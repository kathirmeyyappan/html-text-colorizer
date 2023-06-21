using System;
using System.Drawing;
using System.Collections.Generic;

namespace TextColorizer
{
    public class InputText
    {
        string Text;
        private static Color[] rainbow = {
            Color.FromArgb(148, 0, 211),
            Color.FromArgb(75, 0, 130),
            Color.FromArgb(0, 0, 255),
            Color.FromArgb(0, 255, 0),
            Color.FromArgb(255, 255, 0),
            Color.FromArgb(255, 127, 0),
            Color.FromArgb(255, 0, 0)
        };

        public InputText(string text)
        {
            this.Text = text;
        }

        public string GetRainbowAltHTML()
        {
            // Creating Alternating Rainbow HTML blurb
            string htmlBlurb = "";
            int space_inc = 0;
            for (int i = 0; i < this.Text.Length; i++)
            {
                char c = this.Text[i];
                if (c == ' ')
                    space_inc --;
                string hex = ColorTranslator.ToHtml(rainbow[(i + space_inc) % 7]);
                htmlBlurb += $"<span style=\"color:{hex}\">{c}</span>";
            }

            return htmlBlurb;
        }

        public string GetCustomAltHTML(List<Color> colors)
        {
            // creating custom alternating HTML blurb
            string htmlBlurb = "";
            int space_inc = 0;
            for (int i = 0; i < this.Text.Length; i++)
            {
                char c = this.Text[i];
                if (c == ' ')
                    space_inc--;
                string hex = ColorTranslator.ToHtml(colors[
                    (i + space_inc) % colors.Count]);
                htmlBlurb += $"<span style=\"color:{hex}\">{c}</span>";
            }

            return htmlBlurb;
        }

        private string TwoColorShift(string textpiece, Color color1, Color color2)
        {
            // start/end points for linear interpolation
            int[] startRGB = new int[] { color1.R, color1.G, color1.B };
            int[] endRGB = new int[] { color2.R, color2.G, color2.B };

            // creating array for color interpolation
            int[,] colorAssign = new int[textpiece.Length, 3];

            // doing linear interpolation on array representation of colors
            for (int i = 0; i < textpiece.Length; i++)
            {
                for (int c = 0; c < 3; c++)
                {
                    colorAssign[i, c] = startRGB[c] + (endRGB[c] - startRGB[c]) *
                        i / (textpiece.Length - 1);
                }
            }

            // converting to Color type and making into Color[] array
            var colors = new Color[textpiece.Length];
            for (int i = 0; i < textpiece.Length; i++)
            {
                colors[i] = Color.FromArgb(colorAssign[i, 0], 
                    colorAssign[i, 1], colorAssign[i, 2]);
            }

            // creating shifted HTML blurb
            string pieceBlurb = "";
            for (int i = 0; i < textpiece.Length; i++)
            {
                char c = textpiece[i];
                string hex = ColorTranslator.ToHtml(colors[i]);
                pieceBlurb += $"<span style=\"color:{hex}\">{c}</span>";
            }

            return pieceBlurb;
        }

        public string GetCustomShiftHTML(List<Color> colors)
        {
            // returning alt version if char count is too low
            if (this.Text.Length < colors.Count)
            {
                return GetCustomAltHTML(colors);
            }

            string shiftedHTML = "";
            for (int i = 0; i < colors.Count - 1; i++)
            {
                // find indices
                int start = i * this.Text.Length / (colors.Count - 1);
                int end = (i + 1) * this.Text.Length / (colors.Count - 1);
                int piece_len = i == colors.Count - 2 ? end - start : end - start + 1;

                // get string piece, do interpolation, and append to final result
                string textPiece = this.Text.Substring(start, piece_len);
                string uncutHTML = TwoColorShift(textPiece, colors[i], colors[i + 1]);
                shiftedHTML += i == colors.Count - 2 ? uncutHTML : 
                    uncutHTML.Substring(0, uncutHTML.Length - 36);
            }

            return shiftedHTML;
        }

        public string GetRainbowShiftHTML()
        {
            // returning alt version if char count is too low
            if (this.Text.Length < 7)
            {
                return GetRainbowAltHTML();
            }

            string shiftedHTML = "";
            for (int i = 0; i < 6; i++)
            {
                // find indices
                int start = i * this.Text.Length / 6;
                int end = (i + 1) * this.Text.Length / 6;
                int piece_len = i == 5 ? end - start : end - start + 1;

                // get string piece, do interpolation, and append to final result
                string textPiece = this.Text.Substring(start, piece_len);
                string uncutHTML = TwoColorShift(textPiece, rainbow[i], rainbow[i + 1]);
                shiftedHTML += i == 5 ? uncutHTML : uncutHTML.Substring(0, uncutHTML.Length - 36);
            }

            return shiftedHTML;
        }
    }

}