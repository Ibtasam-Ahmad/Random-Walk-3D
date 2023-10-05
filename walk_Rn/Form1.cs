using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace walk_Rn
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

        private void dgvnextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            int[,] x = new int [4, 5];
            Random ran= new Random();
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    x[i, j] = ran.Next(5,20);
                }
            }
            for (int j = 0; j < x.GetLength(1); j++)
            {
                dt.Columns.Add("Column" + j.ToString());
            }
            for (int i = 0; i < x.GetLength(0); i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    dr[j] = x[i, j];
                }
                dt.Rows.Add(dr);
            }
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
             this.Refresh();

            Random ran = new Random();
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Black);
            int steps = int.Parse(textBox1.Text);
            int walk = int.Parse(textBox2.Text);
            double[] xsav = new double[steps];

            for (int i = 0; i < walk; i++)
            {
                int x = 0;
                //int y = 0;
                for (int j = 0; j < steps; j++)
                {
                    double d = ran.NextDouble();
                    if (d < 0.5)
                        x = x + 1;
                    else
                        x = x - 1;
                    xsav[j] = xsav[j] + x * x;
                    gg.FillEllipse(sb, 200 + j*5, 200 - x*5, 5, 5);
                }

            }
            for (int i = 0; i < steps; i++)
            {
                xsav[i] = xsav[i] / walk;
                gg.FillEllipse(new SolidBrush(Color.Blue), 200 + i * 5, 200 - (float)(xsav[i] * 5), 5, 5);
                gg.FillEllipse(new SolidBrush(Color.Brown), 200 + i * 5, 200 - (float)Math.Sqrt(xsav[i]) * 5, 5, 5);
            }
        }

        private void dToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Refresh();

            Random ran = new Random();
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Black);
            int steps = int.Parse(textBox1.Text);
            int walk = int.Parse(textBox2.Text);
            double[] xsav = new double[steps];

            for (int i = 0; i < walk; i++)
            {
                int x = 0;
                int y = 0;
                for (int j = 0; j < steps; j++)
                {
                    double d = ran.NextDouble();
                    if (d < 0.25)
                        x = x + 1;
                    else if (d > 0.25 && d < 0.50)
                        x = x - 1;
                    else if (d > 0.5 && d < 0.75)
                        y = y + 1;
                    else if (d > 0.75)
                        y = y - 1;
                    xsav[j] = xsav[j] + x * x + y * y;
                    gg.FillEllipse(sb, 200 + x * 5, 200 - y * 5, 5, 5);
                }

            }
            for (int i = 0; i < steps; i++)
            {
                xsav[i] = xsav[i] / walk;
                gg.FillEllipse(new SolidBrush(Color.Blue), 200 + i * 5, 200 - (float)(xsav[i] * 5), 5, 5);
                gg.FillEllipse(new SolidBrush(Color.Brown), 200 + i * 5, 200 - (float)Math.Sqrt(xsav[i]) * 5, 5, 5);
            }
        }

        private void dToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Refresh();

            Random ran = new Random();
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Black);
            int steps = int.Parse(textBox1.Text);
            int walk = int.Parse(textBox2.Text);
            double[] xsav = new double[steps];

            for (int i = 0; i < walk; i++)
            {
                int x = 0;
                int y = 0;
                int z = 0;
                for (int j = 0; j < steps; j++)
                {
                    double d = ran.NextDouble();
                    if (d < 0.16)
                        x = x + 1;
                    else if (d > 0.16 && d < 0.32)
                        x = x - 1;
                    else if (d > 0.32 && d < 0.48)
                        y = y + 1;
                    else if (d > 0.48 && d < 0.64)
                        y = y - 1;
                    else if (d > 0.64 && d < 0.80)
                        z = z + 1;
                    else if (d > 0.80)
                        z = z - 1;
                    xsav[j] = xsav[j] + x * x + y * y + z * z;
                    gg.FillEllipse(sb, 200 + x * 5, 200 - y * 5, 5, 5);
                    gg.FillEllipse(new SolidBrush(Color.Red), 200 + x * 5, 200 - z * 5, 5, 5);
                    gg.FillEllipse(new SolidBrush(Color.Blue), 200 + y * 5, 200 - z * 5, 5, 5);
                }

            }
            for (int i = 0; i < steps; i++)
            {
                xsav[i] = xsav[i] / walk;
                gg.FillEllipse(new SolidBrush(Color.Green), 200 + i * 5, 200 - (float)(xsav[i]*5), 5, 5);
                gg.FillEllipse(new SolidBrush(Color.Brown), 200 + i * 5, 200 - (float)Math.Sqrt(xsav[i]) * 5, 5, 5);
            }
        }

        private void dgvdouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            double[,] x = new double[4, 5];
            Random ran = new Random();
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    x[i, j] = ran.NextDouble();
                }
            }
            for (int j = 0; j < x.GetLength(1); j++)
            {
                dt.Columns.Add("Column" + j.ToString());
            }
            for (int i = 0; i < x.GetLength(0); i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    dr[j] = x[i, j];
                }
                dt.Rows.Add(dr);
            }
        }

        private void dgvdounextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            double[,] x = new double[4, 5];
            Random ran = new Random();
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    x[i, j] = ran.NextDouble()+ran.Next(5,20);
                }
            }
            for (int j = 0; j < x.GetLength(1); j++)
            {
                dt.Columns.Add("Column" + j.ToString());
            }
            for (int i = 0; i < x.GetLength(0); i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    dr[j] = Math.Round(x[i, j],5);
                }
                dt.Rows.Add(dr);
            }
        }

        private void lengthrandomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x1 = 2, x2 = 10, Randlen = 0, aclen = x2 - x1;
            double xmin = 0, xmax = this.ClientSize.Width;
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Black);
            Random gen = new Random();
        }

        private void selfavoidingwalkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();

            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Black);
            Random rnd = new Random();
            int step = int.Parse(textBox1.Text);
            int walker = int.Parse(textBox2.Text);
            Point[,] walks = new Point[walker, step];
            double[] x2av = new double[step];
            int[] counter = new int[walker];
            for (int i = 0; i < walker; i++)
            {
                int x = 0;
                int y = 0;
                bool flag = false;
                for (int j = 0; j < step; j++)
                {
                     double d = rnd.NextDouble();
                    if (d < 0.25)
                        x = x + 1;
                    else if (d > 0.25 && d < 0.50)
                        x = x - 1;
                    else if (d > 0.5 && d < 0.75)
                        y = y + 1;
                    else if (d > 0.75)
                        y = y - 1;
                    walks[i, j] = new Point(x, y);
                    for (int k = 0; k < j; k++)
                    {
                        if (walks[i, j] == walks[i, k])
                            flag = true;
                    }
                    if (flag == true)
                    {  
                        counter[i]=counter[i]+1;
                       // break;
                      
                    }
                    else
                    {
                        gg.FillEllipse(sb,200+x*5,200-y*5,4,4);
                        
                    }
                }

                
            }
            for (int i = 0; i < step; i++)
            {
                double sum = 0;
                for (int j = 0; j < walker; j++)
                {
                    sum = sum + Math.Pow(walks[j, i].X, 2) + Math.Pow(walks[j, i].Y, 2);
                }
                sum = sum / walker;
                gg.FillEllipse(new SolidBrush(Color.Red), 200 + i*5, 200 - (float)sum*5, 5, 5);
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("no");
            dt.Columns.Add("rejected");
            for (int i = 0; i < walker; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = i + 1;
                dr[1] = counter[i];
                dt.Rows.Add(dr);
                
            }
            dataGridView1.DataSource = dt;


        }

    }
}
