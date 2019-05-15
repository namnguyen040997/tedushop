using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tedushop.Model.Abstract;

namespace Tedushop.Model.Model
{
    [Table("ProductCategories")]
    public class ProductCategory:Auditable
    {
        [Key]
        //Set ID tự tăng
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; } //Bí danh, biệt hiệu

        public string Description { get; set; }
        public int? ParentID { get; set; }
        public int? DisplayOrder { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }
}
