namespace shoppingAPP.Models
{
    public class ProductModel
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public string pCatergory { get; set; }
        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }

        static List<ProductModel> pList = new List<ProductModel>()
        {
            new ProductModel(){ pId=101, pName="Pepsi", pCatergory="Cold-Drink", pIsInStock=true, pPrice=50},
            new ProductModel(){ pId=102, pName="Coke", pCatergory="Cold-Drink", pIsInStock=true, pPrice=50},
            new ProductModel(){ pId=103, pName="Maggie", pCatergory="Fast-food", pIsInStock=false, pPrice=50},
            new ProductModel(){ pId=104, pName="Pasta", pCatergory="Fast-food", pIsInStock=true, pPrice=50},
            new ProductModel(){ pId=105, pName="IPhone", pCatergory="Electronics", pIsInStock=true, pPrice=50},
            new ProductModel(){ pId=106, pName="Air-Pods", pCatergory="Electronics", pIsInStock=false, pPrice=50},
            new ProductModel(){ pId=107, pName="Dell Lattitude", pCatergory="Electronics", pIsInStock=true, pPrice=50},
        };

        public List<ProductModel> GetProductsList()
        {
            return pList;
        }


    }
}
