using UnityEngine;

namespace PlayerPrefsWrapper
{
    public class PlayerPrefBool : PlayerPref<bool>
    {
        private const int TrueValue = 1;
        private const int FalseValue = 0;

        public PlayerPrefBool(string key, bool defaultValue = false) : base(key, defaultValue) { }

        public override bool Value
        {
            get => PlayerPrefs.GetInt(Key, DefaultValue ? TrueValue : FalseValue) == TrueValue;
            set => PlayerPrefs.SetInt(Key, value ? TrueValue : FalseValue);
        }
    }
}
