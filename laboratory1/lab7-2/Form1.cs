using static System.Windows.Forms.LinkLabel;

namespace lab7_2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        struct PRICE
        {
            public string nameProduct;
            public string nameShop;
            public string price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] delimiterChars = { "\t", " ", ", " };
            PRICE dataShops = new PRICE();

            dataShops.nameProduct = textBox1.Text;
            dataShops.nameShop = textBox2.Text;
            dataShops.price = textBox3.Text;

            string[] products = dataShops.nameProduct.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            string[] shops = dataShops.nameShop.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            string[] prices = dataShops.price.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);

            if (products.Length != 8 || shops.Length != 8
                || prices.Length != 8)
            {
                MessageBox.Show("Введено недостаточно данных!");
                return;
            }

            try
            {
                StreamWriter sw = new StreamWriter("C:\\lab7-2\\Shops.txt");
                for (int i = 0; i < 8; i++)
                    sw.WriteLine(products[i] + ' ' + shops[i] + ' ' + prices[i]);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); return;
            }
            button2.Enabled = true;

        }
        static string ReadFile(string words)
        {
            string line;
            using (StreamReader sr = new StreamReader("C:\\lab7-2\\Shops.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    words += line + "\n";
                }
            }

            return words;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string lines = "";
            lines = ReadFile(lines);

            MessageBox.Show(lines);
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string lines = "";
            lines = ReadFile(lines);
            string[] line = lines.Split('\n');
            string textToShow = "";

            for (int i = 0; i < 8; i++)
            {
                string[] info = line[i].Split(" ");
                textToShow = textToShow + info[0] + " " + info[1] + "\n";
            }

            MessageBox.Show(textToShow);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string alphabet = "абвгдеёжзийклмпопрстуфхцчшщъыьэюя";
            string lines = "";
            lines = ReadFile(lines);
            string[] line = lines.Split('\n');
            int[] positions = new int[8];
            string[] finalLine = line;
            
            for (int i = 0; i < 8;i++)
            {
                string[] info = line[i].Split(" ");
                string tmpWord = info[2].ToLower();
                if (i == 8)
                    break;
                positions[i] = alphabet.IndexOf(tmpWord[0]);
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = i+1; j < 8; j++)
                {
                    if (positions[i] > positions[j])
                    {
                        string tmpLine = line[i];
                        int tmpPosition = positions[i];
                        line[i] = line[j];
                        positions[i] = positions[j];
                        line[j] = tmpLine;
                        positions[j] = tmpPosition;
                    }

                    else if (positions[i] == positions[j])
                    {
                        int count = 1;
                        string tmpLine = line[i];
                        while (true)
                        {
                            string[] infoI = line[i].Split(" ");
                            string tmpWordI = infoI[2].ToLower();
                            int newPositionI = alphabet.IndexOf(tmpWordI[count]);
                            string[] infoJ = line[j].Split(" ");
                            string tmpWordJ = infoJ[2].ToLower();
                            int newPositionJ = alphabet.IndexOf(tmpWordJ[count]);

                            if (newPositionI > newPositionJ)
                            {
                                int tmpPosition = positions[i];
                                line[i] = line[j];
                                positions[i] = positions[j];
                                line[j] = tmpLine;
                                positions[j] = tmpPosition - 1;
                                break;
                            }

                            else if (newPositionJ > newPositionI)
                                break;

                            count++;
                            if (count == tmpWordI.Length)
                                break;

                            else if (count == tmpWordJ.Length)
                            {
                                int tmpPosition = positions[i];
                                line[i] = line[j];
                                positions[i] = positions[j];
                                line[j] = tmpLine;
                                positions[j] = tmpPosition - 1;
                                break;
                            }
                        }
                    }
                }
            }

            string textToShow = "";

            try
            {
                StreamWriter sw = new StreamWriter("C:\\lab7-2\\Shops.txt");
                for (int i = 0; i < 8; i++)
                {
                    string[] info = line[i].Split(" ");
                    sw.WriteLine(info[0] + ' ' + info[1] + ' ' + "рублей" + ' ' + info[2]);
                    textToShow = textToShow + info[0] + ' ' + info[1] + ' ' + "рублей" + ' ' + info[2] + '\n';
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); return;
            }

            MessageBox.Show(textToShow);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
        
    }
}