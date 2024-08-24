namespace Wipro_API_ProductService.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductQuantity { get; set; }

        public int ProductPrice { get; set; }

    
        public int ProductTotalAmount
        {
            get
            {
                return ProductQuantity * ProductPrice;
            }
            set {; }
        }
    }
}
