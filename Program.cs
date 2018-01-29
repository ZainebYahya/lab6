using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lab6a
{
    class Program
    {
        static void Main(string[] args)

        {
            string temp="";
            Console.WriteLine(" Welcom to the Pig Latin Translater! " + "\n");
            
           
            

                string line = "",words="";
            do
            {
                Console.Write("Enter a line to be translated:     ");
                line = Console.ReadLine();
                Console.WriteLine();
                string[] arrayword = line.Split(' ');
                temp = arrayword.ToString();
                string[] newarray = new string[temp.Length];

                foreach (string wordtemp in arrayword)

                {

                    words = (Piglatintranslater(wordtemp));
                    Console.Write($"{words}" + " ");

                }
                Console.WriteLine('\n');
            }
            while (Countinuquestion());
            
                Console.WriteLine("Bye!");
            




        }


        public static string ConvertToOrigincase(string word, string newword)
        {
            string newwordorigin = "";
            if (word.All(char.IsLower))
            {
                return newword;
            }
            else
            {
                if (word.All(char.IsUpper))
                {
                    newwordorigin = newword.ToUpper();
                    return newwordorigin;
                }
                else
                {

                    newwordorigin = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(newword);
                    return newwordorigin;
                }




            }

        }



        public static string Piglatintranslater(string word)
        {

            string sub = "", copy = "", origincase = "", piglatin = ""; string add = "way";
            int length = 0;
            char[] vowel = { 'a', 'A', 'E', 'O', 'U', 'I', 'e', 'o', 'u', 'i' };
            length =word.Length;


            int temp = 0;
            

            for (int index = 0; index < length; index++)
            {
               
                temp = word.IndexOfAny(vowel);

                
            }
            if ((word.Any(char.IsDigit) || (word.Any(char.IsSymbol))))
            {
                return word;
            }

           
            else if (temp == 0)
            {
                piglatin = word + add;
                origincase = ConvertToOrigincase(word, piglatin);
                return origincase;

            }
            else
            {
                sub = word.Substring(0, temp);
                copy = word.Substring(temp, length - temp);
                piglatin = copy + sub + add;
                origincase = ConvertToOrigincase(word, piglatin);
                return origincase;



            }

            
            
             

            
               


            




        }


        public static bool Countinuquestion()
        {
            string answer = ""; bool flag = true;
            Console.Write("translate another line?(y/n):    ");
            answer = Console.ReadLine();
            if (answer == "n" || answer == "N")
            {

                flag = false;
                return flag;


            }
            else if (answer == "y" || answer == "Y")



                return flag;

            else
            {
                Console.Write("try again invalid input   ");
                return Countinuquestion();

            }

        }

    }
}
