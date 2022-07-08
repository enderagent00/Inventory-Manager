namespace InventoryManager.Forms
{
    partial class EditItemForm
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
            this.lblError = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudItemCount = new System.Windows.Forms.NumericUpDown();
            this.lblEnterItemCount = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.rtbItemDescription = new System.Windows.Forms.RichTextBox();
            this.lblEnterDescription = new System.Windows.Forms.Label();
            this.lblEnterName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblError.Location = new System.Drawing.Point(11, 207);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(46, 13);
            this.lblError.TabIndex = 26;
            this.lblError.Text = "No Error";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(175, 189);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(108, 31);
            this.btnConfirm.TabIndex = 25;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(289, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 31);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nudItemCount
            // 
            this.nudItemCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.nudItemCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudItemCount.ForeColor = System.Drawing.Color.White;
            this.nudItemCount.Location = new System.Drawing.Point(210, 130);
            this.nudItemCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudItemCount.Name = "nudItemCount";
            this.nudItemCount.Size = new System.Drawing.Size(185, 20);
            this.nudItemCount.TabIndex = 23;
            this.nudItemCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEnterItemCount
            // 
            this.lblEnterItemCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblEnterItemCount.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F);
            this.lblEnterItemCount.ForeColor = System.Drawing.Color.White;
            this.lblEnterItemCount.Location = new System.Drawing.Point(11, 130);
            this.lblEnterItemCount.Name = "lblEnterItemCount";
            this.lblEnterItemCount.Size = new System.Drawing.Size(185, 20);
            this.lblEnterItemCount.TabIndex = 22;
            this.lblEnterItemCount.Text = "Item Count";
            this.lblEnterItemCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbItemName
            // 
            this.tbItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.tbItemName.ForeColor = System.Drawing.Color.White;
            this.tbItemName.Location = new System.Drawing.Point(210, 13);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(185, 33);
            this.tbItemName.TabIndex = 21;
            // 
            // rtbItemDescription
            // 
            this.rtbItemDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rtbItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbItemDescription.ForeColor = System.Drawing.Color.White;
            this.rtbItemDescription.Location = new System.Drawing.Point(210, 55);
            this.rtbItemDescription.Name = "rtbItemDescription";
            this.rtbItemDescription.Size = new System.Drawing.Size(185, 57);
            this.rtbItemDescription.TabIndex = 20;
            this.rtbItemDescription.Text = "";
            // 
            // lblEnterDescription
            // 
            this.lblEnterDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblEnterDescription.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F);
            this.lblEnterDescription.ForeColor = System.Drawing.Color.White;
            this.lblEnterDescription.Location = new System.Drawing.Point(11, 55);
            this.lblEnterDescription.Name = "lblEnterDescription";
            this.lblEnterDescription.Size = new System.Drawing.Size(185, 26);
            this.lblEnterDescription.TabIndex = 19;
            this.lblEnterDescription.Text = "Item Description";
            this.lblEnterDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnterName
            // 
            this.lblEnterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblEnterName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F);
            this.lblEnterName.ForeColor = System.Drawing.Color.White;
            this.lblEnterName.Location = new System.Drawing.Point(11, 13);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(185, 26);
            this.lblEnterName.TabIndex = 18;
            this.lblEnterName.Text = "Item Name";
            this.lblEnterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(408, 233);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.nudItemCount);
            this.Controls.Add(this.lblEnterItemCount);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.rtbItemDescription);
            this.Controls.Add(this.lblEnterDescription);
            this.Controls.Add(this.lblEnterName);
            this.Name = "EditItemForm";
            this.Text = "Edit Item";
            this.Load += new System.EventHandler(this.EditItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudItemCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudItemCount;
        private System.Windows.Forms.Label lblEnterItemCount;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.RichTextBox rtbItemDescription;
        private System.Windows.Forms.Label lblEnterDescription;
        private System.Windows.Forms.Label lblEnterName;
    }
}