using Commantary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommentsWinForms
{
    public partial class MainForm: Form
    {
        CommentaryManager commentaryManager_;

        public MainForm()
        {
            InitializeComponent();

            commentaryManager_ = new CommentaryManager(new CommentaryRepo());

            FillUsers();
        }

        public void FillUsers()
        {
            userComboBox.Items.Add("Паша");
            userComboBox.Items.Add("Василий");
            userComboBox.Items.Add("Андрей");
            userComboBox.Items.Add("Илья");
            userComboBox.Items.Add("Максим");
            userComboBox.Items.Add("Александр");
        }

        public void FillUserComments(string login)
        {
            commentsListBox.DataSource = commentaryManager_.GetUserComments(login);
        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            string login = userComboBox.Text;
            commentaryManager_.AddComment(login, commentTextBox.Text);
            FillUserComments(login);
        }
    }
}
