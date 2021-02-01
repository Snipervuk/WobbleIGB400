using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpawnerScript : MonoBehaviour
{
    public GameObject prefab;

    // start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // update is called once per frame
    IEnumerator Spawn()
    {
        while (true)
        {
            GameObject.Instantiate(prefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }
}
