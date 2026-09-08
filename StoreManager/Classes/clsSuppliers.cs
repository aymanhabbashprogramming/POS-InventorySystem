using StoreManager.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreManager.Classes
{
    internal class clsSuppliers
    {
        private StoreManagerDBEntities DB = new StoreManagerDBEntities();

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool isActive { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }

        public clsSuppliers() { }

        public clsSuppliers(string name, string lastName, string phoneNumber,
                            bool isActive, string address, string email, string companyName)
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            this.isActive = isActive;
            Address = address;
            Email = email;
            CompanyName = companyName;
        }

        public bool Add()
        {
            try
            {
                bool isPhoneDuplicate = !string.IsNullOrEmpty(PhoneNumber) &&
                                        DB.SuppliersTabels.Any(s => s.PhoneNumber == PhoneNumber);

                bool isEmailDuplicate = !string.IsNullOrEmpty(Email) &&
                                        DB.SuppliersTabels.Any(s => s.Email == Email);

                if (isPhoneDuplicate || isEmailDuplicate)
                    return false;

                DB.SuppliersTabels.Add(new SuppliersTabel()
                {
                    Name = Name,
                    LastName = LastName,
                    PhoneNumber = PhoneNumber,
                    isActive = isActive,
                    Address = Address,
                    Email = Email,
                    CompanyName = CompanyName
                });

                DB.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Update()
        {
            try
            {
                SuppliersTabel  supplier = DB.SuppliersTabels.FirstOrDefault(s => s.Id == Id);
                if (supplier == null) return false;

                supplier.Name = Name;
                supplier.LastName = LastName;
                supplier.PhoneNumber = PhoneNumber;
                supplier.isActive = isActive;
                supplier.Address = Address;
                supplier.Email = Email;
                supplier.CompanyName = CompanyName;

                DB.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Delete()
        {
            try
            {
                SuppliersTabel  supplier = DB.SuppliersTabels.FirstOrDefault(s => s.Id == Id);
                if (supplier == null) return false;

                DB.SuppliersTabels.Remove(supplier);
                DB.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public static clsSuppliers GetById(int id)
        {
            StoreManagerDBEntities DB = new StoreManagerDBEntities();
            SuppliersTabel  supplier = DB.SuppliersTabels.FirstOrDefault(s => s.Id == id);
            if (supplier == null) return null;

            return Map(supplier);
        }

        public static clsSuppliers GetByPhoneNumber(string phoneNumber)
        {
            StoreManagerDBEntities DB = new StoreManagerDBEntities();
            SuppliersTabel  supplier = DB.SuppliersTabels
                                        .FirstOrDefault(s => s.PhoneNumber == phoneNumber);
            if (supplier == null) return null;

            return Map(supplier);
        }

        public static clsSuppliers GetByEmail(string email)
        {
            StoreManagerDBEntities DB = new StoreManagerDBEntities();
            SuppliersTabel  supplier = DB.SuppliersTabels
                                        .FirstOrDefault(s => s.Email == email);
            if (supplier == null) return null;

            return Map(supplier);
        }

        public static List<SuppliersTabel > GetAll()
        {
            StoreManagerDBEntities DB = new StoreManagerDBEntities();
            return DB.SuppliersTabels.ToList();
        }

        private static clsSuppliers Map(SuppliersTabel  s)
        {
            return new clsSuppliers()
            {
                Id = s.Id,
                Name = s.Name,
                LastName = s.LastName,
                PhoneNumber = s.PhoneNumber,
                isActive = (bool)s.isActive,
                Address = s.Address,
                Email = s.Email,
                CompanyName = s.CompanyName
            };
        }
    }
}