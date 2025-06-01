using Silk.NET.SDL;

namespace TheAdventure.Models
{
    internal class PotionObject : TemporaryGameObject
    {
        public int Heal { get; init; }
        public PotionObject(SpriteSheet spriteSheet, double ttl, int heal, (int X, int Y) position, double angle = 0.0, Point rotationCenter = new())
        : base(spriteSheet, ttl, position, angle, rotationCenter)
        {
            Heal = heal;
        }
    }
}
