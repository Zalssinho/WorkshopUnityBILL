using Photon.Pun;
using UnityEngine;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings(); // Connexion � Photon
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connect� � Photon !");
        PhotonNetwork.JoinLobby(); // Rejoindre un lobby
    }
}

