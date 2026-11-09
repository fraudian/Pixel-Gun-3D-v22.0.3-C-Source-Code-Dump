using UnityEngine;

namespace Rilisoft
{
    public class InAppBonusLobbyScrollView : InAppBonusLobbyViewBase
    {
        // Fields
        private UnityEngine.GameObject _badge;
        private UnityEngine.GameObject _currencyObj;
        private UILabel _descriptionLabel;
        private UnityEngine.GameObject _gadgetsObj;
        private System.Collections.Generic.List<UIBasicSprite> _gadgetsTextures;
        private bool 世且丙丏丄七丗丛丗;
        private UnityEngine.Transform _gameEventSpecificObjParent;
        private Rilisoft.InAppBonusLobbyButtonDependingObject 不三东丒上丑且世丕;
        private UILabel _headerLabel;
        private UnityEngine.GameObject _leprechauntObj;
        private UnityEngine.GameObject _offerPackObj;
        private UIBasicSprite _offerPackTexture;
        private UnityEngine.GameObject _offerwallObj;
        private UnityEngine.GameObject _eventShopObj;
        private UILabel _packsGradientLabel;
        private UILabel _packsLabel;
        private UnityEngine.GameObject _petObj;
        private UIBasicSprite _petTexture;
        private UnityEngine.GameObject _recomendationObj;
        private UnityEngine.GameObject _recommendClanObj;
        private UnityEngine.GameObject _vipObj;
        private UnityEngine.GameObject _weaponObj;
        private UIBasicSprite _weaponTexture;
        
        // Properties
        internal UILabel 丞丄专业七丅丆丌丄 { get; }
        internal UILabel 丘一丞东丞丌不丙三 { get; }
        private UIBasicSprite 丘丈丏丘世一与丏丏 { get; }
        private UIBasicSprite 丈丐丗丞丙丞丁丄丑 { get; }
        private System.Collections.Generic.List<UIBasicSprite> 不丙丙丐丒丕不不专 { get; }
        private UIBasicSprite 丞上丘丙丕丌万业丟 { get; }
        
