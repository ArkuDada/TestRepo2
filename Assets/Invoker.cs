using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Invoker : MonoBehaviour
{
    public static Invoker Instance;
    
    public UnityEvent<Stat> OnStatChanged = new UnityEvent<Stat>();

    private Stat statA = new Stat();

    private void Awake()
    {
        Instance = this;
        
        statA.name = "HP";
        statA.value = 0;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(statA.value);
            OnStatChanged?.Invoke(statA);
            statA.value++;
        }
    }
}

public struct Stat
{
    public string name;
    public int value;
}

