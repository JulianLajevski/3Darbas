using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Darbas
{
    public class UserClass : PersonClass
    {
        public int id;
        private string username;
        private string password;
        private Bitmap profilePicture;
        private UserType userType = UserType.BasicUser;

        

        public UserClass(string name, string surname, DateTime birthDate, string username, string password) : base(name, surname, birthDate)
        {
            if (username == "")
                throw new Exception("Username is empty!");
            if (password == "")
                throw new Exception("Password is empty!");
            this.username = username;
            this.password = password;
        }

        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
        public void SetPassword(string password)
        {
            this.password = password;
        }

        internal UserType UserType 
        { 
            get => userType; set => userType = value; 
        }
        public void setProfilePicture(String roadToPicture)
        {
            profilePicture = new Bitmap(roadToPicture);
        }
        public Bitmap GetProfilePicture()
        {
            return profilePicture;
        }
        public void setId(int value)
        {
            this.id = value;
        }
        public int getId()
        {
            return id;
        }
    }
}
