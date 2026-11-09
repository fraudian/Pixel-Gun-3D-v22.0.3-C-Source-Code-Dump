using UnityEngine;

namespace PGCompany
{
    internal class ClanWarSquadEventFortView : PGBehaviour
    {
        // Fields
        private UISprite FlagSprite;
        private UISprite ShieldSprite;
        private UILabel ScoreLabel;
        private UITexture LogoTexture;
        private UILabel NameLabel;
        private UnityEngine.Color 丂丄一丗业丗丐万丏;
        private int 下丄丕丕世万专业丑;
        
        // Properties
        internal UnityEngine.Color 丕丆一且万业丙一丅 { get; set; }
        internal int 丄东丞丘丞下下下丙 { get; set; }
        internal string 专丕与丒丗丁丘专丟 { get; set; }
        internal UnityEngine.Texture 丛丛丐三丂丂不丅丁 { get; set; }
        
        // Methods
        internal UnityEngine.Color 下丗与丞丏丘三丒丟()
        {
            return new UnityEngine.Color() {r = this.丂丄一丗业丗丐万丏};
        }
        internal void 丄七丁业丙丘丟丁丏(UnityEngine.Color 丙业与丙丗丝不丈东)
        {
            float val_3;
            float val_4;
            float val_5;
            val_3 = 丙业与丙丗丝不丈东.a;
            val_4 = 丙业与丙丗丝不丈东.b;
            val_5 = 丙业与丙丗丝不丈东.g;
            this.丂丄一丗业丗丐万丏 = 丙业与丙丗丝不丈东;
            mem[1152921554242462580] = val_5;
            mem[1152921554242462584] = val_4;
            mem[1152921554242462588] = val_3;
            if(this.FlagSprite != 0)
            {
                    丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.FlagSprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.丂丄一丗业丗丐万丏, g = val_4, b = val_5, a = val_3});
            }
            
            if(this.ShieldSprite == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.ShieldSprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.丂丄一丗业丗丐万丏, g = val_4, b = val_5, a = val_3});
        }
        internal int 丞丏丕丑丞丑丏丏丄()
        {
            return (int)this.下丄丕丕世万专业丑;
        }
        internal void 一丟丌万东专丐丂丆(int 丙业与丙丗丝不丈东)
        {
            this.下丄丕丕世万专业丑 = 丙业与丙丗丝不丈东;
            if(this.ScoreLabel == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.ScoreLabel, 丕丗丘丑丛与丑业丒:  this.下丄丕丕世万专业丑.ToString());
        }
        internal string 东丙上东业丆不丟丘()
        {
            if(this.NameLabel == 0)
            {
                    return (string)System.String.alignConst;
            }
            
            if(this.NameLabel != null)
            {
                    return this.NameLabel.text;
            }
            
            return this.NameLabel.text;
        }
        internal void 丌丏上丏东且丄丑丌(string 丙业与丙丗丝不丈东)
        {
            if(this.NameLabel == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.NameLabel, 丕丗丘丑丛与丑业丒:  丙业与丙丗丝不丈东);
        }
        internal UnityEngine.Texture 丘万丆一丛丈丑且三()
        {
            if(this.LogoTexture == 0)
            {
                    return 0;
            }
            
            this = ???;
            goto typeof(UITexture).__il2cppRuntimeField_2D8;
        }
        internal void 丄丕七丒七丅七丒丙(UnityEngine.Texture 丙业与丙丗丝不丈东)
        {
            if(this.LogoTexture == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.LogoTexture, 与万丆丛丒万丝丙丑:  丙业与丙丗丝不丈东);
        }
        internal void 丈且东丑丂且万丒丅(UnityEngine.Color 丑丞丈丗丄丙丟万丄, int 万且丒下丕丝专丟上, 丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            丞丂丘丒丟丞丑下丄 val_3 = 且丟丅丄丒丑丂丁世;
            this.丄七丁业丙丘丟丁丏(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a});
            this.一丟丌万东专丐丂丆(丙业与丙丗丝不丈东:  万且丒下丕丝专丟上);
            if(val_3 == null)
            {
                goto label_2;
            }
            
            string val_1 = val_3.东丙上东业丆不丟丘();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            label_7:
            this.丌丏上丏东且丄丑丌(丙业与丙丗丝不丈东:  val_1);
            if(val_3 != null)
            {
                    val_3 = val_3.世丐专丂世丄世丂丌();
            }
            
            this.丄丕七丒七丅七丒丙(丙业与丙丗丝不丈东:  val_3);
            return;
            label_2:
            if(this != null)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        public ClanWarSquadEventFortView()
        {
        
        }
    
    }

}
