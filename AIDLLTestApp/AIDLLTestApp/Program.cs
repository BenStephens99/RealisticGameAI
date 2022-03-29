using System;
using System.Runtime.InteropServices;

namespace AIDLLTestApp
{
    class Program
    {

        [DllImport(@"C:\Users\BbEeN\Documents\GitHub\RealisticGameAI\RealisticGameAI\Assets\Scripts\AI Engine\x64\Debug\AIEngine.dll")]
        [return: MarshalAs(UnmanagedType.BStr)]
        private static extern string talk(int aS);

        static void Main(string[] args)
        {
             string t = talk(2);

            Console.Write(t);


        }
    }
}
