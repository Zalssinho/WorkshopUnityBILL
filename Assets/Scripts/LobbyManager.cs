using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom("SalleTest", new RoomOptions { MaxPlayers = 4 });
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Salle Rejointe !");

        Object.FindFirstObjectByType<GameManager>().SpawnPlayer();

        //PhotonNetwork.LoadLevel("GameScene"); // Charger la scène du jeu
    }
}
