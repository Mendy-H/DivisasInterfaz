namespace DivisasInterfaz
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPesos = new TextBox();
            txtResultado = new TextBox();
            btnEuro = new Button();
            btnDolar = new Button();
            btnLibra = new Button();
            btnYen = new Button();
            btnSalida = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 25);
            label1.TabIndex = 0;
            label1.Text = "CONVERSOR DE DIVISAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 71);
            label2.Name = "label2";
            label2.Size = new Size(251, 25);
            label2.TabIndex = 1;
            label2.Text = "Cantidad en pesos mexicanos:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 125);
            label3.Name = "label3";
            label3.Size = new Size(203, 25);
            label3.TabIndex = 2;
            label3.Text = "Selecciona una moneda:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 312);
            label4.Name = "label4";
            label4.Size = new Size(181, 25);
            label4.TabIndex = 3;
            label4.Text = "La equivalencia es de:";
            label4.Click += label4_Click;
            // 
            // txtPesos
            // 
            txtPesos.Location = new Point(336, 65);
            txtPesos.Name = "txtPesos";
            txtPesos.Size = new Size(150, 31);
            txtPesos.TabIndex = 4;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(336, 312);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(150, 31);
            txtResultado.TabIndex = 5;
            txtResultado.TextChanged += textBox2_TextChanged;
            // 
            // btnEuro
            // 
            btnEuro.BackColor = Color.Violet;
            btnEuro.Location = new Point(336, 130);
            btnEuro.Name = "btnEuro";
            btnEuro.Size = new Size(112, 34);
            btnEuro.TabIndex = 6;
            btnEuro.Text = "EURO";
            btnEuro.UseVisualStyleBackColor = false;
            btnEuro.Click += button1_Click;
            // 
            // btnDolar
            // 
            btnDolar.BackColor = Color.HotPink;
            btnDolar.Location = new Point(336, 170);
            btnDolar.Name = "btnDolar";
            btnDolar.Size = new Size(112, 34);
            btnDolar.TabIndex = 7;
            btnDolar.Text = "DOLAR";
            btnDolar.UseVisualStyleBackColor = false;
            btnDolar.Click += button2_Click;
            // 
            // btnLibra
            // 
            btnLibra.BackColor = Color.DarkTurquoise;
            btnLibra.Location = new Point(336, 210);
            btnLibra.Name = "btnLibra";
            btnLibra.Size = new Size(112, 34);
            btnLibra.TabIndex = 8;
            btnLibra.Text = "LIBRA";
            btnLibra.UseVisualStyleBackColor = false;
            btnLibra.Click += button3_Click;
            // 
            // btnYen
            // 
            btnYen.BackColor = Color.Gold;
            btnYen.Location = new Point(336, 250);
            btnYen.Name = "btnYen";
            btnYen.Size = new Size(112, 34);
            btnYen.TabIndex = 9;
            btnYen.Text = "YEN";
            btnYen.UseVisualStyleBackColor = false;
            btnYen.Click += btnYen_Click;
            // 
            // btnSalida
            // 
            btnSalida.Location = new Point(336, 386);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(112, 34);
            btnSalida.TabIndex = 10;
            btnSalida.Text = "Salida";
            btnSalida.UseVisualStyleBackColor = true;
            btnSalida.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalida);
            Controls.Add(btnYen);
            Controls.Add(btnLibra);
            Controls.Add(btnDolar);
            Controls.Add(btnEuro);
            Controls.Add(txtResultado);
            Controls.Add(txtPesos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPesos;
        private TextBox txtResultado;
        private Button btnEuro;
        private Button btnDolar;
        private Button btnLibra;
        private Button btnYen;
        private Button btnSalida;
    }
}
