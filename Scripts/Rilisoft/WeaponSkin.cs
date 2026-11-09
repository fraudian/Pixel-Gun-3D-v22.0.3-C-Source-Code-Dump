using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class WeaponSkin
    {
        // Fields
        private static System.Text.RegularExpressions.Regex _regex;
        public Rilisoft.WeaponSkin.三丐不东业东不丄丑 serverID;
        public string Lkey;
        public int Price;
        public Rilisoft.丝一丌上丟且三一丏 Currency;
        public RatingSystem.RatingLeague ForLeague;
        public string ShaderName;
        public Rilisoft.WeaponSkinTexture[] Textures;
        public string[] ToWeapons;
        
        // Properties
        public string Id { get; }
        
        // Methods
        public bool 三万丘丙丆丛且上世(string 丝三丛且丘不丌丙下)
        {
            string val_3;
            object val_4;
            val_3 = 丝三丛且丘不丌丙下;
            if(val_3 == null)
            {
                goto label_1;
            }
            
            if((丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_3)) == null)
            {
                goto label_4;
            }
            
            return System.String.op_Equality(a:  val_3, b:  this.ToWeapons[0]);
            label_1:
            val_4 = "WeaponSkin IsForWeapon weaponName == null";
            goto label_9;
            label_4:
            val_3 = "WeaponSkin IsForWeapon rec == null, weaponName: "("WeaponSkin IsForWeapon rec == null, weaponName: ") + val_3;
            val_4 = val_3;
            label_9:
            UnityEngine.Debug.LogError(message:  val_4);
            return false;
        }
        public bool 七丌且丑丝业与专万(UnityEngine.GameObject 丝三丁东丈丒世丅业)
        {
            UnityEngine.Object val_25;
            var val_26;
            Rilisoft.WeaponSkinTexture val_27;
            var val_28;
            UnityEngine.Material val_29;
            string val_30;
            var val_31;
            val_25 = 丝三丁东丈丒世丅业;
            if(val_25 == 0)
            {
                goto label_8;
            }
            
            val_25 = 丞东丑专丛丆丄丝世.七一与世与业丐且且(丝三丁东丈丒世丅业:  val_25, 丒丘丏上丙丟丑丕丈:  "Arms_Mesh", 丟丝七七一丁丏丏丙:  true);
            if(val_25 == 0)
            {
                goto label_8;
            }
            
            val_26 = 0;
            goto label_15;
            label_50:
            val_27 = this.Textures[0];
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<System.String>(丑东与丅丐丅丂丞业:  this.Textures[0x0][0].ToObjects)) == false)
            {
                goto label_14;
            }
            
            label_48:
            val_26 = 1;
            goto label_15;
            label_14:
            val_28 = 0;
            goto label_16;
            label_47:
            UnityEngine.GameObject val_5 = 丞东丑专丛丆丄丝世.七一与世与业丐且且(丝三丁东丈丒世丅业:  val_25, 丒丘丏上丙丟丑丕丈:  this.Textures[0x0][0].ToObjects[0], 丟丝七七一丁丏丏丙:  true);
            if(val_5 != 0)
            {
                    UnityEngine.Renderer val_7 = val_5.GetComponent<UnityEngine.Renderer>();
                val_29 = val_7.material;
                bool val_27 = false;
                val_27 = val_27 | (UnityEngine.Object.op_Equality(x:  val_7, y:  0));
                if((System.String.op_Inequality(a:  val_29.shader.name, b:  mem[1152921543654951552])) != false)
            {
                    UnityEngine.Shader val_13 = UnityEngine.Shader.Find(name:  mem[1152921543654951552]);
                val_29 = new UnityEngine.Material();
                val_29 = new UnityEngine.Material(shader:  val_13);
                val_7.material = new UnityEngine.Material();
                bool val_28 = val_27;
                val_28 = val_28 | (UnityEngine.Object.op_Equality(x:  val_13, y:  0));
            }
            
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.Textures[0x0][0].ShaderPropertyName)) != false)
            {
                    val_30 = "_MainTex";
                this.Textures[0x0][0].ShaderPropertyName = val_30;
            }
            else
            {
                    val_30 = this.Textures[0x0][0].ShaderPropertyName;
            }
            
                new UnityEngine.Material().SetTexture(name:  val_30, value:  val_27.Texture);
                if((val_5.GetComponent<UvScroller>()) == 0)
            {
                    UvScroller val_20 = val_5.AddComponent<UvScroller>();
            }
            
            }
            
            val_28 = 1;
            label_16:
            if(val_28 < this.Textures[0x0][0].ToObjects.Length)
            {
                goto label_47;
            }
            
            goto label_48;
            label_15:
            if(val_26 < this.Textures.Length)
            {
                goto label_50;
            }
            
            if((false & 1) != 0)
            {
                    object[] val_21 = new object[2];
                val_27 = val_21;
                val_27[0] = this.Id;
                val_25 = val_25.name;
                val_27[1] = val_25;
                UnityEngine.Debug.LogErrorFormat(format:  "[WEAPON SKIN] set error: skin:\'{0}\', go:\'{1}\'", args:  val_21);
            }
            
            val_31 = false ^ 1;
            return (bool)val_31 & 1;
            label_8:
            val_31 = 0;
            return (bool)val_31 & 1;
        }
        public bool 七丛且丂丏世丟丄丂(UnityEngine.GameObject 丝三丁东丈丒世丅业)
        {
            UnityEngine.Object val_25;
            var val_26;
            Rilisoft.WeaponSkinTexture val_27;
            var val_28;
            UnityEngine.Material val_29;
            string val_30;
            var val_31;
            val_25 = 丝三丁东丈丒世丅业;
            if(val_25 == 0)
            {
                goto label_3;
            }
            
            val_26 = 0;
            goto label_10;
            label_44:
            val_27 = this.Textures[0];
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<System.String>(丑东与丅丐丅丂丞业:  this.Textures[0x0][0].ToObjects)) == false)
            {
                goto label_9;
            }
            
            label_42:
            val_26 = 1;
            goto label_10;
            label_9:
            val_28 = 0;
            goto label_11;
            label_41:
            UnityEngine.Object val_5 = ((System.String.op_Equality(a:  val_25.name, b:  this.Textures[0x0][0].ToObjects[0])) != true) ? (val_25) : 0;
            if(val_5 != 0)
            {
                    UnityEngine.Renderer val_7 = val_5.GetComponent<UnityEngine.Renderer>();
                val_29 = val_7.material;
                bool val_27 = false;
                val_27 = val_27 | (UnityEngine.Object.op_Equality(x:  val_7, y:  0));
                if((System.String.op_Inequality(a:  val_29.shader.name, b:  this.ShaderName)) != false)
            {
                    UnityEngine.Shader val_13 = UnityEngine.Shader.Find(name:  this.ShaderName);
                val_29 = new UnityEngine.Material();
                val_29 = new UnityEngine.Material(shader:  val_13);
                val_7.material = new UnityEngine.Material();
                bool val_28 = val_27;
                val_28 = val_28 | (UnityEngine.Object.op_Equality(x:  val_13, y:  0));
            }
            
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.Textures[0x0][0].ShaderPropertyName)) != false)
            {
                    val_30 = "_MainTex";
                this.Textures[0x0][0].ShaderPropertyName = val_30;
            }
            else
            {
                    val_30 = this.Textures[0x0][0].ShaderPropertyName;
            }
            
                new UnityEngine.Material().SetTexture(name:  val_30, value:  val_27.Texture);
                if((val_5.GetComponent<UvScroller>()) == 0)
            {
                    UvScroller val_20 = val_5.AddComponent<UvScroller>();
            }
            
            }
            
            val_28 = 1;
            label_11:
            if(val_28 < this.Textures[0x0][0].ToObjects.Length)
            {
                goto label_41;
            }
            
            goto label_42;
            label_10:
            if(val_26 < this.Textures.Length)
            {
                goto label_44;
            }
            
            if((false & 1) != 0)
            {
                    object[] val_21 = new object[2];
                val_27 = val_21;
                val_27[0] = this.Id;
                val_25 = val_25.name;
                val_27[1] = val_25;
                UnityEngine.Debug.LogErrorFormat(format:  "[WEAPON SKIN] set error: skin:\'{0}\', go:\'{1}\'", args:  val_21);
            }
            
            val_31 = false ^ 1;
            return (bool)val_31 & 1;
            label_3:
            val_31 = 0;
            return (bool)val_31 & 1;
        }
        internal static Rilisoft.WeaponSkin 一丅丘上不丕丁世丕(UnityEngine.GameObject 丝三丁东丈丒世丅业, string 丞丅上丏丂且下丅与, int 丒世丘丘上丆丝东丞, Rilisoft.丝一丌上丟且三一丏 丏丂不专上丘丂不丅, string 丈丁丄丘丛世七丙丝)
        {
            string val_23;
            Rilisoft.丝一丌上丟且三一丏 val_24;
            int val_25;
            string val_26;
            var val_27;
            var val_28;
            var val_29;
            System.Collections.Generic.List<T> val_30;
            UnityEngine.Object val_34;
            var val_35;
            val_23 = 丈丁丄丘丛世七丙丝;
            val_24 = 丏丂不专上丘丂不丅;
            val_25 = 丒世丘丘上丆丝东丞;
            val_26 = 丞丅上丏丂且下丅与;
            val_27 = 1152921505284374528;
            UnityEngine.GameObject val_1 = 丞东丑专丛丆丄丝世.七一与世与业丐且且(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 丒丘丏上丙丟丑丕丈:  "Arms_Mesh", 丟丝七七一丁丏丏丙:  true);
            val_28 = 1152921504848912384;
            val_29 = 0;
            if(val_1 == 0)
            {
                    return (Rilisoft.WeaponSkin)val_29;
            }
            
            System.Collections.Generic.List<Rilisoft.WeaponSkinTexture> val_3 = null;
            val_30 = val_3;
            val_3 = new System.Collections.Generic.List<Rilisoft.WeaponSkinTexture>();
            var val_26 = 0;
            val_26 = val_26 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = Unity.Linq.丅丆万丟丐丏丏下丄.丛且丞不业丅丆丝且(丈丆上丅丘世专丑丕:  val_1).GetEnumerator();
            label_42:
            var val_27 = 0;
            val_27 = val_27 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_16;
            }
            
            var val_28 = 0;
            val_28 = val_28 + 1;
            T val_10 = val_6.Current;
            UnityEngine.Renderer val_11 = val_10.GetComponent<UnityEngine.Renderer>();
            if(val_11 == 0)
            {
                goto label_42;
            }
            
            var val_29 = val_11.material;
            UnityEngine.Texture val_14 = val_29.mainTexture;
            if(val_14 != null)
            {
                    val_29 = (null == null) ? (val_14) : 0;
            }
            else
            {
                    val_34 = 0;
            }
            
            if(val_34 == 0)
            {
                goto label_42;
            }
            
            string[] val_17 = new string[1];
            val_17[0] = val_10.name;
            new Rilisoft.WeaponSkinTexture() = new Rilisoft.WeaponSkinTexture(丞丕丒专一下丙业上:  SkinsController.StringFromTexture(三与丕丘丌丈一丆七:  val_34), 与丘东下丈东丛丂万:  0, 一丗世三专三万丞丞:  0, 丄专不丂丄且三丛丆:  val_17);
            val_3.Add(item:  new Rilisoft.WeaponSkinTexture());
            goto label_42;
            label_16:
            val_28 = 0;
            val_35 = 0;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_30 = 0;
                val_30 = val_30 + 1;
                val_6.Dispose();
            }
            
            Rilisoft.WeaponSkin val_21 = null;
            val_29 = val_21;
            val_21 = new Rilisoft.WeaponSkin();
            三丐不东业东不丄丑 val_22 = 丞东丑专丛丆丄丝世.与丛丆专东丐一且丅<三丐不东业东不丄丑>(丙业与丙丗丝不丈东:  val_26);
            if(val_29 != null)
            {
                    .serverID = val_22;
                .Price = val_25;
            }
            else
            {
                    mem[16] = val_22;
                mem[32] = val_25;
            }
            
            .Currency = val_24;
            .Textures = val_3.ToArray();
            if((丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_23)) == null)
            {
                    return (Rilisoft.WeaponSkin)val_29;
            }
            
            string[] val_25 = new string[1];
            val_25[0] = val_23;
            .ToWeapons = val_25;
            return (Rilisoft.WeaponSkin)val_29;
        }
        public static string 丗一七不万丅丟丈丞(string 丅丕丟三丛不丕与丈)
        {
            null = null;
            System.Text.RegularExpressions.Match val_1 = Rilisoft.WeaponSkin._regex.Match(input:  丅丕丟三丛不丕与丈);
            if(val_1.Success == false)
            {
                    return (string)System.String.alignConst;
            }
            
            if(val_1 != null)
            {
                    return val_1.Value;
            }
            
            return val_1.Value;
        }
        public string get_Id()
        {
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            return (string)this.serverID.ToString();
        }
        public WeaponSkin()
        {
            this.Lkey = System.String.alignConst;
            this.ShaderName = "Mobile/Diffuse";
            this.Textures = new Rilisoft.WeaponSkinTexture[0];
            this.ToWeapons = new string[0];
        }
        private static WeaponSkin()
        {
            Rilisoft.WeaponSkin._regex = new System.Text.RegularExpressions.Regex(pattern:  "Weapon([0-9])+");
        }
    
    }

}
