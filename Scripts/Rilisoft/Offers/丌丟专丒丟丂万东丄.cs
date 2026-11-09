using UnityEngine;

namespace Rilisoft.Offers
{
    internal class 丌丟专丒丟丂万东丄 : 丑丝上世丄丂丛丛丕, IDisposable
    {
        // Fields
        private static Rilisoft.Offers.东下上东丅丂丘丗丙 丒丄丅丟丞丅丄七丕;
        private static int 与丏丘丟丛与丘丏丑;
        private readonly System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> 且丑不丛丏丏丐丄丐;
        private static Progress.AdaptiveProgress <专丌上一丕丐丅业三>k__BackingField;
        private readonly System.Collections.Generic.Dictionary<Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType, Rilisoft.Offers.丛丝下且丟丈丞丈丗> 世丅丈上万与业下丈;
        private bool 三丟七丑世丆且且万;
        private System.Collections.Generic.Dictionary<Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType, System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem>> 万东万丒丙丅丅丒七;
        private UnityEngine.Coroutine 丗丐与七丐丞上丟丈;
        private UnityEngine.Coroutine 一丗七丌一世东丈丏;
        internal static readonly System.Collections.Generic.Dictionary<string, Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType> 丝丞丑专丅东下上丄;
        
        // Properties
        public int 业不一丒丁专丝丛丑 { get; }
        public Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丗丑不丁丐丄丑丑东 { get; }
        public bool 七七世丅东丈丛丞丕 { get; }
        internal static Rilisoft.Offers.东下上东丅丂丘丗丙 丅万丂世不丘丕下一 { get; }
        internal static Progress.AdaptiveProgress 不丆丟与丙丏业丛丗 { get; set; }
        
        // Methods
        public int 丕丞世一丟丞丞丗丐()
        {
            return 1;
        }
        public Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 与丝丅丘且丐上丅世()
        {
            return 60;
        }
        public bool 丁世东三丂丒不七丆()
        {
            return true;
        }
        internal static Rilisoft.Offers.东下上东丅丂丘丗丙 丏丘下丞丘不丑万丏()
        {
            null = null;
            return (Rilisoft.Offers.东下上东丅丂丘丗丙)Rilisoft.Offers.丌丟专丒丟丂万东丄.丒丄丅丟丞丅丄七丕;
        }
        internal static Progress.AdaptiveProgress 业丑丁丆丕丆丂丅万()
        {
            null = null;
            return (Progress.AdaptiveProgress)Rilisoft.Offers.丌丟专丒丟丂万东丄.<专丌上一丕丐丅业三>k__BackingField;
        }
        private static void 丙丕丘丒丆丅七万丗(Progress.AdaptiveProgress 丙业与丙丗丝不丈东)
        {
            null = null;
            Rilisoft.Offers.丌丟专丒丟丂万东丄.<专丌上一丕丐丅业三>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal 丌丟专丒丟丂万东丄()
        {
            this.且丑不丛丏丏丐丄丐 = new System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄>();
            this.世丅丈上万与业下丈 = new System.Collections.Generic.Dictionary<AdaptiveModuleType, Rilisoft.Offers.丛丝下且丟丈丞丈丗>();
            this.三丟七丑世丆且且万 = true;
            this.万东万丒丙丅丅丒七 = new System.Collections.Generic.Dictionary<AdaptiveModuleType, System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem>>();
            Rilisoft.Offers.丌丟专丒丟丂万东丄.丙丕丘丒丆丅七万丗(丙业与丙丗丝不丈东:  Progress.七七世万专丕丁上业.丑丙丏东丘丏专丐丕().丒丁上丟丑丁丄世丁());
            Rilisoft.业丙丘丆东丈丕丂丄.丁丗一丅三上丟丗世(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.业丙丘丆东丈丕丂丄>(object:  this, method:  System.Void Rilisoft.Offers.丌丟专丒丟丂万东丄::丁丒丟丈世且丆丂丒(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌)));
        }
        public Rilisoft.业丙丘丆东丈丕丂丄 丐上丙世丂丅丝不丈()
        {
            var val_2;
            System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = 丌丟专丒丟丂万东丄.<>c.<>9__17_0;
            if(val_4 != null)
            {
                    return System.Linq.Enumerable.FirstOrDefault<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_1 = null);
            }
            
            val_4 = val_1;
            val_1 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌丟专丒丟丂万东丄.<>c::丟三丐丕不一丐丂丝(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            丌丟专丒丟丂万东丄.<>c.<>9__17_0 = val_4;
            return System.Linq.Enumerable.FirstOrDefault<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  val_1);
        }
        public System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> 丙丈丈东丟丟丒丄三()
        {
            var val_3;
            System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_5;
            val_3 = null;
            val_3 = null;
            val_5 = 丌丟专丒丟丂万东丄.<>c.<>9__18_0;
            if(val_5 != null)
            {
                    return System.Linq.Enumerable.ToList<Rilisoft.业丙丘丆东丈丕丂丄>(source:  System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_1 = null));
            }
            
