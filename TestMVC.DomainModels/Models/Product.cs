using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestMVC.DomainModels.Models
{
    public class Product : BaseClass
    {
        public string ProductDescription { get; set; }

        [Required]
        public Guid ProductNumber { get; set; }

        public float Price { get; set; }

        public int ProductGroupId { get; set; }

        [ForeignKey("ProductGroupId")]
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }

    }
}
