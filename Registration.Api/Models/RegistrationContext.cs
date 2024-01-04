
using Microsoft.EntityFrameworkCore;

namespace Registration.Api.Models
{
    public class RegistrationContext:DbContext
    {
        DbSet<Students> Students { get; set; }
        public RegistrationContext(DbContextOptions<RegistrationContext> opt):base(opt) { }

    }
}
