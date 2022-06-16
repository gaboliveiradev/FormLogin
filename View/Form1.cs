using WFLogin.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFLogin
{
    public partial class frmLogin : Form
    {
        private loginDAO loginDAO;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void entrar()
        {
            string user = tbUser.Text;
            string pass = tbSenha.Text;

            loginDAO = new loginDAO();
            bool retorno = loginDAO.selectByUserAndPass(user, pass);
            if (retorno)
            {
                Form frm = new Form();
                frm.Show();
            } else {
                MessageBox.Show("Usuário e/ou senha incorretos!");
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            entrar();
        }
    }
}
