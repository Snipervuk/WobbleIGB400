using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChracterController : MonoBehaviour
{

    Rigidbody Playerbody;

    public float Speed;
    public bool ifMove = false;
    
    // Start is called before the first frame update
    void Start()
    {
        Playerbody = GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");



        if (ifMove == true)
        {
            Vector3 moveDir = new Vector3(horizontal, 0f, vertical) * Speed * Time.deltaTime;
            transform.Translate(moveDir);
        }


    }
}
