using StoreManager.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreManager.Classes
{
    internal class clsUser
    {
        private StoreManagerDBEntities DB = new StoreManagerDBEntities();

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }

        public clsUser() { }

        public clsUser(string firstName, string lastName, string userName,
                       string password, bool isActive)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            this.isActive = isActive;
        }

        
        public bool Add()
        {
            try
            {
                if (DB.UsersTabels.Any(u => u.UserName == UserName))
                    return false;

                DB.UsersTabels.Add(new UsersTabel()
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    UserName = UserName,
                    Password = Password,
                    isActive = isActive
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
                UsersTabel user = DB.UsersTabels.FirstOrDefault(u => u.Id == Id);
                if (user == null) return false;

                user.FirstName = FirstName;
                user.LastName = LastName;
                user.UserName = UserName;
                user.Password = Password;
                user.isActive = isActive;

                DB.SaveChanges();
                return true;
            }
            catch { return false; }
        }
      
        public bool Delete()
        {
            try
            {
                UsersTabel user = DB.UsersTabels.FirstOrDefault(u => u.Id == Id);
                if (user == null) return false;

                DB.UsersTabels.Remove(user);
                DB.SaveChanges();
                return true;
            }
            catch { return false; }
        }
 
        public bool SetActiveStatus(bool status)
        {
            try
            {
                UsersTabel user = DB.UsersTabels.FirstOrDefault(u => u.Id == Id);
                if (user == null) return false;

                user.isActive = status;
                DB.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        
        public static clsUser Login(string userName, string password)
        {
            StoreManagerDBEntities DB = new StoreManagerDBEntities();

            UsersTabel user = DB.UsersTabels
                                .FirstOrDefault(u => u.UserName == userName
                                                  && u.Password == password
                                                  );
            if (user == null) return null;

            return new clsUser()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Password = user.Password,
                isActive = user.isActive
            };
        }
     
        public static clsUser GetById(int id)
        {
            StoreManagerDBEntities DB = new StoreManagerDBEntities();

            UsersTabel user = DB.UsersTabels.FirstOrDefault(u => u.Id == id);
            if (user == null) return null;

            return new clsUser()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Password = user.Password,
                isActive = user.isActive
            };
        }
      
        public static clsUser GetByUserName(string userName)
        {
            StoreManagerDBEntities DB = new StoreManagerDBEntities();

            UsersTabel user = DB.UsersTabels.FirstOrDefault(u => u.UserName == userName);
            if (user == null) return null;

            return new clsUser()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Password = user.Password,
                isActive = user.isActive
            };
        }
       
        public static List<UsersTabel> GetAll()
        {
            StoreManagerDBEntities DB = new StoreManagerDBEntities();
            return DB.UsersTabels.ToList();
        }
    }
}