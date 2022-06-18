using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buzz : MonoBehaviour
{
    [SerializeField] Rigidbody m_rigidBody;

    void Start()
    {
        StartCoroutine(Launch());
    }

    IEnumerator Launch()
    {
        //wait three seconds before letting buzz fall
        m_rigidBody.useGravity = false;

        yield return new WaitForSeconds(3);
        m_rigidBody.useGravity = true;
        var velDirection = new Vector3(0f, 0f, .6f) - transform.position;
        m_rigidBody.velocity = Vector3.Normalize(velDirection) * 6;

    }
}
