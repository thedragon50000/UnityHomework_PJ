using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_sc : MonoBehaviour
{
    public List<Enemy_sc> listEnemy = new List<Enemy_sc>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Random.Range(1, 11); i++)
        {
            EenemyType temp = (EenemyType) Random.Range(0, 3);
            Enemy_sc e = new Enemy_sc(temp);
            listEnemy.Add(e);
        }

        print(listEnemy.Count + "個敵人");

        for (int i = 0; i < listEnemy.Count; i++)
        {
            print(listEnemy[i].enemyName + listEnemy[i].Hp + "滴血");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            for (int i = 0; i < listEnemy.Count; i++)
            {
                listEnemy[i].Injured(80);
                print(listEnemy[i].enemyName + listEnemy[i].Hp + "滴血");
            }
        }
    }
}