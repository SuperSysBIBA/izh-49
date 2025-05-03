using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temperatura : MonoBehaviour
{
    public health health ;
    public int playerDamage = 2;
    public float temperaturaCurret = 36.6f;
    public float temperaturaNormal = 36.6f;
    public float temperaturaCritical = 34f;
    public float freezeSpeed = 0.05f;
    public float freezeDamageTimer = 1;
     public float freezeDamageDelay = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (temperaturaCurret <=temperaturaCritical)
        { 
                health.TakeDamage(playerDamage);
                freezeDamageTimer += freezeDamageDelay;
        }
        else
        {
            freezeDamageTimer -=Time.deltaTime;
        }
    }

    void FixedUpdate()
    {
        temperaturaCurret -= freezeSpeed * Time.fixedDeltaTime;
    }
}
