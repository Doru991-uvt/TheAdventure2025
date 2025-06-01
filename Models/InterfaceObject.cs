using Silk.NET.SDL;

namespace TheAdventure.Models
{
    internal class InterfaceObject : RenderableGameObject
    {
        public InterfaceObject(SpriteSheet spriteSheet, (int X, int Y) position, double angle = 0.0,
        Point rotationCenter = new())
        : base(spriteSheet, position, angle, rotationCenter)
        {
        }
        override public void Render(GameRenderer renderer)
        {
            SpriteSheet.Render(renderer, Position, Angle, RotationCenter, true);
        }
    }
}
