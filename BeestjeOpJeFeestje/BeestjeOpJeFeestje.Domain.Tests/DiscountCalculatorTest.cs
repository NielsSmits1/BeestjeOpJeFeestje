// <copyright file="DiscountCalculatorTest.cs">Copyright ©  2019</copyright>

using System;
using BeestjeOpJeFeestje.Domain;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BeestjeOpJeFeestje.Domain.Tests
{
    [TestClass]
    [PexClass(typeof(DiscountCalculator))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DiscountCalculatorTest
    {

        [PexMethod]
        public Discount DateDiscount([PexAssumeUnderTest]DiscountCalculator target, DateTime date)
        {
            Discount result = target.DateDiscount(date);
            return result;
            // TODO: add assertions to method DiscountCalculatorTest.DateDiscount(DiscountCalculator, DateTime)
        }
    }
}
