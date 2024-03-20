using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monsters : MonoBehaviour
{
    [SerializeField] private int hp;
    [SerializeField] private int damage;
    [SerializeField] private int moneyForDetermination;


    private void Update()
    {
        Death();
    }

    private void Death()
    {
        if (hp <= 0)
        {
            GameConroller.money += moneyForDetermination;
            GameConroller.enemiesCountOnMap -= 1;
            Destroy(gameObject);
        }
    }

    public void Dead()
    {
        hp = 0;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;

        if (hp <= 0)
        {
            Dead();
        }
    }
}