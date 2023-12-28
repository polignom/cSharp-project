using System.Drawing;

namespace Dashboard_test
{
    partial class dashForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashForm));
            this.btn1 = new System.Windows.Forms.Button();
            this.gridTable = new System.Windows.Forms.DataGridView();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_chek_illness = new System.Windows.Forms.Button();
            this.check_procedures = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.check_person = new System.Windows.Forms.Button();
            this.check_new = new System.Windows.Forms.Button();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.dataTable_pickDate = new System.Windows.Forms.DataGridView();
            this.timePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_showFreePlaces = new System.Windows.Forms.Button();
            this.checkMale = new System.Windows.Forms.CheckBox();
            this.checkFemale = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_pickDate)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn1.AutoSize = true;
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(531, 207);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 3, 27, 3);
            this.btn1.Name = "btn1";
            this.btn1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn1.Size = new System.Drawing.Size(173, 66);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Врачи \r\nотделений";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // gridTable
            // 
            this.gridTable.AllowUserToOrderColumns = true;
            this.gridTable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gridTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridTable.BackgroundColor = System.Drawing.Color.MistyRose;
            this.gridTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTable.GridColor = System.Drawing.Color.Salmon;
            this.gridTable.Location = new System.Drawing.Point(3, 49);
            this.gridTable.Name = "gridTable";
            this.gridTable.RowHeadersWidth = 62;
            this.gridTable.RowTemplate.Height = 28;
            this.gridTable.Size = new System.Drawing.Size(525, 224);
            this.gridTable.TabIndex = 1;
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn2.BackColor = System.Drawing.Color.LightPink;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Location = new System.Drawing.Point(531, 126);
            this.btn2.Name = "btn2";
            this.btn2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn2.Size = new System.Drawing.Size(173, 75);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Информация о штате врачей";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn3.AutoSize = true;
            this.btn3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.Location = new System.Drawing.Point(534, 49);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 3, 27, 3);
            this.btn3.Name = "btn3";
            this.btn3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn3.Size = new System.Drawing.Size(168, 71);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "Специализации";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chart1.BackColor = System.Drawing.Color.MistyRose;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent10;
            this.chart1.BorderlineColor = System.Drawing.Color.Maroon;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chart1.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea5.BackColor = System.Drawing.Color.LavenderBlush;
            chartArea5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea5.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            chartArea5.BorderWidth = 0;
            chartArea5.CursorX.SelectionColor = System.Drawing.Color.Peru;
            chartArea5.CursorY.SelectionColor = System.Drawing.Color.Orange;
            chartArea5.Name = "ChartArea1";
            chartArea5.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Cross;
            legend5.BorderWidth = 3;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend5.IsTextAutoFit = false;
            legend5.ItemColumnSpacing = 20;
            legend5.MaximumAutoSize = 100F;
            legend5.Name = "Legend1";
            legend5.TitleFont = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend5.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(801, 84);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series5.ChartArea = "ChartArea1";
            series5.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(572, 592);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "Диаграмма";
            // 
            // btn_chek_illness
            // 
            this.btn_chek_illness.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_chek_illness.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_chek_illness.BackColor = System.Drawing.Color.LightCoral;
            this.btn_chek_illness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_chek_illness.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_chek_illness.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_chek_illness.Location = new System.Drawing.Point(1089, 688);
            this.btn_chek_illness.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.btn_chek_illness.Name = "btn_chek_illness";
            this.btn_chek_illness.Size = new System.Drawing.Size(164, 69);
            this.btn_chek_illness.TabIndex = 6;
            this.btn_chek_illness.Text = "Статистика заболеваний";
            this.btn_chek_illness.UseVisualStyleBackColor = false;
            this.btn_chek_illness.Click += new System.EventHandler(this.btn_chek_illness_Click);
            // 
            // check_procedures
            // 
            this.check_procedures.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.check_procedures.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.check_procedures.BackColor = System.Drawing.Color.LightCoral;
            this.check_procedures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.check_procedures.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.check_procedures.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_procedures.Location = new System.Drawing.Point(801, 688);
            this.check_procedures.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.check_procedures.Name = "check_procedures";
            this.check_procedures.Size = new System.Drawing.Size(112, 69);
            this.check_procedures.TabIndex = 7;
            this.check_procedures.Text = "Статистика процедур";
            this.check_procedures.UseVisualStyleBackColor = false;
            this.check_procedures.Click += new System.EventHandler(this.check_procedures_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1404, 60);
            this.label1.TabIndex = 8;
            this.label1.Text = "D a s h b o a r d    \" Б о л ь н и ц а \"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // check_person
            // 
            this.check_person.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.check_person.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.check_person.BackColor = System.Drawing.Color.MistyRose;
            this.check_person.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.check_person.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_person.Location = new System.Drawing.Point(1259, 688);
            this.check_person.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.check_person.Name = "check_person";
            this.check_person.Size = new System.Drawing.Size(114, 69);
            this.check_person.TabIndex = 9;
            this.check_person.Text = "Статистика пациентов";
            this.check_person.UseVisualStyleBackColor = false;
            this.check_person.Click += new System.EventHandler(this.check_person_Click);
            // 
            // check_new
            // 
            this.check_new.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.check_new.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.check_new.BackColor = System.Drawing.Color.MistyRose;
            this.check_new.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.check_new.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_new.Location = new System.Drawing.Point(919, 688);
            this.check_new.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.check_new.Name = "check_new";
            this.check_new.Size = new System.Drawing.Size(160, 69);
            this.check_new.TabIndex = 10;
            this.check_new.Text = "Статистика \r\nгоспитализаций";
            this.check_new.UseVisualStyleBackColor = false;
            this.check_new.Click += new System.EventHandler(this.check_new_Click);
            // 
            // timePicker
            // 
            this.timePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timePicker.CalendarForeColor = System.Drawing.Color.IndianRed;
            this.timePicker.CalendarMonthBackground = System.Drawing.Color.SeaShell;
            this.timePicker.CalendarTitleBackColor = System.Drawing.Color.RosyBrown;
            this.timePicker.CalendarTitleForeColor = System.Drawing.Color.Brown;
            this.timePicker.CalendarTrailingForeColor = System.Drawing.Color.Brown;
            this.timePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.timePicker.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timePicker.Location = new System.Drawing.Point(327, 97);
            this.timePicker.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.timePicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(301, 34);
            this.timePicker.TabIndex = 11;
            this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged);
            // 
            // dataTable_pickDate
            // 
            this.dataTable_pickDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataTable_pickDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTable_pickDate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataTable_pickDate.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataTable_pickDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataTable_pickDate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable_pickDate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataTable_pickDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable_pickDate.Location = new System.Drawing.Point(71, 275);
            this.dataTable_pickDate.Name = "dataTable_pickDate";
            this.dataTable_pickDate.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataTable_pickDate.RowHeadersWidth = 50;
            this.dataTable_pickDate.RowTemplate.Height = 28;
            this.dataTable_pickDate.Size = new System.Drawing.Size(557, 171);
            this.dataTable_pickDate.TabIndex = 12;
            // 
            // timePicker2
            // 
            this.timePicker2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timePicker2.CalendarFont = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timePicker2.CalendarForeColor = System.Drawing.Color.IndianRed;
            this.timePicker2.CalendarMonthBackground = System.Drawing.Color.SeaShell;
            this.timePicker2.CalendarTitleBackColor = System.Drawing.Color.RosyBrown;
            this.timePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.timePicker2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timePicker2.Location = new System.Drawing.Point(327, 158);
            this.timePicker2.Name = "timePicker2";
            this.timePicker2.Size = new System.Drawing.Size(301, 34);
            this.timePicker2.TabIndex = 13;
            this.timePicker2.ValueChanged += new System.EventHandler(this.timePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(66, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Н а ч а л о   п е р и о д а:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(72, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "К о н е ц   п е р и о д а:\r\n";
            // 
            // btn_showFreePlaces
            // 
            this.btn_showFreePlaces.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_showFreePlaces.BackColor = System.Drawing.Color.LightPink;
            this.btn_showFreePlaces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_showFreePlaces.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_showFreePlaces.Location = new System.Drawing.Point(70, 451);
            this.btn_showFreePlaces.Name = "btn_showFreePlaces";
            this.btn_showFreePlaces.Size = new System.Drawing.Size(557, 44);
            this.btn_showFreePlaces.TabIndex = 16;
            this.btn_showFreePlaces.Text = "Проверить места";
            this.btn_showFreePlaces.UseVisualStyleBackColor = false;
            this.btn_showFreePlaces.Click += new System.EventHandler(this.btn_showFreePlaces_Click);
            // 
            // checkMale
            // 
            this.checkMale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkMale.BackColor = System.Drawing.Color.MistyRose;
            this.checkMale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkMale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkMale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkMale.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkMale.Location = new System.Drawing.Point(129, 217);
            this.checkMale.Name = "checkMale";
            this.checkMale.Size = new System.Drawing.Size(156, 32);
            this.checkMale.TabIndex = 17;
            this.checkMale.Text = "мужской пол";
            this.checkMale.UseVisualStyleBackColor = false;
            this.checkMale.CheckedChanged += new System.EventHandler(this.checkMale_CheckedChanged);
            // 
            // checkFemale
            // 
            this.checkFemale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkFemale.BackColor = System.Drawing.Color.MistyRose;
            this.checkFemale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkFemale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkFemale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkFemale.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkFemale.Location = new System.Drawing.Point(374, 217);
            this.checkFemale.Name = "checkFemale";
            this.checkFemale.Size = new System.Drawing.Size(154, 32);
            this.checkFemale.TabIndex = 18;
            this.checkFemale.Text = "женский пол";
            this.checkFemale.UseVisualStyleBackColor = false;
            this.checkFemale.CheckedChanged += new System.EventHandler(this.checkFemale_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(667, 75);
            this.label4.TabIndex = 19;
            this.label4.Text = "П р о в е р к а   с в о б о д н ы х  \r\n м е с т   в   п а л а т а х";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.gridTable);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Location = new System.Drawing.Point(9, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 291);
            this.panel1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(723, 34);
            this.label5.TabIndex = 5;
            this.label5.Text = "И н ф о р м а ц и я   о   в р а ч а х";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.dataTable_pickDate);
            this.panel2.Controls.Add(this.checkFemale);
            this.panel2.Controls.Add(this.checkMale);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.timePicker2);
            this.panel2.Controls.Add(this.btn_showFreePlaces);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.timePicker);
            this.panel2.Location = new System.Drawing.Point(9, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 500);
            this.panel2.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(988, 763);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 156);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(570, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 92);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1298, 863);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 44);
            this.button1.TabIndex = 23;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1414, 909);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.check_new);
            this.Controls.Add(this.check_person);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_procedures);
            this.Controls.Add(this.btn_chek_illness);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1480, 1000);
            this.Name = "dashForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_pickDate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.DataGridView gridTable;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_chek_illness;
        private System.Windows.Forms.Button check_procedures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button check_person;
        private System.Windows.Forms.Button check_new;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DataGridView dataTable_pickDate;
        private System.Windows.Forms.DateTimePicker timePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_showFreePlaces;
        private System.Windows.Forms.CheckBox checkMale;
        private System.Windows.Forms.CheckBox checkFemale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}

