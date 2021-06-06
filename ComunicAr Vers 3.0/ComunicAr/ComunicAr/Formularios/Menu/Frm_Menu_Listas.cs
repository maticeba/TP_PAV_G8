﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Formularios.Reportes.Clientes;
using ComunicAr.Formularios.Reportes.Dispositivos;
using ComunicAr.Formularios.Reportes.DispVendidos;

namespace ComunicAr.Formularios.Menu
{
    public partial class Frm_Menu_Listas : Form
    {
        public Frm_Menu_Listas()
        {
            InitializeComponent();
        }

        private void bnt_menu_lista_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_menu_lista_cliente_Click(object sender, EventArgs e)
        {
            Reporte_para_Clientes Rep_cliente = new Reporte_para_Clientes();
            Rep_cliente.ShowDialog();
        }

        private void bnt_menu_lista_dispositivos_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Disp frm_Reporte_Disp = new Frm_Reporte_Disp();
            frm_Reporte_Disp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Disp_Vendidos frm_Reporte_Disp_Vendidos = new Frm_Reporte_Disp_Vendidos();
            frm_Reporte_Disp_Vendidos.ShowDialog();
        }
    }
}