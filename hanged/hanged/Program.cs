using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace hanged
{
    internal static class Program
    {
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            List<string> finished_themes_p = new List<string>();
            bool returnToMenu = true;
            
            while (returnToMenu)
            {
                returnToMenu = false;

                using (Menu menuForm = new Menu(finished_themes_p))
                {
                    if (menuForm.ShowDialog() == DialogResult.OK)
                    {
                        using (Gallows mainForm = new Gallows(menuForm.SelectedTheme))
                        {
                            if (mainForm.ShowDialog() == DialogResult.OK)
                            {
                                bool flag = mainForm.theme_finished;
                                if (flag == true)
                                {
                                    /*if (!finished_themes_p.Contains(menuForm.SelectedTheme))
                                    {
                                        finished_themes_p.Add(menuForm.SelectedTheme);
                                    }*/
                                    finished_themes_p.Add(menuForm.SelectedTheme);
                                }
                                returnToMenu = true;
                            }
                        }
                    }
                }
            }
        }

    }
}
