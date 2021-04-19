using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] possiblePlatforms;
    [SerializeField] List<GameObject> platforms;
    [SerializeField] GameObject player;
    [SerializeField] float spawnAhead = 5f;

    // Update is called once per frame
    void Update()
    {
        GameObject lastPlatform = platforms[platforms.Count - 1];
        Vector3 spawnLocation = lastPlatform.transform.Find("EndPoint").position;

        Debug.Log(spawnLocation.x - player.transform.position.x);
        if (spawnLocation.x - player.transform.position.x <= spawnAhead)
        {
            SpawnNewPlatforms(spawnLocation);
        }
    }

    private void SpawnNewPlatforms(Vector3 spawnPosition)
    {
        GameObject platform = possiblePlatforms[(int) Random.Range(0, possiblePlatforms.Length)];
        platforms.Add(Instantiate(platform, spawnPosition, Quaternion.identity));

    }
}
