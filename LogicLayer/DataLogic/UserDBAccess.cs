using LogicLayer.BussinessLogic;
using LogicLayer.BussinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.DataLogic
{
    public class UserDBAccess
    {
        public bool Insert(User user)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", user.Id),
                new SqlParameter("@name",user.Name),
                new SqlParameter("@email", user.Email),
                new SqlParameter("@university_id", user.University_id),
                new SqlParameter("@password",user.Password),
                new SqlParameter("@created_date", user.Created_date),
                new SqlParameter("@created_by",user.Created_by),
                new SqlParameter("@modify_date", user.Modify_date),
                new SqlParameter("@modify_by", user.Modify_by),
                new SqlParameter("@designation",user.Designation),
                new SqlParameter("@department", user.Department)
            };

            return SqlDBHelper.ExecuteNonQuery(Constraints.SB_USER_INSERT, CommandType.StoredProcedure, parameters);
        }
        public bool Update(User user)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", user.Id),
                new SqlParameter("@name",user.Name),
                new SqlParameter("@email", user.Email),
                new SqlParameter("@university_id", user.University_id),
                new SqlParameter("@password",user.Password),
                new SqlParameter("@created_date", DateTime.Now),
                new SqlParameter("@created_by",user.Created_by),
                new SqlParameter("@modify_date", DateTime.Now),
                new SqlParameter("@modify_by", user.Modify_by),
                new SqlParameter("@designation",user.Designation),
                new SqlParameter("@department", user.Department)
            };

            return SqlDBHelper.ExecuteNonQuery(Constraints.SB_USER_UPDATE_BY_ID, CommandType.StoredProcedure, parameters);
        }

        internal User GetLoginUser(string id)
        {
            User user=null;
            SqlParameter[] parameters = new SqlParameter[]
               {
                new SqlParameter("@university_id", id)
               };

            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Constraints.SB_USER_GET_BY_UID_PASS, CommandType.StoredProcedure, parameters))
            {
                //check if any record exist or not
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];

                    //Lets go ahead and create the list of employees
                    user = new User();

                    //Now lets populate the employee details into the list of employees                                           
                    user.Id = Convert.ToInt32(row["id"]);
                    user.Name = row["name"].ToString();
                    user.Password = row["password"].ToString();
                    user.University_id = row["university_id"].ToString();
                    user.Created_date = Convert.ToDateTime(row["created_date"]);
                    user.Created_by = row["created_by"].ToString();
                    user.Modify_date = Convert.ToDateTime(row["modify_date"].ToString());
                    user.Modify_by = row["modify_by"].ToString();
                    user.Email = row["email"].ToString();
                    user.Designation = row["designation"].ToString();
                    user.Department = row["department"].ToString();

                }
                else return null;
            }

            return user;
        }

        internal string LoginCheck(string id,string pass)
        {
            
            SqlParameter[] parameters = new SqlParameter[]
               {
                new SqlParameter("@university_id", id),
                new SqlParameter("@password",pass)

               };

            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Constraints.SB_USER_GET_BY_UID_PASS, CommandType.StoredProcedure, parameters))
            {
                //check if any record exist or not
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    return row["designation"].ToString(); ;

                }
                return "";
            }

           
        }

        public bool DeleteById(int id)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };

            return SqlDBHelper.ExecuteNonQuery(Constraints.SB_USER_DELETE_BY_ID, CommandType.StoredProcedure, parameters);
        }
        public User GetById(int id)
        {
            User user = null;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };
            //Lets get the list of all employees in a datataable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Constraints.SB_USER_GET_BY_ID, CommandType.StoredProcedure, parameters))
            {
                //check if any record exist or not
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];

                    //Lets go ahead and create the list of employees
                    user = new User();

                    //Now lets populate the employee details into the list of employees                                           
                    user.Id = Convert.ToInt32(row["id"]);
                    user.Name = row["name"].ToString();
                    user.Password = row["password"].ToString();
                    user.University_id= row["university_id"].ToString();
                    user.Created_date = Convert.ToDateTime( row["created_date"]);
                    user.Created_by = row["created_by"].ToString();
                    user.Modify_date =Convert.ToDateTime( row["modify_date"].ToString());
                    user.Modify_by = row["modify_by"].ToString();
                    user.Email = row["email"].ToString();
                    user.Designation = row["designation"].ToString();
                    user.Department = row["department"].ToString();

                }
            }

            return user;
        }


        public User GetByUniversiyId(string id)
        {
            User user = null;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@university_id", id)
            };
            //Lets get the list of all employees in a datataable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Constraints.SB_User_Get_By_UniversityId, CommandType.StoredProcedure, parameters))
            {
                //check if any record exist or not
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];

                    //Lets go ahead and create the list of employees
                    user = new User();

                    //Now lets populate the employee details into the list of employees                                           
                    user.Id = Convert.ToInt32(row["id"]);
                    user.Name = row["name"].ToString();
                    user.Password = row["password"].ToString();
                    user.University_id = row["university_id"].ToString();
                    user.Created_date = Convert.ToDateTime(row["created_date"]);
                    user.Created_by = row["created_by"].ToString();
                    user.Modify_date = Convert.ToDateTime(row["modify_date"].ToString());
                    user.Modify_by = row["modify_by"].ToString();
                    user.Email = row["email"].ToString();
                    user.Designation = row["designation"].ToString();
                    user.Department = row["department"].ToString();

                }
            }

            return user;
        }
        public List<User> GetAll()
        {
            List<User> userList = null;

            //Lets get the list of all employees in a datataable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Constraints.SB_USER_GETALL, CommandType.StoredProcedure))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of employees
                    userList = new List<User>();

                    //Now lets populate the employee details into the list of employees
                    foreach (DataRow row in table.Rows)
                    {
                        

                        //Lets go ahead and create the list of employees
                        User user = new User();

                        //Now lets populate the employee details into the list of employees                                           
                        user.Id = Convert.ToInt32(row["id"]);
                        user.Name = row["name"].ToString();
                        user.Password = row["password"].ToString();
                        user.University_id = row["university_id"].ToString();
                        user.Created_date = Convert.ToDateTime(row["created_date"]);
                        user.Created_by = row["created_by"].ToString();
                        user.Modify_date = Convert.ToDateTime(row["modify_date"].ToString());
                        user.Modify_by = row["modify_by"].ToString();
                        user.Email = row["email"].ToString();
                        user.Designation = row["designation"].ToString();
                        user.Department = row["department"].ToString();
                        userList.Add(user);
                    }
                }
            }

            return userList;
        }
    }
}
