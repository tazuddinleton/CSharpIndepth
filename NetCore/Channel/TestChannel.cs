using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace NetCore.Channel
{

    
    class TestChannel
    {
        public static async Task Main(string[] args)
        {

            await DemoChannel();

        }

        public static async Task DemoChannel()
        {
            var ch = System.Threading.Channels.Channel.CreateUnbounded<string>();

            var t = Task.Run(async () =>
            {
                Console.WriteLine("Printing started...");
                while (await ch.Reader.WaitToReadAsync())
                {
                    await Task.Delay(new Random().Next(1000));
                    var str = await ch.Reader.ReadAsync();
                    Console.WriteLine($"Printed {str}");
                }
                Console.WriteLine("Printing completed!");
            });

            var a = Task.Run(async () =>
            {
                for (var i = 0; i < 10; i++)
                {
                    await Task.Delay(new Random().Next(5000));
                    await ch.Writer.WriteAsync(i.ToString());
                    Console.WriteLine($"Fetched {i}");
                }
                ch.Writer.Complete();
                Console.WriteLine($"Fetched All!");
            });



            

            await Task.WhenAll(t);
        }
    }
}
