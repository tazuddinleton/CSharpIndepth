using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpIndepth.GenericMethods
{
    class TestGenerics
    {
        public static void Main(string[] args)
        {
            var result = new Result<int>(true, 100);
            var result2 = new Result<string>(true, "String Data");

            var result3 = new Result<object>(true, new string[] { "Hello", "World" });

                       
            var printer = new ResultPrinter();
            printer.Print(result);
            printer.Print(result2);
            printer.Print(result3);

        }

    }



    public class ResultPrinter
    {
        public void Print<T>(Result<T> result)
        {
            Console.WriteLine(result.Success);
            Console.WriteLine(result.Data);
            Console.ReadLine();
        }
    }

    public class Result<T>
    {
        public Result(bool s, T d)
        {
            Success = s;
            Data = d;
        }
        public bool Success { get; set; }
        public T Data { get; set; }
    }
}
