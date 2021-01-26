using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class NetworkController : MonoBehaviourPunCallbacks
{
    public Text txtStatus = null;
    //public TextMeshPro txtStatus = null;
    //public TextContainer textContainer;
    public GameObject btnStart = null;
    public byte MaxPlayers = 2;
    private void Start()
    {
        if (PhotonNetwork.IsConnected == false)
        {
            PhotonNetwork.ConnectUsingSettings();
            btnStart.SetActive(false);
            Status("Connecting to server");
        }
    }
    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        PhotonNetwork.AutomaticallySyncScene = true; // ta sama scena dla każdego gracza
        btnStart.SetActive(true);
        Status("Connected to " + PhotonNetwork.ServerAddress);
    }
    public void Click()
    {
        string roomName = "Room1";
        //Photon.Realtime.RoomOptions opts = new Photon.Realtime.RoomOptions();
        RoomOptions opts = new RoomOptions();
        opts.IsOpen = true;
        opts.IsVisible = true;
        opts.MaxPlayers = MaxPlayers;
        opts.CleanupCacheOnLeave = true;
        PhotonNetwork.JoinOrCreateRoom(roomName, opts, Photon.Realtime.TypedLobby.Default);
        btnStart.SetActive(false);
        Status("Joining " + roomName);
    }
    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        SceneManager.LoadScene("SampleScene");
    }
    private void Status(string message)
    {
        Debug.Log(message);
        //txtStatus = GetComponent<TextMeshPro>();
        //textContainer = GetComponent<TextContainer>();
        //textContainer.width = 25f;
        //textContainer.height = 3f;
        //textContainer.fontSize = 24;
        txtStatus.text = message;
    }
    public void BackToMainMenu()
    {
        PhotonNetwork.LeaveRoom();
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene("MainMenu");
    }
}
