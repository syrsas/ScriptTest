using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int mp = 53;
    private int power = 25;

    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        this.hp -= damage;
    }
    public void Magic(int shohi)
    {
        if (mp >= shohi)
        {
            this.mp = mp - shohi;
            Debug.Log("���@�U���������B�c��MP��" + mp);
        }
        if (mp < shohi)
        {
            Debug.Log("�c��MP��" + mp + "MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
}
public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {       
        Boss lastboss = new Boss();
        Boss midboss = new Boss();
        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic(5);
        }
        Hairetsu();
    }

    void Hairetsu()
    {
        int i = 5, sum = 0;
        int[] array = new int[5] { 1, 3, 5, 7, 9 };

        for (int j = 0; j < array.Length; j++)
        {
            Debug.Log(array[j]);
        }

        for (int k = 4; k <= array.Length; k--)
        {
            if (k<0)
            {
                break;
            }
            Debug.Log(array[k]);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
