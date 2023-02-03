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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


using System.Diagnostics;
//using MaterialDesignColors.WpfExample.Domain;
//using MaterialDesignThemes.Wpf;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls.Primitives;
//using System.Windows.Input;
//using System.Windows.Media;


namespace EVotingDashBoard
{
    /// <summary>
    /// Interaction logic for WindowBaseStation.xaml
    /// </summary>
    public partial class WindowBaseStation : Window
    {
        public WindowBaseStation()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        bool AlreadyFaded;
        
        void anim_Completed(object sender, EventArgs e)
        {
            Close();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //var sampleMessageDialog = new SampleMessageDialog
            //{
            //    Message = { Text = ((ButtonBase)sender).Content.ToString() }
            //};

            //await DialogHost.Show(sampleMessageDialog, "RootDialog");  
        }

        

    }
}
