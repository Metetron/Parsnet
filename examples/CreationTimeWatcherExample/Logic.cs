using System.Threading.Tasks;
using Parsnet.Abstractions;

namespace CreationTimeWatcherExample
{
    public class Logic : IParser
    {
        public Task ParseFile(string filePath)
        {
            System.Console.WriteLine(filePath);

            return Task.CompletedTask;
        }
    }
}
