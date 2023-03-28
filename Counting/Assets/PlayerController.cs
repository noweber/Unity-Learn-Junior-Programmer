using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * Input.GetAxis("Horizontal") * Time.deltaTime;
        transform.position += Vector3.left * Input.GetAxis("Vertical") * Time.deltaTime;
    }
}
