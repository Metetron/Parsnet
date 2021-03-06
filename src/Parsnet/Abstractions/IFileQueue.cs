using System.Collections.Generic;
using System.IO.Abstractions;
using Parsnet.Options;

namespace Parsnet.Abstractions
{
    public interface IFileQueue
    {
        void EnqueueNewFilesForProcessing<T>(WatcherOptions options, IList<IFileInfo> newFiles) where T : IParser, new();
    }
}
