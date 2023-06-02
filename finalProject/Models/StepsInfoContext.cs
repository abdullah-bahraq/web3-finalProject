using Microsoft.EntityFrameworkCore;

namespace finalProject.Models
{
	public class StepsInfoContext : DbContext
	{
		public StepsInfoContext(DbContextOptions<StepsInfoContext> options) : base(options) 
		{
					
		}

		public DbSet<StepInfo> StepInformation { get; set; }
	}
}
