
namespace weatherApp
{
    partial class Primary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Primary));
            this.primaryHeaderLbl = new System.Windows.Forms.Label();
            this.primaryCityEntry = new System.Windows.Forms.TextBox();
            this.primarySubmitBtn = new System.Windows.Forms.Button();
            this.returnCityNameLbl = new System.Windows.Forms.Label();
            this.returnWeatherLbl = new System.Windows.Forms.Label();
            this.returnTemperatureLbl = new System.Windows.Forms.Label();
            this.returnFeelLikeLbl = new System.Windows.Forms.Label();
            this.returnHighLbl = new System.Windows.Forms.Label();
            this.returnTempLowLbl = new System.Windows.Forms.Label();
            this.returnPressureLbl = new System.Windows.Forms.Label();
            this.returnHumidityLbl = new System.Windows.Forms.Label();
            this.returnWeatherText = new System.Windows.Forms.TextBox();
            this.returnFeelsLikeText = new System.Windows.Forms.TextBox();
            this.returnTemperatureText = new System.Windows.Forms.TextBox();
            this.returnTempHighText = new System.Windows.Forms.TextBox();
            this.returnPressureText = new System.Windows.Forms.TextBox();
            this.returnTempLowText = new System.Windows.Forms.TextBox();
            this.returnHumidityText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // primaryHeaderLbl
            // 
            this.primaryHeaderLbl.AutoSize = true;
            this.primaryHeaderLbl.BackColor = System.Drawing.Color.Transparent;
            this.primaryHeaderLbl.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primaryHeaderLbl.Location = new System.Drawing.Point(147, 28);
            this.primaryHeaderLbl.Name = "primaryHeaderLbl";
            this.primaryHeaderLbl.Size = new System.Drawing.Size(219, 39);
            this.primaryHeaderLbl.TabIndex = 0;
            this.primaryHeaderLbl.Text = "Weather App";
            // 
            // primaryCityEntry
            // 
            this.primaryCityEntry.BackColor = System.Drawing.Color.Black;
            this.primaryCityEntry.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primaryCityEntry.ForeColor = System.Drawing.Color.White;
            this.primaryCityEntry.Location = new System.Drawing.Point(114, 82);
            this.primaryCityEntry.Name = "primaryCityEntry";
            this.primaryCityEntry.Size = new System.Drawing.Size(278, 23);
            this.primaryCityEntry.TabIndex = 1;
            // 
            // primarySubmitBtn
            // 
            this.primarySubmitBtn.BackColor = System.Drawing.Color.Black;
            this.primarySubmitBtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primarySubmitBtn.ForeColor = System.Drawing.Color.Silver;
            this.primarySubmitBtn.Location = new System.Drawing.Point(179, 383);
            this.primarySubmitBtn.Name = "primarySubmitBtn";
            this.primarySubmitBtn.Size = new System.Drawing.Size(151, 45);
            this.primarySubmitBtn.TabIndex = 2;
            this.primarySubmitBtn.Text = "Get Weather";
            this.primarySubmitBtn.UseVisualStyleBackColor = false;
            this.primarySubmitBtn.Click += new System.EventHandler(this.primarySubmitBtn_Click);
            // 
            // returnCityNameLbl
            // 
            this.returnCityNameLbl.AccessibleName = "primaryName";
            this.returnCityNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.returnCityNameLbl.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnCityNameLbl.Location = new System.Drawing.Point(114, 117);
            this.returnCityNameLbl.Name = "returnCityNameLbl";
            this.returnCityNameLbl.Size = new System.Drawing.Size(278, 33);
            this.returnCityNameLbl.TabIndex = 3;
            this.returnCityNameLbl.Text = "Choose a City";
            this.returnCityNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnWeatherLbl
            // 
            this.returnWeatherLbl.AutoSize = true;
            this.returnWeatherLbl.BackColor = System.Drawing.Color.Transparent;
            this.returnWeatherLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnWeatherLbl.ForeColor = System.Drawing.Color.Black;
            this.returnWeatherLbl.Location = new System.Drawing.Point(122, 168);
            this.returnWeatherLbl.Name = "returnWeatherLbl";
            this.returnWeatherLbl.Size = new System.Drawing.Size(75, 19);
            this.returnWeatherLbl.TabIndex = 4;
            this.returnWeatherLbl.Text = "Weather";
            // 
            // returnTemperatureLbl
            // 
            this.returnTemperatureLbl.AutoSize = true;
            this.returnTemperatureLbl.BackColor = System.Drawing.Color.Transparent;
            this.returnTemperatureLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnTemperatureLbl.ForeColor = System.Drawing.Color.Black;
            this.returnTemperatureLbl.Location = new System.Drawing.Point(122, 195);
            this.returnTemperatureLbl.Name = "returnTemperatureLbl";
            this.returnTemperatureLbl.Size = new System.Drawing.Size(112, 19);
            this.returnTemperatureLbl.TabIndex = 4;
            this.returnTemperatureLbl.Text = "Temperature";
            // 
            // returnFeelLikeLbl
            // 
            this.returnFeelLikeLbl.AutoSize = true;
            this.returnFeelLikeLbl.BackColor = System.Drawing.Color.Transparent;
            this.returnFeelLikeLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnFeelLikeLbl.ForeColor = System.Drawing.Color.Black;
            this.returnFeelLikeLbl.Location = new System.Drawing.Point(122, 223);
            this.returnFeelLikeLbl.Name = "returnFeelLikeLbl";
            this.returnFeelLikeLbl.Size = new System.Drawing.Size(84, 19);
            this.returnFeelLikeLbl.TabIndex = 4;
            this.returnFeelLikeLbl.Text = "Feel-Like";
            // 
            // returnHighLbl
            // 
            this.returnHighLbl.AutoSize = true;
            this.returnHighLbl.BackColor = System.Drawing.Color.Transparent;
            this.returnHighLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnHighLbl.ForeColor = System.Drawing.Color.Black;
            this.returnHighLbl.Location = new System.Drawing.Point(122, 250);
            this.returnHighLbl.Name = "returnHighLbl";
            this.returnHighLbl.Size = new System.Drawing.Size(97, 19);
            this.returnHighLbl.TabIndex = 4;
            this.returnHighLbl.Text = "Temp High";
            // 
            // returnTempLowLbl
            // 
            this.returnTempLowLbl.AutoSize = true;
            this.returnTempLowLbl.BackColor = System.Drawing.Color.Transparent;
            this.returnTempLowLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnTempLowLbl.ForeColor = System.Drawing.Color.Black;
            this.returnTempLowLbl.Location = new System.Drawing.Point(122, 275);
            this.returnTempLowLbl.Name = "returnTempLowLbl";
            this.returnTempLowLbl.Size = new System.Drawing.Size(91, 19);
            this.returnTempLowLbl.TabIndex = 4;
            this.returnTempLowLbl.Text = "Temp Low";
            // 
            // returnPressureLbl
            // 
            this.returnPressureLbl.AutoSize = true;
            this.returnPressureLbl.BackColor = System.Drawing.Color.Transparent;
            this.returnPressureLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnPressureLbl.ForeColor = System.Drawing.Color.Black;
            this.returnPressureLbl.Location = new System.Drawing.Point(122, 302);
            this.returnPressureLbl.Name = "returnPressureLbl";
            this.returnPressureLbl.Size = new System.Drawing.Size(78, 19);
            this.returnPressureLbl.TabIndex = 4;
            this.returnPressureLbl.Text = "Pressure";
            // 
            // returnHumidityLbl
            // 
            this.returnHumidityLbl.AutoSize = true;
            this.returnHumidityLbl.BackColor = System.Drawing.Color.Transparent;
            this.returnHumidityLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnHumidityLbl.ForeColor = System.Drawing.Color.Black;
            this.returnHumidityLbl.Location = new System.Drawing.Point(122, 327);
            this.returnHumidityLbl.Name = "returnHumidityLbl";
            this.returnHumidityLbl.Size = new System.Drawing.Size(85, 19);
            this.returnHumidityLbl.TabIndex = 4;
            this.returnHumidityLbl.Text = "Humidity";
            // 
            // returnWeatherText
            // 
            this.returnWeatherText.BackColor = System.Drawing.Color.Black;
            this.returnWeatherText.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnWeatherText.ForeColor = System.Drawing.Color.White;
            this.returnWeatherText.Location = new System.Drawing.Point(272, 166);
            this.returnWeatherText.Name = "returnWeatherText";
            this.returnWeatherText.Size = new System.Drawing.Size(100, 23);
            this.returnWeatherText.TabIndex = 5;
            // 
            // returnFeelsLikeText
            // 
            this.returnFeelsLikeText.BackColor = System.Drawing.Color.Black;
            this.returnFeelsLikeText.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnFeelsLikeText.ForeColor = System.Drawing.Color.White;
            this.returnFeelsLikeText.Location = new System.Drawing.Point(272, 220);
            this.returnFeelsLikeText.Name = "returnFeelsLikeText";
            this.returnFeelsLikeText.Size = new System.Drawing.Size(100, 23);
            this.returnFeelsLikeText.TabIndex = 5;
            // 
            // returnTemperatureText
            // 
            this.returnTemperatureText.BackColor = System.Drawing.Color.Black;
            this.returnTemperatureText.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnTemperatureText.ForeColor = System.Drawing.Color.White;
            this.returnTemperatureText.Location = new System.Drawing.Point(272, 192);
            this.returnTemperatureText.Name = "returnTemperatureText";
            this.returnTemperatureText.Size = new System.Drawing.Size(100, 23);
            this.returnTemperatureText.TabIndex = 5;
            // 
            // returnTempHighText
            // 
            this.returnTempHighText.BackColor = System.Drawing.Color.Black;
            this.returnTempHighText.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnTempHighText.ForeColor = System.Drawing.Color.White;
            this.returnTempHighText.Location = new System.Drawing.Point(272, 247);
            this.returnTempHighText.Name = "returnTempHighText";
            this.returnTempHighText.Size = new System.Drawing.Size(100, 23);
            this.returnTempHighText.TabIndex = 5;
            // 
            // returnPressureText
            // 
            this.returnPressureText.BackColor = System.Drawing.Color.Black;
            this.returnPressureText.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnPressureText.ForeColor = System.Drawing.Color.White;
            this.returnPressureText.Location = new System.Drawing.Point(272, 300);
            this.returnPressureText.Name = "returnPressureText";
            this.returnPressureText.Size = new System.Drawing.Size(100, 23);
            this.returnPressureText.TabIndex = 5;
            // 
            // returnTempLowText
            // 
            this.returnTempLowText.BackColor = System.Drawing.Color.Black;
            this.returnTempLowText.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnTempLowText.ForeColor = System.Drawing.Color.White;
            this.returnTempLowText.Location = new System.Drawing.Point(272, 274);
            this.returnTempLowText.Name = "returnTempLowText";
            this.returnTempLowText.Size = new System.Drawing.Size(100, 23);
            this.returnTempLowText.TabIndex = 5;
            // 
            // returnHumidityText
            // 
            this.returnHumidityText.BackColor = System.Drawing.Color.Black;
            this.returnHumidityText.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnHumidityText.ForeColor = System.Drawing.Color.White;
            this.returnHumidityText.Location = new System.Drawing.Point(272, 327);
            this.returnHumidityText.Name = "returnHumidityText";
            this.returnHumidityText.Size = new System.Drawing.Size(100, 23);
            this.returnHumidityText.TabIndex = 5;
            // 
            // primary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.returnTempLowText);
            this.Controls.Add(this.returnHumidityText);
            this.Controls.Add(this.returnPressureText);
            this.Controls.Add(this.returnTemperatureText);
            this.Controls.Add(this.returnTempHighText);
            this.Controls.Add(this.returnFeelsLikeText);
            this.Controls.Add(this.returnWeatherText);
            this.Controls.Add(this.returnHumidityLbl);
            this.Controls.Add(this.returnPressureLbl);
            this.Controls.Add(this.returnTempLowLbl);
            this.Controls.Add(this.returnHighLbl);
            this.Controls.Add(this.returnTemperatureLbl);
            this.Controls.Add(this.returnFeelLikeLbl);
            this.Controls.Add(this.returnWeatherLbl);
            this.Controls.Add(this.returnCityNameLbl);
            this.Controls.Add(this.primarySubmitBtn);
            this.Controls.Add(this.primaryCityEntry);
            this.Controls.Add(this.primaryHeaderLbl);
            this.Name = "primary";
            this.Text = "Weather App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label primaryHeaderLbl;
        public System.Windows.Forms.TextBox primaryCityEntry;
        private System.Windows.Forms.Button primarySubmitBtn;
        private System.Windows.Forms.Label returnWeatherLbl;
        private System.Windows.Forms.Label returnTemperatureLbl;
        private System.Windows.Forms.Label returnFeelLikeLbl;
        private System.Windows.Forms.Label returnHighLbl;
        private System.Windows.Forms.Label returnTempLowLbl;
        private System.Windows.Forms.Label returnPressureLbl;
        private System.Windows.Forms.Label returnHumidityLbl;
        public System.Windows.Forms.TextBox returnWeatherText;
        public System.Windows.Forms.TextBox returnFeelsLikeText;
        public System.Windows.Forms.TextBox returnTemperatureText;
        public System.Windows.Forms.TextBox returnTempHighText;
        public System.Windows.Forms.TextBox returnPressureText;
        public System.Windows.Forms.TextBox returnTempLowText;
        public System.Windows.Forms.TextBox returnHumidityText;
        public System.Windows.Forms.Label returnCityNameLbl;
    }
}

