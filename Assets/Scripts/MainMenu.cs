using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // библиотека для работы со сценой
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // 0 - Меню
    // 1 - Игра
    // 2 - Проигрыш

    public int money;
    public int earnedMoney; // заработанные деньги
    public Text moneyText;

    private void Start()
    {
        money = PlayerPrefs.GetInt("Money");
        earnedMoney = PlayerPrefs.GetInt("Score"); // Сколько мы очков набрали за предыдущую игру
        money += earnedMoney; 
        PlayerPrefs.SetInt("Money", money); // сохранили в реестр
        moneyText.text = money.ToString();

        // исправляем баг, который при заходе в игру позволяет бесплатно получать деньги
        earnedMoney = 0;
        PlayerPrefs.SetInt("Score", earnedMoney);

        // при заходе в игру нам попросту не 
        earnedMoney = 0;
        PlayerPrefs.SetInt("Score", earnedMoney);

    }
    public void StartGame() 
    {
        SceneManager.LoadScene(1); // с помощью данного метода мы будем перенаправлены на игровую сцену
    }

    public void Shop() 
    {
        SceneManager.LoadScene(3); // тут мы будем перенаправлены в магазин
    }
}
