using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace FX5UC_Csharp
{
    public partial class Form1 : Form
    {
        ModbusClient modbus = new ModbusClient();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {   //M0 = 8192 ПО КАРТЕ МОДБАС Start MODBUS Device No.
            modbus.WriteSingleCoil(8192, checkBox1.Checked);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            modbus.IPAddress = Convert.ToString(textBox1.Text);
            modbus.Port = Convert.ToInt32(textBox2.Text);
            try
            {
                modbus.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (modbus.Connected == true)
            {
                label4.Text = "Connected";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modbus.Disconnect();
            label4.Text = "Disconnected";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //M1 = 8193 ПО КАРТЕ МОДБАС
            modbus.WriteSingleCoil(8193, checkBox2.Checked);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //Y0 = 0 ПО КАРТЕ МОДБАС Start MODBUS Device No.
            modbus.WriteSingleCoil(0, checkBox3.Checked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //Y1 = 1 ПО КАРТЕ МОДБАС Start MODBUS Device No.
            modbus.WriteSingleCoil(1, checkBox3.Checked);
        }

        private void button3_Click(object sender, EventArgs e)
        {   //Write D0, D1
            modbus.WriteSingleRegister(0, Convert.ToInt32(D0_textBox3.Text));
            modbus.WriteSingleRegister(1, Convert.ToInt32(D1_textBox4.Text));
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {   //Read D0,D1
            int[] D = modbus.ReadHoldingRegisters(0, 2);
            D0_textBox5.Text = D[0].ToString();
            D1_textBox6.Text = D[1].ToString();    
           
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void D1_textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
