using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Tindo.Blazor.ECharts.Test
{
    [TestClass]
    public class UnionTypeTests
    {
        private static JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            Converters = { new StringEnumConverter(new CamelCaseNamingStrategy()) }
        };

        [TestMethod]
        public void TestSerializeInt()
        {
            var unionType = new TestUnionType
            {
                Height = 42,
            };
            var actual = JsonConvert.SerializeObject(unionType, Formatting.None, Settings);
            var expect = "{\"height\":42}";
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestSerializeString()
        {
            var unionType = new TestUnionType
            {
                Height = "42%",
            };
            var actual = JsonConvert.SerializeObject(unionType, Formatting.None, Settings);
            var expect = "{\"height\":\"42%\"}";
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestSerializePerson()
        {
            var unionType = new TestUnionType
            {
                Height = 42,
                Person = new Person
                {
                    Name = "Alice",
                    Age = 18,
                }
            };
            var actual = JsonConvert.SerializeObject(unionType, Formatting.None, Settings);
            var expect = "{\"height\":42,\"person\":{\"name\":\"Alice\",\"age\":18}}";
            Assert.AreEqual(expect, actual);
        }

        private class TestUnionType
        {
            public UnionType<int, string> Height { get; set; }

            public UnionType<string, Person> Person { get; set; }
        }

        private class Person
        {
            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}
