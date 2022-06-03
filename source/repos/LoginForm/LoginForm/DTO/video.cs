using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class video
    {
        [Key]
        public string id { get; set; }

        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string link { get; set; }
        public string luotview { get; set; }
        public string ngaytao { get; set; }
    }
}
