namespace probnayaIgra
{
    public partial class FormGameOfWords : Form
    {


        string[] words = {"����������������", "������", "������", "����", "�������", "�������","����������", "�������"}; // �����, ������������ � ����

        Random rnd = new Random();

        int correct = 0;
        int incorrect = 0;

        public FormGameOfWords()
        {
            InitializeComponent();


            lblword.Text = words[rnd.Next(0, words.Length)]; // ������� �����, ������� ��������� ������� ���������� �� �������
        }

        private void checkGame(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                if (textBox1.Text == lblword.Text) // ���� �������� ����� ��������� � ������������, �� ��������� � ���� �������
                {
                    correct++; // ���������� � ���������� ���������� ������� +1
                    lblword.Text = words[rnd.Next(0, words.Length)]; // ������� ����� �����, ���� ����� ������
                    textBox1.Text = null; // �������� ������ �����
                }
                else
                {
                    incorrect++; // ���������� +1 � �������� ������������� ����� ����
                    lblword.Text = words[rnd.Next(0, words.Length)]; // ������ �����
                    textBox1.Text = null; // �������� ������ ��� �������� �����
                }

                lblright.Text = "���������� �������: " + correct; // ��������� ������� ����������� ������� � ������� ���������� correct
                lblwrong.Text = "������������ �������: " + incorrect; // ��������� ������� ������������ ������� � ������� ���������� incorrect


            }


        }
    }
}