using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Xml.Linq;

namespace Dashboard_test
{
    public partial class dashForm : Form
    {
        public dashForm()
        {
            InitializeComponent();
        }
        string vStrConnection = "Server=localhost;  port=5432; user id=postgres;password=55555; database=hospitalDataBase;";
        NpgsqlConnection vCon;  
        NpgsqlCommand vCmd;  

 
        private void connection()
        {
            vCon = new NpgsqlConnection();
            vCon.ConnectionString = vStrConnection;
            if (vCon.State == ConnectionState.Closed) { vCon.Open(); } 
        }
     
        public DataTable getdata(string sql) 
        {
            DataTable dt = new DataTable(); 
            connection();
            vCmd = new NpgsqlCommand(); 
            vCmd.Connection = vCon;
            vCmd.CommandText = sql; 
            NpgsqlDataReader dr = vCmd.ExecuteReader(); 
            dt.Load(dr);

            return dt;
        }

        private void dashForm_Load(object sender, EventArgs e)
        {
            connection(); 
            pictureBox1.BackColor= Color.Transparent;  
            pictureBox2.BackColor = Color.Transparent;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DataTable getTable = new DataTable(); 

        
            getTable = getdata(" SELECT \r\n       \"отделение\".\"название_отделения\" AS \"в отделении\",\r\n    " +
                               "COUNT(*) AS \"работет врачей:\"\r\n   FROM  \"hospitalDB\".\"врач\"\r\n   " +
                               "JOIN  \"hospitalDB\".\"отделение\" ON врач.отделение_id = отделение.id_отделение\r\n   " +
                               "GROUP BY отделение.название_отделения;");
            gridTable.DataSource = getTable;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataTable getTable = new DataTable();
            //запрос на выборку по врачам 
            getTable = getdata("SELECT\r\n ROUND(AVG(EXTRACT(YEAR FROM CURRENT_DATE) - EXTRACT(YEAR FROM \"дата_рождения\")))\r\n AS \"Средний возраст врачa\",\r\n  COUNT(\"id_врач\") AS \"Всего врачей в штате\",\r\n ROUND(AVG(\"стаж\")) AS \"Средний стаж врача\"\r\n  FROM \"hospitalDB\".\"врач\";");
            gridTable.DataSource = getTable;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DataTable getTable = new DataTable();
            //запрос на выборку по специальностям 
            getTable = getdata(" SELECT \r\n       специальности.название_специальности AS \"по специальности\",\r\n       COUNT(*) AS \"работает врачей:\"\r\n   FROM \"hospitalDB\".\"врач\"\r\n   JOIN  \"hospitalDB\".\"специальности\" ON врач.специальности_id = специальности.id_специальности\r\n   GROUP BY специальности.название_специальности\r\n   ORDER BY   COUNT(*) DESC;");
            gridTable.DataSource = getTable;
        }


        //частота заболеваний
        Series series; 
        private void btn_chek_illness_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();   
            chart1.Titles.Clear();    
            chart1.Palette = ChartColorPalette.SemiTransparent; 
            DataTable getTable1 = new DataTable();
            getTable1 = getdata("SELECT \"диагнозыМКБ\".\"расшифровка\" AS \"заболевание\",\r\nCOUNT(*) AS \"частота\"\r\nFROM \"hospitalDB\".\"медкарта\"\r\nJOIN \"hospitalDB\".\"диагнозыМКБ\" ON \"медкарта\".\"диагноз_id\" = \"диагнозыМКБ\".\"id_диагнозыМКБ\"\r\nGROUP BY \"диагнозыМКБ\".\"расшифровка\";\r\n");
            chart1.ChartAreas[0].AxisX.Interval = 1;
       
            series = new Series { 
            
            Name = "Частота заболеваний в больнице", 
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Column  
        
            };

