using System;  //СОЗДАТЬ СПИСОК СЛОВ INIT_LIST_OF_WORDS И этот список при запуске записывать в файл и не трогать этот список бол
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
    public partial class Gallows : Form
    {
        public string currentTheme;
        public char[] guessed_letters;
        public Gallows(string SelectedTheme)
        {
            InitializeComponent();
            currentTheme = SelectedTheme;
            
            LoadWords();
            visible_button();
            this.KeyPreview = true;
            this.BackgroundImage = Image.FromFile("background1.png");
        }

        public string word = null;
        int quantity_symbols = 0;
        List<string> list_of_words = new List<string>();
        public string dashword = null;
        public string result = "";
        public string display_word = "";
        public const int number_of_tries = 7;
        public int tries_in_this_round = 0;
        public static int quantity_of_guesed_word = 0;
        public string win_or_lose = "";
        string input_file_name = "";
        public bool theme_finished = false;
        public List<string> finished_themes = new List<string>();
        public void LoadWords()
        {
            //visible_button();
            list_of_words.Clear();
            label_kol_guessed_words.Text = $"Количество отгаданных слов:{quantity_of_guesed_word}";
            string line = null;
            
            if (currentTheme == "Еда")
            {
                input_file_name = "Food.txt";
                label_selected_theme.Text = "Выбранная тема: Еда";
            }
            if (currentTheme == "Животные")
            {
                input_file_name = "Animals.txt";
                label_selected_theme.Text = "Выбранная тема: Животные";
            }
            if (currentTheme == "Хобби")
            {
                input_file_name = "Hobby.txt";
                label_selected_theme.Text = "Выбранная тема: Хобби";
            }
            if (currentTheme == "Растения")
            {
                input_file_name = "Flora.txt";
                label_selected_theme.Text = "Выбранная тема: Растения";
            }

            StreamReader read_stream = new StreamReader(input_file_name, Encoding.GetEncoding(1251));//Encoding.UTF8);//Encoding.GetEncoding(1251));

            line = read_stream.ReadLine();
            read_stream.Close();

            if (line != null)
            {

                foreach (var i in line.Split(' '))
                {
                    list_of_words.Add(i);
                }
                Random rand = new Random();
                int random_number = rand.Next(0, list_of_words.Count - 1);
                word = list_of_words[random_number];

                label1.Text = "";

                //MessageBox.Show(word);

                foreach (char sym in word)
                {
                    quantity_symbols += 1;
                }

                for (int i = 0; i < quantity_symbols; i++)
                {
                    dashword += "- ";
                    result += "- ";
                    display_word += "- ";
                }

                label1.Text = dashword;
                label1.TextAlign = ContentAlignment.MiddleCenter;
            }       
                   
        }

        private void Button(char letter)
        {

            if (word.Contains(letter))
            {
                display_word = UpdateDisplayWord(word, display_word, letter);
                label1.Text = display_word;
                label1.Update();
                //Игра окончена победой
                if (display_word.Replace(" ", "").Equals(word)) 
                {
                    End_of_Game("win");
                    System.Threading.Thread.Sleep(2000);
                    
                }
            }
            
            else
            {
                tries_in_this_round += 1;
                Picture();
                pictureBox1.Update();
                //Игра окончена неудачей
                if (tries_in_this_round >= number_of_tries)
                {
                    
                    End_of_Game("lose");
                    System.Threading.Thread.Sleep(2000);
                }
                
            }
           
        }
        public void Picture()
        {
            if(tries_in_this_round == 0)
            {
                FileStream fs = new FileStream("0.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                pictureBox1.Image = img;
            }
            if (tries_in_this_round == 1) 
            { 
                FileStream fs = new FileStream("1.png",FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                pictureBox1.Image = img;
            }
            if (tries_in_this_round == 2)
            {
                pictureBox1.Invalidate();
                FileStream fs = new FileStream("2.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                pictureBox1.Image = img;
                
            }
            if (tries_in_this_round == 3)
            {
                pictureBox1.Invalidate();
                FileStream fs = new FileStream("3.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                pictureBox1.Image = img;

            }
            if (tries_in_this_round == 4)
            {
                pictureBox1.Invalidate();
                FileStream fs = new FileStream("4.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                pictureBox1.Image = img;

            }
            if (tries_in_this_round == 5)
            {
                pictureBox1.Invalidate();
                FileStream fs = new FileStream("5.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                pictureBox1.Image = img;

            }
            if (tries_in_this_round == 6)
            {
                pictureBox1.Invalidate();
                FileStream fs = new FileStream("6.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                pictureBox1.Image = img;

            }
            if (tries_in_this_round == 7)
            {
                pictureBox1.Invalidate();
                FileStream fs = new FileStream("7.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                pictureBox1.Image = img;

            }
        }

        public void visible_button()
        {
            List<Button> letterButtons = new List<Button>
            {
                А, Б, В, Г, Д, Е, Ё, Ж, З, И, Й, К, Л, М, Н, О,
                П, Р, С, Т, У, Ф, Х, Ц, Ч, Ш, Щ, Ъ, Ы, Ь, Э, Ю, Я
            };
            foreach (var i in letterButtons)
            {
                i.Visible = true;
            }
        }
        public void invisible_button()
        {
            List<Button> letterButtons = new List<Button>
            {
                А, Б, В, Г, Д, Е, Ё, Ж, З, И, Й, К, Л, М, Н, О,
                П, Р, С, Т, У, Ф, Х, Ц, Ч, Ш, Щ, Ъ, Ы, Ь, Э, Ю, Я
            };
            foreach (var i in letterButtons)
            {
                i.Visible = false;
            }
        }
        public void End_of_Game(string win_or_lose)
        {
            //Обнулили все значения
            tries_in_this_round = 0;
            FileStream fs = new FileStream("0.png", FileMode.Open);
            Image img = Image.FromStream(fs);
            fs.Close();
            pictureBox1.Image = img;
            result = "";
            dashword = "";
            quantity_symbols = 0;
            display_word = "";

            visible_button();

            if (win_or_lose == "win")
            {
                quantity_of_guesed_word += 1;
                label_kol_guessed_words.Text = $"Количество отгаданных слов:{quantity_of_guesed_word}";
                
                //Убрали слово из list_of_words
                list_of_words.Remove(word);

                
                // Перезаписали файл

                StreamWriter write_stream = new StreamWriter(input_file_name, false, Encoding.GetEncoding(1251));//Encoding.UTF8);//Encoding.GetEncoding(1251));
                for(int i = 0;  i < list_of_words.Count - 1; i++)
                {
                    write_stream.Write(list_of_words[i] + " ");

                }
                if(list_of_words.Count > 0)
                {
                    write_stream.Write(list_of_words[list_of_words.Count - 1]);
                }
                else
                {
                    MessageBox.Show("Вы отгадали все слова в этой теме! Выберите другую тему.");

                    //invisible_button();
                    DialogResult = DialogResult.OK;
                    finished_themes.Add(currentTheme);
                    theme_finished = true;

                }
                write_stream.Close();

                //Загружаем новое слово
                LoadWords();
                

                //Обновляем счетчик количества отгаданных слов
                

            }


            else if (win_or_lose == "lose")
            {
                label1.Text = word;
                label1.Update();
                //Загружаем новое слово
                LoadWords();
            }
        }
        static string UpdateDisplayWord(string word, string display_word, char letter)
        {
            char[] displayArray = display_word.Replace(" ", "").ToCharArray();

            // Проходим по всем буквам загаданного слова
            for (int i = 0; i < word.Length; i++)
            {
                // Если на этой позиции нужная буква
                if (word[i] == letter)
                {
                    // Заменяем черточку на угаданную букву
                    displayArray[i] = letter;
                }
            }

            // Формируем новую строку с пробелами между символами
            string result = "";
            for (int i = 0; i < displayArray.Length; i++)
            {
                result += displayArray[i];
                if (i < displayArray.Length - 1) result += " ";
            }

            return result;
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Gallows_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 'а' || e.KeyChar == 'А') && А.Visible) А_Click(sender, e);
            if ((e.KeyChar == 'б' || e.KeyChar == 'Б') && Б.Visible) Б_Click(sender, e);
            if ((e.KeyChar == 'в' || e.KeyChar == 'В') && В.Visible) В_Click(sender, e);
            if ((e.KeyChar == 'г' || e.KeyChar == 'Г') && Г.Visible) Г_Click(sender, e);
            if ((e.KeyChar == 'д' || e.KeyChar == 'Д') && Д.Visible) Д_Click(sender, e);
            if ((e.KeyChar == 'е' || e.KeyChar == 'Е') && Е.Visible) Е_Click(sender, e);
            if ((e.KeyChar == 'ё' || e.KeyChar == 'Ё') && Ё.Visible) Ё_Click(sender, e);
            if ((e.KeyChar == 'ж' || e.KeyChar == 'Ж') && Ж.Visible) Ж_Click(sender, e);
            if ((e.KeyChar == 'з' || e.KeyChar == 'З') && З.Visible) З_Click(sender, e);
            if ((e.KeyChar == 'и' || e.KeyChar == 'И') && И.Visible) И_Click(sender, e);
            if ((e.KeyChar == 'й' || e.KeyChar == 'Й') && Й.Visible) Й_Click(sender, e);
            if ((e.KeyChar == 'к' || e.KeyChar == 'К') && К.Visible) К_Click(sender, e);
            if ((e.KeyChar == 'л' || e.KeyChar == 'Л') && Л.Visible) Л_Click(sender, e);
            if ((e.KeyChar == 'м' || e.KeyChar == 'М') && М.Visible) М_Click(sender, e);
            if ((e.KeyChar == 'н' || e.KeyChar == 'Н') && Н.Visible) Н_Click(sender, e);
            if ((e.KeyChar == 'о' || e.KeyChar == 'О') && О.Visible) О_Click(sender, e);
            if ((e.KeyChar == 'п' || e.KeyChar == 'П') && П.Visible) П_Click(sender, e);
            if ((e.KeyChar == 'р' || e.KeyChar == 'Р') && Р.Visible) Р_Click(sender, e);
            if ((e.KeyChar == 'с' || e.KeyChar == 'С') && С.Visible) С_Click(sender, e);
            if ((e.KeyChar == 'т' || e.KeyChar == 'Т') && Т.Visible) Т_Click(sender, e);
            if ((e.KeyChar == 'у' || e.KeyChar == 'У') && У.Visible) У_Click(sender, e);
            if ((e.KeyChar == 'ф' || e.KeyChar == 'Ф') && Ф.Visible) Ф_Click(sender, e);
            if ((e.KeyChar == 'х' || e.KeyChar == 'Х') && Х.Visible) Х_Click(sender, e);
            if ((e.KeyChar == 'ц' || e.KeyChar == 'Ц') && Ц.Visible) Ц_Click(sender, e);
            if ((e.KeyChar == 'ч' || e.KeyChar == 'Ч') && Ч.Visible) Ч_Click(sender, e);
            if ((e.KeyChar == 'ш' || e.KeyChar == 'Ш') && Ш.Visible) Ш_Click(sender, e);
            if ((e.KeyChar == 'щ' || e.KeyChar == 'Щ') && Щ.Visible) Щ_Click(sender, e);
            if ((e.KeyChar == 'ъ' || e.KeyChar == 'Ъ') && Ъ.Visible) Ъ_Click(sender, e);
            if ((e.KeyChar == 'ы' || e.KeyChar == 'Ы') && Ы.Visible) Ы_Click(sender, e);
            if ((e.KeyChar == 'ь' || e.KeyChar == 'Ь') && Ь.Visible) Ь_Click(sender, e);
            if ((e.KeyChar == 'э' || e.KeyChar == 'Э') && Э.Visible) Э_Click(sender, e);
            if ((e.KeyChar == 'ю' || e.KeyChar == 'Ю') && Ю.Visible) Ю_Click(sender, e);
            if ((e.KeyChar == 'я' || e.KeyChar == 'Я') && Я.Visible) Я_Click(sender, e);
        }

        private void А_Click(object sender, EventArgs e)
        {
            А.Visible = false;
            Button('А');
        }
        private void Б_Click(object sender, EventArgs e)
        {
            Б.Visible = false;
            Button('Б');
        }
        private void В_Click(object sender, EventArgs e)
        {
            В.Visible = false;
            Button('В'); 
        }
        private void Г_Click(object sender, EventArgs e)
        {
            Г.Visible = false;
            Button('Г');
        }
        private void Д_Click(object sender, EventArgs e)
        {
            Д.Visible = false;
            Button('Д');
        }
        private void Е_Click(object sender, EventArgs e)
        {
            Е.Visible = false;
            Button('Е');
        }
        private void Ё_Click(object sender, EventArgs e)
        {
            Ё.Visible = false;
            Button('Ё');
        }
        private void Ж_Click(object sender, EventArgs e)
        {
            Ж.Visible = false;
            Button('Ж');
        }
        private void З_Click(object sender, EventArgs e)
        {
            З.Visible = false;
            Button('З');
        }
        private void И_Click(object sender, EventArgs e)
        {
            И.Visible = false;
            Button('И');
        }
        private void Й_Click(object sender, EventArgs e)
        {
            Й.Visible = false;
            Button('Й');
        }
        private void К_Click(object sender, EventArgs e)
        {
            К.Visible = false;
            Button('К');
        }
        private void Л_Click(object sender, EventArgs e)
        {
            Л.Visible = false;
            Button('Л');
        }
        private void М_Click(object sender, EventArgs e)
        {
            М.Visible = false;
            Button('М');
        }
        private void Н_Click(object sender, EventArgs e)
        {
            Н.Visible = false;
            Button('Н');
        }
        private void О_Click(object sender, EventArgs e)
        {
            О.Visible = false;
            Button('О');
        }
        private void П_Click(object sender, EventArgs e)
        {
            П.Visible = false;
            Button('П');
        }
        private void Р_Click(object sender, EventArgs e)
        {
            Р.Visible = false;
            Button('Р');
        }
        private void С_Click(object sender, EventArgs e)
        {
            С.Visible = false;
            Button('С');
        }
        private void Т_Click(object sender, EventArgs e)
        {
            Т.Visible = false;
            Button('Т');
        }
        private void У_Click(object sender, EventArgs e)
        {
            У.Visible = false;
            Button('У');
        }
        private void Ф_Click(object sender, EventArgs e)
        {
            Ф.Visible = false;
            Button('Ф');
        }
        private void Х_Click(object sender, EventArgs e)
        {
            Х.Visible = false;
            Button('Х');
        }
        private void Ц_Click(object sender, EventArgs e)
        {
            Ц.Visible = false;
            Button('Ц');
        }
        private void Ч_Click(object sender, EventArgs e)
        {
            Ч.Visible = false;
            Button('Ч');
        }
        private void Ш_Click(object sender, EventArgs e)
        {
            Ш.Visible = false;
            Button('Ш');
        }
        private void Щ_Click(object sender, EventArgs e)
        {
            Щ.Visible = false;
            Button('Щ');
        }
        private void Ъ_Click(object sender, EventArgs e)
        {
            Ъ.Visible = false;
            Button('Ъ');
        }
        private void Ы_Click(object sender, EventArgs e)
        {
            Ы.Visible = false;
            Button('Ы');
        }
        private void Ь_Click(object sender, EventArgs e)
        {
            Ь.Visible = false;
            Button('Ь');
        }
        private void Э_Click(object sender, EventArgs e)
        {
            Э.Visible = false;
            Button('Э');
        }
        private void Ю_Click(object sender, EventArgs e)
        {
            Ю.Visible = false;
            Button('Ю');
        }
        private void Я_Click(object sender, EventArgs e)
        {
            Я.Visible = false;
            Button('Я');
        }

    }
}