        // Methods
        private void 丌与丄丅丅上丗上丞(string 丟丟丄专上丟丁丐丝)
        {
            if(this.不三东丒上丑且世丕 != 0)
            {
                    if((System.String.op_Equality(a:  this.不三东丒上丑且世丕.name, b:  丟丟丄专上丟丁丐丝)) != false)
            {
                    return;
            }
            
                UnityEngine.Object.Destroy(obj:  this.不三东丒上丑且世丕.gameObject);
            }
            
            Rilisoft.丛且世丐丆上七业丁 val_6 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丌丐东业专丑丘丑丗(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝);
            this.不三东丒上丑且世丕 = GameEventsHalper.业一丁丙丏专下丟丗<Rilisoft.InAppBonusLobbyButtonDependingObject>(丅东专与不三丂丁丝:  val_6, 丒丘丏上丙丟丑丕丈:  "lobby", 丈东丘丏与丌东东下:  this._gameEventSpecificObjParent, 丛下丅丏丄且丁一业:  false);
            val_7.gameEvent = val_6;
            this.不三东丒上丑且世丕.gameObject.SetActive(value:  true);
        }
        internal UILabel 丗丗丁丛东丝上上不()
        {
            return (UILabel)this._descriptionLabel;
        }
        internal UILabel 丄上专专丂七丁三丗()
        {
            return (UILabel)this._packsLabel;
        }
        private UIBasicSprite 七丌丘万丌丕丝丞丐()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._weaponTexture);
            this._weaponTexture = val_1;
            return val_1;
        }
        private UIBasicSprite 丑丝上丌丒丝万且丒()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._petTexture);
            this._petTexture = val_1;
            return val_1;
        }
        private System.Collections.Generic.List<UIBasicSprite> 三业丝三丒丙丏且丄()
        {
            var val_4;
            if(this.世且丙丏丄七丗丛丗 == true)
            {
                    return (System.Collections.Generic.List<UIBasicSprite>)this._gadgetsTextures;
            }
            
            val_4 = 0;
            goto label_2;
            label_8:
            this._gadgetsTextures.set_Item(index:  0, value:  丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._gadgetsTextures.Item[0]));
            val_4 = 1;
            label_2:
            if(val_4 < this._gadgetsTextures.Count)
            {
                goto label_8;
            }
            
            return (System.Collections.Generic.List<UIBasicSprite>)this._gadgetsTextures;
        }
        private UIBasicSprite 东万丞东上丁不丌一()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._offerPackTexture);
            this._offerPackTexture = val_1;
            return val_1;
        }
        public override void UpdateView(bool 七丆丟丗世丟且丒丆 = False)
        {
            string val_76;
            var val_77;
            object val_78;
            var val_81;
            var val_82;
            var val_83;
            string val_84;
            var val_85;
            var val_86;
            var val_87;
            var val_88;
            var val_89;
            var val_90;
            var val_91;
            string val_92;
            var val_94;
            string val_95;
            var val_96;
            val_77 = 七丆丟丗世丟且丒丆;
            val_78 = this;
            if(43794 == 0)
            {
                    return;
            }
            
            if(0 == 0)
            {
                goto label_2;
            }
            
            if(val_77 == true)
            {
                goto label_9;
            }
            
            if(X22 == 0)
            {
                goto label_4;
            }
            
            val_81 = mem[X22 + 228];
            val_81 = X22 + 228;
            goto label_7;
            label_2:
            this.上丛业丙丙七丒丝丁();
            goto label_8;
            label_4:
            val_81 = mem[X22 + 228];
            val_81 = X22 + 228;
            if(0 == 0)
            {
                    val_82 = 0;
            }
            
            label_7:
            int val_1 = val_82.Pack;
            if(val_81 == val_1)
            {
                goto label_8;
            }
            
            if(val_1 == 0)
            {
                    val_83 = 0;
            }
            
            label_9:
            mem2[0] = val_83.Pack;
            if((val_2 + 240) != 1)
            {
                    if((val_2 + 240) != 5)
            {
                goto label_14;
            }
            
            }
            
            val_84 = "Key_2864";
            goto label_15;
            label_14:
            val_84 = "Key_2896";
            label_15:
            string val_5 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_84), arg0:  X23.Pack);
            this._packsLabel.text = val_5;
            label_8:
            if(null != 2)
            {
                goto label_25;
            }
            
            if(val_77 != true)
            {
                    if((System.String.op_Inequality(a:  this._packsLabel, b:  val_5)) == false)
            {
                goto label_25;
            }
            
            }
            
            UIBasicSprite val_7 = this.七丌丘万丌丕丝丞丐();
            val_86 = val_5;
            if(val_5 == null)
            {
                    if(val_86 == null)
            {
                goto label_183;
            }
            
            }
            
            label_68:
            label_110:
            if(val_7 != null)
            {
                goto label_108;
            }
            
            goto label_108;
            label_25:
            if(null != 23)
            {
                goto label_36;
            }
            
            if(val_77 == true)
            {
                goto label_34;
            }
            
            System.Func<System.String, System.Boolean> val_10 = new System.Func<System.String, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.InAppBonusLobbyScrollView::上丂与丐业丘上与丕(string 业七丐世专丝丂丟丈));
            if((System.Linq.Enumerable.Any<System.String>(source:  this._packsLabel, predicate:  val_10)) == false)
            {
                goto label_36;
            }
            
            label_34:
            val_87 = 1152921516223708000;
            val_88 = 1152921524390546800;
            val_89 = 0;
            goto label_37;
            label_52:
            string val_12 = val_10.Item[0];
            val_85 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上();
            if((val_85.ContainsKey(key:  val_12)) != false)
            {
                    if((丛且丗丌丏下七下丈.丑丞丞东丟丒丂上不(丞一丁业丄一一业且:  val_12)) != true)
            {
                    val_85 = this.七丌丘万丌丕丝丞丐();
            }
            
            }
            
            val_89 = 1;
            label_37:
            if(val_89 < (丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_12, 七丆丒与丗丌丄且丂:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_12), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false).Count))
            {
                goto label_52;
            }
            
            goto label_108;
            label_36:
            if(null != 3)
            {
                goto label_59;
            }
            
            if(val_77 != true)
            {
                    if((System.String.op_Inequality(a:  this._packsLabel, b:  val_5)) == false)
            {
                goto label_59;
            }
            
            }
            
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  val_5)) == null)
            {
                goto label_108;
            }
            
            this._descriptionLabel.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2901"), arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_22.Lkey));
            UIBasicSprite val_26 = this.丑丝上丌丒丝万且丒();
            goto label_68;
            label_59:
            if(null != 5)
            {
                goto label_75;
            }
            
            if(val_77 == true)
            {
                goto label_71;
            }
            
            System.Collections.Generic.List<UIBasicSprite> val_27 = this.三业丝三丒丙丏且丄();
            if((val_27.Count < 1) || ((System.Linq.Enumerable.Any<System.String>(source:  val_27, predicate:  new System.Func<System.String, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.InAppBonusLobbyScrollView::丙七丄世且丛万东丆(string 业七丐世专丝丂丟丈)))) == false))
            {
                goto label_75;
            }
            
            label_71:
            System.Collections.Generic.List<TSource> val_35 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Intersect<System.String>(first:  System.Linq.Enumerable.ToList<System.String>(source:  丁下万丟且丟丛下业.丁丐丄丝不丅丗丄与(丞丁丏且与丒丐业下:  ExperienceController.丞丞丘业东丙丏七丌())), second:  X23 + 112));
            val_90 = 1152921539905723248;
            val_88 = 1152921516934571616;
            val_87 = 1152921516223708000;
            val_91 = 0;
            goto label_81;
            label_99:
            if(val_91 < val_35.Count)
            {
                    string val_37 = val_35.Item[0];
                if((丁下万丟且丟丛下业.一三专丞丒丅上业上().ContainsKey(key:  val_37)) != false)
            {
                    丕丈丏丝丗下丟丅丂 val_41 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[val_37];
                UIBasicSprite val_43 = this.三业丝三丒丙丏且丄().Item[0];
                if(val_41 != null)
            {
                    val_92 = val_41.业上丙丞丐丄丆丅七();
            }
            else
            {
                    val_92 = val_41.业上丙丞丐丄丆丅七();
            }
            
                UnityEngine.Texture val_47 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_92, 七丆丒与丗丌丄且丂:  val_41.丒万丕七专不丏丞丌(), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
                val_87 = val_87;
                val_77 = val_77;
                val_90 = 1152921539905723248;
            }
            
            }
            
            val_91 = 1;
            label_81:
            val_85 = this.三业丝三丒丙丏且丄();
            if(val_91 < val_85.Count)
            {
                goto label_99;
            }
            
            goto label_108;
            label_75:
            if(null != 7)
            {
                goto label_108;
            }
            
            if(val_77 != true)
            {
                    if(this._packsLabel == null)
            {
                goto label_108;
            }
            
            }
            
            if( == 0)
            {
                goto label_108;
            }
            
            this._descriptionLabel.text = ">>> OFFER <<< \n >>> PACK <<<";
            UIBasicSprite val_50 = this.东万丞东上丁不丌一();
            UnityEngine.Texture val_51 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/MiniOfferIcons/offer_icon_offerPack");
            goto label_110;
            label_108:
            if(val_7 == null)
            {
                    if(val_77 == false)
            {
                    return;
            }
            
            }
            
            val_76 = 1152921505284374528;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._badge, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._currencyObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._leprechauntObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._weaponObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._petObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._gadgetsObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._offerPackObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._recomendationObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._offerwallObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._eventShopObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._vipObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._recommendClanObj, 丏业丟一东丂东丘丛:  false);
            UnityEngine.GameObject val_52 = this._packsLabel.gameObject;
            if((丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_5, 七丆丒与丗丌丄且丂:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  X23), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false)) == 6)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_52, 丏业丟一东丂东丘丛:  false);
                UnityEngine.GameObject val_53 = this._packsGradientLabel.gameObject;
                val_94 = 1;
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_52, 丏业丟一东丂东丘丛:  true);
                val_94 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._packsGradientLabel.gameObject, 丏业丟一东丂东丘丛:  false);
            UnityEngine.GameObject val_55 = this._headerLabel.gameObject;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_55, 丏业丟一东丂东丘丛:  true);
            if(null != 1)
            {
                goto label_131;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._currencyObj, 丏业丟一东丂东丘丛:  true);
            val_76 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2875");
            this._headerLabel.text = val_76;
            val_78 = this._descriptionLabel;
            val_95 = "Key_2906";
            goto label_234;
            label_131:
            if(null != 2)
            {
                goto label_139;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._weaponObj, 丏业丟一东丂东丘丛:  true);
            val_76 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2892");
            this._headerLabel.text = val_76;
            val_78 = this._descriptionLabel;
            val_95 = "Key_2893";
            goto label_234;
            label_139:
            if(null != 3)
            {
                goto label_147;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._petObj, 丏业丟一东丂东丘丛:  true);
            val_78 = this._headerLabel;
            val_95 = "Key_2882";
            goto label_234;
            label_147:
            if(null != 4)
            {
                goto label_154;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._leprechauntObj, 丏业丟一东丂东丘丛:  true);
            val_76 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2900");
            this._headerLabel.text = val_76;
            val_78 = this._descriptionLabel;
            val_95 = "Key_2899";
            goto label_234;
            label_154:
            if(null != 5)
            {
                goto label_162;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._gadgetsObj, 丏业丟一东丂东丘丛:  true);
            val_76 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2883");
            this._headerLabel.text = val_76;
            val_78 = this._descriptionLabel;
            val_95 = "Key_2897";
            label_234:
            label_182:
            label_190:
            val_78.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_95);
            return;
            label_162:
            if(val_55 == null)
            {
                goto label_169;
            }
            
            if(null != 6)
            {
                goto label_170;
            }
            
            Rilisoft.GameEventData val_61 = val_55.丁专丗万三上丟三丆();
            this.丌与丄丅丅上丗上丞(丟丟丄专上丟丁丐丝:  val_61.EventId);
            if(null == 0)
            {
                    return;
            }
            
            this._headerLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  丑丐丏丌丑下一丑丒());
            string val_64 = this._headerLabel.七业丆且丅丘上丞丞();
            goto label_182;
            label_169:
            if(null == 0)
            {
                goto label_183;
            }
            
            val_96 = null;
            label_170:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._offerPackObj, 丏业丟一东丂东丘丛:  true);
            this._headerLabel.text = ">>> offer pack <<<";
            if(this._descriptionLabel != null)
            {
                goto label_190;
            }
            
            goto label_190;
            label_183:
        }
        protected override void 丗丌丂丙丈丆不丂七()
        {
        
        }
        private void 上丛业丙丙七丒丝丁()
        {
            int val_9;
            if(FriendsController.丝丗专上三不丄丑丑() < 1)
            {
                    return;
            }
            
            long val_9 = X21 + 72;
            val_9 = val_9 - FriendsController.丝丗专上三不丄丑丑();
            long val_3 = System.Math.Max(val1:  0, val2:  val_9);
            if(val_3 >= 1)
            {
                    System.TimeSpan val_4 = System.TimeSpan.FromSeconds(value:  (double)val_3);
                val_9 = System.String.Format(format:  "{0}{1}{2}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0984"), arg1:  System.Environment.NewLine, arg2:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_4._ticks}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
            }
            else
            {
                    val_9 = System.String.alignConst;
            }
            
            if((X21 + 240) != 6)
            {
                goto label_18;
            }
            
            if(this._packsGradientLabel != null)
            {
                goto label_20;
            }
            
            label_21:
            label_20:
            this._packsGradientLabel.text = val_9;
            return;
            label_18:
            if(this._packsLabel != null)
            {
                goto label_20;
            }
            
            goto label_21;
        }
        public InAppBonusLobbyScrollView()
        {
        
        }
        private bool 上丂与丐业丘上与丕(string 业七丐世专丝丂丟丈)
        {
            .业七丐世专丝丂丟丈 = 业七丐世专丝丂丟丈;
            return System.Linq.Enumerable.All<System.String>(source:  业七丐世专丝丂丟丈, predicate:  new System.Func<System.String, System.Boolean>(object:  new InAppBonusLobbyScrollView.且且丛丌丝三丏丙丛(), method:  System.Boolean InAppBonusLobbyScrollView.且且丛丌丝三丏丙丛::丆丞世与一下下丈一(string 丌丘丝三丆丌七丛专)));
        }
        private bool 丙七丄世且丛万东丆(string 业七丐世专丝丂丟丈)
        {
            .业七丐世专丝丂丟丈 = 业七丐世专丝丂丟丈;
            return System.Linq.Enumerable.All<System.String>(source:  业七丐世专丝丂丟丈, predicate:  new System.Func<System.String, System.Boolean>(object:  new InAppBonusLobbyScrollView.丂下丌丝且不世丌与(), method:  System.Boolean InAppBonusLobbyScrollView.丂下丌丝且不世丌与::丝下东三上丕丁专丙(string 丌丘丝三丆丌七丛专)));
        }
    
    }

}
