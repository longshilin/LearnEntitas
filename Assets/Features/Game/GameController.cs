using Entitas;

/// 游戏控制器
/// 管理游戏的总入口
public class GameController
{
    private readonly Systems _systems;
    private readonly Contexts _contexts;

    public GameController(Contexts contexts)
    {
        _contexts = contexts;
         _systems = new GameSystems(_contexts);
    }

    public void Initialize()
    {
        _systems.Initialize();
    }

    public void Execute()
    {
        _systems.Execute();
        _systems.Cleanup();
    }
}