using UnityEngine;
using Photon.Pun;
using System.IO;
public class GameController : MonoBehaviourPun
{
    public Transform[] Spawn = null;
    public GameObject ChatWinUI;
    public bool IsChatActive { get { return ChatWinUI.activeInHierarchy; } }
    public GameObject playerPrefab;
    //public Transform[] playerModels;
    private PhotonView PV;
    /*void Awake()
    {
        int i = PhotonNetwork.CurrentRoom.PlayerCount - 1;
        PhotonNetwork.Instantiate(Path.Combine("PlayerA", "PlayerB"), Spawn[i].position, Spawn[i].rotation);
        
    }*/
    private void Awake()
    {
        if (PhotonNetwork.IsMasterClient) { 
            int i = PhotonNetwork.CurrentRoom.PlayerCount - 1;
            //PhotonNetwork.Instantiate("PlayerA", Spawn[i].position, Spawn[i].rotation);
            //GameObject newPlayer = PhotonNetwork.Instantiate("PlayerA", Spawn[i].position, Spawn[i].rotation);
            PhotonNetwork.Instantiate("PlayerA", Spawn[i].position, Spawn[i].rotation, 0);
            //GameObject newPlayer = PhotonNetwork.Instantiate(playerModels[0], Spawn[i].position, Spawn[i].rotation);
            //GameObject newPlayer = PhotonNetwork.Instantiate(this.playerPrefab.name, new Vector3(0f, 5f, 0f), Quaternion.identity, 0);
        }
        else
        {
            int i = PhotonNetwork.CurrentRoom.PlayerCount - 1;
            PhotonNetwork.Instantiate("PlayerB", Spawn[i].position, Spawn[i].rotation, 0);
        }
    }
    public void OnChatButtonPressed()
    {
        ChatWinUI.SetActive(!ChatWinUI.activeInHierarchy);
    }
}
