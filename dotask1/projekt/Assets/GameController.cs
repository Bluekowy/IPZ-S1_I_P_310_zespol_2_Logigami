using UnityEngine;
using Photon.Pun;
public class GameController : MonoBehaviourPun
{
    public Transform[] Spawn = null;
    private void Awake()
    {
        int i = PhotonNetwork.CurrentRoom.PlayerCount - 1;
        PhotonNetwork.Instantiate("duch", Vector3.zero, Quaternion.identity);
    }
}
