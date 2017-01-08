using System;
using System.IO;

namespace Recipe05.Services
{
    public class HitCounterService : IHitCounterService
    {
        private string _rootPath;

        public HitCounterService(string rootPath)
        {
            _rootPath = rootPath;
        }

        public int UpdateCount()
        {
            var hitCountFilePath = "\\Services\\hitcount.txt";
            var fullPath = string.Concat(_rootPath, hitCountFilePath);
            var count = int.Parse(File.ReadAllText(fullPath));
            count++;
            File.WriteAllText(fullPath, count.ToString());

            return count;
        }
    }
}
