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

namespace HolaMundo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            if (NombreTextBox.Text == "")
                SaludoTextBlock.Text = "Hola Mundo!";
            else
            {
                SaludoTextBlock.Text = "Hola " + NombreTextBox.Text + "!";
                NombreTextBox.Text = "";
            }            
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            SaludoTextBlock.Text = "Hola Mundo!";
            NombreTextBox.Text = "";
        }

        private void NombreTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (NombreTextBox.Text == "")
                    SaludoTextBlock.Text = "Hola Mundo!";
                else
                {
                    SaludoTextBlock.Text = "Hola " + NombreTextBox.Text + "!";
                    NombreTextBox.Text = "";
                }
            }
        }
    }
}
