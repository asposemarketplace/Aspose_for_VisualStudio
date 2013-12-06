using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using AsposeVisualStudioPlugin.GUI;
using AsposeVisualStudioPlugin.com.aspose.community;

namespace AsposeVisualStudioPlugin.Core
{
    public class AsposeComponentsManager
    {
        ComponentWizardPage _pageOne = null;
        public AsposeComponentsManager(ComponentWizardPage page)
        {
            _pageOne = page;
        }

        /**
         * 
         * @return
         */
        public bool downloadComponents()
        {
            if (!isIneternetConnected())
            {
                _pageOne.showMessage(Constants.INTERNET_CONNECTION_REQUIRED_MESSAGE_TITLE, Constants.INTERNET_CONNECTION_REQUIRED_MESSAGE, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return false;
            }

            foreach (AsposeComponent component in AsposeComponents.list.Values)
            {

                if (component.is_selected())
                {

                    ProductRelease productRelease = getProductReleaseInfo(component.get_name());
                    component.set_downloadUrl(productRelease.DownloadLink);
                    component.set_downloadFileName(productRelease.FileName);
                    component.set_changeLog(productRelease.ChangeLog);
                    component.set_latestVersion(productRelease.VersionNumber);
                    if (libraryAlreadyExists(component.get_downloadFileName()))
                    {
                        component.set_currentVersion(readVersion(component));
                        if (readVersion(component).CompareTo(component.get_latestVersion()) == 0)
                        {

                            component.set_downloaded(true);
                            //storeVersion(component);
                        }
                        else
                        {
                            storeReleaseNotes(component);
                            string htmlFilePath = getLibaryDownloadPath() + component.get_name() + ".htm"; // path to your new file
                            // open the default web browser for the HTML page
                            try
                            {
                                System.Diagnostics.Process.Start(htmlFilePath);
                            }
                            catch (IOException e)
                            {

                            }

                            if ((_pageOne.showMessage(component.get_name() + " - " + Constants.NEW_VERSION_MESSAGE_TITLE, Constants.NEW_VERSION_MESSAGE + "\nLatest Version: " + component.get_latestVersion() + "\nCurrent Version: " + component.get_currentVersion(), System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes))
                            {
                                if (addToDownloadList(component, component.get_downloadUrl(), component.get_downloadFileName()))
                                {
                                    //component.set_downloaded(true);
                                    //storeVersion(component);
                                }
                            }
                            else
                            {
                                component.set_downloaded(true);
                            }
                        }
                    }
                    else
                    {
                        if (addToDownloadList(component, component.get_downloadUrl(), component.get_downloadFileName()))
                        {
                            //component.set_downloaded(true);
                            //storeVersion(component);
                        }
                        
                    }
                }
            }

            return true;
        }

        /**
         * 
         * @param component
         * @return
         */
        public string readVersion(AsposeComponent component)
        {
            string localPath = getLibaryDownloadPath() + component.get_name() + ".ver";
            string line = null;

            try
            {
                return System.IO.File.ReadAllText(localPath);
            }
            catch (FileNotFoundException e)
            {

            }
            catch (IOException e)
            {

            }

            return line;
        }

        /**
         * 
         * @param component
         */
        public void storeReleaseNotes(AsposeComponent component)
        {
            string localPath = getLibaryDownloadPath() + component.get_name() + ".htm";
            try
            {
                System.IO.File.WriteAllText(localPath, component.get_changeLog());
            }
            catch (FileNotFoundException e)
            {

            }
            catch (Exception e)
            {

            }

        }

        /**
         * 
         * @param component
         */
        public static void storeVersion(AsposeComponent component)
        {
            string localPath = getLibaryDownloadPath() + component.get_name() + ".ver";
            try
            {
                System.IO.File.WriteAllText(localPath, component.get_latestVersion());
            }
            catch (FileNotFoundException e)
            {

            }
            catch (Exception e)
            {

            }

        }

        /**
         * 
         * @param productName
         * @return
         */
        public ProductRelease getProductReleaseInfo(string productName)
        {
            com.aspose.community.AsposeDownloads asposeDn = new AsposeDownloads();
            try
            {
                return asposeDn.GetProductRelease(".NET", productName);
            }
            catch (Exception e)
            {

            }

            return null;
        }

        /**
         * 
         * @param libFileName
         * @return
         */
        private bool libraryAlreadyExists(string libFileName)
        {
            return System.IO.File.Exists(getLibaryDownloadPath() + libFileName);
        }

       
        /**
         * 
         * @param urlStr
         * @param outputFile
         * @return
         */
        public bool addToDownloadList(AsposeComponent component, string urlStr, string outputFile)
        {

            AsyncDownload asyncDownload = new AsyncDownload();
            asyncDownload.Url = urlStr;
            asyncDownload.LocalPath = getLibaryDownloadPath() + outputFile;
            asyncDownload.Component = component;
            AsyncDownloadList.list.Add(asyncDownload);
            return true;
        }

        /**
         * 
         * @param filePath
         * @return
         */
        public static string removeExtention(string filePath)
        {
            return Path.GetFileNameWithoutExtension(filePath);
        }
        /**
         * 
         * @return
         */
        public static bool isIneternetConnected()
        {
            try
            {
                System.Net.IPHostEntry ipHostEntry = System.Net.Dns.GetHostEntry("www.google.com");
            }
            catch (SocketException)
            {
                return false;
            }
            return true;
        }

        /**
         * 
         * @return
         */
        public static string getLibaryDownloadPath()
        {

            string path = "";
            path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            path = path + "/aspose/dotnet/libraries/";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return path;

        }

        public static string getAsposeHomePath()
        {
            string path = "";
            path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            path = path + "/aspose/dotnet/";
            return path;
        }
        /**
         * 
         * @param zipFile
         * @param outputFolder
         */
        public static void unZipFile(string zipFile, string outputFolder)
        {

            ZipUtilities zipUtilities = new ZipUtilities();
            zipUtilities.ExtractZipFile(zipFile, outputFolder);
        }
    }
}
