using System;
using UnityEngine;
using UnityEngine.UI;

public class BallView : MonoBehaviour, IView
{
    public event Action OnCollision;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.CompareTag("Enemy"))
        {
            return;
        }
        OnCollision?.Invoke();
    }

    public void DisplayHealth(int health)
    {
        Debug.Log($"Current Health: {health.ToString()}");
    }
}