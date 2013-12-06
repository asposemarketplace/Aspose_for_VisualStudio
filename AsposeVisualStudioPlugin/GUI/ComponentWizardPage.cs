using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsposeVisualStudioPlugin.Core;

namespace AsposeVisualStudioPlugin.GUI
{
    public partial class ComponentWizardPage : Form
    {
        //AsyncDownloadList downloadList = new AsyncDownloadList();
        AsyncDownload asyncActiveDownload=null;
        public ComponentWizardPage()
        {
            InitializeComponent();
            InitializedCustomComponents();
            AsyncDownloadList.list.Clear();
            validateForm();
            AsposeComponents components = new AsposeComponents();

        }

        private void performPostFinish()
        {
            Close();
        }

        private bool performFinish()
        {
            buttonFinish.Enabled = false;
            processComponents();
            AsposeComponentsManager comManager = new AsposeComponentsManager(this);
            comManager.downloadComponents();
            processDownloadList();
            return true;
        }
        private void processDownloadList()
        {
            if (AsyncDownloadList.list.Count > 0)
            {
                asyncActiveDownload = AsyncDownloadList.list[0];
                AsyncDownloadList.list.Remove(asyncActiveDownload);
                downloadFileFromWeb(asyncActiveDownload.Url, asyncActiveDownload.LocalPath);
                toolStripStatusMessage.ForeColor = Color.Green;
                toolStripStatusMessage.Text = "Please wait, downloading " + asyncActiveDownload.Component.Name;
                buttonCancel.Enabled = false;

            }
            else
                performPostFinish();

        }