            val_5 = val_1;
            val_1 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌丟专丒丟丂万东丄.<>c::业丅三专万万丗三世(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            丌丟专丒丟丂万东丄.<>c.<>9__18_0 = val_5;
            return System.Linq.Enumerable.ToList<Rilisoft.业丙丘丆东丈丕丂丄>(source:  System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  val_1));
        }
        public Rilisoft.业丙丘丆东丈丕丂丄 上丑下专丄下丟丏丆(string 丗丟丁丐与下丙丕丛)
        {
            .丗丟丁丐与下丙丕丛 = 丗丟丁丐与下丙丕丛;
            return System.Linq.Enumerable.FirstOrDefault<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  new 丌丟专丒丟丂万东丄.业丂七丏丟丕丌丂世(), method:  System.Boolean 丌丟专丒丟丂万东丄.业丂七丏丟丕丌丂世::万上下上与丅专丑丗(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上)));
        }
        public Rilisoft.业丙丘丆东丈丕丂丄 丅世业丂丝丁丌七丗(string 业丒丌东丈丏丈一不)
        {
            string val_5;
            var val_6;
            val_5 = 业丒丌东丈丏丈一不;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5)) != false)
            {
                    return 0;
            }
            
            if((val_5.IndexOf(value:  "offer-")) != 0)
            {
                    return this.上丑下专丄下丟丏丆(丗丟丁丐与下丙丕丛:  val_5 = val_5.Substring(startIndex:  Length));
            }
            
            val_6 = "offer-";
            if(("offer-") == null)
            {
                    val_6 = "offer-";
            }
            
            return this.上丑下专丄下丟丏丆(丗丟丁丐与下丙丕丛:  val_5);
        }
        public System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> 东东丛一丄丅丌丗且()
        {
            return System.Linq.Enumerable.ToList<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐);
        }
        public bool 且丟丌丑丘丕七专三()
        {
            var val_2;
            System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = 丌丟专丒丟丂万东丄.<>c.<>9__22_0;
            if(val_4 != null)
            {
                    return System.Linq.Enumerable.Any<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_1 = null);
            }
            
            val_4 = val_1;
            val_1 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌丟专丒丟丂万东丄.<>c::丘丞丏丂丞业世一七(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            丌丟专丒丟丂万东丄.<>c.<>9__22_0 = val_4;
            return System.Linq.Enumerable.Any<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  val_1);
        }
        public void 丁东丐丄丞丌丘业上()
        {
            var val_3 = this;
            if(this.且丑不丛丏丏丐丄丐 == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = this.且丑不丛丏丏丐丄丐.GetEnumerator();
            label_4:
            if((464889960 & 1) == 0)
            {
                goto label_2;
            }
            
            0.丐丏七丌丕丗业且上().丁东丐丄丞丌丘业上();
            goto label_4;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public void 丁丆丕丏东丟丐丄丂()
        {
            var val_3;
            var val_9;
            List.Enumerator<T> val_1 = this.且丑不丛丏丏丐丄丐.GetEnumerator();
            label_4:
            if((465034720 & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_3.丐丏七丌丕丗业且上() != null)
            {
                goto label_4;
            }
            
            goto label_4;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.且丑不丛丏丏丐丄丐.Clear();
            val_9 = null;
            val_9 = null;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁与丑丁丐丑下丌丏(世不下丟世一丝丐丗:  Rilisoft.Offers.丌丟专丒丟丂万东丄.丒丄丅丟丞丅丄七丕.丌丗丏丝丈丒一一丞, 丂三丟丂丈丐丆丗丟:  FriendsController.丝丗专上三不丄丑丑());
            Rilisoft.Offers.丌丟专丒丟丂万东丄.丙丕丘丒丆丅七万丗(丙业与丙丗丝不丈东:  Progress.七七世万专丕丁上业.丑丙丏东丘丏专丐丕().丒丁上丟丑丁丄世丁());
        }
        public void 且丛丕业丞万东七丒(bool 丆丄丘丂业丛七丁且 = False)
        {
            var val_111;
            var val_112;
            var val_113;
            var val_114;
            System.Collections.Generic.IEnumerable<Rilisoft.Offers.AdaptiveOfferItem> val_115;
            int val_116;
            var val_117;
            var val_118;
            var val_119;
            var val_120;
            var val_121;
            int val_122;
            var val_123;
            var val_125;
            int val_126;
            var val_128;
            var val_129;
            var val_130;
            var val_131;
            char val_133;
            var val_134;
            var val_135;
            var val_136;
            val_111;
            val_112 = 丆丄丘丂业丛七丁且;
            if(this.三丟七丑世丆且且万 != false)
            {
                    val_112 = 1;
                this.三丟七丑世丆且且万 = false;
            }
            
            this.万东万丒丙丅丅丒七.Clear();
            val_113 = 1152921505501892608;
            val_114 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            val_115 = 1152921516340667232;
            if((val_1.丂一七丛丄丛三且丁 & 1) == 0)
            {
                    return;
            }
            
            val_114 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            if((val_2.丘丄三专丟丈万上三 & 1) == 0)
            {
                    return;
            }
            
            val_116 = static System.Int32 Rilisoft.Offers.专下丞一丕下下丗与::丛丅下丆丗丏三丁丕<System.Int32>(System.Nullable<Rilisoft.业丙丘丆东丈丕丂丄.OfferModule> 丕上业丕丘上丘七一, string 丒丑丂丐丕丒丕东与);
            val_114 = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Int32>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "level");
            if(val_114 < 1)
            {
                    return;
            }
            
            if(val_114 > ExperienceController.丞丞丘业东丙丏七丌())
            {
                    return;
            }
            
            val_117 = 1152921537962617104;
            val_118 = 0;
            val_119 = 0;
            goto label_17;
            label_220:
            val_116 = public Rilisoft.业丙丘丆东丈丕丂丄 System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄>::get_Item(int index);
            Rilisoft.业丙丘丆东丈丕丂丄 val_5 = this.且丑不丛丏丏丐丄丐.Item[0];
            if(val_5 != null)
            {
                    val_120 = val_5;
                val_121 = 0;
                System.Nullable<System.TimeSpan> val_6 = val_120.丙世丑丅丒丑业与不();
            }
            else
            {
                    val_121 = 0;
            }
            
            if(((465559360 & 1) == 0) || (val_5.TotalSeconds > 0f))
            {
                goto label_22;
            }
            
            System.Nullable<AdaptiveModuleType> val_8 = val_5.下丐丝万丞丙丁丂丑();
            if((465559344 & 1) == 0)
            {
                goto label_26;
            }
            
            System.Nullable<AdaptiveModuleType> val_9 = val_5.下丐丝万丞丙丁丂丑();
            if(465559344 != 70)
            {
                goto label_26;
            }
            
            Progress.AdaptiveProgress val_10 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            if((val_10.OffersShowCounter.ContainsKey(key:  val_5.业上丙丞丐丄丆丅七())) == false)
            {
                goto label_32;
            }
            
            Progress.AdaptiveProgress val_13 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            Progress.AdaptiveProgress val_16 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            val_122 = val_13.OffersShowCounter.Item[val_5.业上丙丞丐丄丆丅七()] + 1;
            val_116 = val_122;
            val_16.OffersShowCounter.set_Item(key:  val_5.业上丙丞丐丄丆丅七(), value:  val_116);
            goto label_41;
            label_26:
            val_123 = 0;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_18 = val_5.丏与丅专三丙与丘丒();
            if(val_18 == null)
            {
                goto label_216;
            }
            
            System.Nullable<AdaptiveModuleType> val_19 = val_5.下丐丝万丞丙丁丂丑();
            if(465559344 == 90)
            {
                    Progress.AdaptiveProgress val_20 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
                if(val_20.GadgetsLastViewed != null)
            {
                    Progress.AdaptiveProgress val_21 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
                if((System.Linq.Enumerable.Any<System.String>(source:  val_21.GadgetsLastViewed)) != false)
            {
                    Progress.AdaptiveProgress val_23 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
                val_23.GadgetsLastViewed.Clear();
            }
            
            }
            
            }
            
            List.Enumerator<T> val_24 = val_18.GetEnumerator();
            label_130:
            if((465559312 & 1) == 0)
            {
                goto label_58;
            }
            
            string val_26 = 0.丐丏七丌丕丗业且上();
            System.Nullable<AdaptiveModuleType> val_27 = val_5.下丐丝万丞丙丁丂丑();
            if((465559344 & 1) == 0)
            {
                goto label_130;
            }
            
            System.Nullable<AdaptiveModuleType> val_28 = val_5.下丐丝万丞丙丁丂丑();
            if(465559344 == 90)
            {
                goto label_62;
            }
            
            new 丌丟专丒丟丂万东丄.丘丞三且东万丕丙丂() = new 丌丟专丒丟丂万东丄.丘丞三且东万丕丙丂();
            .丛丅丐丒丈不丅丐丄 = Rilisoft.CuttedOfferItem.东丝七业丄丑丒世七(丞丕丒专一下丙业上:  val_26.UniqueId);
            Progress.AdaptiveProgress val_32 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            System.Func<SkippedItem, System.Boolean> val_33 = new System.Func<SkippedItem, System.Boolean>(object:  new 丌丟专丒丟丂万东丄.丘丞三且东万丕丙丂(), method:  System.Boolean 丌丟专丒丟丂万东丄.丘丞三且东万丕丙丂::丕一丒下丏丗不丆丆(Progress.AdaptiveProgress.SkippedItem 专上丘丈丁世一丐且));
            if((System.Linq.Enumerable.Any<SkippedItem>(source:  val_32.SkippedItems, predicate:  null)) == true)
            {
                goto label_130;
            }
            
            System.Nullable<AdaptiveModuleType> val_36 = val_5.下丐丝万丞丙丁丂丑();
            new AdaptiveProgress.SkippedItem() = new AdaptiveProgress.SkippedItem(丞一丁业丄一一业且:  (丌丟专丒丟丂万东丄.丘丞三且东万丕丙丂)[1152921543727246224].丛丅丐丒丈不丅丐丄.UniqueId, 丕上业丕丘上丘七一:  465559344);
            Progress.AdaptiveProgress val_38 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            val_38.SkippedItems.Add(item:  new AdaptiveProgress.SkippedItem());
            label_62:
            System.Nullable<AdaptiveModuleType> val_39 = val_5.下丐丝万丞丙丁丂丑();
            val_125 = 1152921505501892608;
            if(465559344 != 30)
            {
                goto label_76;
            }
            
            System.Nullable<CategoryNames> val_40 = val_26.Category;
            Rilisoft.Offers.丙东丄万万丑东丘丅.专七丂丘丄世丘不丒(丙业与丙丗丝不丈东:  new System.Nullable<CategoryNames>() {HasValue = val_40.HasValue});
            goto label_130;
            label_76:
            System.Nullable<AdaptiveModuleType> val_41 = val_5.下丐丝万丞丙丁丂丑();
            if(465559344 != 80)
            {
                goto label_82;
            }
            
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  val_26.Id)) == null)
            {
                goto label_85;
            }
            
            var val_49 = (((System.String.op_Equality(a:  Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.东丏丌丕丑丝下丙丏(), b:  val_26.Id)) & true) != 0) ? (1 + 1) : 1;
            goto label_88;
            label_82:
            System.Nullable<AdaptiveModuleType> val_50 = val_5.下丐丝万丞丙丁丂丑();
            if(465559344 != 10)
            {
                goto label_90;
            }
            
            System.Nullable<CategoryNames> val_51 = val_26.Category;
            if((465559304 & 1) == 0)
            {
                goto label_130;
            }
            
            Progress.AdaptiveProgress val_52 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            System.Nullable<CategoryNames> val_53 = val_26.Category;
            if((val_52.Weapons_LastViewedCategoryes.Contains(item:  465559304)) != false)
            {
                    Progress.AdaptiveProgress val_55 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
                System.Nullable<CategoryNames> val_56 = val_26.Category;
                bool val_57 = val_55.Weapons_LastViewedCategoryes.Remove(item:  465559304);
            }
            
            Progress.AdaptiveProgress val_58 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            System.Nullable<CategoryNames> val_59 = val_26.Category;
            val_58.Weapons_LastViewedCategoryes.Add(item:  465559304);
            goto label_130;
            label_90:
            System.Nullable<AdaptiveModuleType> val_60 = val_5.下丐丝万丞丙丁丂丑();
            if(465559344 != 90)
            {
                goto label_130;
            }
            
            Progress.AdaptiveProgress val_61 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            if(val_61.GadgetsLastViewed == null)
            {
                    Progress.AdaptiveProgress val_62 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
                System.Collections.Generic.List<System.String> val_63 = new System.Collections.Generic.List<System.String>();
                val_62.GadgetsLastViewed = null;
                val_125 = 1152921505501892608;
            }
            
            Progress.AdaptiveProgress val_64 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            val_64.GadgetsLastViewed.Add(item:  val_26.UniqueId);
            goto label_130;
            label_85:
            val_126 = 0;
            label_88:
            Progress.AdaptiveProgress val_66 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            val_66.PetsLastViewedOfferType = val_126;
            if(this.世丅丈上万与业下丈.Item[80] != null)
            {
                goto label_130;
            }
            
            goto label_130;
            label_32:
            Progress.AdaptiveProgress val_68 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            val_116 = 1;
            val_122 = 1;
            val_68.OffersShowCounter.Add(key:  val_5.业上丙丞丐丄丆丅七(), value:  1);
            label_41:
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_70 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            if(val_122 >= val_70.上上一丛丕丏三丁三)
            {
                goto label_139;
            }
            
            val_118 = val_118;
            Progress.OfferProgress val_71 = val_5.业丑丁丆丕丆丂丅万();
            val_117 = 1152921537962617104;
            val_71.FirstShowDate = FriendsController.丝丗专上三不丄丑丑();
            goto label_144;
            label_139:
            Progress.AdaptiveProgress val_76 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            val_76.IgnoreOffers.Add(item:  System.String.Format(format:  "{0}:{1}", arg0:  70, arg1:  val_5.丟丂丞不专丆万丒世().丟丂丞不专丆万丒世()));
            val_118 = val_118;
            val_116 = public System.Boolean System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄>::Remove(Rilisoft.业丙丘丆东丈丕丂丄 item);
            bool val_77 = this.且丑不丛丏丏丐丄丐.Remove(item:  val_5);
            val_117 = 1152921537962617104;
            goto label_153;
            label_58:
            var val_111 = 0;
            val_118 = val_118;
            val_111 = val_111 + 1;
            mem2[0] = 1091;
            val_123 = public System.Void List.Enumerator<Rilisoft.OfferItem>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_113 = val_111;
            if((val_113 == 1) || ((1152921543727111680 + ((0 + 1)) << 2) != 1091))
            {
                goto label_213;
            }
            
            var val_112 = 0;
            val_112 = val_112 ^ (val_113 >> 31);
            val_113 = val_113 + val_112;
            if(val_5 != null)
            {
                goto label_217;
            }
            
            goto label_215;
            label_213:
            if( != 0)
            {
                    val_123 = 0;
                val_118 = 0;
            }
            
            label_216:
            if(val_5 != null)
            {
                goto label_217;
            }
            
            label_215:
            label_217:
            val_116 = public System.Boolean System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄>::Remove(Rilisoft.业丙丘丆东丈丕丂丄 item);
            bool val_78 = this.且丑不丛丏丏丐丄丐.Remove(item:  val_5);
            label_153:
            label_144:
            label_22:
            val_119 = (-1) + 1;
            label_17:
            if(val_119 < this.且丑不丛丏丏丐丄丐.Count)
            {
                goto label_220;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_80 = this.世丅丈上万与业下丈.GetEnumerator();
            label_235:
            if((465559264 & 1) == 0)
            {
                goto label_222;
            }
            
            ConfiguredValueTaskAwaiter val_82 = 70.GetAwaiter();
            if((val_82._value._obj == 0) || ((this.丒丛丛丕丆丄丆丏与(丑丒丛与下专且丗不:  val_82._value._obj.丙东专丂世丈丏丁丂())) == false))
            {
                goto label_235;
            }
            
            if(val_82._value._obj == 0)
            {
                goto label_235;
            }
            
            if(val_82._value._obj == 0)
            {
                goto label_235;
            }
            
            if(val_82._value._obj.Count < 1)
            {
                goto label_235;
            }
            
            this.万东万丒丙丅丅丒七.Add(key:  val_82._value._obj.丙东专丂世丈丏丁丂(), value:  val_82._value._obj);
            goto label_235;
            label_222:
            var val_114 = val_113;
            val_128 = 465559040;
            val_114 = val_114 + 1;
            mem2[0] = 1304;
            val_129 = 1152921505501892608;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_116 = val_114;
            if((val_116 != 1) && ((val_128 + ((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) << 2) == 1304))
            {
                    var val_115 = 0;
                val_115 = val_115 ^ (val_116 >> 31);
                val_116 = val_116 + val_115;
            }
            else
            {
                    if(70 != 0)
            {
                    val_116 = 0;
            }
            
            }
            
            val_114 = 1152921543727015120;
            PGCompany.东丑丒丗一丞下丙丙<T> val_87 = PGCompany.东丑丒丗一丞下丙丙<Rilisoft.Offers.AdaptiveOfferItem>.万世丅七一专丕丞不();
            val_115 = PGCompany.东丑丒丗一丞下丙丙<Rilisoft.Offers.AdaptiveOfferItem>.万世丅七一专丕丞不();
            val_130 = 0;
            if(((Rilisoft.TryGuns_2_0_Controller.丑七不且上丗丁一世() == 0) || (Rilisoft.TryGuns_2_0_Controller.丑七不且上丗丁一世().丄丈丅丗丟丄丗三且() == null)) || (Rilisoft.TryGuns_2_0_Controller.丑七不且上丗丁一世().丄丈丅丗丟丄丗三且().Count < 1))
            {
                goto label_291;
            }
            
            List.Enumerator<T> val_98 = Rilisoft.TryGuns_2_0_Controller.丑七不且上丗丁一世().丄丈丅丗丟丄丗三且().GetEnumerator();
            label_283:
            if((465559216 & 1) == 0)
            {
                goto label_275;
            }
            
            string val_99 = 70.丐丏七丌丕丗业且上();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_99)) == true)
            {
                goto label_283;
            }
            
            Rilisoft.Offers.AdaptiveOfferItem val_101 = Rilisoft.Offers.AdaptiveOfferItem.丂丈世不七丆一丛下(丕上业丕丘上丘七一:  0, 世丈三丐丞一丒丛不:  0, 与丝丙丝万丑丞丄一:  0, 丟丒且一专丟丙下一:  0, 丆且丁丒丒丆丁三丆:  0);
            val_101.丑与东丙丑丘丁丂丒(丁丅丈丌丟世丗丗丟:  10, 丞丅上丏丂且下丅与:  val_99, 丌丒丝东丌下丕丁丅:  1);
            val_115.Add(item:  val_101);
            goto label_283;
            label_275:
            var val_117 = val_116;
            val_131 = 465559040;
            val_117 = val_117 + 1;
            mem2[0] = 1467;
            val_129 = 1152921505501892608;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_119 = val_117;
            if((val_119 != 1) && ((val_131 + ((((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1) + (0 ^ ((int)(((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) >> 31)) + 1)) << 2) == 1467))
            {
                    var val_118 = 0;
                val_118 = val_118 ^ (val_119 >> 31);
                val_119 = val_119 + val_118;
            }
            else
            {
                    if(70 != 0)
            {
                    val_130 = 0;
            }
            
            }
            
            label_291:
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_102 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            List.Enumerator<T> val_103 = val_102.丙丕世一丌丙丙丟丒.GetEnumerator();
            label_303:
            if((465559184 & 1) == 0)
            {
                goto label_297;
            }
            
            if(70.丐丏七丌丕丗业且上() != null)
            {
                    val_133 = val_104.m_firstChar;
            }
            else
            {
                    val_133 = val_104.m_firstChar;
            }
            
            Rilisoft.Offers.AdaptiveOfferItem val_105 = this.丞丗丌丛且七丅丄万(丄一丞丁丂东不丙丁:  val_115, 丟丒且一专丟丙下一:  val_133, 丝丞丈业上丛一丏丆:  null);
            if(val_105 == null)
            {
                goto label_303;
            }
            
            val_87.Add(item:  val_105);
            val_115.Add(item:  val_105);
            goto label_303;
            label_297:
            var val_120 = val_119;
            val_134 = 465559040;
            val_135 = 0;
            val_120 = val_120 + 1;
            mem2[0] = 1563;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_122 = val_120;
            if((val_122 != 1) && ((val_134 + ((((((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1) + (0 ^ ((int)(((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) >> 31)) + 1) + (0 ^ ((int)(((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1) + (0 ^ ((int)(((0 +) << 2) == 1563))
            {
                    var val_121 = 0;
                val_121 = val_121 ^ (val_122 >> 31);
                val_122 = val_122 + val_121;
            }
            else
            {
                    if( != 0)
            {
                    val_130 = 0;
                val_135 = 0;
            }
            
            }
            
            List.Enumerator<T> val_106 = val_115.GetEnumerator();
            val_113 = 1152921543727085776;
            label_320:
            if((465559160 & 1) == 0)
            {
                goto label_316;
            }
            
            string val_107 = 0.丐丏七丌丕丗业且上();
            if((val_87.Contains(item:  val_107)) == true)
            {
                goto label_320;
            }
            
            val_107.Dispose();
            goto label_320;
            label_316:
            var val_123 = val_122;
            val_136 = val_135;
            val_123 = val_123 + 1;
            mem2[0] = 1624;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_123 == 1)
            {
                goto label_325;
            }
            
            if(( == 0) || ((val_134 + ((((((((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1) + (0 ^ ((int)(((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) >> 31)) + 1) + (0 ^ ((int)(((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1) + (0 ^ ((int)(((0) << 2) == 1624))
            {
                goto label_333;
            }
            
            label_332:
            val_130 = 0;
            label_333:
            this.下丌下且三丏丂丐下(三丆丙丙东下丄专七:  val_87);
            PGCompany.东丑丒丗一丞下丙丙<T> val_109 = PGCompany.东丑丒丗一丞下丙丙<Rilisoft.Offers.AdaptiveOfferItem>.万世丅七一专丕丞不();
            PGCompany.东丑丒丗一丞下丙丙<T> val_110 = PGCompany.东丑丒丗一丞下丙丙<Rilisoft.Offers.AdaptiveOfferItem>.万世丅七一专丕丞不();
            return;
            label_325:
            if( != 0)
            {
                goto label_332;
            }
            
            goto label_333;
        }
        private Rilisoft.Offers.AdaptiveOfferItem 丞丗丌丛且七丅丄万(System.Collections.Generic.IEnumerable<Rilisoft.Offers.AdaptiveOfferItem> 丄一丞丁丂东不丙丁, Rilisoft.Offers.AdaptiveOfferItem.丂丘丛下丆一丕丂丅 丟丒且一专丟丙下一, System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType> 丝丞丈业上丛一丏丆)
        {
            var val_21;
            var val_22;
            丂丘丛下丆一丕丂丅 val_23;
            System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean> val_24;
            .丟丒且一专丟丙下一 = 丟丒且一专丟丙下一;
            val_21 = 0;
            val_22 = 0;
            goto label_38;
            label_43:
            丌丟专丒丟丂万东丄.丕万丌丘万丅丘丈丏 val_2 = new 丌丟专丒丟丂万东丄.丕万丌丘万丅丘丈丏();
            if(val_22 != 0)
            {
                    return (Rilisoft.Offers.AdaptiveOfferItem)val_22;
            }
            
            AdaptiveModuleType val_3 = 丝丞丈业上丛一丏丆.Item[0];
            if(val_2 == null)
            {
                goto label_5;
            }
            
            .丗与丟上上丑专世丗 = val_3;
            if(this.世丅丈上万与业下丈 != null)
            {
                goto label_33;
            }
            
            label_34:
            label_33:
            if((((this.世丅丈上万与业下丈.ContainsKey(key:  val_3)) == false) || ((this.万东万丒丙丅丅丒七.ContainsKey(key:  .丗与丟上上丑专世丗)) == false)) || (this.万东万丒丙丅丅丒七.Item[.丗与丟上上丑专世丗] == null))
            {
                goto label_36;
            }
            
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_7 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            if((丄一丞丁丂东不丙丁 == 0) || ((val_7.丟业与一世丟三丞丛.Contains(item:  .丗与丟上上丑专世丗)) == true))
            {
                goto label_20;
            }
            
            System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean> val_9 = null;
            val_23 = public System.Void System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean>::.ctor(object object, IntPtr method);
            val_9 = new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean>(object:  val_2, method:  System.Boolean 丌丟专丒丟丂万东丄.丕万丌丘万丅丘丈丏::与与东丒丁万丕丘丗(Rilisoft.Offers.AdaptiveOfferItem 下丅丙一丂丗丅丝七));
            if((System.Linq.Enumerable.Any<Rilisoft.Offers.AdaptiveOfferItem>(source:  丄一丞丁丂东不丙丁, predicate:  val_9)) == true)
            {
                goto label_36;
            }
            
            label_20:
            val_24 = (丌丟专丒丟丂万东丄.丐丐七丈丅丐三且丆)[1152921543727763728].丂丌丑一丏丌丌世丆;
            if(val_24 == null)
            {
                    System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean> val_12 = null;
                val_24 = val_12;
                val_23 = public System.Void System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean>::.ctor(object object, IntPtr method);
                val_12 = new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean>(object:  new 丌丟专丒丟丂万东丄.丐丐七丈丅丐三且丆(), method:  System.Boolean 丌丟专丒丟丂万东丄.丐丐七丈丅丐三且丆::丄三丆丅与丌与且专(Rilisoft.Offers.AdaptiveOfferItem 三东专丈丘丒东世七));
                .丂丌丑一丏丌丌世丆 = val_24;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_13 = System.Linq.Enumerable.Where<Rilisoft.Offers.AdaptiveOfferItem>(source:  this.万东万丒丙丅丅丒七.Item[.丗与丟上上丑专世丗], predicate:  val_12);
            if((System.Linq.Enumerable.Any<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_13)) == false)
            {
                goto label_36;
            }
            
            if(.丗与丟上上丑专世丗 <= 30)
            {
                goto label_28;
            }
            
            if(.丗与丟上上丑专世丗 == 70)
            {
                goto label_29;
            }
            
            if(.丗与丟上上丑专世丗 == 80)
            {
                goto label_30;
            }
            
            if(.丗与丟上上丑专世丗 != 90)
            {
                goto label_36;
            }
            
            Rilisoft.Offers.AdaptiveOfferItem val_15 = this.丝丟丙丟世世丞丕丑(丄一丞丁丂东不丙丁:  public static System.Boolean System.Linq.Enumerable::Any<Rilisoft.Offers.AdaptiveOfferItem>(System.Collections.Generic.IEnumerable<TSource> source), 丕丏丒业东丕上丟丘:  val_13, 丟丒且一专丟丙下一:  val_23);
            goto label_41;
            label_5:
            mem[16] = val_3;
            if(this.世丅丈上万与业下丈 != null)
            {
                goto label_33;
            }
            
            goto label_34;
            label_28:
            if(.丗与丟上上丑专世丗 == 10)
            {
                goto label_35;
            }
            
            if(.丗与丟上上丑专世丗 != 30)
            {
                goto label_36;
            }
            
            Rilisoft.Offers.AdaptiveOfferItem val_16 = this.丂丗丂丆丄丁丛七丏(丄一丞丁丂东不丙丁:  丄一丞丁丂东不丙丁, 丕丏丒业东丕上丟丘:  val_13, 丟丒且一专丟丙下一:  val_23);
            goto label_41;
            label_36:
            val_22 = 0;
            label_41:
            val_21 = 1;
            goto label_38;
            label_35:
            Rilisoft.Offers.AdaptiveOfferItem val_17 = this.专丕丕丂丝丅丛丈东(丄一丞丁丂东不丙丁:  丄一丞丁丂东不丙丁, 丕丏丒业东丕上丟丘:  val_13, 丟丒且一专丟丙下一:  val_23);
            goto label_41;
            label_29:
            Rilisoft.Offers.AdaptiveOfferItem val_18 = this.一丗业丟丝下丑丏与(丄一丞丁丂东不丙丁:  public static System.Boolean System.Linq.Enumerable::Any<Rilisoft.Offers.AdaptiveOfferItem>(System.Collections.Generic.IEnumerable<TSource> source), 丕丏丒业东丕上丟丘:  val_13, 丟丒且一专丟丙下一:  (丌丟专丒丟丂万东丄.丐丐七丈丅丐三且丆)[1152921543727763728].丟丒且一专丟丙下一);
            goto label_41;
            label_30:
            Rilisoft.Offers.AdaptiveOfferItem val_19 = this.丂丆万丒与丕丐丏丏(丄一丞丁丂东不丙丁:  public static System.Boolean System.Linq.Enumerable::Any<Rilisoft.Offers.AdaptiveOfferItem>(System.Collections.Generic.IEnumerable<TSource> source), 丕丏丒业东丕上丟丘:  val_13, 丟丒且一专丟丙下一:  (丌丟专丒丟丂万东丄.丐丐七丈丅丐三且丆)[1152921543727763728].丟丒且一专丟丙下一);
            goto label_41;
            label_38:
            if(val_21 < 丝丞丈业上丛一丏丆.Count)
            {
                goto label_43;
            }
            
            return (Rilisoft.Offers.AdaptiveOfferItem)val_22;
        }
        private bool 丒丛丛丕丆丄丆丏与(Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType 丑丒丛与下专且丗不)
        {
            AdaptiveModuleType val_10;
            ulong val_11;
            val_10 = 丑丒丛与下专且丗不;
            System.Nullable<System.DateTime> val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丑丙与丟万丅与丄丕();
            if((466389616 & 1) == 0)
            {
                goto label_11;
            }
            
            System.Nullable<System.DateTime> val_3 = val_2.HasValue.万丏三三丅丗世一丞(丑丒丛与下专且丗不:  val_10);
            System.Nullable<System.DateTime> val_4 = val_3.HasValue.丒不业丁七不丝七丏(丑丒丛与下专且丗不:  val_10);
            if((466389584 & 1) == 0)
            {
                goto label_5;
            }
            
            val_10;
            if(( & 1) == 0)
            {
                goto label_11;
            }
            
            if((System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_10}, t2:  new System.DateTime() {dateData = val_2.HasValue.丐丏七丌丕丗业且上()})) == false)
            {
                goto label_11;
            }
            
            label_5:
            if((466389600 & 1) == 0)
            {
                goto label_15;
            }
            
            val_10;
            if(( & 1) == 0)
            {
                goto label_11;
            }
            
            val_11 = val_10;
            bool val_8 = System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_11}, t2:  new System.DateTime() {dateData = val_2.HasValue.丐丏七丌丕丗业且上()});
            goto label_15;
            label_11:
            val_11 = 0;
            label_15:
            val_11 = val_11 & 1;
            return (bool)val_11;
        }
        private int 不丄专丐业丞丛与丁(Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType 丑丒丛与下专且丗不, int 丑丅三丗丌丞三丘丂)
        {
            System.Nullable<System.DateTime> val_1 = this.万丏三三丅丗世一丞(丑丒丛与下专且丗不:  丑丒丛与下专且丗不);
            System.Nullable<System.DateTime> val_3 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丑丙与丟万丅与丄丕();
            if((466526192 & 1) == 0)
            {
                    return (int)((int)val_4._ticks.TotalSeconds < 丑丅三丗丌丞三丘丂) ? ((int)val_4._ticks.TotalSeconds) : (丑丅三丗丌丞三丘丂);
            }
            
            if(( & 1) == 0)
            {
                    return (int)((int)val_4._ticks.TotalSeconds < 丑丅三丗丌丞三丘丂) ? ((int)val_4._ticks.TotalSeconds) : (丑丅三丗丌丞三丘丂);
            }
            
            System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {}, d2:  new System.DateTime() {});
            return (int)((int)val_4._ticks.TotalSeconds < 丑丅三丗丌丞三丘丂) ? ((int)val_4._ticks.TotalSeconds) : (丑丅三丗丌丞三丘丂);
        }
        private int 与丙且丑丙丒下万丌(Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType 丑丒丛与下专且丗不, int 与丕丌丒丗丄丘丙东)
        {
            int val_4 = 与丕丌丒丗丄丘丙东;
            System.Nullable<System.DateTime> val_1 = this.丒不业丁七不丝七丏(丑丒丛与下专且丗不:  丑丒丛与下专且丗不);
            if(( & 1) == 0)
            {
                    return (int)val_4;
            }
            
            val_4 = System.Math.Max(val1:  丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime() {}), val2:  val_4 = 与丕丌丒丗丄丘丙东);
            return (int)val_4;
        }
        private int 丕万丛业东丆丑丞上(Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType 丑丒丛与下专且丗不, int 与丕丌丒丗丄丘丙东)
        {
            int val_4 = 与丕丌丒丗丄丘丙东;
            System.Nullable<System.DateTime> val_1 = this.万丏三三丅丗世一丞(丑丒丛与下专且丗不:  丑丒丛与下专且丗不);
            if(( & 1) == 0)
            {
                    return (int)val_4;
            }
            
            val_4 = System.Math.Min(val1:  丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime() {}), val2:  val_4 = 与丕丌丒丗丄丘丙东);
            return (int)val_4;
        }
        private System.Nullable<System.DateTime> 丒不业丁七不丝七丏(Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType 丑丒丛与下专且丗不)
        {
            ulong val_12;
            var val_14;
            var val_15;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            string val_3 = "start_" + 丑丒丛与下专且丗不.ToString().ToLower();
            if((Rilisoft.Offers.专下丞一丕下下丗与.七丏丙丐一丅丒丗丛<System.DateTime>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  val_3)) != false)
            {
                    System.DateTime val_5 = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.DateTime>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  val_3);
            }
            
            val_12 = "start";
            if((Rilisoft.Offers.专下丞一丕下下丗与.七丏丙丐一丅丒丗丛<System.DateTime>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "start")) != false)
            {
                    System.DateTime val_7 = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.DateTime>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "start");
            }
            
            if(((466909368 & 1) == 0) || ((466909352 & 1) == 0))
            {
                goto label_15;
            }
            
            val_12;
            if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_12}, t2:  new System.DateTime() {})) == false)
            {
                goto label_18;
            }
            
            goto label_19;
            label_15:
            if((466909312 & 1) == 0)
            {
                goto label_22;
            }
            
            goto label_22;
            label_18:
            label_19:
            label_22:
            val_14 = public System.Boolean System.Nullable<System.DateTime>::get_HasValue();
            if((466909328 & 1) == 0)
            {
                    return 0;
            }
            
            val_12 = Rilisoft.与丄丁丄丙丞下下丙.一丄丑丛丕丟万三丞(丗丙丆世丆丕万下丒:  88);
            val_15 = null;
            val_15 = null;
            int val_11 = Rilisoft.Offers.丌丟专丒丟丂万东丄.与丏丘丟丛与丘丏丑;
            val_11 = val_11 + val_12;
            System.DateTime val_10 = 0.AddSeconds(value:  (double)val_11);
            val_14 = val_10.dateData;
            return 0;
        }
        private System.Nullable<System.DateTime> 万丏三三丅丗世一丞(Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType 丑丒丛与下专且丗不)
        {
            ulong val_12;
            var val_14;
            var val_15;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            string val_3 = "end_" + 丑丒丛与下专且丗不.ToString().ToLower();
            if((Rilisoft.Offers.专下丞一丕下下丗与.七丏丙丐一丅丒丗丛<System.DateTime>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  val_3)) != false)
            {
                    System.DateTime val_5 = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.DateTime>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  val_3);
            }
            
            val_12 = "end";
            if((Rilisoft.Offers.专下丞一丕下下丗与.七丏丙丐一丅丒丗丛<System.DateTime>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "end")) != false)
            {
                    System.DateTime val_7 = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.DateTime>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "end");
            }
            
            if(((467062408 & 1) == 0) || ((467062392 & 1) == 0))
            {
                goto label_15;
            }
            
            val_12;
            if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_12}, t2:  new System.DateTime() {})) == false)
            {
                goto label_18;
            }
            
            goto label_19;
            label_15:
            if((467062352 & 1) == 0)
            {
                goto label_22;
            }
            
            goto label_22;
            label_18:
            label_19:
            label_22:
            val_14 = public System.Boolean System.Nullable<System.DateTime>::get_HasValue();
            if((467062368 & 1) == 0)
            {
                    return 0;
            }
            
            val_12 = Rilisoft.与丄丁丄丙丞下下丙.一丄丑丛丕丟万三丞(丗丙丆世丆丕万下丒:  88);
            val_15 = null;
            val_15 = null;
            int val_11 = Rilisoft.Offers.丌丟专丒丟丂万东丄.与丏丘丟丛与丘丏丑;
            val_11 = val_11 + val_12;
            System.DateTime val_10 = 0.AddSeconds(value:  (double)val_11);
            val_14 = val_10.dateData;
            return 0;
        }
        private Rilisoft.Offers.AdaptiveOfferItem 专丕丕丂丝丅丛丈东(System.Collections.Generic.IEnumerable<Rilisoft.Offers.AdaptiveOfferItem> 丄一丞丁丂东不丙丁, System.Collections.Generic.IEnumerable<Rilisoft.Offers.AdaptiveOfferItem> 丕丏丒业东丕上丟丘, Rilisoft.Offers.AdaptiveOfferItem.丂丘丛下丆一丕丂丅 丟丒且一专丟丙下一)
        {
            var val_13;
            System.Collections.Generic.IEnumerable<TSource> val_48;
            System.Collections.Generic.IEnumerable<TSource> val_49;
            var val_51;
            System.Func<CategoryNames, System.Boolean> val_53;
            var val_54;
            System.Func<System.Int32, CategoryNames> val_56;
            var val_57;
            var val_60;
            var val_61;
            var val_63;
            System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean> val_65;
            var val_66;
            var val_67;
            var val_68;
            ItemRarity val_69;
            CategoryNames val_70;
            var val_71;
            System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Int32> val_73;
            var val_74;
            var val_75;
            Rilisoft.Offers.AdaptiveOfferItem val_76;
            val_48 = 丕丏丒业东丕上丟丘;
            val_49 = 丄一丞丁丂东不丙丁;
            if((val_48 == null) || ((System.Linq.Enumerable.Any<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_48)) == false))
            {
                goto label_155;
            }
            
            System.Collections.Generic.List<CategoryNames> val_2 = new System.Collections.Generic.List<CategoryNames>();
            if((val_49 == null) || ((System.Linq.Enumerable.Any<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_49)) == false))
            {
                goto label_4;
            }
            
            var val_50 = 0;
            val_50 = val_50 + 1;
            goto label_8;
            label_4:
            val_48 = 0;
            label_70:
            label_72:
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_4 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            val_51 = null;
            val_51 = null;
            val_53 = 丌丟专丒丟丂万东丄.<>c.<>9__35_0;
            if(val_53 == null)
            {
                    System.Func<CategoryNames, System.Boolean> val_5 = null;
                val_53 = val_5;
                val_5 = new System.Func<CategoryNames, System.Boolean>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌丟专丒丟丂万东丄.<>c::丗世丅丈与丂丝上下(CategoryNames 丁丂专业丁丅丅丈丙));
                丌丟专丒丟丂万东丄.<>c.<>9__35_0 = val_53;
            }
            
            System.Collections.Generic.List<TSource> val_7 = System.Linq.Enumerable.ToList<CategoryNames>(source:  System.Linq.Enumerable.Where<CategoryNames>(source:  val_4.丕七丝万丈三专丄七, predicate:  val_5));
            Progress.AdaptiveProgress val_8 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            val_54 = null;
            val_54 = null;
            val_56 = 丌丟专丒丟丂万东丄.<>c.<>9__35_1;
            if(val_56 == null)
            {
                    System.Func<System.Int32, CategoryNames> val_9 = null;
                val_56 = val_9;
                val_9 = new System.Func<System.Int32, CategoryNames>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  CategoryNames 丌丟专丒丟丂万东丄.<>c::世丂东丝不三丂丂丟(int 七丞丙丒三丕且丌丟));
                丌丟专丒丟丂万东丄.<>c.<>9__35_1 = val_56;
            }
            
            val_7.AddRange(collection:  System.Linq.Enumerable.Select<System.Int32, CategoryNames>(source:  val_8.Weapons_LastViewedCategoryes, selector:  val_9));
            List.Enumerator<T> val_11 = val_2.GetEnumerator();
            label_31:
            if((467326992 & 1) == 0)
            {
                goto label_27;
            }
            
            int val_14 = val_13.丙东专丂世丈丏丁丂();
            if((val_7.Contains(item:  val_14)) == false)
            {
                goto label_31;
            }
            
            bool val_16 = val_7.Remove(item:  val_14);
            goto label_31;
            label_27:
            val_57 = 0 + 1;
            mem2[0] = 287;
            goto label_32;
            label_8:
            System.Collections.Generic.IEnumerator<T> val_18 = val_49.GetEnumerator();
            label_51:
            var val_51 = 0;
            val_51 = val_51 + 1;
            if(val_18.MoveNext() == false)
            {
                goto label_38;
            }
            
            var val_52 = 0;
            val_52 = val_52 + 1;
            System.Nullable<CategoryNames> val_25 = val_18.Current.Items.Item[0].Category;
            if((467327016 & 1) == 0)
            {
                goto label_51;
            }
            
            if((val_2.Contains(item:  val_25.HasValue)) == true)
            {
                goto label_51;
            }
            
            val_2.Add(item:  val_25.HasValue);
            goto label_51;
            label_38:
            val_60 = 0;
            val_61 = 0;
            if(val_18 == null)
            {
                
            }
            else
            {
                    var val_53 = 0;
                val_53 = val_53 + 1;
                val_18.Dispose();
            }
            
            if( != 1)
            {
                    if(120 == 120)
            {
                goto label_70;
            }
            
            }
            
            if( == false)
            {
                goto label_72;
            }
            
            goto label_72;
            label_32:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( == 1) || (120 != 287))
            {
                goto label_77;
            }
            
            var val_54 = 0;
            val_54 = val_54 ^ 0;
            val_57 =  + val_54;
            if(val_49 != null)
            {
                goto label_78;
            }
            
            goto label_81;
            label_77:
            if( != false)
            {
                    val_48 = 0;
            }
            
            if(val_49 == null)
            {
                goto label_81;
            }
            
            label_78:
            val_63 = null;
            val_63 = null;
            val_65 = 丌丟专丒丟丂万东丄.<>c.<>9__35_2;
            if(val_65 == null)
            {
                    System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean> val_28 = null;
                val_65 = val_28;
                val_28 = new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌丟专丒丟丂万东丄.<>c::丁丒丒七专丞丆丗丂(Rilisoft.Offers.AdaptiveOfferItem 七丞丙丒三丕且丌丟));
                丌丟专丒丟丂万东丄.<>c.<>9__35_2 = val_65;
            }
            
            val_66 = System.Linq.Enumerable.Count<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_49, predicate:  val_28);
            goto label_87;
            label_81:
            val_66 = 0;
            label_87:
            System.Collections.Generic.List<ItemRarity> val_30 = null;
            val_49 = val_30;
            val_30 = new System.Collections.Generic.List<ItemRarity>();
            val_67 = 1152921539147147184;
            if((val_66 & 1) == 0)
            {
                    val_30.Add(item:  4);
                val_68 = public System.Void System.Collections.Generic.List<ItemRarity>::Add(ItemRarity item);
                val_69 = 5;
            }
            else
            {
                    val_30.Add(item:  5);
                val_68 = public System.Void System.Collections.Generic.List<ItemRarity>::Add(ItemRarity item);
                val_69 = 4;
            }
            
            val_30.Add(item:  val_69);
            List.Enumerator<T> val_31 = val_30.GetEnumerator();
            goto label_140;
            label_141:
            new 丌丟专丒丟丂万东丄.丑丗东丞三且丂丄丒() = new 丌丟专丒丟丂万东丄.丑丗东丞三且丂丄丒();
            .东东世丝业丝一丂丄 = val_13.丙东专丂世丈丏丁丂();
            System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean> val_34 = new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean>(object:  new 丌丟专丒丟丂万东丄.丑丗东丞三且丂丄丒(), method:  System.Boolean 丌丟专丒丟丂万东丄.丑丗东丞三且丂丄丒::丈一丂丌专丞与丝丘(Rilisoft.Offers.AdaptiveOfferItem 七丞丙丒三丕且丌丟));
            List.Enumerator<T> val_36 = val_18.GetEnumerator();
            label_109:
            if((467326992 & 1) == 0)
            {
                goto label_97;
            }
            
            new 丌丟专丒丟丂万东丄.丌东丙世丑丝丗下丈() = new 丌丟专丒丟丂万东丄.丌东丙世丑丝丗下丈();
            val_70 = val_13.丙东专丂世丈丏丁丂();
            if(new 丌丟专丒丟丂万东丄.丌东丙世丑丝丗下丈() == null)
            {
                goto label_98;
            }
            
            .丙丑丕丂下丏一丁专 = val_70;
            if(val_2 != null)
            {
                goto label_101;
            }
            
            goto label_100;
            label_98:
            val_49 = 16;
            mem[16] = val_70;
            val_70 = mem[16];
            if(val_2 != null)
            {
                goto label_101;
            }
            
            label_100:
            label_101:
            if((val_2.Contains(item:  val_70)) == true)
            {
                goto label_109;
            }
            
            System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean> val_40 = new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean>(object:  new 丌丟专丒丟丂万东丄.丌东丙世丑丝丗下丈(), method:  System.Boolean 丌丟专丒丟丂万东丄.丌东丙世丑丝丗下丈::不与且不业业丕丐丈(Rilisoft.Offers.AdaptiveOfferItem 下丅丙一丂丗丅丝七));
            System.Collections.Generic.IEnumerable<TSource> val_41 = System.Linq.Enumerable.Where<Rilisoft.Offers.AdaptiveOfferItem>(source:  System.Linq.Enumerable.Where<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_48, predicate:  null), predicate:  null);
            if((System.Linq.Enumerable.Any<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_41)) == false)
            {
                goto label_109;
            }
            
            val_71 = null;
            val_71 = null;
            val_73 = 丌丟专丒丟丂万东丄.<>c.<>9__35_5;
            if(val_73 == null)
            {
                    val_73 = null;
                val_73 = new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Int32>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丌丟专丒丟丂万东丄.<>c::丝丅不业丁丙丙七丟(Rilisoft.Offers.AdaptiveOfferItem 下丅丙一丂丗丅丝七));
                丌丟专丒丟丂万东丄.<>c.<>9__35_5 = val_73;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_44 = System.Linq.Enumerable.OrderByDescending<Rilisoft.Offers.AdaptiveOfferItem, System.Int32>(source:  val_41, keySelector:  null);
            if((System.Linq.Enumerable.Any<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_44)) == false)
            {
                goto label_109;
            }
            
            Rilisoft.Offers.AdaptiveOfferItem val_46 = System.Linq.Enumerable.First<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_44);
            System.Nullable<CategoryNames> val_49 = val_46.Items.Item[0].Category;
            val_2.Add(item:  val_49.HasValue);
            val_74 = val_57 + 1;
            val_67 = ;
            mem2[0] = 671;
            goto label_115;
            label_97:
            val_74 = val_57 + 1;
            val_67 = ;
            mem2[0] = 641;
            label_115:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_74 == 1)
            {
                goto label_136;
            }
            
            if((467326864 + (((val_60 + (0 ^ 0)) + 1)) << 2) == 641)
            {
                goto label_137;
            }
            
            if((467326864 + (((val_60 + (0 ^ 0)) + 1)) << 2) == 671)
            {
                goto label_138;
            }
            
            label_136:
            val_48 = 0;
            if( == 0)
            {
                goto label_140;
            }
            
            val_48 = 0;
            goto label_140;
            label_137:
            var val_55 = 0;
            val_55 = val_55 ^ (val_74 >> 31);
            val_57 = val_74 + val_55;
            val_48 = ;
            label_140:
            if((467326960 & 1) != 0)
            {
                goto label_141;
            }
            
            val_75 = val_57 + 1;
            mem2[0] = 669;
            goto label_142;
            label_138:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_76 = val_46;
            return (Rilisoft.Offers.AdaptiveOfferItem)val_76;
            label_142:
            val_76 = val_46;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_74 == 1)
            {
                goto label_152;
            }
            
            if((467326864 + (((val_60 + (0 ^ 0)) + 1)) << 2) == 669)
            {
                goto label_155;
            }
            
            if((467326864 + (((val_60 + (0 ^ 0)) + 1)) << 2) == 671)
            {
                    return (Rilisoft.Offers.AdaptiveOfferItem)val_76;
            }
            
            label_152:
            label_155:
            val_76 = 0;
            return (Rilisoft.Offers.AdaptiveOfferItem)val_76;
        }
        private Rilisoft.Offers.AdaptiveOfferItem 一丗业丟丝下丑丏与(System.Collections.Generic.IEnumerable<Rilisoft.Offers.AdaptiveOfferItem> 丄一丞丁丂东不丙丁, System.Collections.Generic.IEnumerable<Rilisoft.Offers.AdaptiveOfferItem> 丕丏丒业东丕上丟丘, Rilisoft.Offers.AdaptiveOfferItem.丂丘丛下丆一丕丂丅 丟丒且一专丟丙下一)
        {
            var val_7;
            .丟丒且一专丟丙下一 = 丟丒且一专丟丙下一;
            System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<Rilisoft.Offers.AdaptiveOfferItem>(source:  System.Linq.Enumerable.Where<Rilisoft.Offers.AdaptiveOfferItem>(source:  丕丏丒业东丕上丟丘, predicate:  new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean>(object:  new 丌丟专丒丟丂万东丄.且且丛丌丝三丏丙丛(), method:  System.Boolean 丌丟专丒丟丂万东丄.且且丛丌丝三丏丙丛::丗东丝下丐东丁丁一(Rilisoft.Offers.AdaptiveOfferItem 七丞丙丒三丕且丌丟))));
            if(val_4 == null)
            {
                    return (Rilisoft.Offers.AdaptiveOfferItem)val_7;
            }
            
            if((System.Linq.Enumerable.Any<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_4)) != false)
            {
                    Rilisoft.Offers.AdaptiveOfferItem val_6 = System.Linq.Enumerable.First<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_4);
                return (Rilisoft.Offers.AdaptiveOfferItem)val_7;
            }
            
            val_7 = 0;
            return (Rilisoft.Offers.AdaptiveOfferItem)val_7;
        }
        private Rilisoft.Offers.AdaptiveOfferItem 丂丗丂丆丄丁丛七丏(System.Collections.Generic.IEnumerable<Rilisoft.Offers.AdaptiveOfferItem> 丄一丞丁丂东不丙丁, System.Collections.Generic.IEnumerable<Rilisoft.Offers.AdaptiveOfferItem> 丕丏丒业东丕上丟丘, Rilisoft.Offers.AdaptiveOfferItem.丂丘丛下丆一丕丂丅 丟丒且一专丟丙下一)
        {
            var val_11;
            var val_93;
            System.Collections.Generic.IEnumerable<Rilisoft.Offers.AdaptiveOfferItem> val_94;
            var val_95;
            var val_96;
            var val_97;
            System.Func<SkippedItem, System.Boolean> val_99;
            CategoryNames val_100;
            var val_108;
            var val_109;
            var val_111;
            System.Func<SkippedItem, System.Boolean> val_113;
            var val_114;
            var val_115;
            var val_116;
            var val_120;
            System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Int32> val_122;
            var val_123;
            System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean> val_125;
            val_94 = 丄一丞丁丂东不丙丁;
            val_95 = 0;
            if((System.Linq.Enumerable.Any<Rilisoft.Offers.AdaptiveOfferItem>(source:  丕丏丒业东丕上丟丘)) == false)
            {
                    return (Rilisoft.Offers.AdaptiveOfferItem);
            }
            
            val_96 = 1152921505501892608;
            Progress.AdaptiveProgress val_3 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            val_97 = null;
            val_97 = null;
            val_99 = 丌丟专丒丟丂万东丄.<>c.<>9__37_0;
            if(val_99 == null)
            {
                    System.Func<SkippedItem, System.Boolean> val_4 = null;
                val_99 = val_4;
                val_4 = new System.Func<SkippedItem, System.Boolean>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌丟专丒丟丂万东丄.<>c::一丑丄丝丕丘丄丈业(Progress.AdaptiveProgress.SkippedItem 专上丘丈丁世一丐且));
                丌丟专丒丟丂万东丄.<>c.<>9__37_0 = val_99;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_5 = System.Linq.Enumerable.Where<SkippedItem>(source:  val_3.SkippedItems, predicate:  val_4);
            if((System.Linq.Enumerable.Count<SkippedItem>(source:  val_5)) < (System.Linq.Enumerable.Count<Rilisoft.Offers.AdaptiveOfferItem>(source:  丕丏丒业东丕上丟丘)))
            {
                goto label_23;
            }
            
            List.Enumerator<T> val_9 = System.Linq.Enumerable.ToList<SkippedItem>(source:  val_5).GetEnumerator();
            label_17:
            if((468053008 & 1) == 0)
            {
                goto label_12;
            }
            
            Progress.AdaptiveProgress val_13 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            bool val_14 = val_13.SkippedItems.Remove(item:  val_11.丐丏七丌丕丗业且上());
            goto label_17;
            label_12:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_23:
            .不世业丘丛丌丌丟丑 = new System.Collections.Generic.List<CategoryNames>();
            System.Nullable<CategoryNames> val_16 = Rilisoft.Offers.丙东丄万万丑东丘丅.丏上丐丘七丙下丑业();
            val_100 = 1152921536767005376;
            if((468053000 & 1) != 0)
            {
                    System.Nullable<CategoryNames> val_17 = Rilisoft.Offers.丙东丄万万丑东丘丅.丏上丐丘七丙下丑业();
                (丌丟专丒丟丂万东丄.丟丑不七不丆业丐丛)[1152921543729662064].不世业丘丛丌丌丟丑.Add(item:  val_17.HasValue);
            }
            
            var val_100 = 0;
            val_100 = val_100 + 1;
            System.Collections.Generic.IEnumerator<T> val_19 = val_94.GetEnumerator();
            label_55:
            var val_101 = 0;
            val_101 = val_101 + 1;
            if(val_19.MoveNext() == false)
            {
                goto label_41;
            }
            
            var val_102 = 0;
            val_102 = val_102 + 1;
            System.Nullable<CategoryNames> val_26 = val_19.Current.Items.Item[0].Category;
            if((468052992 & 1) == 0)
            {
                goto label_55;
            }
            
            if(((丌丟专丒丟丂万东丄.丟丑不七不丆业丐丛)[1152921543729662064].不世业丘丛丌丌丟丑.Contains(item:  val_26.HasValue)) == true)
            {
                goto label_55;
            }
            
            (丌丟专丒丟丂万东丄.丟丑不七不丆业丐丛)[1152921543729662064].不世业丘丛丌丌丟丑.Add(item:  val_26.HasValue);
            goto label_55;
            label_41:
            val_93 = 0;
            if(val_19 == null)
            {
                
            }
            else
            {
                    var val_103 = 0;
                val_103 = val_103 + 1;
                val_19.Dispose();
            }
            
            if(( != 1) && (303 == 303))
            {
                    val_93 = 0;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_30 = System.Linq.Enumerable.Where<Rilisoft.Offers.AdaptiveOfferItem>(source:  丕丏丒业东丕上丟丘, predicate:  new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean>(object:  new 丌丟专丒丟丂万东丄.丟丑不七不丆业丐丛(), method:  System.Boolean 丌丟专丒丟丂万东丄.丟丑不七不丆业丐丛::东东三丘丂与东丟丄(Rilisoft.Offers.AdaptiveOfferItem 七丞丙丒三丕且丌丟)));
            if((System.Linq.Enumerable.Any<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_30)) != false)
            {
                    丌丟专丒丟丂万东丄.上丈丕专丁业丁丅丏 val_32 = new 丌丟专丒丟丂万东丄.上丈丕专丁业丁丅丏();
                .丄且丙丂业七丂丛丝 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
                var val_104 = 0;
                val_104 = val_104 + 1;
            }
            else
            {
                    val_95 = 0;
                return (Rilisoft.Offers.AdaptiveOfferItem);
            }
            
            System.Collections.Generic.IEnumerator<T> val_35 = val_30.GetEnumerator();
            label_106:
            var val_105 = 0;
            val_105 = val_105 + 1;
            if(val_35.MoveNext() == false)
            {
                goto label_91;
            }
            
            var val_106 = 0;
            val_106 = val_106 + 1;
            Rilisoft.OfferItem val_41 = val_35.Current.Items.Item[0];
            if(((丌丟专丒丟丂万东丄.上丈丕专丁业丁丅丏)[1152921543729735856].丄且丙丂业七丂丛丝.ContainsKey(key:  val_41.Id)) == true)
            {
                goto label_106;
            }
            
            (丌丟专丒丟丂万东丄.上丈丕专丁业丁丅丏)[1152921543729735856].丄且丙丂业七丂丛丝.Add(key:  val_41.Id, value:  val_41.PartsLeft);
            goto label_106;
            label_91:
            val_108 = 303;
            val_109 = 1;
            mem[307] = 452;
            if(val_35 == null)
            {
                
            }
            else
            {
                    var val_107 = 0;
                val_107 = val_107 + 1;
                val_35.Dispose();
            }
            
            if((val_109 != 1) && (mem[307] == 452))
            {
                    var val_108 = 0;
                val_108 = val_108 ^ 0;
                val_109 = val_109 + val_108;
            }
            
            .丌七丞下不且丄世一 = System.Linq.Enumerable.Max(source:  (丌丟专丒丟丂万东丄.上丈丕专丁业丁丅丏)[1152921543729735856].丄且丙丂业七丂丛丝.Values);
            .丑丟丒上丕上三丂丁 = new System.Collections.Generic.List<CategoryNames>();
            Progress.AdaptiveProgress val_50 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            val_111 = null;
            val_111 = null;
            val_113 = 丌丟专丒丟丂万东丄.<>c.<>9__37_3;
            if(val_113 == null)
            {
                    System.Func<SkippedItem, System.Boolean> val_51 = null;
                val_113 = val_51;
                val_51 = new System.Func<SkippedItem, System.Boolean>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌丟专丒丟丂万东丄.<>c::丑丌丈丁丌丄丄且丘(Progress.AdaptiveProgress.SkippedItem 下上丐东丛丗丐且丑));
                丌丟专丒丟丂万东丄.<>c.<>9__37_3 = val_113;
            }
            
            SkippedItem val_52 = System.Linq.Enumerable.LastOrDefault<SkippedItem>(source:  val_50.SkippedItems, predicate:  val_51);
            if(val_52 == null)
            {
                goto label_147;
            }
            
            int val_55 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_52.OfferItemId.丐丙世七丅丅丐下丙());
            if((val_55 & 2147483648) != 0)
            {
                goto label_147;
            }
            
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_56 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            int val_57 = val_56.丕七丝万丈三专丄七.IndexOf(item:  val_55);
            if((val_57 & 2147483648) != 0)
            {
                goto label_147;
            }
            
            val_114 = 0;
            goto label_148;
            label_160:
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_58 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            int val_59 = val_58.丕七丝万丈三专丄七.Count;
            int val_60 = val_57 + val_114;
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_63 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            val_100 = val_63.丕七丝万丈三专丄七.Item[val_60 - ((val_60 / val_59) * val_59)];
            (丌丟专丒丟丂万东丄.上丈丕专丁业丁丅丏)[1152921543729735856].丑丟丒上丕上三丂丁.Add(item:  val_100);
            val_114 = 1;
            label_148:
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_65 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            if(val_114 < val_65.丕七丝万丈三专丄七.Count)
            {
                goto label_160;
            }
            
            label_147:
            val_115 = val_109;
            if((丌丟专丒丟丂万东丄.上丈丕专丁业丁丅丏)[1152921543729735856].丑丟丒上丕上三丂丁.Count <= 0)
            {
                    Rilisoft.Offers.东下上东丅丂丘丗丙 val_68 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
                .丑丟丒上丕上三丂丁 = System.Linq.Enumerable.ToList<CategoryNames>(source:  val_68.丕七丝万丈三专丄七);
            }
            
            if((System.Linq.Enumerable.Any<System.Int32>(source:  (丌丟专丒丟丂万东丄.上丈丕专丁业丁丅丏)[1152921543729735856].丄且丙丂业七丂丛丝.Values, predicate:  new System.Func<System.Int32, System.Boolean>(object:  val_32, method:  System.Boolean 丌丟专丒丟丂万东丄.上丈丕专丁业丁丅丏::与东丅丒一不与三丈(int 业下丌下三丕丙丌下)))) != false)
            {
                    System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Int32> val_73 = null;
                val_93 = 1152921543728846256;
                val_73 = new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Int32>(object:  val_32, method:  System.Int32 丌丟专丒丟丂万东丄.上丈丕专丁业丁丅丏::丅且万三七丒丝丝丟(Rilisoft.Offers.AdaptiveOfferItem 七丞丙丒三丕且丌丟));
                val_94 = System.Linq.Enumerable.OrderBy<Rilisoft.Offers.AdaptiveOfferItem, System.Int32>(source:  val_30, keySelector:  val_73);
                val_95 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.Offers.AdaptiveOfferItem>(source:  System.Linq.Enumerable.ThenBy<Rilisoft.Offers.AdaptiveOfferItem, System.Int32>(source:  val_94, keySelector:  new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Int32>(object:  val_32, method:  System.Int32 丌丟专丒丟丂万东丄.上丈丕专丁业丁丅丏::三丂万丗且且丗丙与(Rilisoft.Offers.AdaptiveOfferItem 七丞丙丒三丕且丌丟))));
                return (Rilisoft.Offers.AdaptiveOfferItem);
            }
            
            if((val_94 == 0) || ((System.Linq.Enumerable.Any<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_94)) == false))
            {
                goto label_215;
            }
            
            var val_111 = val_94;
            if((丄一丞丁丂东不丙丁 + 286) == 0)
            {
                goto label_174;
            }
            
            var val_109 = 丄一丞丁丂东不丙丁 + 176;
            var val_110 = 0;
            val_109 = val_109 + 8;
            label_173:
            if(((丄一丞丁丂东不丙丁 + 176 + 8) + -8) == null)
            {
                goto label_172;
            }
            
            val_110 = val_110 + 1;
            val_109 = val_109 + 16;
            if(val_110 < (丄一丞丁丂东不丙丁 + 286))
            {
                goto label_173;
            }
            
            goto label_174;
            label_172:
            val_111 = val_111 + (((丄一丞丁丂东不丙丁 + 176 + 8)) << 4);
            val_116 = val_111 + 296;
            label_174:
            System.Collections.Generic.IEnumerator<T> val_79 = val_94.GetEnumerator();
            label_194:
            var val_112 = 0;
            val_112 = val_112 + 1;
            if(val_79.MoveNext() == false)
            {
                goto label_180;
            }
            
            var val_113 = 0;
            val_113 = val_113 + 1;
            System.Nullable<CategoryNames> val_86 = val_79.Current.Items.Item[0].Category;
            if((468052984 & 1) == 0)
            {
                goto label_194;
            }
            
            if(((丌丟专丒丟丂万东丄.上丈丕专丁业丁丅丏)[1152921543729735856].丑丟丒上丕上三丂丁.Contains(item:  val_86.HasValue)) == false)
            {
                goto label_194;
            }
            
            bool val_88 = (丌丟专丒丟丂万东丄.上丈丕专丁业丁丅丏)[1152921543729735856].丑丟丒上丕上三丂丁.Remove(item:  val_86.HasValue);
            goto label_194;
            label_180:
            val_115 = val_115 + 1;
            mem2[0] = 926;
            if(val_79 == null)
            {
                
            }
            else
            {
                    var val_114 = 0;
                val_114 = val_114 + 1;
                val_79.Dispose();
            }
            
            if((val_115 != 1) && ((303 + ((val_115 + 1)) << 2) == 926))
            {
                    var val_115 = 0;
                val_115 = val_115 ^ (val_115 >> 31);
                val_115 = val_115 + val_115;
            }
            
            label_215:
            List.Enumerator<T> val_90 = (丌丟专丒丟丂万东丄.上丈丕专丁业丁丅丏)[1152921543729735856].丑丟丒上丕上三丂丁.GetEnumerator();
            val_100 = 1152921505502531584;
            val_96 = 1152921543729561008;
            label_232:
            if((468052960 & 1) == 0)
            {
                goto label_219;
            }
            
            new 丌丟专丒丟丂万东丄.业下丈丕丅丞不且丟() = new 丌丟专丒丟丂万东丄.业下丈丕丅丞不且丟();
            .丙丑丕丂下丏一丁专 = val_11.丙东专丂世丈丏丁丂();
            System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean> val_93 = new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean>(object:  new 丌丟专丒丟丂万东丄.业下丈丕丅丞不且丟(), method:  System.Boolean 丌丟专丒丟丂万东丄.业下丈丕丅丞不且丟::丏不下东三丆丐丆丑(Rilisoft.Offers.AdaptiveOfferItem 七丞丙丒三丕且丌丟));
            System.Collections.Generic.IEnumerable<TSource> val_94 = System.Linq.Enumerable.Where<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_30, predicate:  null);
            if((System.Linq.Enumerable.Any<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_94)) == false)
            {
                goto label_232;
            }
            
            val_120 = null;
            val_120 = null;
            val_122 = 丌丟专丒丟丂万东丄.<>c.<>9__37_8;
            if(val_122 == null)
            {
                    val_122 = null;
                val_122 = new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Int32>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丌丟专丒丟丂万东丄.<>c::丈丕丑丙三丅丘丅丌(Rilisoft.Offers.AdaptiveOfferItem 七丞丙丒三丕且丌丟));
                丌丟专丒丟丂万东丄.<>c.<>9__37_8 = val_122;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_97 = System.Linq.Enumerable.OrderByDescending<Rilisoft.Offers.AdaptiveOfferItem, System.Int32>(source:  val_94, keySelector:  null);
            val_123 = null;
            val_123 = null;
            val_125 = 丌丟专丒丟丂万东丄.<>c.<>9__37_9;
            if(val_125 == null)
            {
                    val_125 = null;
                val_125 = new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌丟专丒丟丂万东丄.<>c::一丒丈丝万丈专丐丆(Rilisoft.Offers.AdaptiveOfferItem 七丞丙丒三丕且丌丟));
                丌丟专丒丟丂万东丄.<>c.<>9__37_9 = val_125;
            }
            
            val_95 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_94, predicate:  null);
            if(val_95 == null)
            {
                goto label_232;
            }
            
            goto label_233;
            label_219:
            val_95 = 0;
            label_233:
            val_94 = 303;
            val_93 = val_115 + 1;
            mem2[0] = 1112;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_93 != 1)
            {
                    if(val_11 == 0)
            {
                    return (Rilisoft.Offers.AdaptiveOfferItem);
            }
            
                if((val_94 + (((val_115 + 1) + 1)) << 2) == 1112)
            {
                    return (Rilisoft.Offers.AdaptiveOfferItem);
            }
            
                return (Rilisoft.Offers.AdaptiveOfferItem);
            }
            
            if(val_11 != 0)
            {
                    return (Rilisoft.Offers.AdaptiveOfferItem);
            }
            
            return (Rilisoft.Offers.AdaptiveOfferItem);
        }
        private Rilisoft.Offers.AdaptiveOfferItem 丂丆万丒与丕丐丏丏(System.Collections.Generic.IEnumerable<Rilisoft.Offers.AdaptiveOfferItem> 丄一丞丁丂东不丙丁, System.Collections.Generic.IEnumerable<Rilisoft.Offers.AdaptiveOfferItem> 丕丏丒业东丕上丟丘, Rilisoft.Offers.AdaptiveOfferItem.丂丘丛下丆一丕丂丅 丟丒且一专丟丙下一)
        {
            var val_25;
            object val_36;
            var val_37;
            System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean> val_39;
            var val_40;
            System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean> val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            丌丟专丒丟丂万东丄.与丙丌丟一七下丏与 val_1 = null;
            val_36 = val_1;
            val_1 = new 丌丟专丒丟丂万东丄.与丙丌丟一七下丏与();
            .丟丒且一专丟丙下一 = 丟丒且一专丟丙下一;
            System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<Rilisoft.Offers.AdaptiveOfferItem>(source:  System.Linq.Enumerable.Where<Rilisoft.Offers.AdaptiveOfferItem>(source:  丕丏丒业东丕上丟丘, predicate:  new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean>(object:  val_1, method:  System.Boolean 丌丟专丒丟丂万东丄.与丙丌丟一七下丏与::世丄丂不一丅专丝世(Rilisoft.Offers.AdaptiveOfferItem 七丞丙丒三丕且丌丟))));
            if((val_4 == null) || ((System.Linq.Enumerable.Any<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_4)) == false))
            {
                goto label_3;
            }
            
            Progress.AdaptiveProgress val_6 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6.PreviousViewedPet)) == true)
            {
                goto label_15;
            }
            
            val_37 = null;
            val_37 = null;
            val_39 = 丌丟专丒丟丂万东丄.<>c.<>9__38_1;
            if(val_39 == null)
            {
                    System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean> val_8 = null;
                val_39 = val_8;
                val_8 = new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌丟专丒丟丂万东丄.<>c::丒丈世万丈丛丁丑万(Rilisoft.Offers.AdaptiveOfferItem 七丞丙丒三丕且丌丟));
                丌丟专丒丟丂万东丄.<>c.<>9__38_1 = val_39;
            }
            
            if((System.Linq.Enumerable.Any<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_4, predicate:  val_8)) == false)
            {
                goto label_15;
            }
            
            val_40 = null;
            val_40 = null;
            val_42 = 丌丟专丒丟丂万东丄.<>c.<>9__38_2;
            if(val_42 == null)
            {
                    System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean> val_10 = null;
                val_42 = val_10;
                val_10 = new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌丟专丒丟丂万东丄.<>c::上丞下丟丟丅东丗东(Rilisoft.Offers.AdaptiveOfferItem 七丞丙丒三丕且丌丟));
                丌丟专丒丟丂万东丄.<>c.<>9__38_2 = val_42;
            }
            
            val_43 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_4, predicate:  val_10);
            return (Rilisoft.Offers.AdaptiveOfferItem)val_43;
            label_3:
            val_43 = 0;
            return (Rilisoft.Offers.AdaptiveOfferItem)val_43;
            label_15:
            System.Collections.Generic.List<七下专丌丐丛丙丝不> val_12 = new System.Collections.Generic.List<七下专丌丐丛丙丝不>();
            Progress.AdaptiveProgress val_13 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            val_44 = null;
            val_44 = null;
            int val_14 = Rilisoft.Offers.不丒上丄业三与下丟.丟丟下丙丈丁下丐三.IndexOf(item:  val_13.PetsLastViewedOfferType);
            if((val_14 + 1) < 1)
            {
                goto label_28;
            }
            
            val_45 = 1;
            goto label_29;
            label_38:
            val_46 = null;
            val_46 = null;
            int val_16 = Rilisoft.Offers.不丒上丄业三与下丟.丟丟下丙丈丁下丐三.Count;
            int val_17 = val_14 + val_45;
            val_12.Add(item:  Rilisoft.Offers.不丒上丄业三与下丟.丟丟下丙丈丁下丐三.Item[val_17 - ((val_17 / val_16) * val_16)]);
            val_45 = 2;
            label_29:
            val_47 = null;
            val_47 = null;
            if(val_45 <= Rilisoft.Offers.不丒上丄业三与下丟.丟丟下丙丈丁下丐三.Count)
            {
                goto label_38;
            }
            
            label_28:
            if(val_12.Count <= 0)
            {
                goto label_40;
            }
            
            label_56:
            List.Enumerator<T> val_23 = val_12.GetEnumerator();
            label_51:
            if((468577872 & 1) == 0)
            {
                goto label_42;
            }
            
            new 丌丟专丒丟丂万东丄.丏丘丁丆丛丁七一且() = new 丌丟专丒丟丂万东丄.丏丘丁丆丛丁七一且();
            .万丗丅七丘丗与丈丑 = val_25.丙东专丂世丈丏丁丂();
            System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean> val_28 = new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean>(object:  new 丌丟专丒丟丂万东丄.丏丘丁丆丛丁七一且(), method:  System.Boolean 丌丟专丒丟丂万东丄.丏丘丁丆丛丁七一且::丙丝业七丑丝丞丐丙(Rilisoft.Offers.AdaptiveOfferItem 丞丟世丅世业丝丑丆));
            System.Collections.Generic.IEnumerable<TSource> val_29 = System.Linq.Enumerable.Where<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_4, predicate:  null);
            if((System.Linq.Enumerable.Any<Rilisoft.Offers.AdaptiveOfferItem>(source:  val_29)) == false)
            {
                goto label_51;
            }
            
            Rilisoft.Offers.AdaptiveOfferItem val_32 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.Offers.AdaptiveOfferItem>(source:  丞东丑专丛丆丄丝世.世一丟丞三丝不丑丆<Rilisoft.Offers.AdaptiveOfferItem>(丑东与丅丐丅丂丞业:  val_29, 丌丒丝东丌下丕丁丅:  1));
            Progress.AdaptiveProgress val_33 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            val_33.PreviousViewedPet = val_32.UniqueId;
            if(val_32 == null)
            {
                goto label_51;
            }
            
            goto label_52;
            label_40:
            val_48 = null;
            val_48 = null;
            if((System.Linq.Enumerable.ToList<七下专丌丐丛丙丝不>(source:  Rilisoft.Offers.不丒上丄业三与下丟.丟丟下丙丈丁下丐三)) != null)
            {
                goto label_56;
            }
            
            goto label_56;
            label_42:
            label_52:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (Rilisoft.Offers.AdaptiveOfferItem)val_43;
        }
        private Rilisoft.Offers.AdaptiveOfferItem 丝丟丙丟世世丞丕丑(System.Collections.Generic.IEnumerable<Rilisoft.Offers.AdaptiveOfferItem> 丄一丞丁丂东不丙丁, System.Collections.Generic.IEnumerable<Rilisoft.Offers.AdaptiveOfferItem> 丕丏丒业东丕上丟丘, Rilisoft.Offers.AdaptiveOfferItem.丂丘丛下丆一丕丂丅 丟丒且一专丟丙下一)
        {
            var val_3;
            if((System.Linq.Enumerable.Any<Rilisoft.Offers.AdaptiveOfferItem>(source:  丕丏丒业东丕上丟丘)) != false)
            {
                    Rilisoft.Offers.AdaptiveOfferItem val_2 = System.Linq.Enumerable.First<Rilisoft.Offers.AdaptiveOfferItem>(source:  丕丏丒业东丕上丟丘);
                return (Rilisoft.Offers.AdaptiveOfferItem)val_3;
            }
            
            val_3 = 0;
            return (Rilisoft.Offers.AdaptiveOfferItem)val_3;
        }
        private void 下丌下且三丏丂丐下(System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem> 三丆丙丙东下丄专七)
        {
            var val_16;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            object val_31;
            var val_32;
            System.Func<Rilisoft.OfferItem, System.String> val_34;
            var val_35;
            System.Func<System.String, System.String, System.String> val_37;
            string val_38;
            var val_39;
            System.Func<Rilisoft.OfferItem, System.String> val_41;
            var val_42;
            System.Func<System.String, System.String, System.String> val_44;
            val_27 = this;
            val_28 = 1152921537962617104;
            val_29 = 0;
            val_30 = 0;
            goto label_1;
            label_25:
            丌丟专丒丟丂万东丄.丄丁丒丄与丁七丆一 val_1 = null;
            val_31 = val_1;
            val_1 = new 丌丟专丒丟丂万东丄.丄丁丒丄与丁七丆一();
            Rilisoft.业丙丘丆东丈丕丂丄 val_2 = this.且丑不丛丏丏丐丄丐.Item[0];
            Progress.OfferProgress val_3 = val_2.业丑丁丆丕丆丂丅万();
            if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_3.PreparedItems)) == false)
            {
                goto label_5;
            }
            
            Progress.OfferProgress val_5 = val_2.业丑丁丆丕丆丂丅万();
            val_32 = null;
            val_32 = null;
            val_34 = 丌丟专丒丟丂万东丄.<>c.<>9__40_0;
            if(val_34 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.String> val_6 = null;
                val_34 = val_6;
                val_6 = new System.Func<Rilisoft.OfferItem, System.String>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丌丟专丒丟丂万东丄.<>c::专七丟世丆专世丆专(Rilisoft.OfferItem 丛丅丐丒丈不丅丐丄));
                丌丟专丒丟丂万东丄.<>c.<>9__40_0 = val_34;
            }
            
            val_35 = null;
            val_35 = null;
            val_37 = 丌丟专丒丟丂万东丄.<>c.<>9__40_1;
            if(val_37 == null)
            {
                    System.Func<System.String, System.String, System.String> val_8 = null;
                val_37 = val_8;
                val_8 = new System.Func<System.String, System.String, System.String>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丌丟专丒丟丂万东丄.<>c::三专丏丘上下业丈上(string 与丕丁三万专世不丅, string 丏丛与丅丛丌万专丌));
                丌丟专丒丟丂万东丄.<>c.<>9__40_1 = val_37;
            }
            
            val_28 = 1152921537962617104;
            val_38 = System.Linq.Enumerable.Aggregate<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, System.String>(source:  val_5.PreparedItems, selector:  val_6), func:  val_8);
            if(val_31 != null)
            {
                goto label_20;
            }
            
            goto label_19;
            label_5:
            val_38 = 0;
            if(val_31 != null)
            {
                goto label_20;
            }
            
            label_19:
            label_20:
            .丝专不丒三丄专丙丘 = val_38;
            if((System.Linq.Enumerable.All<Rilisoft.Offers.AdaptiveOfferItem>(source:  三丆丙丙东下丄专七, predicate:  new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean>(object:  val_1, method:  System.Boolean 丌丟专丒丟丂万东丄.丄丁丒丄与丁七丆一::东丟丘东上丕丗丒丄(Rilisoft.Offers.AdaptiveOfferItem 下上丐东丛丗丐且丑)))) != false)
            {
                    val_31 = this.且丑不丛丏丏丐丄丐;
                bool val_12 = val_31.Remove(item:  val_2);
                val_30 = 1;
            }
            
            val_29 = 0;
            label_1:
            if(val_29 < this.且丑不丛丏丏丐丄丐.Count)
            {
                goto label_25;
            }
            
            List.Enumerator<T> val_14 = 三丆丙丙东下丄专七.GetEnumerator();
            label_42:
            if((469046608 & 1) == 0)
            {
                goto label_27;
            }
            
            string val_17 = val_16.丐丏七丌丕丗业且上();
            new 丌丟专丒丟丂万东丄.业丕丐不下下上业万() = new 丌丟专丒丟丂万东丄.业丕丐不下下上业万();
            val_39 = null;
            val_39 = null;
            val_41 = 丌丟专丒丟丂万东丄.<>c.<>9__40_5;
            if(val_41 == null)
            {
                    val_41 = null;
                val_41 = new System.Func<Rilisoft.OfferItem, System.String>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丌丟专丒丟丂万东丄.<>c::丞丒丘丅丄丌丐丗丁(Rilisoft.OfferItem 丛丅丐丒丈不丅丐丄));
                丌丟专丒丟丂万东丄.<>c.<>9__40_5 = val_41;
            }
            
            val_42 = null;
            val_42 = null;
            val_44 = 丌丟专丒丟丂万东丄.<>c.<>9__40_6;
            if(val_44 == null)
            {
                    val_44 = null;
                val_44 = new System.Func<System.String, System.String, System.String>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丌丟专丒丟丂万东丄.<>c::丗业丌丈丈丕丒万丕(string 与丕丁三万专世不丅, string 丏丛与丅丛丌万专丌));
                丌丟专丒丟丂万东丄.<>c.<>9__40_6 = val_44;
            }
            
            .丞丅上丏丂且下丅与 = System.Linq.Enumerable.Aggregate<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, System.String>(source:  val_17.Items, selector:  null), func:  null);
            System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_24 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  new 丌丟专丒丟丂万东丄.业丕丐不下下上业万(), method:  System.Boolean 丌丟专丒丟丂万东丄.业丕丐不下下上业万::丝与丑丝丐丐丈丐丄(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            Rilisoft.业丙丘丆东丈丕丂丄 val_25 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  null);
            if(val_25 != null)
            {
                goto label_42;
            }
            
            this.且丑不丛丏丏丐丄丐.Add(item:  val_25.丁与且丅丏下丌且与(下上丐东丛丗丐且丑:  val_17));
            goto label_42;
            label_27:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_30 & 1) == 0)
            {
                    return;
            }
            
            BalanceController.丏丝丆东上丙丑丅不(丆丄丘丂业丛七丁且:  false);
        }
        internal void 东丌下丅丟丐下丙丏(bool 丆丄丘丂业丛七丁且)
        {
            goto label_1;
            label_6:
            bool val_2 = this.且丑不丛丏丏丐丄丐.Remove(item:  this.且丑不丛丏丏丐丄丐.Item[0]);
            label_1:
            if(this.且丑不丛丏丏丐丄丐.Count > 0)
            {
                goto label_6;
            }
            
            BalanceController.丏丝丆东上丙丑丅不(丆丄丘丂业丛七丁且:  丆丄丘丂业丛七丁且);
        }
        private Rilisoft.业丙丘丆东丈丕丂丄 丁与且丅丏下丌且与(Rilisoft.Offers.AdaptiveOfferItem 下上丐东丛丗丐且丑)
        {
            var val_62;
            System.Func<Rilisoft.OfferItem, System.String> val_64;
            var val_65;
            System.Func<System.String, System.String, System.String> val_67;
            int val_68;
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_69;
            int val_70;
            Progress.OfferProgress val_71;
            object[] val_1 = new object[4];
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_2 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            val_1[0] = val_2.丌丗丏丝丈丒一一丞;
            val_1[1] = 下上丐东丛丗丐且丑.Module;
            val_1[2] = 下上丐东丛丗丐且丑.Real;
            val_62 = null;
            val_62 = null;
            val_64 = 丌丟专丒丟丂万东丄.<>c.<>9__42_0;
            if(val_64 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.String> val_6 = null;
                val_64 = val_6;
                val_6 = new System.Func<Rilisoft.OfferItem, System.String>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丌丟专丒丟丂万东丄.<>c::丑下与万且丁丘丂万(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                丌丟专丒丟丂万东丄.<>c.<>9__42_0 = val_64;
            }
            
            val_65 = null;
            val_65 = null;
            val_67 = 丌丟专丒丟丂万东丄.<>c.<>9__42_1;
            if(val_67 == null)
            {
                    System.Func<System.String, System.String, System.String> val_8 = null;
                val_67 = val_8;
                val_8 = new System.Func<System.String, System.String, System.String>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丌丟专丒丟丂万东丄.<>c::丒一丕丂七丘丗专三(string 与丕丁三万专世不丅, string 丏丛与丅丛丌万专丌));
                丌丟专丒丟丂万东丄.<>c.<>9__42_1 = val_67;
            }
            
            val_1[3] = System.Linq.Enumerable.Aggregate<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, System.String>(source:  下上丐东丛丗丐且丑.Items, selector:  val_6), func:  val_8);
            string val_10 = System.String.Format(format:  "ad_{0}_{1}_{2}_[{3}]", args:  val_1);
            System.Collections.Generic.List<Rilisoft.OfferItem> val_11 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            List.Enumerator<T> val_13 = 下上丐东丛丗丐且丑.Items.GetEnumerator();
            label_35:
            if((469613792 & 1) == 0)
            {
                goto label_32;
            }
            
            new Rilisoft.OfferItem() = new Rilisoft.OfferItem(丞丕丒专一下丙业上:  val_2.丌丗丏丝丈丒一一丞.丐丏七丌丕丗业且上().UniqueId);
            val_11.Add(item:  new Rilisoft.OfferItem());
            goto label_35;
            label_32:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_19 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            long val_20 = 专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {dateData = val_19.丂一七丛丄丛三且丁});
            int val_21 = val_20.与丙且丑丙丒下万丌(丑丒丛与下专且丗不:  下上丐东丛丗丐且丑.Module, 与丕丌丒丗丄丘丙东:  val_20);
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_22 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            val_68 = 专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {dateData = val_22.丘丄三专丟丈万上三});
            val_69 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丒丄丅丟丞丅丄七丕;
            if(val_69 == null)
            {
                goto label_59;
            }
            
            val_69 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丒丄丅丟丞丅丄七丕;
            if(val_69 == null)
            {
                goto label_54;
            }
            
            if(Rilisoft.Offers.丌丟专丒丟丂万东丄.丒丄丅丟丞丅丄七丕.丗丛下不丟丑业丆业 >= 1)
            {
                    Progress.AdaptiveProgress val_24 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
                if(val_24.SeasonStartAt >= 1)
            {
                    Progress.AdaptiveProgress val_25 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
                int val_62 = val_25.SeasonStartAt;
                val_62 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丒丄丅丟丞丅丄七丕.丗丛下不丟丑业丆业 + val_62;
                val_68 = UnityEngine.Mathf.Min(a:  val_68, b:  val_62);
            }
            
            }
            
            label_59:
            AdaptiveModuleType val_27 = 下上丐东丛丗丐且丑.Module;
            if(((下上丐东丛丗丐且丑.Module != 70) && (下上丐东丛丗丐且丑.Module != 30)) && (下上丐东丛丗丐且丑.Module != 80))
            {
                    if(下上丐东丛丗丐且丑.Module != 40)
            {
                    if(下上丐东丛丗丐且丑.Module != 10)
            {
                goto label_86;
            }
            
            }
            
            }
            
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_37 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            if((val_37.上业三丙专丅丐三丁.ContainsKey(key:  下上丐东丛丗丐且丑.Real)) == false)
            {
                goto label_86;
            }
            
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_40 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            val_70 = val_40.上业三丙专丅丐三丁.Item[下上丐东丛丗丐且丑.Real];
            if(val_70 != 0)
            {
                goto label_92;
            }
            
            label_86:
            val_70 = 下上丐东丛丗丐且丑.Sale;
            label_92:
            Rilisoft.七丈业与与不七丈丟 val_44 = new Rilisoft.七丈业与与不七丈丟();
            七丈业与与不七丈丟.丏一丄丐专丟丂丟丏 val_45 = new 七丈业与与不七丈丟.丏一丄丐专丟丂丟丏();
            if(val_45 != null)
            {
                    .三丌丄丆下丑丛七不 = val_21;
            }
            else
            {
                    mem[48] = val_21;
            }
            
            .丗专丒丕丄下丘丁丛 = val_27.丕万丛业东丆丑丞上(丑丒丛与下专且丗不:  val_27, 与丕丌丒丗丄丘丙东:  val_68);
            if(val_44 != null)
            {
                    .丁丑丅丐丌不世丁下 = val_45;
                .下丄丈不与世丐业专 = val_10;
                .丕丏专业丑丘下丝一 = 0;
            }
            else
            {
                    mem[16] = val_45;
                mem[40] = val_10;
                mem[80] = 0;
            }
            
            .世不丑丙丞丘丘丙丈 = 0;
            .万丈丘丏丅世万丝丄 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            .且与丙丑丕专七丈专 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏().不丄专丐业丞丛与丁(丑丒丛与下专且丗不:  下上丐东丛丗丐且丑.Module, 丑丅三丗丌丞三丘丂:  val_30.且且丙专丒世丙下丗);
            .且东丌丏丐丝丕万业 = val_11;
            .丒丆丕丁丟业上七丅 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  下上丐东丛丗丐且丑.Real, 丏丂不专上丘丂不丅:  "Real");
            decimal val_50 = System.Decimal.op_Implicit(value:  val_70);
            .丂世丙丗丁丝丝丛业 = val_50;
            mem[1152921543731366392] = val_50.lo;
            mem[1152921543731366396] = val_50.mid;
            .丒上一丁丆丛东专丙 = new 七丈业与与不七丈丟.世丕三丙七丆丁丂丒();
            val_71 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丈丒且丗七丗丄下丐(丗丟丁丐与下丙丕丛:  val_10);
            if(val_71 == null)
            {
                goto label_107;
            }
            
            int val_63 = val_52.FirstShowDate;
            val_63 = ((Rilisoft.七丈业与与不七丈丟)[1152921543731353952].且与丙丑丕专七丈专 - Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().业丈丏丏丞丘丛丈丛()) + val_63;
            if(val_63 <= 0)
            {
                goto label_111;
            }
            
            label_120:
            AdaptiveModuleType val_56 = 下上丐东丛丗丐且丑.Module;
            return (Rilisoft.业丙丘丆东丈丕丂丄)new Rilisoft.业丙丘丆东丈丕丂丄(丁丅丈丌丟世丗丗丟:  60, 一丐丗丁丞丆丅丟丄:  val_44, 上丕丈丞丌丘丅不与:  val_71, 丑丒丛与下专且丗不:  new System.Nullable<AdaptiveModuleType>() {HasValue = false}, 东一丁世丑丞业丄丐:  下上丐东丛丗丐且丑.丙业不丝丗丌丗世下());
            label_107:
            Progress.OfferProgress val_59 = null;
            val_71 = val_59;
            val_59 = new Progress.OfferProgress();
            if(val_71 != null)
            {
                    .Id = val_10;
            }
            else
            {
                    mem[16] = val_10;
            }
            
            .PreparedItems = val_11;
            label_111:
            .FirstShowDate = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().业丈丏丏丞丘丛丈丛();
            if(下上丐东丛丗丐且丑 != null)
            {
                goto label_120;
            }
            
            goto label_120;
            label_54:
        }
        private void 丁丒丟丈世且丆丂丒(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌)
        {
            if(丙业丞丑七丗下丟丌 == null)
            {
                    return;
            }
            
            if((this.且丑不丛丏丏丐丄丐.Contains(item:  丙业丞丑七丗下丟丌)) == false)
            {
                    return;
            }
            
            this.且丛丕业丞万东七丒(丆丄丘丂业丛七丁且:  false);
        }
        public void 丑七丂丌世与七丏与(string 丅业丙丞且丐一丙丆)
        {
            var val_24;
            var val_48;
            var val_49;
            var val_52;
            Rilisoft.Offers.丆丏业丞丁下万且东 val_53;
            var val_54;
            var val_55;
            var val_56;
            System.Func<System.Collections.Generic.KeyValuePair<AdaptiveModuleType, Rilisoft.Offers.丛丝下且丟丈丞丈丗>, AdaptiveModuleType> val_58;
            丌丟专丒丟丂万东丄.丅三丈世丝丑专丂世 val_1 = new 丌丟专丒丟丂万东丄.丅三丈世丝丑专丂世();
            object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丅业丙丞且丐一丙丆);
            object[] val_3 = new object[1];
            val_3[0] = 60;
            UnityEngine.Debug.LogErrorFormat(format:  "parse offers config fail: unknown format in \'{0}\'", args:  val_3);
            this.世业丒万丘丆专丘丐();
            return;
            label_64:
            if((470209632 & 1) == 0)
            {
                goto label_46;
            }
            
            string val_18 = 0.丐丏七丌丕丗业且上();
            if(0 == 0)
            {
                goto label_64;
            }
            
            List.Enumerator<T> val_19 = 0.GetEnumerator();
            label_54:
            if((470209600 & 1) == 0)
            {
                goto label_49;
            }
            
            int val_20 = 0.丙东专丂世丈丏丁丂();
            if(((丌丟专丒丟丂万东丄.丅三丈世丝丑专丂世)[1152921543731810496].丕丝三丝丒丁丅丄丙.Contains(item:  val_20)) == true)
            {
                goto label_54;
            }
            
            (丌丟专丒丟丂万东丄.丅三丈世丝丑专丂世)[1152921543731810496].丕丝三丝丒丁丅丄丙.Add(item:  val_20);
            goto label_54;
            label_49:
             =  + 1;
            mem2[0] = 371;
            val_49 = ;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( == 1) || ((1152921543731762176 + ((0 + 1)) << 2) != 371))
            {
                goto label_61;
            }
            
            var val_45 = 0;
            val_45 = val_45 ^ ( >> 31);
             =  + val_45;
            goto label_64;
            label_61:
            if( == 0)
            {
                goto label_64;
            }
            
            goto label_64;
            label_46:
            val_52 =  + 1;
            mem2[0] = 396;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_52 == 1) || ((1152921543731762176 + ((0 + 1)) << 2) != 396))
            {
                goto label_72;
            }
            
            var val_46 = 0;
            val_46 = val_46 ^ (val_52 >> 31);
            val_52 = val_52 + val_46;
            if(val_1 != null)
            {
                goto label_76;
            }
            
            goto label_74;
            label_72:
            if( != 0)
            {
                    val_48 = 0;
            }
            
            if(val_1 != null)
            {
                goto label_76;
            }
            
            label_74:
            label_76:
            List.Enumerator<T> val_22 = (丌丟专丒丟丂万东丄.丅三丈世丝丑专丂世)[1152921543731810496].丕丝三丝丒丁丅丄丙.GetEnumerator();
            label_93:
            if((470209600 & 1) == 0)
            {
                goto label_78;
            }
            
            int val_25 = val_24.丙东专丂世丈丏丁丂();
            if((this.世丅丈上万与业下丈.ContainsKey(key:  val_25)) == true)
            {
                goto label_93;
            }
            
            if(val_25 <= 69)
            {
                goto label_81;
            }
            
            if(val_25 == 70)
            {
                goto label_82;
            }
            
            if(val_25 == 80)
            {
                goto label_83;
            }
            
            if(val_25 != 90)
            {
                goto label_93;
            }
            
            val_53 = new Rilisoft.Offers.丆丏业丞丁下万且东();
            val_53 = new Rilisoft.Offers.丆丏业丞丁下万且东();
            goto label_90;
            label_81:
            if(val_25 == 10)
            {
                goto label_86;
            }
            
            if(val_25 != 30)
            {
                goto label_93;
            }
            
            val_53 = new Rilisoft.Offers.丙东丄万万丑东丘丅();
            val_53 = new Rilisoft.Offers.丙东丄万万丑东丘丅();
            goto label_90;
            label_82:
            val_53 = new Rilisoft.Offers.世丆丏下丆专与丂不();
            val_53 = new Rilisoft.Offers.世丆丏下丆专与丂不();
            goto label_90;
            label_83:
            val_53 = new Rilisoft.Offers.不丒上丄业三与下丟();
            val_53 = new Rilisoft.Offers.不丒上丄业三与下丟();
            goto label_90;
            label_86:
            val_53 = new Rilisoft.Offers.丈丌七丅东丁丁丛丟();
            val_53 = new Rilisoft.Offers.丈丌七丅东丁丁丛丟();
            label_90:
            if(val_53 == null)
            {
                goto label_93;
            }
            
            this.世丅丈上万与业下丈.Add(key:  val_25, value:  new Rilisoft.Offers.丈丌七丅东丁丁丛丟());
            goto label_93;
            label_78:
            val_54 = val_52 + 1;
            mem2[0] = 555;
            val_55 = 1152921543731658240;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_54 != 1) && ((1152921543731762176 + (((0 + 1) + 1)) << 2) == 555))
            {
                    var val_47 = 0;
                val_47 = val_47 ^ (val_54 >> 31);
                val_54 = val_54 + val_47;
            }
            else
            {
                    if( != 0)
            {
                    val_48 = 0;
            }
            
            }
            
            val_56 = null;
            val_56 = null;
            val_58 = 丌丟专丒丟丂万东丄.<>c.<>9__44_0;
            if(val_58 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<AdaptiveModuleType, Rilisoft.Offers.丛丝下且丟丈丞丈丗>, AdaptiveModuleType> val_32 = null;
                val_58 = val_32;
                val_32 = new System.Func<System.Collections.Generic.KeyValuePair<AdaptiveModuleType, Rilisoft.Offers.丛丝下且丟丈丞丈丗>, AdaptiveModuleType>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  AdaptiveModuleType 丌丟专丒丟丂万东丄.<>c::丆东不丒丁丅丏丘丕(System.Collections.Generic.KeyValuePair<Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType, Rilisoft.Offers.丛丝下且丟丈丞丈丗> 丏丛与丅丛丌万专丌));
                丌丟专丒丟丂万东丄.<>c.<>9__44_0 = val_58;
            }
            
            System.Collections.Generic.List<TSource> val_36 = System.Linq.Enumerable.ToList<AdaptiveModuleType>(source:  System.Linq.Enumerable.Where<AdaptiveModuleType>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<AdaptiveModuleType, Rilisoft.Offers.丛丝下且丟丈丞丈丗>, AdaptiveModuleType>(source:  this.世丅丈上万与业下丈, selector:  val_32), predicate:  new System.Func<AdaptiveModuleType, System.Boolean>(object:  val_1, method:  System.Boolean 丌丟专丒丟丂万东丄.丅三丈世丝丑专丂世::丘丌丂丗丁业业上下(Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType 丙丒七丄上与丏丙丙))));
            if(val_36.Count < 1)
            {
                goto label_135;
            }
            
            List.Enumerator<T> val_38 = val_36.GetEnumerator();
            label_119:
            if((470209600 & 1) == 0)
            {
                goto label_115;
            }
            
            int val_39 = val_24.丙东专丂世丈丏丁丂();
            Rilisoft.Offers.丛丝下且丟丈丞丈丗 val_40 = this.世丅丈上万与业下丈.Item[val_39];
            bool val_41 = this.世丅丈上万与业下丈.Remove(key:  val_39);
            goto label_119;
            label_115:
            val_54 = val_54 + 1;
            mem2[0] = 708;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_54 == 1)
            {
                goto label_125;
            }
            
            if(( == 0) || ((1152921543731762176 + ((((0 + 1) + 1) + 1)) << 2) == 708))
            {
                goto label_135;
            }
            
            label_134:
            label_135:
            if(this.丗丐与七丐丞上丟丈 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丗丐与七丐丞上丟丈);
            }
            
            this.丗丐与七丐丞上丟丈 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丛万丙丗世三丙丝不());
            this.且丛丕业丞万东七丒(丆丄丘丂业丛七丁且:  true);
            return;
            label_125:
            if( != 0)
            {
                goto label_134;
            }
            
            goto label_135;
        }
        public void 丟一丏与丈丅丗丅丈()
        {
            bool val_2 = Progress.丆丆丐下万丙丄丆上.丑七不且上丗丁一世().丘七三丏丟丝下上东(丕上业丕丘上丘七一:  60, 丗丛丙丟一丒一与丈:  this.且丑不丛丏丏丐丄丐);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万丑丆丘丟丘丅丁丛(上丕丈丞丌丘丅不与:  Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万());
        }
        private void 丐丑丁丑丟丒不三丅()
        {
            if(this.一丗七丌一世东丈丏 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.一丗七丌一世东丈丏);
            }
            
            this.一丗七丌一世东丈丏 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丂丙三丂丑丈丛丞丆());
        }
        private System.Collections.IEnumerator 丂丙三丂丑丈丛丞丆()
        {
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 丌丟专丒丟丂万东丄.丏三一丕丌丑世丄上(丗丏丅丕丆世丁专丟:  0);
        }
        private System.Collections.IEnumerator 丛万丙丗世三丙丝不()
        {
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 丌丟专丒丟丂万东丄.东丛丅上丙丅三丑丈(丗丏丅丕丆世丁专丟:  0);
        }
        private void 世业丒万丘丆专丘丐()
        {
            var val_2;
            Rilisoft.Offers.专下丞一丕下下丗与.不丄丌丞丟丟丙万业(丕上业丕丘上丘七一:  60);
            val_2 = null;
            val_2 = null;
            Rilisoft.Offers.丌丟专丒丟丂万东丄.丒丄丅丟丞丅丄七丕 = new Rilisoft.Offers.东下上东丅丂丘丗丙();
            this.且丑不丛丏丏丐丄丐.Clear();
        }
        private bool 下丈丘丆丂丒世专丆(System.Collections.Generic.Dictionary<string, object> 丞丕丒专一下丙业上, out Rilisoft.Offers.东下上东丅丂丘丗丙 与不丕丆丈不丙丟丛, out int 丐丙且丗不业丌丄丅)
        {
            var val_85;
            System.Nullable<OfferModule> val_86;
            ulong val_87;
            double val_88;
            ulong val_89;
            var val_90;
            var val_91;
            var val_92;
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_93;
            var val_94;
            var val_95;
            var val_96;
            var val_97;
            var val_98;
            var val_99;
            var val_100;
            val_85;
            val_86 = 丞丕丒专一下丙业上;
            int val_39 = 0;
            与不丕丆丈不丙丟丛 = new Rilisoft.Offers.东下上东丅丂丘丗丙();
            丐丙且丗不业丌丄丅 = 0;
            System.DateTime val_2 = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.DateTime>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "start");
            System.DateTime val_4 = val_2.dateData.AddSeconds(value:  (double)Rilisoft.与丄丁丄丙丞下下丙.一丄丑丛丕丟万三丞(丗丙丆世丆丕万下丒:  88));
            val_87 = val_4.dateData;
            System.DateTime val_5 = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.DateTime>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "end");
            val_88 = (double)Rilisoft.与丄丁丄丙丞下下丙.一丄丑丛丕丟万三丞(丗丙丆世丆丕万下丒:  88);
            System.DateTime val_7 = val_5.dateData.AddSeconds(value:  val_88);
            val_89 = val_7.dateData;
            long val_9 = 专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {dateData = val_89});
            mem[1152921543732909368] = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Int32>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "time_repeat");
            val_90 = 1152921505243639808;
            if((val_9 < PixelTime.丝丗专上三不丄丑丑()) && (mem[1152921543732909368] >= 1))
            {
                    val_88 = ((float)PixelTime.丝丗专上三不丄丑丑() - val_9) / (float)mem[1152921543732909368];
                int val_15 = mem[1152921543732909368] * (UnityEngine.Mathf.CeilToInt(f:  val_88));
                丐丙且丗不业丌丄丅 = val_15;
                System.DateTime val_17 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  (专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {dateData = val_87})) + (val_15 << ));
                val_87 = val_17.dateData;
                System.DateTime val_19 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  val_9 + 丐丙且丗不业丌丄丅);
                val_89 = val_19.dateData;
            }
            
            val_91 = 1152921543732901280;
            val_92 = 1152921530874095888;
            mem[1152921543732909360] = 专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {dateData = val_87});
            val_93 = 与不丕丆丈不丙丟丛;
            mem[1152921543732909364] = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Int32>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "season_duration");
            if(mem[1152921543732909360] < 1)
            {
                goto label_26;
            }
            
            mem[1152921543732909376] = 0;
            mem[1152921543732909384] = 0;
            mem[1152921543732909392] = 0;
            mem[1152921543732909400] = 0;
            mem[1152921543732909412] = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Int32>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "life_time");
            mem[1152921543732909416] = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Single>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "currency_level_mult");
            val_90 = 1152921516630043280;
            if((val_86.ContainsKey(key:  "multy_offers_modules")) == false)
            {
                goto label_65;
            }
            
            object val_25 = val_86.Item["multy_offers_modules"];
            if(val_25 == null)
            {
                goto label_65;
            }
            
            List.Enumerator<T> val_26 = val_25.GetEnumerator();
            val_93 = 1152921516789141600;
            label_53:
            if((471300400 & 1) == 0)
            {
                goto label_39;
            }
            
            string val_28 = 0.丐丏七丌丕丗业且上();
            val_94 = null;
            val_94 = null;
            if((Rilisoft.Offers.丌丟专丒丟丂万东丄.丝丞丑专丅东下上丄.ContainsKey(key:  val_28)) == false)
            {
                goto label_53;
            }
            
            val_95 = null;
            val_95 = null;
            AdaptiveModuleType val_30 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丝丞丑专丅东下上丄.Item[val_28];
            if((mem[1152921543732909456].Contains(item:  val_30)) == true)
            {
                goto label_53;
            }
            
            mem[1152921543732909456].Add(item:  val_30);
            goto label_53;
            label_26:
            val_96 = 0;
            return (bool)val_96;
            label_39:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_90 = val_90;
            val_91 = 1152921543732901280;
            val_92 = 1152921530874095888;
            label_65:
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_32 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            mem[1152921543732909432] = val_32;
            val_86 = new System.Nullable<OfferModule>(value:  "sales_amount");
            if((val_86 & 1) == 0)
            {
                goto label_97;
            }
            
            object val_34 = val_86.Item["sales_amount"];
            if(val_34 == null)
            {
                goto label_97;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_35 = val_34.GetEnumerator();
            val_93 = 1152921516595683744;
            label_86:
            if((471300352 & 1) == 0)
            {
                goto label_73;
            }
            
            ConfiguredValueTaskAwaiter val_37 = 0.GetAwaiter();
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_37._value._obj.丐丏七丌丕丗业且上(), 丙业与丙丗丝不丈东: out  val_39)) == false)
            {
                goto label_86;
            }
            
            if(((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_37._value._obj, 丙业与丙丗丝不丈东: out  val_39)) == false) || ((val_32.ContainsKey(key:  0)) == true))
            {
                goto label_86;
            }
            
            val_32.Add(key:  0, value:  0);
            goto label_86;
            label_73:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            val_91 = 1152921543732901280;
            val_90 = 1152921516630043280;
            val_92 = 1152921530874095888;
            label_97:
            mem[1152921543732909424] = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Collections.Generic.List<System.Int32>>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "sales");
            mem[1152921543732909440] = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Int32>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "currency_views_count");
            if((val_86.ContainsKey(key:  "detailsItems")) != false)
            {
                    object val_46 = val_86.Item["detailsItems"];
                if((val_46 != null) && (null == null))
            {
                    char[] val_47 = new char[1];
                val_87 = val_47;
                val_87[0] = ',';
                mem[1152921543732909480] = System.Linq.Enumerable.ToList<System.String>(source:  val_46.Split(separator:  val_47));
            }
            
            }
            
            if(mem[1152921543732909480] == 0)
            {
                    mem[1152921543732909480] = new System.Collections.Generic.List<System.String>();
            }
            
            System.Collections.Generic.List<丂七丄不专下丘丂丟> val_51 = new System.Collections.Generic.List<丂七丄不专下丘丂丟>();
            mem[1152921543732909472] = val_51;
            if((val_86.ContainsKey(key:  "detailsCohorts")) != false)
            {
                    val_87 = val_86.Item["detailsCohorts"];
            }
            
            label_212:
            if((val_86.ContainsKey(key:  "slots")) == false)
            {
                goto label_231;
            }
            
            object val_55 = val_86.Item["slots"];
            if(val_55 == null)
            {
                goto label_231;
            }
            
            val_90 = 1152921504691564544;
            val_86 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_55) : 0;
            val_97 = 0;
            List.Enumerator<T> val_56 = val_86.GetEnumerator();
            val_93 = 1152921516789171648;
            val_86 = 0;
            goto label_137;
            label_167:
            val_87 = 0.丐丏七丌丕丗业且上();
            if((val_87 == null) || (val_87.Count < 1))
            {
                goto label_137;
            }
            
            System.Collections.Generic.KeyValuePair<System.String, System.Object> val_59 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<System.String, System.Object>>(source:  val_87);
            val_87 = val_59.Value.丐丏七丌丕丗业且上();
            System.Nullable<T> val_61 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<丂丘丛下丆一丕丂丅>(下业七不丑丂丏丟东:  val_87, 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  false);
            if((471300272 & 1) == 0)
            {
                goto label_137;
            }
            
            if(val_59.Value == 0)
            {
                goto label_137;
            }
            
            System.Collections.Generic.List<AdaptiveModuleType> val_62 = new System.Collections.Generic.List<AdaptiveModuleType>();
            List.Enumerator<T> val_63 = val_59.Value.GetEnumerator();
            goto label_148;
            label_151:
            string val_64 = 0.丐丏七丌丕丗业且上();
            val_93 = val_93;
            if((Rilisoft.Offers.丌丟专丒丟丂万东丄.丝丞丑专丅东下上丄.ContainsKey(key:  val_64)) != false)
            {
                    val_93 = val_93;
                null.Add(item:  Rilisoft.Offers.丌丟专丒丟丂万东丄.丝丞丑专丅东下上丄.Item[val_64]);
            }
            
            label_148:
            if((471300240 & 1) != 0)
            {
                goto label_151;
            }
            
            val_97 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_97 != 1) && (1361 == 1361))
            {
                    val_97 = 1;
            }
            else
            {
                    if( != 0)
            {
                    val_86 = 0;
            }
            
            }
            
            new 东下上东丅丂丘丗丙.专丟东业万丗不丟丛() = new 东下上东丅丂丘丗丙.专丟东业万丗不丟丛();
            .下丄丈不与世丐业专 = 1;
            .丁业丛且一丂一丟丁 = val_61.HasValue;
            .上丕专一且专丁丑丞 = null;
            val_87 = mem[1152921543732909448];
            val_87.Add(item:  new 东下上东丅丂丘丗丙.专丟东业万丗不丟丛());
            label_137:
            if((471300400 & 1) != 0)
            {
                goto label_167;
            }
            
            val_98 = 0;
            val_97 = val_97 + 1;
            mem2[0] = 1445;
            goto label_168;
            label_179:
            if((471300352 & 1) == 0)
            {
                goto label_171;
            }
            
            ConfiguredValueTaskAwaiter val_71 = 0.GetAwaiter();
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_71._value._obj.丐丏七丌丕丗业且上(), 丙业与丙丗丝不丈东: out  0)) == false)
            {
                goto label_179;
            }
            
            PGCompany.DataObjects.IntInterval val_75 = PGCompany.DataObjects.IntInterval.东丝七业丄丑丒世七(丞丕丒专一下丙业上:  val_71._value._obj);
            if(val_75 == null)
            {
                goto label_179;
            }
            
            Add(key:  0, value:  val_75);
            goto label_179;
            label_171:
            val_99 = 0;
            val_100 = 136112601;
            mem[1152921544277303140] = 1019;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            if(( != 1) && (633 == 1019))
            {
                    var val_85 = 0;
                val_85 = val_85 ^ 0;
                val_100 =  + val_85;
            }
            else
            {
                    if( != 0)
            {
                    val_99 = 0;
            }
            
            }
            
            PGCompany.DataObjects.IntInterval val_77 = PGCompany.DataObjects.IntInterval.东丝七业丄丑丒世七(丞丕丒专一下丙业上:  Item["payment"]);
            if(val_77 == null)
            {
                goto label_202;
            }
            
            东下上东丅丂丘丗丙.丂七丄不专下丘丂丟 val_78 = new 东下上东丅丂丘丗丙.丂七丄不专下丘丂丟();
            if(val_78 != null)
            {
                    .丏丆丂丘丆世丘下丅 = ;
                .上七丛丝丏丌丅七且 = 0;
            }
            else
            {
                    mem[16] = ;
                mem[24] = 0;
            }
            
            .一丞东丅一上丒万且 = val_77;
            val_51.Add(item:  val_78);
            goto label_210;
            label_211:
            object val_79 = val_87.Item[0];
            if(val_79 == null)
            {
                goto label_202;
            }
            
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_79.Item["id"], 丙业与丙丗丝不丈东: out  0)) != false)
            {
                    if(val_79.Item["inapps"] == null)
            {
                goto label_210;
            }
            
            }
            
            label_210:
            label_202:
             =  + 1;
            if( < val_87.Count)
            {
                goto label_211;
            }
            
            goto label_212;
            label_168:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_97 == 1)
            {
                goto label_227;
            }
            
            val_96 = 1;
            if( == 0)
            {
                    return (bool)val_96;
            }
            
            if(1361 != 1445)
            {
                goto label_229;
            }
            
            return (bool)val_96;
            label_227:
            if( == 0)
            {
                goto label_231;
            }
            
            label_229:
            label_231:
            val_96 = 1;
            return (bool)val_96;
        }
        public void Dispose()
        {
            Rilisoft.业丙丘丆东丈丕丂丄.丐丅丕丑专万丌丈东(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.业丙丘丆东丈丕丂丄>(object:  this, method:  System.Void Rilisoft.Offers.丌丟专丒丟丂万东丄::丁丒丟丈世且丆丂丒(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌)));
            if(this.且丑不丛丏丏丐丄丐 == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_2 = this.且丑不丛丏丏丐丄丐.GetEnumerator();
            label_6:
            if((471600776 & 1) == 0)
            {
                goto label_4;
            }
            
            if(0.丐丏七丌丕丗业且上() == null)
            {
                goto label_6;
            }
            
            goto label_6;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this = this.且丑不丛丏丏丐丄丐;
            this.Clear();
        }
        private static 丌丟专丒丟丂万东丄()
        {
            Rilisoft.Offers.丌丟专丒丟丂万东丄.丒丄丅丟丞丅丄七丕 = new Rilisoft.Offers.东下上东丅丂丘丗丙();
            System.Collections.Generic.Dictionary<System.String, AdaptiveModuleType> val_2 = new System.Collections.Generic.Dictionary<System.String, AdaptiveModuleType>();
            if(val_2 != null)
            {
                    val_2.Add(key:  "W", value:  10);
            }
            else
            {
                    val_2.Add(key:  "W", value:  10);
            }
            
            val_2.Add(key:  "D", value:  30);
            if(val_2 != null)
            {
                    val_2.Add(key:  "C", value:  70);
            }
            else
            {
                    val_2.Add(key:  "C", value:  70);
            }
            
            val_2.Add(key:  "P", value:  80);
            val_2.Add(key:  "G", value:  90);
            Rilisoft.Offers.丌丟专丒丟丂万东丄.丝丞丑专丅东下上丄 = val_2;
        }
    
    }

}
