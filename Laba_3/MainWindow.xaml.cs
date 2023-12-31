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

namespace Laba_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var n = Convert.ToInt32(N.Text);
            if (n < 5)
            {
                MessageBox.Show("N must be >= 5");
                return;
            }
            var a = new Quadrilateral[n * 2];

            for (int i = 0; i < a.Length; i += 2)
            {
                a[i] = new Rectangle(i + 1, (i + 1) * 2);
                a[i + 1] = new Square(i + 2);
            }

            list.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                list.Items.Add(a[i].Print() + " Area = " + a[i].CalculateArea().ToString());
            }
            max.Content = "Max area = " + FindMaxAreaShape(a).CalculateArea().ToString();
        }

        public static Quadrilateral FindMaxAreaShape(Quadrilateral[] shapes)
        {
            Quadrilateral maxAreaShape = null;
            double maxArea = 0;

            foreach (var shape in shapes)
            {
                double area = shape.CalculateArea();
                if (area > maxArea)
                {
                    maxArea = area;
                    maxAreaShape = shape;
                }
            }

            return maxAreaShape;
        }
    }
}
