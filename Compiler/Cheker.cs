
using System;
using System.Text;
using System.IO;

class Game
{
    static void Main()
    {
        int countline = 0;
        int countlex = 0;
        string output;
        string lexemtype = "";
        int IsSeparator = -1;
        int IsKeyWord = -1;
        int SepinString = -1;
        string[] separators = { "+", "-", "*", "/", ".", ",", ":", ";", "=", "<", ">", "<=", ">=", ":=", "..", "(",")", ",", "[","]" };
        string[] KeyWords = { "program", "var", "integer", "real", "bool", "begin", "end", "if", "then", "else", "while", "do", "read", "write", "true", "false" };
       // StreamReader hin = new StreamReader("output1.txt");
        foreach (string line in System.IO.File.ReadLines(@"input1.txt"))
        {
            string newline = line.Replace("    ", "");
            string[] lexems = newline.Split(' ');
            countline++;
            string lexema = "";
            for (int k = 0; k < lexems.Length; k++)
            {
                for (int m = 0; m < lexems[k].Length; m++){
                    IsSeparator = Array.IndexOf(separators, lexems[k][m]);
                    if (IsSeparator != -1)
                    {
                        lexemtype = "Separator";

                        countlex++;
                        break;
                    }
                    else {
                        lexema = lexema + lexems[k][m];
                        IsSeparator = Array.IndexOf(separators, lexema);
                        IsKeyWord = Array.IndexOf(KeyWords, lexema);
                        if (IsKeyWord != -1)
                        {
                            lexemtype = "KeyWord";
                            countlex++;
                            IsKeyWord = -1;
                            
                            break;
                        }
                        else if (IsSeparator != -1)
                        {
                            lexemtype = "Separator";
                            countlex++;
           
                            IsSeparator = -1;
                            
                            break;
                        }
                        if (int.TryParse(lexema, out int numberint))
                        {
                            //Console.WriteLine("Вы ввели число {0}", numberint);
                            lexemtype = "integer";
                            countlex++;

                            break;
                        }
                        else if (float.TryParse(lexema, out float numberfloat))
                        {
                            lexemtype = "float";
                            countlex++;

                            break;
                        }
                        
                        else
                        {
                            lexemtype = "string";
                        }
                    }
                    
                    

                }

                Console.WriteLine(countline.ToString() + ' ' + (countlex + 1).ToString() + ' ' + lexemtype + ' ' + lexema);
                IsKeyWord = -1;
                IsSeparator = -1;
                lexema = "";

            }

           
        }
    }
}


