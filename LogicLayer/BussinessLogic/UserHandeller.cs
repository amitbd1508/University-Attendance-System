using LogicLayer.BussinessObject;
using LogicLayer.DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.BussinessLogic
{
    public class UserHandeller
    {
        UserDBAccess userDBAcess = null;
        public UserHandeller()
        {
            userDBAcess = new UserDBAccess();
        }
        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool Insert(User user)
        {
            return userDBAcess.Insert(user);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool Update(User user)
        {
            return userDBAcess.Update(user);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool DeleteById(int id)
        {
            return userDBAcess.DeleteById(id);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public User GetById(int id)
        {
            return userDBAcess.GetById(id);
        }

        public Boolean LoginCheck(string  id,string pass)
        {
            return userDBAcess.LoginCheck(id,pass);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public List<User> GetAll()
        {
            return userDBAcess.GetAll();
        }

    }
}
