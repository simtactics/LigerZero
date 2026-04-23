namespace LigerZero;

public class SceneManager(Engine engine)
{
    public Node CurrentScene => engine.Tree.CurrentScene;

    public void InstantiateScene(string path = "res://main.tscn")
    {
        var scene = GD.Load<PackedScene>(path);
        engine.Tree.Root.AddChild(scene.Instantiate());
    }

    public void ChangeScene(string path)
    {
        engine.Tree.ChangeSceneToFile(path);
    }
}