            foreach (DataRow row in getTable1.Rows)          
            {
                series.Points.AddXY(row["заболевание"].ToString(), row["частота"]);
            }
            chart1.Series.Add(series); 
            chart1.Titles.Add("Частота заболеваний").Font = new Font("Arial", 14, FontStyle.Bold);
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 10);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 10);



        }

        // частота проводимых процедур
        private void check_procedures_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();  
            chart1.Titles.Clear();
            chart1.Palette = ChartColorPalette.Berry;  
            DataTable getTable1 = new DataTable();
            //запрос на выборку процедур
            getTable1 = getdata("SELECT\r\n    \"процедуры\".\"название_процедуры\",\r\n    COUNT(\"медкарта\".\"процедуры_id\") AS \"частота\"\r\nFROM\r\n    \"hospitalDB\".\"процедуры\"\r\nLEFT JOIN\r\n    \"hospitalDB\".\"медкарта\" ON \"процедуры\".\"id_процедуры\" = \"медкарта\".\"процедуры_id\"\r\nGROUP BY\r\n    \"процедуры\".\"название_процедуры\"\r\nORDER BY\r\n    \"частота\" DESC;");
            chart1.ChartAreas[0].AxisX.Interval = 1;

             series = new Series
            {
            Name = "Частота проводимых процедур в больнице",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Doughnut
            };

            foreach (DataRow row in getTable1.Rows) 
            {
              
                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueXY(row["название_процедуры"].ToString(), row["частота"]);
                dataPoint.Label = "#PERCENT{P0}";
                dataPoint.LegendText = row["название_процедуры"].ToString(); 
                series.Points.Add(dataPoint);
               //  series.Points.AddXY(row["название_процедуры"].ToString(), row["частота"]);

            }
            chart1.Series.Add(series); 
            chart1.Titles.Add("Частота проводимых процедур").Font = new Font("Arial", 14, FontStyle.Bold);
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 5);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 5);
            chart1.AntiAliasing = AntiAliasingStyles.All;



        }


        //статистика госпитализаций в диаграмме 
        private void check_new_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Palette = ChartColorPalette.SemiTransparent;
            DataTable getTable1 = new DataTable();
            getTable1 = getdata("SELECT\r\n    TO_CHAR(\"дата_госпитализации\", 'Month') AS \"месяц\",\r\n    COUNT(*) AS \"количество госпитализаций\"\r\nFROM\r\n    \"hospitalDB\".\"медкарта\"\r\nGROUP BY\r\n    TO_CHAR(\"дата_госпитализации\", 'Month')\r\nORDER BY\r\n    MIN(\"дата_госпитализации\");");
            chart1.ChartAreas[0].AxisX.Interval = 1;

            series = new Series
            {
                Name = "Госпитализации по месяцам",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie 
            };

            foreach (DataRow row in getTable1.Rows) 
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueXY(row["месяц"].ToString(), row["количество госпитализаций"]);
                dataPoint.Label = "кол-во:" + "#VAL{N0}"; 
                dataPoint.LegendText = row["месяц"].ToString(); 
                series.Points.Add(dataPoint);

            }
            chart1.Series.Add(series); 
            chart1.Titles.Add("Госпитализации по месяцам").Font = new Font("Arial", 14, FontStyle.Bold);
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 5);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 5);
            chart1.AntiAliasing = AntiAliasingStyles.All;

        }

        //стистика пациентов
        private void check_person_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Palette = ChartColorPalette.EarthTones;
            DataTable getTable1 = new DataTable();
            getTable1 = getdata("SELECT\r\n    \"hospitalDB\".\"пол\".\"пол\" AS \"пол\",\r\n    COUNT(\"hospitalDB\".\"медкарта\".\"пациент_id\") AS \"количество_заболевших\"\r\nFROM\r\n    \"hospitalDB\".\"медкарта\"\r\nJOIN\r\n    \"hospitalDB\".\"пациент\" ON \"hospitalDB\".\"медкарта\".\"пациент_id\" = \"hospitalDB\".\"пациент\".\"id_пациент\"\r\nJOIN\r\n    \"hospitalDB\".\"пол\" ON \"hospitalDB\".\"пациент\".\"пол_id\" = \"hospitalDB\".\"пол\".\"id_пол\"\r\nGROUP BY\r\n    \"hospitalDB\".\"пол\".\"пол\";");
            chart1.ChartAreas[0].AxisX.Interval = 1;

            series = new Series
            {
                Name = "Кто чаще болеет",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Bar
            };

            foreach (DataRow row in getTable1.Rows)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueXY(row["пол"].ToString(), row["количество_заболевших"]);
                dataPoint.Label = "кол-во за весь период наблюдения:" + "#VAL{N0}." + "\r\n  В % от общего числа - " + "#PERCENT{P0}"; 
                dataPoint.LegendText = row["пол"].ToString(); 
                series.Points.Add(dataPoint);
            }
            chart1.Series.Add(series); 
            chart1.Titles.Add("Кто чаще болеет - мужчины или женщины?").Font = new Font("Arial", 14, FontStyle.Bold);
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 5);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 5);
            chart1.AntiAliasing = AntiAliasingStyles.All;

        }


        string selectedDate = "2023-12-12"; 
        string selectedDate2 = "2023-12-12";
        public void timePicker_ValueChanged(object sender, EventArgs e)
        {
        timePicker.DataBindings.Clear();    
            selectedDate = timePicker.Value.ToString("yyyy-MM-dd"); 
        }

        public void timePicker2_ValueChanged(object sender, EventArgs e)
        {
            timePicker2.DataBindings.Clear();
            selectedDate2 = timePicker2.Value.ToString("yyyy-MM-dd"); 
        }
        int MaleOrFemale = 0;
        private void checkMale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMale.Checked)
            {
                checkFemale.Checked = false;
                MaleOrFemale = 1;
            }

        }

        private void checkFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFemale.Checked)
            {
                checkMale.Checked = false;
                MaleOrFemale = 2;
            }

        }
       
        private void btn_showFreePlaces_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"start:{selectedDate} +  end-  {selectedDate2} +  пол+{MaleOrFemale}"); 
            
            DataTable getTable3 = new DataTable();  
            if (MaleOrFemale != 0 && selectedDate != null && selectedDate2 != null)
            {
                getTable3 = getdata($"SELECT\r\n    \"палата\".\"id_палата\" AS \"номер палаты\",\r\n    \"палата\".\"всего_мест\",\r\n    \"пол\".\"пол\" AS \"пол\",\r\n    COUNT(\"медкарта\".\"id_медкарта\") AS \"занято\",\r\n    \"палата\".\"всего_мест\" - COUNT(\"медкарта\".\"id_медкарта\") AS \"свободно\"\r\nFROM\r\n    \"hospitalDB\".\"палата\"\r\nLEFT JOIN\r\n    \"hospitalDB\".\"медкарта\" ON \"палата\".\"id_палата\" = \"hospitalDB\".\"медкарта\".\"палата_id\"\r\n        AND \"медкарта\".\"дата_госпитализации\" >= '{selectedDate}'\r\n        AND (\"медкарта\".\"дата_выписки\" IS NULL OR \"медкарта\".\"дата_выписки\" < '{selectedDate2}')\r\nJOIN\r\n    \"hospitalDB\".\"пол\" ON \"пол\".\"id_пол\" = \"палата\".\"пол_id\"\r\nWHERE\r\n    \"палата\".\"пол_id\" = {MaleOrFemale}\r\nGROUP BY\r\n    \"палата\".\"id_палата\", \"палата\".\"всего_мест\", \"палата\".\"пол_id\", \"пол\".\"пол\";\r\n");
                dataTable_pickDate.DataSource = getTable3; 
            }
            else MessageBox.Show("Пожалуйста, выберите дату начала периода, дату конца периода и пол. Этот выбор обязателен!","Внимание!",MessageBoxButtons.OKCancel);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
