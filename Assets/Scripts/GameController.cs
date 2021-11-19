using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class GameController : MonoBehaviour
{
    private Systems _systems;
    void Start()
    {
        Random.InitState(42);
        var contexts = Contexts.sharedInstance;
        _systems = createSystems(contexts);
        _systems.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        _systems.Execute();
    }
    // score ekleme ve engele takılma
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "score")
        {

        }
        if (col.gameObject.tag == "engel")
        {

        }
    }
    Systems createSystems(Contexts contexts)
    {
        return new Feature("Systems")
            .Add(new InitSystems(contexts))
            //.Add(new InputSystem(contexts))
            .Add(new GameSystems(contexts))
            //.Add(new DestroySystem(contexts))
            .Add(new ViewSystem(contexts));
    }
}
