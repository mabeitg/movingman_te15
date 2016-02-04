using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MovingManTe15
{
    class MovingObject
    {
        public Vector2 position, velocity;
        public Texture2D sprite;

        public void Update()
        {
            velocity.Y += 0.05f; //Gravitation
            position += velocity; //Rörelse
        }
    }
}
