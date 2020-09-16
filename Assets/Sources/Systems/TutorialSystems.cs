using Entitas;

/// <summary>
/// 第四步：整合所有System到一个功能Feature中
/// </summary>
public class TutorialSystems : Feature
{
    public TutorialSystems(Contexts contexts) : base("Tutorial Systems")
    {
        Add(new HelloWorldSystem(contexts));
        Add(new DebugMessageSystem(contexts));
    }
}