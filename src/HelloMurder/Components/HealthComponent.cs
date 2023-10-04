using Bang.Components;

namespace HelloMurder.Components
{
    public readonly struct HealthComponent : IComponent
    {
        public readonly int Health;
        public readonly int MaxHealth;
        public HealthComponent()
        {
        }
        public HealthComponent(int health, int maxHealth)
        {
            Health = health;
            MaxHealth = maxHealth;
        }

        internal HealthComponent Damage(int damageTaken)
        {
            return new HealthComponent(Math.Max(Health - damageTaken, 0), 
                MaxHealth);
        }
        
        internal HealthComponent Heal(int amountHealed)
        {
            return new HealthComponent(Math.Min(Health+amountHealed, MaxHealth),
                MaxHealth);
        }
    }
}
