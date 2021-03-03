using UnityEngine;

namespace PlayerPrefsWrapper
{
    public class PlayerPrefFloat : PlayerPref<float>
    {
        public PlayerPrefFloat(string key, float defaultValue = 0f) : base(key, defaultValue) { }

        public override float Get() => PlayerPrefs.GetFloat(Key, DefaultValue);
        public override void Set(float value) => PlayerPrefs.SetFloat(Key, value);
    }
}
