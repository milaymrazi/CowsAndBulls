﻿using CowsAndBulls.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CowsAndBulls
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                PlayerBase.DeserializePlayerBase();
            }
            catch (Exception)
            {
                PlayerBase.InitializePlayerBase();
            }

            DescriptionBase.Read();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());
        }
    }
}
