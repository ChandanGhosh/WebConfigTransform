using System;
using System.IO;
using WebConfigTransform.Core;

namespace WebConfigTransform.Con
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = Path.Combine(Environment.CurrentDirectory, @"TestData\Web.Config");
            var transformFile = Path.Combine(Environment.CurrentDirectory, @"TestData\Web.Debug.Config");
            var output = Path.Combine(Environment.CurrentDirectory, @"TestData\Transformed\");
            var outputFileName = "Web.Config";
            var res = WebConfigTransformer.Transform(config, transformFile, output, outputFileName);
            Console.WriteLine(res);
        }
    }
}
