namespace shoppingAPP.Models
{
    public class ProductsModel
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public double pPrice { get; set; }
        public string pCategory { get; set; }
        public bool pIsInStock { get; set; }

        static List<ProductsModel> pList = new List<ProductsModel>()
        {
            new ProductsModel(){ pId=101, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new ProductsModel(){ pId=102, pName="Coke", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new ProductsModel(){ pId=103, pName="IPhone", pCategory="Electronics", pIsInStock=false, pPrice=50000},

        };

        public List<ProductsModel> GetAllProducts()
        {
            return pList;
        }

        public List<ProductsModel> GetAllProductsByCategory(string category)
        {

            var product = (from p in pList
                           where p.pCategory == category
                           select p).ToList();
            return product;
        }

        public ProductsModel GetProductById(int productId)
        {
           
            
                var product = (from p in pList
                               where p.pId == productId
                               select p).Single();
                return product;
           
           
        }

        public string AddProduct(ProductsModel newProduct)
        {
            pList.Add(newProduct);
            return "Product Added Successfully";
        }

        public string DeleteProduct(int productId)
        {

            var product = (from p in pList
                           where p.pId == productId
                           select p).Single();
            pList.Remove(product);
            return "Product Removed Successfully";
        }

        public string UpdateProduct(ProductsModel productupdate)
        {

            var product = (from p in pList
                           where p.pId == productupdate.pId
                           select p).Single();

            product.pName = productupdate.pName;
            product.pCategory = productupdate.pCategory;
            product.pPrice = productupdate.pPrice;
            product.pIsInStock = productupdate.pIsInStock;

            return "Product Updated";
        }

    }
}
