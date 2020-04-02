using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationScript : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject mainCameraPivot;
    private GameObject mainCamera;
    private GameObject picture;
    private GameObject clock;
    public float speed;
    void Start()
    {
        mainCameraPivot = GameObject.Find("MainCameraPivot");
        mainCamera = GameObject.Find("Main Camera");
        picture = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        mainCameraPivot.transform.Rotate(new Vector3(0, Time.deltaTime * speed, 0));
        picture.transform.LookAt(mainCamera.transform);
    }
}
