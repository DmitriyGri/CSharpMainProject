using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayFirstProject : MonoBehaviour
{
    void Start()
    {
        //int i = 0;

        //  while (i < 10)
        //  {
        //      i++;
        //      if (i % 2 == 0)
        //      {
        //          continue;
        //      }
        //      Debug.Log(i);
        //  }

        //for (int a = 0; a < 10; a++)
        //{
        //    Debug.Log(a);
        //}
        // �������������� ���������� ��� ����� � ������������
        float n = 25;
        int a = 0;
        int b = 1;

        // 2. ���������� ���� for ��� ���������� ����� � ������������
        for (int i = 1; i <= n; i++)
        {
            a += i; // ������� �����
            b *= i; // ������� ������������
        }

        // 3. ������� ���������� ����� � ������������ � �������
        Debug.Log($"����� ����� �� 1 �� {n} ����� {a}");
        Debug.Log($"������������ ����� �� 1 �� {n} ����� {b}");
    }




}




    // Start is called before the first frame update
    //void Start()
    //{
    //    Debug.Log("������� ����� ���������� �������: ");
    //    int drink = Convert.ToInt32(Console.ReadLine());

    //    switch (drink)
    //    {
    //        case 1:
    //            OrderCoffee("Cappuccino");
    //            break;
    //        case 2:
    //            OrderCoffee("�����");
    //            break;
    //        case 3:
    //            OrderCoffee("���������");
    //            break;
    //        case 4:
    //            OrderCoffee("�����");
    //            break;
    //        case 5:
    //            OrderCoffee("������� �������");
    //            break;
    //        case 6:
    //            OrderCoffee("��� � �������");
    //            break;
    //        case 7:
    //            OrderCoffee("������� ����");
    //            break;
    //        default:
    //            Debug.Log("������������ �����. ����������, �������� ����� �� 1 �� 7.");
    //            break;
    //    }
    //}

    //static void OrderCoffee(string drinkName)
    //{
    //    Debug.Log($"�� �������: {drinkName}");
    //}

