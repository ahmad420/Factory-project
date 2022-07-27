namespace FreshFactory
{
   
        class Product
        {
            private int barcode;
            private string name;
            private string description;
            private string category;

            public Product(int barcode, string name)
            {
            this.barcode = 0;   
            this.name = name;
            barcode++;
            }

        public int GetId()
        {
            return this.barcode;
        }
        public string GetName()
        {
            return this.name;
        }
        public string Getdescription()
        {
            return this.description;
        }
        public string Getcategory()
        {
            return this.category;
        }


        public void SetName(string name)
        {
            this.name=name;
        }
        public void SetDescription(string description)
        {
            this.description = description;
        }
        public void SetDCategory(string category)
        {
            this.category = category;
        }


    }
}
