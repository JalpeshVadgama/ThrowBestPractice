using System;

namespace ThrowBestPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DevideByZero();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        static int DevideByZero()
        {
            try
            {
                int i = 10;
                int j = 0;
                return i / j;
            }
            catch (Exception)
            {
                // write code handle the exception

                //Never use throw(ex as it will hide your actual exception)
                throw;
            }
        }
    }
}
