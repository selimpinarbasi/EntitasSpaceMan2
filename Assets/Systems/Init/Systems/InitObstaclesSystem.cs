using UnityEngine;
using UnityEditor;
using Entitas;

public sealed class InitObstaclesSystem : IInitializeSystem
{
    readonly GameContext _context;
    public InitObstaclesSystem(Contexts contexts)
    {
        _context = contexts.game;
    }
    public void Initialize()
    {
        const string resourceName = "Score2";
        for (int i = 0; i < 5; i++)
        {
            var e = _context.CreateEntity();
            e.AddAsset(resourceName);
            e.AddPosition(0, 5.5f, 0);
            e.AddMove(0, -1);
            e.isAcceleratable = true;
        }
    }
}