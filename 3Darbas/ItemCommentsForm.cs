using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Darbas
{
    public partial class ItemCommentsForm : Form
    {
        private ItemsRepository itemsRepository;
        UserClass user;
        Item item;
        public ItemCommentsForm(UserClass user, Item item)
        {
            InitializeComponent();
            this.user = user;
            this.item = item;

            itemsRepository = new ItemsRepository();
            List<Comment> commentList = itemsRepository.getCommentsList(item.Id);

            foreach(Comment comment in commentList)
            {
                if(user.UserType == UserType.BasicUser)
                {
                    itemComment commentItem = new itemComment(user, comment);
                    commentsFlowPanel.Controls.Add(commentItem);
                }
                else
                {
                    itemCommentAdmin commentItemAdmin = new itemCommentAdmin(user, comment);
                    commentsFlowPanel.Controls.Add(commentItemAdmin);
                }
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
