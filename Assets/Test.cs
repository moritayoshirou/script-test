using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss

{

    private int hp = 100; // �̗�
    private int power = 99; // �U����
    public int mp = 53; //�@�m��







    //�@�U���p�̊֐�

    public void Attack(int damage)

    {
        Debug.Log(this.power + damage + "�̃_���[�W��^����");


    }
    //�@�h��p�̊֐�

    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");

        //�c��HP�����炷
        this.hp -= damage;
    }


    //�@���@�p�̊֐�

    public void Magic(int damage)

    {



        if (mp >= 5)
        {
            this.mp -= damage;

            Debug.Log("���@�U���������B�c��MP��" + mp);
        }
        else
        {
            Debug.Log("MP���s�����Ă��܂�");
        }

    }




}











public class Test : MonoBehaviour



{

    void Start()
    {

        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����

        Boss lastboss = new Boss();

        // �U���p�̊֐����Ăяo��

        lastboss.Attack(50);

        //�h��p�̊֐����Ăяo��

        lastboss.Defence(99);

            //���@�p�̊֐����Ăяo��

            for (int b = 0; b < 11; b++)
            {
                lastboss.Magic(5);
            }




        //�v�f��5�̔z�������������
        int[] array = new int[5];

        //�z��̊e�v�f�ɒl��������
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;


        //for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\������
        for (int i = 0; i < 5; i++)


        {

            Debug.Log(array[i]);
        }









        //�v�f��5�̔z�������������
        int[] ray = new int[5];

        //�z��̊e�v�f�ɒl��������
        ray[0] = 1;
        ray[1] = 2;
        ray[2] = 3;
        ray[3] = 4;
        ray[4] = 5;

        //for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\������
        for (int a = 4; a > -1; a--)

        {

            Debug.Log(ray[a]);
        }













    }







    // Update is called once per frame

    void Update()
    {

    }

}