using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Asteroids
{
    static class GameConstants
    {
        //Camera constants
        public const float CameraHeight = 25000.0f;
        public const float PlayfieldSizeX = 16000.0f;
        public const float PlayfieldSizeY = 12500.0f;
        //Asteroids constants
        public const int NumAsteroids = 10;
        public const float AsteroidMinSpeed = 100.0f;
        public const float AsteroidMaxSpeed = 300.0f;
        public const float AsteroidSpeedAdjustment = 5.0f;
        //Collision constants
        public const float AsteroidBoundingSphereScale = 0.95f;  //95% size
        public const float ShipBoundingSphereScale = 0.5f; //50% size
        //Bullet constants
        public const int NumBullets = 30;
        public const float BulletSpeedAdjustment = 100.0f;
        //Scoring constants
        public const int ShotPenalty = 1;
        public const int DeathPenalty = 100;
        public const int WarpPenalty = 50;
        public const int KillBonus = 25;

    }
}
