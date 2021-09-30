using Store.controllers;
using System;

namespace StoreM
{
    class Program
    {
        static void Main(string[] args)
        {

            StaffController sc = new StaffController();
            ProductController pc = new ProductController();

            Console.WriteLine(sc.getById(203051));


        }
    }
}
