namespace SpotiHitssV1
{
    partial class Canciones
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
            this.Lst_Colection = new System.Windows.Forms.ListView();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.ComBx_Search = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lst_Colection
            // 
            this.Lst_Colection.Location = new System.Drawing.Point(12, 12);
            this.Lst_Colection.Name = "Lst_Colection";
            this.Lst_Colection.Size = new System.Drawing.Size(468, 187);
            this.Lst_Colection.TabIndex = 0;
            this.Lst_Colection.UseCompatibleStateImageBehavior = false;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(12, 253);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 1;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // ComBx_Search
            // 
            this.ComBx_Search.AutoCompleteCustomSource.AddRange(new string[] {
            "Artista",
            "Genero",
            "Album",
            "Top10 Mas Likes"});
            this.ComBx_Search.FormattingEnabled = true;
            this.ComBx_Search.Location = new System.Drawing.Point(110, 253);
            this.ComBx_Search.Name = "ComBx_Search";
            this.ComBx_Search.Size = new System.Drawing.Size(121, 21);
            this.ComBx_Search.TabIndex = 2;
            this.ComBx_Search.SelectedIndexChanged += new System.EventHandler(this.ComBx_Search_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar Por:";
            // 
            // Canciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComBx_Search);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Lst_Colection);
            this.Name = "Canciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Canciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Lst_Colection;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.ComboBox ComBx_Search;
        private System.Windows.Forms.Label label1;
    }
}