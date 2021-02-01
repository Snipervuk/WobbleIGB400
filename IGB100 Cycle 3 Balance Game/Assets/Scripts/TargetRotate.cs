using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRotate : MonoBehaviour
{
    public GameObject Target1Holder;
    public GameObject Target2Holder;

    public GameObject SpinTarget1;
    public GameObject SpinTarget2;
    public GameObject SpinTarget3;
    public GameObject SpinTarget4;
    public GameObject SpinTarget5;
    public GameObject SpinTarget6;
    public GameObject SpinTarget7;
    public GameObject SpinTarget8;
    public GameObject SpinTarget9;
    public GameObject SpinTarget10;
    public GameObject PlatformHolder;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Target1Holder.transform.Rotate(0, 1, 0);
        Target2Holder.transform.Rotate(0, -1, 0);

        SpinTarget1.transform.Rotate(0, 1, 0);
        SpinTarget2.transform.Rotate(1, 0, 0);
        SpinTarget3.transform.Rotate(1, 0, 0);
        SpinTarget4.transform.Rotate(1, 0, 0);
        SpinTarget5.transform.Rotate(1, 0, 0);
        SpinTarget6.transform.Rotate(1, 0, 0);
        SpinTarget7.transform.Rotate(1, 0, 0);
        SpinTarget8.transform.Rotate(1, 0, 0);
        SpinTarget9.transform.Rotate(1, 0, 0);
        SpinTarget10.transform.Rotate(1, 0, 0);

        //Target3Holder.transform.Rotate(1, 0, 0);
        PlatformHolder.transform.Rotate(0, -1, 0);

    }
}
