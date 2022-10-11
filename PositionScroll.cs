using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionScroll : MonoBehaviour
{
    public float scrollSpeed;
    public float tileSizeX;

    private Vector3 startPosition;
    private Vector3 position;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeX);

        //Method1- Change x position
        transform.position = startPosition + Vector3.right * newPosition;

        //Method2- Change x position
        //position = transform .position;
        //position.x += newPosition;
        //transform.position = position;
    }

}
