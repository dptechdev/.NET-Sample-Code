using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace LocalFolderSample.Data
{
    public class ViewModel : INotifyPropertyChanged
    {


        IDataRepository<Customer> _data;


        public ViewModel(IDataRepository<Customer> data)
        {
            _data = data;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string fieldName = " ")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new
                    PropertyChangedEventArgs(fieldName));
            }
        }


        private Customer _selectedItem;
        private ObservableCollection<Customer> _customers;
        public Customer SelectedItem
        {
            get
            {
                return this._selectedItem;
            }
            set
            {
                if (value != _selectedItem)
                {
                    _selectedItem = value;
                    RaisePropertyChanged();
                }
            }
        }

            public ObservableCollection<Customer> Customers
            {
                get
                {
                    return _customers;
                }

                set
                {
                    _customers = value;
                    RaisePropertyChanged();
                }
            }

            public async void Initialize()
            {
                Customers = await _data.Load();
            }

            internal void AddCustomer(Customer cust)
            {
                _data.Add(cust);
            }

            internal void DeleteCustomer(Customer cust)
            {
                _data.Remove(cust);
            }
        }
    }

