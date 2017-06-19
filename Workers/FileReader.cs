﻿using System;
using System.IO;

namespace WordUnscrambler.Workers
{
    class FileReader
    {
        internal string[] Read(string filename)
        {
            string[] fileContent; 
            try
            {
                fileContent = File.ReadAllLines(filename);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return fileContent;
        }
    }
}
