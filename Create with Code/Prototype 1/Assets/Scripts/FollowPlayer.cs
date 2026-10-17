using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 cameraOffset = new Vector3(0, 5, -7);
    public InputAction cameraSwitcher;

    void OnEnable()
    {
        cameraSwitcher.Enable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // TO DO : Camera switch code will add
        transform.position = player.transform.position + cameraOffset;
    }

}
