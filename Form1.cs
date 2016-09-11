
/////////////////////////////////////////////////////////////////////
//+----------+------------------------------------------------------+
//| Programa | MonitorSerialTCP     
//| Autor    | IDX Consultoria e Sistemas Ltda
//| Data     | 07.09.2016
//+----------+------------------------------------------------------+
//| Monitor de Integração via .txt ou TCP/IP com indicador EPM 
//| SP2400
//+-----------------------------------------------------------------+
/////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Reflection;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Configuration;


namespace MonitorSerialTCP
{
    public partial class Form1 : Form
    {

        private const int porta = 2013;

        SerialPort serial = new SerialPort();
        
        TcpListener listener = new TcpListener(IPAddress.Any, porta);
        TcpClient client;
        NetworkStream ns;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPeso.ReadOnly = true;
            txtPeso.Text = "0";
        }

        private void btnConectaSerial_Click(object sender, EventArgs e)
        {
            try
            {
                string porta = cmbSerial.SelectedItem.ToString();
              
                serial.PortName       = porta;
                serial.BaudRate       = 9600;
                serial.Parity         = Parity.None;
                serial.DataBits       = 8;
                serial.StopBits       = StopBits.Two;
                serial.Handshake      = Handshake.None;
                serial.ReadTimeout    = 500;  // 0,5 segundo
                //serial.ReadBufferSize = ;
                
                // abre a porta serial
                try
                {
                    serial.Open();

                    btnConectaSerial.Enabled = false;
                    btnDesconectaSerial.Enabled = true;
                    btnIniciarMonitor.Enabled = true;
                    btnPararMonitor.Enabled = false;

                }
                catch
                {
                    txtPeso.Text = "FALHA ";
                    btnConectaSerial.Enabled = true;
                    btnDesconectaSerial.Enabled = false;
                    btnIniciarMonitor.Enabled = false;
                    btnPararMonitor.Enabled = false;
                }

            }
            catch
            {
                txtPeso.Text = "SERIAL?";
            }
         
        }

        private void btnDesconectaSerial_Click(object sender, EventArgs e)
        {
            serial.Close();
            btnConectaSerial.Enabled = true;
            btnDesconectaSerial.Enabled = false;
            btnIniciarMonitor.Enabled = false;
            btnPararMonitor.Enabled = false;
        }

        private void btnIniciarMonitor_Click(object sender, EventArgs e)
        {

            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(LeSerial);
            timer1.Enabled = true;

            if (radTCP.Checked == true)
            {
                listener.Start();
                //client = listener.AcceptTcpClient();
                
                //ns = client.GetStream();
                //ns.WriteTimeout = 500;
            }

            btnDesconectaSerial.Enabled = false;
            btnIniciarMonitor.Enabled = false;
            btnPararMonitor.Enabled = true;
            radArquivo.Enabled = false;
            radTCP.Enabled = false;

         
        }

        private void btnPararMonitor_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (radTCP.Checked == true)
            {
                //ns.Close();
                //client.Close();
                listener.Stop();
            }

            btnDesconectaSerial.Enabled = true;
            btnIniciarMonitor.Enabled = true;
            btnPararMonitor.Enabled = false;
            radArquivo.Enabled = true;
            radTCP.Enabled = true;

        }

        private void LeSerial(object sender, EventArgs e)
        {
            string dados = "";

            lblHora.Text = System.DateTime.Now.ToLocalTime().ToString();

            //-----------------TESTE----------------------
            //string txt = ConfigurationManager.AppSettings["arquivo"];
            //StreamWriter file = new StreamWriter(@txt, false);

            //file.WriteLine(dados.Trim());
            //file.Close();
            //--------------------------------------------

            try
            {
                serial.NewLine = "\0";

                if (serial.BytesToRead > 0)
                {
                    dados = serial.ReadExisting().Substring(2, 5);
                    
                    if (radArquivo.Checked == true)
                    {
                        //StreamWriter file = new StreamWriter(@"C:\PESO\PESO.TXT", false);

                        string txt = ConfigurationManager.AppSettings["arquivo"];
                        StreamWriter file = new StreamWriter(@txt, false);

                        file.WriteLine( dados.Trim() );
                        file.Close();
                    }

                    if (radTCP.Checked == true)
                    {
                        byte[] byteDados = Encoding.ASCII.GetBytes( dados.Trim() );
                        //byte[] byteDados = Encoding.ASCII.GetBytes("PAULO\0");
                        try
                        {
                            client = listener.AcceptTcpClient();
                            ns = client.GetStream();
                            ns.Write(byteDados, 0, byteDados.Length);
                            ns.Flush();
                            ns.Close();
                            client.Close();

                        }
                        catch (Exception ex)
                        {
                            //Console.WriteLine(ex.ToString());
                        }

                    }

                }
                else
                {
                    dados = "SEM DADOS";
                }
            }
            catch (TimeoutException)
            {
                dados = "0";
            }

            txtPeso.Text = dados;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lnkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
