using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
public class EscMenu : MonoBehaviourPunCallbacks
{
    public static bool EscClicked = false;
    public GameObject EscMenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (EscClicked)
            {
                Game();
            }
            else
            {
                Menu();
            }
        }
    }
    public void Game()
    {
        EscMenuUI.SetActive(false);
        EscClicked = false;
    }
    void Menu()
    {
        EscMenuUI.SetActive(true);
        EscClicked = true;
    }
    /*List<int> width = new List<int>() { 1024, 1280, 1920 };
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
    }*/
    /*public void BackToMainMenu()
    {
        PhotonNetwork.LeaveRoom();
        //PhotonNetwork.Disconnect();
        SceneManager.LoadScene("MainMenu");
    }*/
    /*public void LeaveRoom()
    {
        //PhotonNetwork.LeaveRoom();
        PhotonNetwork.Disconnect();
    }
    public override void OnLeftRoom()
    {
        //PhotonNetwork.Disconnect();
        base.OnLeftRoom();
        SceneManager.LoadScene("MainMenu");
    }*/
    public void DisconnectPlayer()
    {
        StartCoroutine(BackToMainMenu());
    }
    IEnumerator BackToMainMenu()
    {
        PhotonNetwork.Disconnect();
        while (PhotonNetwork.IsConnected)
            yield return null;
        SceneManager.LoadScene("MainMenu");
    }
    /*IEnumerator BackToMainMenu()
    {
        PhotonNetwork.LeaveRoom();
        while (PhotonNetwork.InRoom)
            yield return null;
        SceneManager.LoadScene("MainMenu");
    }*/
}
