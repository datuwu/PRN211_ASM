using System;
using System.IO;
using Nancy.Json;
using System.Linq;
using BusinessObject;
using System.Windows.Forms;
using DataAccess.Repository;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        public bool UserSuccessfullyAuthenticated { get; private set; }
        public bool isAdmin { get; private set; }
        public int id { get; private set; }
        private MemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }
        

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                string json = string.Empty;
                // read json string from file
                using (StreamReader reader = new StreamReader(@"C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM1\PRN211_ASM\Ass01Solution\MyStoreWinApp\appsettings.json"))
                {
                    json = reader.ReadToEnd();
                }
                JavaScriptSerializer jss = new JavaScriptSerializer();
                // convert json string to dynamic type
                var obj = jss.Deserialize<dynamic>(json);
                // get contents
                var admin = new Member
                {
                    Email = obj["Member"]["Email"],
                    Password = obj["Member"]["Password"]
                };
               
                // add employees to richtextbox
                var members = memberRepository.GetMembers();
                bool isMem = false;
                foreach (var i in members)
                {
                    if (i.Email.Equals(txtEmail.Text) && i.Password.Equals(txtPassword.Text))
                    {
                        frmMemberManagement frm = new frmMemberManagement()
                        {
                            isAdmin = false
                        };
                        Close();
                        UserSuccessfullyAuthenticated = true;
                        isAdmin = false;
                        id = i.MemberID;
                        isMem = true;
                    }
                    else if (admin.Email.Equals(txtEmail.Text) && admin.Password.Equals(txtPassword.Text))
                    {
                        frmMemberManagement frm = new frmMemberManagement()
                        {
                            isAdmin = true
                        };
                        Close();
                        UserSuccessfullyAuthenticated = true;
                        isAdmin = true;
                        isMem = true;
                    }
                }
                if (isMem == true)
                {
                    MessageBox.Show("Login Success", "Right user");
                }
                else
                {
                    MessageBox.Show("Wrong user name or password, please try again", "Wrong user");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}