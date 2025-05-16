namespace WinFormsApp7
{
    partial class Form1
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
            btnAdicionar = new Button();
            btnRemover = new Button();
            lblProdutos = new ListBox();
            lblCarrinho = new ListBox();
            button1 = new Button();
            total = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            numericQuant = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQuant).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(230, 255, 0);
            btnAdicionar.Font = new Font("Perpetua", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.Black;
            btnAdicionar.Location = new Point(314, 214);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(230, 255, 0);
            btnRemover.Font = new Font("Perpetua", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemover.ForeColor = Color.Black;
            btnRemover.Location = new Point(482, 214);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 1;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // lblProdutos
            // 
            lblProdutos.BackColor = Color.Black;
            lblProdutos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProdutos.ForeColor = Color.FromArgb(243, 241, 238);
            lblProdutos.FormattingEnabled = true;
            lblProdutos.Location = new Point(31, 134);
            lblProdutos.Name = "lblProdutos";
            lblProdutos.Size = new Size(249, 104);
            lblProdutos.TabIndex = 2;
            lblProdutos.SelectedIndexChanged += lblProdutos_SelectedIndexChanged;
            // 
            // lblCarrinho
            // 
            lblCarrinho.BackColor = Color.Black;
            lblCarrinho.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarrinho.ForeColor = Color.FromArgb(243, 241, 238);
            lblCarrinho.FormattingEnabled = true;
            lblCarrinho.Location = new Point(587, 134);
            lblCarrinho.Name = "lblCarrinho";
            lblCarrinho.Size = new Size(253, 104);
            lblCarrinho.TabIndex = 3;
            lblCarrinho.SelectedIndexChanged += lblCarrinho_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(230, 255, 0);
            button1.Font = new Font("Perpetua", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(314, 290);
            button1.Name = "button1";
            button1.Size = new Size(232, 58);
            button1.TabIndex = 4;
            button1.Text = "Finalizar Pedido";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // total
            // 
            total.AutoSize = true;
            total.BackColor = Color.Transparent;
            total.Font = new Font("Segoe UI", 20F);
            total.ForeColor = Color.FromArgb(243, 241, 238);
            total.Location = new Point(291, 389);
            total.Name = "total";
            total.Size = new Size(266, 37);
            total.TabIndex = 6;
            total.Text = "Total a pagar:R$ 0,00";
            total.Click += total_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_05_15_081445_removebg_preview;
            pictureBox1.Location = new Point(-8, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(670, 372);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_tela_2025_05_15_082457_removebg_preview;
            pictureBox2.Location = new Point(413, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(249, 127);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // numericQuant
            // 
            numericQuant.Location = new Point(76, 312);
            numericQuant.Name = "numericQuant";
            numericQuant.Size = new Size(120, 23);
            numericQuant.TabIndex = 9;
            numericQuant.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(243, 241, 238);
            label1.Location = new Point(76, 263);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 10;
            label1.Text = "Quantidade";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(861, 472);
            Controls.Add(label1);
            Controls.Add(numericQuant);
            Controls.Add(total);
            Controls.Add(button1);
            Controls.Add(lblCarrinho);
            Controls.Add(lblProdutos);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cantina";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQuant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private Button btnRemover;
        private ListBox lblProdutos;
        private ListBox lblCarrinho;
        private Button button1;
        private Label total;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private NumericUpDown numericQuant;
        private Label label1;
    }
}
