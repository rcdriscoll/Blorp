using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satyr : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;

        //if it is a dawrf then dig
        if (otherObject.GetComponent<Dawrf>())
        {
            GetComponent<Animator>().SetTrigger("digTrigger");
        }

        //if the object ran into is a defender and not a dawrf
        else if (otherObject.GetComponent<Defender>())
        {
            //dig under the object
            GetComponent<Attacker>().Attack(otherObject);
        }
    }
}
