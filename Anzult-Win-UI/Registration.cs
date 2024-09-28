using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Anzult_Win_UI
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void UserRegistrationGroupBox1_Enter(object sender, EventArgs e)
        {
            UserRegistrationGroupBox1.Controls.Cast<Control>().ToList().ForEach(control => control.Font = new Font("Segeo UI", 9, FontStyle.Regular));
         
            //UserRegistrationGroupBox1.Controls.OfType<Label>().ToList().ForEach(label => label.Font = new Font("Segoe UI", 10, FontStyle.Regular));


        }
    }
}
