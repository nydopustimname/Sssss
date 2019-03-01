﻿
using System;
using System.Drawing;

namespace ii_dinahyi_
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = Perfect.ColorFromImg("odin.jpg", 1);
            var t =ObjToAnother.GetBitmapFromArr(l, 160);

            t.Save(@"C:\Users\xoxo\Desktop\he.jpg");

            var h =ObjToAnother.GetArrFromBMP(t);
            var hh = Perfect.MedianFilter(h);
            var cut = Perfect.CuteFunction(hh);
            var miniimg =ObjToAnother.GetBitmapFromArr(cut, 1);

            miniimg.Save(@"C:\Users\xoxo\Desktop\mini.jpg");

            Bitmap ArrFrame = new Bitmap(miniimg, new Size (50,50));

            ArrFrame.Save(@"C:\Users\xoxo\Desktop\Frame.jpg");
        }
    }
}

//TODO: ColorFromImg Black/White insted RGB
//TODO: DEL EBANYU MakeAPerfect!!! It's Kostil!
//TODO: 
//TODO: 