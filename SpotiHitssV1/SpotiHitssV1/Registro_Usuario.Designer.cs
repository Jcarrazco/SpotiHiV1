﻿namespace SpotiHitssV1
{
    partial class Registro_Usuario
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
            this.Txbx_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txbx_Mail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txbx_Password = new System.Windows.Forms.TextBox();
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario";
            // 
            // Txbx_Usuario
            // 
            this.Txbx_Usuario.Location = new System.Drawing.Point(90, 25);
            this.Txbx_Usuario.Name = "Txbx_Usuario";
            this.Txbx_Usuario.Size = new System.Drawing.Size(100, 20);
            this.Txbx_Usuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-Mail";
            // 
            // Txbx_Mail
            // 
            this.Txbx_Mail.Location = new System.Drawing.Point(90, 75);
            this.Txbx_Mail.Name = "Txbx_Mail";
            this.Txbx_Mail.Size = new System.Drawing.Size(100, 20);
            this.Txbx_Mail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PassWord";
            // 
            // Txbx_Password
            // 
            this.Txbx_Password.Location = new System.Drawing.Point(90, 125);
            this.Txbx_Password.Name = "Txbx_Password";
            this.Txbx_Password.Size = new System.Drawing.Size(100, 20);
            this.Txbx_Password.TabIndex = 5;
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.Location = new System.Drawing.Point(104, 161);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Registrar.TabIndex = 6;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.UseVisualStyleBackColor = true;
            // 
            // Registro_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 196);
            this.Controls.Add(this.Btn_Registrar);
            this.Controls.Add(this.Txbx_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txbx_Mail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txbx_Usuario);
            this.Controls.Add(this.label1);
            this.Name = "Registro_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txbx_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txbx_Mail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txbx_Password;
        private System.Windows.Forms.Button Btn_Registrar;
    }
}