using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] float deathAnimationTime = 1.5f;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void DealDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        animator.SetBool("IsDead", true);
        Destroy(gameObject, deathAnimationTime);
    }
}
