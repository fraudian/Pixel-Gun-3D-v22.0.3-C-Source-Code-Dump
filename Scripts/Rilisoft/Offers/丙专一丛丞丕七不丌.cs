using UnityEngine;

namespace Rilisoft.Offers
{
    internal class 丙专一丛丞丕七不丌 : 三丞专不丕七上一丁
    {
        // Fields
        private const int 丅丌丑丙丒丄丝下万 = 100;
        private const int 丑丟丆丕万丟丒丏且 = 200;
        private System.Nullable<CategoryNames> 东丗丈丄且东丂一丗;
        private Rilisoft.业丙丘丆东丈丕丂丄 且七丞丅不七丙丌与;
        private System.Collections.Generic.List<Rilisoft.OfferItem> 不丙丙丕专不丞七上;
        private System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, int> 上三上东丝上七且丆;
        
        // Methods
        public override System.Collections.Generic.List<Rilisoft.OfferItem> 丞丙东丌一三专丏不(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌)
        {
            var val_3;
            Rilisoft.业丙丘丆东丈丕丂丄 val_134;
            var val_136;
            var val_137;
            var val_138;
            世丕三丙七丆丁丂丒 val_139;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_140;
            int val_141;
            var val_142;
            int val_143;
            var val_144;
            var val_145;
            var val_146;
            var val_147;
            var val_148;
            var val_149;
            var val_150;
            var val_151;
            var val_152;
            var val_153;
            var val_154;
            Rilisoft.OfferItem val_155;
            var val_156;
            var val_157;
            var val_158;
            var val_159;
            var val_160;
            var val_161;
            var val_162;
            var val_163;
            var val_164;
            var val_165;
            var val_166;
            var val_168;
            var val_170;
            int val_172;
            val_134 = 丙业丞丑七丗下丟丌;
            List.Enumerator<T> val_1 = this.不丙丙丕专不丞七上.GetEnumerator();
            val_136 = 1152921525755361760;
            val_137 = 1152921505475907584;
            label_5:
            if((450520480 & 1) == 0)
            {
                goto label_2;
            }
            
            Rilisoft.OfferItem.丁丟丞丗丆七丙丐丌(下丅丙一丂丗丅丝七:  val_3.丐丏七丌丕丗业且上());
            goto label_5;
            label_2:
            val_138 = 450520368;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.不丙丙丕专不丞七上.Clear();
            this.上三上东丝上七且丆.Clear();
            this.且七丞丅不七丙丌与 = val_134;
            Progress.OfferProgress val_5 = val_134.业丑丁丆丕丆丂丅万();
            if(val_5.PreparedItems == null)
            {
                    Progress.OfferProgress val_6 = this.且七丞丅不七丙丌与.业丑丁丆丕丆丂丅万();
                val_6.PreparedItems = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            }
            
            Rilisoft.七丈业与与不七丈丟 val_10 = this.且七丞丅不七丙丌与.丁专丗万三上丟三丆();
            val_139 = val_10.丒上一丁丆丛东专丙;
            if(val_139 == null)
            {
                goto label_22;
            }
            
            val_140 = this.且七丞丅不七丙丌与.业丑丁丆丕丆丂丅万();
            if(val_11.PreparedItemsForPlayerPayment != Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丘七丒丕丏东丈与七())
            {
                    Progress.OfferProgress val_12 = this.且七丞丅不七丙丌与.业丑丁丆丕丆丂丅万();
                if(val_12.PreparedItemsForPlayerPayment != 1)
            {
                    Progress.OfferProgress val_13 = this.且七丞丅不七丙丌与.业丑丁丆丕丆丂丅万();
                val_13.PreparedItems.Clear();
            }
            
            }
            
            if(val_10.丒上一丁丆丛东专丙.一丌丌丟丟丐世万丏 >= 1)
            {
                    this.一七上丞丟丗丛丑丕(业丈世与下丘丛丐且:  12, 下丗丁丒丘东丂不丑:  30, 丞世丘丗丝专下下七:  val_10.丒上一丁丆丛东专丙.一丌丌丟丟丐世万丏, 与万丁丈与且丁三丁:  this.不丙丙丕专不丞七上, 七丑上丄丞业丝丄丞:  0);
            }
            
            if(val_10.丒上一丁丆丛东专丙.丒丙丘丙丒不业丂丏 >= 1)
            {
                    this.一七上丞丟丗丛丑丕(业丈世与下丘丛丐且:  6, 下丗丁丒丘东丂不丑:  40, 丞世丘丗丝专下下七:  val_10.丒上一丁丆丛东专丙.丒丙丘丙丒不业丂丏, 与万丁丈与且丁三丁:  this.不丙丙丕专不丞七上, 七丑上丄丞业丝丄丞:  0);
            }
            
            if(val_10.丒上一丁丆丛东专丙.丈与丄丞丆丛丐专三 >= 1)
            {
                    this.一七上丞丟丗丛丑丕(业丈世与下丘丛丐且:  10, 下丗丁丒丘东丂不丑:  50, 丞世丘丗丝专下下七:  val_10.丒上一丁丆丛东专丙.丈与丄丞丆丛丐专三, 与万丁丈与且丁三丁:  this.不丙丙丕专不丞七上, 七丑上丄丞业丝丄丞:  0);
            }
            
            if(val_10.丒上一丁丆丛东专丙.下丑东东且丞丏世下 >= 1)
            {
                    val_140 = this.不丙丙丕专不丞七上;
                string[] val_14 = new string[1];
                val_14[0] = "cape_Custom";
                this.一七上丞丟丗丛丑丕(业丈世与下丘丛丐且:  9, 下丗丁丒丘东丂不丑:  60, 丞世丘丗丝专下下七:  val_10.丒上一丁丆丛东专丙.下丑东东且丞丏世下, 与万丁丈与且丁三丁:  val_140, 七丑上丄丞业丝丄丞:  val_14);
            }
            
            if(val_10.丒上一丁丆丛东专丙.与丂三世丛丗且丘丛 >= 1)
            {
                    this.丌东下丟万丌世丗丐(业丈世与下丘丛丐且:  0, 丞世丘丗丝专下下七:  val_10.丒上一丁丆丛东专丙.与丂三世丛丗且丘丛, 与万丁丈与且丁三丁:  this.不丙丙丕专不丞七上);
            }
            
            if(val_10.丒上一丁丆丛东专丙.丅丈一东东丑丆丟丛 >= 1)
            {
                    this.丌东下丟万丌世丗丐(业丈世与下丘丛丐且:  80, 丞世丘丗丝专下下七:  val_10.丒上一丁丆丛东专丙.与丂三世丛丗且丘丛, 与万丁丈与且丁三丁:  this.不丙丙丕专不丞七上);
            }
            
            val_141 = val_10.丒上一丁丆丛东专丙.丐世丑丈丟丏专专丝;
            if(val_141 >= 1)
            {
                    val_142 = null;
                val_142 = null;
                val_141 = val_10.丒上一丁丆丛东专丙.丐世丑丈丟丏专专丝;
                val_140 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
                bool val_16 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  232, 丞丅上丏丂且下丅与:  val_140, 丌丒丝东丌下丕丁丅:  val_141), 专丂丕丗丗东世丞下:  this.不丙丙丕专不丞七上);
            }
            
