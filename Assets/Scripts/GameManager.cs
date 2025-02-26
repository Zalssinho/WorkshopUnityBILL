using Photon.Pun;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;

    public void SpawnPlayer()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-5f, 5f), 0, 0);
        PhotonNetwork.Instantiate(playerPrefab.name, spawnPos, Quaternion.identity);
    }
}
