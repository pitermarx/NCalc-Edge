using NUnit.Framework;

namespace NCalc.Tests
{
    [TestFixture]
    public class ImplicitDecimalCastTests
    {
        [Test]
        public void ShouldAddDoubleAndDecimal()
        {
            var e = new Expression("1.8 + Abs([var1])")
            {
                Parameters = {["var1"] = 9.2}
            };

            Assert.AreEqual(11M, e.Evaluate());
        }

        [Test]
        public void ShouldAddSingleAndDecimal()
        {
            var e = new Expression("[single] + [decimal]")
            {
                Parameters =
                {
                    ["single"] = 9.2f,
                    ["decimal"] = 1.8m
                }
            };

            Assert.AreEqual(11M, e.Evaluate());
        }

        [Test]
        public void ShouldAddDecimalAndDouble()
        {
            var e = new Expression("[decimal] + [double]")
            {
                Parameters =
                {
                    ["decimal"] = 1.8m,
                    ["double"] = 9.2
                }
            };

            Assert.AreEqual(11M, e.Evaluate());
        }

        [Test]
        public void ShouldAddDecimalAndSingle()
        {
            var e = new Expression("[decimal] + [single]")
            {
                Parameters =
                {
                    ["decimal"] = 1.8m,
                    ["single"] = 9.2f
                }
            };

            Assert.AreEqual(11M, e.Evaluate());
        }

        [Test]
        public void ShouldSubtractDecimalAndDouble()
        {
            var e = new Expression("[decimal] - [double]")
            {
                Parameters =
                {
                    ["decimal"] = 1.8m,
                    ["double"] = 9.2
                }
            };

            Assert.AreEqual(-7.4M, e.Evaluate());
        }

        [Test]
        public void ShouldSubtractDecimalAndSingle()
        {
            var e = new Expression("[decimal] - [single]")
            {
                Parameters =
                {
                    ["decimal"] = 1.8m,
                    ["single"] = 9.2f
                }
            };

            Assert.AreEqual(-7.4M, e.Evaluate());
        }

        [Test]
        public void ShouldSubtractDoubleAndDecimal()
        {
            var e = new Expression("[double] - [decimal]")
            {
                Parameters =
                {
                    ["double"] = 9.2,
                    ["decimal"] = 1.8m
                }
            };

            Assert.AreEqual(7.4M, e.Evaluate());
        }

        [Test]
        public void ShouldSubtractSingleAndDecimal()
        {
            var e = new Expression("[single] - [decimal]")
            {
                Parameters =
                {
                    ["single"] = 9.2f,
                    ["decimal"] = 1.8m
                }
            };

            Assert.AreEqual(7.4M, e.Evaluate());
        }

        [Test]
        public void ShouldMultiplyDecimalAndDouble()
        {
            var e = new Expression("[decimal] * [double]")
            {
                Parameters =
                {
                    ["decimal"] = 1.8m,
                    ["double"] = 9.2
                }
            };

            Assert.AreEqual(16.56M, e.Evaluate());
        }

        [Test]
        public void ShouldMultiplyDecimalAndSingle()
        {
            var e = new Expression("[decimal] * [single]")
            {
                Parameters =
                {
                    ["decimal"] = 1.8m,
                    ["single"] = 9.2f
                }
            };

            Assert.AreEqual(16.56M, e.Evaluate());
        }

        [Test]
        public void ShouldMultiplyDoubleAndDecimal()
        {
            var e = new Expression("[double] * [decimal]")
            {
                Parameters =
                {
                    ["double"] = 9.2,
                    ["decimal"] = 1.8m
                }
            };

            Assert.AreEqual(16.56M, e.Evaluate());
        }

        [Test]
        public void ShouldMultiplySingleAndDecimal()
        {
            var e = new Expression("[single] * [decimal]")
            {
                Parameters =
                {
                    ["single"] = 9.2f,
                    ["decimal"] = 1.8m
                }
            };

            Assert.AreEqual(16.56M, e.Evaluate());
        }

        [Test]
        public void ShouldDivideDoubleAndDecimal()
        {
            var e = new Expression("[double] / [decimal]")
            {
                Parameters =
                {
                    ["double"] = 9.2,
                    ["decimal"] = 1.6m
                }
            };

            Assert.AreEqual(5.75M, e.Evaluate());
        }

        [Test]
        public void ShouldDivideSingleAndDecimal()
        {
            var e = new Expression("[single] / [decimal]")
            {
                Parameters =
                {
                    ["single"] = 9.2f,
                    ["decimal"] = 1.6m
                }
            };

            Assert.AreEqual(5.75M, e.Evaluate());
        }

        [Test]
        public void ShouldDivideDecimalAndDouble()
        {
            var e = new Expression("[decimal] / [double]")
            {
                Parameters =
                {
                    ["decimal"] = 31.28m,
                    ["double"] = 9.2
                }
            };

            Assert.AreEqual(3.4m, e.Evaluate());
        }

        [Test]
        public void ShouldDivideDecimalAndSingle()
        {
            var e = new Expression("[decimal] / [single]")
            {
                Parameters =
                {
                    ["decimal"] = 31.28m,
                    ["single"] = 9.2f
                }
            };

            Assert.AreEqual(3.4m, e.Evaluate());
        }

        [Test]
        public void ShouldModuloDecimalAndDouble()
        {
            var e = new Expression("[decimal] % [double]")
            {
                Parameters =
                {
                    ["decimal"] = 31.40m,
                    ["double"] = 9.2
                }
            };

            Assert.AreEqual(3.8m, e.Evaluate());
        }

        [Test]
        public void ShouldModuloDecimalAndSingle()
        {
            var e = new Expression("[decimal] % [single]")
            {
                Parameters =
                {
                    ["decimal"] = 31.40m,
                    ["single"] = 9.2f
                }
            };

            Assert.AreEqual(3.8m, e.Evaluate());
        }

        [Test]
        public void ShouldModuloDoubleAndDecimal()
        {
            var e = new Expression("[double] % [decimal]")
            {
                Parameters =
                {
                    ["double"] = 31.4,
                    ["decimal"] = 9.2m
                }
            };

            Assert.AreEqual(3.8m, e.Evaluate());
        }

        [Test]
        public void ShouldModuloSingleAndDecimal()
        {
            var e = new Expression("[single] % [decimal]")
            {
                Parameters =
                {
                    ["single"] = 31.40f,
                    ["decimal"] = 9.2m
                }
            };

            Assert.AreEqual(3.8m, e.Evaluate());
        }
    }
}