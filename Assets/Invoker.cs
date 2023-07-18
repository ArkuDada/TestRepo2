using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Invoker : MonoBehaviour
{
    public static Invoker Instance;

    public UnityEvent<Stat> OnStatChanged = new UnityEvent<Stat>();

  
    private Stat statABCDEFLOL = new Stat();

    private void Awake()
    {
        Instance = this;

        statABCDEFLOL.name = "HP";
        statABCDEFLOL.value = 0;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(statABCDEFLOL.value);
            OnStatChanged?.Invoke(statABCDEFLOL);
            statABCDEFLOL.value++;
        }
    }
}

public struct Stat
{
    public string name;
    public int value;
}
