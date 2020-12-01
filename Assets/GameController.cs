using UnityEngine;
using Photon.Pun;
public class GameController : MonoBehaviourPun
{
    public Transform[] Spawn = null;
    private void Awake()
    {
        int i = PhotonNetwork.CurrentRoom.PlayerCount - 1;
        PhotonNetwork.Instantiate("PlayerA", Spawn[i].position, Spawn[i].rotation);
    }
}
