using System.Drawing.Imaging;
using Microsoft.Xna.Framework.Graphics;

namespace Wobble.Assets
{
    public static class WobbleAssets
    {
        /// <summary>
        ///     Resources/UI/Basics/white_box.png
        /// </summary>
        public static Texture2D WhiteBox { get; private set; }

        /// <summary>
        ///     Resources/UI/Basics/wallpaper.jpg
        /// </summary>
        public static Texture2D Wallpaper { get; private set; }

        /// <summary>
        ///     Loads all the assets that Wobble has included.
        /// </summary>
        internal static void Load()
        {
            WhiteBox = AssetLoader.LoadTexture2D(GameBase.Game.Resources.Get("Wobble.Resources/UI/Basics/white_box.png"));
            Wallpaper = AssetLoader.LoadTexture2D(GameBase.Game.Resources.Get("Wobble.Resources/UI/Basics/wallpaper.jpg"));
        }

        /// <summary>
        ///     Disposes of all the assets that Wobble has included
        /// </summary>
        internal static void Dispose() => WhiteBox.Dispose();
    }
}