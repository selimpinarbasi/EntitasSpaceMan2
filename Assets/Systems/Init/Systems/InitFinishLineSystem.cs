using UnityEngine;
using UnityEditor;
using Entitas;

public sealed class InitFinishLineSystem : IInitializeSystem
{
    readonly GameContext _contexts;

    public InitFinishLineSystem(Contexts contexts)
    {
        _contexts = contexts.game;
    }

    public void Initialize()
    {
        var e = _contexts.CreateEntity();
        e.isFinishLine = true;
        e.AddAsset("DestroyObstacleLine2");
        e.AddPosition(0, -10.92f, 0);
    }
}