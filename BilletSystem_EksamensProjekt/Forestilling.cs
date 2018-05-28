namespace BilletSystem_EksamensProjekt
{
    public class Forestilling
    {
        private movies _movies;
        private sal _sal;
        private Tidspunkt _tidspunkt;

        public movies MoviesForShow
        {
            get { return _movies; }
        }

        public sal SalForShow
        {
            get { return _sal; }
        }

        public Tidspunkt TidspunktForShow
        {
            get { return _tidspunkt; }
        }
    }
}