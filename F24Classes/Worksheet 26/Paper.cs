using System;
using System.Collections.Generic;
using System.Text;
using WorkSheets.Interfaces;


namespace WorkSheets.Worksheet_26
{
        public class Paper 
        {
            public void Write(string content, IWritingUtensil utensil)
            {
                if (LastContent.Text != string.Empty) PaperContent.Add(LastContent);
                LastContent = new PaperContent(content, (utensil is IErasable));
            }

            public void Erase()
            {
                if (LastContent.IsErasable) LastContent = new PaperContent(string.Empty, true);
            }

            public void DisplayText()
            {
                Console.Clear();
                foreach (var cont in PaperContent)
                {
                    Console.ForegroundColor = cont.Color;
                    Console.WriteLine(cont.Text);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (LastContent.Text != string.Empty)
                {
                    Console.ForegroundColor = LastContent.Color;
                    Console.WriteLine(LastContent.Text);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            public List<PaperContent> PaperContent { get; set; }
            public PaperContent LastContent { get; set; }

            public Paper()
            {
                PaperContent = new List<PaperContent>();
                LastContent = new PaperContent(string.Empty, true);
            }

        }

        public struct PaperContent
        {
            public string Text { get; }
            public ConsoleColor Color { get; }
            public bool IsErasable { get; }

            public PaperContent(string text, ConsoleColor color, bool isErasable)
            {
                Text = text;
                Color = color;
                IsErasable = isErasable;
            }

            public PaperContent(string text, bool isErasable)
            {
                Text = text;
                Color = ConsoleColor.White;
                IsErasable = isErasable;
            }
        }

}
