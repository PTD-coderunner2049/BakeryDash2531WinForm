using SolbergBakery2531.BLL;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SolbergBakery2531.UI.Forms.StatisticForms
{
    public partial class FinacialStatistician : Form
    {
        private readonly FinacesService _financeService = new FinacesService();
        private readonly ProductService _productService = new ProductService();

        public FinacialStatistician()
        {
            InitializeComponent();
            SetupFilters();
            LoadData();

            YearFilterComboBox.SelectedIndexChanged += (s, e) => LoadData();
            MonthFilterComboBox.SelectedIndexChanged += (s, e) => LoadData();
        }

        private void SetupFilters()
        {
            for (int i = DateTime.Now.Year; i >= 2022; i--) YearFilterComboBox.Items.Add(i);
            YearFilterComboBox.SelectedIndex = 0;

            MonthFilterComboBox.Items.Add("All Months");
            for (int i = 1; i <= 12; i++) MonthFilterComboBox.Items.Add(i);
            MonthFilterComboBox.SelectedIndex = 0;
        }

        private void LoadData()
        {
            TopsaleGrid.DataSource = _financeService.GetTopSalesGrid();




            int year = (int)YearFilterComboBox.SelectedItem;
            int month = MonthFilterComboBox.SelectedIndex;

            DataTable stats = _financeService.GetFinancialStatsByCategory(year, month);

            ConfigureChart(FinancialChart_Profit, stats, "CategoryName", "Profit", "Profit (€)");
            ConfigureChart(FinancialChart_Gross, stats, "CategoryName", "Gross", "Gross (€)");

            decimal totalProfit = stats.AsEnumerable().Sum(r => r.Field<decimal>("Profit"));
            decimal totalGross = stats.AsEnumerable().Sum(r => r.Field<decimal>("Gross"));

            ProfitLab.Text = $"{totalProfit:N2} €";
            GrossLab.Text = $"{totalGross:N2} €";
        }

        private void ConfigureChart(Chart chart, DataTable dt, string xField, string yField, string label)
        {
            chart.Series.Clear();
            chart.ChartAreas[0].AxisY.Title = "Euro (€)";

            Series series = new Series(label)
            {
                XValueMember = xField,
                YValueMembers = yField,
                ChartType = SeriesChartType.Column
            };

            chart.DataSource = dt;
            chart.Series.Add(series);
            chart.DataBind();
        }
    }
}