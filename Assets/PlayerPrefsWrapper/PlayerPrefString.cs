using UnityEngine;

namespace PlayerPrefsWrapper
{
    public class PlayerPrefString : PlayerPref<string>
    {
        public PlayerPrefString(string key, string defaultValue = "") : base(key, defaultValue) { }

        public override string Value
        {
            get => PlayerPrefs.GetString(Key, DefaultValue);
            set => PlayerPrefs.SetString(Key, value);
        }
    }
}
