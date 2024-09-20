# PlayerPrefs Wrapper

This is a wrapper for the [UnityEngine.PlayerPrefs API][PlayerPrefs].

[PlayerPrefs]:
https://docs.unity3d.com/ScriptReference/PlayerPrefs.html


## Features

- Cleaner syntax for working with the PlayerPrefs API.
- Type safety for saving and retrieving data.
- Support for multiple data types, including int, float, string, bool.


## Installation

- Download the .tgz file from [Releases][Releases].
- Add the .tgz file to your Unity project [using the Package Manager][UPM-Tarball].

[Releases]:
https://github.com/murphyne/PlayerPrefsWrapper/releases

[UPM-Tarball]:
https://docs.unity3d.com/Manual/upm-ui-tarball.html


## Usage

```csharp
using PlayerPrefsWrapper;

public class Options
{
    // Create an instance of wrapped PlayerPrefs value.
    // Specify a key and an optional default value.
    private readonly PlayerPrefBool _option1 = new PlayerPrefBool("Option1", true);

    // Get value from PlayerPrefs.
    public bool GetOption1() => _option1.Value;

    // Set value to PlayerPrefs.
    public void SetOption1(bool value) => _option1.Value = value;
}
```
