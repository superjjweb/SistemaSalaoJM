namespace GUI
{
    partial class frmPrincipal
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
            this.grpCadastros = new System.Windows.Forms.GroupBox();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpCadastros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCadastros
            // 
            this.grpCadastros.Controls.Add(this.btnPerfil);
            this.grpCadastros.Controls.Add(this.btnCategoria);
            this.grpCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCadastros.Location = new System.Drawing.Point(386, 7);
            this.grpCadastros.Name = "grpCadastros";
            this.grpCadastros.Size = new System.Drawing.Size(545, 129);
            this.grpCadastros.TabIndex = 2;
            this.grpCadastros.TabStop = false;
            this.grpCadastros.Text = "Cadastros";
            // 
            // btnPerfil
            // 
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.Image = global::GUI.Properties.Resources._1463022360_user_group;
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPerfil.Location = new System.Drawing.Point(122, 19);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(110, 92);
            this.btnPerfil.TabIndex = 3;
            this.btnPerfil.Text = "Perfil Usuário";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Image = global::GUI.Properties.Resources.categoria;
            this.btnCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCategoria.Location = new System.Drawing.Point(6, 19);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(110, 92);
            this.btnCategoria.TabIndex = 1;
            this.btnCategoria.Text = "Categorias";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.novo_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 455);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpCadastros);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.grpCadastros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.GroupBox grpCadastros;
        private System.Windows.Forms.Button btnPerfil;
    }
}