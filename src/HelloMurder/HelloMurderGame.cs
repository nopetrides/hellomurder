using HelloMurder.Core;
using Microsoft.Xna.Framework.Input;
using Murder;
using Murder.Core.Input;

namespace HelloMurder
{
    public class HelloMurderGame : IMurderGame
    {
        public string Name => "HelloMurder";

        public void Initialize()
        {
            Game.Input.RegisterAxes(MurderInputAxis.Movement, GamepadAxis.LeftThumb);
            Game.Input.Register(MurderInputAxis.Movement, 
                new InputButtonAxis(Keys.W, Keys.A, Keys.S, Keys.D), 
                new InputButtonAxis(Keys.Up, Keys.Left, Keys.Down, Keys.Right));

            Game.Input.Register(InputButtons.Interact, Keys.Space);
        }
    }
}
