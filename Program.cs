// bunfetch-cs developed by florencio
// licensed under the MIT license

using System;
using System.Runtime.InteropServices;

namespace bunfetch
{

    class Program
    {
        static void Main(string[] args)

        {

            var os = Environment.OSVersion;

            Console.WriteLine(" (\\_/)      kernel: {0} {1}\n ( . .)     architecture: {2} \nC(\")(\")", os.Platform.ToString(), os.Version.ToString(), RuntimeInformation.OSArchitecture.ToString());

        }
    }

}