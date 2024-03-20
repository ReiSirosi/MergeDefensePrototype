using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class AfkController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI afkTimeText;
    [SerializeField] private TextMeshProUGUI moneyReceiveText;

    [Space]
    [SerializeField] private GameObject AfkCanvas;

    [SerializeField] private int afkTime;
    private int afkTimeCount;
    [SerializeField] private int scaleToMoney;

    [Space]
    [SerializeField] private TextMeshProUGUI inputText;
    [SerializeField] private TMP_InputField inputField;

    public int moneyCounts;

    private void Start()
    {
       // GoAfk();
    }

    public void ChangeTimeText()
    {
        if (int.TryParse(inputField.text, out afkTimeCount))
        {
            moneyCounts = afkTimeCount * scaleToMoney;
            moneyReceiveText.text = moneyCounts.ToString();
        }
        else
        {
            // Если пользователь ввёл некорректное значение, можно выполнить действия по умолчанию или вывести сообщение об ошибке.
        }
    }

    public void GrabAndPlayButton()
    {
        GameConroller.money += moneyCounts;

        AfkCanvas.gameObject.SetActive(false);

        Time.timeScale = 1;
    }

    public void GoAfk()
    {
        AfkCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
