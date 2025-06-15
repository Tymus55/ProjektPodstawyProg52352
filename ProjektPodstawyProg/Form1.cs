using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using OfficeOpenXml;

namespace ProjektPodstawyProg
{
    public partial class Form1 : Form
    {
        private DataTable fullData;

        
        public Form1()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            InitializeComponent();
            LoadEmbeddedExcel();
        }

        private void LoadEmbeddedExcel()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "ProjektPodstawyProg.Statystyki_LaLiga_2024_25.xlsx";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    MessageBox.Show("Nie znaleziono pliku Excel jako zasobu osadzonego.");
                    return;
                }

                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    var start = worksheet.Dimension.Start;
                    var end = worksheet.Dimension.End;

                    DataTable dt = new DataTable();
                    for (int col = start.Column; col <= end.Column; col++)
                        dt.Columns.Add(worksheet.Cells[start.Row, col].Text);

                    for (int row = start.Row + 1; row <= end.Row; row++)
                    {
                        DataRow newRow = dt.NewRow();
                        for (int col = start.Column; col <= end.Column; col++)
                        {
                            newRow[col - 1] = worksheet.Cells[row, col].Text;
                        }
                        dt.Rows.Add(newRow);
                    }

                    fullData = dt;

                    var kluby = fullData.AsEnumerable()
                        .Select(r => r["Klub"].ToString())
                        .Distinct()
                        .OrderBy(n => n)
                        .ToArray();

                    comboBoxKlub.Items.AddRange(kluby);
                }
            }
        }

        private void comboBoxKlub_SelectedIndexChanged(object sender, EventArgs e)
        {
            string klub = comboBoxKlub.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(klub)) return;

            var zawodnicy = fullData.AsEnumerable()
                .Where(r => r["Klub"].ToString() == klub)
                .Select(r => r["Zawodnik"].ToString())
                .Distinct()
                .OrderBy(n => n)
                .ToList();

            comboBoxZawodnik.DataSource = null;
            comboBoxZawodnik.DataSource = zawodnicy;
            comboBoxZawodnik.SelectedIndex = -1;
        }
        private void comboBoxZawodnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            string klub = comboBoxKlub.SelectedItem?.ToString();
            string zawodnik = comboBoxZawodnik.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(klub) || string.IsNullOrEmpty(zawodnik)) return;

            var dane = fullData.AsEnumerable()
                .FirstOrDefault(r => r["Klub"].ToString() == klub && r["Zawodnik"].ToString() == zawodnik);

            if (dane == null) return;

            labelMinuty.Text = "Minuty: " + dane["Minuty"];
            labelGole.Text = "Gole: " + dane["Gole"];
            labelAsysty.Text = "Asysty: " + dane["Asysty"];
            labelZolte.Text = "Żółte kartki: " + dane["Żółte kartki"];
            labelCzerwone.Text = "Czerwone kartki: " + dane["Czerwone kartki"];

        }
    }
}
