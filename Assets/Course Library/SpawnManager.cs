using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obsicle;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnobsicle", 3.0f, 0.00002f);
    }

    // Update is called once per frame
    void spawnobsicle()
    {
        Instantiate(obsicle, new Vector3(23, 2, 0), Quaternion.identity);
    }
}
