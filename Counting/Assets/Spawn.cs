using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Prefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPrefab());
    }

    IEnumerator SpawnPrefab()
    {
        yield return new WaitForSeconds(2.0f);
        Instantiate(Prefab, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
