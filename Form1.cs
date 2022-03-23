using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class Form1 : Form
    {
        private Button btn1;
        private Button btn2;
        private Label password;
        private Label user;
        private TextBox textpassword;
        private Button btn3;
        private TextBox textusername;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.textusername = new System.Windows.Forms.TextBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(476, 263);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(84, 32);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Login";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(616, 263);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(164, 32);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Forgotten Password";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(363, 147);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(78, 20);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(363, 47);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(83, 20);
            this.user.TabIndex = 3;
            this.user.Text = "Username";
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(494, 147);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(212, 26);
            this.textpassword.TabIndex = 4;
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(494, 47);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(212, 26);
            this.textusername.TabIndex = 5;
            this.textusername.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(826, 263);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 32);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "Clear";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1459, 506);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.user);
            this.Controls.Add(this.password);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(textusername.Text=="admin" && textpassword.Text=="admin")
            {
                MessageBox.Show("done");
            }
            else
            {
                MessageBox.Show("fail");
            }
        }
    }
}
