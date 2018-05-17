namespace BilletSystem_EksamensProjekt
{
    public class Tidspunkt
    {
        #region Instance Field

        private string _tid;

        #endregion

        #region Constructor

        public Tidspunkt(string tid)
        {
            _tid = tid;
        }

        #endregion

        #region Properties For Databinding

        public string Tid
        {
            get { return _tid; }
        }

        #endregion

        public override string ToString()
        {
            return Tid;
        }
    }
}