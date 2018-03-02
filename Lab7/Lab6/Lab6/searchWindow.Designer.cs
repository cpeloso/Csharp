namespace Lab6
{
    partial class searchWindow
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
            this.dtbSearchBtn = new System.Windows.Forms.Button();
            this.dtbGridResults = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtbGridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dtbSearchBtn
            // 
            this.dtbSearchBtn.Location = new System.Drawing.Point(344, 155);
            this.dtbSearchBtn.Name = "dtbSearchBtn";
            this.dtbSearchBtn.Size = new System.Drawing.Size(146, 32);
            this.dtbSearchBtn.TabIndex = 0;
            this.dtbSearchBtn.Text = "Search";
            this.dtbSearchBtn.UseVisualStyleBackColor = true;
            this.dtbSearchBtn.Click += new System.EventHandler(this.dtbSearchBtn_Click);
            // 
            // dtbGridResults
            // 
            this.dtbGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbGridResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtbGridResults.Location = new System.Drawing.Point(12, 193);
            this.dtbGridResults.Name = "dtbGridResults";
            this.dtbGridResults.Size = new System.Drawing.Size(800, 289);
            this.dtbGridResults.TabIndex = 1;
            this.dtbGridResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtbGridResults_CellContentClick);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(169, 60);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(139, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(532, 60);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(139, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(106, 63);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(469, 63);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // searchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 494);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.dtbGridResults);
            this.Controls.Add(this.dtbSearchBtn);
            this.Name = "searchWindow";
            this.Text = "Database Search";
            ((System.ComponentModel.ISupportInitialize)(this.dtbGridResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dtbSearchBtn;
        private System.Windows.Forms.DataGridView dtbGridResults;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
    }
}