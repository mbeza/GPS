using System;
using System.Windows.Forms;

namespace GPS
{
    public partial class Form1 : Form
    {
        public string szerokosc;
        public string dlugosc;
        public string liczbaSatelit;
        public string wysokosc;
        public string czas;
     

        public Form1()
        {
            InitializeComponent();
            port.Text = "COM5";
            timer1.Enabled = true;
            timer1.Start();

            serialPort1.PortName = "COM5";
            serialPort1.BaudRate = 9600;
            serialPort1.Parity = System.IO.Ports.Parity.None;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = System.IO.Ports.StopBits.One;
            serialPort1.Handshake = System.IO.Ports.Handshake.None;

            try
            {
                serialPort1.Open();
                MessageBox.Show("Otwarto" + serialPort1.PortName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void locBtn_Click(object sender, EventArgs e)
        {
           browser.Navigate("https://www.google.com/maps/place/"+szerokosc+"+"+dlugosc); 
        }

        private void openPort_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                serialPort1.PortName = port.Text;
                serialPort1.Open();
                MessageBox.Show("Otwarto");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string data = serialPort1.ReadExisting();

                string[] strArr = data.Split('$');
                for (int i = 0; i < strArr.Length; i++)
                {
                    string strTemp = strArr[i];
                    string[] lineArr = strTemp.Split(',');
              
                    if (lineArr[0].Equals("GPGGA"))
                    {
                        Console.WriteLine(strArr[i]);
                        try
                        {

                            lineArr[1] = lineArr[1].Replace('.', ',');
                            czas = lineArr[1].Substring(0, 2).ToString() +":" +lineArr[1].Substring(2, 2).ToString() + ":" + lineArr[1].Substring(4, 2).ToString() +"UTC +0";

                            timeVal.Text = czas;

                            lineArr[2]=lineArr[2].Replace('.', ',');
                            double dLat = Convert.ToDouble(lineArr[2]);
                            
                            dLat = dLat / 100;
                            
                            var dLat2 = Math.Floor(dLat);  // stopnie
                            var dLat3 = Math.Floor((dLat - dLat2) * 60); // minuty
                            var dLat4 = (dLat - dLat2 - (dLat3 / 60)) * 3600;
                            string[] lat = dLat.ToString().Split('.');

                            szerokosc = dLat2.ToString() + "°0" + dLat3.ToString() + "'" + dLat4.ToString() + "\"" + lineArr[3].ToString();

                            lineArr[4] = lineArr[4].Replace('.', ',');
                            double dLon = Convert.ToDouble(lineArr[4]);
                            dLon = dLon / 100;
                            var dLon2 = Math.Floor(dLat);  // stopnie
                            var dLon3 = Math.Floor((dLat - dLat2) * 60); // minuty
                            var dLon4 = (dLat - dLat2 - (dLat3 / 60)) * 3600;
                            
                            dlugosc = dLon2.ToString() + "°0" + dLon3.ToString() + "'" + dLon4.ToString() + "\"" + lineArr[5].ToString();

                            liczbaSatelit = lineArr[7].ToString();

                            wysokosc = lineArr[9].ToString();

                            szerVal.Text = szerokosc;
                            dlugVal.Text = dlugosc;
                            satVal.Text = liczbaSatelit;
                            wysVal.Text = wysokosc;
                           
                        }
                        catch
                        {
                            szerVal.Text = "error";
                            dlugVal.Text = "error";
                            satVal.Text = "error";
                            wysVal.Text = "error";
                            timeVal.Text = "error";
                        }
                    }
                }
            }
            else
            {
                szerVal.Text = "COM zamknięty";
                dlugVal.Text = "COM zamknięty";
                satVal.Text = "COM zamknięty";
                wysVal.Text = "COM zamknięty";
                timeVal.Text = "COM zamknięty";
            }
        }
    }
}
