namespace Aula31_Intermediario
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlancar = new System.Windows.Forms.Button();
            this.listprodutos = new System.Windows.Forms.ListBox();
            this.listpreços = new System.Windows.Forms.ListBox();
            this.lblprecototal = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtproduto
            // 
            this.txtproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproduto.Location = new System.Drawing.Point(12, 57);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(187, 29);
            this.txtproduto.TabIndex = 0;
            this.txtproduto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtpreco
            // 
            this.txtpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreco.Location = new System.Drawing.Point(231, 57);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(187, 29);
            this.txtpreco.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço";
            // 
            // btnlancar
            // 
            this.btnlancar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnlancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlancar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlancar.Location = new System.Drawing.Point(469, 28);
            this.btnlancar.Name = "btnlancar";
            this.btnlancar.Size = new System.Drawing.Size(134, 58);
            this.btnlancar.TabIndex = 2;
            this.btnlancar.Text = "Lançar";
            this.btnlancar.UseVisualStyleBackColor = false;
            this.btnlancar.Click += new System.EventHandler(this.button1_Click);
            // 
            // listprodutos
            // 
            this.listprodutos.FormattingEnabled = true;
            this.listprodutos.Location = new System.Drawing.Point(33, 240);
            this.listprodutos.Name = "listprodutos";
            this.listprodutos.Size = new System.Drawing.Size(239, 290);
            this.listprodutos.TabIndex = 3;
            // 
            // listpreços
            // 
            this.listpreços.FormattingEnabled = true;
            this.listpreços.Location = new System.Drawing.Point(361, 240);
            this.listpreços.Name = "listpreços";
            this.listpreços.Size = new System.Drawing.Size(242, 303);
            this.listpreços.TabIndex = 4;
            // 
            // lblprecototal
            // 
            this.lblprecototal.AutoSize = true;
            this.lblprecototal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecototal.ForeColor = System.Drawing.Color.Purple;
            this.lblprecototal.Location = new System.Drawing.Point(638, 316);
            this.lblprecototal.Name = "lblprecototal";
            this.lblprecototal.Size = new System.Drawing.Size(152, 24);
            this.lblprecototal.TabIndex = 5;
            this.lblprecototal.Text = "Total da Venda";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(255, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(796, 319);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(37, 20);
            this.lbltotal.TabIndex = 7;
            this.lbltotal.Text = "R$:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 568);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblprecototal);
            this.Controls.Add(this.listpreços);
            this.Controls.Add(this.listprodutos);
            this.Controls.Add(this.btnlancar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtproduto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlancar;
        private System.Windows.Forms.ListBox listprodutos;
        private System.Windows.Forms.ListBox listpreços;
        private System.Windows.Forms.Label lblprecototal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbltotal;
    }
}

