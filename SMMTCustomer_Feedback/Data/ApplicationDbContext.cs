using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SMMTCustomer_Feedback.Models;

namespace SMMTCustomer_Feedback.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<SMMTCustomer_Feedback.Models.CustFeedback> CustFeedback { get; set; } = default!;
    }
}
