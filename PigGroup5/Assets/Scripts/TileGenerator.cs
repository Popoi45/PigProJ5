using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    private float spawnPos = 0;
    private float tileLength = 100;
    // Start is called before the first frame update
    void Start()
    {
        SpawnTile(0);
        SpawnTile(1);
        SpawnTile(2);
        SpawnTile(3);
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    private void SpawnTile(int tileIndex)
    {
        Instantiate(tilePrefabs[tileIndex], transform.forward * spawnPos, transform.rotation);
        spawnPos += tileLength;
    }
}
