namespace BilletSystem_EksamensProjekt
{
    public class movie_showtime
    {
        private string _title;
        private int _sal;
        private string _description;
        private string _realese;


        public string Title
        {
            get { return _title; }
        }

        public int Sal
        {
            get { return _sal; }
        }

        public string Description
        {
            get { return _description; }
        }

        public string Realese
        {
            get { return _realese; }
        }

        public movie_showtime(string Title, int Sal, string description, string realese)
        {
            _title = Title;
            _sal = Sal;
            _description = description;
            _realese = realese;
        }

    }
}