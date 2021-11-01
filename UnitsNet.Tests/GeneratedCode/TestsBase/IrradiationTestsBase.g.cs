//------------------------------------------------------------------------------
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
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.TestsBase;
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
    public abstract partial class IrradiationTestsBase : QuantityTestsBase
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
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Irradiation();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(IrradiationUnit.JoulePerSquareMeter, quantity.Unit);
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
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Irradiation(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new Irradiation(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (Irradiation) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void Irradiation_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Irradiation(1, IrradiationUnit.JoulePerSquareMeter);

            QuantityInfo<IrradiationUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Irradiation.Zero, quantityInfo.Zero);
            Assert.Equal("Irradiation", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<IrradiationUnit>().Except(new[] {IrradiationUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());
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
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Irradiation.From(1, IrradiationUnit.JoulePerSquareCentimeter);
            AssertEx.EqualTolerance(1, quantity00.JoulesPerSquareCentimeter, JoulesPerSquareCentimeterTolerance);
            Assert.Equal(IrradiationUnit.JoulePerSquareCentimeter, quantity00.Unit);

            var quantity01 = Irradiation.From(1, IrradiationUnit.JoulePerSquareMeter);
            AssertEx.EqualTolerance(1, quantity01.JoulesPerSquareMeter, JoulesPerSquareMeterTolerance);
            Assert.Equal(IrradiationUnit.JoulePerSquareMeter, quantity01.Unit);

            var quantity02 = Irradiation.From(1, IrradiationUnit.JoulePerSquareMillimeter);
            AssertEx.EqualTolerance(1, quantity02.JoulesPerSquareMillimeter, JoulesPerSquareMillimeterTolerance);
            Assert.Equal(IrradiationUnit.JoulePerSquareMillimeter, quantity02.Unit);

            var quantity03 = Irradiation.From(1, IrradiationUnit.KilojoulePerSquareMeter);
            AssertEx.EqualTolerance(1, quantity03.KilojoulesPerSquareMeter, KilojoulesPerSquareMeterTolerance);
            Assert.Equal(IrradiationUnit.KilojoulePerSquareMeter, quantity03.Unit);

            var quantity04 = Irradiation.From(1, IrradiationUnit.KilowattHourPerSquareMeter);
            AssertEx.EqualTolerance(1, quantity04.KilowattHoursPerSquareMeter, KilowattHoursPerSquareMeterTolerance);
            Assert.Equal(IrradiationUnit.KilowattHourPerSquareMeter, quantity04.Unit);

            var quantity05 = Irradiation.From(1, IrradiationUnit.MillijoulePerSquareCentimeter);
            AssertEx.EqualTolerance(1, quantity05.MillijoulesPerSquareCentimeter, MillijoulesPerSquareCentimeterTolerance);
            Assert.Equal(IrradiationUnit.MillijoulePerSquareCentimeter, quantity05.Unit);

            var quantity06 = Irradiation.From(1, IrradiationUnit.WattHourPerSquareMeter);
            AssertEx.EqualTolerance(1, quantity06.WattHoursPerSquareMeter, WattHoursPerSquareMeterTolerance);
            Assert.Equal(IrradiationUnit.WattHourPerSquareMeter, quantity06.Unit);

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
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new Irradiation(value: 1, unit: Irradiation.ConversionBaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (double) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
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
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = Irradiation.FromJoulesPerSquareMeter(1).ToBaseUnit();
            Assert.Equal(Irradiation.ConversionBaseUnit, quantityInBaseUnit.Unit);
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

#pragma warning disable CS8073
// ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
#pragma warning restore CS8073
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = Irradiation.FromJoulesPerSquareMeter(1);
            var b = Irradiation.FromJoulesPerSquareMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = Irradiation.FromJoulesPerSquareMeter(1);
            object b = Irradiation.FromJoulesPerSquareMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = Irradiation.FromJoulesPerSquareMeter(1);
            Assert.True(v.Equals(Irradiation.FromJoulesPerSquareMeter(1), JoulesPerSquareMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Irradiation.Zero, JoulesPerSquareMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = Irradiation.FromJoulesPerSquareMeter(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(Irradiation.FromJoulesPerSquareMeter(1), -1, ComparisonType.Relative));
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

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 J/cm²", new Irradiation(1, IrradiationUnit.JoulePerSquareCentimeter).ToString());
                Assert.Equal("1 J/m²", new Irradiation(1, IrradiationUnit.JoulePerSquareMeter).ToString());
                Assert.Equal("1 J/mm²", new Irradiation(1, IrradiationUnit.JoulePerSquareMillimeter).ToString());
                Assert.Equal("1 kJ/m²", new Irradiation(1, IrradiationUnit.KilojoulePerSquareMeter).ToString());
                Assert.Equal("1 kWh/m²", new Irradiation(1, IrradiationUnit.KilowattHourPerSquareMeter).ToString());
                Assert.Equal("1 mJ/cm²", new Irradiation(1, IrradiationUnit.MillijoulePerSquareCentimeter).ToString());
                Assert.Equal("1 Wh/m²", new Irradiation(1, IrradiationUnit.WattHourPerSquareMeter).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 J/cm²", new Irradiation(1, IrradiationUnit.JoulePerSquareCentimeter).ToString(swedishCulture));
            Assert.Equal("1 J/m²", new Irradiation(1, IrradiationUnit.JoulePerSquareMeter).ToString(swedishCulture));
            Assert.Equal("1 J/mm²", new Irradiation(1, IrradiationUnit.JoulePerSquareMillimeter).ToString(swedishCulture));
            Assert.Equal("1 kJ/m²", new Irradiation(1, IrradiationUnit.KilojoulePerSquareMeter).ToString(swedishCulture));
            Assert.Equal("1 kWh/m²", new Irradiation(1, IrradiationUnit.KilowattHourPerSquareMeter).ToString(swedishCulture));
            Assert.Equal("1 mJ/cm²", new Irradiation(1, IrradiationUnit.MillijoulePerSquareCentimeter).ToString(swedishCulture));
            Assert.Equal("1 Wh/m²", new Irradiation(1, IrradiationUnit.WattHourPerSquareMeter).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 J/m²", new Irradiation(0.123456, IrradiationUnit.JoulePerSquareMeter).ToString("s1"));
                Assert.Equal("0.12 J/m²", new Irradiation(0.123456, IrradiationUnit.JoulePerSquareMeter).ToString("s2"));
                Assert.Equal("0.123 J/m²", new Irradiation(0.123456, IrradiationUnit.JoulePerSquareMeter).ToString("s3"));
                Assert.Equal("0.1235 J/m²", new Irradiation(0.123456, IrradiationUnit.JoulePerSquareMeter).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 J/m²", new Irradiation(0.123456, IrradiationUnit.JoulePerSquareMeter).ToString("s1", culture));
            Assert.Equal("0.12 J/m²", new Irradiation(0.123456, IrradiationUnit.JoulePerSquareMeter).ToString("s2", culture));
            Assert.Equal("0.123 J/m²", new Irradiation(0.123456, IrradiationUnit.JoulePerSquareMeter).ToString("s3", culture));
            Assert.Equal("0.1235 J/m²", new Irradiation(0.123456, IrradiationUnit.JoulePerSquareMeter).ToString("s4", culture));
        }

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(Irradiation)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(IrradiationUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Equal(Irradiation.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Equal(Irradiation.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(1.0);
            Assert.Equal(new {Irradiation.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = Irradiation.FromJoulesPerSquareMeter(value);
            Assert.Equal(Irradiation.FromJoulesPerSquareMeter(-value), -quantity);
        }
    }
}
