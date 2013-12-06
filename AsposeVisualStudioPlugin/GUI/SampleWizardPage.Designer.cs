namespace AsposeVisualStudioPlugin.GUI
{
    partial class SampleWizardPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleWizardPage));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.logoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelProjectParams = new System.Windows.Forms.Panel();
            this.buttonGetComponents = new System.Windows.Forms.Button();
            this.comboBoxComponents = new System.Windows.Forms.ComboBox();
            this.labelComponents = new System.Windows.Forms.Label();
            this.buttonBrowseLocation = new System.Windows.Forms.Button();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.examplesTree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelProjectParams.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.toolStripStatusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusMessage
            // 
            this.toolStripStatusMessage.Name = "toolStripStatusMessage";
            this.toolStripStatusMessage.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusMessage.Text = "Test message...";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panelProjectParams, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 286F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(584, 496);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.buttonCancel, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonFinish, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 445);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(578, 48);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(382, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(193, 42);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinish.AutoSize = true;
            this.buttonFinish.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFinish.FlatAppearance.BorderSize = 0;
            this.buttonFinish.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonFinish.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.buttonFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinish.Location = new System.Drawing.Point(201, 3);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(175, 42);
            this.buttonFinish.TabIndex = 0;
            this.buttonFinish.Text = "&Finish";
            this.buttonFinish.UseVisualStyleBackColor = false;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.29066F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.70934F));
            this.tableLayoutPanel2.Controls.Add(this.logoButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(584, 74);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // logoButton
            // 
            this.logoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoButton.BackgroundImage = global::AsposeVisualStudioPlugin.Properties.Resources.long_banner;
            this.logoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoButton.FlatAppearance.BorderSize = 0;
            this.logoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoButton.Location = new System.Drawing.Point(276, 0);
            this.logoButton.Margin = new System.Windows.Forms.Padding(0);
            this.logoButton.Name = "logoButton";
            this.logoButton.Size = new System.Drawing.Size(308, 74);
            this.logoButton.TabIndex = 1;
            this.logoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Aspose .NET components and samples";
            // 
            // panelProjectParams
            // 
            this.panelProjectParams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProjectParams.Controls.Add(this.buttonGetComponents);
            this.panelProjectParams.Controls.Add(this.comboBoxComponents);
            this.panelProjectParams.Controls.Add(this.labelComponents);
            this.panelProjectParams.Controls.Add(this.buttonBrowseLocation);
            this.panelProjectParams.Controls.Add(this.textBoxLocation);
            this.panelProjectParams.Controls.Add(this.labelLocation);
            this.panelProjectParams.Location = new System.Drawing.Point(3, 77);
            this.panelProjectParams.Name = "panelProjectParams";
            this.panelProjectParams.Size = new System.Drawing.Size(578, 76);
            this.panelProjectParams.TabIndex = 4;
            // 
            // buttonGetComponents
            // 
            this.buttonGetComponents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetComponents.AutoSize = true;
            this.buttonGetComponents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGetComponents.FlatAppearance.BorderSize = 0;
            this.buttonGetComponents.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonGetComponents.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.buttonGetComponents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetComponents.Location = new System.Drawing.Point(362, 37);
            this.buttonGetComponents.Name = "buttonGetComponents";
            this.buttonGetComponents.Size = new System.Drawing.Size(96, 23);
            this.buttonGetComponents.TabIndex = 7;
            this.buttonGetComponents.Text = "&Get Components";
            this.buttonGetComponents.UseVisualStyleBackColor = false;
            this.buttonGetComponents.Click += new System.EventHandler(this.buttonGetComponents_Click);
            // 
            // comboBoxComponents
            // 
            this.comboBoxComponents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComponents.FormattingEnabled = true;
            this.comboBoxComponents.Location = new System.Drawing.Point(113, 38);
            this.comboBoxComponents.Name = "comboBoxComponents";
            this.comboBoxComponents.Size = new System.Drawing.Size(243, 21);
            this.comboBoxComponents.TabIndex = 6;
            this.comboBoxComponents.SelectedIndexChanged += new System.EventHandler(this.comboBoxComponents_SelectedIndexChanged);
            // 
            // labelComponents
            // 
            this.labelComponents.AutoSize = true;
            this.labelComponents.Location = new System.Drawing.Point(11, 42);
            this.labelComponents.Name = "labelComponents";
            this.labelComponents.Size = new System.Drawing.Size(97, 13);
            this.labelComponents.TabIndex = 5;
            this.labelComponents.Text = ".NET Components:";
            // 
            // buttonBrowseLocation
            // 
            this.buttonBrowseLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseLocation.AutoSize = true;
            this.buttonBrowseLocation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBrowseLocation.FlatAppearance.BorderSize = 0;
            this.buttonBrowseLocation.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBrowseLocation.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBrowseLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseLocation.Location = new System.Drawing.Point(479, 9);
            this.buttonBrowseLocation.Name = "buttonBrowseLocation";
            this.buttonBrowseLocation.Size = new System.Drawing.Size(77, 23);
            this.buttonBrowseLocation.TabIndex = 4;
            this.buttonBrowseLocation.Text = "&Browse";
            this.buttonBrowseLocation.UseVisualStyleBackColor = false;
            this.buttonBrowseLocation.Click += new System.EventHandler(this.buttonBrowseLocation_Click);
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(87, 11);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.ReadOnly = true;
            this.textBoxLocation.Size = new System.Drawing.Size(389, 20);
            this.textBoxLocation.TabIndex = 3;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(10, 14);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(54, 13);
            this.labelLocation.TabIndex = 2;
            this.labelLocation.Text = "Location: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.examplesTree);
            this.groupBox1.Location = new System.Drawing.Point(3, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 280);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Samples:";
            // 
            // examplesTree
            // 
            this.examplesTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.examplesTree.ImageIndex = 0;
            this.examplesTree.ImageList = this.imageList1;
            this.examplesTree.Location = new System.Drawing.Point(4, 19);
            this.examplesTree.Name = "examplesTree";
            this.examplesTree.SelectedImageIndex = 0;
            this.examplesTree.Size = new System.Drawing.Size(568, 255);
            this.examplesTree.TabIndex = 0;
            this.examplesTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.examplesTree_AfterSelect);
            this.examplesTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.examplesTree_NodeMouseClick);
            this.examplesTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.examplesTree_NodeMouseDoubleClick);
            this.examplesTree.Click += new System.EventHandler(this.examplesTree_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder-icon.png");
            this.imageList1.Images.SetKeyName(1, "page_white_csharp.ico");
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SampleWizardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 519);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 558);
            this.MinimumSize = new System.Drawing.Size(600, 558);
            this.Name = "SampleWizardPage";
            this.Text = "Aspose Visual Studio Plugin";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panelProjectParams.ResumeLayout(false);
            this.panelProjectParams.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button logoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelProjectParams;
        private System.Windows.Forms.Button buttonBrowseLocation;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.ComboBox comboBoxComponents;
        private System.Windows.Forms.Label labelComponents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView examplesTree;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonGetComponents;
    }
}