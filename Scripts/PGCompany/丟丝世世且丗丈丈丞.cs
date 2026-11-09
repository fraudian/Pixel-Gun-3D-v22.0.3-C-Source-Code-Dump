using UnityEngine;

namespace PGCompany
{
    internal static class 丟丝世世且丗丈丈丞
    {
        // Properties
        internal static PGCompany.丝丆业不一丌东万世 丝丆业不一丌东万世 { get; set; }
        internal static bool 丞丗三丒丂丗万专丛 { get; set; }
        internal static UnityEngine.FogMode 丕丄上三丛丏丗与不 { get; set; }
        internal static float 与业业丐丘丌且丗下 { get; set; }
        internal static float 丂与万且且丑下丝丙 { get; set; }
        internal static UnityEngine.Color 丟丆丁万丆三丑三万 { get; set; }
        internal static UnityEngine.Color 不丆且不丒业丟丗丐 { get; set; }
        internal static UnityEngine.Color 专丟万丌不不三丙与 { get; set; }
        internal static UnityEngine.Color 丒丕丆三丘不与丌丄 { get; set; }
        internal static UnityEngine.Color 丅万且业一丑三丏丌 { get; set; }
        
        // Methods
        internal static PGCompany.丝丆业不一丌东万世 丟丟万丌丒丛丐丞丝()
        {
            UnityEngine.Color val_11 = UnityEngine.RenderSettings.fogColor;
            UnityEngine.Color val_13 = UnityEngine.RenderSettings.ambientLight;
            UnityEngine.Color val_15 = UnityEngine.RenderSettings.ambientSkyColor;
            UnityEngine.Color val_17 = UnityEngine.RenderSettings.ambientEquatorColor;
            PGCompany.丝丆业不一丌东万世 val_18 = new PGCompany.丝丆业不一丌东万世().丞丒且东三丁七丆丂(丙业与丙丗丝不丈东:  UnityEngine.RenderSettings.fog).丕丟三丑丙丗业业丕(丙业与丙丗丝不丈东:  UnityEngine.RenderSettings.fogMode).丐丒下丕一丐丈丕不(丙业与丙丗丝不丈东:  UnityEngine.RenderSettings.fogStartDistance).丝丂丛不上世且丞丐(丙业与丙丗丝不丈东:  UnityEngine.RenderSettings.fogEndDistance).丂丁丅丏与丕不专且(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a}).丕一一丄丐丞丗业丅(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a}).且丁丟七业丙丏丆丞(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_15.r, g = val_15.g, b = val_15.b, a = val_15.a}).丟下丘丕世丅三与丑(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_17.r, g = val_17.g, b = val_17.b, a = val_17.a});
            UnityEngine.Color val_19 = UnityEngine.RenderSettings.ambientGroundColor;
            if(val_18 != null)
            {
                    return val_18.专丆丂丐丛上丏丒丄(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_19.r, g = val_19.g, b = val_19.b, a = val_19.a});
            }
            
            return val_18.专丆丂丐丛上丏丒丄(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_19.r, g = val_19.g, b = val_19.b, a = val_19.a});
        }
        internal static void 丏东业丛下业一丛万(PGCompany.丝丆业不一丌东万世 丙业与丙丗丝不丈东)
        {
            float val_11;
            System.Nullable<System.Boolean> val_1 = 丙业与丙丗丝不丈东.丁丗万七不丄丑万万();
            if(((-246893764) & 1) != 0)
            {
                    System.Nullable<System.Boolean> val_2 = 丙业与丙丗丝不丈东.丁丗万七不丄丑万万();
                UnityEngine.RenderSettings.fog = false;
            }
            
            System.Nullable<UnityEngine.FogMode> val_3 = 丙业与丙丗丝不丈东.丅丈七丞与丌丗丘丛();
            if(((-246893776) & 1) != 0)
            {
                    System.Nullable<UnityEngine.FogMode> val_4 = 丙业与丙丗丝不丈东.丅丈七丞与丌丗丘丛();
                UnityEngine.RenderSettings.fogMode = val_4.HasValue;
            }
            
            System.Nullable<System.Single> val_5 = 丙业与丙丗丝不丈东.上专丝丑丝丈丑丙七();
            if(((-246893784) & 1) != 0)
            {
                    System.Nullable<System.Single> val_6 = 丙业与丙丗丝不丈东.上专丝丑丝丈丑丙七();
                UnityEngine.RenderSettings.fogStartDistance = null;
            }
            
            System.Nullable<System.Single> val_7 = 丙业与丙丗丝不丈东.专丁丙上丙丏丏丘丘();
            if(((-246893784) & 1) != 0)
            {
                    System.Nullable<System.Single> val_8 = 丙业与丙丗丝不丈东.专丁丙上丙丏丏丘丘();
                UnityEngine.RenderSettings.fogEndDistance = null;
            }
            
            System.Nullable<UnityEngine.Color> val_9 = 丙业与丙丗丝不丈东.丟丑世丕上丌丁丂七();
            if(val_11.HasValue != false)
            {
                    System.Nullable<UnityEngine.Color> val_13 = 丙业与丙丗丝不丈东.丟丑世丕上丌丁丂七();
                UnityEngine.RenderSettings.fogColor = new UnityEngine.Color() {r = val_11};
            }
            
            System.Nullable<UnityEngine.Color> val_14 = 丙业与丙丗丝不丈东.丝丁丆丁丑丈下万与();
            if(val_11.HasValue != false)
            {
                    System.Nullable<UnityEngine.Color> val_16 = 丙业与丙丗丝不丈东.丝丁丆丁丑丈下万与();
                UnityEngine.RenderSettings.ambientLight = new UnityEngine.Color() {r = val_11};
            }
            
            System.Nullable<UnityEngine.Color> val_17 = 丙业与丙丗丝不丈东.丕丟丆丙丐与丅世丄();
            if(val_11.HasValue != false)
            {
                    System.Nullable<UnityEngine.Color> val_19 = 丙业与丙丗丝不丈东.丕丟丆丙丐与丅世丄();
                UnityEngine.RenderSettings.ambientSkyColor = new UnityEngine.Color() {r = val_11};
            }
            
            System.Nullable<UnityEngine.Color> val_20 = 丙业与丙丗丝不丈东.丟丑丟七一丂丙世与();
            if(val_11.HasValue != false)
            {
                    System.Nullable<UnityEngine.Color> val_22 = 丙业与丙丗丝不丈东.丟丑丟七一丂丙世与();
                UnityEngine.RenderSettings.ambientEquatorColor = new UnityEngine.Color() {r = val_11};
            }
            
            System.Nullable<UnityEngine.Color> val_23 = 丙业与丙丗丝不丈东.丙万丙丏丆三三世世();
            if(val_11.HasValue == false)
            {
                    return;
            }
            
            System.Nullable<UnityEngine.Color> val_25 = 丙业与丙丗丝不丈东.丙万丙丏丆三三世世();
            UnityEngine.RenderSettings.ambientGroundColor = new UnityEngine.Color() {r = val_11};
        }
        internal static bool 东七一丈七专丅不丙()
        {
            return UnityEngine.RenderSettings.fog;
        }
        internal static void 丅下业丏丈七专丗东(bool 丙业与丙丗丝不丈东)
        {
            UnityEngine.RenderSettings.fog = 丙业与丙丗丝不丈东;
        }
        internal static UnityEngine.FogMode 东与七丂丘丁丗丈丗()
        {
            return UnityEngine.RenderSettings.fogMode;
        }
        internal static void 下丐专且三丄下丘下(UnityEngine.FogMode 丙业与丙丗丝不丈东)
        {
            UnityEngine.RenderSettings.fogMode = 丙业与丙丗丝不丈东;
        }
        internal static float 丂专世丂丕丌丁业一()
        {
            return UnityEngine.RenderSettings.fogStartDistance;
        }
        internal static void 丁专丒东丆丏丏丛丗(float 丙业与丙丗丝不丈东)
        {
            UnityEngine.RenderSettings.fogStartDistance = 丙业与丙丗丝不丈东;
        }
        internal static float 丁丈专丌丝丙业丂下()
        {
            return UnityEngine.RenderSettings.fogEndDistance;
        }
        internal static void 东不一丛丟东丆不七(float 丙业与丙丗丝不丈东)
        {
            UnityEngine.RenderSettings.fogEndDistance = 丙业与丙丗丝不丈东;
        }
        internal static UnityEngine.Color 丌七丁丅三丅与三与()
        {
            return UnityEngine.RenderSettings.fogColor;
        }
        internal static void 丌三上丂不丝一丄丑(UnityEngine.Color 丙业与丙丗丝不丈东)
        {
            UnityEngine.RenderSettings.fogColor = new UnityEngine.Color() {r = 丙业与丙丗丝不丈东.r, g = 丙业与丙丗丝不丈东.g, b = 丙业与丙丗丝不丈东.b, a = 丙业与丙丗丝不丈东.a};
        }
        internal static UnityEngine.Color 七丐一不丄丟丈丁丗()
        {
            return UnityEngine.RenderSettings.ambientLight;
        }
        internal static void 丌丈一丒丙丗丂东东(UnityEngine.Color 丙业与丙丗丝不丈东)
        {
            UnityEngine.RenderSettings.ambientLight = new UnityEngine.Color() {r = 丙业与丙丗丝不丈东.r, g = 丙业与丙丗丝不丈东.g, b = 丙业与丙丗丝不丈东.b, a = 丙业与丙丗丝不丈东.a};
        }
        internal static UnityEngine.Color 丄丐丒丆与丅不丗不()
        {
            return UnityEngine.RenderSettings.ambientSkyColor;
        }
        internal static void 丙丐东丆丒业下下丙(UnityEngine.Color 丙业与丙丗丝不丈东)
        {
            UnityEngine.RenderSettings.ambientSkyColor = new UnityEngine.Color() {r = 丙业与丙丗丝不丈东.r, g = 丙业与丙丗丝不丈东.g, b = 丙业与丙丗丝不丈东.b, a = 丙业与丙丗丝不丈东.a};
        }
        internal static UnityEngine.Color 业三不丈丌丗丙丆丞()
        {
            return UnityEngine.RenderSettings.ambientEquatorColor;
        }
        internal static void 一丆丛丑与上丝世东(UnityEngine.Color 丙业与丙丗丝不丈东)
        {
            UnityEngine.RenderSettings.ambientEquatorColor = new UnityEngine.Color() {r = 丙业与丙丗丝不丈东.r, g = 丙业与丙丗丝不丈东.g, b = 丙业与丙丗丝不丈东.b, a = 丙业与丙丗丝不丈东.a};
        }
        internal static UnityEngine.Color 丗丙丟丂且丂丗业世()
        {
            return UnityEngine.RenderSettings.ambientGroundColor;
        }
        internal static void 上丝丙丛下不一丘下(UnityEngine.Color 丙业与丙丗丝不丈东)
        {
            UnityEngine.RenderSettings.ambientGroundColor = new UnityEngine.Color() {r = 丙业与丙丗丝不丈东.r, g = 丙业与丙丗丝不丈东.g, b = 丙业与丙丗丝不丈东.b, a = 丙业与丙丗丝不丈东.a};
        }
    
    }

}
