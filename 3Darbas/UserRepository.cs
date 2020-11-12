using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _3Darbas
{
    public class UserRepository
    {
        private static List<UserClass> usersList;

        private SqlConnection conn;

        public UserRepository()
        {
            conn = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");

            if(usersList == null)
            {
                usersList = new List<UserClass>();
            }
            
        }

        public void Register(UserClass user)
        {
            SqlConnection con = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");
            SqlCommand cmd = new SqlCommand("Select * from Users where Username= @Username", con);
            cmd.Parameters.AddWithValue("@Username", user.getUsername());
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
                if (dr.HasRows == true)
                {
                    throw new Exception("Username is used!");
                }
                else
                {
                string sql = "insert into Users(Name, Surname, BirthDate, Username, Password, Type, Image)" +
                 "values (@name, @surname, @birthdate, @username, @password, @userType, @image)";
                    SqlCommand cmd2 = new SqlCommand(sql, conn);
                    cmd2.Parameters.AddWithValue("@name", user.GetName());
                    cmd2.Parameters.AddWithValue("@surname", user.GetSurname());
                    cmd2.Parameters.AddWithValue("@birthdate", user.GetBirthdate());
                    cmd2.Parameters.AddWithValue("@username", user.getUsername());
                    cmd2.Parameters.AddWithValue("@password", user.getPassword());
                    int id = EnumConverters.getUserTypeID(user.UserType);
                    cmd2.Parameters.AddWithValue("@userType", id);
                    cmd2.Parameters.AddWithValue("@image", "C:/Users/Admin/Downloads/icon.png");
                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    conn.Close();

                }
            con.Close();
        }

        public UserClass Login(string username, string password)
        {

            string sql = "select Name, Surname, BirthDate, Username, Password, Type, Image from users " +
                "where Username=@username and Password=@password";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            conn.Open();
            using(SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    string surname = reader["Surname"].ToString();
                    DateTime birthdate = DateTime.Parse(reader["BirthDate"].ToString());
                    string _username = reader["Username"].ToString();
                    string _password = reader["Password"].ToString();
                    int id =(int) reader["Type"];
                    string roadToPicture = reader["Image"].ToString();
                    UserClass user = new UserClass(name, surname, birthdate, _username, _password);
                    user.UserType = EnumConverters.getUserType(id);
                    user.setProfilePicture(roadToPicture);
                    return user;
                }
            }
            conn.Close();

            
            throw new Exception("Bad username/password!");
        }

        public void AddBasicUser(string name, string surname, DateTime birthDate, string username, string password)
        {

            for(int i = 0; i < usersList.Count; i++)
                if(usersList[i].getUsername() == username)
                    throw new Exception("User with this username registered!");
            
           
                UserClass user = new UserClass(name, surname, birthDate, username, password);
                user.UserType = UserType.BasicUser;
                Register(user);
            
            
        }
        public void AddAdminUser(string name, string surname, DateTime birthDate, string username, string password)
        {
            Boolean sameAdmin = false;
            for (int i = 0; i < usersList.Count; i++)
            {
                if (usersList[i].getUsername() == username)
                {
                    sameAdmin = true;
                    throw new Exception("Admin with this username registered!");
                }

            }
            if (sameAdmin == false)
            {
                UserClass admin = new UserClass(name, surname, birthDate, username, password);
                admin.UserType = UserType.Admin;
                Register(admin);
            }
        }

       public string GetAllUsers()
        {
             string str = null;
             foreach(UserClass user in usersList)
             {
                if(user.UserType == UserType.BasicUser)
                str += $"User: {user.GetName()} {user.GetSurname()} {user.GetBirthdate()}";
             }
             return str;
                       
        }
        public List<UserClass> GetUserList()
        {
            return usersList;
        }
        public void DeleteUser(string name, string surname, string username, string password)
        {
            string sql = "delete from Users where Username = @username and Password = @password";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
