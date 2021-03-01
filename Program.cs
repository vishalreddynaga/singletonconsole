using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINGLETON
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Assuming Singleton is created from employee class
             * we refer to the GetInstance property from the Singleton class
             */
            // Singletonn fromEmployee = Singletonn.GetInstance;
            //  fromEmployee.PrintDetails("From Employee");
            /*
             * Assuming Singleton is created from student class
             * we refer to the GetInstance property from the Singleton class
             */
            // Singletonn fromStudent = Singletonn.GetInstance;
            // fromStudent.PrintDetails("From Student");


            Singletonn s = new Singletonn();
            s.PrintDetails("hi");
            Singletonn ss = new Singletonn();
            ss.PrintDetails("hii");



            Console.ReadLine();



        }
    }
}
