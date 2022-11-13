namespace Messenger_Interface
{
    partial class LoginPerson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roundButton1 = new Custom.RoundButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Times New Roman", 21.73585F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userName.Location = new System.Drawing.Point(43, 56);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(240, 44);
            this.userName.TabIndex = 1;
            // 
            // Host
            // 
            this.Host.Font = new System.Drawing.Font("Times New Roman", 21.73585F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Host.Location = new System.Drawing.Point(43, 168);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(240, 44);
            this.Host.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Host";
            // 
            // Port
            // 
            this.Port.Font = new System.Drawing.Font("Times New Roman", 21.73585F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Port.Location = new System.Drawing.Point(43, 277);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(240, 44);
            this.Port.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton1.BackColor2 = System.Drawing.Color.Silver;
            this.roundButton1.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton1.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton1.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton1.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton1.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton1.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton1.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton1.ButtonRoundRadius = 30;
            this.roundButton1.Font = new System.Drawing.Font("Times New Roman", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundButton1.Location = new System.Drawing.Point(43, 346);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(240, 75);
            this.roundButton1.TabIndex = 6;
            this.roundButton1.Text = "Continue";
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // LoginPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(349, 449);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Name = "LoginPerson";
            this.Text = "LoginPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox userName;
        private TextBox Host;
        private Label label2;
        private TextBox Port;
        private Label label3;
        private Custom.RoundButton roundButton1;
    }
}