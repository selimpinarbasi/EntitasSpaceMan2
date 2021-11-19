using UnityEngine;
using UnityEditor;

public class InitSystems : Feature
{
    public InitSystems(Contexts contexts) : base("Init Systems")
    {
        Add(new InitPlayerSystem(contexts));
        //Add(new InitOpponentsSystem(contexts));
        //Add(new InitObstaclesSystem(contexts));
        Add(new InitFinishLineSystem(contexts));
        Add(new InitBackGroundSystem(contexts));
    }
}