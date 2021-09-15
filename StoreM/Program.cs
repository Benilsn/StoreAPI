using System;
using Store.entities;
using Store.controllers;
using Store.entities.Enum;


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
