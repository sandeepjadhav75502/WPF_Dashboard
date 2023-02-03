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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using System.Diagnostics;

namespace EVotingDashBoard
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowCard();
            var paletteHelper = new MaterialDesignThemes.Wpf.PaletteHelper();
        }

        private async Task ShowCard()
        {
            await Task.Delay(2000);
            //Card1.Visibility = Visibility.Visible;
            //MaterialDesignThemes.Wpf.Card c = Card1;
            //c.Visibility = Visibility.Visible;
            //MyGrid.Children.Add(c);




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        bool ShowLeft = true;
        bool isLeft = false;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            isLeft = true;
            if (ShowLeft)
                ShowHideMenu("sbShowLeftMenuHide", btnHideShow, dockPanelLeft);
            else
                ShowHideMenu("sbShowLeftMenuShow", btnHideShow, dockPanelLeft);

        }

        private void ShowHideMenu(string Storyboard, Button btnHide, DockPanel pnl)
        {
            Storyboard sb = Resources[Storyboard] as Storyboard;
            sb.Begin(pnl);
            if (isLeft)
                ShowLeft = !ShowLeft;
            else
                ShowRight = !ShowRight;
        }
        bool ShowRight = true;
        private void btnHideShowRight_Click(object sender, RoutedEventArgs e)
        {
            isLeft = false;
            if (ShowRight)
                ShowHideMenu("sbShowRightMenuHide", btnHideShowRight, dockPanelRight);
            else
                ShowHideMenu("sbShowRightMenuShow", btnHideShowRight, dockPanelRight);
        }

        private void btnStatus_Click(object sender, RoutedEventArgs e)
        {
            //rowHeader.Visibility = Visibility.Collapsed;
        }

        private void CardClick(object sender, MouseButtonEventArgs e)
        {
            string CardName = ((MaterialDesignThemes.Wpf.Card)sender).Name;
            switch (CardName)
            {
                case "cardBaseStation":
                    WindowBaseStation ObjBaseStation = new WindowBaseStation();
                    ObjBaseStation.Owner = this;
                    ObjBaseStation.Show();
                    break;

                case "CardClassInfo":
                    WindowClassMaster ObjClass = new WindowClassMaster();
                    ObjClass.Owner = this;
                    ObjClass.Show();
                    break;

                case "CardVoterMapping":
                    WindowMappingKeypadBaseStationView ObjMappingKeypadBaseStationView = new WindowMappingKeypadBaseStationView();
                    ObjMappingKeypadBaseStationView.Owner = this;
                    ObjMappingKeypadBaseStationView.Show();
                    break;

                case "CardStudentManagement":
                    WindowStudentManagement ObjWindowStudentManagement = new WindowStudentManagement();
                    ObjWindowStudentManagement.Owner = this;
                    ObjWindowStudentManagement.Show();
                    break;




            }
        }

        public void CenterWindowOnScreen(Window window, Window ParentWindow)
        {
            try
            {
                window.Owner = ParentWindow;
                double screenWidth = ParentWindow.Width;
                double screenHeight = ParentWindow.Height;
                double windowWidth = window.Width;
                double windowHeight = window.Height;
                window.Left = (screenWidth / 2) - (windowWidth / 2);
                window.Top = cardHeader.Height + 20;
                //window.Top = (screenHeight / 2) - (windowHeight / 2);
            }
            catch (Exception ex)
            {

            }
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
