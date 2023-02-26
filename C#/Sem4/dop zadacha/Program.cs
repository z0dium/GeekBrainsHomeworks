// Дополнительная задача 4 семинар
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
                int number = int.Parse(parameters[0]);
                int[] array = arrayFromString(parameters[1]);
                int count = int.Parse(parameters[2]);
                Console.WriteLine(number & ' ' & array.Length & ' ' & count);
                using (StreamWriter sw = File.AppendText("OUTPUT.TXT")) {
                    for (int i = 3; i < 3 + count; i++){
                        string action = parameters[i];
                        string[] command = action.Split(' ');
                        switch (command[0]){
                            case "get":
                                sw.WriteLine(get(int.Parse(command[1]),array));
                                break;
                            case "update":
                                update(int.Parse(command[1]),int.Parse(command[2]),int.Parse(command[3]),array);
                                break;
                            case "add":
                                add(int.Parse(command[1]),int.Parse(command[2]),int.Parse(command[3]),array);
                                break;
                            case "rsq":
                                sw.WriteLine(rsq(int.Parse(command[1]),int.Parse(command[2]),array));
                                break;
                            case "rmq":
                                sw.WriteLine(rmq(int.Parse(command[1]),int.Parse(command[2]),array));
                                break;
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

    static int[] arrayFromString(string text){
        string[] textArray = text.Split(' ');
        int[] result = new int[textArray.Length];
        for (int i=0; i< textArray.Length; i++){
            result[i] = int.Parse(textArray[i]);
        }
        return result;
    }

    static int get(int i, int[] array){
        return array[i];
    }

    static void update(int l,int r,int x, int[] array){
        for (int i=l-1; i<=r-1; i++){
            array[i] = x;
        }
    }

    static void add(int l,int r,int x, int[] array){
        for (int i=l-1; i<=r-1; i++){
            array[i] += x;
        }
    }

    static int rsq(int l,int r, int[] array){
        int result = 0;
        for (int i=l-1; i<=r-1; i++){
            result = result + array[i];
        }
        return result;
    }

    static int rmq(int l,int r, int[] array){
        int result = array[l];
        for (int i=l-1; i<=r-1; i++){
            if (result > array[i]) result = array[i];
        }
        return result;
    }
}