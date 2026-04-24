   
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Win32;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER;
using Fileprompt;
namespace EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_PICKER
{
    public class File_Picker01
    {
   private string basePath = Path.GetFullPath(Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory,
        "EASY_CALLENDER01",
        "FILES",
        "IMAGES",
        "IMAGES_EMBEDDED"
    )); 

        public void FilePickerExamples()
        {


            Filepicker.Select(); //current location as starting point
            Filepicker.Select(new string[] { "xml", "json" }); //force select filetype
            Filepicker.Select(@"C:\Location"); //selects location as starting point
            Filepicker.Select(@"C:\Location", new string[] { "xml", "json" }); //select location + force select filetype


        }


     public string Filepicker_photo01()
        {


    return Filepicker.Select(basePath);


        }


    }
}
