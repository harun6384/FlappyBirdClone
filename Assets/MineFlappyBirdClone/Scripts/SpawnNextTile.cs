using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNextTile : MonoBehaviour
{
    [SerializeField] private GameObject[] tilePrefabs;
    public float zSpawn = 0;
    public float tileLength = 3;
    public int numberOfTiles = 1;

    public Transform characterTransform;

    private void Start()
    {
        SpawnTile(Random.Range(0, tilePrefabs.Length));
    }

    private void Update()
    {
        if (characterTransform.position.x > zSpawn - (numberOfTiles * tileLength))
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
        }
    }

    public void SpawnTile(int tileIndex)
    {
        Instantiate(tilePrefabs[tileIndex], transform.right * zSpawn, transform.rotation);
        zSpawn += tileLength;
        
    }
}
