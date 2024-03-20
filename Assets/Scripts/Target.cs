using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private int damageToMonster;
    [SerializeField] private int damageToPlayer;

    [SerializeField] private GameConroller gameConroller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            Monsters enemy = other.gameObject.GetComponent<Monsters>();
            if (enemy != null)
            {
                HitPlayer();
                enemy.TakeDamage(damageToMonster);
            }
        }
    }

    private void HitPlayer()
    {
        gameConroller.TakeDamage(damageToPlayer);
    }
}
