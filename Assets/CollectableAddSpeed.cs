public class CollectableAddSpeed : Collectable
{
    public float speedBoost = 200f;

    protected override void Awake()
    {
        base.Awake();
        collectableName = "CollectableAddSpeed";
    }

    public override void ApplyEffect()
    {
        if (controller != null)
        {
            controller.AddSpeed(speedBoost);
        }
    }
}