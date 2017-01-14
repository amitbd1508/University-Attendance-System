using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.BussinessObject
{
    public class User
    {
        private int id;
        private string name;
        private string password;
        private string university_id;
        private DateTime created_date;
        private string created_by;
        private DateTime modify_date;
        private string modify_by;
        private string email;
        private string department;
        private string designation;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string University_id
        {
            get
            {
                return university_id;
            }

            set
            {
                university_id = value;
            }
        }

        public DateTime Created_date
        {
            get
            {
                return created_date;
            }

            set
            {
                created_date = value;
            }
        }

        public string Created_by
        {
            get
            {
                return created_by;
            }

            set
            {
                created_by = value;
            }
        }

        public DateTime Modify_date
        {
            get
            {
                return modify_date;
            }

            set
            {
                modify_date = value;
            }
        }

        public string Modify_by
        {
            get
            {
                return modify_by;
            }

            set
            {
                modify_by = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Department
        {
            get
            {
                return department;
            }

            set
            {
                department = value;
            }
        }

        public string Designation
        {
            get
            {
                return designation;
            }

            set
            {
                designation = value;
            }
        }
    }
}
