namespace GPS
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.locBtn = new System.Windows.Forms.Button();
            this.port = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.openPort = new System.Windows.Forms.Button();
            this.szerlbl = new System.Windows.Forms.Label();
            this.dluglbl = new System.Windows.Forms.Label();
            this.satlbl = new System.Windows.Forms.Label();
            this.wyslbl = new System.Windows.Forms.Label();
            this.szerVal = new System.Windows.Forms.Label();
            this.dlugVal = new System.Windows.Forms.Label();
            this.satVal = new System.Windows.Forms.Label();
            this.wysVal = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLbl = new System.Windows.Forms.Label();
            this.timeVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(362, 12);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(793, 633);
            this.browser.TabIndex = 0;
            // 
            // locBtn
            // 
            this.locBtn.Location = new System.Drawing.Point(41, 462);
            this.locBtn.Name = "locBtn";
            this.locBtn.Size = new System.Drawing.Size(114, 44);
            this.locBtn.TabIndex = 1;
            this.locBtn.Text = "Lokalizuj";
            this.locBtn.UseVisualStyleBackColor = true;
            this.locBtn.Click += new System.EventHandler(this.locBtn_Click);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(54, 44);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(57, 20);
            this.port.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port COM";
            // 
            // openPort
            // 
            this.openPort.Location = new System.Drawing.Point(54, 71);
            this.openPort.Name = "openPort";
            this.openPort.Size = new System.Drawing.Size(57, 22);
            this.openPort.TabIndex = 4;
            this.openPort.Text = "Otwórz";
            this.openPort.UseVisualStyleBackColor = true;
            this.openPort.Click += new System.EventHandler(this.openPort_Click);
            // 
            // szerlbl
            // 
            this.szerlbl.AutoSize = true;
            this.szerlbl.Location = new System.Drawing.Point(11, 116);
            this.szerlbl.Name = "szerlbl";
            this.szerlbl.Size = new System.Drawing.Size(60, 13);
            this.szerlbl.TabIndex = 5;
            this.szerlbl.Text = "Szerokość:";
            // 
            // dluglbl
            // 
            this.dluglbl.AutoSize = true;
            this.dluglbl.Location = new System.Drawing.Point(11, 143);
            this.dluglbl.Name = "dluglbl";
            this.dluglbl.Size = new System.Drawing.Size(51, 13);
            this.dluglbl.TabIndex = 6;
            this.dluglbl.Text = "Długość:";
            // 
            // satlbl
            // 
            this.satlbl.AutoSize = true;
            this.satlbl.Location = new System.Drawing.Point(11, 173);
            this.satlbl.Name = "satlbl";
            this.satlbl.Size = new System.Drawing.Size(71, 13);
            this.satlbl.TabIndex = 7;
            this.satlbl.Text = "Liczba satelit:";
            // 
            // wyslbl
            // 
            this.wyslbl.AutoSize = true;
            this.wyslbl.Location = new System.Drawing.Point(11, 204);
            this.wyslbl.Name = "wyslbl";
            this.wyslbl.Size = new System.Drawing.Size(60, 13);
            this.wyslbl.TabIndex = 8;
            this.wyslbl.Text = "Wysokość:";
            // 
            // szerVal
            // 
            this.szerVal.AutoSize = true;
            this.szerVal.Location = new System.Drawing.Point(87, 116);
            this.szerVal.Name = "szerVal";
            this.szerVal.Size = new System.Drawing.Size(23, 13);
            this.szerVal.TabIndex = 9;
            this.szerVal.Text = "null";
            // 
            // dlugVal
            // 
            this.dlugVal.AutoSize = true;
            this.dlugVal.Location = new System.Drawing.Point(87, 143);
            this.dlugVal.Name = "dlugVal";
            this.dlugVal.Size = new System.Drawing.Size(23, 13);
            this.dlugVal.TabIndex = 10;
            this.dlugVal.Text = "null";
            // 
            // satVal
            // 
            this.satVal.AutoSize = true;
            this.satVal.Location = new System.Drawing.Point(87, 173);
            this.satVal.Name = "satVal";
            this.satVal.Size = new System.Drawing.Size(23, 13);
            this.satVal.TabIndex = 11;
            this.satVal.Text = "null";
            // 
            // wysVal
            // 
            this.wysVal.AutoSize = true;
            this.wysVal.Location = new System.Drawing.Point(87, 204);
            this.wysVal.Name = "wysVal";
            this.wysVal.Size = new System.Drawing.Size(23, 13);
            this.wysVal.TabIndex = 12;
            this.wysVal.Text = "null";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(11, 231);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(33, 13);
            this.timeLbl.TabIndex = 14;
            this.timeLbl.Text = "Czas:";
            // 
            // timeVal
            // 
            this.timeVal.AutoSize = true;
            this.timeVal.Location = new System.Drawing.Point(87, 231);
            this.timeVal.Name = "timeVal";
            this.timeVal.Size = new System.Drawing.Size(23, 13);
            this.timeVal.TabIndex = 15;
            this.timeVal.Text = "null";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 669);
            this.Controls.Add(this.timeVal);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.wysVal);
            this.Controls.Add(this.satVal);
            this.Controls.Add(this.dlugVal);
            this.Controls.Add(this.szerVal);
            this.Controls.Add(this.wyslbl);
            this.Controls.Add(this.satlbl);
            this.Controls.Add(this.dluglbl);
            this.Controls.Add(this.szerlbl);
            this.Controls.Add(this.openPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port);
            this.Controls.Add(this.locBtn);
            this.Controls.Add(this.browser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Button locBtn;
        private System.Windows.Forms.TextBox port;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openPort;
        private System.Windows.Forms.Label szerlbl;
        private System.Windows.Forms.Label dluglbl;
        private System.Windows.Forms.Label satlbl;
        private System.Windows.Forms.Label wyslbl;
        private System.Windows.Forms.Label szerVal;
        private System.Windows.Forms.Label dlugVal;
        private System.Windows.Forms.Label satVal;
        private System.Windows.Forms.Label wysVal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label timeVal;
    }
}

