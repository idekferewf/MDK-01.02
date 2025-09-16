using System.Collections.Generic;
using System.Windows.Forms;
using RegressionTesting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CommentsWinForms
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();

            FillUsers();
        }

        public void FillUsers()
        {
            List<User> users = new List<User>
            {
                new User { Id = 1, Username = "John" },
                new User { Id = 2, Username = "Alice" },
                new User { Id = 3, Username = "Bob" }
            };

            userComboBox.DataSource = null;
            userComboBox.Items.Clear();

            userComboBox.DataSource = users;
            userComboBox.DisplayMember = "Username";
        }
    }
}
