using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var text = File.ReadAllText(@"operation.txt").ToLower(); //Dosya okundu.
            
            string[] strategicals = {@"\bdevelopment\b",@"\bimprovement\b",@"\bculture\b"};
            int[] strategicalWordsNumbers = new int[strategicals.Length];
            //Strategical ile ilintili kelimeler diziye aktarıld ve bu kelimelerin sayısını tutacak dizi oluşturuldu.
            for (var i = 0; i < strategicals.Length; i++)
            {
                strategicalWordsNumbers[i]= Regex.Matches(text, strategicals[i]).Count;
                //Döngü ile kelimelerin sayısı kaydedildi.
            }

            var strategicalWordsAll = strategicalWordsNumbers.Sum(); //Toplam strategical kelime sayısı 
            Console.WriteLine($"\nTotal Tactical Words: {strategicalWordsAll}");
            Console.WriteLine($"Process: {strategicalWordsNumbers[0]}");
            Console.WriteLine($"Excellence: {strategicalWordsNumbers[1]}");
            Console.WriteLine($"Satisfaction: {strategicalWordsNumbers[2]}");
            
            
            string[] tacticals = {@"\bprocess\b",@"\bexcellence\b",@"\bsatisfaction\b"};
            int[] tacticalWordsNumbers = new int[tacticals.Length];
            //Tactical ile ilintili kelimeler diziye aktarıld ve bu kelimelerin sayısını tutacak dizi oluşturuldu.
            for (var i = 0; i < tacticals.Length; i++)
            {
                tacticalWordsNumbers[i]= Regex.Matches(text, tacticals[i]).Count;
                //Döngü ile kelimelerin sayısı kaydedildi.
            }

            var tacticalWordsAll = tacticalWordsNumbers.Sum(); //Toplam tactical kelime sayısı 
            Console.WriteLine($"\nTotal Tactical Words: {tacticalWordsAll}");
            Console.WriteLine($"Process: {tacticalWordsNumbers[0]}");
            Console.WriteLine($"Excellence: {tacticalWordsNumbers[1]}");
            Console.WriteLine($"Satisfaction: {tacticalWordsNumbers[2]}");
            

            string[] operationals = {@"\bnumber\b",@"\bwait\b",@"\btime\b",@"\btotal\b",@"\bincome\b"};
            int[] operationalWordsNumbers = new int[operationals.Length];
            //Operational ile ilintili kelimeler diziye aktarıld ve bu kelimelerin sayısını tutacak dizi oluşturuldu.
            for (var i = 0; i < operationals.Length; i++)
            {
                operationalWordsNumbers[i]= Regex.Matches(text, operationals[i]).Count;
                //Döngü ile kelimelerin sayısı kaydedildi.
            }

            var operationalWordsAll = operationalWordsNumbers.Sum();  //Toplam operational kelime sayısı 
            Console.WriteLine($"\nTotal Operational Words: {operationalWordsAll}");
            Console.WriteLine($"Number: {operationalWordsNumbers[0]}");
            Console.WriteLine($"Waiting: {operationalWordsNumbers[1]}");
            Console.WriteLine($"Time: {operationalWordsNumbers[2]}");
            Console.WriteLine($"Total: {operationalWordsNumbers[3]}");
            Console.WriteLine($"Income: {operationalWordsNumbers[4]}");
            
        }
    }
}