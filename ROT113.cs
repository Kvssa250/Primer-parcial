using System;

namespace ROT113
{
    class Program
    { 
        static void Main(string[] args) 
        {
            //Pide al usuario el codigo que va a ser evaluado
            Console.WriteLine("Ingrese su cadena codificada (todo en mayusculas): ");
            string code = Console.ReadLine();
            char[] letter;
            letter = code.ToCharArray();

            //Crea la lista con las letras en mayusculas
            List<string> letters = new List<string>();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                letters.Add(i.ToString());
            }

            //Crea la lista con la posicion original + 13
            List<string> lettersplus13 = new List<string>();
            for (char x = 'N'; x <= 'Z'; x++)
            { 
                lettersplus13.Add(x.ToString());
            }
            for (char y = 'A'; y <= 'M'; y++)
            { 
                lettersplus13.Add(y.ToString());
            }

            //Cambia las letras
            List<string> final = new List<string>();
            foreach (char x in letter)
            {
                string eachletter = x.ToString();
                if (x >= 'A' && x <= 'Z')
                {
                    int lugar1 = letters.IndexOf(eachletter);
                    string otherletter = lettersplus13[lugar1];
                    final.Add(otherletter);
                }
                else
                {
                    final.Add(eachletter);
                }
            }

            char coma = ',';
            string result = String.Join(coma, final);
            string finalresult = result.Replace(",", "");
            Console.WriteLine(finalresult);
        }
    }
}