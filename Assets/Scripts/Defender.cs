using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int blorpCost = 100;
    GameObject currentTarget;


    public void AddBlorp(int amount)
    {
        FindObjectOfType<BlorpDisplay>().AddBlorp(amount);
    }

    public int GetBlorpCost()
    {
        return blorpCost;
    }

    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("IsAttacking", true);
        currentTarget = target;
    }

    public void StrikeCurrentTarget(float damage)
    {
        //checks to see if target has been destroyed
        if (!currentTarget)
        {
            GetComponent<Animator>().SetBool("IsAttacking", false);
            return;
        }

        Health health = currentTarget.GetComponent<Health>();

        if (health)
        {
            health.DealDamage(damage);
        }
    }
}
