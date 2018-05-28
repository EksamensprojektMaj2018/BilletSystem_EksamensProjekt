using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Popups;

namespace BilletSystem_EksamensProjekt
{
    public class IncreaseTicketByOneCommand : CommandBase
    {
        //private BilletPageViewModel _viewModel;
        private bestilling _viewModel;

        public IncreaseTicketByOneCommand(bestilling viewModel)
        {
            _viewModel = viewModel;
        }

        public async override void MyExecute()
        {
            MessageDialog msgbox = new MessageDialog("Du kan ikke bestille mere end 10 billetter!", "Hov hov, bandit! Du gjorde noget forkert.");
            _viewModel.BilleterBestilt = _viewModel.BilleterBestilt + 1;
            if (_viewModel.BilleterBestilt == 11)
            {
                var res = await msgbox.ShowAsync();
                _viewModel.BilleterBestilt = 10;
                

            }
        }
    }
}