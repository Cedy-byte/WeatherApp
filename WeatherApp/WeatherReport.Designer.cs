namespace WeatherApp
{
    partial class WeatherReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherReport));
            this.lblHeading = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxTamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.radOneCity = new System.Windows.Forms.RadioButton();
            this.radMultipleCities = new System.Windows.Forms.RadioButton();
            this.cmbCity2 = new System.Windows.Forms.ComboBox();
            this.lblMultipleCities = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOneCity = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHighMin = new System.Windows.Forms.Label();
            this.lblHighMinTemp = new System.Windows.Forms.Label();
            this.lblHighMax = new System.Windows.Forms.Label();
            this.lblHighMaxTemp = new System.Windows.Forms.Label();
            this.lblHighPrec = new System.Windows.Forms.Label();
            this.lblHighPrecipitation = new System.Windows.Forms.Label();
            this.lblHighHum = new System.Windows.Forms.Label();
            this.lblHighHumidity = new System.Windows.Forms.Label();
            this.lblHighWindSpeed = new System.Windows.Forms.Label();
            this.lblHighWind = new System.Windows.Forms.Label();
            this.lblWindLow = new System.Windows.Forms.Label();
            this.lblLowWind = new System.Windows.Forms.Label();
            this.lblHumLow = new System.Windows.Forms.Label();
            this.lblLowHum = new System.Windows.Forms.Label();
            this.lblPrecLow = new System.Windows.Forms.Label();
            this.lblLowPrec = new System.Windows.Forms.Label();
            this.lblMaxTempLow = new System.Windows.Forms.Label();
            this.lblLowMaxTemp = new System.Windows.Forms.Label();
            this.lblMinTempLow = new System.Windows.Forms.Label();
            this.lblLowMinTemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(339, 59);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(259, 30);
            this.lblHeading.TabIndex = 66;
            this.lblHeading.Text = "Weather Report";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.city,
            this.date,
            this.minTemp,
            this.maxTamp,
            this.prec,
            this.hum,
            this.wind});
            this.dataGridView1.Location = new System.Drawing.Point(51, 285);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(827, 231);
            this.dataGridView1.TabIndex = 65;
            // 
            // city
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.DefaultCellStyle = dataGridViewCellStyle2;
            this.city.HeaderText = "City";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // date
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.DefaultCellStyle = dataGridViewCellStyle3;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // minTemp
            // 
            this.minTemp.HeaderText = "Min Temp (°C)";
            this.minTemp.Name = "minTemp";
            this.minTemp.ReadOnly = true;
            // 
            // maxTamp
            // 
            this.maxTamp.HeaderText = "Max Temp (°C)";
            this.maxTamp.Name = "maxTamp";
            this.maxTamp.ReadOnly = true;
            // 
            // prec
            // 
            this.prec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prec.HeaderText = "Precipitation (%)";
            this.prec.Name = "prec";
            this.prec.ReadOnly = true;
            // 
            // hum
            // 
            this.hum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hum.HeaderText = "Humidity (%)";
            this.hum.Name = "hum";
            this.hum.ReadOnly = true;
            // 
            // wind
            // 
            this.wind.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wind.HeaderText = "Wind Speed (Km/h)";
            this.wind.Name = "wind";
            this.wind.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(173, 542);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 30);
            this.btnAdd.TabIndex = 64;
            this.btnAdd.Text = "Add Weather";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // radOneCity
            // 
            this.radOneCity.AutoSize = true;
            this.radOneCity.BackColor = System.Drawing.Color.Transparent;
            this.radOneCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOneCity.Location = new System.Drawing.Point(252, 217);
            this.radOneCity.Name = "radOneCity";
            this.radOneCity.Size = new System.Drawing.Size(110, 19);
            this.radOneCity.TabIndex = 63;
            this.radOneCity.TabStop = true;
            this.radOneCity.Text = "One City Report";
            this.radOneCity.UseVisualStyleBackColor = false;
            this.radOneCity.CheckedChanged += new System.EventHandler(this.radOne_CheckedChanged);
            // 
            // radMultipleCities
            // 
            this.radMultipleCities.AutoSize = true;
            this.radMultipleCities.BackColor = System.Drawing.Color.Transparent;
            this.radMultipleCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMultipleCities.Location = new System.Drawing.Point(252, 251);
            this.radMultipleCities.Name = "radMultipleCities";
            this.radMultipleCities.Size = new System.Drawing.Size(131, 19);
            this.radMultipleCities.TabIndex = 62;
            this.radMultipleCities.TabStop = true;
            this.radMultipleCities.Text = "Multiple City Report";
            this.radMultipleCities.UseVisualStyleBackColor = false;
            this.radMultipleCities.CheckedChanged += new System.EventHandler(this.radMultiple_CheckedChanged);
            // 
            // cmbCity2
            // 
            this.cmbCity2.FormattingEnabled = true;
            this.cmbCity2.Location = new System.Drawing.Point(522, 249);
            this.cmbCity2.Name = "cmbCity2";
            this.cmbCity2.Size = new System.Drawing.Size(121, 21);
            this.cmbCity2.TabIndex = 61;
            this.cmbCity2.Visible = false;
            // 
            // lblMultipleCities
            // 
            this.lblMultipleCities.AutoSize = true;
            this.lblMultipleCities.BackColor = System.Drawing.Color.Transparent;
            this.lblMultipleCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultipleCities.Location = new System.Drawing.Point(472, 255);
            this.lblMultipleCities.Name = "lblMultipleCities";
            this.lblMultipleCities.Size = new System.Drawing.Size(33, 15);
            this.lblMultipleCities.TabIndex = 60;
            this.lblMultipleCities.Text = "City2";
            this.lblMultipleCities.Visible = false;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(473, 542);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(129, 30);
            this.btnDisplay.TabIndex = 59;
            this.btnDisplay.Text = "Display Forcast";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(321, 542);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 30);
            this.btnReset.TabIndex = 58;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(541, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 57;
            this.label6.Text = "To Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(318, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 56;
            this.label5.Text = "From Date";
            // 
            // lblOneCity
            // 
            this.lblOneCity.AutoSize = true;
            this.lblOneCity.BackColor = System.Drawing.Color.Transparent;
            this.lblOneCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneCity.Location = new System.Drawing.Point(472, 221);
            this.lblOneCity.Name = "lblOneCity";
            this.lblOneCity.Size = new System.Drawing.Size(26, 15);
            this.lblOneCity.TabIndex = 55;
            this.lblOneCity.Text = "City";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(475, 176);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 54;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(522, 213);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 21);
            this.cmbCity.TabIndex = 53;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(252, 176);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 52;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(625, 542);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 30);
            this.btnExit.TabIndex = 67;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHighMin
            // 
            this.lblHighMin.AutoSize = true;
            this.lblHighMin.Location = new System.Drawing.Point(24, 39);
            this.lblHighMin.Name = "lblHighMin";
            this.lblHighMin.Size = new System.Drawing.Size(96, 13);
            this.lblHighMin.TabIndex = 70;
            this.lblHighMin.Text = "Highest MinTemp :";
            // 
            // lblHighMinTemp
            // 
            this.lblHighMinTemp.AutoSize = true;
            this.lblHighMinTemp.BackColor = System.Drawing.Color.Red;
            this.lblHighMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighMinTemp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHighMinTemp.Location = new System.Drawing.Point(138, 39);
            this.lblHighMinTemp.Name = "lblHighMinTemp";
            this.lblHighMinTemp.Size = new System.Drawing.Size(14, 13);
            this.lblHighMinTemp.TabIndex = 71;
            this.lblHighMinTemp.Text = "0";
            this.lblHighMinTemp.Visible = false;
            // 
            // lblHighMax
            // 
            this.lblHighMax.AutoSize = true;
            this.lblHighMax.Location = new System.Drawing.Point(24, 73);
            this.lblHighMax.Name = "lblHighMax";
            this.lblHighMax.Size = new System.Drawing.Size(99, 13);
            this.lblHighMax.TabIndex = 72;
            this.lblHighMax.Text = "Highest MaxTemp :";
            // 
            // lblHighMaxTemp
            // 
            this.lblHighMaxTemp.AutoSize = true;
            this.lblHighMaxTemp.BackColor = System.Drawing.Color.Red;
            this.lblHighMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighMaxTemp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHighMaxTemp.Location = new System.Drawing.Point(138, 76);
            this.lblHighMaxTemp.Name = "lblHighMaxTemp";
            this.lblHighMaxTemp.Size = new System.Drawing.Size(14, 13);
            this.lblHighMaxTemp.TabIndex = 73;
            this.lblHighMaxTemp.Text = "0";
            this.lblHighMaxTemp.Visible = false;
            // 
            // lblHighPrec
            // 
            this.lblHighPrec.AutoSize = true;
            this.lblHighPrec.Location = new System.Drawing.Point(24, 112);
            this.lblHighPrec.Name = "lblHighPrec";
            this.lblHighPrec.Size = new System.Drawing.Size(74, 13);
            this.lblHighPrec.TabIndex = 74;
            this.lblHighPrec.Text = "Highest Prec :";
            // 
            // lblHighPrecipitation
            // 
            this.lblHighPrecipitation.AutoSize = true;
            this.lblHighPrecipitation.BackColor = System.Drawing.Color.Red;
            this.lblHighPrecipitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighPrecipitation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHighPrecipitation.Location = new System.Drawing.Point(138, 112);
            this.lblHighPrecipitation.Name = "lblHighPrecipitation";
            this.lblHighPrecipitation.Size = new System.Drawing.Size(14, 13);
            this.lblHighPrecipitation.TabIndex = 75;
            this.lblHighPrecipitation.Text = "0";
            this.lblHighPrecipitation.Visible = false;
            // 
            // lblHighHum
            // 
            this.lblHighHum.AutoSize = true;
            this.lblHighHum.Location = new System.Drawing.Point(24, 146);
            this.lblHighHum.Name = "lblHighHum";
            this.lblHighHum.Size = new System.Drawing.Size(74, 13);
            this.lblHighHum.TabIndex = 76;
            this.lblHighHum.Text = "Highest Hum :";
            // 
            // lblHighHumidity
            // 
            this.lblHighHumidity.AutoSize = true;
            this.lblHighHumidity.BackColor = System.Drawing.Color.Red;
            this.lblHighHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighHumidity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHighHumidity.Location = new System.Drawing.Point(138, 146);
            this.lblHighHumidity.Name = "lblHighHumidity";
            this.lblHighHumidity.Size = new System.Drawing.Size(14, 13);
            this.lblHighHumidity.TabIndex = 77;
            this.lblHighHumidity.Text = "0";
            this.lblHighHumidity.Visible = false;
            // 
            // lblHighWindSpeed
            // 
            this.lblHighWindSpeed.AutoSize = true;
            this.lblHighWindSpeed.BackColor = System.Drawing.Color.Red;
            this.lblHighWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighWindSpeed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHighWindSpeed.Location = new System.Drawing.Point(138, 175);
            this.lblHighWindSpeed.Name = "lblHighWindSpeed";
            this.lblHighWindSpeed.Size = new System.Drawing.Size(14, 13);
            this.lblHighWindSpeed.TabIndex = 79;
            this.lblHighWindSpeed.Text = "0";
            this.lblHighWindSpeed.Visible = false;
            // 
            // lblHighWind
            // 
            this.lblHighWind.AutoSize = true;
            this.lblHighWind.Location = new System.Drawing.Point(24, 175);
            this.lblHighWind.Name = "lblHighWind";
            this.lblHighWind.Size = new System.Drawing.Size(77, 13);
            this.lblHighWind.TabIndex = 78;
            this.lblHighWind.Text = "Highest Wind :";
            // 
            // lblWindLow
            // 
            this.lblWindLow.AutoSize = true;
            this.lblWindLow.BackColor = System.Drawing.Color.Green;
            this.lblWindLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindLow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWindLow.Location = new System.Drawing.Point(879, 175);
            this.lblWindLow.Name = "lblWindLow";
            this.lblWindLow.Size = new System.Drawing.Size(14, 13);
            this.lblWindLow.TabIndex = 89;
            this.lblWindLow.Text = "0";
            this.lblWindLow.Visible = false;
            // 
            // lblLowWind
            // 
            this.lblLowWind.AutoSize = true;
            this.lblLowWind.Location = new System.Drawing.Point(765, 175);
            this.lblLowWind.Name = "lblLowWind";
            this.lblLowWind.Size = new System.Drawing.Size(75, 13);
            this.lblLowWind.TabIndex = 88;
            this.lblLowWind.Text = "Lowest Wind :";
            // 
            // lblHumLow
            // 
            this.lblHumLow.AutoSize = true;
            this.lblHumLow.BackColor = System.Drawing.Color.Green;
            this.lblHumLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumLow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHumLow.Location = new System.Drawing.Point(879, 146);
            this.lblHumLow.Name = "lblHumLow";
            this.lblHumLow.Size = new System.Drawing.Size(14, 13);
            this.lblHumLow.TabIndex = 87;
            this.lblHumLow.Text = "0";
            this.lblHumLow.Visible = false;
            // 
            // lblLowHum
            // 
            this.lblLowHum.AutoSize = true;
            this.lblLowHum.Location = new System.Drawing.Point(765, 146);
            this.lblLowHum.Name = "lblLowHum";
            this.lblLowHum.Size = new System.Drawing.Size(72, 13);
            this.lblLowHum.TabIndex = 86;
            this.lblLowHum.Text = "Lowest Hum :";
            // 
            // lblPrecLow
            // 
            this.lblPrecLow.AutoSize = true;
            this.lblPrecLow.BackColor = System.Drawing.Color.Green;
            this.lblPrecLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecLow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrecLow.Location = new System.Drawing.Point(879, 112);
            this.lblPrecLow.Name = "lblPrecLow";
            this.lblPrecLow.Size = new System.Drawing.Size(14, 13);
            this.lblPrecLow.TabIndex = 85;
            this.lblPrecLow.Text = "0";
            this.lblPrecLow.Visible = false;
            // 
            // lblLowPrec
            // 
            this.lblLowPrec.AutoSize = true;
            this.lblLowPrec.Location = new System.Drawing.Point(765, 112);
            this.lblLowPrec.Name = "lblLowPrec";
            this.lblLowPrec.Size = new System.Drawing.Size(72, 13);
            this.lblLowPrec.TabIndex = 84;
            this.lblLowPrec.Text = "Lowest Prec :";
            // 
            // lblMaxTempLow
            // 
            this.lblMaxTempLow.AutoSize = true;
            this.lblMaxTempLow.BackColor = System.Drawing.Color.Green;
            this.lblMaxTempLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTempLow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMaxTempLow.Location = new System.Drawing.Point(879, 76);
            this.lblMaxTempLow.Name = "lblMaxTempLow";
            this.lblMaxTempLow.Size = new System.Drawing.Size(14, 13);
            this.lblMaxTempLow.TabIndex = 83;
            this.lblMaxTempLow.Text = "0";
            this.lblMaxTempLow.Visible = false;
            // 
            // lblLowMaxTemp
            // 
            this.lblLowMaxTemp.AutoSize = true;
            this.lblLowMaxTemp.Location = new System.Drawing.Point(765, 73);
            this.lblLowMaxTemp.Name = "lblLowMaxTemp";
            this.lblLowMaxTemp.Size = new System.Drawing.Size(97, 13);
            this.lblLowMaxTemp.TabIndex = 82;
            this.lblLowMaxTemp.Text = "Lowest MaxTemp :";
            // 
            // lblMinTempLow
            // 
            this.lblMinTempLow.AutoSize = true;
            this.lblMinTempLow.BackColor = System.Drawing.Color.Green;
            this.lblMinTempLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTempLow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMinTempLow.Location = new System.Drawing.Point(879, 39);
            this.lblMinTempLow.Name = "lblMinTempLow";
            this.lblMinTempLow.Size = new System.Drawing.Size(14, 13);
            this.lblMinTempLow.TabIndex = 81;
            this.lblMinTempLow.Text = "0";
            this.lblMinTempLow.Visible = false;
            // 
            // lblLowMinTemp
            // 
            this.lblLowMinTemp.AutoSize = true;
            this.lblLowMinTemp.Location = new System.Drawing.Point(765, 39);
            this.lblLowMinTemp.Name = "lblLowMinTemp";
            this.lblLowMinTemp.Size = new System.Drawing.Size(94, 13);
            this.lblLowMinTemp.TabIndex = 80;
            this.lblLowMinTemp.Text = "Lowest MinTemp :";
            // 
            // WeatherReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 603);
            this.Controls.Add(this.lblWindLow);
            this.Controls.Add(this.lblLowWind);
            this.Controls.Add(this.lblHumLow);
            this.Controls.Add(this.lblLowHum);
            this.Controls.Add(this.lblPrecLow);
            this.Controls.Add(this.lblLowPrec);
            this.Controls.Add(this.lblMaxTempLow);
            this.Controls.Add(this.lblLowMaxTemp);
            this.Controls.Add(this.lblMinTempLow);
            this.Controls.Add(this.lblLowMinTemp);
            this.Controls.Add(this.lblHighWindSpeed);
            this.Controls.Add(this.lblHighWind);
            this.Controls.Add(this.lblHighHumidity);
            this.Controls.Add(this.lblHighHum);
            this.Controls.Add(this.lblHighPrecipitation);
            this.Controls.Add(this.lblHighPrec);
            this.Controls.Add(this.lblHighMaxTemp);
            this.Controls.Add(this.lblHighMax);
            this.Controls.Add(this.lblHighMinTemp);
            this.Controls.Add(this.lblHighMin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.radOneCity);
            this.Controls.Add(this.radMultipleCities);
            this.Controls.Add(this.cmbCity2);
            this.Controls.Add(this.lblMultipleCities);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOneCity);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.dtpFrom);
            this.DoubleBuffered = true;
            this.Name = "WeatherReport";
            this.Text = "WeatherReport";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton radOneCity;
        private System.Windows.Forms.RadioButton radMultipleCities;
        private System.Windows.Forms.ComboBox cmbCity2;
        private System.Windows.Forms.Label lblMultipleCities;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOneCity;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblHighMin;
        private System.Windows.Forms.Label lblHighMinTemp;
        private System.Windows.Forms.Label lblHighMax;
        private System.Windows.Forms.Label lblHighMaxTemp;
        private System.Windows.Forms.Label lblHighPrec;
        private System.Windows.Forms.Label lblHighPrecipitation;
        private System.Windows.Forms.Label lblHighHum;
        private System.Windows.Forms.Label lblHighHumidity;
        private System.Windows.Forms.Label lblHighWindSpeed;
        private System.Windows.Forms.Label lblHighWind;
        private System.Windows.Forms.Label lblWindLow;
        private System.Windows.Forms.Label lblLowWind;
        private System.Windows.Forms.Label lblHumLow;
        private System.Windows.Forms.Label lblLowHum;
        private System.Windows.Forms.Label lblPrecLow;
        private System.Windows.Forms.Label lblLowPrec;
        private System.Windows.Forms.Label lblMaxTempLow;
        private System.Windows.Forms.Label lblLowMaxTemp;
        private System.Windows.Forms.Label lblMinTempLow;
        private System.Windows.Forms.Label lblLowMinTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn minTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxTamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn prec;
        private System.Windows.Forms.DataGridViewTextBoxColumn hum;
        private System.Windows.Forms.DataGridViewTextBoxColumn wind;
    }
}