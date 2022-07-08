namespace InventoryManager.Forms
{
    partial class InventoryManagerForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvItemGrid = new System.Windows.Forms.DataGridView();
            this.dgvItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.lblDrawCount = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnRedraw = new System.Windows.Forms.Button();
            this.cmsTableControls = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmAddNewRow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmReloadGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRedrawGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemControls = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmSetCount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCountAdd100 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCountAdd10 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCountAdd1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCountSubtract1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCountSubtract10 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCountSubtract100 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemGrid)).BeginInit();
            this.pnlSideBar.SuspendLayout();
            this.cmsTableControls.SuspendLayout();
            this.cmsItemControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItemGrid
            // 
            this.dgvItemGrid.AllowUserToAddRows = false;
            this.dgvItemGrid.AllowUserToDeleteRows = false;
            this.dgvItemGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvItemGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItemGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvItemGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvItemID,
            this.dgvName,
            this.dgvDescription,
            this.dgvCount});
            this.dgvItemGrid.EnableHeadersVisualStyles = false;
            this.dgvItemGrid.Location = new System.Drawing.Point(12, 38);
            this.dgvItemGrid.Name = "dgvItemGrid";
            this.dgvItemGrid.ReadOnly = true;
            this.dgvItemGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItemGrid.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dgvItemGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItemGrid.Size = new System.Drawing.Size(815, 513);
            this.dgvItemGrid.TabIndex = 11;
            this.dgvItemGrid.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItemGrid_CellMouseMove);
            this.dgvItemGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvItemGrid_MouseClick);
            // 
            // dgvItemID
            // 
            this.dgvItemID.HeaderText = "Item ID";
            this.dgvItemID.Name = "dgvItemID";
            this.dgvItemID.ReadOnly = true;
            // 
            // dgvName
            // 
            this.dgvName.FillWeight = 200F;
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvDescription
            // 
            this.dgvDescription.FillWeight = 300F;
            this.dgvDescription.HeaderText = "Description";
            this.dgvDescription.Name = "dgvDescription";
            this.dgvDescription.ReadOnly = true;
            // 
            // dgvCount
            // 
            this.dgvCount.HeaderText = "Count";
            this.dgvCount.Name = "dgvCount";
            this.dgvCount.ReadOnly = true;
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlSideBar.Controls.Add(this.btnAddNewItem);
            this.pnlSideBar.Controls.Add(this.lblDrawCount);
            this.pnlSideBar.Controls.Add(this.btnReload);
            this.pnlSideBar.Controls.Add(this.btnRedraw);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSideBar.Location = new System.Drawing.Point(833, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(150, 563);
            this.pnlSideBar.TabIndex = 12;
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAddNewItem.FlatAppearance.BorderSize = 0;
            this.btnAddNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewItem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewItem.ForeColor = System.Drawing.Color.White;
            this.btnAddNewItem.Location = new System.Drawing.Point(22, 38);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(113, 31);
            this.btnAddNewItem.TabIndex = 16;
            this.btnAddNewItem.Text = "Add New Item";
            this.btnAddNewItem.UseVisualStyleBackColor = false;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // lblDrawCount
            // 
            this.lblDrawCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblDrawCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDrawCount.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F);
            this.lblDrawCount.ForeColor = System.Drawing.Color.White;
            this.lblDrawCount.Location = new System.Drawing.Point(22, 520);
            this.lblDrawCount.Name = "lblDrawCount";
            this.lblDrawCount.Size = new System.Drawing.Size(113, 31);
            this.lblDrawCount.TabIndex = 15;
            this.lblDrawCount.Text = "Items Drawn: 0";
            this.lblDrawCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(22, 94);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(113, 31);
            this.btnReload.TabIndex = 14;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnRedraw
            // 
            this.btnRedraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRedraw.FlatAppearance.BorderSize = 0;
            this.btnRedraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedraw.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedraw.ForeColor = System.Drawing.Color.White;
            this.btnRedraw.Location = new System.Drawing.Point(22, 131);
            this.btnRedraw.Name = "btnRedraw";
            this.btnRedraw.Size = new System.Drawing.Size(113, 31);
            this.btnRedraw.TabIndex = 13;
            this.btnRedraw.Text = "Redraw";
            this.btnRedraw.UseVisualStyleBackColor = false;
            this.btnRedraw.Click += new System.EventHandler(this.btnRedraw_Click);
            // 
            // cmsTableControls
            // 
            this.cmsTableControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddNewRow,
            this.toolStripMenuItem2,
            this.tsmReloadGrid,
            this.tsmRedrawGrid});
            this.cmsTableControls.Name = "contextMenuStrip1";
            this.cmsTableControls.Size = new System.Drawing.Size(181, 98);
            // 
            // tsmAddNewRow
            // 
            this.tsmAddNewRow.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F);
            this.tsmAddNewRow.Image = global::InventoryManager.Properties.Resources.application_add;
            this.tsmAddNewRow.Name = "tsmAddNewRow";
            this.tsmAddNewRow.Size = new System.Drawing.Size(180, 22);
            this.tsmAddNewRow.Text = "Add New Row";
            this.tsmAddNewRow.Click += new System.EventHandler(this.tsmAddNewRow_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmReloadGrid
            // 
            this.tsmReloadGrid.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F);
            this.tsmReloadGrid.Image = global::InventoryManager.Properties.Resources.broom;
            this.tsmReloadGrid.Name = "tsmReloadGrid";
            this.tsmReloadGrid.Size = new System.Drawing.Size(180, 22);
            this.tsmReloadGrid.Text = "Reload Grid";
            this.tsmReloadGrid.Click += new System.EventHandler(this.tsmReloadGrid_Click);
            // 
            // tsmRedrawGrid
            // 
            this.tsmRedrawGrid.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F);
            this.tsmRedrawGrid.Image = global::InventoryManager.Properties.Resources.refresh;
            this.tsmRedrawGrid.Name = "tsmRedrawGrid";
            this.tsmRedrawGrid.Size = new System.Drawing.Size(180, 22);
            this.tsmRedrawGrid.Text = "Redraw Grid";
            this.tsmRedrawGrid.Click += new System.EventHandler(this.tsmRedrawGrid_Click);
            // 
            // cmsItemControls
            // 
            this.cmsItemControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSetCount,
            this.tsmViewItem,
            this.toolStripMenuItem1,
            this.tsmEditItem,
            this.tsmDeleteItem});
            this.cmsItemControls.Name = "cmsItemControls";
            this.cmsItemControls.Size = new System.Drawing.Size(132, 98);
            // 
            // tsmSetCount
            // 
            this.tsmSetCount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCountAdd100,
            this.tsmCountAdd10,
            this.tsmCountAdd1,
            this.tsmCountSubtract1,
            this.tsmCountSubtract10,
            this.tsmCountSubtract100});
            this.tsmSetCount.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F);
            this.tsmSetCount.Image = global::InventoryManager.Properties.Resources.bricks;
            this.tsmSetCount.Name = "tsmSetCount";
            this.tsmSetCount.Size = new System.Drawing.Size(131, 22);
            this.tsmSetCount.Text = "Set Count";
            // 
            // tsmCountAdd100
            // 
            this.tsmCountAdd100.Name = "tsmCountAdd100";
            this.tsmCountAdd100.Size = new System.Drawing.Size(99, 22);
            this.tsmCountAdd100.Text = "+ 100";
            this.tsmCountAdd100.Click += new System.EventHandler(this.tsmCountAdd100_Click);
            // 
            // tsmCountAdd10
            // 
            this.tsmCountAdd10.Name = "tsmCountAdd10";
            this.tsmCountAdd10.Size = new System.Drawing.Size(99, 22);
            this.tsmCountAdd10.Text = "+ 10";
            this.tsmCountAdd10.Click += new System.EventHandler(this.tsmCountAdd10_Click);
            // 
            // tsmCountAdd1
            // 
            this.tsmCountAdd1.Name = "tsmCountAdd1";
            this.tsmCountAdd1.Size = new System.Drawing.Size(99, 22);
            this.tsmCountAdd1.Text = "+ 1";
            this.tsmCountAdd1.Click += new System.EventHandler(this.tsmCountAdd1_Click);
            // 
            // tsmCountSubtract1
            // 
            this.tsmCountSubtract1.Name = "tsmCountSubtract1";
            this.tsmCountSubtract1.Size = new System.Drawing.Size(99, 22);
            this.tsmCountSubtract1.Text = "- 1";
            this.tsmCountSubtract1.Click += new System.EventHandler(this.tsmCountSubtract1_Click);
            // 
            // tsmCountSubtract10
            // 
            this.tsmCountSubtract10.Name = "tsmCountSubtract10";
            this.tsmCountSubtract10.Size = new System.Drawing.Size(99, 22);
            this.tsmCountSubtract10.Text = "- 10";
            this.tsmCountSubtract10.Click += new System.EventHandler(this.tsmCountSubtract10_Click);
            // 
            // tsmCountSubtract100
            // 
            this.tsmCountSubtract100.Name = "tsmCountSubtract100";
            this.tsmCountSubtract100.Size = new System.Drawing.Size(99, 22);
            this.tsmCountSubtract100.Text = "- 100";
            this.tsmCountSubtract100.Click += new System.EventHandler(this.tsmCountSubtract100_Click);
            // 
            // tsmViewItem
            // 
            this.tsmViewItem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F);
            this.tsmViewItem.Image = global::InventoryManager.Properties.Resources.eye;
            this.tsmViewItem.Name = "tsmViewItem";
            this.tsmViewItem.Size = new System.Drawing.Size(131, 22);
            this.tsmViewItem.Text = "View Item";
            this.tsmViewItem.Click += new System.EventHandler(this.tsmViewItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 6);
            // 
            // tsmEditItem
            // 
            this.tsmEditItem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F);
            this.tsmEditItem.Image = global::InventoryManager.Properties.Resources.registry;
            this.tsmEditItem.Name = "tsmEditItem";
            this.tsmEditItem.Size = new System.Drawing.Size(131, 22);
            this.tsmEditItem.Text = "Edit Item";
            this.tsmEditItem.Click += new System.EventHandler(this.tsmEditItem_Click);
            // 
            // tsmDeleteItem
            // 
            this.tsmDeleteItem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F);
            this.tsmDeleteItem.Image = global::InventoryManager.Properties.Resources.delete;
            this.tsmDeleteItem.Name = "tsmDeleteItem";
            this.tsmDeleteItem.Size = new System.Drawing.Size(131, 22);
            this.tsmDeleteItem.Text = "Delete Item";
            this.tsmDeleteItem.Click += new System.EventHandler(this.tsmDeleteItem_Click);
            // 
            // tbSearchBar
            // 
            this.tbSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchBar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F);
            this.tbSearchBar.ForeColor = System.Drawing.Color.White;
            this.tbSearchBar.Location = new System.Drawing.Point(12, 9);
            this.tbSearchBar.Name = "tbSearchBar";
            this.tbSearchBar.Size = new System.Drawing.Size(815, 21);
            this.tbSearchBar.TabIndex = 13;
            this.tbSearchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchBar_KeyPress);
            // 
            // InventoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(983, 563);
            this.Controls.Add(this.tbSearchBar);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.dgvItemGrid);
            this.Name = "InventoryManagerForm";
            this.Text = "Inventory Manager ";
            this.Load += new System.EventHandler(this.InventoryManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemGrid)).EndInit();
            this.pnlSideBar.ResumeLayout(false);
            this.cmsTableControls.ResumeLayout(false);
            this.cmsItemControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItemGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCount;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button btnRedraw;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ContextMenuStrip cmsTableControls;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNewRow;
        private System.Windows.Forms.ContextMenuStrip cmsItemControls;
        private System.Windows.Forms.ToolStripMenuItem tsmEditItem;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteItem;
        private System.Windows.Forms.TextBox tbSearchBar;
        private System.Windows.Forms.ToolStripMenuItem tsmSetCount;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Label lblDrawCount;
        private System.Windows.Forms.ToolStripMenuItem tsmCountAdd100;
        private System.Windows.Forms.ToolStripMenuItem tsmCountAdd10;
        private System.Windows.Forms.ToolStripMenuItem tsmCountAdd1;
        private System.Windows.Forms.ToolStripMenuItem tsmCountSubtract1;
        private System.Windows.Forms.ToolStripMenuItem tsmCountSubtract10;
        private System.Windows.Forms.ToolStripMenuItem tsmCountSubtract100;
        private System.Windows.Forms.ToolStripMenuItem tsmViewItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmReloadGrid;
        private System.Windows.Forms.ToolStripMenuItem tsmRedrawGrid;
        private System.Windows.Forms.Button btnAddNewItem;
    }
}

