using UnityEngine;

namespace OniExtract2.model
{
    public class BUISprite
    {
        public string spriteName;
        public string textureName;
        public BColor color = null;

        public BUISprite(Sprite sprite, Color color)
        {
            this.spriteName = sprite.name;
            this.textureName = sprite.texture.name;
            this.color = new BColor(color);
        }
    }
}
