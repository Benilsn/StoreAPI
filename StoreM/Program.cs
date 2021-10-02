using Store.controllers;
using System;

namespace StoreM
{
    class Program
    {
        static void Main(string[] args)
        {

            StaffRepository sc = new StaffRepository();
            ProductRepository pc = new ProductRepository();

            Console.WriteLine(sc.getById(203051));


        }
    }
}
