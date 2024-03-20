using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Unity.VisualScripting;

public class GameConroller : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lvlText;
    [SerializeField] private TextMeshProUGUI moneyText;
    [SerializeField] private TextMeshProUGUI cardsText;
    [SerializeField] private TextMeshProUGUI slotText;

    [SerializeField] private Spawner spawner;

    public static int lvl;
    public static int money;
    public static int towersCardsCount = 0;
    public static int enemiesCountOnMap = 0;
    public static int slotsCardsCount = 0;

    [SerializeField] private int hpCount;
    [SerializeField] private int startMoneyCount;

    private string ohlvl;

    public GameObject[] enemies;

    private AfkController afkController;

    private void Start()
    {
        afkController = GetComponent<AfkController>();

        lvl = 1;
        money = startMoneyCount + afkController.moneyCounts;
        towersCardsCount = 0;
        slotsCardsCount = 0;
    }

    private void Update()
    {
        CHangeLvlText();

        ChangeTexts();
        enemies = GameObject.FindGameObjectsWithTag("enemy");
    }

    public void CHangeLvlText()
    {
        ohlvl = Convert.ToString(lvl - 1);
        lvlText.text = ohlvl;
    }

    public void TakeDamage(int damage)
    {
        hpCount -= damage;
        if (hpCount <= 0)
        {
            Dead();
        }
    }

    private void Dead()
    {
        lvl -= 1;
        spawner.currentLevel -= 1;
        for (int i = 0; i < enemies.Length; i++)
        {
            enemiesCountOnMap = 0;
            Destroy(enemies[i].gameObject);
        }

        hpCount = 1;
    }

    private void ChangeTexts()
    {
        moneyText.text = Convert.ToString(money);
        cardsText.text = Convert.ToString(towersCardsCount);
        slotText.text = Convert.ToString(slotsCardsCount);
    }
}
