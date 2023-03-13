using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EpicGames_Clone
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

        private void MouseEnteredOnMinimizedBtn(object sender, MouseEventArgs e)
        {
            MinimizeBtn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#54B2DE"));
        }
        private void MouseEnteredOnFullScreenBtn(object sender, MouseEventArgs e)
        {
            FullScreenBtn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#54B2DE"));
        }
        private void MouseEnteredOnExitBtn(object sender, MouseEventArgs e)
        {
            ExitBtn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E62E4C"));
        }
        private void MouseLeavedOnFullScreenBtn(object sender, MouseEventArgs e)
        {
            FullScreenBtn.Background = new SolidColorBrush(Colors.Transparent);
        }
        private void MouseLeavedOnExitBtn(object sender, MouseEventArgs e)
        {
            ExitBtn.Background = new SolidColorBrush(Colors.Transparent);

        }
        private void MouseLeavedOnMinimizeBtn(object sender, MouseEventArgs e)
        {
            MinimizeBtn.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void ExitBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void FullScreenBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
            
        }

        private void MinimizeBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void CartTxt_MouseEnter(object sender, MouseEventArgs e)
        {
            CartTxt.Foreground = new SolidColorBrush(Colors.White);
        }

        private void CartTxt_MouseLeave(object sender, MouseEventArgs e)
        {
            CartTxt.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#686868"));
        }
        private void Wishlist_MouseEnter(object sender, MouseEventArgs e)
        {
            WishlistTxt.Foreground = new SolidColorBrush(Colors.White);
        }

        private void Wishlist_MouseLeave(object sender, MouseEventArgs e)
        {
            WishlistTxt.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#686868"));
        }
        private void Browse_MouseEnter(object sender, MouseEventArgs e)
        {
            BrowseTxt.Foreground = new SolidColorBrush(Colors.White);
        }

        private void Browse_MouseLeave(object sender, MouseEventArgs e)
        {
            BrowseTxt.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#686868"));
        }
        private void News_MouseEnter(object sender, MouseEventArgs e)
        {
            NewsTxt.Foreground = new SolidColorBrush(Colors.White);
        }

        private void News_MouseLeave(object sender, MouseEventArgs e)
        {
            NewsTxt.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#686868"));
        }

        private void LibraryBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            LibraryBtn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void LibraryBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            LibraryBtn.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void UnrealEngineBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            UnrealEngineBtn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));

        }

        private void UnrealEngineBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            UnrealEngineBtn.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void ProfileBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            ProfileBtn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#363636"));
        }

        private void ProfileBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            ProfileBtn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));

        }

        private void GroupBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            GroupBtn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#363636"));
        }

        private void GroupBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            GroupBtn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void StoreBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            StoreBtn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#363636"));
        }

        private void StoreBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            StoreBtn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Item2BtnPage1_MouseEnter(object sender, MouseEventArgs e)
        {
            Item2BtnPage1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Item2BtnPage1_MouseLeave(object sender, MouseEventArgs e)
        {
            Item2BtnPage1.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void Item3BtnPage1_MouseEnter(object sender, MouseEventArgs e)
        {
            Item3BtnPage1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Item3BtnPage1_MouseLeave(object sender, MouseEventArgs e)
        {
            Item3BtnPage1.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void Item4Page1_MouseEnter(object sender, MouseEventArgs e)
        {
            Item4Page1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Item4Page1_MouseLeave(object sender, MouseEventArgs e)
        {
            Item4Page1.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void Item5Page1_MouseEnter(object sender, MouseEventArgs e)
        {
            Item5Page1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Item5Page1_MouseLeave(object sender, MouseEventArgs e)
        {
            Item5Page1.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void Item6Page1_MouseEnter(object sender, MouseEventArgs e)
        {
            Item6Page1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Item6Page1_MouseLeave(object sender, MouseEventArgs e)
        {
            Item6Page1.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void GodOfWarImage_MouseEnter(object sender, MouseEventArgs e)
        {
            GodOfWarImage.Opacity = 0.75;
        }

        private void GodOfWarImage_MouseLeave(object sender, MouseEventArgs e)
        {
            GodOfWarImage.Opacity = 1;
        }

        private void GoatSimImage_MouseEnter(object sender, MouseEventArgs e)
        {
            GoatSimImage.Opacity = 0.75;

        }

        private void GoatSimImage_MouseLeave(object sender, MouseEventArgs e)
        {
            GoatSimImage.Opacity = 1;
        }

        private void EAFIFAImage_MouseEnter(object sender, MouseEventArgs e)
        {
            EAFIFAImage.Opacity = 0.75;
        }

        private void EAFIFAImage_MouseLeave(object sender, MouseEventArgs e)
        {
            EAFIFAImage.Opacity = 1;
        }

        private void MarvelSpiderImage_MouseEnter(object sender, MouseEventArgs e)
        {
            MarvelSpiderImage.Opacity = 0.75;

        }

        private void MarvelSpiderImage_MouseLeave(object sender, MouseEventArgs e)
        {
            MarvelSpiderImage.Opacity = 1;
        }

        private void CyberpunkImage_MouseEnter(object sender, MouseEventArgs e)
        {
            CyberpunkImage.Opacity = 0.75;
        }

        private void CyberpunkImage_MouseLeave(object sender, MouseEventArgs e)
        {
            CyberpunkImage.Opacity = 1;
        }

        private void RedDeadRedemptionImage_MouseEnter(object sender, MouseEventArgs e)
        {
            RedDeadRedemptionImage.Opacity = 0.75;
        }

        private void RedDeadRedemptionImage_MouseLeave(object sender, MouseEventArgs e)
        {
            RedDeadRedemptionImage.Opacity = 1;
        }

        private void rightArrowBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            rightArrowBtn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#363636"));
        }

        private void rightArrowBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            rightArrowBtn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void EgsDeadByDeadImage_MouseEnter(object sender, MouseEventArgs e)
        {
            EgsDeadByDeadImage.Opacity = 0.75;
        }

        private void EgsDeadByDeadImage_MouseLeave(object sender, MouseEventArgs e)
        {
            EgsDeadByDeadImage.Opacity = 1;
        }

        private void EgsNaconConnectImage_MouseEnter(object sender, MouseEventArgs e)
        {
            EgsNaconConnectImage.Opacity = 0.75;
        }

        private void EgsNaconConnectImage_MouseLeave(object sender, MouseEventArgs e)
        {
            EgsNaconConnectImage.Opacity = 1;
        }

        private void EgsTheMageseekerImage_MouseEnter(object sender, MouseEventArgs e)
        {
            EgsTheMageseekerImage.Opacity = 0.75;
        }

        private void EgsTheMageseekerImage_MouseLeave(object sender, MouseEventArgs e)
        {
            EgsTheMageseekerImage.Opacity = 1;
        }

        private void SaveNow_Border_MouseEnter(object sender, MouseEventArgs e)
        {
            SaveNow_1Border.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EEEEEE"));
        }

        private void SaveNow_1Border_MouseLeave(object sender, MouseEventArgs e)
        {
            SaveNow_1Border.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#292929"));
        }

        private void Learn_More_1_Border_MouseEnter(object sender, MouseEventArgs e)
        {
            Learn_More_1_Border.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EEEEEE"));
        }

        private void Learn_More_1_Border_MouseLeave(object sender, MouseEventArgs e)
        {
            Learn_More_1_Border.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#292929"));
        }

        private void ViewMoreBtn_1_MouseEnter(object sender, MouseEventArgs e)
        {
            ViewMoreBtn_1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5B5B5B"));
        }

        private void ViewMoreBtn_1_MouseLeave(object sender, MouseEventArgs e)
        {
            ViewMoreBtn_1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#292929"));
        }

        private void CallofSeaImage_MouseEnter(object sender, MouseEventArgs e)
        {
            CallofSeaImage.Opacity = 0.75;
        }

        private void CallofSeaImage_MouseLeave(object sender, MouseEventArgs e)
        {
            CallofSeaImage.Opacity = 1;
        }

        private void WarhammerImage_MouseEnter(object sender, MouseEventArgs e)
        {
            WarhammerImage.Opacity = 0.75;
        }

        private void WarhammerImage_MouseLeave(object sender, MouseEventArgs e)
        {
            WarhammerImage.Opacity = 1;
        }

        private void EuUniversalImage_MouseEnter(object sender, MouseEventArgs e)
        {
            EuUniversalImage.Opacity = 0.75;
        }

        private void EuUniversalImage_MouseLeave(object sender, MouseEventArgs e)
        {
            EuUniversalImage.Opacity = 1;
        }

        private void SurvivingAfterMathImage_MouseEnter(object sender, MouseEventArgs e)
        {
            SurvivingAfterMathImage.Opacity = 0.75;
        }

        private void SurvivingAfterMathImage_MouseLeave(object sender, MouseEventArgs e)
        {
            SurvivingAfterMathImage.Opacity = 1;
        }

        private void AgeofWonder_4_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            AgeofWonder_4_Image.Opacity = 0.75;
        }

        private void AgeofWonder_4_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            AgeofWonder_4_Image.Opacity = 1;
        }

        private void TheLemlightersLeagueImage_MouseEnter(object sender, MouseEventArgs e)
        {
            TheLemlightersLeagueImage.Opacity = 0.75;
        }

        private void TheLemlightersLeagueImage_MouseLeave(object sender, MouseEventArgs e)
        {
            TheLemlightersLeagueImage.Opacity = 1;
        }

        private void ViewMore_2_MouseEnter(object sender, MouseEventArgs e)
        {
            ViewMore_2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5B5B5B"));
        }

        private void ViewMore_2_MouseLeave(object sender, MouseEventArgs e)
        {
            ViewMore_2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_1_1_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_1_1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_1_1_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_1_1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void ViewMore_3_MouseEnter(object sender, MouseEventArgs e)
        {
            ViewMore_3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5B5B5B"));
        }

        private void ViewMore_3_MouseLeave(object sender, MouseEventArgs e)
        {
            ViewMore_3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void ViewMore_4_MouseEnter(object sender, MouseEventArgs e)
        {
            ViewMore_4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5B5B5B"));
        }

        private void ViewMore_4_MouseLeave(object sender, MouseEventArgs e)
        {
            ViewMore_4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_1_2_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_1_2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_1_2_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_1_2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_1_3_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_1_3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_1_3_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_1_3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_1_4_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_1_4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_1_4_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_1_4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_1_5_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_1_5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_1_5_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_1_5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_1_6_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_1_6.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_1_6_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_1_6.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_1_7_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_1_7.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_1_7_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_1_7.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_1_8_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_1_8.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_1_8_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_1_8.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_1_9_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_1_9.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_1_9_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_1_9.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_1_10_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_1_10.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_1_10_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_1_10.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));

        }

        private void Border_1_11_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_1_11.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_1_11_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_1_11.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_1_12_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_1_12.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_1_12_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_1_12.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_1_13_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_1_13.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_1_13_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_1_13.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_1_14_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_1_14.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_1_14_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_1_14.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_1_15_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_1_15.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_1_15_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_1_15.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Images_2_1_MouseEnter(object sender, MouseEventArgs e)
        {
            Images_2_1.Opacity = 0.75;
        }

        private void Images_2_1_MouseLeave(object sender, MouseEventArgs e)
        {
            Images_2_1.Opacity = 1;
        }

        private void Images_2_2_MouseEnter(object sender, MouseEventArgs e)
        {
            Images_2_2.Opacity = 0.75;
        }

        private void Images_2_2_MouseLeave(object sender, MouseEventArgs e)
        {
            Images_2_2.Opacity = 1;
        }

        private void Images_2_3_MouseEnter(object sender, MouseEventArgs e)
        {
            Images_2_3.Opacity = 0.75;
        }

        private void Images_2_3_MouseLeave(object sender, MouseEventArgs e)
        {
            Images_2_3.Opacity = 1;
        }

        private void Images_2_4_MouseEnter(object sender, MouseEventArgs e)
        {
            Images_2_4.Opacity = 0.75;
        }

        private void Images_2_4_MouseLeave(object sender, MouseEventArgs e)
        {
            Images_2_4.Opacity = 1;
        }

        private void Images_2_5_MouseEnter(object sender, MouseEventArgs e)
        {
            Images_2_5.Opacity = 0.75;
        }

        private void Images_2_5_MouseLeave(object sender, MouseEventArgs e)
        {
            Images_2_5.Opacity = 1;
        }

        private void Images_2_6_MouseEnter(object sender, MouseEventArgs e)
        {
            Images_2_6.Opacity = 0.75;
        }

        private void Images_2_6_MouseLeave(object sender, MouseEventArgs e)
        {
            Images_2_6.Opacity = 1;
        }

        private void ViewMore_5_MouseEnter(object sender, MouseEventArgs e)
        {
            ViewMore_5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5B5B5B"));
        }

        private void ViewMore_5_MouseLeave(object sender, MouseEventArgs e)
        {
            ViewMore_5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_2_1_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_2_1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_2_1_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_2_1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_2_2_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_2_2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_2_2_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_2_2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_2_3_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_2_3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_2_3_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_2_3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_2_4_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_2_4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_2_4_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_2_4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_2_5_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_2_5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_2_5_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_2_5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void VireMore_6_MouseEnter(object sender, MouseEventArgs e)
        {
            VireMore_6.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5B5B5B"));
        }

        private void VireMore_6_MouseLeave(object sender, MouseEventArgs e)
        {
            VireMore_6.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_2_6_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_2_6.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_2_6_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_2_6.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_2_7_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_2_7.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_2_7_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_2_7.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_2_8_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_2_8.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_2_8_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_2_8.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));

        }

        private void Border_2_9_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_2_9.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_2_9_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_2_9.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_2_10_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_2_10.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_2_10_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_2_10.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }
        private void Border_2_11_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_2_11.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_2_11_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_2_11.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_2_12_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_2_12.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_2_12_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_2_12.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_2_13_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_2_13.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_2_13_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_2_13.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
            
        }

        private void Border_2_14_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_2_14.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_2_14_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_2_14.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Border_2_15_MouseEnter(object sender, MouseEventArgs e)
        {
            Border_2_15.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
        }

        private void Border_2_15_MouseLeave(object sender, MouseEventArgs e)
        {
            Border_2_15.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void ViewMore_7_MouseEnter(object sender, MouseEventArgs e)
        {
            ViewMore_7.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5B5B5B"));
        }

        private void ViewMore_7_MouseLeave(object sender, MouseEventArgs e)
        {
            ViewMore_7.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
        }

        private void Table_1_1_MouseEnter(object sender, MouseEventArgs e)
        {
            Table_1_1.Opacity = 0.75;
        }

        private void Table_1_1_MouseLeave(object sender, MouseEventArgs e)
        {
            Table_1_1.Opacity = 1;
        }

        private void Table_1_2_MouseEnter(object sender, MouseEventArgs e)
        {
            Table_1_2.Opacity = 0.75;
        }

        private void Table_1_2_MouseLeave(object sender, MouseEventArgs e)
        {
            Table_1_2.Opacity = 1;
        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            FallGuysEventLine.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EEEEEE"));
        }

        private void TextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            FallGuysEventLine.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#292929"));
        }

        private void Image_3_1_MouseEnter(object sender, MouseEventArgs e)
        {
            Image_3_1.Opacity = 0.75;
        }

        private void Image_3_1_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_3_1.Opacity = 1;
        }

        private void Image_3_2_MouseEnter(object sender, MouseEventArgs e)
        {
            Image_3_2.Opacity = 0.75;
        }

        private void Image_3_2_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_3_2.Opacity = 1;
        }

        private void Image_3_3_MouseEnter(object sender, MouseEventArgs e)
        {
            Image_3_3.Opacity = 0.75;
        }

        private void Image_3_3_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_3_3.Opacity = 1;
        }

        private void Image_3_4_MouseEnter(object sender, MouseEventArgs e)
        {
            Image_3_4.Opacity = 0.75;
        }

        private void Image_3_4_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_3_4.Opacity = 1;
        }

        private void Image_3_5_MouseEnter(object sender, MouseEventArgs e)
        {
            Image_3_5.Opacity = 0.75;
        }

        private void Image_3_5_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_3_5.Opacity = 1;
        }

        private void Image_3_6_MouseEnter(object sender, MouseEventArgs e)
        {
            Image_3_6.Opacity = 0.75;
        }

        private void Image_3_6_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_3_6.Opacity = 1;
        }

        private void Image_3_7_MouseEnter(object sender, MouseEventArgs e)
        {
            Image_3_7.Opacity = 0.75;
        }

        private void Image_3_7_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_3_7.Opacity = 1;
        }

        private void Image_3_8_MouseEnter(object sender, MouseEventArgs e)
        {
            Image_3_8.Opacity = 0.75;
        }

        private void Image_3_8_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_3_8.Opacity = 1;
        }

        private void Image_3_9_MouseEnter(object sender, MouseEventArgs e)
        {
            Image_3_9.Opacity = 0.75;
        }

        private void Image_3_9_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_3_9.Opacity = 1;
        }

        private void Image_3_10_MouseEnter(object sender, MouseEventArgs e)
        {
            Image_3_10.Opacity = 0.75;
        }

        private void Image_3_10_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_3_10.Opacity = 1;
        }

        private void Image_3_11_MouseEnter(object sender, MouseEventArgs e)
        {
            Image_3_11.Opacity = 0.75;
        }

        private void Image_3_11_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_3_11.Opacity = 1;
        }

        private void Image_3_12_MouseEnter(object sender, MouseEventArgs e)
        {
            Image_3_12.Opacity = 0.75;
        }

        private void Image_3_12_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_3_12.Opacity = 1;
        }

        private void Table_2_1_MouseEnter(object sender, MouseEventArgs e)
        {
            Table_2_1.Opacity = 0.75;
        }

        private void Table_2_1_MouseLeave(object sender, MouseEventArgs e)
        {
            Table_2_1.Opacity = 1;
        }

        private void Table_2_2_MouseEnter(object sender, MouseEventArgs e)
        {
            Table_2_2.Opacity = 0.75;
        }

        private void Table_2_2_MouseLeave(object sender, MouseEventArgs e)
        {
            Table_2_2.Opacity = 1;
        }

        private void TextBlock_MouseEnter_1(object sender, MouseEventArgs e)
        {
            RainbowSixEvent.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EEEEEE"));
        }

        private void TextBlock_MouseLeave_1(object sender, MouseEventArgs e)
        {
            RainbowSixEvent.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#292929"));
        }

        private void Image_end_1_MouseEnter(object sender, MouseEventArgs e)
        {
            Image_end_1.Opacity = 0.75;
        }

        private void Image_end_1_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_end_1.Opacity = 1;
        }

        private void Image_end_2_MouseEnter(object sender, MouseEventArgs e)
        {
            Image_end_2.Opacity = 0.75;
        }

        private void Image_end_2_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_end_2.Opacity = 1;
        }

        private void Image_end_3_MouseEnter(object sender, MouseEventArgs e)
        {
            Image_end_3.Opacity = 0.75;
        }

        private void Image_end_3_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_end_3.Opacity = 1;
        }

        private void Image_end_4_MouseEnter(object sender, MouseEventArgs e)
        {
            Image_end_4.Opacity = 0.75;
        }

        private void Image_end_4_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_end_4.Opacity = 1;
        }

        private void Image_end_5_MouseEnter(object sender, MouseEventArgs e)
        {
            Image_end_5.Opacity = 0.75;
        }

        private void Image_end_5_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_end_5.Opacity = 1;
        }

        private void Image_end_6_MouseEnter(object sender, MouseEventArgs e)
        {
            Image_end_6.Opacity = 0.75;
        }

        private void Image_end_6_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_end_6.Opacity = 1;
        }

        private void EndTable_MouseEnter(object sender, MouseEventArgs e)
        {
            EndTable.Opacity = 0.75;
        }

        private void EndTable_MouseLeave(object sender, MouseEventArgs e)
        {
            EndTable.Opacity = 1;
        }
    }
}
