using Photon.Pun;
using UnityEngine;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings(); // Connexion à Photon
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connecté à Photon !");
        PhotonNetwork.JoinLobby(); // Rejoindre un lobby
    }
}

