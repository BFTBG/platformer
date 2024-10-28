using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs
{
    public partial class Record : Form
    {
        int score;
        public Record(int _score)
        {
            InitializeComponent();
            score = _score;
            if(score !=0)
            {
                listBox1.Items.Add(score);
            }
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\Users\\stast\\Desktop\\programming\\C#\\kursovik\\program\\kurs\\rec.txt", append: true))
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                    sw.WriteLine(listBox1.Items[i].ToString());
                sw.Close();
            }
            
            listBox1.Items.Clear();
            sort();
            using (System.IO.StreamReader sr = new System.IO.StreamReader("C:\\Users\\stast\\Desktop\\programming\\C#\\kursovik\\program\\kurs\\rec.txt"))
            {
                while (!sr.EndOfStream)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
            }
        }
        private void sort()
        {
            System.IO.StreamReader sn = new System.IO.StreamReader("C:\\Users\\stast\\Desktop\\programming\\C#\\kursovik\\program\\kurs\\rec.txt");
            List<int> A = new List<int>();
            int temp = 0;
            string s;
            while (!sn.EndOfStream)
            {
                s = sn.ReadLine();
                A.Add(Convert.ToInt32(s));
                Console.WriteLine(s);
            }
            for (int i = 0; i < A.Count - 1; i++)
            {
                for (int j = 0; j < A.Count - i - 1; j++)
                {
                    if (A[j] < A[j + 1])//Сортировка по убыванию,чтоб было по возрастанию смените знак в условном операторе if > на <
                    {
                        temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                    }
                }
            }
            sn.Close();
            System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\Users\\stast\\Desktop\\programming\\C#\\kursovik\\program\\kurs\\rec.txt");
            for(int i = 0; i<A.Count;i++)
            {
                sw.WriteLine(A[i].ToString());
            }
            sw.Close();
        }

    

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox1.Items.Add(score);
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

    }
}
