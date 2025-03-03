using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    private bool isConnectedToMaster = false; // Indique si on est bien connect� au Master Server

    private void Start()
    {
        // Connexion � Photon au d�marrage
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connect� au Master Server !");
        isConnectedToMaster = true;
        PhotonNetwork.JoinLobby(); // Rejoindre le lobby
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Lobby rejoint !");
    }

    public void CreateRoom()
    {
        if (!isConnectedToMaster)
        {
            Debug.LogError("Impossible de cr�er une salle : pas encore connect� au Master Server !");
            return;
        }

        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 4; // Limite de joueurs

        PhotonNetwork.CreateRoom("SalleTest", options);
    }

    public void JoinRoom()
    {
        if (!isConnectedToMaster)
        {
            Debug.LogError("Impossible de rejoindre une salle : pas encore connect� au Master Server !");
            return;
        }

        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Salle Rejointe !");
        PhotonNetwork.LoadLevel("GameScene"); // Charger la sc�ne du jeu apr�s avoir rejoint
    }
}
