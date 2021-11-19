using UnityEngine;
using UnityEditor;
using Entitas;

public class MoveSpaceManSystem : IExecuteSystem
{
    readonly IGroup<GameEntity> _group;

    public MoveSpaceManSystem(Contexts contexts)
    {
        _group = contexts.game.GetGroup(Matcher<GameEntity>.AllOf(GameMatcher.Position));
    }

    public void Execute()
    {
        //var e = _group.GetEntities();
        if (Input.GetMouseButtonDown(0))
        {

            foreach (var e in _group.GetEntities())
            {
                if (e.position.x == 0 && e.position.y == -3.75f)
                {
                    e.ReplacePosition(-1.75f, -3.75f, 0);
                }
                else if (e.position.x == -1.75 && e.position.y == -3.75f)
                {
                    e.ReplacePosition(0.000001f, -3.75f, 0);
                }
                else if (e.position.x == 0.000001f && e.position.y == -3.75f)
                {
                    e.ReplacePosition(1.75f, -3.75f, 0);
                }
                else if (e.position.x == 1.75f && e.position.y == -3.75f)
                {
                    e.ReplacePosition(0, -3.75f, 0);
                }
            }
        }
    }
}