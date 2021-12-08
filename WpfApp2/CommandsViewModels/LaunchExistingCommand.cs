using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.ViewModels;

namespace WpfApp2.CommandsViewModels
{
    public class LaunchExistingCommand : CommandBase
    {
        private readonly Navigation _navigation;
        private readonly Func<ViewModelBase> _createViewModel;

        public LaunchExistingCommand(Navigation navigation, Func<ViewModelBase> createViewModel)
        {
            _navigation = navigation;
            _createViewModel = createViewModel;
        }
        public override void Execute(object parameter)
        {
            _navigation.CurrentViewModel = _createViewModel();
        }
    }
}
