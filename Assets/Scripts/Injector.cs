using DELTation.DIFramework;
using DELTation.DIFramework.Containers;
using UnityEngine;

public sealed class Injector : DependencyContainerBase
{
    [SerializeField] private BallView _ballView;
    [SerializeField] private ManualView _manualView;
    [SerializeField] private bool _barToggle;

    public GameObject Bar;
    public GameObject Button;

    protected override void ComposeDependencies(ICanRegisterContainerBuilder builder)
    {
        if (_barToggle)
        {
            Bar.SetActive(true);
            Button.SetActive(true);
            builder.Register(_manualView);
        }
        else
        {
            Bar.SetActive(false);
            Button.SetActive(false);
            builder.Register(_ballView);
        }

        builder
            .Register(ScriptableObject.CreateInstance<DummyCfg>())
            .Register<ViewController>()
            .Register<Health>()
            .Register<Game>();
    }
}

