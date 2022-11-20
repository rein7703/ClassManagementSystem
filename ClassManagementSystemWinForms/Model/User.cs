using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Npgsql;

namespace ClassManagementSystemWinForms
{
    public abstract class User
    {
        protected int _id;
        protected string _name;
        protected string _username;
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

        public string Username
        {
            get { return _username; }
            set { _username = value; }
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

        public virtual bool updateAtDatabase() { throw new NotImplementedException(); }

        public virtual bool deleteAtDatabase() { throw new NotImplementedException(); }
    }

    public class Student : User
    {

        private string _niu;
        private string _prodi;

        public string NIU
        {
            get { return _niu; }
            set { _niu = value; }
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

        public Student(string name, string username, string password, string niu, string prodi)
        {
            this._name = name;
            this._username = username;
            this._password = password;
            this._niu = niu;
            this._prodi = prodi;
        }



        public override bool createAtDatabase()
        {
            try
            {
                string connstring = ConnString.connString;
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO \"Student\"(\"Name\", \"Username\", \"Password\", \"NIU\", \"Prodi\") VALUES (@name, @username, @password, @niu, @prodi)";
                        cmd.Parameters.AddWithValue("name", _name);
                        cmd.Parameters.AddWithValue("username", _username);
                        cmd.Parameters.AddWithValue("password", _password);
                        cmd.Parameters.AddWithValue("niu", int.Parse(_niu));
                        cmd.Parameters.AddWithValue("prodi", _prodi);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                MessageBox.Show("Data berhasil ditambahkan");
                return true;
            }
            catch(Exception ex) {
                if (ex.Message.Contains("23505")) {
                    MessageBox.Show("Username sudah ada");
                    return false;
                }
                MessageBox.Show(ex.Message);
                return false; 
            }
        }

        public bool updateAtDatabase(int id)
        {
            try
            {
                {
                    string connstring = ConnString.connString;
                    using (var conn = new NpgsqlConnection(connstring))
                    {
                        conn.Open();
                        using (var cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "UPDATE \"Student\" SET \"Name\" = @name, \"Username\" = @username, \"Password\" = @password, \"NIU\" = @niu, \"Prodi\" = @prodi WHERE \"Id\" = @id";
                            cmd.Parameters.AddWithValue("username", _username);
                            cmd.Parameters.AddWithValue("password", _password);
                            cmd.Parameters.AddWithValue("niu", int.Parse(_niu));
                            cmd.Parameters.AddWithValue("prodi", _prodi);
                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                    MessageBox.Show("Data berhasil ditambahkan");
                    return true;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("23505"))
                {
                    MessageBox.Show("Username sudah ada");
                    return false;
                }
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    

    public class Admin : User
    {

        private string _nip;
        private string _jabatan;

            public Admin(string name, string username, string password, string nip, string jabatan)
            {
                this._name = name;
                this._username = username;
                this._password = password;
                this._nip = nip;
                this._jabatan = jabatan;
            }

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

        public override bool createAtDatabase()
        {
            try
            {
                string connstring = ConnString.connString;
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO \"Student\"(\"Name\", \"Username\", \"Password\", \"NIP\", \"Jabatan\") VALUES (@name, @username, @password, @nip, @jabatan)";
                        cmd.Parameters.AddWithValue("name", _name);
                        cmd.Parameters.AddWithValue("username", _username);
                        cmd.Parameters.AddWithValue("password", _password);
                        cmd.Parameters.AddWithValue("nip", int.Parse(_nip));
                        cmd.Parameters.AddWithValue("jabatan", _jabatan);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                MessageBox.Show("Data berhasil ditambahkan");
                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("23505"))
                {
                    MessageBox.Show("Username sudah ada");
                    return false;
                }
                MessageBox.Show(ex.Message);
                return false;
            }
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
