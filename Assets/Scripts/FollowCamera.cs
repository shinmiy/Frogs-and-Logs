﻿using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField]
    private Transform player;
    [SerializeField]
    private Vector3 offset;
    private float cameraFollowSpeed = 5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = player.position + offset;

        transform.position = Vector3.Lerp(transform.position, newPosition, cameraFollowSpeed + Time.deltaTime);
    }
}
