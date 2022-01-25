using UnityEngine;

namespace PlayerPrefsWrapper
{
    public class PlayerPrefInt : PlayerPref<int>
    {
        public PlayerPrefInt(string key, int defaultValue = 0) : base(key, defaultValue) { }

        public override int Value
        {
            get => PlayerPrefs.GetInt(Key, DefaultValue);
            set => PlayerPrefs.SetInt(Key, value);
        }
    }
}
