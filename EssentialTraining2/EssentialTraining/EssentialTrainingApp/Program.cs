using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTrainingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void ReadTextFile()
        {
            try
            {
                using (var sr = new StreamReader(@"c:\temp\test.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Cleaning up");
            }
        }
    }
}
