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
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.DeepPink;
            btnAdicionar.Font = new Font("Perpetua", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = SystemColors.ButtonFace;
            btnAdicionar.Location = new Point(285, 214);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.DeepPink;
            btnRemover.Font = new Font("Perpetua", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemover.ForeColor = Color.WhiteSmoke;
            btnRemover.Location = new Point(442, 214);
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
            lblProdutos.Font = new Font("Segoe UI", 12F);
            lblProdutos.ForeColor = Color.DeepPink;
            lblProdutos.FormattingEnabled = true;
            lblProdutos.Location = new Point(25, 224);
            lblProdutos.Name = "lblProdutos";
            lblProdutos.Size = new Size(201, 214);
            lblProdutos.TabIndex = 2;
            lblProdutos.SelectedIndexChanged += lblProdutos_SelectedIndexChanged;
            // 
            // lblCarrinho
            // 
            lblCarrinho.BackColor = Color.Black;
            lblCarrinho.Font = new Font("Segoe UI", 12F);
            lblCarrinho.ForeColor = Color.DeepPink;
            lblCarrinho.FormattingEnabled = true;
            lblCarrinho.Location = new Point(586, 224);
            lblCarrinho.Name = "lblCarrinho";
            lblCarrinho.Size = new Size(191, 214);
            lblCarrinho.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepPink;
            button1.Font = new Font("Perpetua", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(285, 290);
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
            total.Font = new Font("Segoe UI", 20F);
            total.ForeColor = Color.White;
            total.Location = new Point(268, 379);
            total.Name = "total";
            total.Size = new Size(266, 37);
            total.TabIndex = 6;
            total.Text = "Total a pagar:R$ 0,00";
            total.Click += total_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Barbie_Logo_svg;
            pictureBox1.Location = new Point(417, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SWScrpc", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(248, 24);
            label2.Name = "label2";
            label2.Size = new Size(190, 45);
            label2.TabIndex = 9;
            label2.Text = "Cantina da ";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 

            // Update the line causing the error
            // Update the line causing the error
            pictureBox2.Image = WinFormsApp7.Properties.Resources.download_removebg_preview;
            //pictureBox2.Image = Resources.download_removebg_preview;
            // Update the line causing the error
            pictureBox2.Image = Properties.Resources.download_removebg_preview;
            pictureBox2.Location = new Point(473, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(327, 426);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.b1dcf94c48b9b069e81c6217fbced8ce_removebg_preview;
            pictureBox3.Location = new Point(37, 87);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(129, 116);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(total);
            Controls.Add(button1);
            Controls.Add(lblCarrinho);
            Controls.Add(lblProdutos);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(pictureBox2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cantina";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
