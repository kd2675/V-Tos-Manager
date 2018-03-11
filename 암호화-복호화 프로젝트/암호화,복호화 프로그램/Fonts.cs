using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 암호화_복호화_프로그램
{
    public static class Fonts
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private static PrivateFontCollection Setting(byte[] fontData)
        {
            PrivateFontCollection fonts = new PrivateFontCollection();
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, fontData.Length);
            AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            return fonts;
        }
        public static Font SetFonts(byte[] fontData, float emSize = 10.0f)
        {
            PrivateFontCollection fonts = Setting(fontData);

            Font myFont = new Font(fonts.Families[0], emSize);
            return myFont;
        }
        public static Font SetFonts(byte[] fontData, float emSize, GraphicsUnit unit)
        {
            PrivateFontCollection fonts = Setting(fontData);

            Font myFont = new Font(fonts.Families[0], emSize, unit);
            return myFont;
        }
        public static Font SetFonts(byte[] fontData, float emSize, FontStyle style)
        {
            PrivateFontCollection fonts = Setting(fontData);

            Font myFont = new Font(fonts.Families[0], emSize, style);
            return myFont;
        }
        public static Font SetFonts(byte[] fontData, float emSize, FontStyle style, GraphicsUnit unit)
        {
            PrivateFontCollection fonts = Setting(fontData);

            Font myFont = new Font(fonts.Families[0], emSize, style, unit);
            return myFont;
        }
        public static Font SetFonts(byte[] fontData, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet)
        {
            PrivateFontCollection fonts = Setting(fontData);

            Font myFont = new Font(fonts.Families[0], emSize, style, unit, gdiCharSet);
            return myFont;
        }
        public static Font SetFonts(byte[] fontData, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet, bool gdiVerticalFont) {
            PrivateFontCollection fonts = Setting(fontData);

            Font myFont = new Font(fonts.Families[0], emSize, style, unit, gdiCharSet, gdiVerticalFont);
            return myFont;
        }
    }
}
