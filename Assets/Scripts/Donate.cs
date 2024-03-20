using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class Donate : MonoBehaviour
{
    [SerializeField] private int smallDonateMoney;
    [SerializeField] private int middleDonateMoney;
    [SerializeField] private int highDonateMoney;
    [SerializeField] private int ExclusiveDonateMoney;

    [Space]
    [SerializeField] private TextMeshProUGUI smallMoneyText;
    [SerializeField] private TextMeshProUGUI middleMoneyText;
    [SerializeField] private TextMeshProUGUI highMoneyText;
    [SerializeField] private TextMeshProUGUI exclusiveMoneyText;

    [Space]
    [SerializeField] private GameObject donateCanvas;

    [Space]
    [SerializeField] private Button exclusiveDonateButton;
    [SerializeField] private GameObject specialOffer;


    private bool exIsDone;
    private void Awake()
    {
        exIsDone = false;
    }

    private void Update()
    {
        ChangeText();
    }

    public void SmallDonate()
    {
        GameConroller.money += smallDonateMoney;
    }

    public void MiddleDonate()
    {
        GameConroller.money += middleDonateMoney;
    }

    public void HighDonate()
    {
        GameConroller.money += highDonateMoney;
    }

    public void ExclusiveDonate()
    {
        if (!exIsDone)
        {
            GameConroller.money += ExclusiveDonateMoney;
            exIsDone = true;
            exclusiveDonateButton.interactable = false;
            specialOffer.gameObject.SetActive(false);
        }
    }

    private void ChangeText()
    {
        smallMoneyText.text = Convert.ToString(smallDonateMoney);
        middleMoneyText.text = Convert.ToString(middleDonateMoney);
        highMoneyText.text = Convert.ToString(highDonateMoney);
        exclusiveMoneyText.text = Convert.ToString(ExclusiveDonateMoney);
    }

    public void ActivateDonateCanvas()
    {
        donateCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void DeactivateDonateCanvas()
    {
        donateCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
