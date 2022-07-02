using DataAccess.Repository;
using Nancy.Json;
using SalesWinApp;
using System;
using System.IO;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class FrmLogin : Form
    {
        private MemberRepository memberRepository = new MemberRepository();
        public bool UserSuccessfullyAuthenticated { get; private set;  }
        public bool isAdmin { get; private set; }
        public int id { get; private set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private Label lbUsername;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Label lbPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private Button btnCancel;
        private Button btnLogin;

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}