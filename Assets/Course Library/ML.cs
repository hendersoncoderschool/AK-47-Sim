using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ML : MonoBehaviour
// Why is pi called pi? It sounds like pie. What if people eat pi thinking it's pie?
{
    private float speed = 30;
    //public bool gameOver = false;
    private Pscript playerControllerScript;
   
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript =
        GameObject.Find("Player").GetComponent<Pscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false) {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
