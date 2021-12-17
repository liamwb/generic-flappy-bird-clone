using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathControl : MonoBehaviour
{
    public static DeathControl deathControl;
    public bool isDead;
    void Awake() 
    {
        if (deathControl == null)
        {
            deathControl = this;
        }
        
        isDead = false;
    }
    
}
