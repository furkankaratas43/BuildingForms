namespace BuildingForms.Models
{
    public static class ProductRepository
    {
        private static List<Product> _products;

        static ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product { Id = 1, Name = "Product 1", Description = "Description 1", Price = 1000, isApproved = true},
                new Product { Id = 2, Name = "Product 2", Description = "Description 2", Price = 2000, isApproved = false},
                new Product { Id = 3, Name = "Product 3", Description = "Description 3", Price = 3000, isApproved = false},
                new Product { Id = 4, Name = "Product 4", Description = "Description 4", Price = 4000, isApproved = false},
                new Product { Id = 5, Name = "Product 5", Description = "Description 5", Price = 5000, isApproved = true},
                new Product { Id = 6, Name = "Product 6", Description = "Description 6", Price = 6000, isApproved = true},
                new Product { Id = 7, Name = "Product 7", Description = "Description 7", Price = 7000, isApproved = true}
            };

        }

        public static List<Product> Products
        {
            get { return _products; }
        }

        public static void AddProduct(Product entry)
        {
            _products.Add(entry);
        }

    }
}