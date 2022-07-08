namespace InventoryManager.Forms
{
    partial class AddNewRowItem
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
            this.lblEnterName = new System.Windows.Forms.Label();
            this.lblEnterDescription = new System.Windows.Forms.Label();
            this.rtbItemDescription = new System.Windows.Forms.RichTextBox();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.lblEnterItemCount = new System.Windows.Forms.Label();
            this.nudItemCount = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterName
            // 
            this.lblEnterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblEnterName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F);
            this.lblEnterName.ForeColor = System.Drawing.Color.White;
            this.lblEnterName.Location = new System.Drawing.Point(12, 9);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(185, 26);
            this.lblEnterName.TabIndex = 0;
            this.lblEnterName.Text = "Item Name";
            this.lblEnterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnterDescription
            // 
            this.lblEnterDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblEnterDescription.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F);
            this.lblEnterDescription.ForeColor = System.Drawing.Color.White;
            this.lblEnterDescription.Location = new System.Drawing.Point(12, 51);
            this.lblEnterDescription.Name = "lblEnterDescription";
            this.lblEnterDescription.Size = new System.Drawing.Size(185, 26);
            this.lblEnterDescription.TabIndex = 2;
            this.lblEnterDescription.Text = "Item Description";
            this.lblEnterDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbItemDescription
            // 
            this.rtbItemDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rtbItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbItemDescription.ForeColor = System.Drawing.Color.White;
            this.rtbItemDescription.Location = new System.Drawing.Point(211, 51);
            this.rtbItemDescription.Name = "rtbItemDescription";
            this.rtbItemDescription.Size = new System.Drawing.Size(185, 57);
            this.rtbItemDescription.TabIndex = 3;
            this.rtbItemDescription.Text = "";
            // 
            // tbItemName
            // 
            this.tbItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.tbItemName.ForeColor = System.Drawing.Color.White;
            this.tbItemName.Location = new System.Drawing.Point(211, 9);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(185, 33);
            this.tbItemName.TabIndex = 4;
            // 
            // lblEnterItemCount
            // 
            this.lblEnterItemCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblEnterItemCount.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F);
            this.lblEnterItemCount.ForeColor = System.Drawing.Color.White;
            this.lblEnterItemCount.Location = new System.Drawing.Point(12, 126);
            this.lblEnterItemCount.Name = "lblEnterItemCount";
            this.lblEnterItemCount.Size = new System.Drawing.Size(185, 20);
            this.lblEnterItemCount.TabIndex = 5;
            this.lblEnterItemCount.Text = "Item Count";
            this.lblEnterItemCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudItemCount
            // 
            this.nudItemCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.nudItemCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudItemCount.ForeColor = System.Drawing.Color.White;
            this.nudItemCount.Location = new System.Drawing.Point(211, 126);
            this.nudItemCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudItemCount.Name = "nudItemCount";
            this.nudItemCount.Size = new System.Drawing.Size(185, 20);
            this.nudItemCount.TabIndex = 6;
            this.nudItemCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(290, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 31);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(176, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 31);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblError.Location = new System.Drawing.Point(12, 203);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(46, 13);
            this.lblError.TabIndex = 17;
            this.lblError.Text = "No Error";
            // 
            // AddNewRowItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(408, 233);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.nudItemCount);
            this.Controls.Add(this.lblEnterItemCount);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.rtbItemDescription);
            this.Controls.Add(this.lblEnterDescription);
            this.Controls.Add(this.lblEnterName);
            this.Name = "AddNewRowItem";
            this.Text = "Add New Item";
            this.Load += new System.EventHandler(this.AddNewRowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudItemCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Label lblEnterDescription;
        private System.Windows.Forms.RichTextBox rtbItemDescription;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label lblEnterItemCount;
        private System.Windows.Forms.NumericUpDown nudItemCount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblError;
    }
}