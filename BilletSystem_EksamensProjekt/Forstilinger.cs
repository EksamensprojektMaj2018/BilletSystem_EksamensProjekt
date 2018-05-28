namespace BilletSystem_EksamensProjekt
{
    public class Forestillinger
    {
        private movies _movie;
        private sal _sal;
        private Tidspunkt _tidspunkt;

        public movies Movies
        {
            get { return _movie; }
        }

        public sal Sal
        {
            get { return _sal; }
        }

        public Tidspunkt Tidspunkt
        {
            get { return _tidspunkt; }
        }

        public Forestillinger(movies movie, sal sale, Tidspunkt tid)
        {
            _movie = movie;
            _sal = sale;
            _tidspunkt = tid;
        }
    }
}