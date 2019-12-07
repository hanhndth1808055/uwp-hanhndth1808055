using QualityTest.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityTest
{
    class Program
    {
        public static StudentController studentController = new StudentController();
        static void Main(string[] args)
        {
            for(; ; )
            {
                studentController.GenerateMenu();
            }
        }
    }
}
