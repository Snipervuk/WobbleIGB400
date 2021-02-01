using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawns : MonoBehaviour
{
    public GameObject RedCube, BlueCube, GreenCube, YellowCube, RedSphere, BlueSphere, GreenSphere, YellowSphere, RedPrism, BluePrism, GreenPrism, YellowPrism;

    public float SpawnRate = 10f;
    float NextSpawn = 0f;
    int WhatToSpawn;
    

    void Update()
    {
     if (Time.time > NextSpawn)
        {
            WhatToSpawn = Random.Range(1, 13);
            Debug.Log(WhatToSpawn);

            switch (WhatToSpawn)
            {
                case 1:
                    Instantiate(RedCube, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(BlueCube, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(GreenCube, transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(YellowCube, transform.position, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(RedSphere, transform.position, Quaternion.identity);
                    break;
                case 6:
                    Instantiate(BlueSphere, transform.position, Quaternion.identity);
                    break;
                case 7:
                    Instantiate(GreenSphere, transform.position, Quaternion.identity);
                    break;
                case 8:
                    Instantiate(YellowSphere, transform.position, Quaternion.identity);
                    break;
                case 9:
                    Instantiate(RedPrism, transform.position, Quaternion.identity);
                    break;
                case 10:
                    Instantiate(BluePrism, transform.position, Quaternion.identity);
                    break;
                case 11:
                    Instantiate(GreenPrism, transform.position, Quaternion.identity);
                    break;
                case 12:
                    Instantiate(YellowPrism, transform.position, Quaternion.identity);
                    break;
            }

            NextSpawn = Time.time + SpawnRate;

     }
    }
}
