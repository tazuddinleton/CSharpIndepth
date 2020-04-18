using CSharpIndepth.Generics;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpIndepth.GenericMethods
{
    class TestGenerics
    {
        public static void Main(string[] args)
        {
            var buffer = new CircularBuffer<int>(3);
            var values = new List<int>() { 1, 2, 3 };
            values.ForEach(buffer.Write);

            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine(buffer.Read());
            }

            Console.Read();
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
