using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public GameObject partical;
    private Vector3 initialPlayer = new Vector3(0, 0, 0);
    private Vector3 initialCamera = new Vector3(0, 0, 0);
    private Vector3 finalCamera = new Vector3(0, 0, 0);
    private Vector3 offset = new Vector3(0, 0, 0);

    void Start()
    {
        initialPlayer = player.transform.position;
        initialCamera = transform.position;
        offset.x = initialPlayer.x - initialCamera.x;
        finalCamera.y += initialCamera.y;
        finalCamera.z += initialCamera.z;
    }


    void LateUpdate()
    {
        if(player.activeInHierarchy)
        finalCamera.x = player.transform.position.x - offset.x;
        if(partical.activeInHierarchy)
            finalCamera.x = partical.transform.position.x - offset.x;
        transform.position = finalCamera;
    }
}
