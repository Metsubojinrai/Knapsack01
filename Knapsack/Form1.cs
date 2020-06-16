using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Knapsack
{
    public partial class Form1 : Form
    {
        public int numberOfItems = new int();
        public int capacity = new int();
        public int[,] arr = new int[100, 2];
        List<Item> items;
        OpenFileDialog data;
        public int populationSize;
        public double crossoverProb;
        public double mutateProb;
        public int maxGeneration;
        public int generation = 0;
        public List<int> fitness;
        public List<int> best;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private int[,] getData(string filename)
        {
            int[,] kq;
            int row = 0;
            int col = 0;
            string[] lines = File.ReadAllLines(filename);
            row = lines.Length;
            col = lines[0].Split(' ').Length;
            kq = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    kq[i, j] = Int32.Parse(lines[i].Split(' ')[j]);
                }
            }
            return kq;
        }

        private void btnData1_Click(object sender, EventArgs e)
        {
            data = new OpenFileDialog();
            while (data.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Chọn lại dataset ");
            }

            arr = getData(data.FileName);
            txtNoItem.Text = arr[0, 0].ToString();
            txtMaxWeight.Text = arr[0, 1].ToString();
            numberOfItems = arr[0,0];
            capacity = arr[0,1];
       
            items = new List<Item>();
            for(int i = 1;i<=numberOfItems; i++)
            {
                items.Add(new Item { v = arr[i, 0], w = arr[i, 1] });
            }

            dataGridView1.RowCount = numberOfItems;
            dataGridView1.ColumnCount = 2;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                row.HeaderCell.Value = String.Concat("Item ",
                    (row.Index + 1).ToString());
            }
            dataGridView1.Columns[0].HeaderCell.Value = " Value";
            dataGridView1.Columns[1].HeaderCell.Value = "Weight";
            for (int i = 0; i < numberOfItems; i++)
            {
                dataGridView1[0, i].Value = items[i].v;
                dataGridView1[1, i].Value = items[i].w;
            }
            btnStartDP.Enabled = true;
            btnRefresh1.Enabled = true;
        }

        private void btnStartDP_Click(object sender, EventArgs e)
        {
            var stopwatch = new Stopwatch();
            KnapsackDP.Init(items, capacity);
            stopwatch.Start();
            KnapsackDP.Run();
            stopwatch.Stop();

            txtItem2.Text = KnapsackDP.Print();
            txtMaxValue.Text = KnapsackDP.MaxValue.ToString();
            txtTime.Text = stopwatch.Elapsed.ToString();

            if (chkSave.Checked == true)
            {
                string path = data.FileName + "_optimum.txt";

                if (!File.Exists(path))
                {
                    FileStream f = new FileStream(path, FileMode.Create);

                    f.Close();
                }
                KnapsackDP.SavePicksMatrix(path);
                Process.Start(path);
            }
        }

        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            arr = new int[50, 2];
            btnStartDP.Enabled = false;
            btnRefresh1.Enabled = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            txtItem2.Clear();
            txtMaxValue.Clear();
            txtTime.Clear();
            txtNoItem.Clear();
            txtMaxWeight.Clear();
        }

        private void btnData2_Click(object sender, EventArgs e)
        {
            data = new OpenFileDialog();
            while (data.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Chọn lại dataset ");
            }

            arr = getData(data.FileName);
            txtNoItems.Text = arr[0, 0].ToString();
            txtMaxWeight2.Text = arr[0, 1].ToString();
            numberOfItems = arr[0, 0];
            capacity = arr[0, 1];

            items = new List<Item>();
            for (int i = 1; i <= numberOfItems; i++)
            {
                items.Add(new Item { v = arr[i, 0], w = arr[i, 1] });
            }

            dgvItem.RowCount = numberOfItems;
            dgvItem.ColumnCount = 2;
            foreach (DataGridViewRow row in dgvItem.Rows)
            {

                row.HeaderCell.Value = string.Concat("Item ",
                    (row.Index + 1).ToString());
            }
            dgvItem.Columns[0].HeaderCell.Value = " Value";
            dgvItem.Columns[1].HeaderCell.Value = "Weight";
            for (int i = 0; i < numberOfItems; i++)
            {
                dgvItem[0, i].Value = items[i].v;
                dgvItem[1, i].Value = items[i].w;
            }
            btnFinish.Enabled = true;
            btnRefresh2.Enabled = true;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            populationSize = Convert.ToInt32(numPop.Value);
            crossoverProb = Convert.ToDouble(numCross.Value);
            mutateProb = Convert.ToDouble(numMutate.Value);
            maxGeneration = Convert.ToInt32(numGeneration.Value);
            
            string result = "";
            KnapsackGA.Init(items, capacity);
            string bestsol = RunGA(populationSize, mutateProb, crossoverProb,maxGeneration, 0.9);

            int value = 0;
            int weight = 0;
            for (int i = 0; i < bestsol.Length; i++)
            {
                if (bestsol[i] == '1')
                {
                    result += (i + 1) + " ";
                    value += items[i].v;
                    weight += items[i].w;
                }
            }

            result += ", Fitness: " + value + ", Weight: " + weight;
            lbBestSolution.Text = result;
            lbBestSolution.Visible = true;
            btnFinish.Enabled = false;
        }

        public string RunGA(int popSize, double mut, double cross, int maxGen, double percent)
        {
            List<string> pop = KnapsackGA.generate(popSize);
            fitness = KnapsackGA.getFitness(pop);
        
            Stopwatch swObj = new Stopwatch();
            swObj.Start();
            while (!KnapsackGA.test(fitness, percent) && generation < maxGen)
            {
                generation++;
                pop = KnapsackGA.newPopulation(pop, fitness, mut, cross);
                fitness = KnapsackGA.getFitness(pop);
                best = KnapsackGA.BestFit(fitness);
            }
            swObj.Stop();

            lbGeneration.Text = generation.ToString();
            lbTime.Text = swObj.Elapsed.ToString();
            lbTime.Visible = true;
            chart1.Visible = true;
            RunChart();

            dt = new DataTable();
            dt.Columns.Add("Chronosome", typeof(string));
            dt.Columns.Add("Fitness", typeof(int));
            for (int i = 0; i < pop.Count; i++)
            {
                DataRow row = dt.NewRow();
                row["Chronosome"] = pop[i];
                row["Fitness"] = fitness[i];
                dt.Rows.Add(row);
            }
            dgvPopulation.DataSource = dt;

            return KnapsackGA.selectElite(pop, fitness);
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            dgvItem.Rows.Clear();
            dgvItem.Columns.Clear();
            dt.Clear();
            dgvPopulation.DataSource = dt;
            btnFinish.Enabled = false;
            btnRefresh2.Enabled = false;
            this.chart1.Series.Clear();
            lbBestSolution.Visible = false;
            lbTime.Visible = false;
            best = new List<int>();
        }

        private void RunChart()
        {
            this.chart1.Series.Clear();;
            Series series = this.chart1.Series.Add("Max Fitness");
            series.ChartType = SeriesChartType.Spline;
            for(int i = 0; i<best.Count;i++)
            {
                series.Points.AddXY(i+1, best[i]);
            }
        }
    }
}
