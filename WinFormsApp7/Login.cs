using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            btnComprar = new Button();
            SuspendLayout();
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(291, 142);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(138, 47);
            btnComprar.TabIndex = 0;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // login
            // 
            ClientSize = new Size(741, 402);
            Controls.Add(btnComprar);
            Name = "login";
            Text = "Login";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            login novoLogin = new login();
            novoLogin.Show();
        }
    }
}
