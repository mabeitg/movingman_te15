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
        public Rectangle hitbox;

        public MovingObject()//Konstruktur. Körs när objekt skapas!
        {
            position = new Vector2(100, 50);
            velocity = new Vector2(1, 0.4f);

            hitbox = new Rectangle();
        }

        public void Update()
        {

            velocity.Y += 0.05f; //Gravitation
            position += velocity; //Rörelse

            hitbox.X = (int)position.X;
            hitbox.Y = (int)position.Y;
            hitbox.Width = sprite.Width;
            hitbox.Height = sprite.Height;
        }
    }
}
