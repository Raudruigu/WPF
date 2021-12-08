using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp2.CommandsViewModels;

namespace WpfApp2.ViewModels
{
    public class NewBackupJobViewModel : ViewModelBase
    {

        private string _backupJobCreateNameText;

        public string BackupJobCreateNameText
        {
            get
            {
                return _backupJobCreateNameText;
            }
            set
            {
                _backupJobCreateNameText = value;
                OnPropertyChanged(nameof(BackupJobCreateNameText));
            }
        }

        private string _sourceFolderText;

        public string SourceFolderText
        {
            get
            {
                return _sourceFolderText;
            }
            set
            {
                _sourceFolderText = value;
                OnPropertyChanged(nameof(SourceFolderText));
            }
        }

        private string _destinationFolderText;

        public string DestinationFolderText
        {
            get
            {
                return _destinationFolderText;
            }
            set
            {
                _destinationFolderText = value;
                OnPropertyChanged(nameof(DestinationFolderText));
            }
        }

        public ICommand DestinationFolderBtn { get; }


        public ICommand SourceFolderBtn { get; }


        public ICommand CreateBackupBtn { get; }

        public ICommand ReturnBtn { get; }
        

        public NewBackupJobViewModel(Navigation navigation, Func<MainMenuViewModel> createMainMenuViewModel2)
        {
            ReturnBtn = new NavigateCommand(navigation, createMainMenuViewModel2);
        }

    }
}
