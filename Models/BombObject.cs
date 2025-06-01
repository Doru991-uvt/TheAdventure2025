using Silk.NET.SDL;

namespace TheAdventure.Models
{
    internal class BombObject : TemporaryGameObject
    {
        public int Damage { get; init; }
        public BombObject(SpriteSheet spriteSheet, double ttl, int damage, (int X, int Y) position, double angle = 0.0, Point rotationCenter = new())
        : base(spriteSheet, ttl, position, angle, rotationCenter)
        {
            Damage = damage;
        }
    }
}
