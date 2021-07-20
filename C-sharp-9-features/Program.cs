using System;
using System.Collections.Generic;

namespace C_sharp_9_features
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Init Only Demo
            InitOnlyDemo initOnlyDemo = new InitOnlyDemo
            {
                A = 10,
                B = 20
            };

            Console.WriteLine($"A: {initOnlyDemo.A}, B = {initOnlyDemo.B}");

            //initOnlyDemo.A = 100; // Will throw Error because it will be only initialized during initialization
            initOnlyDemo.B = 200;
            Console.WriteLine($"A: {initOnlyDemo.A}, B = {initOnlyDemo.B}");

            Console.WriteLine("\n*** Record Demo ***\n");


            // Record Demo
            var recordDemo = new RecordDemo(10, 20);

            Console.WriteLine($"A: {recordDemo.A}, B = {recordDemo.B}, C: {recordDemo.C}");

            // Below will give error because record properties are by default init-only and can not be re initialized 
            //recordDemo.A = 100;
            //recordDemo.B = 200;
            //recordDemo.C = 300;

            var newRecordDemo = recordDemo with { A = 20, B = 30 };
            Console.WriteLine($"A: {newRecordDemo.A}, B = {newRecordDemo.B}, C: {newRecordDemo.C}");

            Console.WriteLine("\n*** Fit and FInish Demo ***\n");

            List<int> intCollection = new();
            Console.WriteLine(intCollection.Count);
            Console.WriteLine(GetCollection().Count);

            Console.ReadLine();
        }

        public static List<string> GetCollection()
        {
            return new();
        }
    }
}
