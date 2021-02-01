using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{

    //Camera Rotate Speed
    public float HSpeed = 10f;
    public float VSpeed = 10f;

    private float HorzSpeed;
    private float VertSpeed; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorzSpeed += HSpeed * Input.GetAxis("Mouse X");
        VertSpeed -= VSpeed * Input.GetAxis("Mouse Y");

        HorzSpeed = Mathf.Clamp(HorzSpeed, -90f, 90f);
        VertSpeed = Mathf.Clamp(VertSpeed, -60f, 90f);


        transform.eulerAngles = new Vector3(VertSpeed, HorzSpeed, 0.0f);

    }
}
