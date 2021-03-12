using UnityEngine;

namespace PlayerPrefsWrapper
{
    public class PlayerPrefFloat : PlayerPref<float>
    {
        public PlayerPrefFloat(string key, float defaultValue = 0f) : base(key, defaultValue) { }

        public override float Value
        {
            get => PlayerPrefs.GetFloat(Key, DefaultValue);
            set => PlayerPrefs.SetFloat(Key, value);
        }
    }
}
