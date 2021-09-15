using Store.entities.Enum;

namespace Store.entities
{
    public class Product
    {

        private long id;
        private string name;
        private double price;
        private int quantity;
        private Category category;

        public Product() { }

        public Product(string name, double price, int quantity, Category category)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
        }

        public long Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Category Category
        {
            get { return category; }
            set { category = value; }
        }

        public string toString()
        {
            return "Name = " + this.name +
                "\nPrice = " + this.price +
                "\nQuantity = " + this.quantity +
                "\nCategory = " + this.category;
        }
    }
}
