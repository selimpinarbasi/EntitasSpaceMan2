using UnityEngine;
using UnityEditor;
using Entitas;

public sealed class MoveSystem : IExecuteSystem
{
    readonly IGroup<GameEntity> _group;

    public MoveSystem(Contexts contexts)
    {
        _group = contexts.game.GetGroup(Matcher<GameEntity>.AllOf(GameMatcher.Move, GameMatcher.Position, GameMatcher.Acceleratable));
    }

    public void Execute()
    {
        foreach (var e in _group.GetEntities())
        {
            var move = e.move;
            var position = e.position;
            e.ReplacePosition(position.x, position.y + move.speed, position.z);
        }
    }
}