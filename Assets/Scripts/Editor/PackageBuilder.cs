using UnityEditor;
using UnityEditor.PackageManager;
using UnityEngine;

public static class PackageBuilder
{
    [MenuItem("Assets/Create GZip tarball", false)]
    private static void PackTgz()
    {
        const string sourceFolder = "Assets/PlayerPrefsWrapper";
        const string targetFolder = "Builds";

        var packRequest = Client.Pack(sourceFolder, targetFolder);

        while (!packRequest.IsCompleted)
        {
        }

        if (packRequest.Status == StatusCode.Failure)
        {
            var error = packRequest.Error;

            Debug.LogError($"GZip tarball creation failed.");
            Debug.LogError($"Error code: {error.errorCode}");
            Debug.LogError($"Error message: {error.message}");
        }
        else if (packRequest.Status == StatusCode.Success)
        {
            var tarballPath = packRequest.Result.tarballPath;

            Debug.Log($"GZip tarball created successfully.");
            Debug.Log($"{tarballPath}");
        }
    }
}
