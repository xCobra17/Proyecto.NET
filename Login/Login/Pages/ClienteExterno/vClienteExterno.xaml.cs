﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using CoreSevices;

namespace Login.Pages.ClienteExterno
{
    /// <summary>
    /// Lógica de interacción para vClienteExterno.xaml
    /// </summary>
    public partial class vClienteExterno : MetroWindow
	{
        public vClienteExterno()
        {
            InitializeComponent();
        }
		private void Tile_Click(object sender, RoutedEventArgs e)
		{
			Configuracion.IsOpen = true;
		}
	}
}
