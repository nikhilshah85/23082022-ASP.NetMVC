namespace DI_Demo.Models
{
    public class Products
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public int pPrice { get; set; }
        public bool pIsInStock { get; set; }

        private static List<Products> pList = new List<Products>()
        {
            new Products(){ pId=101, pName="Pepsi", pCategory="Cold-Drinks", pIsInStock=true, pPrice=50  },
            new Products(){ pId=102, pName="Coke", pCategory="Cold-Drinks", pIsInStock=true, pPrice=70  },
            new Products(){ pId=103, pName="Iphone", pCategory="Electronics", pIsInStock=false, pPrice=50000  },
            new Products(){ pId=104, pName="Air-pods", pCategory="Electronics", pIsInStock=true, pPrice=12000  },
        };

        public  List<Products> ShowProducts()
        {
            return pList;
        }


        public string AddProduct(Products newProduct)
        {
            pList.Add(newProduct);
            return "Product Added Successfully";
        }
    }
}
