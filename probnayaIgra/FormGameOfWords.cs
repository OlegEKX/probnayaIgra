namespace probnayaIgra
{
    public partial class FormGameOfWords : Form
    {


        string[] words = {"программирование", "строки", "массив", "цикл", "символы", "функции","переменная", "перебор"}; // слова, используемые в игре

        Random rnd = new Random();

        int correct = 0;
        int incorrect = 0;

        public FormGameOfWords()
        {
            InitializeComponent();


            lblword.Text = words[rnd.Next(0, words.Length)]; // выводим слово, которое рандомным образом выбирается из массива
        }

        private void checkGame(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                if (textBox1.Text == lblword.Text) // если введённое слово совпадает с предложенным, то переходим в тело условия
                {
                    correct++; // прибавляем к результату правильных ответов +1
                    lblword.Text = words[rnd.Next(0, words.Length)]; // выводим новое слово, если ответ верный
                    textBox1.Text = null; // обнуляем строку ввода
                }
                else
                {
                    incorrect++; // прибавляем +1 к счетчику неправильного ввода слов
                    lblword.Text = words[rnd.Next(0, words.Length)]; // меняем слово
                    textBox1.Text = null; // обнуляем строку для введения слова
                }

                lblright.Text = "Правильных ответов: " + correct; // обновляем счетчик праввильных ответов с помощью переменной correct
                lblwrong.Text = "Неправильных ответов: " + incorrect; // обновляем счетчик неправильных ответов с помощбю переменной incorrect


            }


        }
    }
}