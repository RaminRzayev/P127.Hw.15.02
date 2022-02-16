using System;

namespace P127.HW._15._02
{
    class Program
    {
        static void Main(string[] args)
        {
            string Task = "Confrontation Alley of Fame";
            Console.WriteLine(ChangeLetter(Task));
        }
        public static string ChangeLetter(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
               
                if (str[i]==char.ToUpper(str[i]))
                {
                    char.ToLower(str[i]);
                }
                else
                {
                    char.ToUpper(str[i]);
                }
                
            }
            return str;
        }
    }
}
