﻿using MisControles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EchoOfRebellion
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            DibuixarMenu();
        }


        private void DibuixarMenu()
        {
            Dictionary<string, string> opciones = new Dictionary<string, string>()
            {
                { "frmClientes", "Clientes" },
                { "frmProveedores", "Proveedores" },
                { "frmPlanetas", "Planets" },
            };

            int _x = 10;
            int _y = 120;
            int _h = 80;
            int _w = 260;
            int offset = 10;

            foreach (KeyValuePair<string, string> kvp in opciones)
            {
                string key = kvp.Key;
                string value = kvp.Value;

                SWBotons btn = new SWBotons()
                {
                    Texto = value,
                    Top=_y,
                    Left=_x,
                    Height=_h,
                    Width=_w,
                };

                _y += _h + offset;  
                
                this.Controls.Add(btn);
            }
        }
    }
}
