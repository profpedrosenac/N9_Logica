namespace Aula04
{
    partial class frmVendas
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
            this.btoPIX = new System.Windows.Forms.Button();
            this.btoCartao = new System.Windows.Forms.Button();
            this.btoCredito = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.cboValor = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btoPIX
            // 
            this.btoPIX.Location = new System.Drawing.Point(827, 12);
            this.btoPIX.Name = "btoPIX";
            this.btoPIX.Size = new System.Drawing.Size(136, 49);
            this.btoPIX.TabIndex = 3;
            this.btoPIX.Text = "PIX/Money";
            this.btoPIX.UseVisualStyleBackColor = true;
            this.btoPIX.Click += new System.EventHandler(this.btoPIX_Click);
            // 
            // btoCartao
            // 
            this.btoCartao.Location = new System.Drawing.Point(827, 67);
            this.btoCartao.Name = "btoCartao";
            this.btoCartao.Size = new System.Drawing.Size(136, 49);
            this.btoCartao.TabIndex = 4;
            this.btoCartao.Text = "A Vista";
            this.btoCartao.UseVisualStyleBackColor = true;
            this.btoCartao.Click += new System.EventHandler(this.btoCartao_Click);
            // 
            // btoCredito
            // 
            this.btoCredito.Location = new System.Drawing.Point(827, 122);
            this.btoCredito.Name = "btoCredito";
            this.btoCredito.Size = new System.Drawing.Size(136, 49);
            this.btoCredito.TabIndex = 5;
            this.btoCredito.Text = "Crédito";
            this.btoCredito.UseVisualStyleBackColor = true;
            this.btoCredito.Click += new System.EventHandler(this.btoCredito_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(827, 177);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(136, 49);
            this.btoLimpar.TabIndex = 6;
            this.btoLimpar.Text = "Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(827, 232);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(136, 49);
            this.btoSair.TabIndex = 7;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(689, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qtde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Valor Unitário";
            // 
            // cboProduto
            // 
            this.cboProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Items.AddRange(new object[] {
            "Salada Pronta",
            "Granola Artesanal",
            "Ovos Orgânicos",
            "Refeições Prontas",
            "Suco de Frutas Naturais",
            "Azeite Extra Virgem",
            "Kit de Lanches Fitness",
            "Barra de Cereais Multigrãos",
            "Tempero para Churrasco",
            "Mousse de Chocolate Belga"});
            this.cboProduto.Location = new System.Drawing.Point(12, 45);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(391, 38);
            this.cboProduto.TabIndex = 0;
            this.cboProduto.SelectedIndexChanged += new System.EventHandler(this.cboProduto_SelectedIndexChanged);
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(689, 47);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(132, 36);
            this.txtQtde.TabIndex = 2;
            // 
            // cboValor
            // 
            this.cboValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboValor.Enabled = false;
            this.cboValor.FormattingEnabled = true;
            this.cboValor.Items.AddRange(new object[] {
            "R$ 12,99",
            "R$ 8,49",
            "R$ 6,99",
            "R$ 14,99",
            "R$ 5,79",
            "R$ 19,99",
            "R$ 24,99",
            "R$ 3,49",
            "R$ 7,99",
            "R$ 9,99"});
            this.cboValor.Location = new System.Drawing.Point(409, 45);
            this.cboValor.Name = "cboValor";
            this.cboValor.Size = new System.Drawing.Size(274, 38);
            this.cboValor.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(12, 86);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(809, 195);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "R$ 0,00";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 291);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cboValor);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.cboProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btoSair);
            this.Controls.Add(this.btoLimpar);
            this.Controls.Add(this.btoCredito);
            this.Controls.Add(this.btoCartao);
            this.Controls.Add(this.btoPIX);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btoPIX;
        private Button btoCartao;
        private Button btoCredito;
        private Button btoLimpar;
        private Button btoSair;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboProduto;
        private TextBox txtQtde;
        private ComboBox cboValor;
        private Label lblResult;
    }
}