using System;
public interface IView
{
    public event Action OnCollision;
    public void DisplayHealth(int health);
}
