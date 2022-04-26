using System;

public class ViewController : IDisposable
{
    private readonly IView _view;
    private readonly IModel _model;

    public ViewController(IView view, IModel model)
    {
        _view = view;
        _model = model;
        _view.OnCollision += CollisionHandler;
        _model.HealthChanged += OnHealthChanged;

        OnHealthChanged();
    }

    private void CollisionHandler()
    {
        _model.OnCollidedWithBox();
    }

    private void OnHealthChanged()
    {
        _view.DisplayHealth(_model.Current);
    }

    public void Dispose()
    {
        _view.OnCollision -= CollisionHandler;
        _model.HealthChanged -= OnHealthChanged;
    }
}