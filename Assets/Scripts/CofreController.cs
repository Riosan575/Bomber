using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofreController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Piso")
        {
            Destroy(this.gameObject);
        }
        if(other.gameObject.tag == "Bala")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
