namespace WinFormsApp7
{
    partial class Cozinha
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            listCozinha = new ListBox();
            btnEntregarCozinha = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_05_15_081445_removebg_preview;
            pictureBox1.Location = new Point(-2, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(902, 481);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(230, 255, 0);
            label1.Font = new Font("Agrandir", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 117);
            label1.Name = "label1";
            label1.Size = new Size(185, 21);
            label1.TabIndex = 23;
            label1.Text = "Pedidos em Andamento";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bolt_logo__1_;
            pictureBox2.Location = new Point(747, -6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(259, 178);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // listCozinha
            // 
            listCozinha.BackColor = Color.FromArgb(202, 196, 183);
            listCozinha.Font = new Font("Agrandir", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listCozinha.FormattingEnabled = true;
            listCozinha.Location = new Point(25, 160);
            listCozinha.Name = "listCozinha";
            listCozinha.Size = new Size(595, 256);
            listCozinha.TabIndex = 28;
            // 
            // btnEntregarCozinha
            // 
            btnEntregarCozinha.BackColor = Color.FromArgb(230, 255, 0);
            btnEntregarCozinha.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntregarCozinha.Location = new Point(688, 308);
            btnEntregarCozinha.Name = "btnEntregarCozinha";
            btnEntregarCozinha.Size = new Size(186, 52);
            btnEntregarCozinha.TabIndex = 29;
            btnEntregarCozinha.Text = "Entregar";
            btnEntregarCozinha.UseVisualStyleBackColor = false;
            btnEntregarCozinha.Click += btnEntregarCozinha_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agrandir", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(412, 24);
            label2.Name = "label2";
            label2.Size = new Size(116, 36);
            label2.TabIndex = 30;
            label2.Text = "Cozinha";
            // 
            // Cozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1018, 578);
            Controls.Add(label2);
            Controls.Add(btnEntregarCozinha);
            Controls.Add(listCozinha);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Cozinha";
            Text = "Cozinha";
            Load += Cozinha_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private ListBox listCozinha;
        private Button btnEntregarCozinha;
        private Label label2;
    }
}