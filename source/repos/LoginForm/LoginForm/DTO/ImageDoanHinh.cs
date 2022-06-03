using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class ImageDoanHinh
    {
        [Key]
        public  string id;
        public string url;
        public string content;
    }
}
