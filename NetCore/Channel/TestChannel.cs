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
            
        }

        public static async Task DemoChannel()
        {
            var ch = System.Threading.Channels.Channel.CreateUnbounded<string>();

            var a = Task.Run(async () =>
            {
                for (var i = 0; i < 10; i++)
                {
                    await ch.Writer.WriteAsync(i.ToString());


                    await Task.Delay(new Random().Next(1000));
                }
                ch.Writer.Complete();
            });



            var t = Task.Run(async () =>
            {
                Console.WriteLine("Printing started...");
                while (await ch.Reader.WaitToReadAsync())
                {
                    var str = await ch.Reader.ReadAsync();
                    Console.WriteLine(str);
                }
                Console.WriteLine("Printing completed!");
            });

            await Task.WhenAll(t);
        }
    }
}