        private void downloadFileFromWeb(string sourceURL, string destinationPath)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri(sourceURL), destinationPath);
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            progressBar.Value = 100;
            asyncActiveDownload.Component.Downloaded = true;
            AsposeComponentsManager.storeVersion(asyncActiveDownload.Component);
            UnZipDownloadedFile(asyncActiveDownload);
            buttonCancel.Enabled = true;
            processDownloadList();
        }

        private void UnZipDownloadedFile(AsyncDownload download)
        {
            AsposeComponentsManager.unZipFile(download.LocalPath, Path.Combine(Path.GetDirectoryName(download.LocalPath) , download.Component.Name));
        }

        public DialogResult showMessage(string title, string message,MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(message, title, buttons, icon);
        }

        private bool validateForm()
        {
            

            if (!isComponentSelected())
            {
                setErrorMessage(Constants.IS_COMPONENT_SELECTED);
                return false;
            }

           

            clearError();
            return true;
            
        }
        
        void processComponents()
        {
            if (checkBoxAsposeCells.Checked)
            {
                AsposeComponent component = new AsposeComponent();
                AsposeComponents.list.TryGetValue(Constants.ASPOSE_CELLS, out component);
                component.Selected = true;
            }
            if (checkBoxAsposeWords.Checked)
            {
                AsposeComponent component = new AsposeComponent();
                AsposeComponents.list.TryGetValue(Constants.ASPOSE_WORDS, out component);
                component.Selected = true;
            }
            if (checkBoxAsposePdf.Checked)
            {
                AsposeComponent component = new AsposeComponent();
                AsposeComponents.list.TryGetValue(Constants.ASPOSE_PDF, out component);
                component.Selected = true;
            }
            if (checkBoxAsposeSlides.Checked)
            {
                AsposeComponent component = new AsposeComponent();
                AsposeComponents.list.TryGetValue(Constants.ASPOSE_SLIDES, out component);
                component.Selected = true;
            }
            if (checkBoxAsposeDiagram.Checked)
            {
                AsposeComponent component = new AsposeComponent();
                AsposeComponents.list.TryGetValue(Constants.ASPOSE_DIAGRAM, out component);
                component.Selected = true;
            }
            if (checkBoxAsposeBarCode.Checked)
            {
                AsposeComponent component = new AsposeComponent();
                AsposeComponents.list.TryGetValue(Constants.ASPOSE_BARCODE, out component);
                component.Selected = true;
            }
            if (checkBoxAsposeTasks.Checked)
            {
                AsposeComponent component = new AsposeComponent();
                AsposeComponents.list.TryGetValue(Constants.ASPOSE_TASKS, out component);
                component.Selected = true;
            }
            if (checkBoxAsposeEmail.Checked)
            {
                AsposeComponent component = new AsposeComponent();
                AsposeComponents.list.TryGetValue(Constants.ASPOSE_EMAIL, out component);
                component.Selected = true;
            }
            if (checkBoxAsposeOCR.Checked)
            {
                AsposeComponent component = new AsposeComponent();
                AsposeComponents.list.TryGetValue(Constants.ASPOSE_OCR, out component);
                component.Selected = true;
            }
            if (checkBoxAsposeImaging.Checked)
            {
                AsposeComponent component = new AsposeComponent();
                AsposeComponents.list.TryGetValue(Constants.ASPOSE_IMAGING, out component);
                component.Selected = true;
            }
        }

       

        private void setErrorMessage(string message)
        {
            toolStripStatusMessage.ForeColor = Color.Red;
            toolStripStatusMessage.Text = message;
            buttonFinish.Enabled = false;
        }

        private void clearError()
        {

            toolStripStatusMessage.Text = "";
            buttonFinish.Enabled = true;
        }

        private bool isComponentSelected()
        {
            if (checkBoxAsposeCells.Checked || checkBoxAsposeWords.Checked || checkBoxAsposePdf.Checked || checkBoxAsposeSlides.Checked ||
                checkBoxAsposeDiagram.Checked || checkBoxAsposeBarCode.Checked || checkBoxAsposeTasks.Checked || checkBoxAsposeEmail.Checked ||
                checkBoxAsposeOCR.Checked || checkBoxAsposeImaging.Checked)
                return true;


            return false;
        }

        private void InitializedCustomComponents()
        {
            setTooltip(checkBoxAsposeCells, Constants.ASPOSE_CELLS_FEATURE_TEXT);
            setTooltip(checkBoxAsposeWords, Constants.ASPOSE_WORDS_FEATURE_TEXT);
            setTooltip(checkBoxAsposePdf, Constants.ASPOSE_PDF_FEATURE_TEXT);
            setTooltip(checkBoxAsposeSlides, Constants.ASPOSE_SLIDES_FEATURE_TEXT);
            setTooltip(checkBoxAsposeDiagram, Constants.ASPOSE_DIAGRAM_FEATURE_TEXT);
            setTooltip(checkBoxAsposeBarCode, Constants.ASPOSE_BARCODE_FEATURE_TEXT);
            setTooltip(checkBoxAsposeTasks, Constants.ASPOSE_TASKS_FEATURE_TEXT);
            setTooltip(checkBoxAsposeEmail, Constants.ASPOSE_EMAIL_FEATURE_TEXT);
            setTooltip(checkBoxAsposeOCR, Constants.ASPOSE_OCR_FEATURE_TEXT);
            setTooltip(checkBoxAsposeImaging, Constants.ASPOSE_IMAGING_FEATURE_TEXT);
        }

        private void setTooltip(Control control, string message)
        {
            ToolTip buttonToolTip = new ToolTip();
            buttonToolTip.ToolTipTitle = control.Text;
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;
            buttonToolTip.ToolTipIcon = ToolTipIcon.Info;

            buttonToolTip.ShowAlways = true;

            buttonToolTip.AutoPopDelay = 90000;
            buttonToolTip.InitialDelay = 100;
            buttonToolTip.ReshowDelay = 100;

            buttonToolTip.SetToolTip(control, message);

        }
        #region events
        private void linkLabelAspose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelAspose.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.aspose.com/.net/total-component.aspx");
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            performFinish();
        }

        

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region checkbox_events
        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            setComponentsCheckValue(checkBoxSelectAll.Checked);
            validateForm();
        }

        private void checkBoxAsposeCells_CheckedChanged(object sender, EventArgs e)
        {
            validateForm();
        }

        private void checkBoxAsposeWords_CheckedChanged(object sender, EventArgs e)
        {
            validateForm();
        }

        private void checkBoxAsposePdf_CheckedChanged(object sender, EventArgs e)
        {
            validateForm();
        }

        private void checkBoxAsposeSlides_CheckedChanged(object sender, EventArgs e)
        {
            validateForm();
        }

        private void checkBoxAsposePdfKit_CheckedChanged(object sender, EventArgs e)
        {
            validateForm();
        }

        private void checkBoxAsposeBarCode_CheckedChanged(object sender, EventArgs e)
        {
            validateForm();
        }

        private void checkBoxAsposeMetafiles_CheckedChanged(object sender, EventArgs e)
        {
            validateForm();
        }

        private void checkBoxAsposeEmail_CheckedChanged(object sender, EventArgs e)
        {
            validateForm();
        }

        private void checkBoxAsposeOCR_CheckedChanged(object sender, EventArgs e)
        {
            validateForm();
        }

        private void checkBoxAsposeImaging_CheckedChanged(object sender, EventArgs e)
        {
            validateForm();
        }
        #endregion

        #endregion

        void setComponentsCheckValue(bool value)
        {
            checkBoxAsposeCells.Checked = value;
            checkBoxAsposeWords.Checked = value;
            checkBoxAsposePdf.Checked = value;
            checkBoxAsposeSlides.Checked = value;
            checkBoxAsposeDiagram.Checked = value;
            checkBoxAsposeBarCode.Checked = value;
            checkBoxAsposeTasks.Checked = value;
            checkBoxAsposeEmail.Checked = value;
            checkBoxAsposeOCR.Checked = value;
            checkBoxAsposeImaging.Checked = value;
        }

        private void logoButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.aspose.com");
        }

        private void textBoxProjectName_TextChanged(object sender, EventArgs e)
        {
            validateForm();
        }

       
    }
}
