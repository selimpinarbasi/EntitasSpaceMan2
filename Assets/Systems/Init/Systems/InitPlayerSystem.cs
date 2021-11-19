using UnityEngine;
using UnityEditor;
using Entitas;

public sealed class InitPlayerSystem : IInitializeSystem
{
    readonly GameContext _context;

    public InitPlayerSystem(Contexts contexts)
    {
        _context = contexts.game;
    }

    public void Initialize()
    {        
        const string resourceName = "SpaceMan2";
        var e = _context.CreateEntity();
        e.AddAsset(resourceName);
        e.AddPosition(0, -3.75f, 0);
        e.AddMove(0, 0.025f);
    }
}