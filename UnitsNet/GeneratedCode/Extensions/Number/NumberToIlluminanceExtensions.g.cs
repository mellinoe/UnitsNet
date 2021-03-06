﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToIlluminance
{
    public static class NumberToIlluminanceExtensions
    {
        #region Kilolux

        /// <inheritdoc cref="Illuminance.FromKilolux(double)"/>
        public static Illuminance Kilolux(this int value) => Illuminance.FromKilolux(value);

        /// <inheritdoc cref="Illuminance.FromKilolux(double?)"/>
        public static Illuminance? Kilolux(this int? value) => Illuminance.FromKilolux(value);

        /// <inheritdoc cref="Illuminance.FromKilolux(double)"/>
        public static Illuminance Kilolux(this long value) => Illuminance.FromKilolux(value);

        /// <inheritdoc cref="Illuminance.FromKilolux(double?)"/>
        public static Illuminance? Kilolux(this long? value) => Illuminance.FromKilolux(value);

        /// <inheritdoc cref="Illuminance.FromKilolux(double)"/>
        public static Illuminance Kilolux(this double value) => Illuminance.FromKilolux(value);

        /// <inheritdoc cref="Illuminance.FromKilolux(double?)"/>
        public static Illuminance? Kilolux(this double? value) => Illuminance.FromKilolux(value);

        /// <inheritdoc cref="Illuminance.FromKilolux(double)"/>
        public static Illuminance Kilolux(this float value) => Illuminance.FromKilolux(value);

        /// <inheritdoc cref="Illuminance.FromKilolux(double?)"/>
        public static Illuminance? Kilolux(this float? value) => Illuminance.FromKilolux(value);

        /// <inheritdoc cref="Illuminance.FromKilolux(double)"/>
        public static Illuminance Kilolux(this decimal value) => Illuminance.FromKilolux(Convert.ToDouble(value));

        /// <inheritdoc cref="Illuminance.FromKilolux(double?)"/>
        public static Illuminance? Kilolux(this decimal? value) => Illuminance.FromKilolux(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Lux

        /// <inheritdoc cref="Illuminance.FromLux(double)"/>
        public static Illuminance Lux(this int value) => Illuminance.FromLux(value);

        /// <inheritdoc cref="Illuminance.FromLux(double?)"/>
        public static Illuminance? Lux(this int? value) => Illuminance.FromLux(value);

        /// <inheritdoc cref="Illuminance.FromLux(double)"/>
        public static Illuminance Lux(this long value) => Illuminance.FromLux(value);

        /// <inheritdoc cref="Illuminance.FromLux(double?)"/>
        public static Illuminance? Lux(this long? value) => Illuminance.FromLux(value);

        /// <inheritdoc cref="Illuminance.FromLux(double)"/>
        public static Illuminance Lux(this double value) => Illuminance.FromLux(value);

        /// <inheritdoc cref="Illuminance.FromLux(double?)"/>
        public static Illuminance? Lux(this double? value) => Illuminance.FromLux(value);

        /// <inheritdoc cref="Illuminance.FromLux(double)"/>
        public static Illuminance Lux(this float value) => Illuminance.FromLux(value);

        /// <inheritdoc cref="Illuminance.FromLux(double?)"/>
        public static Illuminance? Lux(this float? value) => Illuminance.FromLux(value);

        /// <inheritdoc cref="Illuminance.FromLux(double)"/>
        public static Illuminance Lux(this decimal value) => Illuminance.FromLux(Convert.ToDouble(value));

        /// <inheritdoc cref="Illuminance.FromLux(double?)"/>
        public static Illuminance? Lux(this decimal? value) => Illuminance.FromLux(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Megalux

        /// <inheritdoc cref="Illuminance.FromMegalux(double)"/>
        public static Illuminance Megalux(this int value) => Illuminance.FromMegalux(value);

        /// <inheritdoc cref="Illuminance.FromMegalux(double?)"/>
        public static Illuminance? Megalux(this int? value) => Illuminance.FromMegalux(value);

        /// <inheritdoc cref="Illuminance.FromMegalux(double)"/>
        public static Illuminance Megalux(this long value) => Illuminance.FromMegalux(value);

        /// <inheritdoc cref="Illuminance.FromMegalux(double?)"/>
        public static Illuminance? Megalux(this long? value) => Illuminance.FromMegalux(value);

        /// <inheritdoc cref="Illuminance.FromMegalux(double)"/>
        public static Illuminance Megalux(this double value) => Illuminance.FromMegalux(value);

        /// <inheritdoc cref="Illuminance.FromMegalux(double?)"/>
        public static Illuminance? Megalux(this double? value) => Illuminance.FromMegalux(value);

        /// <inheritdoc cref="Illuminance.FromMegalux(double)"/>
        public static Illuminance Megalux(this float value) => Illuminance.FromMegalux(value);

        /// <inheritdoc cref="Illuminance.FromMegalux(double?)"/>
        public static Illuminance? Megalux(this float? value) => Illuminance.FromMegalux(value);

        /// <inheritdoc cref="Illuminance.FromMegalux(double)"/>
        public static Illuminance Megalux(this decimal value) => Illuminance.FromMegalux(Convert.ToDouble(value));

        /// <inheritdoc cref="Illuminance.FromMegalux(double?)"/>
        public static Illuminance? Megalux(this decimal? value) => Illuminance.FromMegalux(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Millilux

        /// <inheritdoc cref="Illuminance.FromMillilux(double)"/>
        public static Illuminance Millilux(this int value) => Illuminance.FromMillilux(value);

        /// <inheritdoc cref="Illuminance.FromMillilux(double?)"/>
        public static Illuminance? Millilux(this int? value) => Illuminance.FromMillilux(value);

        /// <inheritdoc cref="Illuminance.FromMillilux(double)"/>
        public static Illuminance Millilux(this long value) => Illuminance.FromMillilux(value);

        /// <inheritdoc cref="Illuminance.FromMillilux(double?)"/>
        public static Illuminance? Millilux(this long? value) => Illuminance.FromMillilux(value);

        /// <inheritdoc cref="Illuminance.FromMillilux(double)"/>
        public static Illuminance Millilux(this double value) => Illuminance.FromMillilux(value);

        /// <inheritdoc cref="Illuminance.FromMillilux(double?)"/>
        public static Illuminance? Millilux(this double? value) => Illuminance.FromMillilux(value);

        /// <inheritdoc cref="Illuminance.FromMillilux(double)"/>
        public static Illuminance Millilux(this float value) => Illuminance.FromMillilux(value);

        /// <inheritdoc cref="Illuminance.FromMillilux(double?)"/>
        public static Illuminance? Millilux(this float? value) => Illuminance.FromMillilux(value);

        /// <inheritdoc cref="Illuminance.FromMillilux(double)"/>
        public static Illuminance Millilux(this decimal value) => Illuminance.FromMillilux(Convert.ToDouble(value));

        /// <inheritdoc cref="Illuminance.FromMillilux(double?)"/>
        public static Illuminance? Millilux(this decimal? value) => Illuminance.FromMillilux(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
