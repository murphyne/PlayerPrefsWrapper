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
            Assert.AreEqual("", pref.Value);
        }

        [Test]
        public void WrapperStringDefault()
        {
            var pref = new PlayerPrefString("Name", "Odin");
            Assert.AreEqual("Odin", pref.Value);
        }

        [Test]
        public void WrapperStringAdditionAssignment()
        {
            var pref = new PlayerPrefString("Name", "Odin");
            pref.Value += "son";
            Assert.AreEqual("Odinson", pref.Value);
        }

        [Test]
        public void WrapperStringKeyIsNotSetImmediately()
        {
            var pref = new PlayerPrefString("Name");
            Assert.AreEqual(false, pref.Exists);
        }

        [Test]
        public void WrapperStringKeyIsSetAfterAssignment()
        {
            var pref = new PlayerPrefString("Name");
            pref.Value = "Odin";
            Assert.AreEqual(true, pref.Exists);
        }

        [Test]
        public void WrapperStringKeyIsUnsetAfterDelete()
        {
            var pref = new PlayerPrefString("Name");
            pref.Value = "Odin";
            pref.Delete();
            Assert.AreEqual(false, pref.Exists);
        }
    }
}
