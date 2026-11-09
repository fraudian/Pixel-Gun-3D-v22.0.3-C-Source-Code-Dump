using UnityEngine;

namespace Rilisoft
{
    internal sealed class ClanLobbyWarLeaderboardViewItem : DynamicWrapGridItem
    {
        // Fields
        public UILabel ScoreLabel;
        public UILabel NameLabel;
        public UILabel PlaceLabel;
        public UITexture LogoTexture;
        public UITexture ShieldCenterTexture;
        public UITexture ShieldOutlineTexture;
        private Rilisoft.丅丏三专专丁丟下丈 丁丂东丂丗丂丛丟一;
        private UnityEngine.Color 丌丂丒丙丄不丞且丕;
        
        // Properties
        public 丞丂丘丒丟丞丑下丄 丞丂丘丒丟丞丑下丄 { get; }
        public int 丝三丐下丅专丐业七 { get; }
        
        // Methods
        public 丞丂丘丒丟丞丑下丄 get_Clan()
        {
            if(this.丁丂东丂丗丂丛丟一 == null)
            {
                    return (丞丂丘丒丟丞丑下丄)this.丁丂东丂丗丂丛丟一;
            }
            
            return this.丁丂东丂丗丂丛丟一.丒万万专丑丛万丛丙();
        }
        public int get_ClanPlace()
        {
            if(this.丁丂东丂丗丂丛丟一 == null)
            {
                    return (int)this.丁丂东丂丗丂丛丟一;
            }
            
            return this.丁丂东丂丗丂丛丟一.丞与丑与丑丙世丗丙();
        }
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Color val_1 = 丞东丑专丛丆丄丝世.万丐一与丄丐丌丆丟(丞上三丏且丕丅丗丌:  "ffd700");
            this.丌丂丒丙丄不丞且丕 = val_1;
            mem[1152921542387517124] = val_1.g;
            mem[1152921542387517128] = val_1.b;
            mem[1152921542387517132] = val_1.a;
        }
        public override void UpdateContent(object 三丏丑不业丏不丂丈)
        {
            if(三丏丑不业丏不丂丈 == null)
            {
                    return;
            }
        
        }
        private void 且丆丘一丆丕与下专()
        {
        
        }
        private void 丒七且七一丂专且一(Rilisoft.丅丏三专专丁丟下丈 一不丏专丒丄且万丗)
        {
            UnityEngine.Color val_18;
            float val_19;
            float val_20;
            float val_21;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.ScoreLabel, 丕丗丘丑丛与丑业丒:  一不丏专丒丄且万丗.丒万万专丑丛万丛丙().业不且丟丆下丏丌丒());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.NameLabel, 丕丗丘丑丛与丑业丒:  一不丏专丒丄且万丗.丒万万专丑丛万丛丙().东丙上东业丆不丟丘());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.PlaceLabel, 丕丗丘丑丛与丑业丒:  一不丏专丒丄且万丗.丞与丑与丑丙世丗丙());
            if(this.LogoTexture != 0)
            {
                    UnityEngine.Texture2D val_8 = 一不丏专丒丄且万丗.丒万万专丑丛万丛丙().世丐专丂世丄世丂丌();
            }
            
            UnityEngine.Color val_11 = PGCompany.丂丘丞丂丏七丁丄不.丙业不丘丝一丁丆丏(丄丒下业一不丈丝丘:  一不丏专丒丄且万丗.丒万万专丑丛万丛丙().业丐丐三丕一丗丛丁(), 丏丆丗丂丟丘丈万万:  0);
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.ShieldCenterTexture, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a});
            if(一不丏专丒丄且万丗.丞与丑与丑丙世丗丙() == 1)
            {
                    val_18 = this.丌丂丒丙丄不丞且丕;
            }
            else
            {
                    UnityEngine.Color val_13 = UnityEngine.Color.white;
                val_18 = val_13.r;
                val_19 = val_13.g;
                val_20 = val_13.b;
                val_21 = val_13.a;
            }
            
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.ShieldOutlineTexture, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_18, g = val_19, b = val_20, a = val_21});
        }
        public void OnClickHandler()
        {
            null = null;
            Rilisoft.ClanLobbyWarLeaderboardView.一下丆丌丂上丟丈且 = false;
            if((Rilisoft.Singleton<ClansVisitController>.Instance) != 0)
            {
                    ClansVisitController val_3 = Rilisoft.Singleton<ClansVisitController>.Instance;
                val_3.丁下且丙丟上丗丘丅 = true;
            }
            
            if(this.丁丂东丂丗丂丛丟一 == null)
            {
                goto label_8;
            }
            
            if((Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField) != null)
            {
                goto label_10;
            }
            
            label_11:
            label_10:
            Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField.一丐丕且丝丄上丁丄(丟一专与丟丟丘丝万:  this.丁丂东丂丗丂丛丟一.丒万万专丑丛万丛丙());
            return;
            label_8:
            if((Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField) != null)
            {
                goto label_10;
            }
            
            goto label_11;
        }
        public ClanLobbyWarLeaderboardViewItem()
        {
        
        }
    
    }

}
