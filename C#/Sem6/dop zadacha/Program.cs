// Дополнительная задача 6 семинар
using System;
using System.IO;
class Program
{    public static void Main()
    {
        Console.Clear();
        try
        {
            using (var sr = new StreamReader("INPUT.TXT"))
            {   
                string[] input = sr.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);
                string[,] directory = new string[n,2];
                for (int i = 0; i < n; i++){
                    directory[i,0] = sr.ReadLine();
                    directory[i,1] = sr.ReadLine() + " (" + sr.ReadLine() + ")";
                }
                
                using (StreamWriter sw = File.AppendText("OUTPUT.TXT")) {
                    for (int i = 0; i < m; i++){
                        string number = sr.ReadLine();
                        for (int j = 0; j < n; j++){
                            if (number == directory[j,0]) {
                                sw.WriteLine(directory[j,1]);
                                break;
                            }        
                        }
                    }
                    
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }  
}