using Raylib_cs;

namespace SpaceShooter.Model.Abstract
{
    internal abstract class GameObject
    {
        public abstract string TexturePath { get; }
        internal Texture2D Texture2D { get; set; }

        protected GameObject()
        {
            LoadTexture();
        }

        private void LoadTexture()
        {
            if (TexturePath is not null && File.Exists(TexturePath))
            {
                Texture2D = Raylib.LoadTexture(TexturePath);
            }
        }
    }
}
