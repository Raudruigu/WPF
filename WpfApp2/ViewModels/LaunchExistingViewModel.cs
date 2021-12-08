using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp2.ViewModels
{
    public class LaunchExistingViewModel : ViewModelBase
    {
        private string _backupJobNameText;

        public string BackupJobNameText
        {
            get
            {
                return _backupJobNameText;
            }
            set
            {
                _backupJobNameText = value;
                OnPropertyChanged(nameof(BackupJobNameText));
            }
        }

        public ICommand RunExistingBtn { get; }

        //-------------------------------------------------------------------------------------------------//

        public ICommand ReturnBtn { get; }

        //-------------------------------------------------------------------------------------------------//

        public LaunchExistingViewModel()
        {

        }
    }
}
