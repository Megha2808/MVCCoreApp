using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestMVC.DomainModels.Models
{
    public class ProductGroup : BaseClass
    {

        public string GroupDescription { get; set; }

        [Required]
        public Guid GroupCode { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
    }
}
