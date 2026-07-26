using UnityEngine;

public class ForcePortraitWindow : MonoBehaviour
{
    void Awake()
    {
        int width = 540;
        int height = 960;

        Screen.SetResolution(width, height, FullScreenMode.Windowed);
    }
}
