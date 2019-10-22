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

namespace headunitdigital
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, EventListener
    {
        Controller engineController;
        public MainWindow()
        {
            InitializeComponent();
            Engine engine = new Engine();
            engineController = new Controller(engine);
            engineController.addDisplayListener(this);

        }

        public void updateDisplay(string speed, string rpm, string fuel)
        {
            labelSpeed.Content = speed;
            labelRpm.Content = rpm;
            labelFuel.Content = fuel;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                engineController.acceleratePedalPressed();
            }
            if (e.Key == Key.Down)
            {
                engineController.breakPedalPressed();
            }
        }
    }
}
