using UnityEngine;

namespace PlayerPrefsWrapper
{
    public abstract class PlayerPref<T> : IPlayerPref<T>
    {
        protected string Key { get; }
        protected T DefaultValue { get; }

        protected PlayerPref(string key, T defaultValue)
        {
            this.Key = key;
            this.DefaultValue = defaultValue;
        }

        public abstract T Value { get; set; }

        public bool Exists => PlayerPrefs.HasKey(Key);

        public void Delete()
        {
            PlayerPrefs.DeleteKey(Key);
        }
    }
}
