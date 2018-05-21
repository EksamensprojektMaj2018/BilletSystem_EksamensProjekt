using System;
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
        private sal _selectedSeats;

        #endregion

        #region Constructor

        
        public salCatalog()
        {
           // var rnd = new Random();
            _sale = new List<sal>();

            _sale.Add(new sal("sal1"));
            _sale.Add(new sal("sal2"));
            _sale.Add(new sal("sal3"));
            //int index = rnd.Next(_sale.Count);

        }
        #endregion

        #region Properties For Databinding
        public List<sal> sal
        {
            
            get { return _sale; }
        }

        public sal selectedSal
        {
            get { return _selectedSal; }
            set
            {
                _selectedSal = value;
                OnPropertyChanged();

            }
        }
        //public int selectedSeats
        //{
        //    get { return selectedSeats; }
        //    set
        //    {
        //        selectedSeats = value;
        //        OnPropertyChanged();
        //    }
        //}
        #endregion
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}