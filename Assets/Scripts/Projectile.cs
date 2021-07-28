using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

   
    // Update is called once per frame
    private void OncollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Target"))
        {
            collision.collider.GetComponent<Renderer>().material.color = Color.red;
            Destroy(collision.gameObject, 1);
            
            collision.gameObject.GetComponent<Target>().Hit();
            Destroy(gameObject, 0.2f);
        }

        if(collision.gameObject.CompareTag("Target"))
        {
            collision.gameObject.GetComponent<Target>().Hit();
            Destroy(gameObject);
        }

        
    }


}
