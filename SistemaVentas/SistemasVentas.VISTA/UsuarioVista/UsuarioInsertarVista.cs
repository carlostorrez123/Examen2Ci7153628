﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.BSs;
using SistemaVentas.Modelos;

namespace SistemasVentas.VISTA.UsuarioVista
{
    public partial class UsuarioInsertarVista : Form
    {
        public UsuarioInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bss = new PersonaBss();
        UsuarioBss bssuser = new UsuarioBss();

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void UsuarioInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
