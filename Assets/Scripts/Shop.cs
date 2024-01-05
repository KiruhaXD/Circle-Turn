using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    public int money;
    public Text moneyText;
    public bool isMulti = false;


    void Start()
    {
        money = PlayerPrefs.GetInt("Money");
    }


    void Update()
    {
        moneyText.text = money.ToString();
    }

    public void BuyMulti() // для каждого нового товара нам нужно создавать новый метод
    {
                          // значение isMulti == false для того чтобы пользователь не купил одну акцию два раза
        if (money >= 10 && isMulti == true)
        {
            isMulti = true;
            money -= 10;
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("isMulti", isMulti ? 1 : 0);
        }

    }

    public void ExitShop() 
    {
        SceneManager.LoadScene(0);
    }
}
