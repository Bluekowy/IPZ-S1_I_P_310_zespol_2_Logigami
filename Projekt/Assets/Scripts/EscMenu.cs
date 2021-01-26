using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
public class EscMenu : MonoBehaviour
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
        //PhotonNetwork.LeaveRoom();
        while (PhotonNetwork.IsConnected)
        //while (PhotonNetwork.InRoom)
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
