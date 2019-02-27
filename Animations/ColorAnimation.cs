﻿using System;
using System.Drawing;

namespace Arc.YTSubConverter.Animations
{
    internal abstract class ColorAnimation : Animation
    {
        protected ColorAnimation(DateTime startTime, Color startColor, DateTime endTime, Color endColor)
            : base(startTime, endTime)
        {
            StartColor = startColor;
            EndColor = endColor;
        }

        public Color StartColor
        {
            get;
            set;
        }

        public Color EndColor
        {
            get;
            set;
        }

        protected Color GetColor(float t)
        {
            return Interpolate(StartColor, EndColor, t);
        }
    }
}
