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
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of Irradiation.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class IrradiationTestsBase
    {
        protected abstract double JoulesPerSquareCentimeterInOneJoulePerSquareMeter { get; }
        protected abstract double JoulesPerSquareMeterInOneJoulePerSquareMeter { get; }
        protected abstract double JoulesPerSquareMillimeterInOneJoulePerSquareMeter { get; }
        protected abstract double KilojoulesPerSquareMeterInOneJoulePerSquareMeter { get; }
        protected abstract double KilowattHoursPerSquareMeterInOneJoulePerSquareMeter { get; }
        protected abstract double MillijoulesPerSquareCentimeterInOneJoulePerSquareMeter { get; }
        protected abstract double WattHoursPerSquareMeterInOneJoulePerSquareMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double JoulesPerSquareCentimeterTolerance { get { return 1e-5; } }
        protected virtual double JoulesPerSquareMeterTolerance { get { return 1e-5; } }
        protected virtual double JoulesPerSquareMillimeterTolerance { get { return 1e-5; } }
        protected virtual double KilojoulesPerSquareMeterTolerance { get { return 1e-5; } }
        protected virtual double KilowattHoursPerSquareMeterTolerance { get { return 1e-5; } }
        protected virtual double MillijoulesPerSquareCentimeterTolerance { get { return 1e-5; } }
        protected virtual double WattHoursPerSquareMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Irradiation((double)0.0, IrradiationUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Irradiation(double.PositiveInfinity, IrradiationUnit.JoulePerSquareMeter));
            Assert.Throws<ArgumentException>(() => new Irradiation(double.NegativeInfinity, IrradiationUnit.JoulePerSquareMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Irradiation(double.NaN, IrradiationUnit.JoulePerSquareMeter));
        }

        [Fact]
        public void JoulePerSquareMeterToIrradiationUnits()
        {
            Irradiation joulepersquaremeter = Irradiation.FromJoulesPerSquareMeter(1);
            AssertEx.EqualTolerance(JoulesPerSquareCentimeterInOneJoulePerSquareMeter, joulepersquaremeter.JoulesPerSquareCentimeter, JoulesPerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(JoulesPerSquareMeterInOneJoulePerSquareMeter, joulepersquaremeter.JoulesPerSquareMeter, JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(JoulesPerSquareMillimeterInOneJoulePerSquareMeter, joulepersquaremeter.JoulesPerSquareMillimeter, JoulesPerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(KilojoulesPerSquareMeterInOneJoulePerSquareMeter, joulepersquaremeter.KilojoulesPerSquareMeter, KilojoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(KilowattHoursPerSquareMeterInOneJoulePerSquareMeter, joulepersquaremeter.KilowattHoursPerSquareMeter, KilowattHoursPerSquareMeterTolerance);
            AssertEx.EqualTolerance(MillijoulesPerSquareCentimeterInOneJoulePerSquareMeter, joulepersquaremeter.MillijoulesPerSquareCentimeter, MillijoulesPerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(WattHoursPerSquareMeterInOneJoulePerSquareMeter, joulepersquaremeter.WattHoursPerSquareMeter, WattHoursPerSquareMeterTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Irradiation.From(1, IrradiationUnit.JoulePerSquareCentimeter).JoulesPerSquareCentimeter, JoulesPerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(1, Irradiation.From(1, IrradiationUnit.JoulePerSquareMeter).JoulesPerSquareMeter, JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Irradiation.From(1, IrradiationUnit.JoulePerSquareMillimeter).JoulesPerSquareMillimeter, JoulesPerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(1, Irradiation.From(1, IrradiationUnit.KilojoulePerSquareMeter).KilojoulesPerSquareMeter, KilojoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Irradiation.From(1, IrradiationUnit.KilowattHourPerSquareMeter).KilowattHoursPerSquareMeter, KilowattHoursPerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Irradiation.From(1, IrradiationUnit.MillijoulePerSquareCentimeter).MillijoulesPerSquareCentimeter, MillijoulesPerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(1, Irradiation.From(1, IrradiationUnit.WattHourPerSquareMeter).WattHoursPerSquareMeter, WattHoursPerSquareMeterTolerance);
        }

        [Fact]
        public void FromJoulesPerSquareMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Irradiation.FromJoulesPerSquareMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Irradiation.FromJoulesPerSquareMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromJoulesPerSquareMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Irradiation.FromJoulesPerSquareMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var joulepersquaremeter = Irradiation.FromJoulesPerSquareMeter(1);
            AssertEx.EqualTolerance(JoulesPerSquareCentimeterInOneJoulePerSquareMeter, joulepersquaremeter.As(IrradiationUnit.JoulePerSquareCentimeter), JoulesPerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(JoulesPerSquareMeterInOneJoulePerSquareMeter, joulepersquaremeter.As(IrradiationUnit.JoulePerSquareMeter), JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(JoulesPerSquareMillimeterInOneJoulePerSquareMeter, joulepersquaremeter.As(IrradiationUnit.JoulePerSquareMillimeter), JoulesPerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(KilojoulesPerSquareMeterInOneJoulePerSquareMeter, joulepersquaremeter.As(IrradiationUnit.KilojoulePerSquareMeter), KilojoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(KilowattHoursPerSquareMeterInOneJoulePerSquareMeter, joulepersquaremeter.As(IrradiationUnit.KilowattHourPerSquareMeter), KilowattHoursPerSquareMeterTolerance);
            AssertEx.EqualTolerance(MillijoulesPerSquareCentimeterInOneJoulePerSquareMeter, joulepersquaremeter.As(IrradiationUnit.MillijoulePerSquareCentimeter), MillijoulesPerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(WattHoursPerSquareMeterInOneJoulePerSquareMeter, joulepersquaremeter.As(IrradiationUnit.WattHourPerSquareMeter), WattHoursPerSquareMeterTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var joulepersquaremeter = Irradiation.FromJoulesPerSquareMeter(1);

            var joulepersquarecentimeterQuantity = joulepersquaremeter.ToUnit(IrradiationUnit.JoulePerSquareCentimeter);
            AssertEx.EqualTolerance(JoulesPerSquareCentimeterInOneJoulePerSquareMeter, (double)joulepersquarecentimeterQuantity.Value, JoulesPerSquareCentimeterTolerance);
            Assert.Equal(IrradiationUnit.JoulePerSquareCentimeter, joulepersquarecentimeterQuantity.Unit);

            var joulepersquaremeterQuantity = joulepersquaremeter.ToUnit(IrradiationUnit.JoulePerSquareMeter);
            AssertEx.EqualTolerance(JoulesPerSquareMeterInOneJoulePerSquareMeter, (double)joulepersquaremeterQuantity.Value, JoulesPerSquareMeterTolerance);
            Assert.Equal(IrradiationUnit.JoulePerSquareMeter, joulepersquaremeterQuantity.Unit);

            var joulepersquaremillimeterQuantity = joulepersquaremeter.ToUnit(IrradiationUnit.JoulePerSquareMillimeter);
            AssertEx.EqualTolerance(JoulesPerSquareMillimeterInOneJoulePerSquareMeter, (double)joulepersquaremillimeterQuantity.Value, JoulesPerSquareMillimeterTolerance);
            Assert.Equal(IrradiationUnit.JoulePerSquareMillimeter, joulepersquaremillimeterQuantity.Unit);

            var kilojoulepersquaremeterQuantity = joulepersquaremeter.ToUnit(IrradiationUnit.KilojoulePerSquareMeter);
            AssertEx.EqualTolerance(KilojoulesPerSquareMeterInOneJoulePerSquareMeter, (double)kilojoulepersquaremeterQuantity.Value, KilojoulesPerSquareMeterTolerance);
            Assert.Equal(IrradiationUnit.KilojoulePerSquareMeter, kilojoulepersquaremeterQuantity.Unit);

            var kilowatthourpersquaremeterQuantity = joulepersquaremeter.ToUnit(IrradiationUnit.KilowattHourPerSquareMeter);
            AssertEx.EqualTolerance(KilowattHoursPerSquareMeterInOneJoulePerSquareMeter, (double)kilowatthourpersquaremeterQuantity.Value, KilowattHoursPerSquareMeterTolerance);
            Assert.Equal(IrradiationUnit.KilowattHourPerSquareMeter, kilowatthourpersquaremeterQuantity.Unit);

            var millijoulepersquarecentimeterQuantity = joulepersquaremeter.ToUnit(IrradiationUnit.MillijoulePerSquareCentimeter);
            AssertEx.EqualTolerance(MillijoulesPerSquareCentimeterInOneJoulePerSquareMeter, (double)millijoulepersquarecentimeterQuantity.Value, MillijoulesPerSquareCentimeterTolerance);
            Assert.Equal(IrradiationUnit.MillijoulePerSquareCentimeter, millijoulepersquarecentimeterQuantity.Unit);

            var watthourpersquaremeterQuantity = joulepersquaremeter.ToUnit(IrradiationUnit.WattHourPerSquareMeter);
            AssertEx.EqualTolerance(WattHoursPerSquareMeterInOneJoulePerSquareMeter, (double)watthourpersquaremeterQuantity.Value, WattHoursPerSquareMeterTolerance);
            Assert.Equal(IrradiationUnit.WattHourPerSquareMeter, watthourpersquaremeterQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Irradiation joulepersquaremeter = Irradiation.FromJoulesPerSquareMeter(1);
            AssertEx.EqualTolerance(1, Irradiation.FromJoulesPerSquareCentimeter(joulepersquaremeter.JoulesPerSquareCentimeter).JoulesPerSquareMeter, JoulesPerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(1, Irradiation.FromJoulesPerSquareMeter(joulepersquaremeter.JoulesPerSquareMeter).JoulesPerSquareMeter, JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Irradiation.FromJoulesPerSquareMillimeter(joulepersquaremeter.JoulesPerSquareMillimeter).JoulesPerSquareMeter, JoulesPerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(1, Irradiation.FromKilojoulesPerSquareMeter(joulepersquaremeter.KilojoulesPerSquareMeter).JoulesPerSquareMeter, KilojoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Irradiation.FromKilowattHoursPerSquareMeter(joulepersquaremeter.KilowattHoursPerSquareMeter).JoulesPerSquareMeter, KilowattHoursPerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Irradiation.FromMillijoulesPerSquareCentimeter(joulepersquaremeter.MillijoulesPerSquareCentimeter).JoulesPerSquareMeter, MillijoulesPerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(1, Irradiation.FromWattHoursPerSquareMeter(joulepersquaremeter.WattHoursPerSquareMeter).JoulesPerSquareMeter, WattHoursPerSquareMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Irradiation v = Irradiation.FromJoulesPerSquareMeter(1);
            AssertEx.EqualTolerance(-1, -v.JoulesPerSquareMeter, JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (Irradiation.FromJoulesPerSquareMeter(3)-v).JoulesPerSquareMeter, JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).JoulesPerSquareMeter, JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).JoulesPerSquareMeter, JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).JoulesPerSquareMeter, JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (Irradiation.FromJoulesPerSquareMeter(10)/5).JoulesPerSquareMeter, JoulesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, Irradiation.FromJoulesPerSquareMeter(10)/Irradiation.FromJoulesPerSquareMeter(5), JoulesPerSquareMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Irradiation oneJoulePerSquareMeter = Irradiation.FromJoulesPerSquareMeter(1);
            Irradiation twoJoulesPerSquareMeter = Irradiation.FromJoulesPerSquareMeter(2);

            Assert.True(oneJoulePerSquareMeter < twoJoulesPerSquareMeter);
            Assert.True(oneJoulePerSquareMeter <= twoJoulesPerSquareMeter);
            Assert.True(twoJoulesPerSquareMeter > oneJoulePerSquareMeter);
            Assert.True(twoJoulesPerSquareMeter >= oneJoulePerSquareMeter);

            Assert.False(oneJoulePerSquareMeter > twoJoulesPerSquareMeter);
            Assert.False(oneJoulePerSquareMeter >= twoJoulesPerSquareMeter);
            Assert.False(twoJoulesPerSquareMeter < oneJoulePerSquareMeter);
            Assert.False(twoJoulesPerSquareMeter <= oneJoulePerSquareMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Irradiation joulepersquaremeter = Irradiation.FromJoulesPerSquareMeter(1);
            Assert.Equal(0, joulepersquaremeter.CompareTo(joulepersquaremeter));
            Assert.True(joulepersquaremeter.CompareTo(Irradiation.Zero) > 0);
            Assert.True(Irradiation.Zero.CompareTo(joulepersquaremeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Irradiation joulepersquaremeter = Irradiation.FromJoulesPerSquareMeter(1);
            Assert.Throws<ArgumentException>(() => joulepersquaremeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Irradiation joulepersquaremeter = Irradiation.FromJoulesPerSquareMeter(1);
            Assert.Throws<ArgumentNullException>(() => joulepersquaremeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Irradiation.FromJoulesPerSquareMeter(1);
            var b = Irradiation.FromJoulesPerSquareMeter(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            var a = Irradiation.FromJoulesPerSquareMeter(1);
            var b = Irradiation.FromJoulesPerSquareMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = Irradiation.FromJoulesPerSquareMeter(1);
            Assert.True(v.Equals(Irradiation.FromJoulesPerSquareMeter(1), JoulesPerSquareMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Irradiation.Zero, JoulesPerSquareMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Irradiation joulepersquaremeter = Irradiation.FromJoulesPerSquareMeter(1);
            Assert.False(joulepersquaremeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Irradiation joulepersquaremeter = Irradiation.FromJoulesPerSquareMeter(1);
            Assert.False(joulepersquaremeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(IrradiationUnit.Undefined, Irradiation.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(IrradiationUnit)).Cast<IrradiationUnit>();
            foreach(var unit in units)
            {
                if(unit == IrradiationUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Irradiation.BaseDimensions is null);
        }
    }
}