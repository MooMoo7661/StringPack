using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace StringPack
{
    public class StringHelpers
    {
        public readonly static string PrePath = "StringPack/Strings/";

        #region Calamity
        public readonly static string CalPath = "CalamityStrings_";
        public readonly static Asset<Texture2D> AirSpinnerString = ModContent.Request<Texture2D>(PrePath + CalPath + "AirSpinner");
        public readonly static Asset<Texture2D> AortaString = ModContent.Request<Texture2D>(PrePath + CalPath + "Aorta");
        public readonly static Asset<Texture2D> AzathothString = ModContent.Request<Texture2D>(PrePath + CalPath + "Azathoth");
        public readonly static Asset<Texture2D> FaultLineString = ModContent.Request<Texture2D>(PrePath + CalPath + "FaultLine");
        public readonly static Asset<Texture2D> LaceratorString = ModContent.Request<Texture2D>(PrePath + CalPath + "Lacerator");
        public readonly static Asset<Texture2D> OblivionString = ModContent.Request<Texture2D>(PrePath + CalPath + "Oblivion");
        public readonly static Asset<Texture2D> PandemicString = ModContent.Request<Texture2D>(PrePath + CalPath + "Pandemic");
        public readonly static Asset<Texture2D> QuagmireString = ModContent.Request<Texture2D>(PrePath + CalPath + "Quagmire");
        public readonly static Asset<Texture2D> RiptideString = ModContent.Request<Texture2D>(PrePath + CalPath + "Riptide");
        public readonly static Asset<Texture2D> ShimmersparkString = ModContent.Request<Texture2D>(PrePath + CalPath + "Shimmerspark");
        public readonly static Asset<Texture2D> SolarFlareString = ModContent.Request<Texture2D>(PrePath + CalPath + "SolarFlare");
        public readonly static Asset<Texture2D> SulphurousGrabberString = ModContent.Request<Texture2D>(PrePath + CalPath + "SulphurousGrabber");
        public readonly static Asset<Texture2D> GodsGambitString = ModContent.Request<Texture2D>(PrePath + CalPath + "GodsGambit");
        public readonly static Asset<Texture2D> MicrowaveString = ModContent.Request<Texture2D>(PrePath + CalPath + "Microwave");
        public readonly static Asset<Texture2D> TheObliteratorString = ModContent.Request<Texture2D>(PrePath + CalPath + "TheObliterator");
        public readonly static Asset<Texture2D> TheOracleString = ModContent.Request<Texture2D>(PrePath + CalPath + "TheOracle");
        public readonly static Asset<Texture2D> YinYoString = ModContent.Request<Texture2D>(PrePath + CalPath + "YinYo");
        #endregion

        #region FargowiltasSouls
        public readonly static string FargosPath = "FargowiltasSoulsStrings_";
        public readonly static Asset<Texture2D> BlenderString = ModContent.Request<Texture2D>(PrePath + FargosPath + "Blender");
        public readonly static Asset<Texture2D> DicerString = ModContent.Request<Texture2D>(PrePath + FargosPath + "Dicer");
        #endregion

        #region Thorium
        public readonly static string ThoriumPath = "ThoriumStrings_";
        public readonly static Asset<Texture2D> AerialString = ModContent.Request<Texture2D>(PrePath + ThoriumPath + "Aerial");
        #endregion

        #region Terraria
        public readonly static string TerrariaPath = "TerrariaStrings_";
        public readonly static Asset<Texture2D> BasicString = ModContent.Request<Texture2D>(PrePath + TerrariaPath + "BasicString");
        #endregion
    }
}
