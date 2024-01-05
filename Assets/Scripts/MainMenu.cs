using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // ���������� ��� ������ �� ������
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // 0 - ����
    // 1 - ����
    // 2 - ��������

    public int money;
    public int earnedMoney; // ������������ ������
    public Text moneyText;

    private void Start()
    {
        money = PlayerPrefs.GetInt("Money");
        earnedMoney = PlayerPrefs.GetInt("Score"); // ������� �� ����� ������� �� ���������� ����
        money += earnedMoney; 
        PlayerPrefs.SetInt("Money", money); // ��������� � ������
        moneyText.text = money.ToString();

        // ���������� ���, ������� ��� ������ � ���� ��������� ��������� �������� ������
        earnedMoney = 0;
        PlayerPrefs.SetInt("Score", earnedMoney);

        // ��� ������ � ���� ��� �������� �� 
        earnedMoney = 0;
        PlayerPrefs.SetInt("Score", earnedMoney);

    }
    public void StartGame() 
    {
        SceneManager.LoadScene(1); // � ������� ������� ������ �� ����� �������������� �� ������� �����
    }

    public void Shop() 
    {
        SceneManager.LoadScene(3); // ��� �� ����� �������������� � �������
    }
}
