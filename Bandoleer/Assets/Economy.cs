using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Economy : MonoBehaviour
{
  public int money;
  Text moneyText;

   void Start() 
  {
    moneyText = GameObject.FindWithTag("moneyTxt").GetComponent<Text>(); 
  }

   void Update() 
  {
    moneyText.text = money.ToString();
  }
}
