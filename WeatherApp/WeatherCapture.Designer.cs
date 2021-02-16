namespace WeatherApp
{
    partial class WeatherCapture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherCapture));
            this.numUpDownHum = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstCities = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.txtPrec = new System.Windows.Forms.TextBox();
            this.lblPrec = new System.Windows.Forms.Label();
            this.lblHeading2 = new System.Windows.Forms.Label();
            this.numUpDownWind = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownWind)).BeginInit();
            this.SuspendLayout();
            // 
            // numUpDownHum
            // 
            this.numUpDownHum.Location = new System.Drawing.Point(135, 363);
            this.numUpDownHum.Name = "numUpDownHum";
            this.numUpDownHum.Size = new System.Drawing.Size(203, 20);
            this.numUpDownHum.TabIndex = 73;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(545, 463);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 33);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(645, 463);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 33);
            this.btnClear.TabIndex = 70;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstCities
            // 
            this.lstCities.FormattingEnabled = true;
            this.lstCities.Location = new System.Drawing.Point(521, 210);
            this.lstCities.Name = "lstCities";
            this.lstCities.Size = new System.Drawing.Size(243, 238);
            this.lstCities.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(554, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 24);
            this.label4.TabIndex = 68;
            this.label4.Text = "Captured Weather";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.BackColor = System.Drawing.Color.White;
            this.lblMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTemp.Location = new System.Drawing.Point(36, 291);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(80, 16);
            this.lblMaxTemp.TabIndex = 67;
            this.lblMaxTemp.Text = "Max Temp";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.BackColor = System.Drawing.Color.White;
            this.lblMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTemp.Location = new System.Drawing.Point(36, 257);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(80, 16);
            this.lblMinTemp.TabIndex = 66;
            this.lblMinTemp.Text = "Miin Temp";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(135, 287);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(203, 20);
            this.txtMax.TabIndex = 65;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(135, 253);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(203, 20);
            this.txtMin.TabIndex = 64;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.White;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(36, 178);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 16);
            this.lblCity.TabIndex = 63;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(135, 174);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(203, 20);
            this.txtCity.TabIndex = 62;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(36, 217);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 16);
            this.lblDate.TabIndex = 61;
            this.lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(135, 217);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(203, 20);
            this.dtpDate.TabIndex = 60;
            this.dtpDate.Value = new System.DateTime(2020, 5, 19, 0, 0, 0, 0);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(248, 463);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 33);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(135, 463);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(94, 33);
            this.btnView.TabIndex = 58;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.BackColor = System.Drawing.Color.White;
            this.lblWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWind.Location = new System.Drawing.Point(36, 408);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(93, 16);
            this.lblWind.TabIndex = 57;
            this.lblWind.Text = "Wind Speed";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.BackColor = System.Drawing.Color.White;
            this.lblHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.Location = new System.Drawing.Point(36, 367);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(68, 16);
            this.lblHumidity.TabIndex = 54;
            this.lblHumidity.Text = "Humidity";
            // 
            // txtPrec
            // 
            this.txtPrec.Location = new System.Drawing.Point(135, 320);
            this.txtPrec.Name = "txtPrec";
            this.txtPrec.Size = new System.Drawing.Size(203, 20);
            this.txtPrec.TabIndex = 53;
            // 
            // lblPrec
            // 
            this.lblPrec.AutoSize = true;
            this.lblPrec.BackColor = System.Drawing.Color.White;
            this.lblPrec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrec.Location = new System.Drawing.Point(36, 324);
            this.lblPrec.Name = "lblPrec";
            this.lblPrec.Size = new System.Drawing.Size(95, 16);
            this.lblPrec.TabIndex = 52;
            this.lblPrec.Text = "Precipitation";
            // 
            // lblHeading2
            // 
            this.lblHeading2.AutoSize = true;
            this.lblHeading2.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading2.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading2.Location = new System.Drawing.Point(245, 59);
            this.lblHeading2.Name = "lblHeading2";
            this.lblHeading2.Size = new System.Drawing.Size(278, 30);
            this.lblHeading2.TabIndex = 74;
            this.lblHeading2.Text = "Weather Capture";
            // 
            // numUpDownWind
            // 
            this.numUpDownWind.Location = new System.Drawing.Point(135, 404);
            this.numUpDownWind.Name = "numUpDownWind";
            this.numUpDownWind.Size = new System.Drawing.Size(203, 20);
            this.numUpDownWind.TabIndex = 75;
            // 
            // WeatherCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.numUpDownWind);
            this.Controls.Add(this.lblHeading2);
            this.Controls.Add(this.numUpDownHum);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstCities);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMaxTemp);
            this.Controls.Add(this.lblMinTemp);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.txtPrec);
            this.Controls.Add(this.lblPrec);
            this.DoubleBuffered = true;
            this.Name = "WeatherCapture";
            this.Text = "WeatherCapture";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownWind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUpDownHum;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstCities;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.TextBox txtPrec;
        private System.Windows.Forms.Label lblPrec;
        private System.Windows.Forms.Label lblHeading2;
        private System.Windows.Forms.NumericUpDown numUpDownWind;
    }
}

