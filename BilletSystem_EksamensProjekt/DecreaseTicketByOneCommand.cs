using System;
using Windows.UI.Popups;

namespace BilletSystem_EksamensProjekt
{
    public class DecreaseTicketByOneCommand : CommandBase
    {
        private bestilling _viewModel;

        public DecreaseTicketByOneCommand(bestilling viewModel)
        {
            _viewModel = viewModel;
        }

        public async override void MyExecute()
        {
            MessageDialog msgbox = new MessageDialog("Du kan ikke bestille mindre end en billet!", "Hov hov, bandit! Du gjorde noget forkert.");
            _viewModel.BilleterBestilt = _viewModel.BilleterBestilt - 1;
            if (_viewModel.BilleterBestilt == 0)
            {
                var res = await msgbox.ShowAsync();
                _viewModel.BilleterBestilt = 1;


            }
        }
    }
}