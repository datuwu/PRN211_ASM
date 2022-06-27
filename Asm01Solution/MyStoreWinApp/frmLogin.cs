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
                if (member != null) MemberRepository.Login(member);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Login fail");
            }

        }


        private void btnCancel_Click(object sender, EventArgs e) => Close();

        
    }
}