using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttackArea : MonoBehaviour
{
    [SerializeField] private int damage = 10;
    private bool canAttack = true;
    public float attackCooldown = 1f;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (canAttack && collider.GetComponent<Health>() != null)
        {
            Health health = collider.GetComponent<Health>();
            health.Damage(damage);

            // Disable further attacks and start the cooldown coroutine
            canAttack = false;
            StartCoroutine(AttackCooldown());
        }
    }

    private IEnumerator AttackCooldown()
    {
        // Wait for the specified cooldown duration
        yield return new WaitForSeconds(attackCooldown);

        // Re-enable the ability to attack
        canAttack = true;
    }
}
