# PlayerPrefs Wrapper

This is a wrapper for the [UnityEngine.PlayerPrefs API][PlayerPrefs].

[PlayerPrefs]:
https://docs.unity3d.com/ScriptReference/PlayerPrefs.html


## Features

- Cleaner syntax for working with the PlayerPrefs API.
- Type safety for saving and retrieving data.
- Support for multiple data types, including int, float, string, bool.


## Installation

- To install from a Git URL:
  - Copy Git URL: `https://github.com/murphyne/PlayerPrefsWrapper.git?path=Packages/PlayerPrefsWrapper`
  - Follow the instructions on the [Install a UPM package from a Git URL][UPM-Git] page.

- To install from a tarball file:
  - Download the .tgz file from [Releases][Releases].
  - Follow the instructions on the [Install a UPM package from a local tarball file][UPM-Tarball] page.

[Releases]:
https://github.com/murphyne/PlayerPrefsWrapper/releases

[UPM-Tarball]:
https://docs.unity3d.com/Manual/upm-ui-tarball.html

[UPM-Git]:
https://docs.unity3d.com/Manual/upm-ui-giturl.html


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
