using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDragonUI : MonoBehaviour
{
    public GameObject RedDragonPrefab, BlueDragonPrefab;
    public Transform SpawnArea;
    private float spawnAreaBoundX, spawnAreaBoundZ;

    private void Awake()
    {
        // Get the bound of the plane
        Mesh planeMesh = SpawnArea.GetComponent<MeshFilter>().mesh;
        spawnAreaBoundX = SpawnArea.transform.localScale.x * planeMesh.bounds.size.x / 2f;
        spawnAreaBoundZ = SpawnArea.transform.localScale.z * planeMesh.bounds.size.z / 2f;
    }

    public void SpawnRedDragon(int amount)
    {
        for(int i = 0; i < amount; i++)
        {
            Instantiate(RedDragonPrefab, GetRandomSpawnLocation(), RedDragonPrefab.transform.rotation);
        }
    }

    public void SpawnBlueDragon(int amount)
    {
        for(int i = 0; i < amount; i++)
        {
            Instantiate(BlueDragonPrefab, GetRandomSpawnLocation(), BlueDragonPrefab.transform.rotation);
        }
    }

    private Vector3 GetRandomSpawnLocation()
    {
        float randomX = Random.Range(-spawnAreaBoundX, spawnAreaBoundX);
        float randomZ = Random.Range(-spawnAreaBoundZ, spawnAreaBoundZ);

        Debug.Log($"{randomX}, {randomZ}");

        return new Vector3(randomX, 0f, randomZ);
    }
}
