using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Tindo.Blazor.ECharts.Test
{
    [TestClass]
    public class ColorTests
    {
        private static JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            Converters = { new StringEnumConverter(new CamelCaseNamingStrategy()) }
        };

        [TestMethod]
        public void TestImplicitConvert()
        {
            Color color = "rgb(255,255,255)";
            Assert.AreEqual("rgb(255,255,255)", color.Value);

            color = System.Drawing.Color.White;
            var expect = "rgba(255, 255, 255, 255)";
            Assert.AreEqual(expect, color.Value);
        }

        [TestMethod]
        public void TestJsonSerializeString()
        {
            TestColor color = new TestColor
            {
                Color = "rgb(0, 0, 0)",
            };
            var actual = JsonConvert.SerializeObject(color, Formatting.None, Settings);
            var expect = "{\"color\":\"rgb(0, 0, 0)\"}";
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestJsonSerializeColor()
        {
            TestColor color = new TestColor
            {
                Color = System.Drawing.Color.White,
            };
            var actual = JsonConvert.SerializeObject(color, Formatting.None, Settings);
            var expect = "{\"color\":\"rgba(255, 255, 255, 255)\"}";
            Assert.AreEqual(expect, actual);
        }

        private class TestColor
        {
            public Color Color { get; set; }
        }
    }
}
