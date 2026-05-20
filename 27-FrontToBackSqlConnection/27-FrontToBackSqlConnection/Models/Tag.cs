namespace _27_FrontToBackSqlConnection.Models
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public List<ProductTag> ProductTags { get; set; }
    }
}
