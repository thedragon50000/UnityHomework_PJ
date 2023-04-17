using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager24_sc : MonoBehaviour
{
    private CharacterData_sc c;
    public MyEnum e;

    // Start is called before the first frame update
    void Start()
    {
        c = new Senshi_sc();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            c.Skill1();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            c.Skill2();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            c.Skill3();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            c.Skill4();
        }
    }

}
    public enum MyEnum
    {
        A,B,C,D
    }
