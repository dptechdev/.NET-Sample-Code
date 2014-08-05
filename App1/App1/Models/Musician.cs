using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    public class Musician
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return this._firstName; }
            set
            {
                if (_firstName != null)
                {
                    this._firstName = value;
                        OnPropertyChanged();
                }
            }
        }
        public string LastName
        {
            get { return this._lastName; }
            set
            {
                if (_lastName != null)
                {
                    this._lastName = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        internal void OnPropertyChanged([CallerMemberName]
            string member = " ")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new
                    PropertyChangedEventArgs(member));
            }
        }


    }
}