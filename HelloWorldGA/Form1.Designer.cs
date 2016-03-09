namespace HelloWorldGA
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rtfLOG = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPOPSIZE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtELITERATE = new System.Windows.Forms.TextBox();
            this.txtMUTATIONRATE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run GA ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Hello World";
            // 
            // rtfLOG
            // 
            this.rtfLOG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfLOG.Location = new System.Drawing.Point(10, 97);
            this.rtfLOG.Name = "rtfLOG";
            this.rtfLOG.Size = new System.Drawing.Size(353, 265);
            this.rtfLOG.TabIndex = 2;
            this.rtfLOG.Text = "";
            this.rtfLOG.TextChanged += new System.EventHandler(this.rtfLOG_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TARGET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "POPSIZE";
            // 
            // txtPOPSIZE
            // 
            this.txtPOPSIZE.Location = new System.Drawing.Point(15, 71);
            this.txtPOPSIZE.Name = "txtPOPSIZE";
            this.txtPOPSIZE.Size = new System.Drawing.Size(50, 20);
            this.txtPOPSIZE.TabIndex = 5;
            this.txtPOPSIZE.Text = "1024";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ELITERATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "MUTATIONRATE";
            // 
            // txtELITERATE
            // 
            this.txtELITERATE.Location = new System.Drawing.Point(93, 71);
            this.txtELITERATE.Name = "txtELITERATE";
            this.txtELITERATE.Size = new System.Drawing.Size(63, 20);
            this.txtELITERATE.TabIndex = 6;
            this.txtELITERATE.Text = "0,1";
            // 
            // txtMUTATIONRATE
            // 
            this.txtMUTATIONRATE.Location = new System.Drawing.Point(183, 71);
            this.txtMUTATIONRATE.Name = "txtMUTATIONRATE";
            this.txtMUTATIONRATE.Size = new System.Drawing.Size(90, 20);
            this.txtMUTATIONRATE.TabIndex = 7;
            this.txtMUTATIONRATE.Text = "0,05";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 367);
            this.Controls.Add(this.txtMUTATIONRATE);
            this.Controls.Add(this.txtELITERATE);
            this.Controls.Add(this.txtPOPSIZE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtfLOG);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Hello World! GA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox rtfLOG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPOPSIZE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtELITERATE;
        private System.Windows.Forms.TextBox txtMUTATIONRATE;
    }
}

