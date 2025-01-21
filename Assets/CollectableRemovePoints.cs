public class CollectableRemovePoints : Collectable
{
    protected override void Awake()
    {
        base.Awake();
        collectableName = "CollectableRemovePoints";
        points = -5;
    }

    public override void ApplyEffect()
    {
        if (gameManager != null)
        {
            gameManager.score += points;
        }
    }

}