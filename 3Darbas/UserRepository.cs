using System;
using System.Data.SqlClient;

namespace _3Darbas
{
    public class UserRepository
    {
        private SqlConnection conn;

        public UserRepository()
        {
            conn = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");
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

            string sql = "select User_ID, Name, Surname, BirthDate, Username, Password, Type, Image from users " +
                "where Username=@username and Password=@password";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    string surname = reader["Surname"].ToString();
                    DateTime birthdate = DateTime.Parse(reader["BirthDate"].ToString());
                    string _username = reader["Username"].ToString();
                    string _password = reader["Password"].ToString();
                    int typeId = (int)reader["Type"];
                    string roadToPicture = reader["Image"].ToString();
                    int user_Id = int.Parse(reader["User_ID"].ToString());
                    UserClass user = new UserClass(name, surname, birthdate, _username, _password);
                    user.UserType = EnumConverters.getUserType(typeId);
                    user.setProfilePicture(roadToPicture);
                    user.setId(user_Id);
                    return user;
                }
            }
            conn.Close();


            throw new Exception("Bad username/password!");
        }

        public void AddBasicUser(string name, string surname, DateTime birthDate, string username, string password)
        {

            UserClass user = new UserClass(name, surname, birthDate, username, password);
            user.UserType = UserType.BasicUser;
            Register(user);

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
