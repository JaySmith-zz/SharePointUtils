namespace SharePointUtils
{
    partial class FormMain
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
            this.buttonImportFileBrowse = new System.Windows.Forms.TabControl();
            this.tabExport = new System.Windows.Forms.TabPage();
            this.tabImport = new System.Windows.Forms.TabPage();
            this.tabUpdateSystemFields = new System.Windows.Forms.TabPage();
            this.labelExportEnterSite = new System.Windows.Forms.Label();
            this.textExportSharePointAddress = new System.Windows.Forms.TextBox();
            this.labelExportEnterSiteExample = new System.Windows.Forms.Label();
            this.buttonExportConnect = new System.Windows.Forms.Button();
            this.comboBoxExportSelectedList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExportFile = new System.Windows.Forms.TextBox();
            this.buttonExportFileBrowse = new System.Windows.Forms.Button();
            this.listBoxExportAvailableColumns = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1ExportSelectedColumns = new System.Windows.Forms.ListBox();
            this.buttonExportColumnsAddAll = new System.Windows.Forms.Button();
            this.buttonExportColumnsRemoveAll = new System.Windows.Forms.Button();
            this.buttonExportColumnsAddSelected = new System.Windows.Forms.Button();
            this.buttonExportColumnsRemoveSelected = new System.Windows.Forms.Button();
            this.buttonExportList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxImportFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxImportSelectedList = new System.Windows.Forms.ComboBox();
            this.buttonImportConnect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textImportSharePointAddress = new System.Windows.Forms.TextBox();
            this.labelImportServerSite = new System.Windows.Forms.Label();
            this.labelImportColumnMapping = new System.Windows.Forms.Label();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonImportFileBrowse.SuspendLayout();
            this.tabExport.SuspendLayout();
            this.tabImport.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonImportFileBrowse
            // 
            this.buttonImportFileBrowse.Controls.Add(this.tabExport);
            this.buttonImportFileBrowse.Controls.Add(this.tabImport);
            this.buttonImportFileBrowse.Controls.Add(this.tabUpdateSystemFields);
            this.buttonImportFileBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonImportFileBrowse.Location = new System.Drawing.Point(0, 0);
            this.buttonImportFileBrowse.Name = "buttonImportFileBrowse";
            this.buttonImportFileBrowse.SelectedIndex = 0;
            this.buttonImportFileBrowse.Size = new System.Drawing.Size(539, 526);
            this.buttonImportFileBrowse.TabIndex = 0;
            // 
            // tabExport
            // 
            this.tabExport.Controls.Add(this.buttonExportList);
            this.tabExport.Controls.Add(this.buttonExportColumnsRemoveSelected);
            this.tabExport.Controls.Add(this.buttonExportColumnsAddSelected);
            this.tabExport.Controls.Add(this.buttonExportColumnsRemoveAll);
            this.tabExport.Controls.Add(this.buttonExportColumnsAddAll);
            this.tabExport.Controls.Add(this.label4);
            this.tabExport.Controls.Add(this.listBox1ExportSelectedColumns);
            this.tabExport.Controls.Add(this.label3);
            this.tabExport.Controls.Add(this.listBoxExportAvailableColumns);
            this.tabExport.Controls.Add(this.buttonExportFileBrowse);
            this.tabExport.Controls.Add(this.textBoxExportFile);
            this.tabExport.Controls.Add(this.label2);
            this.tabExport.Controls.Add(this.label1);
            this.tabExport.Controls.Add(this.comboBoxExportSelectedList);
            this.tabExport.Controls.Add(this.buttonExportConnect);
            this.tabExport.Controls.Add(this.labelExportEnterSiteExample);
            this.tabExport.Controls.Add(this.textExportSharePointAddress);
            this.tabExport.Controls.Add(this.labelExportEnterSite);
            this.tabExport.Location = new System.Drawing.Point(4, 22);
            this.tabExport.Name = "tabExport";
            this.tabExport.Padding = new System.Windows.Forms.Padding(3);
            this.tabExport.Size = new System.Drawing.Size(531, 500);
            this.tabExport.TabIndex = 0;
            this.tabExport.Text = "Export";
            this.tabExport.UseVisualStyleBackColor = true;
            // 
            // tabImport
            // 
            this.tabImport.Controls.Add(this.buttonImport);
            this.tabImport.Controls.Add(this.labelImportColumnMapping);
            this.tabImport.Controls.Add(this.button1);
            this.tabImport.Controls.Add(this.textBoxImportFile);
            this.tabImport.Controls.Add(this.label5);
            this.tabImport.Controls.Add(this.label6);
            this.tabImport.Controls.Add(this.comboBoxImportSelectedList);
            this.tabImport.Controls.Add(this.buttonImportConnect);
            this.tabImport.Controls.Add(this.label7);
            this.tabImport.Controls.Add(this.textImportSharePointAddress);
            this.tabImport.Controls.Add(this.labelImportServerSite);
            this.tabImport.Location = new System.Drawing.Point(4, 22);
            this.tabImport.Name = "tabImport";
            this.tabImport.Padding = new System.Windows.Forms.Padding(3);
            this.tabImport.Size = new System.Drawing.Size(531, 500);
            this.tabImport.TabIndex = 1;
            this.tabImport.Text = "Import";
            this.tabImport.UseVisualStyleBackColor = true;
            // 
            // tabUpdateSystemFields
            // 
            this.tabUpdateSystemFields.Location = new System.Drawing.Point(4, 22);
            this.tabUpdateSystemFields.Name = "tabUpdateSystemFields";
            this.tabUpdateSystemFields.Size = new System.Drawing.Size(531, 500);
            this.tabUpdateSystemFields.TabIndex = 2;
            this.tabUpdateSystemFields.Text = "System Fields";
            this.tabUpdateSystemFields.UseVisualStyleBackColor = true;
            // 
            // labelExportEnterSite
            // 
            this.labelExportEnterSite.AutoSize = true;
            this.labelExportEnterSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExportEnterSite.Location = new System.Drawing.Point(6, 3);
            this.labelExportEnterSite.Name = "labelExportEnterSite";
            this.labelExportEnterSite.Size = new System.Drawing.Size(428, 20);
            this.labelExportEnterSite.TabIndex = 0;
            this.labelExportEnterSite.Text = "Enter the address of the SharePoint Server and Site";
            // 
            // textExportSharePointAddress
            // 
            this.textExportSharePointAddress.Location = new System.Drawing.Point(10, 27);
            this.textExportSharePointAddress.Name = "textExportSharePointAddress";
            this.textExportSharePointAddress.Size = new System.Drawing.Size(416, 20);
            this.textExportSharePointAddress.TabIndex = 1;
            // 
            // labelExportEnterSiteExample
            // 
            this.labelExportEnterSiteExample.AutoSize = true;
            this.labelExportEnterSiteExample.Location = new System.Drawing.Point(8, 50);
            this.labelExportEnterSiteExample.Name = "labelExportEnterSiteExample";
            this.labelExportEnterSiteExample.Size = new System.Drawing.Size(229, 13);
            this.labelExportEnterSiteExample.TabIndex = 2;
            this.labelExportEnterSiteExample.Text = "Example: http://example.com/sites/portalname";
            // 
            // buttonExportConnect
            // 
            this.buttonExportConnect.Location = new System.Drawing.Point(432, 24);
            this.buttonExportConnect.Name = "buttonExportConnect";
            this.buttonExportConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonExportConnect.TabIndex = 3;
            this.buttonExportConnect.Text = "Connect";
            this.buttonExportConnect.UseVisualStyleBackColor = true;
            // 
            // comboBoxExportSelectedList
            // 
            this.comboBoxExportSelectedList.FormattingEnabled = true;
            this.comboBoxExportSelectedList.Location = new System.Drawing.Point(10, 104);
            this.comboBoxExportSelectedList.Name = "comboBoxExportSelectedList";
            this.comboBoxExportSelectedList.Size = new System.Drawing.Size(287, 21);
            this.comboBoxExportSelectedList.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select a list";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select export file location";
            // 
            // textBoxExportFile
            // 
            this.textBoxExportFile.Location = new System.Drawing.Point(12, 164);
            this.textBoxExportFile.Name = "textBoxExportFile";
            this.textBoxExportFile.Size = new System.Drawing.Size(414, 20);
            this.textBoxExportFile.TabIndex = 7;
            // 
            // buttonExportFileBrowse
            // 
            this.buttonExportFileBrowse.Location = new System.Drawing.Point(432, 161);
            this.buttonExportFileBrowse.Name = "buttonExportFileBrowse";
            this.buttonExportFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonExportFileBrowse.TabIndex = 8;
            this.buttonExportFileBrowse.Text = "Browse";
            this.buttonExportFileBrowse.UseVisualStyleBackColor = true;
            // 
            // listBoxExportAvailableColumns
            // 
            this.listBoxExportAvailableColumns.FormattingEnabled = true;
            this.listBoxExportAvailableColumns.Location = new System.Drawing.Point(12, 232);
            this.listBoxExportAvailableColumns.Name = "listBoxExportAvailableColumns";
            this.listBoxExportAvailableColumns.Size = new System.Drawing.Size(225, 199);
            this.listBoxExportAvailableColumns.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Available Columns";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Selected Columns";
            // 
            // listBox1ExportSelectedColumns
            // 
            this.listBox1ExportSelectedColumns.FormattingEnabled = true;
            this.listBox1ExportSelectedColumns.Location = new System.Drawing.Point(282, 232);
            this.listBox1ExportSelectedColumns.Name = "listBox1ExportSelectedColumns";
            this.listBox1ExportSelectedColumns.Size = new System.Drawing.Size(225, 199);
            this.listBox1ExportSelectedColumns.TabIndex = 11;
            // 
            // buttonExportColumnsAddAll
            // 
            this.buttonExportColumnsAddAll.Location = new System.Drawing.Point(243, 270);
            this.buttonExportColumnsAddAll.Name = "buttonExportColumnsAddAll";
            this.buttonExportColumnsAddAll.Size = new System.Drawing.Size(33, 23);
            this.buttonExportColumnsAddAll.TabIndex = 13;
            this.buttonExportColumnsAddAll.Text = ">>";
            this.buttonExportColumnsAddAll.UseVisualStyleBackColor = true;
            // 
            // buttonExportColumnsRemoveAll
            // 
            this.buttonExportColumnsRemoveAll.Location = new System.Drawing.Point(243, 357);
            this.buttonExportColumnsRemoveAll.Name = "buttonExportColumnsRemoveAll";
            this.buttonExportColumnsRemoveAll.Size = new System.Drawing.Size(33, 23);
            this.buttonExportColumnsRemoveAll.TabIndex = 14;
            this.buttonExportColumnsRemoveAll.Text = "<<";
            this.buttonExportColumnsRemoveAll.UseVisualStyleBackColor = true;
            // 
            // buttonExportColumnsAddSelected
            // 
            this.buttonExportColumnsAddSelected.Location = new System.Drawing.Point(243, 299);
            this.buttonExportColumnsAddSelected.Name = "buttonExportColumnsAddSelected";
            this.buttonExportColumnsAddSelected.Size = new System.Drawing.Size(33, 23);
            this.buttonExportColumnsAddSelected.TabIndex = 15;
            this.buttonExportColumnsAddSelected.Text = ">";
            this.buttonExportColumnsAddSelected.UseVisualStyleBackColor = true;
            // 
            // buttonExportColumnsRemoveSelected
            // 
            this.buttonExportColumnsRemoveSelected.Location = new System.Drawing.Point(243, 328);
            this.buttonExportColumnsRemoveSelected.Name = "buttonExportColumnsRemoveSelected";
            this.buttonExportColumnsRemoveSelected.Size = new System.Drawing.Size(33, 23);
            this.buttonExportColumnsRemoveSelected.TabIndex = 16;
            this.buttonExportColumnsRemoveSelected.Text = "<";
            this.buttonExportColumnsRemoveSelected.UseVisualStyleBackColor = true;
            // 
            // buttonExportList
            // 
            this.buttonExportList.Location = new System.Drawing.Point(432, 459);
            this.buttonExportList.Name = "buttonExportList";
            this.buttonExportList.Size = new System.Drawing.Size(75, 23);
            this.buttonExportList.TabIndex = 17;
            this.buttonExportList.Text = "Export";
            this.buttonExportList.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxImportFile
            // 
            this.textBoxImportFile.Location = new System.Drawing.Point(12, 164);
            this.textBoxImportFile.Name = "textBoxImportFile";
            this.textBoxImportFile.Size = new System.Drawing.Size(414, 20);
            this.textBoxImportFile.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Select import file";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Select a list";
            // 
            // comboBoxImportSelectedList
            // 
            this.comboBoxImportSelectedList.FormattingEnabled = true;
            this.comboBoxImportSelectedList.Location = new System.Drawing.Point(10, 104);
            this.comboBoxImportSelectedList.Name = "comboBoxImportSelectedList";
            this.comboBoxImportSelectedList.Size = new System.Drawing.Size(287, 21);
            this.comboBoxImportSelectedList.TabIndex = 13;
            // 
            // buttonImportConnect
            // 
            this.buttonImportConnect.Location = new System.Drawing.Point(432, 24);
            this.buttonImportConnect.Name = "buttonImportConnect";
            this.buttonImportConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonImportConnect.TabIndex = 12;
            this.buttonImportConnect.Text = "Connect";
            this.buttonImportConnect.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Example: http://example.com/sites/portalname";
            // 
            // textImportSharePointAddress
            // 
            this.textImportSharePointAddress.Location = new System.Drawing.Point(10, 27);
            this.textImportSharePointAddress.Name = "textImportSharePointAddress";
            this.textImportSharePointAddress.Size = new System.Drawing.Size(416, 20);
            this.textImportSharePointAddress.TabIndex = 10;
            // 
            // labelImportServerSite
            // 
            this.labelImportServerSite.AutoSize = true;
            this.labelImportServerSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImportServerSite.Location = new System.Drawing.Point(6, 3);
            this.labelImportServerSite.Name = "labelImportServerSite";
            this.labelImportServerSite.Size = new System.Drawing.Size(428, 20);
            this.labelImportServerSite.TabIndex = 9;
            this.labelImportServerSite.Text = "Enter the address of the SharePoint Server and Site";
            // 
            // labelImportColumnMapping
            // 
            this.labelImportColumnMapping.AutoSize = true;
            this.labelImportColumnMapping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImportColumnMapping.Location = new System.Drawing.Point(8, 209);
            this.labelImportColumnMapping.Name = "labelImportColumnMapping";
            this.labelImportColumnMapping.Size = new System.Drawing.Size(142, 20);
            this.labelImportColumnMapping.TabIndex = 18;
            this.labelImportColumnMapping.Text = "Column Mapping";
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(432, 469);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(75, 23);
            this.buttonImport.TabIndex = 19;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 526);
            this.Controls.Add(this.buttonImportFileBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(545, 554);
            this.Name = "FormMain";
            this.Text = "SharePoint Utils";
            this.buttonImportFileBrowse.ResumeLayout(false);
            this.tabExport.ResumeLayout(false);
            this.tabExport.PerformLayout();
            this.tabImport.ResumeLayout(false);
            this.tabImport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl buttonImportFileBrowse;
        private System.Windows.Forms.TabPage tabExport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1ExportSelectedColumns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxExportAvailableColumns;
        private System.Windows.Forms.Button buttonExportFileBrowse;
        private System.Windows.Forms.TextBox textBoxExportFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxExportSelectedList;
        private System.Windows.Forms.Button buttonExportConnect;
        private System.Windows.Forms.Label labelExportEnterSiteExample;
        private System.Windows.Forms.TextBox textExportSharePointAddress;
        private System.Windows.Forms.Label labelExportEnterSite;
        private System.Windows.Forms.TabPage tabImport;
        private System.Windows.Forms.TabPage tabUpdateSystemFields;
        private System.Windows.Forms.Button buttonExportList;
        private System.Windows.Forms.Button buttonExportColumnsRemoveSelected;
        private System.Windows.Forms.Button buttonExportColumnsAddSelected;
        private System.Windows.Forms.Button buttonExportColumnsRemoveAll;
        private System.Windows.Forms.Button buttonExportColumnsAddAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxImportFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxImportSelectedList;
        private System.Windows.Forms.Button buttonImportConnect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textImportSharePointAddress;
        private System.Windows.Forms.Label labelImportServerSite;
        private System.Windows.Forms.Label labelImportColumnMapping;
        private System.Windows.Forms.Button buttonImport;
    }
}

