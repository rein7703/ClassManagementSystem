using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassManagementSystemMAUIVersion.Model
{
    public abstract class User
    {
        private string _id;
        private string _name;
        private string _email;
        private string _password;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        [JsonIgnore]
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public bool Login(string id,string password) 
        { 
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password))
                return false;
            if(id == _id && password == _password)  return true; 
            else return false;
        }
    }

    public class Student : User
    { 
    
        private string _nim;
        private string _prodi;

        public string NIM
        {
            get { return _nim; }
            set { _nim = value; }
        }

        public string Prodi
        {
            get { return _prodi; }
            set { _prodi = value; }
        }

    }

    public class Admin : User
    {

        private string _nip;
        private string _jabatan;

        public string NIP
        {
            get { return _nip; }
            set { _nip = value; }
        }

        public string Jabatan
        {
            get { return _jabatan; }
            set { _jabatan = value; }
        }

        public void AddToCalendar(DateTime dateTime)
        {

        }

        public void AddClass() { }

    }
}
