using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NoKill : MonoBehaviour, IHealth
{
    [SerializeField]
    private int healthInHits = 5;
    private bool canTakeDamage = true;

    public event Action<float> OnHPPctChanged = delegate (float f) { };
    public event Action OnDied = delegate { };

    public void TakeDamage(int amount)
    {
        if (canTakeDamage)
        {
            Debug.Log("test");
            GetComponent<BGSwitch>().SwitchProps();

        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(healthInHits);
        }
    }
}