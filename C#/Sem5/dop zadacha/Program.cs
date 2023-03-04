// Дополнительная задача 5 семинар
using System;
using System.IO;
class Program
{    public static void Main()
    {
        Console.Clear();
        try
        {
            // Open the text file using a stream reader.
            using (var sr = new StreamReader("INPUT.TXT"))
            {   
                int daysCount = int.Parse(sr.ReadLine());
                int[] prices = arrayFromString(sr.ReadLine());
                
                using (StreamWriter sw = File.AppendText("OUTPUT.TXT")) {
                    sw.WriteLine(calculateMaximumIncome(prices));
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }

        int calculateMaximumIncome(int[] prices){
            int sum = 0;
            int length = 1;
            int i = 0;
            while (i < prices.Length){
                int[] total = findMaximumPrice(prices,i);
                sum = sum + total[0] * total[1];
                i = i + total[1];
            }
            return sum;
        }

        int[] findMaximumPrice(int[] prices, int dayOffset){
            int[] result = new int[2];
            result[0] = prices[dayOffset];
            result[1] = 1;
            for (int i = dayOffset + 1; i < prices.Length; i++){
                if (result[0] < prices[i]) {
                    result[0] = prices[i];
                    result[1] = i - dayOffset + 1;
                }
            }
            return result;
        }

        static int[] arrayFromString(string text){
            string[] textArray = text.Split(' ');
            int[] result = new int[textArray.Length];
            for (int i=0; i< textArray.Length; i++){
                result[i] = int.Parse(textArray[i]);
            }
            return result;
        }
    }  
}