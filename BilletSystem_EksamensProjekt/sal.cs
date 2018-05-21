using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BilletSystem_EksamensProjekt
{
    public class sal
    {
        #region Instance Field
        private string _sale;
        private string _noOfSeats;

        #endregion

        #region constructer

        public sal(string sale)
        {
            _sale = sale;
            //_noOfSeats = noOfSeats;
        }

        #endregion


        #region Properties for data binding

        public string Sale
        {
            get { return _sale; }
        }

        //public string NoOfSeats
        //{
        //    get { return _noOfSeats; }
        //}
        #endregion


        //public event PropertyChangedEventHandler PropertyChanged;

        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        public override string ToString()
        {
            return Sale;
        }
    }
}