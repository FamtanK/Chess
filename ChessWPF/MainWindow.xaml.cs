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
        private List<Piece> pieces;
        public MainWindow()
        {
            InitializeComponent();
            pieces = new List<Piece>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            var piece = new Piece(1, 1);
            if (btn.Content == null)
            {
                piece = CreatePiece(btn);
            }
            else
            {
                btn.Background = Brushes.Blue; 
            }
        }

        private Piece CreatePiece(Button btn)
        {
            var pieceCod = GetPieceCode();
            var x = Grid.GetRow(btn);
            var y = Grid.GetColumn(btn);
            pieces.Add(FigureFab.Make(pieceCod, x, y));

            btn.Content = pieceCod;
            if (btn.Background == Brushes.Black)
            {
                btn.Foreground = Brushes.White;
            }
            btn.Content = pieceCod;
            return pieces.Last();
        }

        private string GetPieceCode()
        {
            var comboBoxItem = (ComboBoxItem)Pieces.SelectedItem;
            var content = (TextBlock)comboBoxItem.Content;
            string pieceCode = content.Text;
            return pieceCode;
        }
    }
}
