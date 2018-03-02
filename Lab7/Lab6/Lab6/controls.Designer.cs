namespace Lab6
{
    partial class controls
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(88, 97);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(113, 53);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add Record";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(301, 97);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(115, 53);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Search Database";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 253);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "controls";
            this.Text = "Controls";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SearchBtn;
    }
}