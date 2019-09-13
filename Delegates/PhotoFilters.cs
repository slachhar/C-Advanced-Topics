﻿using System;

namespace Delegates
{
    public class PhotoFilters
    {
        public void Resize(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply Contrast");
        }

        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply Brightness");
        }
    }
}