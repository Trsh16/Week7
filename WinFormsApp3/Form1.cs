namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_Konversi_Click(sender, e);
        }

        private void textBox_Kalimat_TextChanged(object sender, EventArgs e)
        {
            label_Hasil.Text = textBox_Kalimat.Text.ToUpper();
            string Kalimat = textBox_Kalimat.Text;
        }

        private void button_Konversi_Click(object sender, EventArgs e)
        {
            String conversion(char[] charSet,
                            String str)
            {
                int n = str.Length;
                char[] hashChar = new char[26];
                for (int i = 0; i < 26; i++)
                {
                    int ch = Math.Abs(charSet[i] - 'a');
                    hashChar[ch] = (char)('a' + i);
                }
               
                String s = textBox_Menjadi.Text;
                for (int i = 0; i < n; i++)
                {
                    s += hashChar[str[i] - 'a'];
                }
                return s;
            }
            char[] charSet = "cdefghijklmnopqrstuvwxyzab".ToCharArray();
            String str = textBox_Kalimat.Text;
            str = conversion(charSet, str);
            label_Hasil.Text = str.ToUpper();
        }
    }
}