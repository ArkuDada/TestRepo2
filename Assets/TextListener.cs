using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]

public class TextListener : MonoBehaviour
{
    private TextMeshProUGUI _textMeshProUGUI;

    private void Awake()
    {
        _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        Invoker.Instance.OnStatChanged.AddListener(ChangeText);
    }

    private void OnDisable()
    {
        Invoker.Instance.OnStatChanged.RemoveListener(ChangeText);
    }
    private void ChangeText(Stat stat)
    {
        _textMeshProUGUI.text = $"{stat.name}: {stat.value}";
    }
}
