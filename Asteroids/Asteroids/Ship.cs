﻿#region Using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
#endregion

namespace Asteroids
{
    class Ship
    {
        public Model Model;
        public Matrix[] Transforms;

        //Position of the model in world space
        public Vector3 Position = Vector3.Zero;

        //Velocity of the model, applied each frame to the model's position
        public Vector3 Velocity = Vector3.Zero;
        private const float VelocityScale = 5.0f; //amplifies controller speed input
        public bool isActive = true;
        public Matrix RotationMatrix = Matrix.CreateRotationX(MathHelper.PiOver2);
        private float rotation;
        public float Rotation
        {
            get { return rotation; }
            set
            {
                while (value >= MathHelper.TwoPi)
                {
                    value -= MathHelper.TwoPi;
                }
                while (value < 0)
                {
                    value += MathHelper.TwoPi;
                }
                if (rotation != value)
                {
                    rotation = value;
                    RotationMatrix = Matrix.CreateRotationX(MathHelper.PiOver2) *
                        Matrix.CreateRotationZ(rotation);
                }

            }
        }

#region Update
        public void Update(GamePadState controllerState)
        {
            //Rotate the model using left thumbstick, and scale it down.
            Rotation -= controllerState.ThumbSticks.Left.X * 0.10f;

            //Finally, add this vector to our velocity.
            Velocity += RotationMatrix.Forward * VelocityScale * controllerState.Triggers.Right;
        }
    }
}

        #endregion
