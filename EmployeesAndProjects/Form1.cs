namespace EmployeesAndProjects
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        List<string> employees = new List<string>();
        Dictionary<string, string[]> pairs = new Dictionary<string, string[]>();
        Dictionary<string, int> daysTogether = new Dictionary<string, int>();
        string[] headerLabels = new string[] { "Employee ID #1", "Employee ID #2", "Project ID", "Days worked" };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            filePath.Text = openFileDialog.FileName;
            BindDataCSV(filePath.Text);

            if (employees.Count > 0 )
            {
                var kvp = GetPairs();
                BestPairs(kvp);
            }
        }

        private void BestPairs(string[] kvp)
        {
            foreach (var headerWord in headerLabels)
            {
                dt2.Columns.Add(new DataColumn(headerWord));
            }

            DataRow row = dt2.NewRow();
            int index = 0;

            foreach (var headerWord in headerLabels)
            {
                row[headerWord] = kvp[index++];
            }

            dt2.Rows.Add(row);

            if (dt2.Rows.Count > 0)
            {
                Pairs.DataSource = dt2;
            }
        }

        private string[] GetPairs()
        {
            while (employees.Count > 0)
            {
                employees.ForEach((line1) =>
                {
                    var el1 = line1.Split(';');
                    var emp1Id = el1[0];
                    var projectId = el1[1];
                    var emp1StartDate = DateTime.Parse(el1[2]);
                    var emp1EndDate = el1[3];

                    employees.GetRange(employees.IndexOf(line1) + 1, employees.Count - employees.IndexOf(line1) - 1).ForEach(line2 =>
                    {
                        var el2 = line2.Split(';');
                        var emp2Id = el2[0];
                        var emp2StartDate = DateTime.Parse(el2[2]);
                        var emp2EndDate = el2[3];

                        if (el1[0] != el2[0])
                        {
                            var startDate1 = emp1StartDate;
                            var endDate1 = emp1EndDate == "NULL" ? new DateTime() : DateTime.Parse(emp1EndDate);
                            var startDate2 = emp2StartDate;
                            var endDate2 = emp2EndDate == "NULL" ? new DateTime() : DateTime.Parse(emp2EndDate);

                            var start = DateTime.Compare(startDate1, startDate2) <= 0 ? startDate2 : startDate1;
                            var end = DateTime.Compare(endDate1, endDate2) <= 0 ? endDate2 : endDate1;

                            if (end >= startDate2)
                            {
                                var diffDays = Math.Abs(end.Subtract(start).Days);
                                var x = $"{el1[0]}{el2[0]}";

                                if (!daysTogether.ContainsKey(x))
                                {
                                    daysTogether[x] = 0;
                                }
                                daysTogether[x] = 1 * daysTogether[x] + diffDays;

                                if (!pairs.ContainsKey(x))
                                {
                                    pairs[x] = new string[] { emp1Id, emp2Id, projectId, diffDays.ToString() };
                                }
                            }
                        }
                    });
                });

                return pairs[daysTogether.Keys.Aggregate((a, b) => daysTogether[a] > daysTogether[b] ? a : b)];

            }

            return null;
        }

        private void BindDataCSV(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length > 0) 
            {
                string firstLine = lines[0];

                string[] headerLabels = firstLine.Split(';');

                foreach (var headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataElements = lines[i].Split(';');
                    employees.Add(lines[i]);

                    DataRow row = dt.NewRow();
                    int columnIndex = 0;

                    foreach (var headerWord in headerLabels)
                    {
                        row[headerWord] = dataElements[columnIndex++];
                    }

                    dt.Rows.Add(row);
                }
            }

            if (dt.Rows.Count > 0)
            {
                EmployeesAndProjects.DataSource = dt;
            }
        }
    }
}
