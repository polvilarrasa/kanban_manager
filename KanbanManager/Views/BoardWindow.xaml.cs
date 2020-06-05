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

namespace KanbanManager
{
    /// <summary>
    /// Lógica de interacción para BoardWindow.xaml
    /// </summary>
    public partial class BoardWindow : Window
    {
        public BoardWindow(Board board)
        {
            InitializeComponent();
            titleLbl.Content = board.GetBoardName();
            int itemCount = 0;
            int totalItems = 3;
            ColumnDefinition col = new ColumnDefinition
            {
                Width = GridLength.Auto
            };
            contentGrid.ColumnDefinitions.Add(col);
            while (itemCount < totalItems)
            {
                //contentGrid.Children.Add();
                //Grid.SetColumn(, itemCount);
                col = new ColumnDefinition
                {
                    Width = GridLength.Auto
                };
                contentGrid.ColumnDefinitions.Add(col);
                itemCount++;
            }
        }
    }
}
