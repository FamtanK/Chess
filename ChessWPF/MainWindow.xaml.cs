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
using ChessCore;

namespace ChessWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Pieces pieces;
        private Piece activePiece;
        private Button activeButton;
        public MainWindow()
        {
            InitializeComponent();
            pieces = new Pieces();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            if (activePiece == null && btn.Content == null)
            {
                CreatePiece(btn);
            }
            else if (activePiece == null)
            {
                ActivatePiece(btn);
            }
            else if (btn == activeButton)
            {
                InActivatePiece();
            }
            else
            {
                MovePiece(btn);
            }
        }

        private void ActivatePiece(Button btn)
        {
            btn.Background = Brushes.Blue;
            var x = Grid.GetColumn(btn);
            var y = Grid.GetRow(btn);
            activePiece = pieces.FindPiece(x, y);
            activeButton = btn;
        }

        private void InActivatePiece()
        {
            if ((Grid.GetRow(activeButton) + Grid.GetColumn(activeButton)) % 2 == 0)
            {
                activeButton.Background = Brushes.White;
            }
            else
            {
                activeButton.Background = Brushes.Black;
            }
            activeButton = null;
            activePiece = null;
        }

        private void MovePiece(Button btn)
        {
            try
            {
                var x = Grid.GetColumn(btn);
                var y = Grid.GetRow(btn);
                activePiece.Move(x, y);
                btn.Content = activeButton.Content;

                if (btn.Background == Brushes.Black)
                {
                    btn.Foreground = Brushes.White;
                }
                else
                {
                    btn.Foreground = Brushes.Black;
                }
                activeButton.Content = null;
                InActivatePiece();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreatePiece(Button btn)
        {
            var pieceCod = GetPieceCode();
            var x = Grid.GetColumn(btn);
            var y = Grid.GetRow(btn);
            pieces.Add(FigureFab.Make(pieceCod, x, y));

            btn.Content = pieceCod;
            if (btn.Background == Brushes.Black)
            {
                btn.Foreground = Brushes.White;
            }
            btn.Content = pieceCod;
        }

        private string GetPieceCode()
        {
            var comboBoxItem = (ComboBoxItem)Pieces.SelectedItem;
            var content = (TextBlock)comboBoxItem.Content;
            string pieceCode = content.Text;
            return pieceCode;
        }

        private void Button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var btn = (Button)sender;
            var x = Grid.GetColumn(btn);
            var y = Grid.GetRow(btn);

            if (btn == activeButton)
            {
                if ((Grid.GetRow(activeButton) + Grid.GetColumn(activeButton)) % 2 == 0)
                {
                    activeButton.Background = Brushes.White;
                }
                else
                {
                    activeButton.Background = Brushes.Black;
                }
                activeButton = null;
                activePiece = null;
            }

            btn.Content = null;

            int index = pieces.FindPieceIndex(x, y);
            if (index == -1)
            {
                MessageBox.Show("There is nothing on these coordinates");
            }
            else
            {
                pieces.RemoveAt(pieces.FindPieceIndex(x, y));
            }
        }
    }
}
