namespace BilletSystem_EksamensProjekt
{
    public class forestillinger
    {
        private string _title;
        private int _sal;
        private string _description;
        private string _realese;
        private string _tidspunkt;


        public string Title
        {
            get { return _title; }
        }

        public int Sal
        {
            get { return _sal; }
        }

        public string Tidspunkt
        {
            get { return _tidspunkt; }
        }

        public string Description
        {
            get { return _description; }
        }

        public string Realese
        {
            get { return _realese; }
        }

        public forestillinger(string Title, int Sal, string Tidspunkt, stræing description, string realese)
        {
            _title = Title;
            _sal = Sal;
            _description = description;
            _realese = realese;
            _tidspunkt = Tidspunkt;
        }

    }
}