using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    public Vector3 RandomPosition;

    public Color RandomColor;

    private void Awake()
    {
        if(RandomColor == new Color(0, 0, 0, 0))
        {
            RandomColor = new Color(
            Random.Range(0, 1.0f),
            Random.Range(0, 1.0f),
            Random.Range(0, 1.0f),
            1.0f
            );
        }

        if(RandomPosition == Vector3.zero)
        {
            RandomPosition = new Vector3(
            Random.Range(0, 4),
            Random.Range(0, 4),
            Random.Range(0, 4)
            );
        }
    }

    void Start()
    {
        transform.position = RandomPosition;
        transform.localScale = Vector3.one * 1.3f;

        Material material = Renderer.material;

        material.color = RandomColor;
    }

    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
