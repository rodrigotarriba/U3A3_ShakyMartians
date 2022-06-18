using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{


    private void OnCollisionEnter(Collision collision)
    {
        // If Buzz collides against table, alien layers shake
        var crashingObject = collision.gameObject;
        if (crashingObject.layer == LayerMask.NameToLayer("Buzz"))
        {
            // create a physics collision box that detects any object
            crashingObject.GetComponent<Rigidbody>().useGravity = true;
            var m_myAliensColliders = Physics.OverlapBox(Vector3.zero, new Vector3(10f,10f,10f));


            for (var i = 0; i < m_myAliensColliders.Length; i++)
            {
                // filter to only finding layer ALiens objects
                if(m_myAliensColliders[i].gameObject.layer == LayerMask.NameToLayer("Aliens"))
                {
                    Debug.Log($"{m_myAliensColliders[i].gameObject.layer}");
                    m_myAliensColliders[i].gameObject.GetComponentInParent<Alien>().ShakeItUp();
                }
                
            }
        }
    }
}
