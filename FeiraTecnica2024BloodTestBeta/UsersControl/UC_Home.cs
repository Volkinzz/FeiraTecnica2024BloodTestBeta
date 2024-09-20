using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeiraTecnica2024BloodTestBeta.UsersControl
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
            PictureBox_FundoLoading.Visible = false;
            PictureBox_FundoLoading.Enabled = false;
            Panel_Loading.Visible = false;
            Panel_Loading.Enabled = false;
            ProgressBarCircle_1.Value = 0;
            Button_2.Visible = false;
            Button_2.Enabled = false;
            Form1 parentForm = this.FindForm() as Form1;            
        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Label_1.Visible = false;
            Button_1.Visible = false;
            Label_1.Enabled = false;
            Button_1.Enabled = false;
            Panel_Loading.Visible = true;
            Panel_Loading.Enabled = true;
            
            PictureBox_FundoLoading.Dock = DockStyle.Fill;
            PictureBox_FundoLoading.Visible = true;
            PictureBox_FundoLoading.Enabled = true;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Panel_Loading.Enabled == true)
            {
                ProgressBarCircle_1.Value += 1;
                if (ProgressBarCircle_1.Value == 100)
                {
                    Label_1.Text = "Identificado";
                    Button_2.Visible = true;
                    Button_2.Enabled = true;
                }
            }
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
