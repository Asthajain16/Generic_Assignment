using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2
{
   public  class Program

    {
    
        
      


        static void Main(string[] args)
        {
            
            List<Product> list1 = new List<Product>() 
            {
                 new Product(){ Name="lettuce", Price=10.5,Quantity=50,Type="Leafy green"},
                 new Product(){ Name="cabbage", Price=20,Quantity=100,Type="Cruciferous"},
                 new Product(){ Name="pumpkin", Price=30,Quantity=30,Type="Marrow"},
                 new Product(){ Name="cauliflower", Price=10,Quantity=25,Type="Cruciferous"},
                 new Product(){ Name="zucchini", Price=20.5,Quantity=50,Type="Marrow"},
                 new Product(){ Name="yam", Price=30,Quantity=50,Type="Root"},
                 new Product(){ Name="spinach", Price=10,Quantity=100,Type="Leafy green"},
                 new Product(){ Name="broccoli", Price=20.2 ,Quantity=75,Type="Cruciferous"},
                 new Product(){ Name="garlic", Price=30 ,Quantity=20,Type="Leafy green"},
                 new Product(){ Name="silverbeet", Price=10,Quantity=50,Type="Marrow"}
            };
            //priting total products
            Console.WriteLine("\nTotal number of products in the List:-{0}\n", list1.Count);

            //Adding Potato and cacculating total number of Products
            Console.WriteLine("After adding new product");
            list1.Add(new Product() { Name = "potato", Price = 10, Quantity = 50, Type = "Root" } );
            Console.WriteLine(" Total number of Products in list:-{0}\n", list1.Count);
            
            //Products having type leafy green
            foreach (var item in list1)
                Console.WriteLine(item);
            Console.WriteLine("\nProducts having type Leafy Green:");
            foreach (var item in list1)
            {
                if (item.Type.Equals("Leafy green"))
                    Console.WriteLine(item);
            }
            
            //After removing garlic total number of products
            var itemToRemove = list1.Single(r => r.Name == "garlic");
            list1.Remove(itemToRemove);
            Console.WriteLine("\nTotal number of Product after removing Garlic:-{0}\n", list1.Count);
            Console.WriteLine("\nTotal number of cabbages after adding 50");


            //After adding 50 cabbages
            foreach (var item in list1)
            {
                if (item.Name.Equals("cabbage"))
                {
                    int a = item.Quantity + 50 ;
                    item.Quantity = a;
                    Console.WriteLine(item);
                }
                    
            }

            //Round off figure if user purchases 1kg lettuce,2kg zucchini,1 kg broccoli
            
            var t1 =list1.Find(r=>r.Name=="lettuce");
            var t2 =list1.Find(r=>r.Name=="zucchini");
            var t3 =list1.Find(r=>r.Name=="broccoli");

            var total=t1.Price+(2*t2.Price)+t3.Price;
             Console.WriteLine("\nAfter purchasing 1 kg lettuce,2 kg zucchini, 1kg broccoli Rounded Value:-{0}",total);











        }
    } 
}