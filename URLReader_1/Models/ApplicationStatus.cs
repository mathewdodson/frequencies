using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace URLReader.Models
{
    public class ApplicationStatus
    {
        [Key]
        [Display(Name = "ID")]
        public string WebAppID { get; set; }
        [Display(Name = "Time Execution")]
        public DateTime ExecutedTime { get; set; }

        public bool Success { get; set; }

        [Display(Name = "Task Time")]
        public DateTime TaskTime { get; set; }

        [Display(Name = "Health Status")]
        public string HealthStatus { get; set; }

        [Display(Name = "Response Time")]
        public DateTime HSResponseTime { get; set; }
    }
}
