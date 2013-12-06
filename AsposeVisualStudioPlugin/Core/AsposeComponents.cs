﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AsposeVisualStudioPlugin.Core
{
    public class AsposeComponents
    {
        //public static Map<String,AsposeComponent> list = new HashMap<String,AsposeComponent>();
        public static Dictionary<String, AsposeComponent> list = new Dictionary<string, AsposeComponent>();
        public AsposeComponents()
        {
            list.Clear();
            //ASPOSE_CELLS
            AsposeComponent asposeCells = new AsposeComponent();
            asposeCells.set_downloadUrl("");
            asposeCells.set_downloadFileName("aspose-cells.zip");
            asposeCells.set_name(Constants.ASPOSE_CELLS);
            asposeCells.set_remoteExamplesRepository("https://github.com/asposecells/Aspose_Cells_NET.git");
            list.Add(Constants.ASPOSE_CELLS, asposeCells);

            //ASPOSE_WORDS
            AsposeComponent asposeWords = new AsposeComponent();
            asposeWords.set_downloadUrl("");
            asposeWords.set_downloadFileName("aspose-words.zip");
            asposeWords.set_name(Constants.ASPOSE_WORDS);
            asposeWords.set_remoteExamplesRepository("");
            list.Add(Constants.ASPOSE_WORDS, asposeWords);

            //ASPOSE_WORDS
            AsposeComponent asposePDF = new AsposeComponent();
            asposePDF.set_downloadUrl("");
            asposePDF.get_downloadFileName();
            asposePDF.set_name(Constants.ASPOSE_PDF);
            asposePDF.RemoteExamplesRepository = "https://github.com/asposepdf/Aspose_Pdf_NET.git";
            list.Add(Constants.ASPOSE_PDF, asposePDF);

            //ASPOSE_WORDS
            AsposeComponent asposeSlides = new AsposeComponent();
            asposeSlides.set_downloadUrl("");
            asposeSlides.get_downloadFileName();
            asposeSlides.set_name(Constants.ASPOSE_SLIDES);
            asposeSlides.RemoteExamplesRepository = "https://github.com/asposeslides/Aspose_Slides_NET.git";
            list.Add(Constants.ASPOSE_SLIDES, asposeSlides);

            //ASPOSE_WORDS
            AsposeComponent asposeDiagram = new AsposeComponent();
            asposeDiagram.set_downloadUrl("");
            asposeDiagram.get_downloadFileName();
            asposeDiagram.set_name(Constants.ASPOSE_DIAGRAM);
            asposeDiagram.RemoteExamplesRepository="https://github.com/asposediagram/Aspose_Diagram_NET.git";
            list.Add(Constants.ASPOSE_DIAGRAM, asposeDiagram);

            //ASPOSE_WORDS
            AsposeComponent asposeBarcode = new AsposeComponent();
            asposeBarcode.set_downloadUrl("");
            asposeBarcode.get_downloadFileName();
            asposeBarcode.set_name(Constants.ASPOSE_BARCODE);
            asposeBarcode.RemoteExamplesRepository = "https://github.com/asposebarcode/Aspose_BarCode_NET.git";
            list.Add(Constants.ASPOSE_BARCODE, asposeBarcode);

            //ASPOSE_WORDS
            AsposeComponent asposeTasks = new AsposeComponent();
            asposeTasks.set_downloadUrl("");
            asposeTasks.get_downloadFileName();
            asposeTasks.set_name(Constants.ASPOSE_TASKS);
            asposeTasks.RemoteExamplesRepository = "https://github.com/asposetasks/Aspose_Tasks_NET.git";
            list.Add(Constants.ASPOSE_TASKS, asposeTasks);

            //ASPOSE_WORDS
            AsposeComponent asposeEmail = new AsposeComponent();
            asposeEmail.set_downloadUrl("");
            asposeEmail.get_downloadFileName();
            asposeEmail.set_name(Constants.ASPOSE_EMAIL);
            asposeEmail.set_remoteExamplesRepository("https://github.com/asposeemail/Aspose_Email_NET.git");
            list.Add(Constants.ASPOSE_EMAIL, asposeEmail);


            //ASPOSE_WORDS
            AsposeComponent asposeOCR = new AsposeComponent();
            asposeOCR.set_downloadUrl("");
            asposeOCR.get_downloadFileName();
            asposeOCR.set_name(Constants.ASPOSE_OCR);
            list.Add(Constants.ASPOSE_OCR, asposeOCR);

            //ASPOSE_WORDS
            AsposeComponent asposeImaging = new AsposeComponent();
            asposeImaging.set_downloadUrl("");
            asposeImaging.set_downloadFileName("aspose.imaging.zip");
            asposeImaging.set_name(Constants.ASPOSE_IMAGING);
            asposeImaging.RemoteExamplesRepository = "https://github.com/asposeimaging/Aspose_Imaging_NET.git";
            list.Add(Constants.ASPOSE_IMAGING, asposeImaging);


            //aspose.tasks
            //aspose.diagram
        }
    }
}