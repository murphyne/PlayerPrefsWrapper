using UnityEngine;

namespace PlayerPrefsWrapper
{
    public class PlayerPrefString : PlayerPref<string>
    {
        public PlayerPrefString(string key, string defaultValue = "") : base(key, defaultValue) { }

        public override string Get() => PlayerPrefs.GetString(Key, DefaultValue);
        public override void Set(string value) => PlayerPrefs.SetString(Key, value);
    }
}
