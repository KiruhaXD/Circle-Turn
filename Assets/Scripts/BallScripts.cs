using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallScripts : MonoBehaviour
{
    public int score; // очки
    public bool isMulti; // создаем переменную для того чтобы у нас удваивались очки при покупке бонуса
    [SerializeField] Text scoreText;

    public GameObject bonusEffect;

    public void Start()
    {
        isMulti = PlayerPrefs.GetInt("isMulti") == 1 ? true : false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bonus") 
        {
            Destroy(other.gameObject);
            // создаем объект типа "bonusEffect", принимаем позицию шарика
            Instantiate(bonusEffect, transform.position, Quaternion.identity);

            if (isMulti)
                score += 2; // удваиваем очки, если у нас есть бонус x2
            else
                score++;
        }

        if (other.gameObject.tag == "Enemy") 
        {
            // PlayerPrefs - это такая система,
            // которая позволяет сохранять данны, посредством записи в реестор

            // метод SetInt - записывает целочисленное значение в реестр под названием "Score" и значением score
            PlayerPrefs.SetInt("Score", score); 
            SceneManager.LoadScene(2);
        }
    }

    void Update()
    {
        scoreText.text = score.ToString(); // переводим интовое(int) значение в строку(string)
    }
}
