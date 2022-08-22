using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigov2 : MonoBehaviour
{
    public EnemigoData data;
    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        if (data.isAlive==false)
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
        }
    }

    
    void OnMouseDown()
    {

        data.isAlive=false;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        gm.AddPoints(2);
    }
}
