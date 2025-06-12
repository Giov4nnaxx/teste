namespace WinFormsApp7
{
    partial class Balcao
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            listBalcao = new ListBox();
            listEntregues = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnEntregarCozinha = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bolt_logo__1_;
            pictureBox2.Location = new Point(795, -7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(259, 178);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_05_15_081445_removebg_preview;
            pictureBox1.Location = new Point(-4, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(902, 481);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // listBalcao
            // 
            listBalcao.BackColor = Color.FromArgb(202, 196, 183);
            listBalcao.Font = new Font("Agrandir", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBalcao.ForeColor = Color.FromArgb(17, 25, 12);
            listBalcao.FormattingEnabled = true;
            listBalcao.Location = new Point(22, 115);
            listBalcao.Name = "listBalcao";
            listBalcao.Size = new Size(527, 193);
            listBalcao.TabIndex = 21;
            listBalcao.SelectedIndexChanged += listBalcao_SelectedIndexChanged;
            // 
            // listEntregues
            // 
            listEntregues.BackColor = Color.FromArgb(202, 196, 183);
            listEntregues.Font = new Font("Agrandir", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listEntregues.ForeColor = Color.FromArgb(17, 25, 12);
            listEntregues.FormattingEnabled = true;
            listEntregues.Location = new Point(22, 407);
            listEntregues.Name = "listEntregues";
            listEntregues.Size = new Size(527, 193);
            listEntregues.TabIndex = 22;
            listEntregues.SelectedIndexChanged += listEntregues_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 370);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 23;
            label1.Text = "Pedidos Entregues";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(230, 255, 0);
            label2.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 76);
            label2.Name = "label2";
            label2.Size = new Size(132, 21);
            label2.TabIndex = 24;
            label2.Text = "Pedidos Prontos";
            // 
            // btnEntregarCozinha
            // 
            btnEntregarCozinha.BackColor = Color.FromArgb(230, 255, 0);
            btnEntregarCozinha.Font = new Font("Inter", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntregarCozinha.Location = new Point(649, 267);
            btnEntregarCozinha.Name = "btnEntregarCozinha";
            btnEntregarCozinha.Size = new Size(197, 50);
            btnEntregarCozinha.TabIndex = 25;
            btnEntregarCozinha.Text = "Entregar";
            btnEntregarCozinha.UseVisualStyleBackColor = false;
            btnEntregarCozinha.Click += btnEntregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agrandir", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(448, 21);
            label3.Name = "label3";
            label3.Size = new Size(101, 36);
            label3.TabIndex = 26;
            label3.Text = "Balcão";
            // 
            // Balcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1066, 640);
            Controls.Add(label3);
            Controls.Add(btnEntregarCozinha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listEntregues);
            Controls.Add(listBalcao);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Balcao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balcao";
            Load += Balcao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ListBox listBalcao;
        private ListBox listEntregues;
        private Label label1;
        private Label label2;
        private Button btnEntregarCozinha;
        private Label label3;
    }
}