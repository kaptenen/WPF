using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;


namespace WPFcontact
{
    public class Contact : INotifyPropertyChanged
    {
        private string _name;
        private string _email;
        private string _phone;


        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Name
        {
            get { return _name; }
            set { _name = value; NotifyPropertyChanged(); }
        }

        [MaxLength(50)]
        public string Email
        {
            get { return _email; }
            set { _email = value; NotifyPropertyChanged(); }
        }

        [MaxLength(50)]
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; NotifyPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return $"{Name} - {Email} - {Phone}" ;
        }
    }
}
