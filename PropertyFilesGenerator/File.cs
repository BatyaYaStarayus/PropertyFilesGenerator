using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyFilesGenerator
{
    class File
    {
        protected String userName = getUserName();
        protected String name;
        protected String path;
        protected String templateFilePath;
        protected String fileText = getFileText();

        protected String[] variablesArray;
        protected Dictionary<String, String> environmentElements = new Dictionary<String, String>();

        environmentElements.Add("dataBaseName", "sdaasd");

        protected String getStringFromFile()
        {
            return;
        }

        protected String replaceStringWith()
        {
            return;
        }

        protected String getUserName()
        {
            return Environment.UserName;
        }

        protected void createFile()
        {
            using (FileStream fs = File.Create(path + name));
        }

        protected void saveFile(path)
        {
            
        }

        protected void getFileText()
        {
            return File.ReadAllText(path + name);
        }

        protected void findStringInFile()
        {

        }

        protected void replaceStringWith(String toReplace, String replaceWith)
        {
            fileText.Replace(toReplace, replaceWith);
        }





    }
}
