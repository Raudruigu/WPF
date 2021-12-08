using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp2.CommandsViewModels;

namespace WpfApp2.ViewModels
{
    public class SettingsViewModel : ViewModelBase 
    {
        private string _softwareExceptionsText;

        public string SoftwareExceptionsText
        {
            get
            {
                return _softwareExceptionsText;
            }
            set
            {
                _softwareExceptionsText = value;
                OnPropertyChanged(nameof(SoftwareExceptionsText));
            }
        }
        public ICommand AddSoftwareExceptionsBtn { get; }
        public ICommand RemoveSoftwareExceptionsBtn { get; }
        //---------------------------------------------------------------------------------------------------------------------------------//
        private string _extensionsToEncryptText;

        public string ExtensionsToEncryptText
        {
            get
            {
                return _extensionsToEncryptText;
            }
            set
            {
                _extensionsToEncryptText = value;
                OnPropertyChanged(nameof(ExtensionsToEncryptText));
            }
        }
        public ICommand AddExtensionsToEncryptBtn { get; }
        public ICommand RemoveExtensionsToEncryptBtn { get; }
        //---------------------------------------------------------------------------------------------------------------------------------//
        public ICommand SaveSettingsBtn { get; }

        public ICommand ReturnBtn { get; }

        public SettingsViewModel(Navigation navigation, Func<MainMenuViewModel> createMainMenuViewModel)
        {
            ReturnBtn = new NavigateCommand(navigation, createMainMenuViewModel);
        }
    }
}
