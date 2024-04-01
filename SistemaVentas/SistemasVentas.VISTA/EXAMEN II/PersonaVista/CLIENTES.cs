﻿using SistemasVentas.BSs;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.EXAMEN_II.PersonaVista
{
    public partial class CLIENTES : Form
    {
        int idx = 0;
        Persona p = new Persona();
        PersonaBss bss = new PersonaBss();
        public CLIENTES()
        {
            idx = idx;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;
            p.Telefono = textBox3.Text;
            p.CI = textBox4.Text;
            p.Correo = textBox5.Text;

            bss.EditarPersonaBss(p);
            MessageBox.Show("SE GUARDO CORRECTAMENTE");
        }

        private void CLIENTES_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerIdBss(idx);
            textBox1.Text = p.Nombre;
            textBox2.Text = p.Apellido;
            textBox3.Text = p.Telefono;
            textBox4.Text = p.CI;
            textBox5.Text = p.Correo;

        }
    }
}
