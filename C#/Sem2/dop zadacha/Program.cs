// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
class Program
{    public static void Main()
    {
        try
        {
            // Open the text file using a stream reader.
            using (var sr = new StreamReader("INPUT.TXT"))
            {   
                string file = sr.ReadToEnd();
                string[] parameters = file.Split("\r\n");
                int count = int.Parse(parameters[0]);
                string row = parameters[1];
                int heightPeter = int.Parse(parameters[2]);
                string[] rowSplitted = new string[count];
                rowSplitted = row.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                int result = 0;

                for (int i = 0; i < count; i++){
                    result = result + 1;
                    if (int.Parse(rowSplitted[i]) < heightPeter) {
                        File.WriteAllText("OUTPUT.TXT", result + Environment.NewLine);
                        return;
                    }  
                }
                File.WriteAllText("OUTPUT.TXT", (result+1) + Environment.NewLine);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}