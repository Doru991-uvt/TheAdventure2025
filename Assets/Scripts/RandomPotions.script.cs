using TheAdventure.Scripting;
using System;
using TheAdventure;

public class RandomPotion : IScript
{
    DateTimeOffset _nextPotionTimestamp;

    public void Initialize()
    {
        _nextPotionTimestamp = DateTimeOffset.UtcNow.AddSeconds(Random.Shared.Next(5, 10));
    }

    public void Execute(Engine engine)
    {
        if (_nextPotionTimestamp < DateTimeOffset.UtcNow)
        {
            _nextPotionTimestamp = DateTimeOffset.UtcNow.AddSeconds(Random.Shared.Next(5, 10));
            var playerPos = engine.GetPlayerPosition();
            var potPosX = playerPos.X + Random.Shared.Next(-50, 50);
            var potPosY = playerPos.Y + Random.Shared.Next(-50, 50);
            engine.AddPotion(potPosX, potPosY, false);
        }
    }
}