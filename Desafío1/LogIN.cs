﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafío1
{
    public partial class LogIN : Form
    {
        Archivo Ingresar;

        public LogIN()
        {
            InitializeComponent();
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {

                if ((textBox1.Text == "admin") && (textBox2.Text == "admin"))
                {

                    MessageBox.Show("¡ BIENVENIDO/A !");
                    Ingresar = new Archivo();
                    Ingresar.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("DEBE INGRESAR LOS DATOS CORRECTOS");
                }

            }
            else
            {
                MessageBox.Show("DEBE INGRESAR LOS DATOS");
            }

        }

        private void LogIN_Load(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

    }
 }
    
   

