using System;

public interface IModel
{
    public event Action HealthChanged;

    public int Current { get; }

    public void OnCollidedWithBox();
}
