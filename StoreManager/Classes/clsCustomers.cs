using StoreManager.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.Classes
{

    internal class clsCustomers
    {

        public clsCustomers()
        {

        }

        private StoreManagerDBEntities DB = new StoreManagerDBEntities();

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool isActive { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public clsCustomers(string name, string lastName, string phoneNumber, bool IsActive, string address, string email)
        {
           Name=name; 
            LastName=lastName; 
            PhoneNumber=phoneNumber;
            isActive=IsActive;
            Address=address;
            Email=email;
        }
        public static List<CustomersTabel> GetAll()
        {
            StoreManagerDBEntities DB = new StoreManagerDBEntities();
            return DB.CustomersTabels.ToList();
        }
        public bool AddNewCustomer()
        {
            try {
                bool isPhoneDuplicate = !string.IsNullOrEmpty(PhoneNumber) && DB.CustomersTabels.Any(c => c.PhoneNumber == PhoneNumber);
                bool isEmailDuplicate = !string.IsNullOrEmpty(Email) && DB.CustomersTabels.Any(c => c.Email == Email);
                if (isEmailDuplicate|| isPhoneDuplicate)
                {
                    return false;
                }
                
                Database.CustomersTabel NewCustomer = new CustomersTabel();

                NewCustomer.Name = Name;
                NewCustomer.LastName = LastName;
                NewCustomer.PhoneNumber = PhoneNumber;
                NewCustomer.isActive = isActive;
                NewCustomer.Address = Address;
                NewCustomer.Email = Email;
                DB.CustomersTabels.Add(NewCustomer);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public static clsCustomers GetCustomerById(int id)
        {
            StoreManagerDBEntities DB = new StoreManagerDBEntities();
            Database.CustomersTabel customer = new Database.CustomersTabel();
            customer = DB.CustomersTabels.FirstOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return null;
            }

            return new clsCustomers()
            {
                Id = customer.Id,
                Name= customer.Name,
                LastName= customer.LastName,
                PhoneNumber= customer.PhoneNumber,
                isActive= customer.isActive,
                Address= customer.Address,
                Email= customer.Email,
            };

        }
        public bool UpdateCustomer()
        {
            Database.CustomersTabel customer = new Database.CustomersTabel();
            customer = DB.CustomersTabels.FirstOrDefault(c => c.Id == Id);
            try
            {
                if (customer == null)
                {
                    return false;
                }
                customer.Name = Name;
                customer.LastName = LastName;
                customer.PhoneNumber = PhoneNumber;
                customer.isActive = isActive;
                customer.Address = Address;
                customer.Email = Email;

                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeletCustomer()
        {
            Database.CustomersTabel customer = new Database.CustomersTabel();
            customer = DB.CustomersTabels.FirstOrDefault(c => c.Id == Id);
            try
            {
                if (customer == null)
                {
                    return false;
                }

                DB.CustomersTabels.Remove(customer);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static clsCustomers GetCustomerByEmail(string email)
        {
            StoreManagerDBEntities DB = new StoreManagerDBEntities();
            Database.CustomersTabel customer = new Database.CustomersTabel();
            customer= DB.CustomersTabels.FirstOrDefault(c=>c.Email == email);
            if (customer == null)
            {
                return null;
            }
            return new clsCustomers()
            {
                Id = customer.Id,
                Name = customer.Name,
                LastName = customer.LastName,
                PhoneNumber = customer.PhoneNumber,
                isActive = customer.isActive,
                Address = customer.Address,
                Email = customer.Email,
            };

        }

        public static clsCustomers GetCustomerByPhoneNumber(string phoneNumber) {
            StoreManagerDBEntities DB = new StoreManagerDBEntities();
            Database.CustomersTabel customer = new Database.CustomersTabel();
            customer = DB.CustomersTabels.FirstOrDefault(c => c.PhoneNumber == phoneNumber);
            if (customer == null)
            {
                return null;
            }
            return new clsCustomers()
            {
                Id = customer.Id,
                Name = customer.Name,
                LastName = customer.LastName,
                PhoneNumber = customer.PhoneNumber,
                isActive = customer.isActive,
                Address = customer.Address,
                Email = customer.Email,
            };

        }

    }

}
