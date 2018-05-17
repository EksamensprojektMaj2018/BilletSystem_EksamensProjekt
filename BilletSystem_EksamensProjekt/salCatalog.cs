using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace BilletSystem_EksamensProjekt
{
    public class salCatalog : INotifyPropertyChanged
    {
        #region Instance Field

        private List<sal> _sale;
        private sal _selectedSal;
       

        #endregion

        #region Constructor

        
        public salCatalog()
        {
            _sale = new List<sal>();

            _sale.Add(new sal("sal1"));
            _sale.Add(new sal("sal2"));
            _sale.Add(new sal("sal3"));

            _selectedSal = _sale[0];
        }
        #endregion

        #region Properties For Databinding
        public List<sal> Sal
        {
            get { return _sale; }
        }

        public sal SelectedSal
        {
            get { return _selectedSal; }
            set
            {
                _selectedSal = value;
                OnPropertyChanged();

            }
        }
        public sal NoOfSeats
        {
            get { return NoOfSeats; }
            set
            {
                NoOfSeats = value;
                OnPropertyChanged();
            }
        }
        #endregion
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}