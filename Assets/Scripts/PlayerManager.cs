using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject player;
    private int maxSpawn = 3;
    // Start is called before the first frame update
    void Start()
    {
        int spawnCount = GameManager.currentLevelIndex / 4;
        if(spawnCount < maxSpawn) {
            SpawnPlayer(spawnCount);
        }
        else
        {
            SpawnPlayer(maxSpawn);
        }
    }

    public void SpawnPlayer(int count)
    {
        for(int i = 0; i < count; i++)
        {
            Instantiate(player, player.transform.position, Quaternion.identity);
        }
    }
}
