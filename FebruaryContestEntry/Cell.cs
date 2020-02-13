using System;

namespace FebruaryContestEntry
{
    public class Cell
    {
        public ConsoleColor BackgroundColor { get; set; }
        public ConsoleColor ForegroundColor { get; set; }
        private char _content = '▓';

        public char Content
        {
            get => _content;
            set => _content = value;
        }
    }
}