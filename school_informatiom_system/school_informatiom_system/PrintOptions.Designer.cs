namespace school_informatiom_system
{
    partial class PrintOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintOptions));
            this.lblColumnsToPrint = new System.Windows.Forms.Label();
            this.chklst = new System.Windows.Forms.CheckedListBox();
            this.gboxRowsToPrint = new System.Windows.Forms.GroupBox();
            this.rdoAllRows = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkFitToPageWidth = new System.Windows.Forms.CheckBox();
            this.gboxRowsToPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColumnsToPrint
            // 
            this.lblColumnsToPrint.AutoSize = true;
            this.lblColumnsToPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnsToPrint.Location = new System.Drawing.Point(37, 29);
            this.lblColumnsToPrint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColumnsToPrint.Name = "lblColumnsToPrint";
            this.lblColumnsToPrint.Size = new System.Drawing.Size(68, 17);
            this.lblColumnsToPrint.TabIndex = 18;
            this.lblColumnsToPrint.Text = "列印欄位";
            // 
            // chklst
            // 
            this.chklst.CheckOnClick = true;
            this.chklst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklst.FormattingEnabled = true;
            this.chklst.Location = new System.Drawing.Point(40, 58);
            this.chklst.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chklst.Name = "chklst";
            this.chklst.Size = new System.Drawing.Size(225, 274);
            this.chklst.TabIndex = 19;
            // 
            // gboxRowsToPrint
            // 
            this.gboxRowsToPrint.Controls.Add(this.rdoAllRows);
            this.gboxRowsToPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxRowsToPrint.Location = new System.Drawing.Point(466, 12);
            this.gboxRowsToPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxRowsToPrint.Name = "gboxRowsToPrint";
            this.gboxRowsToPrint.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxRowsToPrint.Size = new System.Drawing.Size(110, 48);
            this.gboxRowsToPrint.TabIndex = 20;
            this.gboxRowsToPrint.TabStop = false;
            this.gboxRowsToPrint.Text = "選擇列印行";
            this.gboxRowsToPrint.Visible = false;
            // 
            // rdoAllRows
            // 
            this.rdoAllRows.AutoSize = true;
            this.rdoAllRows.Checked = true;
            this.rdoAllRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAllRows.Location = new System.Drawing.Point(12, 22);
            this.rdoAllRows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoAllRows.Name = "rdoAllRows";
            this.rdoAllRows.Size = new System.Drawing.Size(47, 21);
            this.rdoAllRows.TabIndex = 0;
            this.rdoAllRows.TabStop = true;
            this.rdoAllRows.Text = "All";
            this.rdoAllRows.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(295, 58);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 17);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Title of print ";
            // 
            // txtTitle
            // 
            this.txtTitle.AcceptsReturn = true;
            this.txtTitle.Location = new System.Drawing.Point(295, 78);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTitle.Size = new System.Drawing.Size(233, 88);
            this.txtTitle.TabIndex = 25;
            this.txtTitle.Text = "學生成績";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Control;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.Location = new System.Drawing.Point(300, 190);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOK.Size = new System.Drawing.Size(75, 29);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(450, 190);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // chkFitToPageWidth
            // 
            this.chkFitToPageWidth.AutoSize = true;
            this.chkFitToPageWidth.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFitToPageWidth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkFitToPageWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFitToPageWidth.Location = new System.Drawing.Point(298, 12);
            this.chkFitToPageWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkFitToPageWidth.Name = "chkFitToPageWidth";
            this.chkFitToPageWidth.Size = new System.Drawing.Size(153, 22);
            this.chkFitToPageWidth.TabIndex = 27;
            this.chkFitToPageWidth.Text = "Fit to page width";
            this.chkFitToPageWidth.UseVisualStyleBackColor = true;
            this.chkFitToPageWidth.Visible = false;
            // 
            // PrintOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 370);
            this.Controls.Add(this.chkFitToPageWidth);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gboxRowsToPrint);
            this.Controls.Add(this.chklst);
            this.Controls.Add(this.lblColumnsToPrint);
            this.Name = "PrintOptions";
            this.Text = "PrintOptions";
            this.gboxRowsToPrint.ResumeLayout(false);
            this.gboxRowsToPrint.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblColumnsToPrint;
        internal System.Windows.Forms.CheckedListBox chklst;
        internal System.Windows.Forms.GroupBox gboxRowsToPrint;
        internal System.Windows.Forms.RadioButton rdoAllRows;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.TextBox txtTitle;
        protected System.Windows.Forms.Button btnOK;
        protected System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.CheckBox chkFitToPageWidth;
    }
}