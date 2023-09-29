using Bang.Contexts;
using Bang.Entities;
using Bang.Systems;
using Murder.Components;
using Murder;
using Murder.Helpers;
using HelloMurder.Components;
using HelloMurder.Core.Input;
using System.Numerics;
using Murder.Utilities;

namespace HelloMurder.Systems
{
    [Filter(kind: ContextAccessorKind.Read, typeof(PlayerComponent), typeof(AgentComponent))]
    public class PlayerInputSystem : IUpdateSystem, IFixedUpdateSystem
    {
        private Vector2 _cachedInputAxis = Vector2.Zero;

        public void FixedUpdate(Context context)
        {
            foreach (Entity entity in context.Entities)
            {
                bool moved = _cachedInputAxis.HasValue();
                
                if (moved)
                {
                    Direction direction = DirectionHelper.FromVector(_cachedInputAxis);
                        
                    entity.SetAgentImpulse(_cachedInputAxis, direction);
                }
            }
        }

        public void Update(Context context)
        {
            _cachedInputAxis = Game.Input.GetAxis(InputAxis.Movement).Value;
        }
    }
}
