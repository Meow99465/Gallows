using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hanged
{
    public partial class Menu : Form
    {
        public bool selected_theme_finished = false;
        public Menu(List<string> list_finished_themes_m)
        {
            InitializeComponent();
            Status_Game(list_finished_themes_m);
            
            
            BackgroundImage = Image.FromFile("background1.png");
            Finished_Themes(list_finished_themes_m);

        }
        List<string> list_files_name = new List<string>() { "Food.txt", "Animals.txt", "Hobby.txt", "Flora.txt"};
        public string SelectedTheme = null;
        List<string> theme_of_game = new List<string>() { "Еда","Животные","Хобби", "Растения" };

        public void Finished_Themes(List<string> list_finished_themes_m)
        {
            if (list_finished_themes_m.Contains("Еда"))
            {
                Food.Visible = false;
                Food.Update();
            }

            if (list_finished_themes_m.Contains("Животные"))
            {
                Animals.Visible = false;
            }
            if (list_finished_themes_m.Contains("Хобби"))
            {
                Hobby.Visible = false;
            }
            if (list_finished_themes_m.Contains("Растения"))
            {
                Flora.Visible = false;
            }
            if (list_finished_themes_m.Count >= theme_of_game.Count)
            {
                
                label_win.Visible = true;
                label_win.Text = "ПОЗДРАВЛЯЕМ! ВЫ ПРОШЛИ ИГРУ";
                label_win.Update();
            }
        }

        public void Status_Game(List<string> list_finished_themes_m)
        {
            
            foreach (var file_name in list_files_name)
            {
                string line = null;
                StreamReader read_stream = new StreamReader(file_name, Encoding.GetEncoding(1251));
                line = read_stream.ReadLine();
                if (line == null)
                {
                    if (file_name == "Food.txt" && !list_finished_themes_m.Contains("Еда")) list_finished_themes_m.Add("Еда");//Food.Visible = false;\
                    if (file_name == "Animals.txt" && !list_finished_themes_m.Contains("Животные")) list_finished_themes_m.Add("Животные");
                    if (file_name == "Hobby.txt" && !list_finished_themes_m.Contains("Хобби")) list_finished_themes_m.Add("Хобби");
                    if (file_name == "Flora.txt" && !list_finished_themes_m.Contains("Растения")) list_finished_themes_m.Add("Растения");

                }
                read_stream.Close();
            }
           
        }

        private void Food_Click(object sender, EventArgs e)
        {
            SelectedTheme = "Еда";
            //list_files_name.
            DialogResult = DialogResult.OK;
            
        }


        private void Animals_Click(object sender, EventArgs e)
        {
            SelectedTheme = "Животные";
            DialogResult = DialogResult.OK;
        }

        private void Hobby_Click(object sender, EventArgs e)
        {
            SelectedTheme = "Хобби";
            DialogResult = DialogResult.OK;
        }

        private void Flora_Click(object sender, EventArgs e)
        {
            SelectedTheme = "Растения";
            DialogResult = DialogResult.OK;
        }

       
    }
}
