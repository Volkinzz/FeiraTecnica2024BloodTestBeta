using static Guna.UI2.WinForms.Suite.Descriptions;
using System.Xml.Linq;

namespace FeiraTecnica2024BloodTestBeta.UsersControl
{
    partial class UC_BloodResult
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BloodResult));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            porcentagem_sangue = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Panel_controlUsers_ExtraSangue = new Guna.UI2.WinForms.Guna2Panel();
            guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            Panel_controlUsers_ExtraSangue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // porcentagem_sangue
            // 
            porcentagem_sangue.BackColor = Color.Transparent;
            porcentagem_sangue.FillColor = Color.FromArgb(200, 213, 218, 223);
            porcentagem_sangue.Font = new Font("JetBrains Mono NL", 35.9999962F);
            porcentagem_sangue.ForeColor = Color.White;
            porcentagem_sangue.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            porcentagem_sangue.Location = new Point(36, 24);
            porcentagem_sangue.Minimum = 0;
            porcentagem_sangue.Name = "porcentagem_sangue";
            porcentagem_sangue.ProgressColor = Color.FromArgb(220, 46, 71);
            porcentagem_sangue.ProgressColor2 = Color.FromArgb(220, 46, 71);
            porcentagem_sangue.RightToLeft = RightToLeft.No;
            porcentagem_sangue.ShadowDecoration.CustomizableEdges = customizableEdges10;
            porcentagem_sangue.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            porcentagem_sangue.ShowText = true;
            porcentagem_sangue.Size = new Size(151, 151);
            porcentagem_sangue.TabIndex = 10;
            porcentagem_sangue.Text = "guna2CircleProgressBar1";
            porcentagem_sangue.Value = 54;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.None;
            guna2Panel1.BackColor = Color.Gray;
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(porcentagem_sangue);
            guna2Panel1.CustomizableEdges = customizableEdges11;
            guna2Panel1.ForeColor = Color.Transparent;
            guna2Panel1.Location = new Point(535, 35);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel1.Size = new Size(231, 335);
            guna2Panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono NL", 15.9999962F);
            label1.Location = new Point(7, 203);
            label1.Name = "label1";
            label1.Size = new Size(221, 116);
            label1.TabIndex = 12;
            label1.Text = "O sangue A+ está\r\npresente em 54% \r\nda população\r\nbrasileira";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 12;
            guna2Elipse1.TargetControl = guna2Panel1;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 500;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Anchor = AnchorStyles.None;
            guna2Separator1.Location = new Point(256, 125);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(273, 10);
            guna2Separator1.TabIndex = 7;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.Anchor = AnchorStyles.None;
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            guna2PictureBox1.CustomizableEdges = customizableEdges13;
            guna2PictureBox1.FillColor = SystemColors.ControlText;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.InitialImage = null;
            guna2PictureBox1.Location = new Point(288, 141);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2PictureBox1.Size = new Size(195, 199);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 5;
            guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.Anchor = AnchorStyles.None;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("JetBrains Mono NL", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = SystemColors.ButtonHighlight;
            guna2HtmlLabel1.Location = new Point(260, 74);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(269, 45);
            guna2HtmlLabel1.TabIndex = 6;
            guna2HtmlLabel1.Text = "Tipo Sanguíneo";
            // 
            // Panel_controlUsers_ExtraSangue
            // 
            Panel_controlUsers_ExtraSangue.Anchor = AnchorStyles.None;
            Panel_controlUsers_ExtraSangue.BackColor = Color.Gray;
            Panel_controlUsers_ExtraSangue.Controls.Add(guna2PictureBox2);
            Panel_controlUsers_ExtraSangue.CustomizableEdges = customizableEdges17;
            Panel_controlUsers_ExtraSangue.Location = new Point(31, 35);
            Panel_controlUsers_ExtraSangue.Name = "Panel_controlUsers_ExtraSangue";
            Panel_controlUsers_ExtraSangue.ShadowDecoration.CustomizableEdges = customizableEdges18;
            Panel_controlUsers_ExtraSangue.Size = new Size(217, 335);
            Panel_controlUsers_ExtraSangue.TabIndex = 12;
            // 
            // guna2PictureBox2
            // 
            guna2PictureBox2.CustomizableEdges = customizableEdges15;
            guna2PictureBox2.Image = (Image)resources.GetObject("guna2PictureBox2.Image");
            guna2PictureBox2.ImageRotate = 0F;
            guna2PictureBox2.Location = new Point(-8, 0);
            guna2PictureBox2.Name = "guna2PictureBox2";
            guna2PictureBox2.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2PictureBox2.Size = new Size(225, 335);
            guna2PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox2.TabIndex = 0;
            guna2PictureBox2.TabStop = false;
            // 
            // UC_BloodResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(guna2PictureBox1);
            Controls.Add(Panel_controlUsers_ExtraSangue);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2Separator1);
            Controls.Add(guna2Panel1);
            Name = "UC_BloodResult";
            Size = new Size(801, 415);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            Panel_controlUsers_ExtraSangue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleProgressBar porcentagem_sangue;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel Panel_controlUsers_ExtraSangue;
        private Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}
