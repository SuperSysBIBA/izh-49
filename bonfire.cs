using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonfire : MonoBehaviour
{
    public float LifeTime = 15;
    public float heatPower=0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LifeTime -= Time.deltaTime;
        if (LifeTime <=0)

        gameObject.SetActive(false);
    }
    void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<temperatura>() != null)
{
    temperatura temperatura = other.GetComponent<temperatura>();
    if(temperatura.temperaturaCurret <temperatura.temperaturaNormal)
    {
        temperatura.temperaturaCurret += heatPower * Time.deltaTime;
    }
}
    }
}
