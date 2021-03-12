namespace PlayerPrefsWrapper
{
    public interface IPlayerPref<T>
    {
        T Value { get; set; }
    }
}
