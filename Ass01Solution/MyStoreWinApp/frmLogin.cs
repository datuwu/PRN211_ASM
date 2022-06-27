using BusinessObject;
using DataAccess.Repository;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }
        public IMemberRepository MemberRepository { get; set; }
        public Member member { get; set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new Member()
                {
                    Email = txtEmail.Text,
                    Password = txtPassword.Text
                };
                MemberRepository.Login(member);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Login fail");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try { 
            txtEmail.Text = member.Email.ToString();
            txtPassword.Text = member.Password.ToString();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

          
        }

        
    }
}