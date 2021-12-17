using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "birb")
        {
            Destroy(collision.gameObject);
            DeathControl.deathControl.isDead = true;
        }
    }
}
