using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BilletSystem_EksamensProjekt
{
    public class sal
    {
        #region Instance Field
        private string _sale;

        #endregion

        #region constructer

        public sal(string sale)
        {
            _sale = sale;
            
        }

        #endregion


        #region Properties for data binding

        public string Sale
        {
            get { return _sale; }
        }

        public int NoOfSeats { get; set; }
        #endregion

    }
}