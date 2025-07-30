﻿using BLL;
using System;
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
using System.Windows.Shapes;

namespace SchoolApp
{
    /// <summary>
    /// Interaction logic for TeachersWindow.xaml
    /// </summary>
    public partial class TeachersWindow : Window
    {
        public TeachersWindow()
        {
            //DataContext = this;
            //bl = new bl;
            //Teachers = bl.GetTeachers();
            InitializeComponent();
            DataContext = new
            {
                Teachers = fun.GetTeachers()
            };
        }
        //public List<Teacher> Teachers { get; set; }
    }
}
