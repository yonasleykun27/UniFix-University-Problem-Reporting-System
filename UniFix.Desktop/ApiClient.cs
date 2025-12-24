using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using UniFix.Data;

namespace UniFix.Desktop
{
    public class ApiClient
    {
        private readonly HttpClient _client = new HttpClient();

        private string _baseUrl = "http://localhost:5245/api/";

        public async Task<User> LoginAsync(string username, string password)
        {
            var loginData = new { Username = username, Password = password };
            var json = JsonConvert.SerializeObject(loginData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await _client.PostAsync(_baseUrl + "users/login", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<User>(responseString);
                }
                else
                {
                    var errorMsg = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Login Failed: {response.StatusCode}\n{errorMsg}", "Server Error");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection Failed: {ex.Message}", "Network Error");
                return null;
            }
        }

        public async Task<bool> RegisterAsync(User user)
        {
            var content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(_baseUrl + "users/register", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            try
            {
                var response = await _client.GetAsync(_baseUrl + "users");
                if (response.IsSuccessStatusCode)
                    return JsonConvert.DeserializeObject<List<User>>(await response.Content.ReadAsStringAsync());
            }
            catch { }
            return new List<User>();
        }

        public async Task<bool> WarnUserAsync(int id)
        {
            var response = await _client.PutAsync(_baseUrl + $"users/warn/{id}", null);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var response = await _client.DeleteAsync(_baseUrl + $"users/{id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<List<Report>> GetAllReportsAsync()
        {
            try
            {
                var response = await _client.GetAsync(_baseUrl + "reports");
                if (response.IsSuccessStatusCode)
                    return JsonConvert.DeserializeObject<List<Report>>(await response.Content.ReadAsStringAsync());
            }
            catch { }
            return new List<Report>();
        }

        public async Task<bool> AddReportAsync(Report report)
        {
            var content = new StringContent(JsonConvert.SerializeObject(report), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(_baseUrl + "reports", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateReportAsync(Report report)
        {
            var content = new StringContent(JsonConvert.SerializeObject(report), Encoding.UTF8, "application/json");
            var response = await _client.PutAsync(_baseUrl + $"reports/{report.Id}", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteReportAsync(int id)
        {
            var response = await _client.DeleteAsync(_baseUrl + $"reports/{id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateReportStatusAsync(int id, string status, string assignedTo = null, string reason = null)
        {
            var update = new { Status = status, AssignedTo = assignedTo, DeclineReason = reason };
            var content = new StringContent(JsonConvert.SerializeObject(update), Encoding.UTF8, "application/json");

            try
            {
                var response = await _client.PutAsync(_baseUrl + $"reports/status/{id}", content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection Error: {ex.Message}");
                return false;
            }
        }
    }
}