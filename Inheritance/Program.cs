using Inheritance;
using System;

namespace Inheritance
{

    public interface Iparent
    {
   
        
    }


    }



    class Program
    {
      //  private readonly Iparent _Iparent;
        public Program()
        {
            // _Iparent = new child();
           //  _Iparent = new Iparent();
        }

        public void testing()
        {
           
        }
        static void Main(string[] args)
        {
           parent p = new parent();
       // p.common();


            child c = new child();
      //  c.common();


        parent pp = new child();
        pp.common();
       
         //   (c as parent).common();
            




            Console.ReadKey();
        }
    }

