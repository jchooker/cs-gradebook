
using System;

namespace GradeBook
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var Book = new Book();
            Book.addGrade(77.2);
            var x = new double[]{67.3, 99.1, 78.5, 89.4};
            Console.WriteLine($"Hello {args[0]}!");
        }
    }

}
