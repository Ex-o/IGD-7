using System;
using UnityEngine;
using UnityEngine.UI;

public class ManualView : MonoBehaviour, IView
{
        
    [SerializeField] private Button _collideBtn;
    [SerializeField] private Image _healthBar;
    private float _widthPerHP;

    public event Action OnCollision;

    public void Construct(DummyCfg cfg)
    {
        _widthPerHP = _healthBar.rectTransform.sizeDelta.x / cfg.InitialHealth;
    }
    
    private void Awake()
    {
        _collideBtn.onClick.AddListener(ClickHandler);
    }

    private void ClickHandler()
    {
        OnCollision?.Invoke();
    }

    public void DisplayHealth(int health)
    {
        if (health < 0 || _widthPerHP <= 0)
        {
            return;
        }
        
        _healthBar.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, _widthPerHP * health);
    }
}