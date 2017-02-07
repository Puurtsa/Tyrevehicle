using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lab05Teht01();
        }
   
    static void Lab05Teht01()
{
    //Programmed and tsted by Esa 7.2.2017
    //testataan Tyre ja vehicle luokkia
    //luodaan auto
    Vehicle auto = new JAMK.IT.Vehicle();
    auto.Brand = "BMW";
    auto.Model = "320";

    Tyre rinkula = new Tyre();
    rinkula.branch = "Hankook";
    rinkula.Size = "205/55R16";
    auto.AddTyre(rinkula);
    auto.AddTyre(rinkula);

    Console.WriteLine("Autossasi {0} on seuraavat tiedot: {1}", auto.Brand, auto.ToString());
        }
    }
}