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

namespace Yomiage.GUI.Dialog.Views
{
    /// <summary>
    /// WordListDialog.xaml の相互作用ロジック
    /// </summary>
    public partial class WordListDialog : UserControl
    {
        public WordListDialog()
        {
            InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void detail_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
