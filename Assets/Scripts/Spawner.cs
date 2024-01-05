using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos;
    [SerializeField] Vector2 range; // то есть в каком промежутке у нас будет допустимо создание объектов 
    [SerializeField] GameObject enemy; // и тот объект который мы будем спавнить
    [SerializeField] GameObject bonus;

    
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn() 
    {
        // тут мы будем указывать с какой переодичностью будет выполняться действие
        yield return new WaitForSeconds(1.5f); // WaitForSeconds - то есть сколько секунд мы будем ждать
        Vector2 pos = spawnPos.position + new Vector3(0, Random.Range(-range.y, range.y)); // мы посчитали координату точки

        // теперь создаем объект для этого используем метод Instantiate
        Instantiate(enemy, pos, Quaternion.identity); //(какой объект надо спавнить, координаты, перегрузка)
        Instantiate(bonus, pos, Quaternion.identity);
        Repeat(); // теперь этот метод будет вызываться бесконечно
    }

    void Repeat() // метод для бесконечного спавна 
    {
        StartCoroutine(Spawn());
    }
    
}
