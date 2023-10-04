using Bang.Components;

namespace HelloMurder.Components
{
    public readonly struct DealsDamageOnCollisionComponent : IComponent
    {
        public readonly int Damage = 1;

        public DealsDamageOnCollisionComponent()
        {
        }

        public DealsDamageOnCollisionComponent(int damage)
        {
            Damage = damage;
        }
    }
}
