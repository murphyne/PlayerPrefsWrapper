using NUnit.Framework;
using UnityEngine;

namespace PlayerPrefsWrapper.Editor
{
    [TestFixture]
    public class WrapperBoolTests
    {
        [TearDown]
        public void AfterEach()
        {
            PlayerPrefs.DeleteKey("Flag");
        }

        [Test]
        public void WrapperBoolDefaultUnset()
        {
            var pref = new PlayerPrefBool("Flag");
            Assert.AreEqual(false, pref.Value);
        }

        [Test]
        public void WrapperBoolDefault()
        {
            var pref = new PlayerPrefBool("Flag", true);
            Assert.AreEqual(true, pref.Value);
        }

        [Test]
        public void WrapperBoolCompoundAssignment()
        {
            var pref = new PlayerPrefBool("Flag", true);
            pref.Value ^= true;
            Assert.AreEqual(false, pref.Value);
        }

        [Test]
        public void WrapperBoolKeyIsNotSetImmediately()
        {
            var pref = new PlayerPrefBool("Flag");
            Assert.AreEqual(false, pref.Exists);
        }

        [Test]
        public void WrapperBoolKeyIsSetAfterAssignment()
        {
            var pref = new PlayerPrefBool("Flag");
            pref.Value = true;
            Assert.AreEqual(true, pref.Exists);
        }

        [Test]
        public void WrapperBoolKeyIsUnsetAfterDelete()
        {
            var pref = new PlayerPrefBool("Flag");
            pref.Value = true;
            pref.Delete();
            Assert.AreEqual(false, pref.Exists);
        }
    }
}
