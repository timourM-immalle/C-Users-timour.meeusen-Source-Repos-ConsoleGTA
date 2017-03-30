using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGTA
{
    public class Console2
    {
        public static void Write(string str, ConsoleColor kleur)
        {
            Console.ForegroundColor = kleur;
            Console.Write(str);
            Console.ResetColor();
        }

        public static void WriteLine(string str, ConsoleColor kleur)
        {
            Console2.Write(str, kleur);
            Console.WriteLine();
        }

        enum LexerState
        {
            BEFORE,
            ACCENTED,
            AFTER,
            FIRST_OPENING_BRACE,
            SECOND_OPENING_BRACE,
            FIRST_CLOSING_BRACE,
            SECOND_CLOSING_BRACE
        }

        //Parset een Mustacheachtige (= met "{}") template-string (met max. 1 parameter) en print deze op de console met de parameter in "de" geaccentueerdeKleur.
        public static void Write(string str, ConsoleColor basiskleur, ConsoleColor geaccentueerdeKleur)
        {
            string voor = "";
            string geaccentueerd = "";
            string na = "";
            LexerState ps = LexerState.BEFORE;

            foreach (char c in str)
            {
                switch (ps)
                {
                    case LexerState.BEFORE:
                        if (c != '{')
                        {
                            voor += c;
                        }
                        else
                        {
                            ps = LexerState.FIRST_OPENING_BRACE;
                        }
                        break;
                    case LexerState.FIRST_OPENING_BRACE:
                        if (c == '{')
                        {
                            ps = LexerState.SECOND_OPENING_BRACE;
                        }
                        else
                        {
                            ps = LexerState.BEFORE;
                            voor += '{';
                            voor += c;
                        }
                        break;
                    case LexerState.SECOND_OPENING_BRACE:
                        if (c == '}')
                        {
                            ps = LexerState.FIRST_CLOSING_BRACE;
                        }
                        else
                        {
                            ps = LexerState.ACCENTED;
                            geaccentueerd += c;
                        }
                        break;
                    case LexerState.ACCENTED:
                        if (c == '}')
                        {
                            ps = LexerState.FIRST_CLOSING_BRACE;
                        }
                        else
                        {
                            geaccentueerd += c;
                        }
                        break;
                    case LexerState.FIRST_CLOSING_BRACE:
                        if (c == '}')
                        {
                            ps = LexerState.SECOND_CLOSING_BRACE;
                        }
                        else
                        {
                            geaccentueerd += '}';
                            geaccentueerd += c;
                        }
                        break;
                    case LexerState.SECOND_CLOSING_BRACE:
                        ps = LexerState.AFTER;
                        na += c;
                        break;
                    case LexerState.AFTER:
                        na += c;
                        break;
                }
            }

            Console2.Write(voor, basiskleur);
            Console2.Write(geaccentueerd, geaccentueerdeKleur);
            Console2.Write(na, basiskleur);
        }

        public static void WriteLine(string str, ConsoleColor basiskleur, ConsoleColor geaccentueerdeKleur)
        {
            Console2.Write(str, basiskleur, geaccentueerdeKleur);
            Console2.WriteLine(str, basiskleur, geaccentueerdeKleur);
        }
    }
}