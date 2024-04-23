namespace CelularCTI.Desktop
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnPesquisarFabricante = new System.Windows.Forms.Button();
            this.btnPesquisarModelo = new System.Windows.Forms.Button();
            this.btnPesquisarPreco = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numPrecoFinal = new System.Windows.Forms.NumericUpDown();
            this.numPrecoInicial = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstCelulares = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoInicial)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFabricante);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.btnPesquisarFabricante);
            this.groupBox1.Controls.Add(this.btnPesquisarModelo);
            this.groupBox1.Controls.Add(this.btnPesquisarPreco);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numPrecoFinal);
            this.groupBox1.Controls.Add(this.numPrecoInicial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(672, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por:  ";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(123, 122);
            this.cmbFabricante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(343, 27);
            this.cmbFabricante.TabIndex = 10;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(123, 77);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(347, 27);
            this.txtModelo.TabIndex = 9;
            // 
            // btnPesquisarFabricante
            // 
            this.btnPesquisarFabricante.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarFabricante.Location = new System.Drawing.Point(495, 119);
            this.btnPesquisarFabricante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisarFabricante.Name = "btnPesquisarFabricante";
            this.btnPesquisarFabricante.Size = new System.Drawing.Size(82, 28);
            this.btnPesquisarFabricante.TabIndex = 8;
            this.btnPesquisarFabricante.Text = ">>";
            this.btnPesquisarFabricante.UseVisualStyleBackColor = true;
            this.btnPesquisarFabricante.Click += new System.EventHandler(this.btnPesquisarFabricante_Click);
            // 
            // btnPesquisarModelo
            // 
            this.btnPesquisarModelo.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarModelo.Location = new System.Drawing.Point(495, 77);
            this.btnPesquisarModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisarModelo.Name = "btnPesquisarModelo";
            this.btnPesquisarModelo.Size = new System.Drawing.Size(82, 28);
            this.btnPesquisarModelo.TabIndex = 7;
            this.btnPesquisarModelo.Text = ">>";
            this.btnPesquisarModelo.UseVisualStyleBackColor = true;
            this.btnPesquisarModelo.Click += new System.EventHandler(this.btnPesquisarModelo_Click);
            // 
            // btnPesquisarPreco
            // 
            this.btnPesquisarPreco.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPreco.Location = new System.Drawing.Point(495, 36);
            this.btnPesquisarPreco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisarPreco.Name = "btnPesquisarPreco";
            this.btnPesquisarPreco.Size = new System.Drawing.Size(82, 28);
            this.btnPesquisarPreco.TabIndex = 6;
            this.btnPesquisarPreco.Text = ">>";
            this.btnPesquisarPreco.UseVisualStyleBackColor = true;
            this.btnPesquisarPreco.Click += new System.EventHandler(this.btnPesquisarPreco_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "a";
            // 
            // numPrecoFinal
            // 
            this.numPrecoFinal.DecimalPlaces = 2;
            this.numPrecoFinal.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPrecoFinal.Location = new System.Drawing.Point(319, 34);
            this.numPrecoFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPrecoFinal.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.numPrecoFinal.Name = "numPrecoFinal";
            this.numPrecoFinal.Size = new System.Drawing.Size(151, 27);
            this.numPrecoFinal.TabIndex = 4;
            this.numPrecoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrecoFinal.ThousandsSeparator = true;
            // 
            // numPrecoInicial
            // 
            this.numPrecoInicial.DecimalPlaces = 2;
            this.numPrecoInicial.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPrecoInicial.Location = new System.Drawing.Point(123, 34);
            this.numPrecoInicial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPrecoInicial.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.numPrecoInicial.Name = "numPrecoInicial";
            this.numPrecoInicial.Size = new System.Drawing.Size(151, 27);
            this.numPrecoInicial.TabIndex = 3;
            this.numPrecoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrecoInicial.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fabricante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preço: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstCelulares);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 215);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(696, 389);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Celulares : ";
            // 
            // lstCelulares
            // 
            this.lstCelulares.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCelulares.FormattingEnabled = true;
            this.lstCelulares.ItemHeight = 19;
            this.lstCelulares.Location = new System.Drawing.Point(24, 30);
            this.lstCelulares.Name = "lstCelulares";
            this.lstCelulares.Size = new System.Drawing.Size(649, 346);
            this.lstCelulares.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSair);
            this.groupBox3.Controls.Add(this.btnComprar);
            this.groupBox3.Controls.Add(this.btnNovo);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(26, 644);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(666, 86);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(483, 40);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(109, 28);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Location = new System.Drawing.Point(103, 40);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(109, 28);
            this.btnComprar.TabIndex = 10;
            this.btnComprar.Text = "&Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(291, 40);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(109, 28);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTodos.Location = new System.Drawing.Point(299, 616);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(139, 32);
            this.btnListarTodos.TabIndex = 10;
            this.btnListarTodos.Text = "Listar todos";
            this.btnListarTodos.UseVisualStyleBackColor = true;
            this.btnListarTodos.Click += new System.EventHandler(this.btnListarTodos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 731);
            this.Controls.Add(this.btnListarTodos);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Loja CelularCTi - O seu mundo mobile";
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoInicial)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numPrecoInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btnPesquisarFabricante;
        private System.Windows.Forms.Button btnPesquisarModelo;
        private System.Windows.Forms.Button btnPesquisarPreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPrecoFinal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.ListBox lstCelulares;
        private System.Windows.Forms.Button btnListarTodos;
    }
}

