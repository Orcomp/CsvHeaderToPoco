using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Catel.MVVM;

namespace CsvHeaderToPoco.UI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            CreateFiles = new Command(OnCreateFiles);
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
