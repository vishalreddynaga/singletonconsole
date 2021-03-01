using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SINGLETON
{
    /*
     *  Sealed ensures the class being inherited and
     *  object instantiation is restricted in the derived class
     */
    //public sealed class Singletonn
    public class Singletonn
    {
        // private static int counter = 0;
        public static int counter = 0;

        /*
         * Private property initilized with null
         * ensures that only one instance of the object is created
         * based on the null condition
         */
        //  private static Singletonn instance = null;

        /*
         * public property is used to return only one instance of the class
         * leveraging on the private property
         */
        // public static Singletonn GetInstance
        // {
        //     get
        //     {
        //         if (instance == null)
        //             instance = new Singletonn();
        //         return instance;
        //     }
        // }
        /*
         * Private constructor ensures that object is not
         * instantiated other than with in the class itself
         */
        //  private Singletonn()

        public Singletonn()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        /*
         * Public method which can be invoked through the singleton instance
         */
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}