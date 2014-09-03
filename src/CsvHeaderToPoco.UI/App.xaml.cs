using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using Catel.IoC;
using CsvHeaderToPoco.UI.Services;

namespace CsvHeaderToPoco.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var serviceLocator = ServiceLocator.Default;

            serviceLocator.RegisterType<ICreateCSharpFilesService, CreateCSharpFilesService>();
        }
    }
}
