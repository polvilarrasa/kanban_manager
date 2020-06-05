using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace KanbanManager
{
    public class Board
    {
        private string boardName;

        Window currentWindow;
        MaterialDesignThemes.Wpf.Card backgroundCard;
        MaterialDesignThemes.Wpf.PackIcon editIcon;
        MaterialDesignThemes.Wpf.PackIcon deleteIcon;
        MaterialDesignThemes.Wpf.PackIcon addIcon;
        System.Windows.Controls.Grid contentGrid;
        System.Windows.Controls.Button editButton;
        System.Windows.Controls.Button deleteButton;
        System.Windows.Controls.Button addButton;
        System.Windows.Controls.Label titleLabel;

        public Board()
        {
            addIcon = new MaterialDesignThemes.Wpf.PackIcon();
            addIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Add;
            addIcon.Width = 50;
            addIcon.Height = 50;
            addButton = new System.Windows.Controls.Button()
            {
                Width = 60,
                Height = 60,
                BorderBrush = Brushes.White,
                Background = Brushes.White,
                Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFB9CBE4")),
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Center,
                Content = addIcon
            };
            contentGrid = new System.Windows.Controls.Grid();
            contentGrid.Children.Add(addButton);
            backgroundCard = new MaterialDesignThemes.Wpf.Card();
            backgroundCard.Background = Brushes.White;
            backgroundCard.Margin = new System.Windows.Thickness(20);
            backgroundCard.MinHeight = 150;
            backgroundCard.Content = contentGrid;
        }

        public Board(string name)
        {
            boardName = name;
            editIcon = new MaterialDesignThemes.Wpf.PackIcon();
            editIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Pencil;
            deleteIcon = new MaterialDesignThemes.Wpf.PackIcon();
            deleteIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Bin;
            editButton = new System.Windows.Controls.Button()
            {
                Width = 50,
                Height = 50,
                BorderBrush = Brushes.White,
                Background = Brushes.White,
                Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF3A6FBB")),
                HorizontalAlignment = System.Windows.HorizontalAlignment.Left,
                VerticalAlignment = System.Windows.VerticalAlignment.Top,
                Content = editIcon
            };
            deleteButton = new System.Windows.Controls.Button()
            {
                Width = 50,
                Height = 50,
                BorderBrush = Brushes.White,
                Background = Brushes.White,
                Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFD13F3F")),
                HorizontalAlignment = System.Windows.HorizontalAlignment.Right,
                VerticalAlignment = System.Windows.VerticalAlignment.Top,
                Content = deleteIcon
            };
            titleLabel = new System.Windows.Controls.Label()
            {
                Content = boardName,
                FontSize = 50,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Center,
                Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF464E64")),
                FontFamily = new FontFamily("Freestyle Script")
            };
            contentGrid = new System.Windows.Controls.Grid();
            contentGrid.Children.Add(titleLabel);
            contentGrid.Children.Add(editButton);
            contentGrid.Children.Add(deleteButton);
            backgroundCard = new MaterialDesignThemes.Wpf.Card();
            backgroundCard.Background = Brushes.White;
            backgroundCard.Margin = new System.Windows.Thickness(20);
            backgroundCard.MinHeight = 150;
            backgroundCard.Content = contentGrid;
            backgroundCard.MouseDown += BoardClick;
        }

        private void BoardClick(object sender, RoutedEventArgs e)
        {
            BoardWindow board = new BoardWindow(this);
            board.Show();
            currentWindow.Close();

        }

        public MaterialDesignThemes.Wpf.Card GetBoard()
        {
            return backgroundCard;
        }

        public void SetCurrentWindow(Window w)
        {
            currentWindow = w;
        }

        public Window GetCurrentWindow()
        {
            return currentWindow;
        }

        public string GetBoardName()
        {
            return boardName;
        }
    }
}
