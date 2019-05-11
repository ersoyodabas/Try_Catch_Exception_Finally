using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defaults
            Console.WindowWidth = 160;
            int Number = 10;
            Console.Write(" Please Enter Text : ");


            #region EXCEPTION DETAIL
            try
            {
                Number = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine(" \n  Hata Oluştu !");
                Console.WriteLine(" \n  Data            : "+ex.Data);
                Console.WriteLine(" \n  HelpLink        : "+ex.HelpLink);
                Console.WriteLine(" \n  HResult         : "+ex.HResult);
                Console.WriteLine(" \n  InnerException  : "+ex.InnerException);
                Console.WriteLine(" \n  Message         : "+ex.Message);
                Console.WriteLine(" \n  Source          : "+ex.Source);
                Console.WriteLine(" \n  TargetSite      : " + ex.TargetSite);
                Console.WriteLine(" \n  StackTrace      : ");
                Console.WriteLine(ex.StackTrace);
            }

            #endregion




            #region EXCEPTION CASES WTIH WHEN
            //try
            //{
            //    Number = Convert.ToInt32(Console.ReadLine());

            //}
            //catch (Exception ex) when(ex.Source=="mscorlib")
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion



            #region EXCEPTION CASES
            //try
            //{
            //    Number = Convert.ToInt32(Console.ReadLine());

            //}
            //catch (FormatException){
            //    Console.WriteLine("FormatException");
            //}
            //catch (NullReferenceException){
            //    Console.WriteLine("NullReferenceException");
            //}
            //catch (Exception){
            //    Console.WriteLine("Exception");
            //}
            #endregion


            #region EXCEPTION AND FINALLY
            //try
            //{
            //    Number = Convert.ToInt32(Console.ReadLine());

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Exception");
            //}
            //finally
            //{
            //    Console.WriteLine(Convert.ToInt32(Number));
            //}
            #endregion


            Console.Read();

        }
    }
}
