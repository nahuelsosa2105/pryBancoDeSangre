﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBancoDeSangre
{
    public partial class frmLogin : MaterialSkin.Controls.MaterialForm
    {
        clsBaseDeDatosUser objBaseDeDatos;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            objBaseDeDatos = new clsBaseDeDatosUser();
            objBaseDeDatos.ConectarBD();
            lblEstadoDeConexion.Text = objBaseDeDatos.estadoConexion.ToString();


        }

        public static string user;
        public static string pass;
        private void materialButton1_Click(object sender, EventArgs e)
        {
            user = txtUser.Text;
            pass = txtPass.Text;

            clsBaseDeDatosUser

        }
    }
}
