namespace BilletSystem_EksamensProjekt
{
    public class movies
    {
        private string _title;
        private string _description;
        private string _realese;


        public string Title
        {
            get { return _title; }
        }

        public string Description
        {
            get { return _description; }
        }

        public string Realese
        {
            get { return _realese; }
        }

        public movies(string title, string description, string realese)
        {
            _title = title;
            _description = description;
            _realese = realese;
        }
    }
}