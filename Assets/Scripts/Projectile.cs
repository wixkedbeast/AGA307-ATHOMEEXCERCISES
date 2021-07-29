using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    
    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Target"))
        {
            collision.collider.GetComponent<Renderer>().material.color = Color.red;
            Destroy(collision.collider.gameObject, 1f);
            
            collision.gameObject.GetComponent<Target>().Hit();

           
            Destroy(this.gameObject);

        }

        //if(collision.gameObject.CompareTag("Target"))
        //{
            //collision.gameObject.GetComponent<Target>().Hit();
            //Destroy(gameObject);
        //}

        
    }


}
