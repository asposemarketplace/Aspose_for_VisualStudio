using AsposeVisualStudioPlugin.Core;
namespace AsposeVisualStudioPlugin.GUI
{
    partial class ComponentWizardPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentWizardPage));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.logoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxComponentsSelection = new System.Windows.Forms.GroupBox();
            this.checkBoxAsposeImaging = new System.Windows.Forms.CheckBox();
            this.checkBoxAsposeOCR = new System.Windows.Forms.CheckBox();
            this.checkBoxAsposeEmail = new System.Windows.Forms.CheckBox();
            this.checkBoxAsposeTasks = new System.Windows.Forms.CheckBox();
            this.checkBoxAsposeBarCode = new System.Windows.Forms.CheckBox();
            this.checkBoxAsposeDiagram = new System.Windows.Forms.CheckBox();
            this.checkBoxAsposeSlides = new System.Windows.Forms.CheckBox();
            this.checkBoxAsposePdf = new System.Windows.Forms.CheckBox();
            this.checkBoxAsposeWords = new System.Windows.Forms.CheckBox();
            this.checkBoxAsposeCells = new System.Windows.Forms.CheckBox();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.groupBoxCommonUses = new System.Windows.Forms.GroupBox();
            this.linkLabelAspose = new System.Windows.Forms.LinkLabel();
            this.labelCommonUses = new System.Windows.Forms.Label();
            this.folderBrowserDialogLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxComponentsSelection.SuspendLayout();
            this.groupBoxCommonUses.SuspendLayout();
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
            this.statusStrip1.TabIndex = 1;
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 324F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(584, 496);
            this.tableLayoutPanel3.TabIndex = 2;
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
            this.logoButton.Click += new System.EventHandler(this.logoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Aspose .NET components";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.75565F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.24435F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxComponentsSelection, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxCommonUses, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 121);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 256);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBoxComponentsSelection
            // 
            this.groupBoxComponentsSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxComponentsSelection.Controls.Add(this.checkBoxAsposeImaging);
            this.groupBoxComponentsSelection.Controls.Add(this.checkBoxAsposeOCR);
            this.groupBoxComponentsSelection.Controls.Add(this.checkBoxAsposeEmail);
            this.groupBoxComponentsSelection.Controls.Add(this.checkBoxAsposeTasks);
            this.groupBoxComponentsSelection.Controls.Add(this.checkBoxAsposeBarCode);
            this.groupBoxComponentsSelection.Controls.Add(this.checkBoxAsposeDiagram);
            this.groupBoxComponentsSelection.Controls.Add(this.checkBoxAsposeSlides);
            this.groupBoxComponentsSelection.Controls.Add(this.checkBoxAsposePdf);
            this.groupBoxComponentsSelection.Controls.Add(this.checkBoxAsposeWords);
            this.groupBoxComponentsSelection.Controls.Add(this.checkBoxAsposeCells);
            this.groupBoxComponentsSelection.Controls.Add(this.checkBoxSelectAll);
            this.groupBoxComponentsSelection.Location = new System.Drawing.Point(3, 3);
            this.groupBoxComponentsSelection.Name = "groupBoxComponentsSelection";
            this.groupBoxComponentsSelection.Size = new System.Drawing.Size(206, 246);
            this.groupBoxComponentsSelection.TabIndex = 0;
            this.groupBoxComponentsSelection.TabStop = false;
            this.groupBoxComponentsSelection.Text = "Select Components:";
            // 
            // checkBoxAsposeImaging
            // 
            this.checkBoxAsposeImaging.AutoSize = true;
            this.checkBoxAsposeImaging.FlatAppearance.BorderSize = 0;
            this.checkBoxAsposeImaging.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxAsposeImaging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAsposeImaging.Location = new System.Drawing.Point(7, 209);
            this.checkBoxAsposeImaging.Name = "checkBoxAsposeImaging";
            this.checkBoxAsposeImaging.Size = new System.Drawing.Size(98, 17);
            this.checkBoxAsposeImaging.TabIndex = 10;
            this.checkBoxAsposeImaging.Text = "Aspose.Imaging";
            this.checkBoxAsposeImaging.UseVisualStyleBackColor = true;
            this.checkBoxAsposeImaging.CheckedChanged += new System.EventHandler(this.checkBoxAsposeImaging_CheckedChanged);
            // 
            // checkBoxAsposeOCR
            // 
            this.checkBoxAsposeOCR.AutoSize = true;
            this.checkBoxAsposeOCR.FlatAppearance.BorderSize = 0;
            this.checkBoxAsposeOCR.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxAsposeOCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAsposeOCR.Location = new System.Drawing.Point(7, 190);
            this.checkBoxAsposeOCR.Name = "checkBoxAsposeOCR";
            this.checkBoxAsposeOCR.Size = new System.Drawing.Size(84, 17);
            this.checkBoxAsposeOCR.TabIndex = 9;
            this.checkBoxAsposeOCR.Text = "Aspose.OCR";
            this.checkBoxAsposeOCR.UseVisualStyleBackColor = true;
            this.checkBoxAsposeOCR.CheckedChanged += new System.EventHandler(this.checkBoxAsposeOCR_CheckedChanged);
            // 
            // checkBoxAsposeEmail
            // 
            this.checkBoxAsposeEmail.AutoSize = true;
            this.checkBoxAsposeEmail.FlatAppearance.BorderSize = 0;
            this.checkBoxAsposeEmail.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxAsposeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAsposeEmail.Location = new System.Drawing.Point(7, 171);
            this.checkBoxAsposeEmail.Name = "checkBoxAsposeEmail";
            this.checkBoxAsposeEmail.Size = new System.Drawing.Size(86, 17);
            this.checkBoxAsposeEmail.TabIndex = 8;
            this.checkBoxAsposeEmail.Text = "Aspose.Email";
            this.checkBoxAsposeEmail.UseVisualStyleBackColor = true;
            this.checkBoxAsposeEmail.CheckedChanged += new System.EventHandler(this.checkBoxAsposeEmail_CheckedChanged);
            // 
            // checkBoxAsposeTasks
            // 
            this.checkBoxAsposeTasks.AutoSize = true;
            this.checkBoxAsposeTasks.FlatAppearance.BorderSize = 0;
            this.checkBoxAsposeTasks.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxAsposeTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAsposeTasks.Location = new System.Drawing.Point(7, 151);
            this.checkBoxAsposeTasks.Name = "checkBoxAsposeTasks";
            this.checkBoxAsposeTasks.Size = new System.Drawing.Size(90, 17);
            this.checkBoxAsposeTasks.TabIndex = 7;
            this.checkBoxAsposeTasks.Text = "Aspose.Tasks";
            this.checkBoxAsposeTasks.UseVisualStyleBackColor = true;
            this.checkBoxAsposeTasks.CheckedChanged += new System.EventHandler(this.checkBoxAsposeMetafiles_CheckedChanged);
            // 
            // checkBoxAsposeBarCode
            // 
            this.checkBoxAsposeBarCode.AutoSize = true;
            this.checkBoxAsposeBarCode.FlatAppearance.BorderSize = 0;
            this.checkBoxAsposeBarCode.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxAsposeBarCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAsposeBarCode.Location = new System.Drawing.Point(7, 132);
            this.checkBoxAsposeBarCode.Name = "checkBoxAsposeBarCode";
            this.checkBoxAsposeBarCode.Size = new System.Drawing.Size(102, 17);
            this.checkBoxAsposeBarCode.TabIndex = 6;
            this.checkBoxAsposeBarCode.Text = "Aspose.BarCode";
            this.checkBoxAsposeBarCode.UseVisualStyleBackColor = true;
            this.checkBoxAsposeBarCode.CheckedChanged += new System.EventHandler(this.checkBoxAsposeBarCode_CheckedChanged);
            // 
            // checkBoxAsposeDiagram
            // 
            this.checkBoxAsposeDiagram.AutoSize = true;
            this.checkBoxAsposeDiagram.FlatAppearance.BorderSize = 0;
            this.checkBoxAsposeDiagram.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxAsposeDiagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAsposeDiagram.Location = new System.Drawing.Point(7, 113);
            this.checkBoxAsposeDiagram.Name = "checkBoxAsposeDiagram";
            this.checkBoxAsposeDiagram.Size = new System.Drawing.Size(100, 17);
            this.checkBoxAsposeDiagram.TabIndex = 5;
            this.checkBoxAsposeDiagram.Text = "Aspose.Diagram";
            this.checkBoxAsposeDiagram.UseVisualStyleBackColor = true;
            this.checkBoxAsposeDiagram.CheckedChanged += new System.EventHandler(this.checkBoxAsposePdfKit_CheckedChanged);
            // 
            // checkBoxAsposeSlides
            // 
            this.checkBoxAsposeSlides.AutoSize = true;
            this.checkBoxAsposeSlides.FlatAppearance.BorderSize = 0;
            this.checkBoxAsposeSlides.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxAsposeSlides.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAsposeSlides.Location = new System.Drawing.Point(7, 94);
            this.checkBoxAsposeSlides.Name = "checkBoxAsposeSlides";
            this.checkBoxAsposeSlides.Size = new System.Drawing.Size(89, 17);
            this.checkBoxAsposeSlides.TabIndex = 4;
            this.checkBoxAsposeSlides.Text = "Aspose.Slides";
            this.checkBoxAsposeSlides.UseVisualStyleBackColor = true;
            this.checkBoxAsposeSlides.CheckedChanged += new System.EventHandler(this.checkBoxAsposeSlides_CheckedChanged);
            // 
            // checkBoxAsposePdf
            // 
            this.checkBoxAsposePdf.AutoSize = true;
            this.checkBoxAsposePdf.FlatAppearance.BorderSize = 0;
            this.checkBoxAsposePdf.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxAsposePdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAsposePdf.Location = new System.Drawing.Point(7, 75);
            this.checkBoxAsposePdf.Name = "checkBoxAsposePdf";
            this.checkBoxAsposePdf.Size = new System.Drawing.Size(77, 17);
            this.checkBoxAsposePdf.TabIndex = 3;
            this.checkBoxAsposePdf.Text = "Aspose.Pdf";
            this.checkBoxAsposePdf.UseVisualStyleBackColor = true;
            this.checkBoxAsposePdf.CheckedChanged += new System.EventHandler(this.checkBoxAsposePdf_CheckedChanged);
            // 
            // checkBoxAsposeWords
            // 
            this.checkBoxAsposeWords.AutoSize = true;
            this.checkBoxAsposeWords.FlatAppearance.BorderSize = 0;
            this.checkBoxAsposeWords.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxAsposeWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAsposeWords.Location = new System.Drawing.Point(7, 56);
            this.checkBoxAsposeWords.Name = "checkBoxAsposeWords";
            this.checkBoxAsposeWords.Size = new System.Drawing.Size(92, 17);
            this.checkBoxAsposeWords.TabIndex = 2;
            this.checkBoxAsposeWords.Text = "Aspose.Words";
            this.checkBoxAsposeWords.UseVisualStyleBackColor = true;
            this.checkBoxAsposeWords.CheckedChanged += new System.EventHandler(this.checkBoxAsposeWords_CheckedChanged);
            // 
            // checkBoxAsposeCells
            // 
            this.checkBoxAsposeCells.AutoSize = true;
            this.checkBoxAsposeCells.FlatAppearance.BorderSize = 0;
            this.checkBoxAsposeCells.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxAsposeCells.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAsposeCells.Location = new System.Drawing.Point(7, 39);
            this.checkBoxAsposeCells.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxAsposeCells.Name = "checkBoxAsposeCells";
            this.checkBoxAsposeCells.Size = new System.Drawing.Size(83, 17);
            this.checkBoxAsposeCells.TabIndex = 1;
            this.checkBoxAsposeCells.Text = "Aspose.Cells";
            this.checkBoxAsposeCells.UseVisualStyleBackColor = true;
            this.checkBoxAsposeCells.CheckedChanged += new System.EventHandler(this.checkBoxAsposeCells_CheckedChanged);
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.FlatAppearance.BorderSize = 0;
            this.checkBoxSelectAll.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(7, 20);
            this.checkBoxSelectAll.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(67, 17);
            this.checkBoxSelectAll.TabIndex = 0;
            this.checkBoxSelectAll.Text = "Select All";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
            // 
            // groupBoxCommonUses
            // 
            this.groupBoxCommonUses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCommonUses.Controls.Add(this.linkLabelAspose);
            this.groupBoxCommonUses.Controls.Add(this.labelCommonUses);
            this.groupBoxCommonUses.Location = new System.Drawing.Point(215, 3);
            this.groupBoxCommonUses.Name = "groupBoxCommonUses";
            this.groupBoxCommonUses.Size = new System.Drawing.Size(360, 246);
            this.groupBoxCommonUses.TabIndex = 1;
            this.groupBoxCommonUses.TabStop = false;
            this.groupBoxCommonUses.Text = "Common Uses:";
            // 
            // linkLabelAspose
            // 
            this.linkLabelAspose.AutoSize = true;
            this.linkLabelAspose.LinkArea = new System.Windows.Forms.LinkArea(6, 6);
            this.linkLabelAspose.Location = new System.Drawing.Point(12, 221);
            this.linkLabelAspose.Name = "linkLabelAspose";
            this.linkLabelAspose.Size = new System.Drawing.Size(151, 17);
            this.linkLabelAspose.TabIndex = 1;
            this.linkLabelAspose.TabStop = true;
            this.linkLabelAspose.Text = "Visit Aspose for more details.";
            this.linkLabelAspose.UseCompatibleTextRendering = true;
            this.linkLabelAspose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAspose_LinkClicked);
            // 
            // labelCommonUses
            // 
            this.labelCommonUses.AutoSize = true;
            this.labelCommonUses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCommonUses.Location = new System.Drawing.Point(7, 20);
            this.labelCommonUses.Name = "labelCommonUses";
            this.labelCommonUses.Size = new System.Drawing.Size(311, 195);
            this.labelCommonUses.TabIndex = 0;
            this.labelCommonUses.Text = resources.GetString("labelCommonUses.Text");
            // 
            // ComponentWizardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 519);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 558);
            this.MinimumSize = new System.Drawing.Size(600, 558);
            this.Name = "ComponentWizardPage";
            this.Text = "Aspose Visual Studio Plugin";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxComponentsSelection.ResumeLayout(false);
            this.groupBoxComponentsSelection.PerformLayout();
            this.groupBoxCommonUses.ResumeLayout(false);
            this.groupBoxCommonUses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxComponentsSelection;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private System.Windows.Forms.CheckBox checkBoxAsposeSlides;
        private System.Windows.Forms.CheckBox checkBoxAsposePdf;
        private System.Windows.Forms.CheckBox checkBoxAsposeWords;
        private System.Windows.Forms.CheckBox checkBoxAsposeCells;
        private System.Windows.Forms.CheckBox checkBoxAsposeImaging;
        private System.Windows.Forms.CheckBox checkBoxAsposeOCR;
        private System.Windows.Forms.CheckBox checkBoxAsposeEmail;
        private System.Windows.Forms.CheckBox checkBoxAsposeTasks;
        private System.Windows.Forms.CheckBox checkBoxAsposeBarCode;
        private System.Windows.Forms.CheckBox checkBoxAsposeDiagram;
        private System.Windows.Forms.GroupBox groupBoxCommonUses;
        private System.Windows.Forms.Label labelCommonUses;
        private System.Windows.Forms.LinkLabel linkLabelAspose;
        public System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogLocation;
    }
}