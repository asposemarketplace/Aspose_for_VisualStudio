/*--------------------------------------------------------------------------------------+
|
|   $HeadURL: svn://sialkot.codeporting.com/cs-porter/trunk/Web2Services/CsPorterWebInterface/CsPorterWebInterface/Utilities.cs $
|   $Id: Utilities.cs 1691 2012-06-08 11:09:48Z mohsan.raza $
|   $Revision: 1691 $
|   $Date: 2012-06-08 16:09:48 +0500 (Fri, 08 Jun 2012) $
|   $Author: mohsan.raza $
|
|   $Copyright: (c) 2001-2011 Aspose Pty Ltd. All rights reserved. $
|   
|   This program is confidential, proprietary and unpublished property of Aspose Pty
|   Ltd. It may NOT be copied in part or in whole on any medium, either electronic or
|   printed, without the express written consent of Aspose Pty Ltd.This program is 
|   developed and maintained by CodePorting venture [http://codeporting.com ] a division of Aspose Pty Ltd.
|
+--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ionic.Zip;
namespace AsposeVisualStudioPlugin.Core
{
    public class ZipUtilities
    {


        /// <summary>
        /// Unzip files
        /// </summary>
        /// <param name="zipFilePath"></param>
        /// <param name="pathToExtract"></param>
        public Boolean ExtractZipFile(string zipFilePath, string pathToExtract)
        {
            try
            {
                var options = new ReadOptions { StatusMessageWriter = System.Console.Out };
                using (ZipFile zip = ZipFile.Read(zipFilePath, options))
                {
                    // This call to ExtractAll() assumes:
                    //   - none of the entries are password-protected.
                    //   - want to extract all entries to current working directory
                    //   - none of the files in the zip already exist in the directory;
                    //     if they do, the method will throw.
                    zip.ExtractAll(pathToExtract);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
  
    }
}
