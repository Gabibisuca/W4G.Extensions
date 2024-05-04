using System.Globalization;
using W4G.Extensions;

namespace W4G.Test
{
    [TestClass]
    public class ToExtensionValueTest
    {
        public ToExtensionValueTest()
        {
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
        }

        [TestMethod]
        public void ToExtension()
        {
            long value = 0;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("zero", result);
        }

        [TestMethod]
        public void ToExtensionNegative()
        {
            long value = -1239;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("menos mil e duzentos e trinta e nove", result);
        }

        [TestMethod]
        public void ToExtensionPositive()
        {
            long value = 123456789;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("cento e vinte e tr�s milh�es e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove", result);
        }

        [TestMethod]
        public void ToExtensionHundred()
        {
            long value = 100;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("cem", result);
        }

        [TestMethod]
        public void ToExtension2582()
        {
            long value = 2582;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("dois mil e quinhentos e oitenta e dois", result);
        }

        [TestMethod]
        public void ToExtensionThousand()
        {
            long value = 1000;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("mil", result);
        }
        [TestMethod]
        public void ToExtensionMillion()
        {
            long value = 1000000;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("um milh�o", result);
        }

        [TestMethod]
        public void ToExtensionBillion()
        {
            long value = 1000000000;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("um bilh�o", result);
        }

        [TestMethod]
        public void ToExtensionTrillion()
        {
            long value = 1000000000000;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("um trilh�o", result);
        }

        [TestMethod]
        public void ToExtensionQuadrillion()
        {
            long value = 1000000000000000;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("um quadrilh�o", result);
        }

        [TestMethod]
        public void ToExtensionQuintillion()
        {
            long value = 1000000000000000000;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("um quintilh�o", result);
        }

        [TestMethod]
        public void IntToExtension()
        {
            int value = 123456789;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("cento e vinte e tr�s milh�es e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove", result);
        }

        [TestMethod]
        public void Double()
        {
            Assert.AreEqual("zero v�rgula um d�cimo", 0.1.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula um cent�simo", 0.01.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula um mil�simo", 0.001.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula um d�cimo de mil�simo", 0.0001.ToExtensionValueBR());
            Assert.AreEqual("um v�rgula um cent�simo de mil�simo", 1.00001.ToExtensionValueBR());
            Assert.AreEqual("doze v�rgula um milion�simo", 12.000001.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula cento e vinte e tr�s d�cimos de mil�simos", 0.0123.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula mil e duzentos e trinta e quatro milion�simos", 0.001234.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula doze cent�simos", 0.12.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula cento e vinte e tr�s mil�simos", 0.123.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula mil e duzentos e trinta e quatro d�cimos de mil�simos", 0.1234.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula doze mil e trezentos e quarenta e cinco cent�simos de mil�simos", 0.12345.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula cento e vinte e tr�s mil e quatrocentos e cinquenta e seis milion�simos", 0.123456.ToExtensionValueBR());
        }

        [TestMethod]
        public void Decimal()
        {
            Assert.AreEqual("zero v�rgula um d�cimo", 0.1m.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula um cent�simo", 0.01m.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula um mil�simo", 0.001m.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula um d�cimo de mil�simo", 0.0001m.ToExtensionValueBR());
            Assert.AreEqual("um v�rgula um cent�simo de mil�simo", 1.00001m.ToExtensionValueBR());
            Assert.AreEqual("doze v�rgula um milion�simo", 12.000001m.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula cento e vinte e tr�s d�cimos de mil�simos", 0.0123m.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula mil e duzentos e trinta e quatro milion�simos", 0.001234m.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula doze cent�simos", 0.12m.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula cento e vinte e tr�s mil�simos", 0.123m.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula mil e duzentos e trinta e quatro d�cimos de mil�simos", 0.1234m.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula doze mil e trezentos e quarenta e cinco cent�simos de mil�simos", 0.12345m.ToExtensionValueBR());
            Assert.AreEqual("zero v�rgula cento e vinte e tr�s mil e quatrocentos e cinquenta e seis milion�simos", 0.123456m.ToExtensionValueBR());
        }

        [TestMethod]
        public void DecimalToExtension()
        {
            decimal value = 123456789.123456789m;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("cento e vinte e tr�s milh�es e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove v�rgula cento e vinte e tr�s milh�es e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove bilion�simos", result);
        }

        [TestMethod]
        public void DecimalToExtensionNoPopular()
        {
            decimal value = 123456789.123456789m;

            var result = value.ToExtensionValueBR(false);

            Assert.AreEqual("cento e vinte e tr�s milh�es e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove inteiros e cento e vinte e tr�s milh�es e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove bilion�simos", result);
        }

        [TestMethod]
        public void DecimalToExtensionNegative()
        {
            decimal value = -123456789.123456789m;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("menos cento e vinte e tr�s milh�es e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove v�rgula cento e vinte e tr�s milh�es e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove bilion�simos", result);
        }

        [TestMethod]
        public void DecimalToExtensionZero()
        {
            decimal value = 0.0m;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("zero", result);
        }

        [TestMethod]
        public void DecimalToExtensionOne()
        {
            decimal value = 1.0m;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("um", result);
        }

        [TestMethod]
        public void DecimalToExtensionOneDecimal()
        {
            decimal value = 1.1m;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("um v�rgula um d�cimo", result);
        }

        [TestMethod]
        public void DecimalToExtensionOneDecimalNegative()
        {
            decimal value = -1.1m;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("menos um v�rgula um d�cimo", result);
        }

        [TestMethod]
        public void DoubleToExtension()
        {
            double value = 123456789.12345678;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("cento e vinte e tr�s milh�es e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove v�rgula doze milh�es e trezentos e quarenta e cinco mil e seiscentos e setenta e oito cent�simos de milion�simos", result);
        }

        [TestMethod]
        public void DecimalNoPopularText()
        {
            decimal value = 1.1m;

            var result = value.ToExtensionValueBR(false);

            Assert.AreEqual("um inteiro e um d�cimo", result);
        }

        [TestMethod]
        public void DecimalNoPopularText2()
        {
            decimal value = 231.12m;

            var result = value.ToExtensionValueBR(false);

            Assert.AreEqual("duzentos e trinta e um inteiros e doze cent�simos", result);
        }
    }
}