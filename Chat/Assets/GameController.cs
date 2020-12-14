using UnityEngine;
using Photon.Pun;
public class GameController : MonoBehaviourPun
{
    public Transform[] Spawn = null;
    public GameObject ChatWinUI;
    public bool IsChatActive { get { return ChatWinUI.activeInHierarchy; } }
    private void Awake()
    {
        int i = PhotonNetwork.CurrentRoom.PlayerCount - 1;
        //PhotonNetwork.Instantiate("PlayerA", Spawn[i].position, Spawn[i].rotation);
        GameObject newPlayer = PhotonNetwork.Instantiate("PlayerA", Spawn[i].position, Spawn[i].rotation);
        //ChatWinUI.playerinfo = newPlayer.GetComponent<PlayerInfo>();
    }
    public void OnChatButtonPressed()
    {
        ChatWinUI.SetActive(!ChatWinUI.activeInHierarchy);
    }
}
