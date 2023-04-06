using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss

{

    private int hp = 100; // 体力
    private int power = 99; // 攻撃力
    public int mp = 53; //　知力







    //　攻撃用の関数

    public void Attack(int damage)

    {
        Debug.Log(this.power + damage + "のダメージを与えた");


    }
    //　防御用の関数

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");

        //残りHPを減らす
        this.hp -= damage;
    }


    //　魔法用の関数

    public void Magic(int damage)

    {



        if (mp >= 5)
        {
            this.mp -= damage;

            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが不足しています");
        }

    }




}











public class Test : MonoBehaviour



{

    void Start()
    {

        // Bossクラスの変数を宣言してインスタンスを代入

        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す

        lastboss.Attack(50);

        //防御用の関数を呼び出す

        lastboss.Defence(99);

            //魔法用の関数を呼び出す

            for (int b = 0; b < 11; b++)
            {
                lastboss.Magic(5);
            }




        //要素数5の配列を初期化する
        int[] array = new int[5];

        //配列の各要素に値を代入する
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;


        //for文を使い、配列の各要素の値を順番に表示する
        for (int i = 0; i < 5; i++)


        {

            Debug.Log(array[i]);
        }









        //要素数5の配列を初期化する
        int[] ray = new int[5];

        //配列の各要素に値を代入する
        ray[0] = 1;
        ray[1] = 2;
        ray[2] = 3;
        ray[3] = 4;
        ray[4] = 5;

        //for文を使い、配列の各要素の値を順番に表示する
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