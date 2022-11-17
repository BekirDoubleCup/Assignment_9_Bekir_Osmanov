
namespace Assignment_9_Bekir_Osmanov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
        
                String str = stringBox.Text;
                int[] charCount = new int[256];
                int length = str.Length;
                for ( int i = 0; i < length; i++)
                {
                    charCount[str[i]]++;
                }
                int maxCount = -1;
                char character = ' ';
                for (int i = 0; i < length; i++)
                {
                    if (maxCount < charCount[str[i]])
                    {
                        maxCount = charCount[str[i]];
                        character = str[i];
                    }
                }
                label4.Text = ("" + character);
                label5.Text = ("" + maxCount);
        }
    }
}