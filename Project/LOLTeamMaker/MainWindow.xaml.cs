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

using LOLTeamMaker.Data;
using LOLTeamMaker.Enum;
using LOLTeamMaker.Converter;
using Microsoft.Win32;

namespace LOLTeamMaker
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // FOR TEST
            #region TEST
            PlayerDataContainer container = PlayerDataContainer.GetOrCreateInstance();

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                string tier = EnumConverter.TierToKoreanString((Tier)random.Next(7));
                string dPosition = EnumConverter.PositionToKoreanString((Position)random.Next(5));
                string aPosition = EnumConverter.PositionToKoreanString((Position)random.Next(5));

                container.AddData(new Player()
                {
                    NickName = $"Test_{i}",
                    Tier = tier,
                    DesiredPosition = dPosition,
                    AssignedPosition = aPosition
                });
            }

            MainList.ItemsSource = container.GetListData();
            #endregion
        }

        // Calls when next button clicked.
        // Check player list's count and move to next scene.
        private void OnNextButtonClick(object sender, RoutedEventArgs e)
        {
            PlayerDataContainer container = PlayerDataContainer.GetOrCreateInstance();
            if (container.GetPlayerCount() >= 10)
            {
                // TODO : goto next page
                MessageBox.Show("개발중입니다.", "알림", MessageBoxButton.OK, MessageBoxImage.None);
            }
            else
            {
                MessageBox.Show($"플레이어 10명을 채워주세요. ({container.GetPlayerCount()})", "알림", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void MainList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // TODO : 선택된 부분을 저장/삭제 후 추후 삭제 버튼이 추가되었을 떄 작동하 수 있도록 하기
        }
    }
}
