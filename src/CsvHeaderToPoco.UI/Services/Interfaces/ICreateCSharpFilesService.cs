namespace CsvHeaderToPoco.UI.Services
{
    public interface ICreateCSharpFilesService
    {
        void CreateCSharpFilesForAllCsvFiles(string inputFolder, string namespaceName, string outputFolder);
    }
}