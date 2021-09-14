﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Shape : IDraw
    {
        protected virtual IList<Point> Locus { get; init; } = new List<Point>();

        public void Draw()
        {
            foreach (Point point in Locus)
            {
                point.Draw();
            }
        }
    }
}