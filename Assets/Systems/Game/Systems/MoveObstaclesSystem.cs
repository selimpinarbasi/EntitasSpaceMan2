using UnityEngine;
using UnityEditor;
using Entitas;

public class MoveObstaclesSystem : IExecuteSystem
{
    float degisimZaman = 0;
    readonly IGroup<GameEntity> _group;
    public MoveObstaclesSystem(Contexts contexts)
    {
        _group = contexts.game.GetGroup(Matcher<GameEntity>.AllOf(GameMatcher.Position, GameMatcher.Acceleratable, GameMatcher.Move));
    }
    public void Execute()
    {
        foreach (var e in _group.GetEntities())
        {
            degisimZaman += Time.deltaTime;
            if (degisimZaman > 1.15f)
            {
                var position = e.position;
                e.ReplacePosition(position.x, position.y + (-0.025f), position.z);
                degisimZaman = 0;
            }
        }
    }
}