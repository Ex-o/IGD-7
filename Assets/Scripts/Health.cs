using System;
using UnityEngine;

public class Health : IModel
{
    public event Action HealthChanged;
    public int Current { get; private set; }
        
    public Health(DummyCfg cfg)
    {
        Current = cfg.InitialHealth; // Initial
    }

    public void OnCollidedWithBox()
    {
        Current--;
        HealthChanged?.Invoke();
    }
}