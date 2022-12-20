using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    // List of Tiles
    public GameObject[] tilePrefabs;
    private float spawnPos = 0;
    private float tileLength = 100;

    
    void Start()
    {
        //Spawn first 4 Tiles
        SpawnTile(0);
        SpawnTile(1);
        SpawnTile(2);
        SpawnTile(3);
    }

    
    void Update()
    {
   
    }


    //Class for making endless amount of tiles
    private void SpawnTile(int tileIndex)
    {
        Instantiate(tilePrefabs[tileIndex], transform.forward * spawnPos, transform.rotation);
        spawnPos += tileLength;
    }
}
