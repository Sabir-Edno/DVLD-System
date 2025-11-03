namespace DVLD_System
{
    partial class CtrlPersonCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlPersonCard));
            this.GbFindCardPerson = new System.Windows.Forms.GroupBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pbAddNewPerson = new System.Windows.Forms.PictureBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlShowPersonInfo1 = new DVLD_System.CtrlShowPersonInfo();
            this.GbFindCardPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNewPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // GbFindCardPerson
            // 
            this.GbFindCardPerson.Controls.Add(this.pbSearch);
            this.GbFindCardPerson.Controls.Add(this.pbAddNewPerson);
            this.GbFindCardPerson.Controls.Add(this.tbFilter);
            this.GbFindCardPerson.Controls.Add(this.cbFilterBy);
            this.GbFindCardPerson.Controls.Add(this.label3);
            this.GbFindCardPerson.Location = new System.Drawing.Point(3, 3);
            this.GbFindCardPerson.Name = "GbFindCardPerson";
            this.GbFindCardPerson.Size = new System.Drawing.Size(1019, 108);
            this.GbFindCardPerson.TabIndex = 0;
            this.GbFindCardPerson.TabStop = false;
            this.GbFindCardPerson.Text = "Filter";
            // 
            // pbSearch
            // 
            this.pbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(556, 30);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(50, 50);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 24;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // pbAddNewPerson
            // 
            this.pbAddNewPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddNewPerson.Image = ((System.Drawing.Image)(resources.GetObject("pbAddNewPerson.Image")));
            this.pbAddNewPerson.Location = new System.Drawing.Point(622, 30);
            this.pbAddNewPerson.Name = "pbAddNewPerson";
            this.pbAddNewPerson.Size = new System.Drawing.Size(50, 50);
            this.pbAddNewPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddNewPerson.TabIndex = 23;
            this.pbAddNewPerson.TabStop = false;
            this.pbAddNewPerson.Click += new System.EventHandler(this.pbAddNewPerson_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFilter.Location = new System.Drawing.Point(335, 44);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(213, 22);
            this.tbFilter.TabIndex = 22;
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Location = new System.Drawing.Point(124, 43);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(193, 24);
            this.cbFilterBy.TabIndex = 21;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 30);
            this.label3.TabIndex = 20;
            this.label3.Text = "Filter By :";
            // 
            // ctrlShowPersonInfo1
            // 
            this.ctrlShowPersonInfo1.Location = new System.Drawing.Point(0, 115);
            this.ctrlShowPersonInfo1.Name = "ctrlShowPersonInfo1";
            this.ctrlShowPersonInfo1.Size = new System.Drawing.Size(1025, 337);
            this.ctrlShowPersonInfo1.TabIndex = 1;
            // 
            // CtrlPersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlShowPersonInfo1);
            this.Controls.Add(this.GbFindCardPerson);
            this.Name = "CtrlPersonCard";
            this.Size = new System.Drawing.Size(1025, 458);
            this.Load += new System.EventHandler(this.CtrlPersonCard_Load);
            this.GbFindCardPerson.ResumeLayout(false);
            this.GbFindCardPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNewPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbFindCardPerson;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.PictureBox pbAddNewPerson;
        private System.Windows.Forms.PictureBox pbSearch;
        private CtrlShowPersonInfo ctrlShowPersonInfo1;
    }
}
