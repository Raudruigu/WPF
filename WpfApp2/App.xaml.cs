using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp2.CommandsViewModels;
using WpfApp2.ViewModels;

namespace WpfApp2
{
	public partial class App : Application
	{
        private readonly Navigation _navigation;

        public App()
        {
            _navigation = new Navigation();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigation.CurrentViewModel = CreateLaunchExistingViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigation)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        private SettingsViewModel CreateSettingsViewModel()
        {
            return new SettingsViewModel(_navigation, CreateMainMenuViewModel);
        }

        private NewBackupJobViewModel CreateNewBackupJobViewModel()
        {
            return new NewBackupJobViewModel(_navigation, CreateMainMenuViewModel);
        }


        private LaunchExistingViewModel CreateLaunchExistingViewModel()
        {
            return new LaunchExistingViewModel(_navigation, CreateMainMenuViewModel);
        }


        private MainMenuViewModel CreateMainMenuViewModel()
        {
            return new MainMenuViewModel(_navigation, CreateSettingsViewModel);
            
        }

        private MainMenuViewModel CreateMainMenuViewModel2()
        {
            return new MainMenuViewModel(_navigation, CreateNewBackupJobViewModel);

        }

        
    }
}
