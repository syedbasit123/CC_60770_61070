using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser_Phase3
{
    class Parser
    {

        public Parser()
        {

            syntax = @"while num == 50:$";
            lookAhead = syntax[count];
            CHECK();
            if (lookAhead == '$')
            {
                Console.WriteLine("Parsed Successfully");
            }
            else
            {
                Console.WriteLine("Unsuccesfull Parsed");
            }
        }
        public void CHECK()
        {
            if (lookAhead == 'w')
            {
                Match('w');
                Match('h');
                Match('i');
                Match('l');
                Match('e');
                CONDITION();
                Match(':');

            }
        }

        public char lookAhead;
        public string syntax;
        public int count = 0;
        public bool check = true;
        public void CONDITION()
        {
            if (check == true)
            {

                VARIABLE();
                OPERATOR();
                NUMBER();

            }
        }
        public void X()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (lookAhead == c)
                {
                    VARIABLE();
                    Y();
                }
            }

            for (int c = '0'; c < '9'; c++)
            {
                if (lookAhead == c)
                {
                    NUMBER();
                    Y();
                }
            }
        }
        public void Y()
        {
            if (lookAhead == '|')
            {
                Match('|');
                Match('|');
                CONDITION();
            }
            else if (lookAhead == '&')
            {
                Match('&');
                Match('&');
                CONDITION();
            }
        }
        public void VARIABLE()
        {
            if (check == true)
            {
                for (char c = 'a'; c <= 'z'; c++)
                {


                    if (lookAhead == c)
                    {
                        Match(lookAhead);
                        VARIABLE();
                    }
                }
            }
        }
        public void NUMBER()
        {
            if (check == true)
            {
                for (int c = '0'; c < '9'; c++)
                {
                    if (lookAhead == c)
                    {
                        Match(lookAhead);
                        NUMBER();
                    }
                }
            }
        }
        public void OPERATOR()
        {
            if (check == true)
            {
                if (lookAhead == '>')
                {
                    Match('>');

                    Z();
                }
                else if (lookAhead == '<')
                {
                    Match('<');

                    Z();
                }
                else if (lookAhead == '=')
                {
                    Match('=');

                    Match('=');
                }
                else if (lookAhead == '!')
                {
                    Match('!');

                    Match('=');
                }
                else
                {
                    check = false;
                }
            }
        }
        public void Z()
        {
            if (check == true)
            {
                if (lookAhead == '=')
                {
                    Match('=');
                }
            }
        }
        public void Match(char ch)
        {
            if (check == true)
            {
                if (lookAhead == ch)
                {
                    count++;
                    lookAhead = syntax[count];
                }
                else
                {
                    check = false;
                }
                if (lookAhead == ' ')
                {
                    count++;
                    lookAhead = syntax[count];
                }
            }

        }


    }
}
