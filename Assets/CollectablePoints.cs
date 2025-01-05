
public class CollectableAddPoints : Collectable
{
    protected override void Awake()
    {
        base.Awake();
        collectableName = "CollectableAddPoints";
    }

    public override void ApplyEffect()
    {
        if (gameController != null)
        {
            gameController.score += points;
        }
    }
}