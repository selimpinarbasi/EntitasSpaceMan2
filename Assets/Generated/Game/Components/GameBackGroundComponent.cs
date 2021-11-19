//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly BackGroundComponent backGroundComponent = new BackGroundComponent();

    public bool isBackGround {
        get { return HasComponent(GameComponentsLookup.BackGround); }
        set {
            if (value != isBackGround) {
                var index = GameComponentsLookup.BackGround;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : backGroundComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherBackGround;

    public static Entitas.IMatcher<GameEntity> BackGround {
        get {
            if (_matcherBackGround == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.BackGround);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBackGround = matcher;
            }

            return _matcherBackGround;
        }
    }
}