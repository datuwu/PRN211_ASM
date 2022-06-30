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
                MemberRepository.G
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                if (email != null && password != null) MemberRepository.Login(email, password); 
                else throw new Exception("null info");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Login fail");
            }

        }


        private void btnCancel_Click(object sender, EventArgs e) => Close();

        
    }
}