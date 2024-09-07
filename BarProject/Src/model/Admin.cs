using System;

namespace BarProject.Src
{
    public class Admin
    {
        public int idAdmin { get; set; }
        public string nameAdmin { get; set;}
        private string _password { get; set; }
        public string password 
        {
            get { return _password; }
            set { _password = value; }
        }

    }

}