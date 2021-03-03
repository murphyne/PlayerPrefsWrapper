using UnityEngine;

namespace PlayerPrefsWrapper
{
    public class PlayerPrefInt : PlayerPref<int>
    {
        public PlayerPrefInt(string key, int defaultValue = 0) : base(key, defaultValue) { }

        public override int Get() => PlayerPrefs.GetInt(Key, DefaultValue);
        public override void Set(int value) => PlayerPrefs.SetInt(Key, value);
    }
}
