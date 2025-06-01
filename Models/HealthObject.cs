using Silk.NET.SDL;

namespace TheAdventure.Models
{
    internal class HealthObject : InterfaceObject
    {
        public int Health { get; set; } = 0;
        public int MaxHealth { get; set; } = 3;
        public HealthObject(SpriteSheet spriteSheet)
        : base(spriteSheet, (16,16))
        {
        }
        override public void Render(GameRenderer renderer)
        {
            for (int i = 0; i < MaxHealth; i++)
            {
                if (i < Health)
                {
                    SpriteSheet.ActivateAnimation("Full");
                }
                else SpriteSheet.ActivateAnimation("Empty");
                SpriteSheet.Render(renderer, (Position.X + i * 32, Position.Y), Angle, RotationCenter, true);
            }
        }
    }
}
