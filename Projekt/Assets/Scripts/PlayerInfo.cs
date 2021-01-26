using UnityEngine;
using Photon.Pun;
using System.Collections.Generic;
public class PlayerInfo : Photon.Pun.MonoBehaviourPun, IPunObservable
{
    public int colorIndex;
    public SpriteRenderer playerBody;
    public List<Color> AllPlayerColors = new List<Color>();
    public Color currentColor { get { return AllPlayerColors[colorIndex]; } }
    private void Awake()
    {
        if (photonView.IsMine)
        {
            colorIndex=Random.Range(0,AllPlayerColors.Count-1);
        }
    }
    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            stream.SendNext(colorIndex);
        }
        else
        {
            colorIndex = (int)stream.ReceiveNext();
        }
    }
    private void Update()
    {
        playerBody.color = AllPlayerColors[colorIndex];
    }
}


