using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丙与与丂上世丄万且
    {
        // Fields
        private static Rilisoft.丙与与丂上世丄万且 丝业丆丁业三丈丟东;
        private readonly UnityEngine.Texture2D 丗一丁丗丁丙丏丄丐;
        private readonly UnityEngine.GUIStyle 与丕丕下丕丑丂丄丝;
        private readonly UnityEngine.Texture2D 丗七专丁上与丆且丟;
        
        // Properties
        internal static Rilisoft.丙与与丂上世丄万且 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        private 丙与与丂上世丄万且()
        {
            this.丗一丁丗丁丙丏丄丐 = UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  "line_shadow");
            this.丗七专丁上与丆且丟 = UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  "line");
            UnityEngine.GUIStyle val_5 = new UnityEngine.GUIStyle(other:  UnityEngine.GUI.skin.label);
            val_5.alignment = 4;
            val_5.font = UnityEngine.Resources.Load<UnityEngine.Font>(path:  "04B_03");
            float val_11 = 22f;
            val_11 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * val_11;
            val_5.fontSize = System.Convert.ToInt32(value:  val_11);
            UnityEngine.GUIStyleState val_9 = new UnityEngine.GUIStyleState();
            UnityEngine.Color val_10 = UnityEngine.Color.black;
            val_9.textColor = new UnityEngine.Color() {r = val_10.r, g = val_10.g, b = val_10.b, a = val_10.a};
            val_5.normal = val_9;
            this.与丕丕下丕丑丂丄丝 = val_5;
        }
        internal static Rilisoft.丙与与丂上世丄万且 丑七不且上丗丁一世()
        {
            Rilisoft.丙与与丂上世丄万且 val_2;
            Rilisoft.丙与与丂上世丄万且 val_3 = Rilisoft.丙与与丂上世丄万且.丝业丆丁业三丈丟东;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            Rilisoft.丙与与丂上世丄万且 val_1 = null;
            val_2 = val_1;
            val_1 = new Rilisoft.丙与与丂上世丄万且();
            Rilisoft.丙与与丂上世丄万且.丝业丆丁业三丈丟东 = val_2;
            val_3 = Rilisoft.丙与与丂上世丄万且.丝业丆丁业三丈丟东;
            return val_3;
        }
        internal static void 丅丆万丒丁上东丆丑()
        {
            if(Rilisoft.丙与与丂上世丄万且.丝业丆丁业三丈丟东 == null)
            {
                    return;
            }
            
            UnityEngine.Resources.UnloadAsset(assetToUnload:  Rilisoft.丙与与丂上世丄万且.丝业丆丁业三丈丟东.丗一丁丗丁丙丏丄丐);
            UnityEngine.Resources.UnloadAsset(assetToUnload:  Rilisoft.丙与与丂上世丄万且.丝业丆丁业三丈丟东.丗七专丁上与丆且丟);
            Rilisoft.丙与与丂上世丄万且.丝业丆丁业三丈丟东 = 0;
        }
        public void 丈业丑丂一丕丂丏丗(float 上丕丈丞丌丘丅不与)
        {
            float val_28;
            float val_30;
            float val_1 = UnityEngine.Mathf.Clamp01(value:  上丕丈丞丌丘丅不与);
            if(this.丗一丁丗丁丙丏丄丐 == 0)
            {
                    return;
            }
            
            float val_26 = (float)this.丗一丁丗丁丙丏丄丐.width;
            val_26 = val_26 * 1.8f;
            float val_5 = val_26 * 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
            float val_27 = (float)this.丗一丁丗丁丙丏丄丐.height;
            val_27 = val_27 * 1.8f;
            val_28 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * val_27;
            float val_28 = (float)UnityEngine.Screen.width;
            float val_29 = 21f;
            val_28 = val_28 - val_5;
            val_29 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * val_29;
            float val_11 = val_28 * 0.5f;
            float val_12 = val_28 + val_29;
            val_12 = (float)UnityEngine.Screen.height - val_12;
            val_30 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
            if(this.丗七专丁上与丆且丟 != 0)
            {
                    float val_30 = 7.2f;
                float val_16 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * val_30;
                val_30 = val_30 * val_30;
                val_16 = val_5 - val_16;
                val_5 = val_1 * val_16;
                val_28 = val_28 - val_30;
                float val_18 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
                val_30 = val_18;
                float val_31 = 3.6f;
                val_31 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * val_31;
                float val_21 = 0f.x + (val_30 * val_31);
                val_31 = val_18 + val_31;
                UnityEngine.GUI.DrawTexture(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, image:  this.丗七专丁上与丆且丟);
            }
            
            UnityEngine.GUI.DrawTexture(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, image:  this.丗一丁丗丁丙丏丄丐);
            float val_22 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
            val_22 = val_22 * 1.8f;
            val_22 = 0f - val_22;
            float val_23 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
            val_23 = val_23 * 1.8f;
            val_23 = val_22 + val_23;
            float val_32 = 100f;
            val_32 = val_1 * val_32;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  System.String.Format(format:  "{0}%", arg0:  UnityEngine.Mathf.RoundToInt(f:  val_32)), style:  this.与丕丕下丕丑丂丄丝);
        }
    
    }

}
