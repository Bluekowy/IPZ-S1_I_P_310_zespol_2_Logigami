using System.Collections;
using UnityEngine;
using Photon.Pun;
using System.IO;
//public class GameController : MonoBehaviourPun
public class GameController : MonoBehaviourPunCallbacks
{
    public Transform[] Spawn = null;
    public GameObject ChatWinUI;
    public bool IsChatActive { get { return ChatWinUI.activeInHierarchy; } }
    //public GameObject playerPrefab;
    //public Transform[] playerModels;
    private PhotonView PV;
    private PlayerMovement playerMovement;
    //public static bool canMove = true;
    /*void Awake()
    {
        int i = PhotonNetwork.CurrentRoom.PlayerCount - 1;
        PhotonNetwork.Instantiate(Path.Combine("PlayerA", "PlayerB"), Spawn[i].position, Spawn[i].rotation);
        
    }*/

    static public bool door = false;
    public GameObject door1;
    public GameObject door2;
    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
    }
    private void Awake()
    {
        if (door == true)
        {
            door1.SetActive(false);
            door2.SetActive(true);
        }
        //if (!PhotonNetwork.IsMasterClient)
        //    return;
        if (PhotonNetwork.IsMasterClient)
        {
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
    public void ChangeMasterClientifAvailble()
    {
        if (!PhotonNetwork.IsMasterClient)
        {
            return;
        }
        if (PhotonNetwork.CurrentRoom.PlayerCount <= 1)
        {
            return;
        }

        PhotonNetwork.SetMasterClient(PhotonNetwork.MasterClient.GetNext());
    }
    public void OnChatButtonPressed()
    {
        if (playerMovement.canMove == true)
        {
            playerMovement.canMove = false;
        }
        else
        {
            playerMovement.canMove = true;
        }
        ChatWinUI.SetActive(!ChatWinUI.activeInHierarchy);
    }
}
