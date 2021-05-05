﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Formularios.ABM_Clientes;
using ComunicAr.Formularios.Servicios;
using ComunicAr.Formularios.ABM_Servicios.Datos;
using ComunicAr.Formularios.ABM_Servicios.Fijos;
using ComunicAr.Formularios.ABM_Provincia;
using ComunicAr.Formularios.Barrio;

namespace ComunicAr.Formularios
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void cmb_Actual_Datos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Actual_Datos.SelectedIndex == 0)
            {
                Frm_ABM_Cliente Frm_Cliente = new Frm_ABM_Cliente();
                Frm_Cliente.ShowDialog();
                cmb_Actual_Datos.SelectedIndex = -1;
            }

            if (cmb_Actual_Datos.SelectedIndex == 4)
            {
                Frm_ABM_Servicios Frm_Servicios = new Servicios.Frm_ABM_Servicios();
                Frm_Servicios.ShowDialog();
                cmb_Actual_Datos.SelectedIndex = -1;
            }

            if (cmb_Actual_Datos.SelectedIndex == 6)
            {
                Frm_ABM_ServicioFijo Frm_Fijo = new Frm_ABM_ServicioFijo();
                Frm_Fijo.ShowDialog();
                cmb_Actual_Datos.SelectedIndex = -1;

            }

            if (cmb_Actual_Datos.SelectedIndex == 7)
            {
                Frm_ABM_Datos Frm_Datos = new Frm_ABM_Datos();
                Frm_Datos.ShowDialog();
                cmb_Actual_Datos.SelectedIndex = -1;

            }
            if (cmb_Actual_Datos.SelectedIndex == 8)
            {
                Frm_ABM_Barrio Frm_Barrio = new Frm_ABM_Barrio();
                Frm_Barrio.ShowDialog();
                cmb_Actual_Datos.SelectedIndex = -1;
            }
            if (cmb_Actual_Datos.SelectedIndex == 10)
            {
                Frm_ABM_Provincia Frm_Prov = new Frm_ABM_Provincia();
                Frm_Prov.ShowDialog();
                cmb_Actual_Datos.SelectedIndex = -1;
            }
            
        }

        private void cmb_Actual_Datos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