            val_143 = val_10.丒上一丁丆丛东专丙.丕丁丙与丙丝丞上丄;
            if(val_143 >= 1)
            {
                    val_144 = null;
                val_144 = null;
                val_143 = val_10.丒上一丁丆丛东专丙.丕丁丙与丙丝丞上丄;
                val_140 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
                bool val_18 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  242, 丞丅上丏丂且下丅与:  val_140, 丌丒丝东丌下丕丁丅:  val_143), 专丂丕丗丗东世丞下:  this.不丙丙丕专不丞七上);
            }
            
            if(val_10.丒上一丁丆丛东专丙.东丝业丅丏丟七丗且 >= 1)
            {
                    string val_19 = Rilisoft.三一丈七且丄与丝东.丝丌丛丂且一丑上丌(且下丕七丙丗丄不七:  100);
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_19)) != true)
            {
                    val_140 = val_10.丒上一丁丆丛东专丙.东丝业丅丏丟七丗且;
                bool val_22 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  26, 丞丅上丏丂且下丅与:  val_19, 丌丒丝东丌下丕丁丅:  val_140), 专丂丕丗丗东世丞下:  this.不丙丙丕专不丞七上);
            }
            
            }
            
            if(val_10.丒上一丁丆丛东专丙.丅与丛丘丁丈业丆业 >= 1)
            {
                    if(Rilisoft.VIPController.丌丏丄专丘丕丑上且() != true)
            {
                    if((Rilisoft.Singleton<Rilisoft.VIPController>.Instance.下一与丄丄丆三丝丐()) == false)
            {
                goto label_65;
            }
            
            }
            
                bool val_27 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  36, 丞丅上丏丂且下丅与:  "Vip", 丌丒丝东丌下丕丁丅:  val_10.丒上一丁丆丛东专丙.丅与丛丘丁丈业丆业), 专丂丕丗丗东世丞下:  this.不丙丙丕专不丞七上);
            }
            
            label_65:
            if(val_10.丒上一丁丆丛东专丙.丌且丕丄丞丗丄与丂 >= 1)
            {
                    if((Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝()) != null)
            {
                    bool val_31 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  86, 丞丅上丏丂且下丅与:  "BattlePassCurrency", 丌丒丝东丌下丕丁丅:  val_10.丒上一丁丆丛东专丙.丌且丕丄丞丗丄与丂), 专丂丕丗丗东世丞下:  this.不丙丙丕专不丞七上);
            }
            
            }
            
            if(val_10.丒上一丁丆丛东专丙.丕丝丛七丂世不且丒 == null)
            {
                goto label_88;
            }
            
            List.Enumerator<T> val_32 = val_10.丒上一丁丆丛东专丙.丕丝丛七丂世不且丒.GetEnumerator();
            goto label_74;
            label_81:
            string val_33 = val_3.丐丏七丌丕丗业且上();
            val_145 = 0;
            goto label_75;
            label_80:
            val_140 = Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  70, 丞丅上丏丂且下丅与:  System.String.alignConst, 丌丒丝东丌下丕丁丅:  1);
            this.不丙丙丕专不丞七上.Add(item:  val_140);
            val_145 = 1;
            label_75:
            if(val_145 < val_33.m_stringLength)
            {
                goto label_80;
            }
            
            label_74:
            if((450520448 & 1) != 0)
            {
                goto label_81;
            }
            
            val_138 = 450520368;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_134 = val_134;
            val_136 = 1152921525755361760;
            val_137 = 1152921505475907584;
            goto label_88;
            label_22:
            val_146 = 0;
            return (System.Collections.Generic.List<Rilisoft.OfferItem>)System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  this.不丙丙丕专不丞七上);
            label_88:
            if(val_10.丒上一丁丆丛东专丙.一丗丁且不丒丗丁且 == null)
            {
                goto label_89;
            }
            
            List.Enumerator<T> val_35 = val_10.丒上一丁丆丛东专丙.一丗丁且不丒丗丁且.GetEnumerator();
            goto label_90;
            label_113:
            string val_36 = val_3.丐丏七丌丕丗业且上();
            val_147 = 0;
            goto label_91;
            label_112:
            if((val_36 == null) || (val_36.Count <= 0))
            {
                goto label_107;
            }
            
            val_140 = X23.Item[0];
            if((val_140 == null) || ((Rilisoft.PetsManager.丌丈万丆一丒不世三(世丐丗专丅三丝丑丆:  val_140)) == false))
            {
                goto label_107;
            }
            
            bool val_40 = Rilisoft.PetsManager.丌丝丄丟丅业且丗丂(世丐丗专丅三丝丑丆:  val_140);
            if(val_40 == false)
            {
                goto label_101;
            }
            
            val_140 = val_40.丕三丅丘三丕一丙东(不三丙万与丗丌七丈:  168, 丞丅上丏丂且下丅与:  val_140);
            if(val_140 == null)
            {
                goto label_107;
            }
            
            val_148 = null;
            val_148 = null;
            val_140 = val_140.丟丂丞不专丆万丒世();
            val_137 = 1152921505475907584;
            bool val_48 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  ((System.String.op_Equality(a:  val_140.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != true) ? 1000 : 1010, 丞丅上丏丂且下丅与:  val_140.东与三丌丅三丒丏业(), 丌丒丝东丌下丕丁丅:  val_140), 专丂丕丗丗东世丞下:  this.不丙丙丕专不丞七上);
            goto label_107;
            label_101:
            val_140 = Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  80, 丞丅上丏丂且下丅与:  val_140, 丌丒丝东丌下丕丁丅:  1);
            this.不丙丙丕专不丞七上.Add(item:  val_140);
            label_107:
            val_147 = 1;
            label_91:
            if(val_147 < val_36.m_stringLength)
            {
                goto label_112;
            }
            
            label_90:
            val_134 = val_134;
            if((450520448 & 1) != 0)
            {
                goto label_113;
            }
            
            val_138 = 450520368;
            val_136 = 1152921525755361760;
            val_149 = 0;
            val_150 = 0;
            goto label_114;
            label_89:
            val_150 = 0;
            goto label_115;
            label_114:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( == 1) || (1088 != 1088))
            {
                goto label_133;
            }
            
            label_115:
            val_149 = 0;
            goto label_135;
            label_133:
            if(null != null)
            {
                    val_150 = 0;
            }
            
            label_135:
            if(val_10.丒上一丁丆丛东专丙.丁丞丘丏丘丐丟丒三 == null)
            {
                goto label_198;
            }
            
            List.Enumerator<T> val_50 = val_10.丒上一丁丆丛东专丙.丁丞丘丏丘丐丟丒三.GetEnumerator();
            goto label_137;
            label_169:
            val_140 = val_3.丐丏七丌丕丗业且上();
            val_151 = 0;
            goto label_138;
            label_168:
            Rilisoft.丏丘七丞丄丙丌丞丁 val_54 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  Item[0]);
            if(val_54 != null)
            {
                    if(((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丕丌丈丏丙丁丟东丘(下丅丙一丂丗丅丝七:  val_54)) != true) && (val_54.丐万且七专丒七丛丞() != false))
            {
                    bool val_60 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  85, 丞丅上丏丂且下丅与:  val_54.Item[0], 丌丒丝东丌下丕丁丅:  1), 专丂丕丗丗东世丞下:  this.不丙丙丕专不丞七上);
            }
            else
            {
                    val_152 = null;
                val_152 = null;
                val_153 = null;
                if((System.String.op_Equality(a:  val_54.丙丕丞且丕不丘丙丑().丞丅世丄业丗丄丄丈().东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
            {
                    val_154 = null;
                val_155 = Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  232, 丞丅上丏丂且下丅与:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丌丒丝东丌下丕丁丅:  val_54.丙丕丞且丕不丘丙丑().丞丅世丄业丗丄丄丈().丟丂丞不专丆万丒世());
            }
            else
            {
                    val_156 = null;
                val_155 = Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  242, 丞丅上丏丂且下丅与:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 丌丒丝东丌下丕丁丅:  val_54.丙丕丞且丕不丘丙丑().丞丅世丄业丗丄丄丈().丟丂丞不专丆万丒世());
            }
            
                bool val_73 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  val_155, 专丂丕丗丗东世丞下:  this.不丙丙丕专不丞七上);
            }
            
            }
            
            val_137 = 1152921505475907584;
            val_151 = 1;
            label_138:
            if(val_151 < val_51.m_stringLength)
            {
                goto label_168;
            }
            
            label_137:
            if((450520448 & 1) != 0)
            {
                goto label_169;
            }
            
            val_149 = 1;
            val_136 = 1152921525755361760;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && (1088 == 1391))
            {
                    var val_132 = 0;
                val_132 = val_132 ^ 0;
                val_149 =  + val_132;
            }
            else
            {
                    if( != 0)
            {
                    val_150 = 0;
            }
            
            }
            
            label_198:
            if(val_10.丒上一丁丆丛东专丙.丌丘不丑丗三不丐丏 >= 1)
            {
                    this.丂丐丆丑丗下丆丆上(上丂丝世丝丌专丙丛:  val_10.丒上一丁丆丛东专丙.丌丘不丑丗三不丐丏, 与万丁丈与且丁三丁:  this.不丙丙丕专不丞七上);
            }
            
            if(val_10.丒上一丁丆丛东专丙.不七丆一丆丘东丄丛 >= 1)
            {
                    val_140 = 1040.ToString();
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                bool val_76 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  16, 丞丅上丏丂且下丅与:  val_140, 丌丒丝东丌下丕丁丅:  val_10.丒上一丁丆丛东专丙.不七丆一丆丘东丄丛), 专丂丕丗丗东世丞下:  this.不丙丙丕专不丞七上);
            }
            
            if(val_10.丒上一丁丆丛东专丙.丛一业丆下丒丏一丝 != null)
            {
                    this.丞丘下上世一丝丏三(丙业丞丑七丗下丟丌:  null, 上一丁丆七世业一且:  val_139);
            }
            
            if(val_10.丒上一丁丆丛东专丙.且东丌丏丐丝丕万业 == null)
            {
                goto label_378;
            }
            
            List.Enumerator<T> val_77 = val_10.丒上一丁丆丛东专丙.且东丌丏丐丝丕万业.GetEnumerator();
            goto label_291;
            label_293:
            new 丙专一丛丞丕七不丌.丘丞上世丗丘丏丐东() = new 丙专一丛丞丕七不丌.丘丞上世丗丘丏丐东();
            val_140 = val_3.丐丏七丌丕丗业且上();
            if(new 丙专一丛丞丕七不丌.丘丞上世丗丘丏丐东() == null)
            {
                goto label_208;
            }
            
            val_137 = new 丙专一丛丞丕七不丌.丘丞上世丗丘丏丐东();
            .丛业且上丑不丄丄丅 = val_140;
            if(val_140 == null)
            {
                goto label_291;
            }
            
            label_223:
            if(new 丙专一丛丞丕七不丌.丘丞上世丗丘丏丐东() == null)
            {
                    val_140 = .丛业且上丑不丄丄丅;
            }
            
            if((Rilisoft.下丐丒一丝丈丝三丞.丌丆不不东丅丟万东(下丅丙一丂丗丅丝七:  val_140)) == false)
            {
                goto label_213;
            }
            
            if(丑且一丐东三不丈丝() != 100)
            {
                goto label_291;
            }
            
            丈丞丕丘丕丗与上一 val_82 = .丛业且上丑不丄丄丅.PriceOfThisItem;
            if((val_82 == null) || ((System.String.op_Inequality(a:  val_82.东与三丌丅三丒丏业(), b:  "Real")) == false))
            {
                goto label_291;
            }
            
            val_157 = ;
            goto label_221;
            label_208:
            mem[16] = val_140;
            val_140 = mem[16];
            val_137 = 16;
            if(val_140 == 0)
            {
                goto label_291;
            }
            
            goto label_223;
            label_213:
            val_140 = .丛业且上丑不丄丄丅;
            if((Rilisoft.下丐丒一丝丈丝三丞.丄不丅七业不丌丞与(下丅丙一丂丗丅丝七:  val_140)) == false)
            {
                goto label_291;
            }
            
            if(.丛业且上丑不丄丄丅.IsStackable == true)
            {
                goto label_230;
            }
            
            val_140 = this.不丙丙丕专不丞七上;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_88 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  new 丙专一丛丞丕七不丌.丘丞上世丗丘丏丐东(), method:  System.Boolean 丙专一丛丞丕七不丌.丘丞上世丗丘丏丐东::万丆七万上丕东丝与(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
            if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_140, predicate:  null)) == true)
            {
                goto label_291;
            }
            
            label_230:
            if(.丛业且上丑不丄丄丅.Type != 10)
            {
                goto label_247;
            }
            
            val_158 = null;
            val_158 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
            {
                goto label_247;
            }
            
            val_159 = null;
            val_159 = null;
            val_140 = WeaponManager.丟丗丄业丘丗业丗七;
            if((val_140.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  .丛业且上丑不丄丄丅.Id)) == true)
            {
                goto label_291;
            }
            
            if(丑且一丐东三不丈丝() == 70)
            {
                goto label_247;
            }
            
            val_160 = null;
            val_160 = null;
            val_140 = WeaponManager.丟丗丄业丘丗业丗七;
            if((val_140.世世丟上三与东丘不(丒东业不丐丑丕丄丆:  .丛业且上丑不丄丄丅.Id)) == true)
            {
                goto label_291;
            }
            
            label_247:
            if(丑且一丐东三不丈丝() != 40)
            {
                goto label_255;
            }
            
            val_140 = .丛业且上丑不丄丄丅;
            if((Rilisoft.下丐丒一丝丈丝三丞.丄不丅七业不丌丞与(下丅丙一丂丗丅丝七:  val_140)) == false)
            {
                goto label_291;
            }
            
            label_255:
            val_140 = .丛业且上丑不丄丄丅.Type;
            bool val_103 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  val_140, 丞丅上丏丂且下丅与:  .丛业且上丑不丄丄丅.Id, 丌丒丝东丌下丕丁丅:  .丛业且上丑不丄丄丅.Count), 专丂丕丗丗东世丞下:  this.不丙丙丕专不丞七上);
            goto label_291;
            label_221:
            val_161 = 1152921505475907584;
            if((System.String.op_Equality(a:  val_82.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
            {
                    OfferModule val_105 = 丑且一丐东三不丈丝();
                val_3 = 0;
                val_140 = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Int32>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "cg");
                if(val_140 <= 0)
            {
                    val_140 = val_82.丟丂丞不专丆万丒世();
            }
            
                val_162 = null;
                val_157 = ;
                val_162 = null;
                val_161 = 1152921505475907584;
                val_149 = val_157;
                bool val_109 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  232, 丞丅上丏丂且下丅与:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丌丒丝东丌下丕丁丅:  val_140), 专丂丕丗丗东世丞下:  this.不丙丙丕专不丞七上);
            }
            else
            {
                    val_140 = val_82.东与三丌丅三丒丏业();
                val_149 = ;
                val_163 = null;
                val_163 = null;
                if((System.String.op_Equality(a:  val_140, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != false)
            {
                    OfferModule val_112 = 丑且一丐东三不丈丝();
                val_3 = 0;
                val_140 = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Int32>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "cc");
                val_164 = 1152921505475907584;
                if(val_140 <= 0)
            {
                    val_140 = val_82.丟丂丞不专丆万丒世();
            }
            
                val_165 = null;
                val_165 = null;
                val_164 = 1152921505475907584;
                val_149 = val_149;
                bool val_116 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  242, 丞丅上丏丂且下丅与:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 丌丒丝东丌下丕丁丅:  val_140), 专丂丕丗丗东世丞下:  this.不丙丙丕专不丞七上);
            }
            
            }
            
            label_291:
            if((450520480 & 1) != 0)
            {
                goto label_293;
            }
            
            val_166 =  + 1;
            mem2[0] = 2087;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_166 == 1)
            {
                goto label_350;
            }
            
            if(( == 0) || ((450520368 + ((val_149 + 1)) << 2) == 2087))
            {
                goto label_378;
            }
            
            label_377:
            label_378:
            val_139 = this.上三上东丝上七且丆;
            if(val_139.Count < 1)
            {
                goto label_372;
            }
            
            val_168 = null;
            val_168 = null;
            if((丙专一丛丞丕七不丌.<>c.<>9__6_1) == null)
            {
                goto label_357;
            }
            
            label_382:
            val_137 = 1152921543247501936;
            val_170 = null;
            val_139 = this.不丙丙丕专不丞七上.Find(match:  丙专一丛丞丕七不丌.<>c.<>9__6_1);
            val_170 = null;
            val_140 = 丙专一丛丞丕七不丌.<>c.<>9__6_2;
            if(val_140 == null)
            {
                goto label_361;
            }
            
            label_386:
            Rilisoft.OfferItem val_119 = this.不丙丙丕专不丞七上.Find(match:  val_140);
            if(val_139 == null)
            {
                goto label_365;
            }
            
            val_140 = this.上三上东丝上七且丆;
            if((val_140.ContainsKey(key:  232)) == false)
            {
                goto label_365;
            }
            
            if(val_119 == null)
            {
                goto label_366;
            }
            
            val_140 = val_139.Count;
            if(val_140 < val_119.Count)
            {
                goto label_367;
            }
            
            label_366:
            val_140 = this.上三上东丝上七且丆;
            val_172 = val_140.Item[232] + val_139.Count;
            goto label_369;
            label_365:
            if(val_119 == null)
            {
                goto label_372;
            }
            
            label_367:
            val_139 = this.上三上东丝上七且丆;
            if((val_139.ContainsKey(key:  242)) == false)
            {
                goto label_372;
            }
            
            val_140 = this.上三上东丝上七且丆;
            val_139 = val_119.Count;
            val_172 = val_140.Item[242] + val_139;
            label_369:
            val_119.Count = val_172;
            label_372:
            Rilisoft.七丈业与与不七丈丟 val_128 = 丁专丗万三上丟三丆();
            if(val_128.丒丌丑丟丄上世丅专 != false)
            {
                    this.丌东丑丑世一丗丘丆();
            }
            
            Rilisoft.Offers.丙专一丛丞丕七不丌.丝丟丑下上下丌丆七(丙业丞丑七丗下丟丌:  this.且七丞丅不七丙丌与, 东丗东专下七丕丕丑:  this.不丙丙丕专不丞七上);
            return (System.Collections.Generic.List<Rilisoft.OfferItem>)System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  this.不丙丙丕专不丞七上);
            label_350:
            if( != 0)
            {
                goto label_377;
            }
            
            goto label_378;
            label_357:
            丙专一丛丞丕七不丌.<>c.<>9__6_1 = new System.Predicate<Rilisoft.OfferItem>(object:  丙专一丛丞丕七不丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丙专一丛丞丕七不丌.<>c::丙一世丐且东下业且(Rilisoft.OfferItem 三丟东丕丄丄下下丑));
            if(this.不丙丙丕专不丞七上 != null)
            {
                goto label_382;
            }
            
            goto label_382;
            label_361:
            丙专一丛丞丕七不丌.<>c.<>9__6_2 = new System.Predicate<Rilisoft.OfferItem>(object:  丙专一丛丞丕七不丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丙专一丛丞丕七不丌.<>c::丅七丟上丟丁万东丝(Rilisoft.OfferItem 三丟东丕丄丄下下丑));
            if(this.不丙丙丕专不丞七上 != null)
            {
                goto label_386;
            }
            
            goto label_386;
        }
        private 丈丞丕丘丕丗与上一 丕三丅丘三丕一丙东(int 不三丙万与丗丌七丈, string 丞丅上丏丂且下丅与)
        {
            丈丞丕丘丕丗与上一 val_1 = 上丑三丁丄丛丁万丑.丞丟丛下丘下与上下(不三丙万与丗丌七丈:  不三丙万与丗丌七丈, 丞一丁业丄一一业且:  丞丅上丏丂且下丅与, 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
            if(val_1 == null)
            {
                    return 丏丄丑上丛不丈且万.丂丈一丐丂丟三丆丂(不三丙万与丗丌七丈:  不三丙万与丗丌七丈, 丛丐且下丂丏丁专丌:  丞丅上丏丂且下丅与, 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
            }
            
            return val_1;
        }
        private 丈丞丕丘丕丗与上一 丏一丙东东丐丐丏丑(int 不三丙万与丗丌七丈, string 丞丅上丏丂且下丅与)
        {
            return 丏丄丑上丛不丈且万.丂丈一丐丂丟三丆丂(不三丙万与丗丌七丈:  不三丙万与丗丌七丈, 丛丐且下丂丏丁专丌:  丞丅上丏丂且下丅与, 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
        }
        private void 丌东丑丑世一丗丘丆()
        {
            var val_6;
            var val_17;
            var val_26;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_31;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_32;
            var val_33;
            var val_34;
            Rilisoft.OfferItem val_35;
            var val_36;
            var val_37;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_40;
            var val_41;
            Rilisoft.OfferItem val_43;
            var val_44;
            var val_45;
            var val_46;
            val_31 = this;
            if(this.不丙丙丕专不丞七上 == null)
            {
                    return;
            }
            
            if(this.且七丞丅不七丙丌与.丑且一丐东三不丈丝() != 120)
            {
                    this.不丙丙丕专不丞七上.Sort(comparison:  new System.Comparison<Rilisoft.OfferItem>(object:  0, method:  static System.Int32 Rilisoft.Offers.丁且丕专万丈丒丏丗::丌下丑丆丛丌且下下(Rilisoft.OfferItem 丏丆丑丗七丄丙丝与, Rilisoft.OfferItem 丒丈丙丐丏丕丆万丗)));
            }
            
            val_32 = 1152921525530181280;
            if(this.不丙丙丕专不丞七上.Count >= 5)
            {
                goto label_6;
            }
            
            val_33 = 0;
            val_34 = 0;
            goto label_36;
            label_6:
            List.Enumerator<T> val_4 = this.不丙丙丕专不丞七上.GetEnumerator();
            label_11:
            if((451496496 & 1) == 0)
            {
                goto label_9;
            }
            
            if(val_6.丐丏七丌丕丗业且上().Type != 1000)
            {
                goto label_11;
            }
            
            List.Enumerator<T> val_9 = this.不丙丙丕专不丞七上.GetEnumerator();
            label_15:
            if((451496464 & 1) == 0)
            {
                goto label_13;
            }
            
            val_35 = val_6.丐丏七丌丕丗业且上();
            if(val_35.Type != 1000)
            {
                goto label_15;
            }
            
            val_36 = 0;
            val_33 = 0;
            goto label_18;
            label_9:
            val_34 = 0;
            val_33 = 0;
            val_37;
            goto label_17;
            label_13:
            val_36 = 0;
            val_33 = 0;
            val_35 = 0;
            label_18:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && (163 == 163))
            {
                    val_36 = 0;
            }
            else
            {
                    if( != 0)
            {
                    val_33 = 0;
            }
            
            }
            
            bool val_12 = this.不丙丙丕专不丞七上.Remove(item:  null);
            this.不丙丙丕专不丞七上.Insert(index:  3, item:  null);
            val_34 = 1;
            label_17:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(216 == 216)
            {
                    val_34 = val_34 - 1;
            }
            else
            {
                    if( != 0)
            {
                    val_33 = 0;
            }
            
            }
            
            label_36:
            val_40 = this.不丙丙丕专不丞七上;
            if(val_40.Count < 5)
            {
                    return;
            }
            
            val_40 = this.不丙丙丕专不丞七上;
            List.Enumerator<T> val_15 = val_40.GetEnumerator();
            val_32 = 1152921525755361760;
            label_42:
            if((451496496 & 1) == 0)
            {
                goto label_40;
            }
            
            if(val_17.丐丏七丌丕丗业且上().Type != 1010)
            {
                goto label_42;
            }
            
            List.Enumerator<T> val_20 = this.不丙丙丕专不丞七上.GetEnumerator();
            label_46:
            if((451496464 & 1) == 0)
            {
                goto label_44;
            }
            
            val_40 = val_17.丐丏七丌丕丗业且上();
            if(val_40.Type != 1010)
            {
                goto label_46;
            }
            
            goto label_47;
            label_44:
            val_40 = 0;
            label_47:
            val_41 = ((0 == 1) ? -1 : 0) + 1;
            mem2[0] = 343;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_41 != 1) && ((1152921543713048976 + ((0 == 0x1 ? -1 : 0 + 1)) << 2) == 343))
            {
                    var val_30 = 0;
                val_30 = val_30 ^ (val_41 >> 31);
                val_41 = val_41 + val_30;
            }
            else
            {
                    if( != 0)
            {
                    val_33 = 0;
            }
            
            }
            
            bool val_23 = this.不丙丙丕专不丞七上.Remove(item:  null);
            List.Enumerator<T> val_24 = this.不丙丙丕专不丞七上.GetEnumerator();
            label_60:
            if((451496464 & 1) == 0)
            {
                goto label_58;
            }
            
            val_43 = val_26.丐丏七丌丕丗业且上();
            if(val_43.Type != 1000)
            {
                goto label_60;
            }
            
            goto label_61;
            label_58:
            val_43 = 0;
            label_61:
            val_44 = val_41 + 1;
            mem2[0] = 428;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_44 == 1) || ((1152921543713048976 + (((0 == 0x1 ? -1 : 0 + 1) + 1)) << 2) != 428))
            {
                goto label_69;
            }
            
            var val_31 = 0;
            val_31 = val_31 ^ (val_44 >> 31);
            val_44 = val_44 + val_31;
            if( != 0)
            {
                goto label_70;
            }
            
            goto label_73;
            label_69:
            if( != 0)
            {
                    val_33 = 0;
            }
            
            if( == 0)
            {
                goto label_73;
            }
            
            label_70:
            val_32 = this.不丙丙丕专不丞七上;
            val_45 = (val_32.IndexOf(item:  null)) + 1;
            goto label_75;
            label_73:
            val_45 = 3;
            label_75:
            val_31 = this.不丙丙丕专不丞七上;
            val_31.Insert(index:  3, item:  null);
            label_40:
            val_46 = val_44 + 1;
            mem2[0] = 497;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_41 != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if((1152921543713048976 + ((0 == 0x1 ? -1 : 0 + 1)) << 2) == 497)
            {
                    return;
            }
            
                return;
            }
            
            if( != 0)
            {
                    return;
            }
        
        }
        private static void 丝丟丑下上下丌丆七(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌, System.Collections.Generic.IList<Rilisoft.OfferItem> 东丗东专下七丕丕丑)
        {
            var val_17;
            var val_18;
            var val_20;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_21;
            int val_23;
            Progress.OfferProgress val_1 = 丙业丞丑七丗下丟丌.业丑丁丆丕丆丂丅万();
            val_1.PreparedItemsForPlayerPayment = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丘七丒丕丏东丈与七();
            Progress.OfferProgress val_4 = 丙业丞丑七丗下丟丌.业丑丁丆丕丆丂丅万();
            System.Collections.Generic.List<Rilisoft.OfferItem> val_19 = val_4.PreparedItems;
            val_19 = val_19.Count - 1;
            if((val_19 & 2147483648) == 0)
            {
                    val_17 = 1152921504690978816;
                do
            {
                Progress.OfferProgress val_6 = 丙业丞丑七丗下丟丌.业丑丁丆丕丆丂丅万();
                val_18 = public Rilisoft.OfferItem System.Collections.Generic.List<Rilisoft.OfferItem>::get_Item(int index);
                var val_20 = 0;
                val_20 = val_20 + 1;
                val_18 = 4;
                val_20 = public System.Boolean System.Collections.Generic.ICollection<T>::Contains(T item);
                if((东丗东专下七丕丕丑.Contains(item:  ???)) != true)
            {
                    Progress.OfferProgress val_10 = 丙业丞丑七丗下丟丌.业丑丁丆丕丆丂丅万();
                val_21 = val_10.PreparedItems;
                val_20 = public System.Boolean System.Collections.Generic.List<Rilisoft.OfferItem>::Remove(Rilisoft.OfferItem item);
                bool val_11 = val_21.Remove(item:  val_6.PreparedItems.Item[val_19]);
            }
            
                val_19 = val_19 - 1;
            }
            while((val_19 & 2147483648) == 0);
            
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_20 = 0;
            val_23 = 东丗东专下七丕丕丑.Count - 1;
            if((val_23 & 2147483648) != 0)
            {
                    return;
            }
            
            val_17 = 1152921543231785664;
            do
            {
                var val_22 = 0;
                val_22 = val_22 + 1;
                val_20 = 0;
                T val_15 = 东丗东专下七丕丕丑.Item[val_23];
                Progress.OfferProgress val_16 = 丙业丞丑七丗下丟丌.业丑丁丆丕丆丂丅万();
                val_21 = val_16.PreparedItems;
                if((val_21.Contains(item:  val_15)) != true)
            {
                    Progress.OfferProgress val_18 = 丙业丞丑七丗下丟丌.业丑丁丆丕丆丂丅万();
                val_21 = val_18.PreparedItems;
                val_21.Add(item:  val_15);
            }
            
                val_23 = val_23 - 1;
            }
            while((val_23 & 2147483648) == 0);
        
        }
        private void 丞丘下上世一丝丏三(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌, Rilisoft.七丈业与与不七丈丟.世丕三丙七丆丁丂丒 上一丁丆七世业一且)
        {
            var val_7;
            var val_53;
            var val_103;
            System.Collections.Generic.List<东丛丏且丆丑丙丅丟> val_152;
            var val_154;
            var val_155;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_157;
            System.Collections.Generic.List<CategoryNames> val_158;
            string val_159;
            string val_160;
            bool val_161;
            var val_162;
            var val_164;
            var val_165;
            var val_167;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_169;
            var val_170;
            var val_171;
            var val_172;
            System.Collections.Generic.IEnumerable<TSource> val_173;
            System.Collections.Generic.IEnumerable<T> val_174;
            var val_175;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_177;
            var val_178;
            System.Func<Rilisoft.OfferItem, CategoryNames> val_180;
            var val_181;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_183;
            var val_184;
            var val_185;
            System.Func<Rilisoft.OfferItem, CategoryNames> val_187;
            var val_188;
            System.Func<Rilisoft.OfferItem, System.String> val_190;
            var val_191;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_193;
            var val_194;
            System.Func<Rilisoft.OfferItem, System.String> val_196;
            var val_198;
            var val_199;
            var val_200;
            System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_202;
            var val_203;
            System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_205;
            var val_206;
            if(上一丁丆七世业一且.丛一业丆下丒丏一丝 == null)
            {
                    return;
            }
            
            Progress.OfferProgress val_1 = mem[1152921543714089224].业丑丁丆丕丆丂丅万();
            val_154 = 1152921505501147136;
            val_155 = null;
            val_155 = null;
            val_157 = 丙专一丛丞丕七不丌.<>c.<>9__11_0;
            if(val_157 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.Boolean> val_2 = null;
                val_157 = val_2;
                val_2 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  丙专一丛丞丕七不丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丙专一丛丞丕七不丌.<>c::丙万丅丙丒下下丁丒(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                丙专一丛丞丕七不丌.<>c.<>9__11_0 = val_157;
            }
            
            if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_1.PreparedItems, predicate:  val_2)) == false)
            {
                goto label_10;
            }
            
            goto label_11;
            label_10:
            System.Collections.Generic.List<CategoryNames> val_4 = null;
            val_158 = val_4;
            val_4 = new System.Collections.Generic.List<CategoryNames>();
            val_152 = 上一丁丆七世业一且.丛一业丆下丒丏一丝;
            List.Enumerator<T> val_5 = val_152.GetEnumerator();
            val_159 = 1152921525755361760;
            val_160 = 1152921539096349248;
            val_161 = 0;
            val_162 = 0;
            label_42:
            if((452524416 & 1) == 0)
            {
                goto label_43;
            }
            
            string val_8 = val_7.丐丏七丌丕丗业且上();
            if((public 东丛丏且丆丑丙丅丟 List.Enumerator<东丛丏且丆丑丙丅丟>::get_Current()) != 0)
            {
                    val_164 = this.上丁专一丐东七丞丛(下丟与东七丂丐且七:  public 东丛丏且丆丑丙丅丟 List.Enumerator<东丛丏且丆丑丙丅丟>::get_Current(), 丌丒丝东丌下丕丁丅:  val_8.m_stringLength);
            }
            else
            {
                    val_164 = Rilisoft.Offers.丙专一丛丞丕七不丌.丕不丙丈上丏万与丌(丙业丞丑七丗下丟丌:  丙业丞丑七丗下丟丌, 丈下丑丆上丏丗丈专:  public 东丛丏且丆丑丙丅丟 List.Enumerator<东丛丏且丆丑丙丅丟>::get_Current(), 下丛丟下丅上丟丞丕:  val_8.m_stringLength, 万丝不且世丁丞不业:  val_4);
            }
            
            东丛丏且丆丑丙丅丟 val_11 = val_164.Current;
            label_26:
            if((452524384 & 1) == 0)
            {
                goto label_18;
            }
            
            string val_12 = val_7.丐丏七丌丕丗业且上();
            System.Nullable<CategoryNames> val_13 = val_12.Category;
            if((452524376 & 1) != 0)
            {
                    System.Nullable<CategoryNames> val_14 = val_12.Category;
                if((val_4.Contains(item:  val_14.HasValue)) != true)
            {
                    System.Nullable<CategoryNames> val_16 = val_12.Category;
                val_4.Add(item:  val_16.HasValue);
            }
            
            }
            
            bool val_17 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  val_12, 专丂丕丗丗东世丞下:  mem[1152921543714089232]);
            goto label_26;
            label_18:
            val_165 = val_162;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((1 == 1) || (265 != 265))
            {
                goto label_39;
            }
            
            goto label_42;
            label_39:
            if( == 0)
            {
                goto label_42;
            }
            
            goto label_42;
            label_43:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(2 != 1)
            {
                    if(2201 == 2201)
            {
                    return;
            }
            
            }
            
            val_154 = 1152921505501147136;
            label_11:
            Progress.OfferProgress val_18 = mem[1152921543714089224].业丑丁丆丕丆丂丅万();
            val_167 = null;
            val_169 = 丙专一丛丞丕七不丌.<>c.<>9__11_1;
            if(val_169 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.Boolean> val_19 = null;
                val_169 = val_19;
                val_19 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  丙专一丛丞丕七不丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丙专一丛丞丕七不丌.<>c::三业且丅丕下丗丕丒(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                丙专一丛丞丕七不丌.<>c.<>9__11_1 = val_169;
            }
            
            val_158 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Where<Rilisoft.OfferItem>(source:  val_18.PreparedItems, predicate:  val_19));
            int val_23 = val_158.Count - 1;
            if((val_23 & 2147483648) != 0)
            {
                goto label_60;
            }
            
            val_159 = 1152921504616005632;
            goto label_98;
            label_93:
            val_160 = WeaponManager.丐上业丐丏丐万世丑();
            if((val_160.Contains(item:  上一丁丆七世业一且.业且东丒丕丕丛专丛.Record.与不丞丑七丘丁丂丛())) == false)
            {
                goto label_85;
            }
            
            val_160 = 上一丁丆七世业一且.业且东丒丕丕丛专丛.Record;
            System.Collections.Generic.KeyValuePair<System.String, System.Int64> val_33 = WeaponManager.万一丛七丙丑丄丆丑();
            if((System.String.op_Equality(a:  val_33.Value.System.IConvertible.ToInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Int64>::get_Key()), b:  val_160.与不丞丑七丘丁丂丛())) != false)
            {
                    val_171 = 1;
            }
            else
            {
                    val_160 = val_160.与不丞丑七丘丁丂丛();
                val_170 = ((Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  val_160.与不丞丑七丘丁丂丛())) >= (BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  val_160.三与丛丑且丐丈业丌()))) ? 1 : 0;
                val_171 = WeaponManager.七世丂丁丆丙丐丆丌().Contains(item:  val_160);
            }
            
            val_171 = val_171 | val_170;
            if(val_171 == true)
            {
                goto label_88;
            }
            
            goto label_85;
            label_98:
            .丌丝下丄业一丄不三 = val_158.Item[val_23];
            if((System.Linq.Enumerable.Count<Rilisoft.OfferItem>(source:  val_158, predicate:  new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  new 丙专一丛丞丕七不丌.丗丛丘丑丐不丌丑丙(), method:  System.Boolean 丙专一丛丞丕七不丌.丗丛丘丑丐不丌丑丙::丅万丛丙丒下丐丟下(Rilisoft.OfferItem 与丘东下丈东丛丂万)))) < 2)
            {
                    if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  (丙专一丛丞丕七不丌.丗丛丘丑丐不丌丑丙)[1152921543714231792].丌丝下丄业一丄不三.Id)) == null)
            {
                goto label_93;
            }
            
            }
            
            label_88:
            Progress.OfferProgress val_48 = mem[1152921543714089224].业丑丁丆丕丆丂丅万();
            val_160 = (丙专一丛丞丕七不丌.丗丛丘丑丐不丌丑丙)[1152921543714231792].丌丝下丄业一丄不三;
            bool val_49 = val_48.PreparedItems.Remove(item:  val_160);
            bool val_50 = val_158.Remove(item:  (丙专一丛丞丕七不丌.丗丛丘丑丐不丌丑丙)[1152921543714231792].丌丝下丄业一丄不三);
            label_85:
            val_23 = val_23 - 1;
            if((val_23 & 2147483648) == 0)
            {
                goto label_98;
            }
            
            label_60:
            List.Enumerator<T> val_51 = 上一丁丆七世业一且 + 168.GetEnumerator();
            val_161 = 0;
            goto label_266;
            label_276:
            val_160 = new 丙专一丛丞丕七不丌.世世丝丏丙丞丙丏丁();
            val_160 = new 丙专一丛丞丕七不丌.世世丝丏丙丞丙丏丁();
            string val_55 = val_53.丐丏七丌丕丗业且上();
            if(val_160 != null)
            {
                    val_172 = val_160;
                .东东世专不万丁丌丈 = val_55;
            }
            else
            {
                    mem[16] = val_55;
                val_172 = 16;
            }
            
            if((val_55 + 24) == 0)
            {
                goto label_105;
            }
            
            System.Func<Rilisoft.OfferItem, System.Boolean> val_56 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  new 丙专一丛丞丕七不丌.世世丝丏丙丞丙丏丁(), method:  System.Boolean 丙专一丛丞丕七不丌.世世丝丏丙丞丙丏丁::丁上丈丙与与丁丆丐(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
            val_159 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Where<Rilisoft.OfferItem>(source:  val_158, predicate:  null));
            val_173 = val_159;
            if(val_160 != null)
            {
                goto label_108;
            }
            
            goto label_107;
            label_105:
            val_159 = 0;
            val_173 = 0;
            if(val_160 != null)
            {
                goto label_108;
            }
            
            label_107:
            label_108:
            if((val_55 + 24) == 0)
            {
                goto label_110;
            }
            
            val_174 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Except<Rilisoft.OfferItem>(first:  val_158, second:  val_173));
            if(val_160 != null)
            {
                goto label_119;
            }
            
            goto label_112;
            label_110:
            val_174 = 丞东丑专丛丆丄丝世.三东丕七专丒不丌东<Rilisoft.OfferItem>(丝丘丑业丛万丞丌丝:  val_158, 丞世不丒下上上丝丑:  0, 丌丒丝东丌下丕丁丅:  val_55 + 16);
            var val_150 = 0;
            val_150 = (val_55 + 16) + val_150;
            if(val_160 != null)
            {
                goto label_119;
            }
            
            label_112:
            label_119:
            if((val_55 + 24) == 0)
            {
                goto label_121;
            }
            
            mem[1152921543714089232].AddRange(collection:  val_173);
            if(val_159.Count == (val_55 + 16))
            {
                goto label_266;
            }
            
            if(val_159.Count >= (val_55 + 16))
            {
                goto label_130;
            }
            
            System.Func<System.String, System.Boolean> val_64 = new System.Func<System.String, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.Offers.丙专一丛丞丕七不丌::丗丝上丙业丛不世丄(string 丞丅上丏丂且下丅与));
            System.Collections.Generic.List<TSource> val_66 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Where<System.String>(source:  val_55 + 32, predicate:  null));
            List.Enumerator<T> val_70 = this.上丁专一丐东七丞丛(下丟与东七丂丐且七:  val_66, 丌丒丝东丌下丕丁丅:  (val_55 + 16) - val_159.Count).GetEnumerator();
            label_138:
            if((452524384 & 1) == 0)
            {
                goto label_212;
            }
            
            bool val_72 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  val_53.丐丏七丌丕丗业且上(), 专丂丕丗丗东世丞下:  mem[1152921543714089232]);
            goto label_138;
            label_121:
            mem[1152921543714089232].AddRange(collection:  val_174);
            if(val_174.Count == (val_55 + 16))
            {
                goto label_266;
            }
            
            if(val_174.Count >= (val_55 + 16))
            {
                goto label_147;
            }
            
            val_175 = null;
            val_175 = null;
            val_177 = 丙专一丛丞丕七不丌.<>c.<>9__11_6;
            if(val_177 == null)
            {
                    val_177 = null;
                val_177 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  丙专一丛丞丕七不丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丙专一丛丞丕七不丌.<>c::专且不且丌东业与丙(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                丙专一丛丞丕七不丌.<>c.<>9__11_6 = val_177;
            }
            
            val_178 = null;
            val_178 = null;
            val_180 = 丙专一丛丞丕七不丌.<>c.<>9__11_7;
            if(val_180 == null)
            {
                    val_180 = null;
                val_180 = new System.Func<Rilisoft.OfferItem, CategoryNames>(object:  丙专一丛丞丕七不丌.<>c.__il2cppRuntimeField_static_fields, method:  CategoryNames 丙专一丛丞丕七不丌.<>c::三东丑丝丝上丆世丏(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                丙专一丛丞丕七不丌.<>c.<>9__11_7 = val_180;
            }
            
            val_181 = null;
            val_181 = null;
            val_183 = 丙专一丛丞丕七不丌.<>c.<>9__11_8;
            if(val_183 == null)
            {
                    val_183 = null;
                val_183 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  丙专一丛丞丕七不丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丙专一丛丞丕七不丌.<>c::业三万丆丅丙七专丕(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                val_184 = 1152921505501147136;
                丙专一丛丞丕七不丌.<>c.<>9__11_8 = val_183;
            }
            
            val_185 = null;
            val_185 = null;
            val_187 = 丙专一丛丞丕七不丌.<>c.<>9__11_9;
            if(val_187 == null)
            {
                    val_187 = null;
                val_187 = new System.Func<Rilisoft.OfferItem, CategoryNames>(object:  丙专一丛丞丕七不丌.<>c.__il2cppRuntimeField_static_fields, method:  CategoryNames 丙专一丛丞丕七不丌.<>c::丄与东丁丘丗丂丆丒(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                val_184 = 1152921505501147136;
                丙专一丛丞丕七不丌.<>c.<>9__11_9 = val_187;
            }
            
            val_188 = null;
            val_190 = 丙专一丛丞丕七不丌.<>c.<>9__11_10;
            if(val_190 == null)
            {
                    val_190 = null;
                val_190 = new System.Func<Rilisoft.OfferItem, System.String>(object:  丙专一丛丞丕七不丌.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丙专一丛丞丕七不丌.<>c::万丐丕丘丂丘丝万丅(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                val_184 = 1152921505501147136;
                丙专一丛丞丕七不丌.<>c.<>9__11_10 = val_190;
            }
            
            val_191 = null;
            val_193 = 丙专一丛丞丕七不丌.<>c.<>9__11_11;
            if(val_193 == null)
            {
                    val_193 = null;
                val_193 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  丙专一丛丞丕七不丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丙专一丛丞丕七不丌.<>c::三丅丆丏万丐丛丙丈(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                val_184 = 1152921505501147136;
                丙专一丛丞丕七不丌.<>c.<>9__11_11 = val_193;
            }
            
            val_194 = null;
            val_196 = 丙专一丛丞丕七不丌.<>c.<>9__11_12;
            if(val_196 == null)
            {
                    val_196 = null;
                val_196 = new System.Func<Rilisoft.OfferItem, System.String>(object:  丙专一丛丞丕七不丌.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丙专一丛丞丕七不丌.<>c::丗丞东丂丘丐丛丅三(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                val_184 = 1152921505501147136;
                丙专一丛丞丕七不丌.<>c.<>9__11_12 = val_196;
            }
            
            val_53 = 0;
            System.Collections.Generic.List<TSource> val_99 = System.Linq.Enumerable.ToList<三丅丁丗丗丝丂万且>(source:  WeaponManager.三丏丏丄专丅世丞不(丈下丑丆上丏丗丈专:  new System.Nullable<ItemRarity>() {HasValue = false}, 丈专且丄丈丞丙丘三:  System.Linq.Enumerable.ToArray<CategoryNames>(source:  System.Linq.Enumerable.Except<CategoryNames>(first:  WeaponManager.万三不丄丈丙与丁不(), second:  System.Linq.Enumerable.ToArray<CategoryNames>(source:  System.Linq.Enumerable.Distinct<CategoryNames>(source:  System.Linq.Enumerable.Concat<CategoryNames>(first:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, CategoryNames>(source:  System.Linq.Enumerable.Where<Rilisoft.OfferItem>(source:  val_174, predicate:  null), selector:  null), second:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, CategoryNames>(source:  System.Linq.Enumerable.Where<Rilisoft.OfferItem>(source:  mem[1152921543714089232], predicate:  null), selector:  null)))))), 且上下丌一下且丑丟:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Concat<System.String>(first:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, System.String>(source:  val_174, selector:  null), second:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, System.String>(source:  System.Linq.Enumerable.Where<Rilisoft.OfferItem>(source:  mem[1152921543714089232], predicate:  null), selector:  null))), 丒万丂七不丏丙万丝:  false, 丄七丛丛丛下三业丛:  false));
            System.Comparison<三丅丁丗丗丝丂万且> val_100 = new System.Comparison<三丅丁丗丗丝丂万且>(object:  0, method:  static System.Int32 Rilisoft.Offers.丁且丕专万丈丒丏丗::上万万丑业丌丌丅丝(三丅丁丗丗丝丂万且 丏丆丑丗七丄丙丝与, 三丅丁丗丗丝丂万且 丒丈丙丐丏丕丆万丗));
            val_99.Sort(comparison:  null);
            List.Enumerator<T> val_101 = val_99.GetEnumerator();
            val_159 = 1152921525519449728;
            var val_151 = 0;
            do
            {
                if((452524336 & 1) == 0)
            {
                goto label_199;
            }
            
                bool val_108 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  10, 丞丅上丏丂且下丅与:  val_103.丐丏七丌丕丗业且上().与不丞丑七丘丁丂丛(), 丌丒丝东丌下丕丁丅:  1), 专丂丕丗丗东世丞下:  mem[1152921543714089232]);
                val_151 = val_151 + 1;
            }
            while(val_151 < ((val_55 + 16) - val_174.Count));
            
            goto label_199;
            label_147:
            if(val_174.Count <= (val_55 + 16))
            {
                goto label_266;
            }
            
            var val_153 = 0;
            var val_154 = 0;
            label_211:
            val_159 = mem[16];
            var val_152 = val_55 + 16;
            val_152 = val_174.Count - val_152;
            if(val_153 >= val_152)
            {
                goto label_271;
            }
            
            val_153 = val_153 + 1;
            val_154 = val_154 - 1;
            bool val_114 = mem[1152921543714089232].Remove(item:  val_174.Item[val_154 + val_174.Count]);
            goto label_211;
            label_199:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((4 == 1) || (2173 != 1715))
            {
                goto label_218;
            }
            
            val_198 = ;
            if(val_66 != null)
            {
                goto label_222;
            }
            
            goto label_220;
            label_218:
            val_161 = 0;
            val_198 = 0;
            if(val_66 != null)
            {
                goto label_222;
            }
            
            label_220:
            label_222:
            if(val_66.Count >= val_172)
            {
                goto label_266;
            }
            
            OfferModule val_116 = 丙业丞丑七丗下丟丌.丑且一丐东三不丈丝();
            val_53 = 0;
            val_159 = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Int32>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "cc");
            if(val_159 < 1)
            {
                goto label_227;
            }
            
            val_199 = null;
            val_199 = null;
            bool val_119 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  242, 丞丅上丏丂且下丅与:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 丌丒丝东丌下丕丁丅:  val_159), 专丂丕丗丗东世丞下:  mem[1152921543714089232]);
            goto label_266;
            label_227:
            val_159 = new 丙专一丛丞丕七不丌.丒丂丈东丗丁丁上且();
            val_159 = new 丙专一丛丞丕七不丌.丒丂丈东丗丁丁上且();
            .东丟且丗且三专丙丁 = val_160;
            .丙丂丏丛丌丏下丝不 = ExperienceController.丞丞丘业东丙丏七丌();
            System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_123 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  new 丙专一丛丞丕七不丌.丒丂丈东丗丁丁上且(), method:  System.Boolean 丙专一丛丞丕七不丌.丒丂丈东丗丁丁上且::丕下下丅丅丙丟丝丝(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业));
            val_200 = null;
            val_202 = 丙专一丛丞丕七不丌.<>c.<>9__11_14;
            if(val_202 == null)
            {
                    val_202 = null;
                val_202 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  丙专一丛丞丕七不丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丙专一丛丞丕七不丌.<>c::丕丆丙丘丗丆七丛东(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业));
                val_184 = 1152921505501147136;
                丙专一丛丞丕七不丌.<>c.<>9__11_14 = val_202;
            }
            
            val_203 = null;
            val_205 = 丙专一丛丞丕七不丌.<>c.<>9__11_15;
            if(val_205 == null)
            {
                    val_205 = null;
                val_205 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  丙专一丛丞丕七不丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丙专一丛丞丕七不丌.<>c::丒丄下世一丒丑与一(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业));
                丙专一丛丞丕七不丌.<>c.<>9__11_15 = val_205;
            }
            
            System.Collections.Generic.List<TSource> val_129 = System.Linq.Enumerable.ToList<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  丏丄丑上丛不丈且万.丐丙丛丒世三业丏丙(), predicate:  null), predicate:  null), predicate:  null));
            上丑三丁丄丛丁万丑.丗丒丒丗丗丛丈丒丒(丏东上丟与丙一万一:  val_129);
            val_160 = System.Linq.Enumerable.FirstOrDefault<三丅丁丗丗丝丂万且>(source:  val_129);
            if(val_160 == null)
            {
                goto label_266;
            }
            
            string val_133 = val_160.与不丞丑七丘丁丂丛();
            val_160 = val_133.丏一丙东东丐丐丏丑(不三丙万与丗丌七丈:  (丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_160.与不丞丑七丘丁丂丛())) - 1, 丞丅上丏丂且下丅与:  val_133);
            if(val_160 == null)
            {
                goto label_266;
            }
            
            val_206 = null;
            val_206 = null;
            Rilisoft.OfferItemType val_138 = ((System.String.op_Equality(a:  val_160.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != true) ? 1000 : 1010;
            int val_140 = val_172 - val_66.Count;
            if(val_140 < 1)
            {
                goto label_266;
            }
            
            var val_155 = 0;
            do
            {
                bool val_144 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  val_138, 丞丅上丏丂且下丅与:  val_160.东与三丌丅三丒丏业(), 丌丒丝东丌下丕丁丅:  val_160.丟丂丞不专丆万丒世()), 专丂丕丗丗东世丞下:  mem[1152921543714089232]);
                val_155 = val_155 + 1;
            }
            while(val_155 < val_140);
            
            goto label_271;
            label_212:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((4 == 1) || (2173 != 2173))
            {
                goto label_265;
            }
            
            goto label_266;
            label_265:
            val_161 = 0;
            label_130:
            var val_157 = 0;
            var val_158 = 0;
            label_275:
            var val_156 = val_55 + 16;
            val_156 = val_138.Count - val_156;
            if(val_157 >= val_156)
            {
                goto label_271;
            }
            
            val_157 = val_157 + 1;
            val_158 = val_158 - 1;
            bool val_149 = mem[1152921543714089232].Remove(item:  val_138.Item[val_158 + val_138.Count]);
            goto label_275;
            label_271:
            label_266:
            if((452524416 & 1) != 0)
            {
                goto label_276;
            }
            
            val_152 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(5 != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if(2201 == 2201)
            {
                    return;
            }
            
                return;
            }
            
            if( != 0)
            {
                    return;
            }
        
        }
        private System.Collections.Generic.List<Rilisoft.OfferItem> 上丁专一丐东七丞丛(System.Collections.Generic.IEnumerable<string> 下丟与东七丂丐且七, int 丌丒丝东丌下丕丁丅)
        {
            var val_33;
            var val_34;
            var val_36;
            Rilisoft.OfferItem val_37;
            string val_40;
            var val_41;
            var val_46;
            var val_48;
            var val_49;
            var val_50;
            string val_51;
            int val_52;
            val_34 = 0;
            if(下丟与东七丂丐且七 == null)
            {
                    return (System.Collections.Generic.List<Rilisoft.OfferItem>)val_34;
            }
            
            if(丌丒丝东丌下丕丁丅 < 1)
            {
                    return (System.Collections.Generic.List<Rilisoft.OfferItem>)val_34;
            }
            
            System.Collections.Generic.List<Rilisoft.OfferItem> val_1 = null;
            val_34 = val_1;
            val_1 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            var val_39 = 0;
            val_39 = val_39 + 1;
            val_33 = 1152921504686346240;
            val_36 = 1152921505317388288;
            val_37 = 下丟与东七丂丐且七.GetEnumerator();
            label_33:
            var val_40 = 0;
            val_40 = val_40 + 1;
            if(val_37.MoveNext() == false)
            {
                goto label_19;
            }
            
            var val_41 = 0;
            val_41 = val_41 + 1;
            T val_7 = val_37.Current;
            if(val_1.Count >= 丌丒丝东丌下丕丁丅)
            {
                goto label_19;
            }
            
            三丅丁丗丗丝丂万且 val_9 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_7);
            if(((val_9 == null) || (val_9 > ExperienceController.丞丞丘业东丙丏七丌())) || ((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_9.业东丅东丌上丗丑不())) != null))
            {
                goto label_33;
            }
            
            val_1.Add(item:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  10, 丞丅上丏丂且下丅与:  val_7, 丌丒丝东丌下丕丁丅:  1));
            goto label_33;
            label_19:
            val_40 = 0;
            val_41 = 0;
            if(val_37 == null)
            {
                
            }
            else
            {
                    var val_42 = 0;
                val_42 = val_42 + 1;
                val_37.Dispose();
            }
            
            if(( == 1) || (125 != 125))
            {
                goto label_53;
            }
            
            val_40 = 0;
            if(val_34 != null)
            {
                goto label_57;
            }
            
            goto label_55;
            label_53:
            if( != false)
            {
                    val_41 = 0;
            }
            
            if(val_34 != null)
            {
                goto label_57;
            }
            
            label_55:
            label_57:
            if(val_1.Count >= 丌丒丝东丌下丕丁丅)
            {
                    return (System.Collections.Generic.List<Rilisoft.OfferItem>)val_34;
            }
            
            var val_43 = 0;
            val_43 = val_43 + 1;
            val_37 = 下丟与东七丂丐且七.GetEnumerator();
            label_76:
            var val_44 = 0;
            val_44 = val_44 + 1;
            if(val_37.MoveNext() == false)
            {
                goto label_68;
            }
            
            var val_45 = 0;
            val_45 = val_45 + 1;
            val_46 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_37.Current);
            if(val_46 == null)
            {
                goto label_76;
            }
            
            goto label_77;
            label_68:
            val_46 = 0;
            label_77:
            val_40 = 0 + 1;
            mem2[0] = 188;
            if(val_37 == null)
            {
                
            }
            else
            {
                    var val_46 = 0;
                val_46 = val_46 + 1;
                val_37.Dispose();
            }
            
            if(val_40 == 1)
            {
                goto label_88;
            }
            
            if(( == false) || ((1152921543714787216 + ((0 + 1)) << 2) == 188))
            {
                goto label_113;
            }
            
            label_112:
            label_113:
            if( == 0)
            {
                    return (System.Collections.Generic.List<Rilisoft.OfferItem>)val_34;
            }
            
            if(val_46.且丅万下业下三丛与() == null)
            {
                    return (System.Collections.Generic.List<Rilisoft.OfferItem>)val_34;
            }
            
            val_33 = 1152921536336223456;
            val_48 = 0;
            goto label_93;
            label_111:
            val_49 = null;
            val_49 = null;
            bool val_28 = System.String.op_Equality(a:  val_46.且丅万下业下三丛与().东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
            OfferModule val_30 = mem[1152921543714799368].丑且一丐东三不丈丝();
            if(val_28 != false)
            {
                    val_50 = 0;
                val_51 = "cg";
            }
            else
            {
                    val_50 = 0;
                val_51 = "cc";
            }
            
            val_52 = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Int32>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  val_51);
            if(val_52 <= 0)
            {
                    val_52 = val_46.且丅万下业下三丛与().丟丂丞不专丆万丒世();
            }
            
            val_40 = val_46.且丅万下业下三丛与().东与三丌丅三丒丏业();
            val_37 = Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  (val_28 != true) ? 1000 : 1010, 丞丅上丏丂且下丅与:  val_40, 丌丒丝东丌下丕丁丅:  val_52);
            val_1.Add(item:  val_37);
            val_48 = 1;
            label_93:
            if(val_48 < (丌丒丝东丌下丕丁丅 - val_1.Count))
            {
                goto label_111;
            }
            
            return (System.Collections.Generic.List<Rilisoft.OfferItem>)val_34;
            label_88:
            if( == true)
            {
                goto label_112;
            }
            
            goto label_113;
        }
        private static System.Collections.Generic.List<Rilisoft.OfferItem> 丕不丙丈上丏万与丌(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌, ItemRarity 丈下丑丆上丏丗丈专, int 下丛丟下丅上丟丞丕, System.Collections.Generic.List<CategoryNames> 万丝不且世丁丞不业)
        {
            System.Collections.Generic.IEnumerable<TSource> val_71;
            Rilisoft.OfferItem val_72;
            var val_73;
            var val_74;
            System.Func<三丅丁丗丗丝丂万且, System.Int32> val_76;
            System.Collections.Generic.List<T> val_78;
            int val_79;
            var val_80;
            var val_81;
            var val_82;
            System.Func<三丅丁丗丗丝丂万且, CategoryNames> val_84;
            var val_85;
            System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_87;
            var val_88;
            System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_90;
            var val_91;
            int val_92;
            var val_93;
            var val_94;
            System.Collections.Generic.List<T> val_95;
            int val_96;
            var val_97;
            丙专一丛丞丕七不丌.世东丒与丞七不不东 val_1 = new 丙专一丛丞丕七不丌.世东丒与丞七不不东();
            .丈下丑丆上丏丗丈专 = 丈下丑丆上丏丗丈专;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_2 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            val_71 = System.Linq.Enumerable.Except<CategoryNames>(first:  WeaponManager.万三不丄丈丙与丁不(), second:  万丝不且世丁丞不业);
            Progress.CommonProgress val_6 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丂丂丐七丕丐且丌丅();
            if(val_6.LastBougthWeaponCategories != null)
            {
                    Progress.CommonProgress val_8 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丂丂丐七丕丐且丌丅();
                val_71 = System.Linq.Enumerable.Except<CategoryNames>(first:  val_71, second:  val_8.LastBougthWeaponCategories);
            }
            
            System.Collections.Generic.List<TSource> val_10 = System.Linq.Enumerable.ToList<CategoryNames>(source:  val_71);
            System.Collections.Generic.Dictionary<CategoryNames, 三丅丁丗丗丝丂万且> val_11 = null;
            val_72 = val_11;
            val_11 = new System.Collections.Generic.Dictionary<CategoryNames, 三丅丁丗丗丝丂万且>();
            val_73 = 0;
            goto label_13;
            label_30:
            System.Collections.Generic.List<CategoryNames> val_12 = new System.Collections.Generic.List<CategoryNames>();
            val_12.Add(item:  val_10.Item[0]);
            System.Collections.Generic.IEnumerable<三丅丁丗丗丝丂万且> val_14 = WeaponManager.三丏丏丄专丅世丞不(丈下丑丆上丏丗丈专:  new System.Nullable<ItemRarity>() {HasValue = false}, 丈专且丄丈丞丙丘三:  val_12, 且上下丌一下且丑丟:  0, 丒万丂七不丏丙万丝:  true, 丄七丛丛丛下三业丛:  true);
            if((val_14 != null) && ((System.Linq.Enumerable.Any<三丅丁丗丗丝丂万且>(source:  val_14)) != false))
            {
                    System.Collections.Generic.List<TSource> val_16 = System.Linq.Enumerable.ToList<三丅丁丗丗丝丂万且>(source:  val_14);
                val_16.Sort(comparison:  new System.Comparison<三丅丁丗丗丝丂万且>(object:  0, method:  static System.Int32 Rilisoft.Offers.丁且丕专万丈丒丏丗::三万丕丗丌丗丗七丄(三丅丁丗丗丝丂万且 丏丆丑丗七丄丙丝与, 三丅丁丗丗丝丂万且 丒丈丙丐丏丕丆万丗)));
                val_74 = null;
                val_74 = null;
                val_76 = 丙专一丛丞丕七不丌.<>c.<>9__13_0;
                if(val_76 == null)
            {
                    System.Func<三丅丁丗丗丝丂万且, System.Int32> val_18 = null;
                val_76 = val_18;
                val_18 = new System.Func<三丅丁丗丗丝丂万且, System.Int32>(object:  丙专一丛丞丕七不丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丙专一丛丞丕七不丌.<>c::上万三万丘丕东丑东(三丅丁丗丗丝丂万且 业七丐世专丝丂丟丈));
                丙专一丛丞丕七不丌.<>c.<>9__13_0 = val_76;
            }
            
                System.Collections.Generic.List<TSource> val_20 = System.Linq.Enumerable.ToList<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.OrderByDescending<三丅丁丗丗丝丂万且, System.Int32>(source:  val_16, keySelector:  val_18));
                val_11.Add(key:  val_10.Item[0], value:  val_16.Item[0]);
            }
            
            val_73 = 1;
            label_13:
            if(val_73 < val_10.Count)
            {
                goto label_30;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_24 = val_11.GetEnumerator();
            val_78 = val_2;
            val_79 = 下丛丟下丅上丟丞丕;
            val_80 = 0;
            goto label_32;
            label_38:
            ConfiguredValueTaskAwaiter val_27 = 0.GetAwaiter();
            if(val_80 >= val_79)
            {
                goto label_33;
            }
            
            val_72 = Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  10, 丞丅上丏丂且下丅与:  val_27._value._obj.与不丞丑七丘丁丂丛(), 丌丒丝东丌下丕丁丅:  1);
            val_2.Add(item:  val_72);
            val_80 = 1;
            label_32:
            if((453738880 & 1) != 0)
            {
                goto label_38;
            }
            
            label_33:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_2.Count >= val_79)
            {
                    return (System.Collections.Generic.List<Rilisoft.OfferItem>);
            }
            
            丙专一丛丞丕七不丌.不丞丛丑万丗丏丄丟 val_31 = new 丙专一丛丞丕七不丌.不丞丛丑万丗丏丄丟();
            if(val_31 != null)
            {
                    val_81 = val_31;
                .东丟且丗且三专丙丁 = val_1;
            }
            else
            {
                    val_81 = 24;
                mem[24] = val_1;
            }
            
            val_82 = null;
            val_82 = null;
            val_84 = 丙专一丛丞丕七不丌.<>c.<>9__13_1;
            if(val_84 == null)
            {
                    System.Func<三丅丁丗丗丝丂万且, CategoryNames> val_33 = null;
                val_84 = val_33;
                val_33 = new System.Func<三丅丁丗丗丝丂万且, CategoryNames>(object:  丙专一丛丞丕七不丌.<>c.__il2cppRuntimeField_static_fields, method:  CategoryNames 丙专一丛丞丕七不丌.<>c::丕一专丛丗丗丞丑丟(三丅丁丗丗丝丂万且 业七丐世专丝丂丟丈));
                丙专一丛丞丕七不丌.<>c.<>9__13_1 = val_84;
            }
            
            val_72 = System.Linq.Enumerable.ToList<CategoryNames>(source:  System.Linq.Enumerable.Except<CategoryNames>(first:  WeaponManager.万三不丄丈丙与丁不(), second:  System.Linq.Enumerable.ToList<CategoryNames>(source:  System.Linq.Enumerable.Select<三丅丁丗丗丝丂万且, CategoryNames>(source:  WeaponManager.三丏丏丄专丅世丞不(丈下丑丆上丏丗丈专:  new System.Nullable<ItemRarity>() {HasValue = false}, 丈专且丄丈丞丙丘三:  0, 且上下丌一下且丑丟:  0, 丒万丂七不丏丙万丝:  true, 丄七丛丛丛下三业丛:  false), selector:  val_33))));
            .丙丂丏丛丌丏下丝不 = ExperienceController.丞丞丘业东丙丏七丌();
            val_80 = 1152921504616005632;
            val_85 = null;
            val_85 = null;
            val_87 = 丙专一丛丞丕七不丌.<>c.<>9__13_3;
            if(val_87 == null)
            {
                    System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_43 = null;
                val_87 = val_43;
                val_43 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  丙专一丛丞丕七不丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丙专一丛丞丕七不丌.<>c::业丛世丞丐丐丞丟丞(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业));
                丙专一丛丞丕七不丌.<>c.<>9__13_3 = val_87;
            }
            
            val_88 = null;
            val_88 = null;
            val_90 = 丙专一丛丞丕七不丌.<>c.<>9__13_4;
            if(val_90 == null)
            {
                    System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_45 = null;
                val_90 = val_45;
                val_45 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  丙专一丛丞丕七不丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丙专一丛丞丕七不丌.<>c::丛一业且丌东丝丐丈(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业));
                丙专一丛丞丕七不丌.<>c.<>9__13_4 = val_90;
            }
            
            System.Collections.Generic.List<TSource> val_47 = System.Linq.Enumerable.ToList<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  丏丄丑上丛不丈且万.丐丙丛丒世三业丏丙(), predicate:  new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  val_31, method:  System.Boolean 丙专一丛丞丕七不丌.不丞丛丑万丗丏丄丟::上丅世丆丘丌丏丈业(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业))), predicate:  val_43), predicate:  val_45));
            上丑三丁丄丛丁万丑.丗丒丒丗丗丛丈丒丒(丏东上丟与丙一万一:  val_47);
            List.Enumerator<T> val_48 = val_72.GetEnumerator();
            val_79 = 1152921505171275776;
            label_112:
            if((453738832 & 1) == 0)
            {
                goto label_78;
            }
            
            new 丙专一丛丞丕七不丌.丑万不丙丟不丘且丁() = new 丙专一丛丞丕七不丌.丑万不丙丟不丘且丁();
            .丙丑丕丂下丏一丁专 = 0.丙东专丂世丈丏丁丂();
            System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_51 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  new 丙专一丛丞丕七不丌.丑万不丙丟不丘且丁(), method:  System.Boolean 丙专一丛丞丕七不丌.丑万不丙丟不丘且丁::丈丞丐丆丌丗丞且上(三丅丁丗丗丝丂万且 业七丐世专丝丂丟丈));
            val_72 = System.Linq.Enumerable.FirstOrDefault<三丅丁丗丗丝丂万且>(source:  val_47, predicate:  null);
            if(val_72 != null)
            {
                goto label_80;
            }
            
            val_72 = System.Linq.Enumerable.FirstOrDefault<三丅丁丗丗丝丂万且>(source:  val_47);
            if(val_72 == null)
            {
                goto label_112;
            }
            
            label_80:
            val_91 = null;
            val_91 = null;
            if((System.String.op_Equality(a:  val_72.且丅万下业下三丛与().东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
            {
                goto label_85;
            }
            
            OfferModule val_57 = 丙业丞丑七丗下丟丌.丑且一丐东三不丈丝();
            val_92 = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Int32>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "cg");
            if(val_92 <= 0)
            {
                    val_92 = val_72.且丅万下业下三丛与().丟丂丞不专丆万丒世();
            }
            
            val_93 = null;
            val_93 = null;
            val_72 = Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  232, 丞丅上丏丂且下丅与:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丌丒丝东丌下丕丁丅:  val_92);
            goto label_95;
            label_85:
            val_94 = null;
            val_94 = null;
            val_95 = val_2;
            if((System.String.op_Equality(a:  val_72.且丅万下业下三丛与().东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
            {
                goto label_109;
            }
            
            OfferModule val_65 = 丙业丞丑七丗下丟丌.丑且一丐东三不丈丝();
            val_96 = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Int32>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "cc");
            if(val_96 <= 0)
            {
                    val_96 = val_72.且丅万下业下三丛与().丟丂丞不专丆万丒世();
            }
            
            val_97 = null;
            val_97 = null;
            val_72 = Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  242, 丞丅上丏丂且下丅与:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 丌丒丝东丌下丕丁丅:  val_96);
            label_95:
            val_95 = val_2;
            if(val_72 != null)
            {
                    val_2.Add(item:  val_72);
            }
            
            label_109:
            if(val_2.Count != 下丛丟下丅上丟丞丕)
            {
                goto label_112;
            }
            
            label_78:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_78 = val_2;
            return (System.Collections.Generic.List<Rilisoft.OfferItem>);
        }
        private Rilisoft.OfferItem 不三丗东一专世丐丌()
        {
            return 0;
        }
        private void 一七上丞丟丗丛丑丕(CategoryNames 业丈世与下丘丛丐且, Rilisoft.OfferItemType 下丗丁丒丘东丂不丑, int 丞世丘丗丝专下下七, System.Collections.Generic.ICollection<Rilisoft.OfferItem> 与万丁丈与且丁三丁, string[] 七丑上丄丞业丝丄丞)
        {
            var val_8;
            var val_50;
            System.Collections.Generic.IList<T> val_51;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_52;
            var val_53;
            var val_54;
            System.Func<TSource, System.Boolean> val_55;
            var val_56;
            int val_57;
            var val_58;
            string val_59;
            var val_60;
            var val_61;
            var val_62;
            int val_63;
            var val_64;
            丙专一丛丞丕七不丌.丕丛业丁丏下一七丘 val_1 = new 丙专一丛丞丕七不丌.丕丛业丁丏下一七丘();
            .下丗丁丒丘东丂不丑 = 下丗丁丒丘东丂不丑;
            Progress.OfferProgress val_2 = this.且七丞丅不七丙丌与.业丑丁丆丕丆丂丅万();
            List.Enumerator<T> val_6 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Where<Rilisoft.OfferItem>(source:  val_2.PreparedItems, predicate:  new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  val_1, method:  System.Boolean 丙专一丛丞丕七不丌.丕丛业丁丏下一七丘::一七丗下七万丅丁上(Rilisoft.OfferItem 七丞丙丒三丕且丌丟)))).GetEnumerator();
            val_50 = 1152921525755361760;
            val_51 = 1152921516734113248;
            label_25:
            if((454442144 & 1) == 0)
            {
                goto label_5;
            }
            
            string val_9 = val_8.丐丏七丌丕丗业且上();
            if(val_9 != null)
            {
                    if((七丌丞万七万丁丐丙.与不专丅三丈丄丈上(七丆丒与丗丌丄且丂:  业丈世与下丘丛丐且).Contains(item:  val_9.Id)) != true)
            {
                    if((PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().丅世丘业丙丞丆丕丞(下丅丙一丂丗丅丝七:  val_9.Id)) == false)
            {
                goto label_12;
            }
            
            }
            
            }
            
            Progress.OfferProgress val_16 = this.且七丞丅不七丙丌与.业丑丁丆丕丆丂丅万();
            bool val_17 = val_16.PreparedItems.Remove(item:  val_9);
            goto label_25;
            label_12:
            val_52 = (丙专一丛丞丕七不丌.丕丛业丁丏下一七丘)[1152921543716088064].丙丕丗万丑丗丈丟专;
            if(val_52 == null)
            {
                    val_52 = null;
                val_52 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  val_1, method:  System.Boolean 丙专一丛丞丕七不丌.丕丛业丁丏下一七丘::丝专丄上不丞下丑丏(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                .丙丕丗万丑丗丈丟专 = val_52;
            }
            
            val_53 = public static System.Int32 System.Linq.Enumerable::Count<Rilisoft.OfferItem>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, bool> predicate);
            if((System.Linq.Enumerable.Count<Rilisoft.OfferItem>(source:  与万丁丈与且丁三丁, predicate:  null)) >= 丞世丘丗丝专下下七)
            {
                goto label_25;
            }
            
            System.Collections.Generic.ICollection<Rilisoft.OfferItem> val_52 = 与万丁丈与且丁三丁;
            if((与万丁丈与且丁三丁 + 286) == 0)
            {
                goto label_21;
            }
            
            var val_49 = 与万丁丈与且丁三丁 + 176;
            var val_50 = 0;
            val_49 = val_49 + 8;
            label_23:
            if(((与万丁丈与且丁三丁 + 176 + 8) + -8) == null)
            {
                goto label_22;
            }
            
            val_50 = val_50 + 1;
            val_49 = val_49 + 16;
            if(val_50 < (与万丁丈与且丁三丁 + 286))
            {
                goto label_23;
            }
            
            label_21:
            val_53 = 2;
            goto label_24;
            label_22:
            var val_51 = val_49;
            val_51 = val_51 + 2;
            val_52 = val_52 + val_51;
            val_54 = val_52 + 296;
            label_24:
            与万丁丈与且丁三丁.Add(item:  七丑上丄丞业丝丄丞);
            goto label_25;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            System.Func<Rilisoft.OfferItem, System.Boolean> val_20 = null;
            val_55 = val_20;
            val_20 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  val_1, method:  System.Boolean 丙专一丛丞丕七不丌.丕丛业丁丏下一七丘::七不丄丞丂丏丑丌丆(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
            int val_22 = 丞世丘丗丝专下下七 - (System.Linq.Enumerable.Count<Rilisoft.OfferItem>(source:  与万丁丈与且丁三丁, predicate:  val_20));
            if(val_22 < 1)
            {
                    return;
            }
            
            val_51 = 丏丄丑上丛不丈且万.丌下丗上万下世丛丑(七丆丒与丗丌丄且丂:  业丈世与下丘丛丐且, 丏丄丌专丈不丝丒一:  0, 七丑上丄丞业丝丄丞:  七丑上丄丞业丝丄丞);
            int val_25 = val_51.Count - 1;
            if((val_25 & 2147483648) == 0)
            {
                    do
            {
                val_55 = PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世();
                if((val_55.丅世丘业丙丞丆丕丞(下丅丙一丂丗丅丝七:  val_51.Item[val_25])) != false)
            {
                    if(val_51 != null)
            {
                    val_55 = val_51.Item[val_25];
            }
            else
            {
                    val_55 = val_51.Item[val_25];
            }
            
                bool val_31 = val_51.Remove(item:  val_55);
            }
            
                val_25 = val_25 - 1;
            }
            while((val_25 & 2147483648) == 0);
            
            }
            
            val_50 = 1152921505171275776;
            var val_53 = 0;
            label_85:
            if(val_53 <= (val_51.Count - 1))
            {
                goto label_53;
            }
            
            System.Collections.Generic.List<System.String> val_35 = 七丌丞万七万丁丐丙.丛丞丝专丐丐丞三丈(七丆丒与丗丌丄且丂:  业丈世与下丘丛丐且, 业万上丆丐丞且丒七:  ExpController.万上一丝丆且七丅丅(), 丅丐丛丞丒七不丟丂:  true, 丐丅丄一七且丕东与:  true);
            if(val_35.Count < 1)
            {
                goto label_59;
            }
            
            if(val_35 == null)
            {
                goto label_60;
            }
            
            val_56 = val_35.Count;
            goto label_61;
            label_53:
            val_55 = (丙专一丛丞丕七不丌.丕丛业丁丏下一七丘)[1152921543716088064].下丗丁丒丘东丂不丑;
            val_57 = 1;
            val_58 = val_55;
            val_59 = 丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<System.String>(丑东与丅丐丅丂丞业:  val_51);
            goto label_67;
            label_60:
            val_56 = val_35.Count;
            label_61:
            丈丞丕丘丕丗与上一 val_42 = 上丑三丁丄丛丁万丑.丞丟丛下丘下与上下(不三丙万与丗丌七丈:  业丈世与下丘丛丐且, 丞一丁业丄一一业且:  val_35.Item[val_56 - 1], 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
            val_60 = null;
            val_60 = null;
            val_61 = null;
            if((System.String.op_Equality(a:  val_42.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
            {
                    val_62 = null;
                val_55 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
                val_63 = val_42.丟丂丞不专丆万丒世();
                val_58 = 1000;
            }
            else
            {
                    val_64 = null;
                val_55 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
                val_63 = val_42.丟丂丞不专丆万丒世();
                val_58 = 1010;
            }
            
            val_59 = val_55;
            val_57 = val_63;
            label_67:
            bool val_48 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  242, 丞丅上丏丂且下丅与:  val_59, 丌丒丝东丌下丕丁丅:  val_57), 专丂丕丗丗东世丞下:  与万丁丈与且丁三丁);
            label_59:
            val_53 = val_53 + 1;
            if(val_22 != val_53)
            {
                goto label_85;
            }
        
        }
        private void 丌东下丟万丌世丗丐(CategoryNames 业丈世与下丘丛丐且, int 丞世丘丗丝专下下七, System.Collections.Generic.ICollection<Rilisoft.OfferItem> 与万丁丈与且丁三丁)
        {
            object val_40;
            var val_41;
            var val_42;
            System.Predicate<T> val_43;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_44;
            var val_45;
            var val_46;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_47;
            System.Func<TSource, System.Boolean> val_48;
            var val_49;
            丙专一丛丞丕七不丌.丞丆丌万丛不且七丐 val_1 = null;
            val_40 = val_1;
            val_1 = new 丙专一丛丞丕七不丌.丞丆丌万丛不且七丐();
            .业丈世与下丘丛丐且 = 业丈世与下丘丛丐且;
            val_41 = 丞世丘丗丝专下下七;
            Progress.OfferProgress val_2 = this.且七丞丅不七丙丌与.业丑丁丆丕丆丂丅万();
            val_42 = 1152921504616751104;
            System.Predicate<PGCompany.丌丙丈丕丛丆丝丗丟> val_8 = null;
            val_43 = val_8;
            val_8 = new System.Predicate<PGCompany.丌丙丈丕丛丆丝丗丟>(object:  val_1, method:  System.Boolean 丙专一丛丞丕七不丌.丞丆丌万丛不且七丐::三丕三丅下三七丆丛(PGCompany.丌丙丈丕丛丆丝丗丟 三丟东丕丄丄下下丑));
            .丕丁且与丏世一丈丕 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().三与专下上丘丏下丂<PGCompany.丌丙丈丕丛丆丝丗丟>(丁丅丈丌丟世丗丗丟:  56, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true}).FindAll(match:  val_8);
            List.Enumerator<T> val_10 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Where<Rilisoft.OfferItem>(source:  val_2.PreparedItems, predicate:  new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  val_1, method:  System.Boolean 丙专一丛丞丕七不丌.丞丆丌万丛不且七丐::下万丏上业专丏七一(Rilisoft.OfferItem 七丞丙丒三丕且丌丟)))).GetEnumerator();
            label_23:
            if((454882848 & 1) == 0)
            {
                goto label_7;
            }
            
            new 丙专一丛丞丕七不丌.与与专丛丑丄丗不丏() = new 丙专一丛丞丕七不丌.与与专丛丑丄丗不丏();
            .不七业一丑与丐丏丁 = 0.丐丏七丌丕丗业且上();
            System.Predicate<PGCompany.丌丙丈丕丛丆丝丗丟> val_13 = new System.Predicate<PGCompany.丌丙丈丕丛丆丝丗丟>(object:  new 丙专一丛丞丕七不丌.与与专丛丑丄丗不丏(), method:  System.Boolean 丙专一丛丞丕七不丌.与与专丛丑丄丗不丏::下一丏丗上丂丂七三(PGCompany.丌丙丈丕丛丆丝丗丟 三丟东丕丄丄下下丑));
            if(((丙专一丛丞丕七不丌.丞丆丌万丛不且七丐)[1152921543716487840].丕丁且与丏世一丈丕.Exists(match:  null)) == false)
            {
                goto label_11;
            }
            
            Progress.OfferProgress val_15 = this.且七丞丅不七丙丌与.业丑丁丆丕丆丂丅万();
            bool val_16 = val_15.PreparedItems.Remove(item:  (丙专一丛丞丕七不丌.与与专丛丑丄丗不丏)[1152921543716532896].不七业一丑与丐丏丁);
            goto label_23;
            label_11:
            val_44 = (丙专一丛丞丕七不丌.丞丆丌万丛不且七丐)[1152921543716487840].丟丕丁与丝丝丂下丕;
            if(val_44 == null)
            {
                    val_44 = null;
                val_44 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  val_1, method:  System.Boolean 丙专一丛丞丕七不丌.丞丆丌万丛不且七丐::丏三丛上万丆不丂丄(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                .丟丕丁与丝丝丂下丕 = val_44;
            }
            
            val_45 = public static System.Int32 System.Linq.Enumerable::Count<Rilisoft.OfferItem>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, bool> predicate);
            if((System.Linq.Enumerable.Count<Rilisoft.OfferItem>(source:  与万丁丈与且丁三丁, predicate:  null)) >= val_41)
            {
                goto label_23;
            }
            
            System.Collections.Generic.ICollection<Rilisoft.OfferItem> val_41 = 与万丁丈与且丁三丁;
            if((与万丁丈与且丁三丁 + 286) == 0)
            {
                goto label_19;
            }
            
            var val_38 = 与万丁丈与且丁三丁 + 176;
            var val_39 = 0;
            val_38 = val_38 + 8;
            label_21:
            if(((与万丁丈与且丁三丁 + 176 + 8) + -8) == null)
            {
                goto label_20;
            }
            
            val_39 = val_39 + 1;
            val_38 = val_38 + 16;
            if(val_39 < (与万丁丈与且丁三丁 + 286))
            {
                goto label_21;
            }
            
            label_19:
            val_45 = 2;
            goto label_22;
            label_20:
            var val_40 = val_38;
            val_40 = val_40 + 2;
            val_41 = val_41 + val_40;
            val_46 = val_41 + 296;
            label_22:
            与万丁丈与且丁三丁.Add(item:  与万丁丈与且丁三丁);
            goto label_23;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_48 = val_47;
            val_47 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  val_1, method:  System.Boolean 丙专一丛丞丕七不丌.丞丆丌万丛不且七丐::下一丞丛丙东万七与(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
            int val_20 = val_41 - (System.Linq.Enumerable.Count<Rilisoft.OfferItem>(source:  与万丁丈与且丁三丁, predicate:  val_48));
            if(val_20 < 1)
            {
                    return;
            }
            
            System.Collections.Generic.List<丙且上东下丏丏丟下> val_21 = 上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  (丙专一丛丞丕七不丌.丞丆丌万丛不且七丐)[1152921543716487840].业丈世与下丘丛丐且, 丙丑丄与丅丐一不东:  true);
            System.Predicate<丙且上东下丏丏丟下> val_22 = static_value_081D9E68;
            val_22 = new System.Predicate<丙且上东下丏丏丟下>(object:  val_1, method:  System.Boolean 丙专一丛丞丕七不丌.丞丆丌万丛不且七丐::丘东丒丒东丞且丘东(丙且上东下丏丏丟下 三丟东丕丄丄下下丑));
            int val_23 = val_21.RemoveAll(match:  val_22);
            val_41 = 1152921543712021312;
            val_42 = 1152921543716383712;
            do
            {
                if(0 < val_21.Count)
            {
                    val_40 = 丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<丙且上东下丏丏丟下>(丑东与丅丐丅丂丞业:  val_21);
                val_48 = val_40.业上丙丞丐丄丆丅七();
                bool val_28 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  56, 丞丅上丏丂且下丅与:  val_48, 丌丒丝东丌下丕丁丅:  1), 专丂丕丗丗东世丞下:  与万丁丈与且丁三丁);
                bool val_29 = val_21.Remove(item:  val_40);
            }
            else
            {
                    if((this.上三上东丝上七且丆.ContainsKey(key:  232)) != true)
            {
                    this.上三上东丝上七且丆.set_Item(key:  232, value:  0);
            }
            
                if(this.上三上东丝上七且丆 != null)
            {
                    val_49 = this.上三上东丝上七且丆.Item[232];
            }
            else
            {
                    val_49 = 0.Item[232];
            }
            
                this.上三上东丝上七且丆.set_Item(key:  232, value:  val_49 + 100);
                if((this.上三上东丝上七且丆.ContainsKey(key:  242)) != true)
            {
                    this.上三上东丝上七且丆.set_Item(key:  242, value:  0);
            }
            
                val_40 = this.上三上东丝上七且丆;
                if(val_40 != null)
            {
                    val_48 = val_40.Item[242];
            }
            else
            {
                    val_48 = 0.Item[242];
            }
            
                val_40.set_Item(key:  242, value:  val_48 + 200);
            }
            
                val_43 = 0 + 1;
            }
            while(val_20 != val_43);
        
        }
        private bool 丙丂丂丙七丗三一丘(Rilisoft.OfferItem 下丅丙一丂丗丅丝七, System.Collections.Generic.ICollection<Rilisoft.OfferItem> 专丂丕丗丗东世丞下)
        {
            System.Collections.Generic.IEnumerable<TSource> val_23;
            Rilisoft.OfferItem val_24;
            System.Func<TSource, System.Boolean> val_25;
            var val_26;
            var val_27;
            var val_28;
            Rilisoft.OfferItem val_30;
            var val_31;
            Rilisoft.OfferItem val_33;
            val_23 = 专丂丕丗丗东世丞下;
            val_24 = 下丅丙一丂丗丅丝七;
            val_25 = this;
            丙专一丛丞丕七不丌.三丅丞丒丕丅专一丅 val_1 = new 丙专一丛丞丕七不丌.三丅丞丒丕丅专一丅();
            if(val_1 != null)
            {
                    val_26 = val_1;
                .下丅丙一丂丗丅丝七 = val_24;
            }
            else
            {
                    val_26 = 16;
                mem[16] = val_24;
                val_24 = mem[16];
            }
            
            val_27 = 0;
            if(val_23 == null)
            {
                    return (bool)val_27;
            }
            
            if(val_24 == 0)
            {
                    return (bool)val_27;
            }
            
            if(val_1 == null)
            {
                goto label_5;
            }
            
            label_16:
            if(val_24.Type != 1000)
            {
                    if(val_26.Type != 1010)
            {
                goto label_10;
            }
            
            }
            
            val_28 = public static Rilisoft.OfferItem System.Linq.Enumerable::FirstOrDefault<Rilisoft.OfferItem>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, bool> predicate);
            val_25 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  val_23, predicate:  new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  val_1, method:  System.Boolean 丙专一丛丞丕七不丌.三丅丞丒丕丅专一丅::上丄上丞丟与丈丘七(Rilisoft.OfferItem 七丞丙丒三丕且丌丟)));
            if(val_25 == null)
            {
                goto label_11;
            }
            
            label_28:
            val_23 = val_25.Count;
            val_25.Count = mem[16].Count + val_23;
            goto label_70;
            label_5:
            if(mem[16] != 0)
            {
                goto label_16;
            }
            
            goto label_16;
            label_11:
            val_30 = mem[16];
            var val_24 = 0;
            val_31 = 1152921504691015688;
            val_24 = val_24 + 1;
            label_75:
            val_28 = 2;
            goto label_21;
            label_10:
            if(mem[16].Type != 1050)
            {
                goto label_24;
            }
            
            val_28 = public static Rilisoft.OfferItem System.Linq.Enumerable::FirstOrDefault<Rilisoft.OfferItem>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, bool> predicate);
            val_25 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  val_23, predicate:  new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  val_1, method:  System.Boolean 丙专一丛丞丕七不丌.三丅丞丒丕丅专一丅::且与丑丞丛丘丌下丅(Rilisoft.OfferItem 七丞丙丒三丕且丌丟)));
            if(val_25 == null)
            {
                goto label_25;
            }
            
            val_33 = mem[16];
            val_28 = 0;
            if((System.String.op_Equality(a:  val_25.Id, b:  val_33.Id)) == true)
            {
                goto label_28;
            }
            
            val_30 = mem[16];
            var val_25 = 0;
            val_31 = 1152921504691015688;
            val_25 = val_25 + 1;
            goto label_75;
            label_24:
            val_33 = 1152921504690978816;
            var val_26 = 0;
            val_26 = val_26 + 1;
            goto label_38;
            label_25:
            val_30 = mem[16];
            var val_27 = 0;
            val_31 = 1152921504691015688;
            val_27 = val_27 + 1;
            goto label_75;
            label_38:
            if((val_23.Contains(item:  null)) != false)
            {
                    object[] val_17 = new object[2];
                val_23 = val_17;
                val_23[0] = mem[16];
                val_23[1] = this.且七丞丅不七丙丌与;
                UnityEngine.Debug.LogErrorFormat(format:  "item {0} allready exists in collection {1}", args:  val_17);
                val_27 = 0;
                return (bool)val_27;
            }
            
            System.Func<Rilisoft.OfferItem, System.Boolean> val_18 = null;
            val_25 = val_18;
            val_18 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  val_1, method:  System.Boolean 丙专一丛丞丕七不丌.三丅丞丒丕丅专一丅::一一世丈且业丘一丈(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
            val_28 = public static System.Boolean System.Linq.Enumerable::Any<Rilisoft.OfferItem>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, bool> predicate);
            if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_23, predicate:  val_18)) == false)
            {
                goto label_56;
            }
            
            object[] val_20 = new object[2];
            val_23 = val_20;
            val_25 = mem[16].Type;
            val_23[0] = val_25;
            val_23[1] = mem[16].Id;
            UnityEngine.Debug.LogErrorFormat(format:  "identity item allready exists in collection : type:{0} id:{1}", args:  val_20);
            goto label_70;
            label_56:
            val_30 = mem[16];
            var val_28 = 0;
            val_31 = 1152921504691015688;
            val_28 = val_28 + 1;
            goto label_75;
            label_21:
            val_23.Add(item:  null);
            label_70:
            val_27 = 1;
            return (bool)val_27;
        }
        private void 丂丐丆丑丗下丆丆上(int 上丂丝世丝丌专丙丛, System.Collections.Generic.ICollection<Rilisoft.OfferItem> 与万丁丈与且丁三丁)
        {
            if((this.东丗丈丄且东丂一丗 & 1) == 0)
            {
                    CategoryNames[] val_1 = WeaponManager.万三不丄丈丙与丁不();
                int val_2 = UnityEngine.Random.Range(min:  0, max:  val_1.Length);
                CategoryNames val_7 = WeaponManager.万三不丄丈丙与丁不()[((long)(int)(val_2)) << 2];
                mem2[0] = 0;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            bool val_6 = this.丙丂丂丙七丗三一丘(下丅丙一丂丗丅丝七:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  6, 丞丅上丏丂且下丅与:  this.东丗丈丄且东丂一丗.ToString(), 丌丒丝东丌下丕丁丅:  上丂丝世丝丌专丙丛), 专丂丕丗丗东世丞下:  与万丁丈与且丁三丁);
        }
        public 丙专一丛丞丕七不丌()
        {
            this.不丙丙丕专不丞七上 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            this.上三上东丝上七且丆 = new System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, System.Int32>();
        }
        private bool 丗丝上丙业丛不世丄(string 丞丅上丏丂且下丅与)
        {
            object val_7;
            var val_8;
            丙专一丛丞丕七不丌.世业万丕丝丄丝丒一 val_1 = null;
            val_7 = val_1;
            val_1 = new 丙专一丛丞丕七不丌.世业万丕丝丄丝丒一();
            .丞丅上丏丂且下丅与 = 丞丅上丏丂且下丅与;
            if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  this.不丙丙丕专不丞七上, predicate:  new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  val_1, method:  System.Boolean 丙专一丛丞丕七不丌.世业万丕丝丄丝丒一::丈丞不丛丐丞丆与丙(Rilisoft.OfferItem 七丞丙丒三丕且丌丟)))) != false)
            {
                    val_8 = 0;
                return (bool)((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  val_7 = (丙专一丛丞丕七不丌.世业万丕丝丄丝丒一)[1152921543717469840].丞丅上丏丂且下丅与)) == 0) ? 1 : 0;
            }
            
            return (bool)((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  val_7)) == 0) ? 1 : 0;
        }
    
    }

}
