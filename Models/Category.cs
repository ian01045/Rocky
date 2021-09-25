using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("類別名稱")]
        public string Name { get; set; }

        [DisplayName("展示順序")]
        public int DisplayOrder { get; set; }
    }
}
