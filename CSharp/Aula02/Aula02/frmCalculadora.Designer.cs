namespace Aula02
{
    partial class frmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.btoMais = new System.Windows.Forms.Button();
            this.btoMenos = new System.Windows.Forms.Button();
            this.btoMult = new System.Windows.Forms.Button();
            this.btoDivisao = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoSair = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "N1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "N2";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(12, 42);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(155, 36);
            this.txtN1.TabIndex = 0;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(173, 42);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(155, 36);
            this.txtN2.TabIndex = 1;
            // 
            // btoMais
            // 
            this.btoMais.Location = new System.Drawing.Point(334, 12);
            this.btoMais.Name = "btoMais";
            this.btoMais.Size = new System.Drawing.Size(47, 43);
            this.btoMais.TabIndex = 2;
            this.btoMais.Text = "+";
            this.btoMais.UseVisualStyleBackColor = true;
            this.btoMais.Click += new System.EventHandler(this.btoMais_Click);
            // 
            // btoMenos
            // 
            this.btoMenos.Location = new System.Drawing.Point(387, 12);
            this.btoMenos.Name = "btoMenos";
            this.btoMenos.Size = new System.Drawing.Size(47, 43);
            this.btoMenos.TabIndex = 3;
            this.btoMenos.Text = "-";
            this.btoMenos.UseVisualStyleBackColor = true;
            this.btoMenos.Click += new System.EventHandler(this.btoMenos_Click);
            // 
            // btoMult
            // 
            this.btoMult.Location = new System.Drawing.Point(334, 61);
            this.btoMult.Name = "btoMult";
            this.btoMult.Size = new System.Drawing.Size(47, 43);
            this.btoMult.TabIndex = 4;
            this.btoMult.Text = "x";
            this.btoMult.UseVisualStyleBackColor = true;
            this.btoMult.Click += new System.EventHandler(this.btoMult_Click);
            // 
            // btoDivisao
            // 
            this.btoDivisao.Location = new System.Drawing.Point(387, 61);
            this.btoDivisao.Name = "btoDivisao";
            this.btoDivisao.Size = new System.Drawing.Size(47, 43);
            this.btoDivisao.TabIndex = 5;
            this.btoDivisao.Text = "/";
            this.btoDivisao.UseVisualStyleBackColor = true;
            this.btoDivisao.Click += new System.EventHandler(this.btoDivisao_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(334, 110);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(100, 43);
            this.btoLimpar.TabIndex = 6;
            this.btoLimpar.Text = "CE";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(334, 159);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(100, 43);
            this.btoSair.TabIndex = 7;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResult.Location = new System.Drawing.Point(12, 81);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(316, 121);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 212);
            this.Controls.Add(this.btoSair);
            this.Controls.Add(this.btoLimpar);
            this.Controls.Add(this.btoDivisao);
            this.Controls.Add(this.btoMult);
            this.Controls.Add(this.btoMenos);
            this.Controls.Add(this.btoMais);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtN1;
        private TextBox txtN2;
        private Button btoMais;
        private Button btoMenos;
        private Button btoMult;
        private Button btoDivisao;
        private Button btoLimpar;
        private Button btoSair;
        private Label lblResult;
    }
}