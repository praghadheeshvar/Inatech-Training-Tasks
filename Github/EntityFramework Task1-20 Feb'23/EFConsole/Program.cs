using EFConsole.Migrations;
using EFConsole.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
    internal class Program
    {
        public static void InsertProduct()
        {
            using (var dbcon = new ProdContext())
            {
                Product product = new Product();
                product.Name = "Lyril";
                dbcon.Add(product);
                product = new Product();
                product.Name = "Medimix";
                dbcon.Add(product);
                dbcon.SaveChanges();
            }
            return;
        }
        public static void ReadProduct() 
        { 
            using(var dbcon = new ProdContext()) 
            {
                List<Product> prds = dbcon.Products.ToList();
                foreach (Product p in prds) 
                {
                    Console.WriteLine(p.Name+" "+p.Id);
                }
            }
        }
      /*  public static void UpdateProduct()
        {
            using(var dbcon=new ProdContext()) 
            {
                Product? prd = dbcon.Products.Find(5);
                prd.Name = "Pears";
                dbcon.SaveChanges();
            }
        }*/
        //public static void DeleteProduct() 
        //{
        //    using(var dbcon=new ProdContext()) 
        //    {
        //        dbcon.Products.Remove(dbcon.Products.Find(5));
        //        dbcon.SaveChanges();
        //    }
        //}
        public static void InsertBatch()
        {
            using(var db=new ProdContext()) 
            {
                ProductBatch productbatch=new ProductBatch();
                productbatch.BatchID = 1;
                productbatch.Description="Inatech India";
                productbatch.Quantity = 5;
                productbatch.Price = 100;
                //productbatch.Product.ProductFK = 10;
                db.SaveChanges();
            }
        }
        public static void insertstandard()
        {
            using (var dbcon = new ProdContext())
            {
                Standard stan = new Standard();
                stan.StandardName = "EEE";
                dbcon.Add(stan);
                dbcon.SaveChanges();
            }
            return;
        }
        public static void readstandard()
        {
            using (var dbcon = new ProdContext())
            {
                List<Standard> std = dbcon.Standards.ToList();
                foreach (Standard s in std)
                {
                    Console.WriteLine(s.StandardId+" "+s.StandardName);
                }
            }
        }
        public static void insertstudent()
        {
            using(var dbcon=new ProdContext())
            {
                Student stud = new Student();
                stud.StandardRefId = 1;
                stud.StudentName = "Rishab";
                dbcon.Add(stud);
                dbcon.SaveChanges() ;
            }
            return;
        }
        public static void readstudent()
        {
            using(var dbcon=new ProdContext()) 
            {
                List<Student> std=dbcon.Students.ToList();
                foreach(var st in std)
                {
                    Console.WriteLine(st.StudentId+" "+st.StudentName+" "+st.StandardRefId);
                }
            }
        }
        public static void Main(string[] args) 
        {
            //InsertProduct();
            //UpdateProduct();
            //ReadProduct();
            //DeleteProduct();
            //InsertBatch();
            //insertstandard();
            //insertstudent();
            readstandard();
            //readstudent();
            Console.WriteLine("Success");
        }
    }
}
