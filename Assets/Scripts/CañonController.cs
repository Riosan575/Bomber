using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CañonController : MonoBehaviour
{
    public GameObject CanonCabeza;
    public Camera CamaraDeJuego;
    public GameObject Bala;
    public float fuerzadisparo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 PosicionMouse = Input.mousePosition;
        Vector3 PosicionGlobal = CamaraDeJuego.ScreenToWorldPoint(new Vector3(
            PosicionMouse.x,
            PosicionMouse.y,
            transform.position.z - CamaraDeJuego.transform.position.z
        ));

        CanonCabeza.transform.localEulerAngles = new Vector3(
            CanonCabeza.transform.localEulerAngles.x,
            CanonCabeza.transform.localEulerAngles.y,
            Mathf.Atan2((PosicionGlobal.y - CanonCabeza.transform.position.y),
                    (PosicionGlobal.x - CanonCabeza.transform.position.x)) * Mathf.Rad2Deg
        );

        if(Input.GetMouseButtonDown(0))
        {
            GameObject objectBala = Instantiate(Bala);
            objectBala.transform.position = CanonCabeza.transform.position;
            objectBala.GetComponent<Rigidbody2D>().AddForce(CanonCabeza.transform.right * fuerzadisparo);
            objectBala.transform.SetParent(this.transform);
        }
    }
}
