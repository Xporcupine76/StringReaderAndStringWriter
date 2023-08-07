using System;
using System.Text;

namespace StringReaderAndStringWriter
{
    class Program
    {


        static void Main(string[] args)
        {

            StringReadWrite srw = new StringReadWrite();

        }

        #region
         void StringReadWriter(string input)
        {
            WriteData();
            ReadData();


        }
        #endregion
        public void WriteData()
        {

            StringWriter sw = new StringWriter();
            Console.WriteLine("olease enter first and last name...");
            string name = Console.ReadLine();

            sw.WriteLine("Name: "+ name);
            sw.Flush();
            sw.Close();

        }
       

    }


}