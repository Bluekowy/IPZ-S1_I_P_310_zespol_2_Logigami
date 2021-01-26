using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
public class ChatWinUI : MonoBehaviourPun
{
    [SerializeField] ChatItemUI toChatItem;
    [SerializeField] Transform context;
    [SerializeField] InputField inputtxt;
    //public PlayerInfo playerinfo;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Message();
        }
    }
    private void OnEnable()
    {
        inputtxt.text = string.Empty;
        inputtxt.ActivateInputField();
    }
    private void Message()
    {
        if (string.IsNullOrEmpty(inputtxt.text)) { return; }
        //if (playerinfo = null) { return; }
        photonView.RPC("ReceiveMessageRPC", RpcTarget.All, inputtxt.text);
        //photonView.RPC("MessageRPC", RpcTarget.All, inputtxt.text);
        //InstantiateChatItem(inputtxt.text);
        inputtxt.text = string.Empty;
        inputtxt.ActivateInputField();
    }
    private void InstantiateChatItem(string text)
    {
        ChatItemUI newChatItem = Instantiate(toChatItem);
        newChatItem.transform.SetParent(context);
        newChatItem.transform.position = Vector3.zero;
        newChatItem.transform.localScale = Vector3.one;

        newChatItem.Initialize(text);
    }
    [PunRPC]
    public void ReceiveMessageRPC(string text)
    {
        InstantiateChatItem(text);
    }

    public void OnSendButtonPressed()
    {
        Message();
    }
}
