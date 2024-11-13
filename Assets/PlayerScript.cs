using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        plrMove();
    }
    
    void plrMove()
    {
        var inputDir = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W) == true)
        {
            inputDir.y = 1;
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            inputDir.y = -1;
        }
        rb.MovePosition(rb.position + inputDir.normalized * moveSpeed * Time.deltaTime);
    }
}
