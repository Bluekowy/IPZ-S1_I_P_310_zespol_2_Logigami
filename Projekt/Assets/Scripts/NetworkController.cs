using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NetworkController : MonoBehaviourPunCallbacks
{
    public Text txtStatus = null;
    public GameObject btnStart = null;
    public byte MaxPlayers = 2;
    //activeTaskCnt zlicza libzbę aktywnych tasków jeśli dowolny task jest aktywny to gracze nie będą już mieli tych samych scen
    static public int activeTaskCnt = 0;
    static public bool taskDone1 = false;
    static public bool taskDone3 = false;
    static public bool taskDone4 = false;
    static public int clock = 1;

    private void Start()
    {   
        PhotonNetwork.ConnectUsingSettings();
        btnStart.SetActive(false);
        Status("Connecting to server");
        clock = UnityEngine.Random.Range(1, 6);
        Debug.Log("clock:" + clock);
    }
    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        if(activeTaskCnt == 0)
            PhotonNetwork.AutomaticallySyncScene = true; // ta sama scena dla każdego gracza
        btnStart.SetActive(true);
        Status("Connected to " + PhotonNetwork.ServerAddress);
    }
    public void Click()
    {
        string roomName = "Room1";
        Photon.Realtime.RoomOptions opts = new Photon.Realtime.RoomOptions();
        opts.IsOpen = true;
        opts.IsVisible = true;
        opts.MaxPlayers = MaxPlayers;

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
        txtStatus.text = message;
    }
}
