using System;

public class Game : IDisposable
{
    private ViewController _ballPresenter;

    public Game(ViewController presenter)
    {
        _ballPresenter = presenter;
    }

    public void Dispose()
    {
        _ballPresenter.Dispose();
    }
}
