using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_sc : MonoBehaviour
{
    public List<Enemy_sc> list_enemy = new List<Enemy_sc>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Random.Range(1, 11); i++)
        {
            EenemyType temp = (EenemyType) Random.Range(0, 3);
            Enemy_sc e = new Enemy_sc(temp);
            list_enemy.Add(e);
        }

        print(list_enemy.Count + "個敵人");

        for (int i = 0; i < list_enemy.Count; i++)
        {
            print(list_enemy[i].enemyName + list_enemy[i].HP + "滴血");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            for (int i = 0; i < list_enemy.Count; i++)
            {
                list_enemy[i].Injured(80);
                print(list_enemy[i].enemyName + list_enemy[i].HP + "滴血");
            }
        }
    }
}