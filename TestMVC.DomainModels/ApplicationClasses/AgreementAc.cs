using System.ComponentModel.DataAnnotations;


namespace TestMVC.DomainModels.ApplicationClasses
{
    public class AgreementAc
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int ProductGroupId { get; set; }
        public Guid ProductGroupCode { get; set; }
        public string? GroupDescription { get; set; }
        public Guid ProductNumber { get; set; }
        public string ProductDescription { get; set; }
        public Guid CreatedByUserId { get; set; }
        public float ProductPrice { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public DateTime EffectiveDate { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public DateTime ExpirationDate { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [DataAnnotationsExtensions.Integer(ErrorMessage = "Please enter a valid number.")]
        public float NewPrice { get; set; }

        public bool IsActive { get; set; }

    }
}
