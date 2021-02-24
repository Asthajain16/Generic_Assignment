using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2
{
   public  class Product

    {
    
        string ProdutName;
        double ProdutPrice;
        int ProdutQuantity;
        string ProdutType;


        public int Quantity
        {
            get
            {
                  return ProdutQuantity;
            }
            set 
            {
                 ProdutQuantity = value; 
            }
        }

        public string Name
        {
            get 
            { 
                return ProdutName; 
            }
            set 
            { 
                ProdutName = value; 
            }
        }
        public double Price
        {
            get 
            { 
                return ProdutPrice; 
            }
            set 
            { 
                ProdutPrice = value; 
            }
        }
        public string Type
        {
            get 
            { 
                return ProdutType; 
            }
            set 
            { 
                ProdutType = value; 
            }
        }
        public override string  ToString()
        {
            return "Name:-" + Name + " " +"Price:-"+ Price+" RS"+" "+"Quantity:-"+Quantity+" "+"Type:-"+Type;
        }
    }
}