namespace ProductsApi.dtos
{
    public class UpdateProductDto
    {
        public string Name { get; set; }
        public string Description { get;set;}
        public string Link { get;set;}
        public decimal Price { get; set; }
        
    }
}