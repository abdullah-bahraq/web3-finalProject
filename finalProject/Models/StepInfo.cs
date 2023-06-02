using System.ComponentModel.DataAnnotations;

namespace finalProject.Models
{
	public class StepInfo
	{
        public int number { get; set; }
        [Key]
        public DateTime time { get; set; }
    }
}
