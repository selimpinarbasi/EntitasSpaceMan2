using UnityEngine;
using UnityEditor;
using Entitas;
using System.Collections.Generic;

public sealed class ReachedFinishSystem : ReactiveSystem<GameEntity>
{
    GameContext _context;
    public ReachedFinishSystem(Contexts contexts) : base(contexts.game)
    {
        _context = contexts.game;
    }
    protected override void Execute(List<GameEntity> entities)
    {
        var finishLinePosY = _context.finishLineEntity.position.y;
        foreach (var e in entities)
        {
            if (e.position.y < finishLinePosY)
            {
                e.isDestroyed = true;
            }
        }
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasPosition;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Position);
    }
}