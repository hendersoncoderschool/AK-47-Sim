using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pscript : MonoBehaviour
{
    private Rigidbody playerRb;
    private float E = 10;
    public bool gameOver = false;
    public bool isOnGround = true;
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Ground")) {
            isOnGround = true;
        } else if (collision.gameObject.CompareTag("Obstacle")) {
            gameOver = true;
            Debug.Log("Game Over!");}}
    private Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.left * Time.deltaTime * E);
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true) {
            playerRb.AddForce(Vector3.up * E, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
        }
    }
}
