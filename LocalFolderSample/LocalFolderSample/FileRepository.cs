﻿using LocalFolderSample.Data;
using System;
using System.Collections.ObjectModel;
using Windows.Storage;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFolderSample
{
    public class FileRepository : IDataRepository<Customer>
    {

        string _fileName = "customers.json";
        ObservableCollection<Customer> _customers;
        

        public FileRepository()
        {
            Initialize();
        }

        private void Initialize()
        {

        }

        private Task WriteToFile()
        {
            return Task.Run(async () =>
                {
                    string JSON =
                        JsonConvert.SerializeObject(_customers);
                    var file = await OpenFileAsync();
                    await FileIO.WriteTextAsync(file, JSON);
                });
        }

        private async Task<StorageFile> OpenFileAsync()
        {
            return await FileOperations.OpenFile(_fileName);
        }

        public Task Add(Customer customer)
        {
           _customers.Add(customer);
            return WriteToFile();
        }

        public async Task<ObservableCollection<Customer>> Load()
        {
            var file = await FileOperations.OpenFile(_fileName);
            string fileContents = string.Empty;
            if (file != null)
            {
                fileContents = await FileIO.ReadTextAsync(file);
            }
            IList<Customer> customersfromJSON =
                JsonConvert.DeserializeObject<List<Customer>>
                (fileContents)
                ?? new List<Customer>();
            _customers = new ObservableCollection<Customer>(customersfromJSON);
            return _customers;
        }

        public Task Remove(Customer customer)
        {
            _customers.Remove(customer);
            return WriteToFile();
        }

        public Task Update(Customer customer)
        {
            var oldCustomer = _customers.FirstOrDefault(
                c => c.Id == customer.Id);
            if (oldCustomer == null)
            {
                throw new System.ArgumentException("Customer not found.");

            }
            _customers.Remove(oldCustomer);
            _customers.Add(customer);
            return WriteToFile();
        }
    }
}
