using System.Windows;
using Catel.Windows;

namespace CsvHeaderToPoco.UI.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DataWindow
    {
        public MainWindow()
            :base(DataWindowMode.Custom)
        {
            InitializeComponent();
        }
    }
}
