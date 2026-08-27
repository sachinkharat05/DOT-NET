namespace com.transflower.catalog.entities
{
    public class Product
    {

        //encapsulated data members  (non static)
        private int id;
        private string title;
        private string description;
        private decimal price;
        private int stock;
        private int likes;

        //getter and setter methods for data members
        public void SetId(int id)
        {

            this.id = id;
        }
        public int GetId()
        {
            return this.id;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }
        public string GetTitle()
        {
            return this.title;
        }
        public void SetDescription(string description)
        {
            this.description = description;
        }
        public string GetDescription()
        {
            return this.description;
        }
        public void SetPrice(decimal price)
        {
            this.price = price;
        }
        public decimal GetPrice()
        {
            return this.price;
        }


        public void SetStock(int stock)
        {
            this.stock = stock;
        }
        public int GetStock()
        {
            return this.stock;
        }

        public void SetLikes(int likes)
        {
            this.likes = likes;
        }
        public int GetLikes()
        {
            return this.likes;
        }


        //constructor to initialize the data members of the class

        //Construcor overloading - multiple constructors with different parameters
        //default constructor
        public Product()
        {
            this.id = 0;
            this.title = "";
            this.description = "";
            this.price = 0.0m;
            this.stock = 0;
            this.likes = 0;
        }

        //parameterized constructor
        public Product(int id, string title, string description, decimal price, int stock, int likes)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.price = price;
            this.stock = stock;
            this.likes = likes;
        }

    
        ~Product()
        {
            //destructor to clean up resources if needed
        }
    }
}