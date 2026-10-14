using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private GameObject menuManager;
    [SerializeField] public Transform spawnPoint;
    [SerializeField] GameObject player;

    public void OnClickRespawn()
    {
        RespawnSpawnPoint();
        Debug.Log("Start Respawn");
    }

    private void RespawnSpawnPoint()
    {   
        menuManager.GetComponent<MenuManager>().backToGame();
        player.transform.position = spawnPoint.position;
        player.transform.rotation = spawnPoint.rotation;
        Debug.Log("Player should respawn now");
    }
}
