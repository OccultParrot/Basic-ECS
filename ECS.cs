using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ECS
{
    // ======== Entity ======== \\
    public class Entity
    {
        public int ID { get; }
        public List<Component> Components;

        public Entity(int ID)
        {
            this.ID = ID;
            Components = new List<Component>();
        }

        public bool HasComponent<T>()
        {
            return Components.Any(c => c.GetType() == typeof(T));
        }
        public T GetComponent<T>() where T : Component
        {
            return Components.OfType<T>().FirstOrDefault();
        }
    }

    // ======= Components ======= \\
    public class PositionComponent : Component
    {
        public Vector2 Position { get; set; }
        public PositionComponent(Vector2 Position)
        {
            this.Position = Position;
        }
    }

    public class TextureComponent : Component
    {
        public Texture2D Texture { get; set; }
        public TextureComponent(Texture2D Texture)
        {
            this.Texture = Texture;
        }
    }

// ======== Systems ======== \\
    public class DrawingSystem
    {
        public void Draw(SpriteBatch spriteBatch, List<Entity> entities)
        {
            foreach (var item in entities)
            {
                if (item.HasComponent<PositionComponent>() && item.HasComponent<TextureComponent>())
                {
                    spriteBatch.Draw(
                        item.GetComponent<TextureComponent>().Texture,
                        item.GetComponent<PositionComponent>().Position,
                        Color.White);
                }
            }
        }
    }
}
