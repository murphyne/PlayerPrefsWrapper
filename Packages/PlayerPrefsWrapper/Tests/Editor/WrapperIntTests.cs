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
            Assert.AreEqual(0, pref.Value);
        }

        [Test]
        public void WrapperIntDefault()
        {
            var pref = new PlayerPrefInt("Counter", 42);
            Assert.AreEqual(42, pref.Value);
        }

        [Test]
        public void WrapperIntAdditionAssignment()
        {
            var pref = new PlayerPrefInt("Counter", 42);
            pref.Value += 1;
            Assert.AreEqual(43, pref.Value);
        }

        [Test]
        public void WrapperIntKeyIsNotSetImmediately()
        {
            var pref = new PlayerPrefInt("Counter");
            Assert.AreEqual(false, pref.Exists);
        }

        [Test]
        public void WrapperIntKeyIsSetAfterAssignment()
        {
            var pref = new PlayerPrefInt("Counter");
            pref.Value = 42;
            Assert.AreEqual(true, pref.Exists);
        }

        [Test]
        public void WrapperIntKeyIsUnsetAfterDelete()
        {
            var pref = new PlayerPrefInt("Counter");
            pref.Value = 42;
            pref.Delete();
            Assert.AreEqual(false, pref.Exists);
        }
    }
}
