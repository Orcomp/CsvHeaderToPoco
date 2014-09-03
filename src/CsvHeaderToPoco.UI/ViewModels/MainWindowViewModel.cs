using System.Reflection;
using Catel;
using Catel.IO;
using Catel.MVVM;
using CsvHeaderToPoco.UI.Services;

namespace CsvHeaderToPoco.UI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(ICreateCSharpFilesService createCSharpFilesService)
        {
            Argument.IsNotNull(() => createCSharpFilesService);
            _createCSharpFilesService = createCSharpFilesService;
            CreateFiles = new Command(OnCreateFiles);
            this.Input = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            this.Output = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Output");
            this.Namespace = "Test.Entities";
        }

        private string _namespace;
        public string Namespace
        {
            get { return _namespace; }
            set
            {
                if (value == _namespace) return;
                _namespace = value;
                RaisePropertyChanged(() => Namespace);
            }
        }

        private string _input;
        public string Input
        {
            get { return _input; }
            set
            {
                if (value == _input) return;
                _input = value;
                RaisePropertyChanged(() => Input);
            }
        }

        private string _output;
        private ICreateCSharpFilesService _createCSharpFilesService;

        public string Output
        {
            get { return _output; }
            set
            {
                if (value == _output) return;
                _output = value;
                RaisePropertyChanged(() => Output);
            }
        }

        public Command CreateFiles { get; private set; }
        private void OnCreateFiles()
        {
            _createCSharpFilesService.CreateCSharpFilesForAllCsvFiles(Input, Namespace, Output);
        }
    }
}
