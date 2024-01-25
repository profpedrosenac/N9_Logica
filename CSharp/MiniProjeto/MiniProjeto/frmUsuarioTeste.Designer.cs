namespace MiniProjeto
{
    partial class frmUsuarioTeste
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboNomeUsuario = new System.Windows.Forms.ComboBox();
            this.cboIDUsuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // cboNomeUsuario
            // 
            this.cboNomeUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNomeUsuario.FormattingEnabled = true;
            this.cboNomeUsuario.Location = new System.Drawing.Point(12, 47);
            this.cboNomeUsuario.Name = "cboNomeUsuario";
            this.cboNomeUsuario.Size = new System.Drawing.Size(372, 33);
            this.cboNomeUsuario.TabIndex = 1;
            // 
            // cboIDUsuario
            // 
            this.cboIDUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboIDUsuario.Enabled = false;
            this.cboIDUsuario.FormattingEnabled = true;
            this.cboIDUsuario.Location = new System.Drawing.Point(390, 47);
            this.cboIDUsuario.Name = "cboIDUsuario";
            this.cboIDUsuario.Size = new System.Drawing.Size(174, 33);
            this.cboIDUsuario.TabIndex = 1;
            // 
            // frmUsuarioTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 109);
            this.Controls.Add(this.cboIDUsuario);
            this.Controls.Add(this.cboNomeUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmUsuarioTeste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuarioTeste";
            this.Load += new System.EventHandler(this.frmUsuarioTeste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboNomeUsuario;
        private ComboBox cboIDUsuario;
    }
}