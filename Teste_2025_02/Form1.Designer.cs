namespace Teste_2025_02
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
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            txtNumero = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(68, 22);
            button1.Name = "button1";
            button1.Size = new Size(207, 23);
            button1.TabIndex = 0;
            button1.Text = "Inverter Caracteres";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(68, 65);
            button2.Name = "button2";
            button2.Size = new Size(207, 23);
            button2.TabIndex = 1;
            button2.Text = "Calcular Percentual";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(356, 16);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(190, 214);
            listBox1.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(68, 106);
            button3.Name = "button3";
            button3.Size = new Size(207, 23);
            button3.TabIndex = 3;
            button3.Text = "Somar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(68, 207);
            button4.Name = "button4";
            button4.Size = new Size(250, 23);
            button4.TabIndex = 4;
            button4.Text = "Verificar se é Fibonacci";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(218, 178);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 181);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 6;
            label1.Text = "Digite um número inteiro:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 294);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Button button3;
        private Button button4;
        private TextBox txtNumero;
        private Label label1;
    }
}
