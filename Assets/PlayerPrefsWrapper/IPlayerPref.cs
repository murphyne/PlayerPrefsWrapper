namespace PlayerPrefsWrapper
{
    public interface IPlayerPref<T>
    {
        T Get();
        void Set(T value);
    }
}
