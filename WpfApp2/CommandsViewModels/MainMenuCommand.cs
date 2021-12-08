using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.ViewModels;

namespace WpfApp2.CommandsViewModels
{
    public class MainMenuCommand : CommandBase
    {
        private readonly Navigation _navigation;
        private readonly Func<ViewModelBase> _createViewModel;
        private readonly Func<ViewModelBase> _createViewModel2;

        public MainMenuCommand(Navigation navigation, Func<ViewModelBase> createViewModel, Func<ViewModelBase> createViewModel2)
        {
            _navigation = navigation;
            _createViewModel = createViewModel;
            _createViewModel2 = createViewModel2;
        }
        public override void Execute(object parameter)
        {
            _navigation.CurrentViewModel = _createViewModel();
        }
    }
}