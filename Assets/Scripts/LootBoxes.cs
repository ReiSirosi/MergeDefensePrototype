using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class LootBoxes : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI cardsTowerText;
    [SerializeField] private TextMeshProUGUI cardsSlotText;
    [SerializeField] private TextMeshProUGUI moneysText;
    [SerializeField] private Canvas lootBoxCanvas;

    [Space]
    [SerializeField] private int cardsTowerGiftCount;
    [SerializeField] private int cardsSlotGiftCount;
    private int moneyGiftCount;
    [SerializeField] private int lvlForLoot;

    [SerializeField] private Button button;
    [SerializeField] private TextMeshProUGUI lvlText;

    private int lootboxCounts;

    private void Start()
    {
        lootboxCounts = 1;
    }
    
    private void Update()
    {
        lvlText.text = Convert.ToString(lvlForLoot - 1);

        if (GameConroller.lvl >= lvlForLoot)
            button.interactable = true;
        else
            button.interactable = false;
    }

    public void AccesLootBox()
    {
        lootBoxCanvas.gameObject.SetActive(true);
        cardsTowerText.text = Convert.ToString(cardsTowerGiftCount);
        cardsSlotText.text = Convert.ToString(cardsSlotGiftCount);

        GameConroller.towersCardsCount += cardsTowerGiftCount;
        GameConroller.slotsCardsCount += cardsSlotGiftCount;

        lvlForLoot += 10; //повышение количества для следующего лутбокса

        MoneyGift();

        Time.timeScale = 0;
    }

    public void ExitLootCanvas()
    {
        Time.timeScale = 1;
        lootboxCounts += 1;
        lootBoxCanvas.gameObject.SetActive(false);
    }

    private void MoneyGift()
    {
        if (lootboxCounts == 1)
        {
            moneyGiftCount = 100;
            GameConroller.money += moneyGiftCount;
            moneysText.text = Convert.ToString(moneyGiftCount);
        }
        else if (lootboxCounts == 3)
        {
            moneyGiftCount = 200;
            GameConroller.money += moneyGiftCount;
            moneysText.text = Convert.ToString(moneyGiftCount);
        }
        else if (lootboxCounts == 4)
        {
            moneyGiftCount = 100;
            GameConroller.money += moneyGiftCount;
            moneysText.text = Convert.ToString(moneyGiftCount);
        }
        else if (lootboxCounts == 6)
        {
            moneyGiftCount = 300;
            GameConroller.money += moneyGiftCount;
            moneysText.text = Convert.ToString(moneyGiftCount);
        }
        else if (lootboxCounts == 8)
        {
            moneyGiftCount = 400;
            GameConroller.money += moneyGiftCount;
            moneysText.text = Convert.ToString(moneyGiftCount);
        }
        else if (lootboxCounts == 9)
        {
            moneyGiftCount = 500;
            GameConroller.money += moneyGiftCount;
            moneysText.text = Convert.ToString(moneyGiftCount);
        }
        else if (lootboxCounts == 10)
        {
            moneyGiftCount = 200;
            GameConroller.money += moneyGiftCount;
            moneysText.text = Convert.ToString(moneyGiftCount);
        }
        else if (lootboxCounts == 13)
        {
            moneyGiftCount = 600;
            GameConroller.money += moneyGiftCount;
            moneysText.text = Convert.ToString(moneyGiftCount);
        }
        else if (lootboxCounts == 17)
        {
            moneyGiftCount = 700;
            GameConroller.money += moneyGiftCount;
            moneysText.text = Convert.ToString(moneyGiftCount);
        }
        else if (lootboxCounts == 24)
        {
            moneyGiftCount = 1100;
            GameConroller.money += moneyGiftCount;
            moneysText.text = Convert.ToString(moneyGiftCount);
        }
        else if (lootboxCounts == 32)
        {
            moneyGiftCount = 900;
            GameConroller.money += moneyGiftCount;
            moneysText.text = Convert.ToString(moneyGiftCount);
        }
        else if (lootboxCounts == 34)
        {
            moneyGiftCount = 400;
            GameConroller.money += moneyGiftCount;
            moneysText.text = Convert.ToString(moneyGiftCount);
        }
        else if (lootboxCounts == 39)
        {
            moneyGiftCount = 1000;
            GameConroller.money += moneyGiftCount;
            moneysText.text = Convert.ToString(moneyGiftCount);
        }
        else
        {
            moneyGiftCount = 0;
            moneysText.text = Convert.ToString(moneyGiftCount);
        }
    }
}
