using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    private Rigidbody2D rb;

    public float MovementSpeed = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
     var movement = Input.GetAxis("Horizontal");
     transform.position += new Vector3 (movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (movement == 0)
        {
            rb.velocity = new Vector2(0, 0);
        }

    }

    void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.CompareTag("TeleporterIn"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
    

}
