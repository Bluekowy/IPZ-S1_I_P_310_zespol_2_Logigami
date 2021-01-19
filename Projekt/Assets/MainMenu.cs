using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Menu");
    }
    List<int> width = new List<int>() { 1024, 1280, 1920 };
    List<int> height = new List<int>() { 768, 720, 1080 };
    public void SetScreenSize(int i)
    {
        bool fullscreen = Screen.fullScreen;
        int wdt = width[i];
        int hgt = height[i];
        Screen.SetResolution(wdt, hgt, fullscreen);
    }
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
