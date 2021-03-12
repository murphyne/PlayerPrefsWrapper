using NUnit.Framework;
using UnityEngine;

namespace PlayerPrefsWrapper.Editor
{
    [TestFixture]
    public class WrapperFloatTests
    {
        [TearDown]
        public void AfterEach()
        {
            PlayerPrefs.DeleteKey("Temperature");
        }

        [Test]
        public void WrapperFloatDefaultUnset()
        {
            var pref = new PlayerPrefFloat("Temperature");
            Assert.AreEqual(0f, pref.Get());
        }

        [Test]
        public void WrapperFloatDefault()
        {
            var pref = new PlayerPrefFloat("Temperature", 36.6f);
            Assert.AreEqual(36.6f, pref.Get());
        }
    }
}
