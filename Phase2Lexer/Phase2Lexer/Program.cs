using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase2Lexer
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string text = File.ReadAllText("pythonFile.txt");
                Lexer lex = new Lexer();
                lex.Parse(text);

                while (text != null)
                {
                    text = text.Trim(' ', '\t');
                    string token = lex.GetNextLexicalAtom(ref text);
                    Console.Write(token);
                }
            }
            catch (Exception)
            {

               
            }
           

        }
    }
}
