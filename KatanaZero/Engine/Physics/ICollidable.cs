﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Physics
{
    public enum MoveableBodyStates
    {
        Idle,
        WalkRight,
        WalkLeft,
        InAirRight,
        InAirLeft,
        InAir,
        Attack
    }

    public interface ICollidable : IDrawableComponent
    {
        MoveableBodyStates MoveableBodyState { get; set; }
        Vector2 Velocity { get; set; }
        void PrepareMove(GameTime gameTime);
    }
}
