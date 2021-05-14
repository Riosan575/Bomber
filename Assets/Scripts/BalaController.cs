using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaController : MonoBehaviour
{
    public float TiempoVida = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TiempoVida -= Time.deltaTime;
        if(TiempoVida <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
