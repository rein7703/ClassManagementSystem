using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Npgsql;
/*
namespace ClassManagementSystemWinForms
{
    public abstract class User
    {
        protected int _id;
        protected string _name;
        protected string _email;
        protected string _password;

        public int Id
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

        public virtual bool Login(string name, string password)
        {
            throw new NotImplementedException();
        }

        public virtual bool createAtDatabase() { throw new NotImplementedException(); }

        public virtual bool createTable() { throw new NotImplementedException(); }
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

        public override bool Login(string name, string password)
        {
            throw new NotImplementedException();
        }

        public override bool createTable() {
            try { 
            SQLiteConnection connection;
            connection = ConnectionSingleton.GetInstance(new SQLiteConnection()).Value;

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "CREATE TABLE Student" +
                "(ID INT PRIMARY KEY NOT NULL, " +
                "NAME VARCHAR(255) UNIQUE NOT NULL, " +
                "EMAIL VARCHAR(255) NOT NULL, " +
                "PASSWORD VARCHAR(255) NOT NULL, " +
                "NIM VARCHAR(255), " +
                "Prodi VARCHAR(255))";
            sqlite_cmd.ExecuteNonQuery();
            Console.WriteLine("Created Table");
        return true;}
            catch { return false; }
        }

        public override bool createAtDatabase()
        {
            try
            {
                SQLiteConnection connection;
                connection = ConnectionSingleton.GetInstance(new SQLiteConnection()).Value;

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = connection.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO TABLE Student" +
                    "(NAME, EMAIL,PASSWORD,NIM,PRODI) " +
                    "VALUES " +$"({_name},{_email},{_password},{_nim},{_prodi})";
                sqlite_cmd.ExecuteNonQuery();
                Console.WriteLine("Created Table");
                return true;
            }
            catch { return false; }
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

        public override bool Login(string id, string password)
        {
            return true;
        }
    }
}
*/