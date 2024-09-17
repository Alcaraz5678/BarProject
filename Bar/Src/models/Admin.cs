using System;

namespace BarProject.Bar.src.models
{
    public class Admin
    {
        public int IdAdmin { get; set; }
        public string NameAdmin { get; set;}
        private string _password { get; set; }
        public string Password 
        {
            get { return _password; }
            set { _password = value; }
        }

    }

}