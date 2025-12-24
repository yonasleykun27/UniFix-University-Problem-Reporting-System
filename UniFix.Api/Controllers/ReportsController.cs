using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniFix.Data;

namespace UniFix.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ReportsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Report>>> GetReports()
        {
            return await _context.Reports.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Report>> PostReport(Report report)
        {
            _context.Reports.Add(report);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetReports), new { id = report.Id }, report);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateReport(int id, [FromBody] Report updatedReport)
        {
            if (id != updatedReport.Id) return BadRequest();

            var report = await _context.Reports.FindAsync(id);
            if (report == null) return NotFound();

            if (report.Status != "Pending")
                return BadRequest("Cannot edit a report that is already processed.");

            report.Description = updatedReport.Description;
            report.Category = updatedReport.Category;
            report.Urgency = updatedReport.Urgency;
            report.ReporterPhone = updatedReport.ReporterPhone;
            report.SpecificDetails = updatedReport.SpecificDetails;

            await _context.SaveChangesAsync();
            return NoContent();
        }
 
        [HttpPut("status/{id}")]
        public async Task<IActionResult> UpdateStatus(int id, [FromBody] StatusUpdateDto update)
        {
            var report = await _context.Reports.FindAsync(id);
            if (report == null) return NotFound("Report ID not found");

            if (!string.IsNullOrEmpty(update.Status)) report.Status = update.Status;
            if (update.AssignedTo != null) report.AssignedTo = update.AssignedTo;
            if (update.DeclineReason != null) report.DeclineReason = update.DeclineReason;

            await _context.SaveChangesAsync();
            return Ok(new { message = "Status Updated Successfully" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReport(int id)
        {
            var report = await _context.Reports.FindAsync(id);
            if (report == null) return NotFound();

            _context.Reports.Remove(report);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }

    public class StatusUpdateDto
    {
        public string? Status { get; set; }
        public string? AssignedTo { get; set; }
        public string? DeclineReason { get; set; }
    }
}