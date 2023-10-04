using Bang.Components;

namespace HelloMurder.Messages
{
    public readonly struct DamagingCollisionMessage : IMessage
    {
        public readonly int DamageDealt = 0;
        public readonly int OtherEntityId = -1;

        public DamagingCollisionMessage(int damageDealt, int otherEntityId) : this ()
        {
            DamageDealt = damageDealt;
            OtherEntityId = otherEntityId;
        }
    }
}
