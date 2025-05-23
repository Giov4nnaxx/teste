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
            btnFinalizar = new Button();
            total = new Label();
            pictureBox1 = new PictureBox();
            numericQuant = new NumericUpDown();
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            listNomes = new ListBox();
            btnNomes = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            checkBox1 = new CheckBox();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQuant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(230, 255, 0);
            btnAdicionar.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.Black;
            btnAdicionar.Location = new Point(833, 195);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(83, 32);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(230, 255, 0);
            btnRemover.Font = new Font("Inter", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemover.ForeColor = Color.Black;
            btnRemover.Location = new Point(833, 254);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(83, 32);
            btnRemover.TabIndex = 1;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // lblProdutos
            // 
            lblProdutos.BackColor = Color.FromArgb(202, 196, 183);
            lblProdutos.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProdutos.ForeColor = Color.FromArgb(17, 25, 12);
            lblProdutos.FormattingEnabled = true;
            lblProdutos.Location = new Point(465, 152);
            lblProdutos.Name = "lblProdutos";
            lblProdutos.Size = new Size(277, 334);
            lblProdutos.TabIndex = 2;
            lblProdutos.SelectedIndexChanged += lblProdutos_SelectedIndexChanged;
            // 
            // lblCarrinho
            // 
            lblCarrinho.BackColor = Color.FromArgb(202, 196, 183);
            lblCarrinho.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarrinho.ForeColor = Color.FromArgb(17, 25, 12);
            lblCarrinho.FormattingEnabled = true;
            lblCarrinho.Location = new Point(1015, 152);
            lblCarrinho.Name = "lblCarrinho";
            lblCarrinho.Size = new Size(280, 334);
            lblCarrinho.TabIndex = 3;
            lblCarrinho.SelectedIndexChanged += lblCarrinho_SelectedIndexChanged;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.FromArgb(230, 255, 0);
            btnFinalizar.Font = new Font("Inter", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFinalizar.ForeColor = Color.FromArgb(17, 25, 12);
            btnFinalizar.Location = new Point(769, 319);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(201, 54);
            btnFinalizar.TabIndex = 4;
            btnFinalizar.Text = "Finalizar Pedido";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += button1_Click;
            // 
            // total
            // 
            total.AutoSize = true;
            total.BackColor = Color.Transparent;
            total.Font = new Font("Agrandir", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total.ForeColor = Color.FromArgb(17, 25, 12);
            total.Location = new Point(1028, 84);
            total.Name = "total";
            total.Size = new Size(255, 32);
            total.TabIndex = 6;
            total.Text = "Total a pagar:R$ 0,00";
            total.Click += total_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_05_15_081445_removebg_preview;
            pictureBox1.Location = new Point(-3, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(902, 481);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // numericQuant
            // 
            numericQuant.Location = new Point(315, 292);
            numericQuant.Name = "numericQuant";
            numericQuant.Size = new Size(120, 23);
            numericQuant.TabIndex = 9;
            numericQuant.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(230, 255, 0);
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Agrandir", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 25, 12);
            label1.Location = new Point(315, 258);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 10;
            label1.Text = "Quantidade";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(243, 241, 238);
            txtNome.Location = new Point(12, 108);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(266, 23);
            txtNome.TabIndex = 12;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(230, 255, 0);
            label2.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(17, 25, 12);
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(188, 21);
            label2.TabIndex = 13;
            label2.Text = "Insira o nome do cliente";
            label2.Click += label2_Click_1;
            // 
            // listNomes
            // 
            listNomes.BackColor = Color.FromArgb(202, 196, 183);
            listNomes.Font = new Font("Inter", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listNomes.ForeColor = Color.FromArgb(17, 25, 12);
            listNomes.FormattingEnabled = true;
            listNomes.Location = new Point(12, 152);
            listNomes.Name = "listNomes";
            listNomes.Size = new Size(266, 94);
            listNomes.TabIndex = 14;
            listNomes.SelectedIndexChanged += listNomes_SelectedIndexChanged;
            // 
            // btnNomes
            // 
            btnNomes.BackColor = Color.FromArgb(230, 255, 0);
            btnNomes.BackgroundImageLayout = ImageLayout.None;
            btnNomes.Font = new Font("Inter", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNomes.ForeColor = Color.FromArgb(17, 25, 12);
            btnNomes.Location = new Point(299, 103);
            btnNomes.Name = "btnNomes";
            btnNomes.Size = new Size(91, 30);
            btnNomes.TabIndex = 15;
            btnNomes.Text = "Adicionar";
            btnNomes.UseVisualStyleBackColor = false;
            btnNomes.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pix", "Cartão", "Dinheiro" });
            comboBox1.Location = new Point(823, 444);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(108, 23);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(17, 25, 12);
            label3.Location = new Point(791, 409);
            label3.Name = "label3";
            label3.Size = new Size(168, 21);
            label3.TabIndex = 17;
            label3.Text = "Forma de Pagamento";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bolt_logo__1_;
            pictureBox2.Location = new Point(571, -29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(259, 178);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Agrandir", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(836, 482);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(80, 24);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Viagem";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(21, 566);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(84, 23);
            dateTimePicker2.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(465, 128);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 21;
            label4.Text = "Produtos";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1015, 128);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 22;
            label5.Text = "Carrinho";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1347, 612);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(btnNomes);
            Controls.Add(listNomes);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(numericQuant);
            Controls.Add(total);
            Controls.Add(btnFinalizar);
            Controls.Add(lblCarrinho);
            Controls.Add(lblProdutos);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cantina";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQuant).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private Button btnRemover;
        private ListBox lblProdutos;
        private ListBox lblCarrinho;
        private Button btnFinalizar;
        private Label total;
        private PictureBox pictureBox1;
        private NumericUpDown numericQuant;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private ListBox listNomes;
        private Button btnNomes;
        private ComboBox comboBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Label label5;
    }
}
