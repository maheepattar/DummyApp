using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyApp
{
    class TaskWhenAll
    {
        static void Main()
        {
            IEnumerable<string> items;
            List<string> itemsToBeProcessed = new List<string>(); 
            
            for (int i = 0; i < 50; i++)
            {
                itemsToBeProcessed.Add("Name " + i);
            }

            items = itemsToBeProcessed;
            VeryGoodLoopAsync(items).ConfigureAwait(false);
            Console.ReadLine();
        }

        #region Method 1
        public static Task DoAsync(string item)
        {
            Task.Delay(1000);
            Console.WriteLine($"Item :  {item}");
            return Task.CompletedTask;
        }

        public static async Task BadLoopAsync(IEnumerable<string> items)
        {
            foreach (string item in items)
            {
                await DoAsync(item);
            }
        }
        #endregion

        #region Method 2
        public static async Task GoodLoopAsync(IEnumerable<string> items)
        {
            List<Task> tasksToLoop = new List<Task>();
            foreach (string item in items)
            {
                tasksToLoop.Add(DoAsync(item));
            }

            await Task.WhenAll(tasksToLoop);
        }

        #endregion

        #region Method 3
        public static Task<string> DoAsyncResult(string item)
        {
            Task.Delay(1000);
            Console.WriteLine(item);
            return Task.FromResult(item);
        }

        public static async Task<IEnumerable<string>> VeryGoodLoopAsync(IEnumerable<string> items)
        {
            List<Task<string>> thingstoLoops = new List<Task<string>>();
            foreach (string item in items)
            {
                thingstoLoops.Add(DoAsyncResult(item));
            }

            return await Task.WhenAll<string>(thingstoLoops);
        }

    
        #endregion
    }
}
