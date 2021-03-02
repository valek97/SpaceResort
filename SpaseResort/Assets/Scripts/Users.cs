using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Users : MonoBehaviour
{
    public int DayToEnd = 50;
    public int Credits = 15000;
    public float Repitation = 10;
    public Text MoneyTextField;
    public Text RepitationField;
    public Text DayToEndField;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoneyTextField.text = "Количество cr: " + Credits.ToString();
        RepitationField.text = "Репутация: " + Repitation.ToString();
        DayToEndField.text = "Остаток дней: " + DayToEnd.ToString();
    }
}
