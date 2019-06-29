using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CourseManager.Models
{
    public partial class ActionLinks
    {
        [Key]
        [Required]
        public int id { get; set; }
        [StringLength(20)]
        [Display(Name = "名称")]
        public string Name { get; set; }
        [StringLength(20)]
        [Display(Name = "控制器")]
        public string Controller { get; set; }
        [StringLength(20)]
        [Display(Name = "动作")]
        public string Action { get; set; }
        [Display(Name = "序号")]
        public Nullable<int> order { get; set; }
    }
}
