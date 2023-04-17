using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager22_sc : MonoBehaviour
{
    private Player_sc p;

    // Start is called before the first frame update
    void Start()
    {
        p = new Player_sc();
        print(p._name);
        print(p._atk);
        print(p._hp);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            p.Skill1();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            p.Skill2();
        }
    }
}