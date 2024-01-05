using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation : MonoBehaviour
{
    [SerializeField] GameObject CenterCircle; // создаем поле в редакторе юнити, которое мы можем изменять значение
    bool direction = false; // когда у нас будет false, мячик будет идти против часовой, а когда true, то по часовой

    void FixedUpdate() // в этом методе задаем движение для того чтобы наш мячик крутился по кругу
    {
        if (direction == false)
            CenterCircle.transform.Rotate(0, 0, 140 * Time.deltaTime);
        else
            CenterCircle.transform.Rotate(0, 0, -140 * Time.deltaTime);

    }

    public void ChangeDirection() // метод для смены направления
    {
        direction = !direction;
    }
}
