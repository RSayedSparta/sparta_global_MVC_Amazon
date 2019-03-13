using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace AmazonMVC.Models
{
    public class Products
    {
        private string pName;
        private string pDescription;
        private double pPrice;

        public string PName { get => pName; set => pName = value; }
        public string PDescription { get => pDescription; set => pDescription = value; }
        public double PPrice { get => pPrice; set => pPrice = value; }

        public Products()
        {

        }

        public Products(string name, string description, double price)
        {
            pName = name;
            pDescription = description;
            pPrice = price;
        }

        public void saveData()
        {
            using (StreamWriter sw = new StreamWriter("PrductData.txt"))
            {
                sw.WriteLine(pName + "," + pDescription + "," + pPrice );
            }
        }
    }
}