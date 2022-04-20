
using System.ComponentModel.DataAnnotations.Schema;

namespace TestMVC.DomainModels.Models
{
    public class Agreement : BaseClass
    {
        public int ProductGroupId { get; set; }

        [ForeignKey("ProductGroupId")]
        public virtual ProductGroup? ProductGroup { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product? Product { get; set; }

        public DateTime EffectiveDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public Guid CreatedByUserId { get; set; }

        public float NewPrice { get; set; }
    }
}
