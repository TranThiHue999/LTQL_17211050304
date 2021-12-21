namespace LTQL_17211050304.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_1
    {
        [Key]
        [StringLength(10)]
        public string hue { get; set; }
    }
}
