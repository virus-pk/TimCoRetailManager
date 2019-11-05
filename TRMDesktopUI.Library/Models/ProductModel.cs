namespace TRMDesktopUI.Library.Models
{
    public class ProductModel
    {
        /// <summary>
        /// Unique identifier for products model.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of the product available for selling.
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// Description of the item available in products.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The retail price is the final price that a good is sold to customers for.
        /// </summary>
        public decimal RetailPrice { get; set; }
        /// <summary>
        /// Remaining items in the stock.
        /// </summary>
        public int QuantityInStock { get; set; }
        /// <summary>
        /// Identifies if the item is taxable or not.
        /// </summary>
        public bool IsTaxable { get; set; }
    }
}
