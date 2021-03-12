using NUnit.Framework;
using UnityEngine;

namespace PlayerPrefsWrapper.Editor
{
    [TestFixture]
    public class WrapperStringTests
    {
        [TearDown]
        public void AfterEach()
        {
            PlayerPrefs.DeleteKey("Name");
        }

        [Test]
        public void WrapperStringDefaultUnset()
        {
            var pref = new PlayerPrefString("Name");
            Assert.AreEqual("", pref.Get());
        }

        [Test]
        public void WrapperStringDefault()
        {
            var pref = new PlayerPrefString("Name", "Odin");
            Assert.AreEqual("Odin", pref.Get());
        }
    }
}
