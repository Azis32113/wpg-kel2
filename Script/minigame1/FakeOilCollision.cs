using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeOilCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D Collision)
    {

        if (Collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }

        else
        {
            ScoreScript.ScoreValue -= 10;
            Destroy(gameObject);
        }

    }

}