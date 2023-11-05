using Terraria.ModLoader;
using MooMooLib;
using static MooMooLib.MooMooLibModsystem;
using static StringPack.StringHelpers;
using Terraria;
using Terraria.ID;

namespace StringPack
{
	public class DictionaryEntries : ModSystem
	{
        public override void Load()
        {
            AddDictionaryEntries();
        }

        #region Calamity
        public static StringTexture AirSpinner = new StringTexture();
        public static StringTexture Aorta = new StringTexture();
        public static StringTexture Azathoth = new StringTexture();
        public static StringTexture FaultLine = new StringTexture();
        public static StringTexture Lacerator = new StringTexture();
        public static StringTexture Oblivion = new StringTexture();
        public static StringTexture Pandemic = new StringTexture();
        public static StringTexture Quagmire = new StringTexture();
        public static StringTexture Riptide = new StringTexture();
        public static StringTexture Shimmerspark = new StringTexture();
        public static StringTexture SolarFlare = new StringTexture();
        public static StringTexture SulphurousGrabber = new StringTexture();
        public static StringTexture GodsGambit = new StringTexture();
        public static StringTexture Microwave = new StringTexture();
        public static StringTexture TheObliterator = new StringTexture();
        public static StringTexture TheOracle = new StringTexture();
        public static StringTexture YinYo = new StringTexture();
        #endregion
        #region FargowiltasSouls
        public static StringTexture Blender = new StringTexture();
        public static StringTexture Dicer = new StringTexture();
        #endregion

        #region Terraria
        public static StringTexture Basic = new StringTexture();
        #endregion
        private static void AddDictionaryEntries()
        {
            if (ModLoader.TryGetMod("CalamityMod", out Mod Calamity))
            {
                AirSpinner.setStringTexture(AirSpinnerString); yoyoStringDictionary.TryAdd(Calamity.Find<ModItem>("AirSpinner").Type, AirSpinner);
                Aorta.setStringTexture(AortaString); yoyoStringDictionary.TryAdd(Calamity.Find<ModItem>("Aorta").Type, Aorta);
                Azathoth.setStringTexture(AzathothString); yoyoStringDictionary.TryAdd(Calamity.Find<ModItem>("Azathoth").Type, Azathoth);
                FaultLine.setStringTexture(FaultLineString); yoyoStringDictionary.TryAdd(Calamity.Find<ModItem>("FaultLine").Type, FaultLine);
                Lacerator.setStringTexture(LaceratorString); yoyoStringDictionary.TryAdd(Calamity.Find<ModItem>("Lacerator").Type, Lacerator);
                Oblivion.setStringTexture(OblivionString); yoyoStringDictionary.TryAdd(Calamity.Find<ModItem>("Oblivion").Type, Oblivion);
                Pandemic.setStringTexture(PandemicString); yoyoStringDictionary.TryAdd(Calamity.Find<ModItem>("Pandemic").Type, Pandemic);
                Quagmire.setStringTexture(QuagmireString); yoyoStringDictionary.TryAdd(Calamity.Find<ModItem>("Quagmire").Type, Quagmire);
                Riptide.setStringTexture(RiptideString); yoyoStringDictionary.TryAdd(Calamity.Find<ModItem>("Riptide").Type, Riptide);
                Shimmerspark.setStringTexture(ShimmersparkString); yoyoStringDictionary.TryAdd(Calamity.Find<ModItem>("Shimmerspark").Type, Shimmerspark);
                SolarFlare.setStringTexture(SolarFlareString); yoyoStringDictionary.TryAdd(Calamity.Find<ModItem>("SolarFlare").Type, SolarFlare);
                GodsGambit.setStringTexture(GodsGambitString); yoyoStringDictionary.TryAdd(Calamity.Find<ModItem>("TheGodsGambit").Type, GodsGambit);
                Microwave.setStringTexture(MicrowaveString); yoyoStringDictionary.TryAdd(Calamity.Find<ModItem>("TheMicrowave").Type, Microwave);
                TheObliterator.setStringTexture(TheObliteratorString); yoyoStringDictionary.TryAdd(Calamity.Find<ModItem>("TheObliterator").Type, TheObliterator);
                TheOracle.setStringTexture(TheOracleString); yoyoStringDictionary.TryAdd(Calamity.Find<ModItem>("Oracle").Type, TheOracle);
                SulphurousGrabber.setStringTexture(SulphurousGrabberString); yoyoStringDictionary.TryAdd(Calamity.Find<ModItem>("SulphurousGrabber").Type, SulphurousGrabber);
                YinYo.setStringTexture(YinYoString); yoyoStringDictionary.TryAdd(Calamity.Find<ModItem>("YinYo").Type, YinYo);
            }

            if (ModLoader.TryGetMod("FargowiltasSouls", out Mod Fargos))
            {
                Blender.setStringTexture(BlenderString); yoyoStringDictionary.TryAdd(Fargos.Find<ModItem>("Blender").Type, Blender);
                Dicer.setStringTexture(DicerString); yoyoStringDictionary.TryAdd(Fargos.Find<ModItem>("Dicer").Type, Dicer);
            }

            Basic.setStringTexture(BasicString); yoyoStringDictionary.TryAdd(ItemID.WoodYoyo, Basic);
        }
    }
}