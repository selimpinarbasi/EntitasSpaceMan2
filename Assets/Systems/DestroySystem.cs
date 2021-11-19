using UnityEngine;
using UnityEditor;
using Entitas;
using System.Collections.Generic;

public sealed class DestroySystem : ReactiveSystem<GameEntity>
{
    readonly GameContext _context;
    public DestroySystem(Contexts contexts) : base(contexts.game)
    {
        _context = contexts.game;
    }
    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            _context.DestroyAllEntities();
        }
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.isDestroyed;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Destroyed);
    }
}