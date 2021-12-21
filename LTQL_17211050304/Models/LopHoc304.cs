using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_17211050304.Models
{ 
    [Table("LopHoc304")]
    public class LopHoc304
    {
        [Key]
        [Display (Name = "LopHoc")]
        public string MaLop { get; set; }
        public ICollection<SinhVien304> SinhVien304s { get; set; }
    }
}