using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

using Debug = UnityEngine.Debug;

public class ControlScript : MonoBehaviourPunCallbacks
{
    public Color buttonDepressedColor = new Color(1.0f, 1.0f, 1.0f);
    public Color buttonPressedColor = new Color(0.6f, 0.6f, 0.6f);

    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.IsVisible = false;
        roomOptions.MaxPlayers = 4;
        PhotonNetwork.JoinOrCreateRoom("parthandpriyankaarebullies", roomOptions, TypedLobby.Default);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartHeartbeatButtonClicked()
    {
        RaiseEventOptions raiseEventOptions = new RaiseEventOptions { Receivers = ReceiverGroup.Others };
        PhotonNetwork.RaiseEvent(Utility.StartHeartbeatEventCode, null, raiseEventOptions, SendOptions.SendReliable);
        Debug.Log("Start heartbeat event sent");
    }

    public void StopHeartbeatButtonClicked()
    {
        RaiseEventOptions raiseEventOptions = new RaiseEventOptions { Receivers = ReceiverGroup.Others };
        PhotonNetwork.RaiseEvent(Utility.StopHeartbeatEventCode, null, raiseEventOptions, SendOptions.SendReliable);
        Debug.Log("Stop heartbeat event sent");
    }

    public void RevealPrice1ButtonClicked()
    {
        RaiseEventOptions raiseEventOptions = new RaiseEventOptions { Receivers = ReceiverGroup.Others };
        PhotonNetwork.RaiseEvent(Utility.RevealPrice1EventCode, null, raiseEventOptions, SendOptions.SendReliable);
        Debug.Log("Reveal price 1 event sent");
    }

    public void RevealPrice2ButtonClicked()
    {
        RaiseEventOptions raiseEventOptions = new RaiseEventOptions { Receivers = ReceiverGroup.Others };
        PhotonNetwork.RaiseEvent(Utility.RevealPrice2EventCode, null, raiseEventOptions, SendOptions.SendReliable);
        Debug.Log("Reveal price 2 event sent");
    }

    public void RevealPrice3ButtonClicked()
    {
        RaiseEventOptions raiseEventOptions = new RaiseEventOptions { Receivers = ReceiverGroup.Others };
        PhotonNetwork.RaiseEvent(Utility.RevealPrice3EventCode, null, raiseEventOptions, SendOptions.SendReliable);
        Debug.Log("Reveal price 3 event sent");
    }

    public void RevealPrice4ButtonClicked()
    {
        RaiseEventOptions raiseEventOptions = new RaiseEventOptions { Receivers = ReceiverGroup.Others };
        PhotonNetwork.RaiseEvent(Utility.RevealPrice4EventCode, null, raiseEventOptions, SendOptions.SendReliable);
        Debug.Log("Reveal price 4 event sent");
    }

    public void RevealPrice5ButtonClicked()
    {
        RaiseEventOptions raiseEventOptions = new RaiseEventOptions { Receivers = ReceiverGroup.Others };
        PhotonNetwork.RaiseEvent(Utility.RevealPrice5EventCode, null, raiseEventOptions, SendOptions.SendReliable);
        Debug.Log("Reveal price 5 event sent");
    }

    public void HideAllPricesButtonClicked()
    {
        RaiseEventOptions raiseEventOptions = new RaiseEventOptions { Receivers = ReceiverGroup.Others };
        PhotonNetwork.RaiseEvent(Utility.HideAllPricesEventCode, null, raiseEventOptions, SendOptions.SendReliable);
        Debug.Log("Hide all prices event sent");
    }
}
