using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform mainCamera;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera.transform.position = new Vector3(player.position.x , player.position.y, -10);
    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.transform.position = new Vector3(player.position.x , player.position.y, -10);
    }
}
