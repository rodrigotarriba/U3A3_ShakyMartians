using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    [SerializeField] float m_shakeSpeed;
    [SerializeField] float m_shakeAmount;
    [SerializeField] float m_shakeTime;


    public void ShakeItUp()
    {
        // randomize shaking amount 
        m_shakeAmount *= Random.Range(.5f, 1f);
        StartCoroutine(Shaking());
    }

    IEnumerator Shaking()
    {

        while (m_shakeTime > 0)
        {
            // shake alien while the time is on
            m_shakeTime -= Time.deltaTime;
            transform.Rotate(Vector3.up, Mathf.Sin(Time.time * m_shakeAmount));

            yield return new WaitForEndOfFrame();
        }

    }
}
