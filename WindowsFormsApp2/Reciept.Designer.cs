namespace WindowsFormsApp2
{
    partial class Reciept
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
            this.reciepttxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtclose = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reciepttxt
            // 
            this.reciepttxt.Location = new System.Drawing.Point(51, 82);
            this.reciepttxt.Name = "reciepttxt";
            this.reciepttxt.Size = new System.Drawing.Size(343, 264);
            this.reciepttxt.TabIndex = 0;
            this.reciepttxt.Text = "";
            this.reciepttxt.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Details";
            // 
            // txtclose
            // 
            this.txtclose.Location = new System.Drawing.Point(415, 323);
            this.txtclose.Name = "txtclose";
            this.txtclose.Size = new System.Drawing.Size(75, 23);
            this.txtclose.TabIndex = 2;
            this.txtclose.Text = "Close";
            this.txtclose.UseVisualStyleBackColor = true;
            this.txtclose.Click += new System.EventHandler(this.txtclose_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(415, 284);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Reciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 388);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txtclose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reciepttxt);
            this.Name = "Reciept";
            this.Text = "Reciept";
            this.Load += new System.EventHandler(this.Reciept_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox reciepttxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtclose;
        private System.Windows.Forms.Button btnback;
    }
}