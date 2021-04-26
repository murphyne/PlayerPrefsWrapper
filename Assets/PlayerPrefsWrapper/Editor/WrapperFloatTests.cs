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
            Assert.AreEqual(0f, pref.Value);
        }

        [Test]
        public void WrapperFloatDefault()
        {
            var pref = new PlayerPrefFloat("Temperature", 36.6f);
            Assert.AreEqual(36.6f, pref.Value);
        }

        [Test]
        public void WrapperFloatAdditionAssignment()
        {
            var pref = new PlayerPrefFloat("Temperature", 36.6f);
            pref.Value += 1f;
            Assert.AreEqual(37.6f, pref.Value);
        }

        [Test]
        public void WrapperFloatKeyIsNotSetImmediately()
        {
            var pref = new PlayerPrefFloat("Temperature");
            Assert.AreEqual(false, pref.Exists);
        }

        [Test]
        public void WrapperFloatKeyIsSetAfterAssignment()
        {
            var pref = new PlayerPrefFloat("Temperature");
            pref.Value = 36.6f;
            Assert.AreEqual(true, pref.Exists);
        }

        [Test]
        public void WrapperFloatKeyIsUnsetAfterDelete()
        {
            var pref = new PlayerPrefFloat("Temperature");
            pref.Value = 36.6f;
            pref.Delete();
            Assert.AreEqual(false, pref.Exists);
        }
    }
}
