using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject SpawnPrefab;

    public Vector3 SpawnPosition = new Vector3(25, 0, 0);

    public float StartDelay = 2;

    public float RepeatRate = 2;
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("InstantiatePrefab", StartDelay, RepeatRate);
    }

    // Update is called once per frame
    void InstantiatePrefab()
    {
        if (!playerController.IsGameOver)
        {
            Instantiate(SpawnPrefab, SpawnPosition, SpawnPrefab.transform.rotation);
        }
    }
}
