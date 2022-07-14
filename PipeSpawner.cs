using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipesPrefab;

    public float spawnRate = 0.5f;
    public float minY = -2.5f;
    public float maxY = 2.5f;


    private void Spawn()
    {
        GameObject pipes = Instantiate(pipesPrefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minY, maxY);
    }

    private void OnEnable()
    {
        
            InvokeRepeating(nameof(Spawn), spawnRate   , spawnRate);
        

    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }


}
