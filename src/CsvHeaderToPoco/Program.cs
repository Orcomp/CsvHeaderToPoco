namespace CsvHeaderToPoco
{
    using System;
    using System.IO;

    using System.Reflection;

    public class Program
    {
        static void Main(string[] args)
        {
            var csvFolderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var namespaceName = "Test.Entities";

            Orc.Csv.CodeGeneration.CreateCSharpFilesForAllCsvFiles(csvFolderPath, namespaceName, Path.Combine(csvFolderPath, "Output"));
            Console.ReadLine();
        }
    }
}