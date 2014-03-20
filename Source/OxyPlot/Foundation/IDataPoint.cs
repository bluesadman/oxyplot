﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDataPoint.cs" company="OxyPlot">
//   The MIT License (MIT)
//   
//   Copyright (c) 2012 Oystein Bjorke
//   
//   Permission is hereby granted, free of charge, to any person obtaining a
//   copy of this software and associated documentation files (the
//   "Software"), to deal in the Software without restriction, including
//   without limitation the rights to use, copy, modify, merge, publish,
//   distribute, sublicense, and/or sell copies of the Software, and to
//   permit persons to whom the Software is furnished to do so, subject to
//   the following conditions:
//   
//   The above copyright notice and this permission notice shall be included
//   in all copies or substantial portions of the Software.
//   
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
//   OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
//   MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
//   IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
//   CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
//   TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
//   SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary>
//   DataPoint interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OxyPlot
{
    /// <summary>
    /// Defines a point.
    /// </summary>
    public interface IDataPoint
    {
        /// <summary>
        /// Gets or sets the x-coordinate.
        /// </summary>
        /// <value>The x-coordinate.</value>
        double X { get; set; }

        /// <summary>
        /// Gets or sets the y-coordinate.
        /// </summary>
        /// <value>The y-coordinate.</value>
        double Y { get; set; }
    }

    /// <summary>
    /// Provides extension methods for <see cref="IDataPoint"/>.
    /// </summary>
    public static class DataPointExtensions
    {
        /// <summary>
        /// Returns whether the coordinate contains a NaN value.
        /// </summary>
        /// <param name="p">The point to evaluate.</param>
        /// <returns><value>true</value> if neither the X nor Y coordinates are NaN values; otherwise, <value>false</value>.</returns>
        public static bool IsValid(this IDataPoint p)
        {
            return !double.IsNaN(p.X) && !double.IsNaN(p.Y);
        }
    }
}