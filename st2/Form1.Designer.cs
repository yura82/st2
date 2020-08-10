namespace st2
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
            this.names = new System.Windows.Forms.ListBox();
            this.Mtext = new System.Windows.Forms.TextBox();
            this.mybut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // names
            // 
            this.names.FormattingEnabled = true;
            this.names.ItemHeight = 16;
            this.names.Location = new System.Drawing.Point(12, 0);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(166, 116);
            this.names.TabIndex = 0;
            this.names.SelectedIndexChanged += new System.EventHandler(this.names_SelectedIndexChanged);
            // 
            // Mtext
            // 
            this.Mtext.Location = new System.Drawing.Point(12, 136);
            this.Mtext.Name = "Mtext";
            this.Mtext.Size = new System.Drawing.Size(136, 22);
            this.Mtext.TabIndex = 1;
            // 
            // mybut
            // 
            this.mybut.Location = new System.Drawing.Point(174, 136);
            this.mybut.Name = "mybut";
            this.mybut.Size = new System.Drawing.Size(75, 23);
            this.mybut.TabIndex = 2;
            this.mybut.Text = "deleite";
            this.mybut.UseVisualStyleBackColor = true;
            this.mybut.Click += new System.EventHandler(this.mybut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mybut);
            this.Controls.Add(this.Mtext);
            this.Controls.Add(this.names);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox names;
        private System.Windows.Forms.TextBox Mtext;
        private System.Windows.Forms.Button mybut;
    }
}

