using NUnit.Framework;
using UnityEngine;

namespace PlayerPrefsWrapper.Editor
{
    [TestFixture]
    public class WrapperIntTests
    {
        [TearDown]
        public void AfterEach()
        {
            PlayerPrefs.DeleteKey("Counter");
        }

        [Test]
        public void WrapperIntDefaultUnset()
        {
            var pref = new PlayerPrefInt("Counter");
            Assert.AreEqual(0, pref.Get());
        }

        [Test]
        public void WrapperIntDefault()
        {
            var pref = new PlayerPrefInt("Counter", 42);
            Assert.AreEqual(42, pref.Get());
        }
    }
}
