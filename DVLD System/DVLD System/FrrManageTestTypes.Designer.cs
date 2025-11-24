namespace DVLD_System
{
    partial class FrrManageTestTypes
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
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.DGVTestTypes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pbIconPeople = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTestTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Edit Test Type";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(965, 643);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 33);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 645);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "Records :";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.ForeColor = System.Drawing.Color.Black;
            this.lblRecords.Location = new System.Drawing.Point(120, 646);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(40, 30);
            this.lblRecords.TabIndex = 22;
            this.lblRecords.Text = "???";
            // 
            // DGVTestTypes
            // 
            this.DGVTestTypes.AllowUserToAddRows = false;
            this.DGVTestTypes.AllowUserToDeleteRows = false;
            this.DGVTestTypes.BackgroundColor = System.Drawing.Color.White;
            this.DGVTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTestTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVTestTypes.Location = new System.Drawing.Point(18, 216);
            this.DGVTestTypes.Name = "DGVTestTypes";
            this.DGVTestTypes.ReadOnly = true;
            this.DGVTestTypes.RowHeadersWidth = 51;
            this.DGVTestTypes.RowTemplate.Height = 24;
            this.DGVTestTypes.Size = new System.Drawing.Size(1043, 413);
            this.DGVTestTypes.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Black", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(413, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 51);
            this.label1.TabIndex = 20;
            this.label1.Text = "Manage Test Types";
            // 
            // pbIconPeople
            // 
            this.pbIconPeople.Image = global::DVLD_System.Properties.Resources.testing;
            this.pbIconPeople.Location = new System.Drawing.Point(454, 12);
            this.pbIconPeople.Name = "pbIconPeople";
            this.pbIconPeople.Size = new System.Drawing.Size(227, 142);
            this.pbIconPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIconPeople.TabIndex = 19;
            this.pbIconPeople.TabStop = false;
            // 
            // FrrManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 694);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.DGVTestTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbIconPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrrManageTestTypes";
            this.Text = "FrrManageTestTypes";
            this.Load += new System.EventHandler(this.FrrManageTestTypes_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTestTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView DGVTestTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbIconPeople;
    }
}