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

        public override void MyExecute()
        {
            _viewModel.BilleterBestilt = _viewModel.BilleterBestilt + 1;
        }
    }
}