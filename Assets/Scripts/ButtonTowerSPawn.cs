using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ButtonTowerSPawn : MonoBehaviour
{
    [SerializeField] private Button addButton;

    [Space]
    [SerializeField] private GameObject activateFirstSlots;
    [SerializeField] private GameObject activateSecondSlots;
    [SerializeField] private GameObject activateThirdSlots;
    [SerializeField] private GameObject activateSlots4;
    [SerializeField] private GameObject activateSlots5;
    [SerializeField] private GameObject activateSlots6;
    [SerializeField] private GameObject activateSlots7;
    [SerializeField] private GameObject activateSlots8;
    [SerializeField] private GameObject activateSlots9;
    [SerializeField] private GameObject activateSlots10;
    [SerializeField] private GameObject activateSlots11;
    [SerializeField] private GameObject activateSlots12;
    [SerializeField] private GameObject activateSlots13;
    [SerializeField] private GameObject activateSlots14;
    [SerializeField] private GameObject activateSlots15;

    private int countActivateSlots;
    private int countActivateTower;


    [Space]
    [SerializeField] private TextMeshProUGUI priceToBoughtTowerText;
    [SerializeField] private TextMeshProUGUI priceToBoughtSlotText;
    [SerializeField] private TextMeshProUGUI countCardsSlotText;
    [SerializeField] private TextMeshProUGUI countCardsTowerText;
    [Space]
    [SerializeField] private TextMeshProUGUI costText;

    [Space]
    [SerializeField] private GameObject towerPrefabLevel1;
    [SerializeField] private GameObject towerPrefabLevel2;
    [SerializeField] private GameObject towerPrefabLevel3;
    [SerializeField] private GameObject towerPrefabLevel4;
    [SerializeField] private GameObject towerPrefabLevel5;
    [SerializeField] private GameObject towerPrefabLevel6;
    [SerializeField] private GameObject towerPrefabLevel7;
    [SerializeField] private GameObject towerPrefabLevel8;
    [SerializeField] private GameObject towerPrefabLevel9;
    [SerializeField] private GameObject towerPrefabLevel10;
    [SerializeField] private GameObject towerPrefabLevel11;
    [SerializeField] private GameObject towerPrefabLevel12;
    
    [Space]
    [SerializeField] private GameObject[] slots;

    [Space]
    public int buyCost;

    [Space]
    [SerializeField] private int moneyForTowerCardsLvl;
    [SerializeField] private int countCardsToChangeTower; //сколько нужно собрать карточек, чтобы сменить префаб на 2 уровень


    [Space]
    [SerializeField] private int moneyForSlotCardsLvl;
    [SerializeField] private int countCardsToAddSlot; //сколько нужно собрать карточек


    private bool isBoughtToLVL2;
    private bool isBoughtToLVL3;
    private bool isBoughtToLVL4;
    private bool isBoughtToLVL5;
    private bool isBoughtToLVL6;
    private bool isBoughtToLVL7;
    private bool isBoughtToLVL8;
    private bool isBoughtToLVL9;

    private void Start()
    {
        countActivateSlots = 0;
        countActivateTower = 0;
        isBoughtToLVL2 = false;
        isBoughtToLVL3 = false;
        isBoughtToLVL4 = false;
        isBoughtToLVL5 = false;
        isBoughtToLVL6 = false;
        isBoughtToLVL7 = false;
        isBoughtToLVL8 = false;
        isBoughtToLVL9 = false;
    }

    private void Update()
    {
        ChangeTexts();
        ChackForEnoughMoney();
    }


    public void SpawnTower()
    {
        for (int i = 0; i < slots.Length; i++)   // прохожусь по всему массиву слотов
        {
            if (slots[i].transform.childCount == 0)         //если слот пустой, то
            {
                if (GameConroller.money >= buyCost)         //проверка на наличие денег
                {
                    GameConroller.money -= buyCost;

                    if (!isBoughtToLVL2 && !isBoughtToLVL9 && !isBoughtToLVL8 && !isBoughtToLVL7 && !isBoughtToLVL6 && !isBoughtToLVL5 && !isBoughtToLVL4 && !isBoughtToLVL3)             //десь будет спавнится только тавера первого типа первого уровня
                    {
                        Instantiate(towerPrefabLevel1, slots[i].transform.position, Quaternion.identity, slots[i].transform);
                    }

                    else if (isBoughtToLVL2 && !isBoughtToLVL9 && !isBoughtToLVL8 && !isBoughtToLVL7 && !isBoughtToLVL6 && !isBoughtToLVL5 && !isBoughtToLVL4 && !isBoughtToLVL3)     //если же карточек достаточно, то спавнится тавер первого типа 9 уровня
                    {
                        Instantiate(towerPrefabLevel2, slots[i].transform.position, Quaternion.identity, slots[i].transform);
                    }

                    else if (isBoughtToLVL3 && !isBoughtToLVL9 && !isBoughtToLVL8 && !isBoughtToLVL7 && !isBoughtToLVL6 && !isBoughtToLVL5 && !isBoughtToLVL4 && !isBoughtToLVL2)     //если же карточек достаточно, то спавнится тавер первого типа 8 уровня
                    {
                        Instantiate(towerPrefabLevel3, slots[i].transform.position, Quaternion.identity, slots[i].transform);
                    }

                    else if (isBoughtToLVL4 && !isBoughtToLVL9 && !isBoughtToLVL8 && !isBoughtToLVL7 && !isBoughtToLVL6 && !isBoughtToLVL5 && !isBoughtToLVL3 && !isBoughtToLVL2)     //если же карточек достаточно, то спавнится тавер первого типа 7 уровня
                    {
                        Instantiate(towerPrefabLevel4, slots[i].transform.position, Quaternion.identity, slots[i].transform);
                    }

                    else if (isBoughtToLVL5 && !isBoughtToLVL9 && !isBoughtToLVL8 && !isBoughtToLVL7 && !isBoughtToLVL6 && !isBoughtToLVL3 && !isBoughtToLVL4 && !isBoughtToLVL2)     //если же карточек достаточно, то спавнится тавер первого типа 6 уровня
                    {
                        Instantiate(towerPrefabLevel5, slots[i].transform.position, Quaternion.identity, slots[i].transform);
                    }

                    else if (isBoughtToLVL6 && !isBoughtToLVL9 && !isBoughtToLVL8 && !isBoughtToLVL7 && !isBoughtToLVL3 && !isBoughtToLVL5 && !isBoughtToLVL4 && !isBoughtToLVL2)     //если же карточек достаточно, то спавнится тавер первого типа 5 уровня
                    {
                        Instantiate(towerPrefabLevel6, slots[i].transform.position, Quaternion.identity, slots[i].transform);
                    }

                    else if (isBoughtToLVL7 && !isBoughtToLVL9 && !isBoughtToLVL8 && !isBoughtToLVL3 && !isBoughtToLVL6 && !isBoughtToLVL5 && !isBoughtToLVL4 && !isBoughtToLVL2)     //если же карточек достаточно, то спавнится тавер первого типа 4 уровня
                    {
                        Instantiate(towerPrefabLevel7, slots[i].transform.position, Quaternion.identity, slots[i].transform);
                    }

                    else if (isBoughtToLVL8 && !isBoughtToLVL9 && !isBoughtToLVL3 && !isBoughtToLVL7 && !isBoughtToLVL6 && !isBoughtToLVL5 && !isBoughtToLVL4 && !isBoughtToLVL2)     //если же карточек достаточно, то спавнится тавер первого типа 3 уровня
                    {
                        Instantiate(towerPrefabLevel8, slots[i].transform.position, Quaternion.identity, slots[i].transform);
                    }

                    else if (isBoughtToLVL9 && !isBoughtToLVL3 && !isBoughtToLVL8 && !isBoughtToLVL7 && !isBoughtToLVL6 && !isBoughtToLVL5 && !isBoughtToLVL4 && !isBoughtToLVL2)     //если же карточек достаточно, то спавнится тавер первого типа 2 уровня
                    {
                        Instantiate(towerPrefabLevel9, slots[i].transform.position, Quaternion.identity, slots[i].transform);
                    }
                }
                break;
            }
        }
    }

    public void BuyCardButton()
    {
        if (GameConroller.towersCardsCount >= countCardsToChangeTower)
        {
            if (GameConroller.money >= moneyForTowerCardsLvl)
            {
                if (countActivateTower == 0)
                {
                    isBoughtToLVL2 = true;
                    GameConroller.money -= moneyForTowerCardsLvl;
                    countCardsToChangeTower += 20; 
                    moneyForTowerCardsLvl += 100;
                    buyCost += 5;
                }
                if (countActivateTower == 1)
                {
                    isBoughtToLVL3 = true;
                    isBoughtToLVL2 = false;
                    GameConroller.money -= moneyForTowerCardsLvl;
                    countCardsToChangeTower += 40;
                    moneyForTowerCardsLvl += 100;
                    buyCost += 5;
                }
                if (countActivateTower == 2)
                {
                    isBoughtToLVL4 = true;
                    isBoughtToLVL3 = false;
                    GameConroller.money -= moneyForTowerCardsLvl;
                    countCardsToChangeTower += 30;
                    moneyForTowerCardsLvl += 100;
                    buyCost += 5;
                }
                if (countActivateTower == 3)
                {
                    isBoughtToLVL5 = true;
                    isBoughtToLVL4 = false;
                    GameConroller.money -= moneyForTowerCardsLvl;
                    countCardsToChangeTower += 30;
                    moneyForTowerCardsLvl += 100;
                    buyCost += 10;
                }
                if (countActivateTower == 4)
                {
                    isBoughtToLVL6 = true;
                    isBoughtToLVL5 = false;
                    GameConroller.money -= moneyForTowerCardsLvl;
                    countCardsToChangeTower += 50;
                    moneyForTowerCardsLvl += 100;
                    buyCost += 10;
                }
                if (countActivateTower == 5)
                {
                    isBoughtToLVL7 = true;
                    isBoughtToLVL6 = false;
                    GameConroller.money -= moneyForTowerCardsLvl;
                    countCardsToChangeTower += 50;
                    moneyForTowerCardsLvl += 100;
                    buyCost += 10;
                }
                if (countActivateTower == 6)
                {
                    isBoughtToLVL8 = true;
                    isBoughtToLVL7 = false;
                    GameConroller.money -= moneyForTowerCardsLvl;
                    countCardsToChangeTower += 50;
                    moneyForTowerCardsLvl += 100;
                    buyCost += 10;
                }
                if (countActivateTower == 7)
                {
                    isBoughtToLVL9 = true;
                    isBoughtToLVL8 = false;
                    GameConroller.money -= moneyForTowerCardsLvl;
                    countCardsToChangeTower += 50;
                    moneyForTowerCardsLvl += 100;
                    buyCost += 10;
                }
            }
        }
    }

    public void BuyCardsSlotButton()
    {
        Debug.Log(GameConroller.slotsCardsCount);
        Debug.Log(">");
        Debug.Log(countCardsToAddSlot);
        Debug.Log(GameConroller.money);
        Debug.Log(">");
        Debug.Log(moneyForSlotCardsLvl);

        if (GameConroller.slotsCardsCount >= countCardsToAddSlot)
        {
            if (GameConroller.money >= moneyForSlotCardsLvl)
            {
                if (countActivateSlots == 0)
                {
                    GameConroller.money -= moneyForSlotCardsLvl;
                    activateFirstSlots.gameObject.SetActive(true);

                    countActivateSlots += 1;
                    countCardsToAddSlot += 6;
                    moneyForSlotCardsLvl += 100;
                }
                else if (countActivateSlots == 1)
                {
                    GameConroller.money -= moneyForSlotCardsLvl;
                    activateSecondSlots.gameObject.SetActive(true);

                    countActivateSlots += 1;
                    countCardsToAddSlot += 12;
                    moneyForSlotCardsLvl += 100;
                }
                else if (countActivateSlots == 2)
                {
                    GameConroller.money -= moneyForSlotCardsLvl;
                    activateThirdSlots.gameObject.SetActive(true);

                    countActivateSlots += 1;
                    countCardsToAddSlot += 8;
                    moneyForSlotCardsLvl += 100;
                }
                else if (countActivateSlots == 3)
                {
                    GameConroller.money -= moneyForSlotCardsLvl;
                    activateSlots4.gameObject.SetActive(true);

                    countActivateSlots += 1;
                    countCardsToAddSlot += 7;
                    moneyForSlotCardsLvl += 100;
                }
                else if (countActivateSlots == 4)
                {
                    GameConroller.money -= moneyForSlotCardsLvl;
                    activateSlots5.gameObject.SetActive(true);

                    countActivateSlots += 1;
                    countCardsToAddSlot += 13;
                    moneyForSlotCardsLvl += 100;
                }
                else if (countActivateSlots == 5)
                {
                    GameConroller.money -= moneyForSlotCardsLvl;
                    activateSlots6.gameObject.SetActive(true);

                    countActivateSlots += 1;
                    countCardsToAddSlot += 16;
                    moneyForSlotCardsLvl += 100;
                }
                else if (countActivateSlots == 6)
                {
                    GameConroller.money -= moneyForSlotCardsLvl;
                    activateSlots7.gameObject.SetActive(true);

                    countActivateSlots += 1;
                    countCardsToAddSlot += 30;
                    moneyForSlotCardsLvl += 100;
                }
                else if (countActivateSlots == 7)
                {
                    GameConroller.money -= moneyForSlotCardsLvl;
                    activateSlots8.gameObject.SetActive(true);

                    countActivateSlots += 1;
                    countCardsToAddSlot += 30;
                    moneyForSlotCardsLvl += 100;
                }
                else if (countActivateSlots == 8)
                {
                    GameConroller.money -= moneyForSlotCardsLvl;
                    activateSlots9.gameObject.SetActive(true);

                    countActivateSlots += 1;
                    countCardsToAddSlot += 30;
                    moneyForSlotCardsLvl += 100;
                }
                else if (countActivateSlots == 9)
                {
                    GameConroller.money -= moneyForSlotCardsLvl;
                    activateSlots10.gameObject.SetActive(true);

                    countActivateSlots += 1;
                    countCardsToAddSlot += 30;
                    moneyForSlotCardsLvl += 100;
                }
                else if (countActivateSlots == 10)
                {
                    GameConroller.money -= moneyForSlotCardsLvl;
                    activateSlots11.gameObject.SetActive(true);

                    countActivateSlots += 1;
                    countCardsToAddSlot += 30;
                    moneyForSlotCardsLvl += 100;
                }
                else if (countActivateSlots == 11)
                {
                    GameConroller.money -= moneyForSlotCardsLvl;
                    activateSlots12.gameObject.SetActive(true);

                    countActivateSlots += 1;
                    countCardsToAddSlot += 30;
                    moneyForSlotCardsLvl += 100;
                }
                else if (countActivateSlots == 12)
                {
                    GameConroller.money -= moneyForSlotCardsLvl;
                    activateSlots13.gameObject.SetActive(true);

                    countActivateSlots += 1;
                    countCardsToAddSlot += 30;
                    moneyForSlotCardsLvl += 100;
                }
                else if (countActivateSlots == 13)
                {
                    GameConroller.money -= moneyForSlotCardsLvl;
                    activateSlots14.gameObject.SetActive(true);

                    countActivateSlots += 1;
                    countCardsToAddSlot += 30;
                    moneyForSlotCardsLvl += 100;
                }
                else if (countActivateSlots == 14)
                {
                    GameConroller.money -= moneyForSlotCardsLvl;
                    activateSlots15.gameObject.SetActive(true);

                    countActivateSlots += 1;
                    countCardsToAddSlot += 30;
                    moneyForSlotCardsLvl += 100;
                }
            }
        }
    }

    private void ChackForEnoughMoney()
    {
        if (GameConroller.money >= buyCost)
            addButton.interactable = true;
        else
            addButton.interactable = false;
    }

    private void ChangeTexts()
    {
        priceToBoughtTowerText.text = Convert.ToString(moneyForTowerCardsLvl);
        priceToBoughtSlotText.text = Convert.ToString(moneyForSlotCardsLvl);

        countCardsSlotText.text = Convert.ToString(countCardsToAddSlot);
        countCardsTowerText.text = Convert.ToString(countCardsToChangeTower);

        costText.text = Convert.ToString(buyCost);
    }
}