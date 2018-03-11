using System;
using System.Drawing;

namespace Steganography
{
    public static class SteganographyConvert
    {
        public delegate void ProgressEvent(long num);
        public static event ProgressEvent runEvent = null;

        public static Bitmap Encrypt(string text, Bitmap Imgbmp)
        {
            int charIndex = 0;
            int charValue = 0;
            long colorUnitIndex = 0;

            int R = 0, G = 0, B = 0;

            if (text.Length > Imgbmp.Height * Imgbmp.Width / 8)
            {
                throw new SteganographySizeException();
            }

            for (int i = 0; i < Imgbmp.Height; i++)
            {
                for (int j = 0; j < Imgbmp.Width; j++)
                {
                    Color pixel = Imgbmp.GetPixel(j, i);

                    pixel = Color.FromArgb(pixel.R - pixel.R % 2, pixel.G - pixel.G % 2, pixel.B - pixel.B % 2);
                    R = pixel.R; G = pixel.G; B = pixel.B;

                    for (int n = 0; n < 3; n++)
                    {
                        if (colorUnitIndex % 8 == 0)
                        {
                            if (charIndex < text.Length)
                            {
                                charValue = text[charIndex++];
                            }
                        }
                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                R += charValue % 2;
                                charValue /= 2;
                                break;
                            case 1:
                                G += charValue % 2;
                                charValue /= 2;
                                break;
                            case 2:
                                B += charValue % 2;
                                charValue /= 2;
                                break;
                        }
                        Imgbmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                        colorUnitIndex++;
                    }
                }
                runEvent?.Invoke(i + 1);
            }
            return Imgbmp;
        }

        public static string Decrypt(Bitmap Imgbmp)
        {
            int colorUnitIndex = 0;
            int charValue = 0;

            string ExtractedText = string.Empty;

            for (int i = 0; i < Imgbmp.Height; i++)
            {
                for (int j = 0; j < Imgbmp.Width; j++)
                {
                    Color pixel = Imgbmp.GetPixel(j, i);

                    for (int n = 0; n < 3; n++)
                    {
                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                charValue = charValue * 2 + pixel.R % 2;
                                break;
                            case 1:
                                charValue = charValue * 2 + pixel.G % 2;
                                break;
                            case 2:
                                charValue = charValue * 2 + pixel.B % 2;
                                break;
                        }
                        colorUnitIndex++;
                        if (colorUnitIndex % 8 == 0)
                        {
                            charValue = ReverseBits(charValue);
                            if (charValue == 0)
                            {
                                runEvent?.Invoke(Imgbmp.Height);
                                return ExtractedText;
                            }
                            char c = (char)charValue;
                            ExtractedText += c.ToString();
                        }
                    }
                }
                runEvent?.Invoke(i + 1);
            }
            return ExtractedText;
        }

        public static int ReverseBits(int n)
        {
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;
                n /= 2;
            }
            return result;
        }
    }
}
