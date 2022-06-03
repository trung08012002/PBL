using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class videotrochoi
    {
        public videotrochoi()
        {
            this.Khoahoc = new khoahoc();
            this.video = new videotrochoi();
        }
        [Key]
        public string id { get; set; }
        public string idkhoahoc { get; set; }
        public string idvideo { get; set; }
        [ForeignKey("idkhoahoc")]
        public virtual videotrochoi video { get; set; }
        public virtual khoahoc Khoahoc { get; set; }

    }
}
