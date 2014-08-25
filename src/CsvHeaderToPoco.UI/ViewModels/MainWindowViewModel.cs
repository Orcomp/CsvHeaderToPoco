using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Catel.IO;
using Catel.MVVM;

namespace CsvHeaderToPoco.UI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            CreateFiles = new Command(OnCreateFiles);
            this.Input = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            this.Output = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Output");
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
            System.Windows.MessageBox.Show("CreateFiles");
        }
    }
}
