using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using BilletSystem_EksamensProjekt.Annotations;

namespace BilletSystem_EksamensProjekt
{
    public class bestilling : INotifyPropertyChanged
    {
        private int _billetterBestilt;

        public bestilling()
        {
            _billetterBestilt = 0;
        }

        public int BilleterBestilt
        {
            get { return _billetterBestilt; }
            set
            {
                _billetterBestilt = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddOneCommand
        {
            get { return new IncreaseTicketByOneCommand(this); }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}