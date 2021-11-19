using UnityEngine;
using UnityEditor;
using Entitas;

public class MoveBackGroundSystem : IExecuteSystem
{
    readonly IGroup<GameEntity> _group;
    readonly GameContext _context;
    public MoveBackGroundSystem(Contexts contexts)
    {
        _context = contexts.game;
        _group = contexts.game.GetGroup(Matcher<GameEntity>.AllOf(GameMatcher.BackGround));
    }

    public void Execute()
    {
        foreach (var e in _group.GetEntities())
        {
            if (e.position.y == -1)
            {
                var e2 = _context.CreateEntity();
                e2.AddAsset("backGround2");
                e2.AddPosition(0, 22.77999f, 10);
                e2.AddMove(0, 0.00025f);
                e2.isAcceleratable = true;
                e2.isBackGround = true;
            }
        }
    }
}