using FeiraTecnica2024BloodTestBeta.UsersControl;
using System.Windows.Forms;

namespace FeiraTecnica2024BloodTestBeta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }



        private void guna2Button4_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
