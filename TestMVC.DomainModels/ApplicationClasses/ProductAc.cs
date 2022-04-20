namespace TestMVC.DomainModels.ApplicationClasses
{
    public class ProductAc
    {
        public int Id { get; set; }
        public Guid ProductNumber { get; set; }
        public float Price { get; set; }
        public string ProductDescription { get; set; }
    }
}
