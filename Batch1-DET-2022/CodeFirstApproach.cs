using Batch1_DET_2022.Data;
using Batch1_DET_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using Microsoft.EntityFrameworkCore;

namespace Batch1_DET_2022
{
    public class CodeFirstApproach
    {
        static void Main(string[] args)
        {
            // AddNewBook();
            //RemoveBook();
            //UpdateBook();
            //GetAllBookDetails();
            //AddnewcustomerAndOrder();
           //GetAllCustomersWithOrder_EagerLoading();
            GetAllCustomersWithOrder_ExplicitLoading();



            Console.ReadLine();
        }

        private static void GetAllCustomersWithOrder_ExplicitLoading()
        {
            //Explicit loading means that the related data is
            //explicitly loaded from the database at a later time.
            //Needs MARS to be set to TRUE in connection string
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers;

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");


                    ctx.Entry(customer).Collection(o => o.Orders).Load();

                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + " " + order.OrderDate.ToString());


                    }
                    Console.WriteLine("-----");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }






    }




    //private static void GetAllCustomersWithOrder_EagerLoading()
    //    {
    //        var ctx = new BookContext();
    //        try
    //        {
    //            var customers = ctx.Customers.Include("Orders");

    //            //var customers = ctx.Customers.Include(o => o.Orders);

    //            foreach (var customer in customers)
    //            {
    //                Console.WriteLine(customer.Name);
    //                Console.WriteLine("----->");



    //                foreach (var order in customer.Orders)
    //                {
    //                    Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
    //                }
    //                Console.WriteLine("-----");
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }



}
        

        //public static void AddnewcustomerAndOrder()
        //{
        //    var ctx = new BookContext();
        //    Customer customer = new Customer();
        //    customer.ID = 3;
        //    customer.Name = "Abhi";
        //    customer.Age = 22;

        //    Order ord = new Order();
        //    ord.Order_ID = 20;
        //    ord.Amount = 2000;
        //    ord.OrderDate = DateTime.Now;
        //    ord.cust = customer;
            
        //    try
        //    {
        //        ctx.orders.Add(ord);
        //        ctx.SaveChanges();
        //        Console.WriteLine("customer order is created");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
              
        //    }
            
            


        

        //private static void GetAllBookDetails()
        //{
        //    var ctx = new BookContext();
        //    var book = ctx.Books;

        //    try
        //    {
        //        foreach(var b in book)
        //            Console.WriteLine(b.BookName );
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }


        //}

        //private static void UpdateBook()
        //{
        //    var ctx = new BookContext();
        //    var Books = ctx.Books.Where(b => b.BookID == 2).SingleOrDefault();

        //    try
        //    {
        //        Books.BookName = "EFS core";
        //        ctx.Update(Books);
        //        ctx.SaveChanges();
        //        Console.WriteLine(" book updated successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //private static void RemoveBook()
        //{
        //    var ctx = new BookContext();
        //    var Books = ctx.Books.Where(b => b.BookID == 4).SingleOrDefault();  

        //    try
        //    {
        //        Books.BookName = "DF core";
        //        ctx.Remove(Books);
        //        ctx.SaveChanges();
        //        Console.WriteLine("new book removed successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //private static void AddNewBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 1;
        //    book.BookName = "EF core";
        //    book.author = "Jack";
        //    book.price = 100;

        //    Book book1 = new Book();
        //    book.BookID = 4;
        //    book.BookName = "DF core";
        //    book.author = "Henry";
        //    book.price = 200;



        //    try
        //    {
        //        ctx.Books.Add(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("new book added successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}



