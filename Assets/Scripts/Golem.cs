using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;

        //if the object ran into is a defender
        if (otherObject.GetComponent<Defender>())
        {
            //attack the other object
            GetComponent<Attacker>().Attack(otherObject);
        }
    }
}
