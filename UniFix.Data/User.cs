namespace UniFix.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; } 
        public string UserIdCard { get; set; } 

     
        public string? Department { get; set; }
        public string? Year { get; set; }
        public string? Block { get; set; }
        public string? Dorm { get; set; }

        public string? JobTitle { get; set; } 
       
        public int Warnings { get; set; } = 0;
        public bool IsBanned { get; set; } = false;
    }
}