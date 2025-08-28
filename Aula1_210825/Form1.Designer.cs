namespace Aula1_210825
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
            txt1 = new TextBox();
            txt2 = new TextBox();
            button2 = new Button();
            valortxt = new TextBox();
            idtxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tipoPag = new ComboBox();
            datatxt = new DateTimePicker();
            Consultabtn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(321, 244);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Processar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(296, 130);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 1;
            // 
            // txt2
            // 
            txt2.Location = new Point(296, 185);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 23);
            txt2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(520, 301);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Inserir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // valortxt
            // 
            valortxt.Location = new Point(506, 154);
            valortxt.Name = "valortxt";
            valortxt.Size = new Size(100, 23);
            valortxt.TabIndex = 5;
            // 
            // idtxt
            // 
            idtxt.Location = new Point(506, 109);
            idtxt.Name = "idtxt";
            idtxt.Size = new Size(100, 23);
            idtxt.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(506, 91);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 8;
            label1.Text = "id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(506, 138);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 9;
            label2.Text = "valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(506, 191);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 10;
            label3.Text = "tipo de pagamento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(506, 239);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 11;
            label4.Text = "data";
            // 
            // tipoPag
            // 
            tipoPag.Items.AddRange(new object[] { "credito", "debito", "dinheiro", "pix" });
            tipoPag.Location = new Point(506, 209);
            tipoPag.Name = "tipoPag";
            tipoPag.Size = new Size(100, 23);
            tipoPag.TabIndex = 12;
            // 
            // datatxt
            // 
            datatxt.Format = DateTimePickerFormat.Short;
            datatxt.Location = new Point(506, 257);
            datatxt.Name = "datatxt";
            datatxt.Size = new Size(100, 23);
            datatxt.TabIndex = 13;
            datatxt.Value = new DateTime(2025, 8, 28, 19, 48, 12, 0);
            // 
            // Consultabtn
            // 
            Consultabtn.Location = new Point(254, 355);
            Consultabtn.Name = "Consultabtn";
            Consultabtn.Size = new Size(75, 23);
            Consultabtn.TabIndex = 14;
            Consultabtn.Text = "Consulta";
            Consultabtn.UseVisualStyleBackColor = true;
            Consultabtn.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Consultabtn);
            Controls.Add(datatxt);
            Controls.Add(tipoPag);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(idtxt);
            Controls.Add(valortxt);
            Controls.Add(button2);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txt1;
        private TextBox txt2;
        private Button button2;
        private TextBox valortxt;
        private TextBox idtxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox tipoPag;
        private DateTimePicker datatxt;
        private Button Consultabtn;
    }
}
