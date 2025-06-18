namespace WinFormsApp7
{
    partial class Chamada
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
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            listAndamento = new ListBox();
            listPronto = new ListBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(387, 32);
            label1.Name = "label1";
            label1.Size = new Size(134, 36);
            label1.TabIndex = 0;
            label1.Text = "Chamada";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bolt_logo__1_;
            pictureBox2.Location = new Point(580, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_05_15_081445_removebg_preview;
            pictureBox1.Location = new Point(-2, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(699, 390);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // listAndamento
            // 
            listAndamento.BackColor = Color.FromArgb(202, 196, 183);
            listAndamento.Font = new Font("Agrandir", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listAndamento.FormattingEnabled = true;
            listAndamento.Location = new Point(49, 161);
            listAndamento.Name = "listAndamento";
            listAndamento.Size = new Size(258, 277);
            listAndamento.TabIndex = 21;
            // 
            // listPronto
            // 
            listPronto.BackColor = Color.FromArgb(202, 196, 183);
            listPronto.Font = new Font("Agrandir", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listPronto.FormattingEnabled = true;
            listPronto.Location = new Point(471, 161);
            listPronto.Name = "listPronto";
            listPronto.Size = new Size(258, 277);
            listPronto.TabIndex = 22;
            listPronto.SelectedIndexChanged += listPronto_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(230, 255, 0);
            label2.Font = new Font("Agrandir", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 118);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 23;
            label2.Text = "Pedido em Andamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agrandir", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(471, 122);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 24;
            label3.Text = "Pedidos Prontos";
            // 
            // Chamada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(795, 475);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listPronto);
            Controls.Add(listAndamento);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Chamada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chamada";
            Load += Chamada_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ListBox listAndamento;
        private ListBox listPronto;
        private Label label2;
        private Label label3;
    }
}