using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp2.CommandsViewModels;

namespace WpfApp2.ViewModels
{
    public class MainMenuViewModel : ViewModelBase
    {
        public ICommand CreateNewBtn { get; }

        public ICommand LaunchExistingBtn { get; }

        public ICommand LaunchAllExistingBtn { get; }

        public ICommand GoToSettingsBtn { get; }



        public MainMenuViewModel(Navigation navigation, Func<SettingsViewModel> createSettingsViewModel)
        {
            GoToSettingsBtn = new NavigateCommand(navigation, createSettingsViewModel);
        }

        public MainMenuViewModel(Navigation navigation, Func<NewBackupJobViewModel> createNewBackupJobViewModel)
        {
            CreateNewBtn = new NavigateCommand(navigation, createNewBackupJobViewModel);
        }
    }
}
