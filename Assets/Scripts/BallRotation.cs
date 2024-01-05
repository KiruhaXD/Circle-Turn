using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation : MonoBehaviour
{
    [SerializeField] GameObject CenterCircle; // ������� ���� � ��������� �����, ������� �� ����� �������� ��������
    bool direction = false; // ����� � ��� ����� false, ����� ����� ���� ������ �������, � ����� true, �� �� �������

    void FixedUpdate() // � ���� ������ ������ �������� ��� ���� ����� ��� ����� �������� �� �����
    {
        if (direction == false)
            CenterCircle.transform.Rotate(0, 0, 140 * Time.deltaTime);
        else
            CenterCircle.transform.Rotate(0, 0, -140 * Time.deltaTime);

    }

    public void ChangeDirection() // ����� ��� ����� �����������
    {
        direction = !direction;
    }
}
