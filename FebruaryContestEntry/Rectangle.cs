using System;

namespace FebruaryContestEntry
{
    public class Rectangle
    {
        private int _width;
        private int _height;
        private Cell[,] _matrix;

        public Rectangle()
        {
        }

        #region Public method
        public Rectangle Width(int width)
        {
            _width = width;
            return this;
        }
        
        public Rectangle Height(int height)
        {
            _height = height;
            return this;
        }

        public Rectangle BuildRectangle()
        {
            _matrix = new Cell[_width, _height];
            return this;
        }

        public Rectangle FillRectangle()
        {
            for(var row = 0; row < _width; row++) 
            {
                for (var col = 0; col < _height; col++)
                {
					var cell = new Cell();
                    if (IsBorderLine(row, col))
                    {
                        FillColorBorderLine(cell);
                    }
                    else
                    {
                        FillColorContent(cell);
                    }

                    _matrix[row, col] = cell;
                }
            }

            return this;
        }

        public Rectangle ShowRectangleColor()
        {
            for(var row = 0; row < _width; row++) 
            {
                for (var col = 0; col < _height; col++)
                {
                    var cell = _matrix[row, col];
                    Console.BackgroundColor = cell.BackgroundColor;
                    Console.ForegroundColor = cell.ForegroundColor;
                    Console.Write(cell.Content);
                }
                Console.ResetColor();
                Console.WriteLine();
            }

            return this;
        }
        #endregion

        #region Private Methods
        private bool IsBorderLine(int row, int column)
        {
            return (row == 0 || row == (_width - 1) || column == 0 || column == (_height - 1));
        }
        
        private void FillColorBorderLine(Cell cell)
        {
            cell.BackgroundColor = ConsoleColor.DarkGreen;
            cell.ForegroundColor = ConsoleColor.DarkGreen;
        }

        private void FillColorContent(Cell cell)
        {
            cell.BackgroundColor = ConsoleColor.Yellow;
            cell.ForegroundColor = ConsoleColor.Yellow;
        }
        #endregion
    }
}
