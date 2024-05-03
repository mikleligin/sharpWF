
using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
namespace TestTask
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

        CultureInfo ruCulture = new CultureInfo("ru");
        CultureInfo enCulture = new CultureInfo("en");

        // �������������� XML �����

        private BOSMeth deserializeXML(string filePath)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(typeof(BOSMeth));
                using (MemoryStream stream = new MemoryStream())
                {
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        fileStream.CopyTo(stream);
                    }
                    stream.Position = 0;
                    return (BOSMeth)xml.Deserialize(stream);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("�������� ���� � ����������� XML");
                throw;
            }
            
        }
        BOSMeth test = new BOSMeth();
        string filename = "";

        // ��� ������� ���������� ���������� ���� � ����������� ������

        private void ChangeFile_Click(object sender, EventArgs e)
        { 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files (*.xml)|*.xml"; ;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog.FileName;
                NameFile.Text = filename;
            }
            test = deserializeXML(filename);
            NameFile.Text = test.Channels.channels[0].SignalFileName;
            comboBox1.Items.Add("������� ���");
            for (int i = 0; i < test.Channels.channels.Count; i++)
            {
                comboBox1.Items.Add(test.Channels.channels[i].SignalFileName);
            }
            dataGridView1.ReadOnly = true; 

        }
        int selectedIndexCB = 0;
        double time = 0;

        // ����� ���������� � ��������� 

        private void addCb(int index)
        {
            listBox1.Items.Add("���: " + test.Channels.channels[index].SignalFileName);
            switch (test.Channels.channels[index].Type)
            {
                case 1:
                    listBox1.Items.Add("���: " + "���");
                    break;
                case 2:
                    listBox1.Items.Add("���: " + "���");
                    break;
                case 3:
                    listBox1.Items.Add("���: " + "���");
                    break;

                default:
                    break;
            }

            listBox1.Items.Add("�������: " + test.Channels.channels[index].EffectiveFd);
            listBox1.Items.Add("���������� �����: " + test.Channels.channels[index].UnicNumber);
            listBox1.Items.Add("___");
        }

        // ������ �����, ������ �� ����������������� ������

        void readFile(calculator calculatorObj, int index)
        {
            int countBuffer = 0;
            int timer = 0;
            double[] values = new double[100];
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open($"{filename}\\..\\{test.Channels.channels[index].SignalFileName}", FileMode.Open)))
                {
                    
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        double value = reader.ReadDouble();
                        values[countBuffer] = value;
                        countBuffer++;
                        if (countBuffer % 100 == 0)
                        {
                            calculatorObj.setValues(values);
                            countBuffer = 0;
                            
                        }
                        timer++;
                    }
                }
                calculatorObj.times = timer;
            }
            catch (Exception ex)
            {

            }

        }

        // ����� ���������� �������

        private void createThread(int numThreads, calculator[] calculators)
        {
            Thread[] threads = new Thread[numThreads];
            for (int i = 0; i < numThreads; i++)
            {
                try
                {
                    threads[i] = new Thread(() => readFile(calculators[i], i));
                    threads[i].Start();
                    dataGridView1.Rows.Add();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            foreach (Thread thread in threads)
            {
                thread.Join();
            }
            for (int i = 0; i < numThreads; i++)
            {
                string [] final = calculators[i].getData();
                for (int h = 0; h < 4; h++)
                {
                    dataGridView1.CurrentCell = dataGridView1[h, i];
                    dataGridView1.CurrentCell.Value = final[h];
                    dataGridView1.CurrentCell = dataGridView1[4, i];
                    dataGridView1.CurrentCell.Value = $"{calculators[i].times/ test.Channels.channels[i].EffectiveFd}�"; 

                }
            }

        }

        // ������� ���� ����� 

        void clearAll()
        {
            listBox1.Items.Clear();
            dataGridView1.Rows.Clear();
        
        }

        // ����� ������ � ����������� �� ������

        private void GetLog_Click(object sender, EventArgs e)
        {
            clearAll();
            if (selectedIndexCB == -1)
            {
                calculator[] arr = new calculator[comboBox1.Items.Count - 1];
                for (int i = 0; i < comboBox1.Items.Count-1; i++)
                {
                    calculator obj = new calculator();
                    obj.name = test.Channels.channels[i].SignalFileName;
                    arr[i] = obj;
                    addCb(i);

                }
                createThread(comboBox1.Items.Count - 1, arr);
            }
            else
            { 
                calculator c = new calculator();
                c.name = test.Channels.channels[selectedIndexCB].SignalFileName;
                addCb(selectedIndexCB);
                readFile(c, selectedIndexCB);
                string[] final = c.getData();
                for (int h = 0; h < 4; h++)
                {
                    dataGridView1.CurrentCell = dataGridView1[h, 0];
                    dataGridView1.CurrentCell.Value = final[h];
                    dataGridView1.CurrentCell = dataGridView1[4, 0];
                    dataGridView1.CurrentCell.Value = $"{c.times / test.Channels.channels[selectedIndexCB].EffectiveFd}�";

                }
            }
            NameFile.Text = selectedIndexCB.ToString();   
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            selectedIndexCB = comboBox1.SelectedIndex;
            if (selectedIndexCB==0)
            {
                selectedIndexCB = -1;
            }
            else
            {
                selectedIndexCB--;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int switcher = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            switcher = -switcher;
            if (switcher == 1)
            {
                CultureInfo.CurrentCulture = ruCulture;
                button1.Text = "ru";
            }
            else
            {
                CultureInfo.CurrentCulture = enCulture;
                button1.Text = "en";
            }
        }
    }
}