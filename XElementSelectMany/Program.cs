﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XElementSelectMany
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                var fullname = System.Reflection.Assembly.GetEntryAssembly().Location;
                var progname = Path.GetFileNameWithoutExtension(fullname);
                Console.Error.WriteLine(progname + ": Error: " + ex.Message);
            }

        }
    }
}
