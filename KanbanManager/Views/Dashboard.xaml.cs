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
    /// Lógica de interacción para Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
            Board board;
            int itemCount = 0;
            int totalItems = 1;
            int i = 0;
            int j = 0;
            RowDefinition row = new RowDefinition();
            row.Height = GridLength.Auto;
            contentGrid.RowDefinitions.Add(row);
            while (itemCount < totalItems)
            {
                if(j == 3)
                {
                    i++;
                    row = new RowDefinition();
                    row.Height = GridLength.Auto;
                    contentGrid.RowDefinitions.Add(row);
                    j = 0;
                }
                board = new Board("URV");
                board.SetCurrentWindow(this);
                contentGrid.Children.Add(board.GetBoard());
                Grid.SetRow(board.GetBoard(), i);
                Grid.SetColumn(board.GetBoard(), j);
                j++;
                itemCount++;
            }
            if(j == 3)
            {
                i++;
                row = new RowDefinition();
                row.Height = GridLength.Auto;
                contentGrid.RowDefinitions.Add(row);
                j = 0;
            }
            board = new Board();
            contentGrid.Children.Add(board.GetBoard());
            Grid.SetRow(board.GetBoard(), i);
            Grid.SetColumn(board.GetBoard(), j);
        }

    }
}
