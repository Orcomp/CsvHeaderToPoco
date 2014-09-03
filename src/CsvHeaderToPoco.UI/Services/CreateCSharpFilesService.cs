using Orc.Csv;

namespace CsvHeaderToPoco.UI.Services
{
    public class CreateCSharpFilesService : ICreateCSharpFilesService
    {
        public void CreateCSharpFilesForAllCsvFiles(string inputFolder, string namespaceName, string outputFolder)
        {
            CodeGeneration.CreateCSharpFilesForAllCsvFiles(inputFolder, namespaceName, outputFolder);
            System.Windows.MessageBox.Show(string.Format("Files have been created in the '{0}' folder", outputFolder));
        }
    }
}
