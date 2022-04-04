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

        }
     
        private void textBox_Kalimat_TextChanged(object sender, EventArgs e)
        {
            label_Hasil.Text = textBox_Kalimat.Text.ToUpper();
            string Kalimat = textBox_Kalimat.Text;
        }
        
        private void textBox_Huruf_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Menjadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Konversi_Click(object sender, EventArgs e)
        {
            char temp;         
            char[] character = textBox_Kalimat.Text.ToCharArray();
            for (int i = 0; i<character.Length-1; i++)
            {
                for (int j = 0; j < character.Length - i - 1; j++)
                {
                    if (character[j] > character[j + 1])
                    {
                        temp = character[j];
                        character[j] = character[j + 1];
                        character[j + 1] = temp;
                    }
                }
            }
            label_Hasil.Text = character.ToString();
        }

        private void label_Hasil_Click(object sender, EventArgs e)
        {
        }
    }
}