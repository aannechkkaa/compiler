
using System;
using System.Text;
using System.IO;

class Game
{
    static void Main()
    {
        //StreamReader fin = new StreamReader("input1.txt");
        //StreamWriter fout = new StreamWriter("output.txt");

        //string strin = fin.ReadLine();

        //fin.Close();
        int countline = 0;
        int countlex = 0;
        string output;
        string lexemtype;

       // StreamReader hin = new StreamReader("output1.txt");
        foreach (string line in System.IO.File.ReadLines(@"input1.txt"))
        {

            //System.Console.WriteLine(line);
            string[] lexems = line.Split(' ');
            //Console.WriteLine(lexems[1]);
            countline++;
            //Console.WriteLine(countline);
            for (int i = 0; i < lexems.Length; i++)
            {
                countlex = i;
                if (int.TryParse(lexems[i], out int numberint))
                {
                    //Console.WriteLine("Вы ввели число {0}", numberint);
                    lexemtype = "integer";
                    //break;
                }
                else if(float.TryParse(lexems[i], out float numberfloat))
                {
                    lexemtype = "float";
                    //break;
                }
                else
                {
                    lexemtype = "string";
                }
                Console.WriteLine(countline.ToString() +  ' ' + (countlex + 1).ToString() + ' ' + lexemtype + ' ' + lexems[i]);
            }
            

            
        }

        //System.Console.WriteLine("There were {0} lines.", counter);

        //string strout = hin.ReadLine();
       // Console.WriteLine(strin);

        //strin = fin.ReadLine();
        //Console.WriteLine(strin);

        //if (strin == strout)
        //{
        //    Console.WriteLine(strin);
        //}
    }
}
