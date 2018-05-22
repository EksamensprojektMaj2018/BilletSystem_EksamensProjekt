using System.ComponentModel;
using System.Runtime.CompilerServices;
using BilletSystem_EksamensProjekt.Annotations;

namespace BilletSystem_EksamensProjekt
{
    public class SeatCatalog : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}