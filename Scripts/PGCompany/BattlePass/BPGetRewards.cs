using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPGetRewards : MonoBehaviour
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        private System.Collections.Generic.List<PGCompany.BattlePass.BPReward> 丑丘七丄万丐三下世;
        private static PGCompany.BattlePass.BPGetRewards <不丁丄七丛不丆丁丕>k__BackingField;
        private static System.Action 丛丄业丘不丆丄三丞;
        private System.Collections.Generic.List<UILabel> _levelLabels;
        private UnityEngine.GameObject _largeContainer;
        private Rilisoft.BetterWrapContent _largeWrap;
        private UIWidget _scrollBorder;
        private UIPanel _scrollPanel;
        private UnityEngine.GameObject _smallContainer;
        private Rilisoft.BetterWrapContent _smallWrap;
        private PGCompany.BattlePass.BPRewardView _freeRewardView;
        private System.Collections.Generic.List<UILabel> _scrollsHeadersLabels;
        private System.Collections.Generic.List<UnityEngine.GameObject> _freeObjects;
        private System.Collections.Generic.List<UnityEngine.GameObject> _premiumObjects;
        private UnityEngine.AudioClip _openClip;
        private UnityEngine.GameObject _noPremHint;
        private UnityEngine.GameObject _tutoriaHint;
        private UnityEngine.GameObject _buyLevelButton;
        
        // Properties
        internal static PGCompany.BattlePass.BPGetRewards 丆丕丝丒不丙且丐丗 { get; set; }
        internal static bool 丕世一与业丅万专丑 { get; }
        
        // Methods
        internal static PGCompany.BattlePass.BPGetRewards 丑七不且上丗丁一世()
        {
            return (PGCompany.BattlePass.BPGetRewards)PGCompany.BattlePass.BPGetRewards.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(PGCompany.BattlePass.BPGetRewards 丙业与丙丗丝不丈东)
        {
            PGCompany.BattlePass.BPGetRewards.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal PGCompany.BattlePass.上丕丁专三丗丝万丆.PlayerPaymentState 下丗丈万丞与专丕丂(int 丌丗丏丝丈丒一一丞)
        {
            PGCompany.BattlePass.三专下业丒七丑丒丅 val_2 = Progress.七七世万专丕丁上业.上业丑丅业不东丛业().专东专丄丆丙与丘丆(世不下丟世一丝丐丗:  丌丗丏丝丈丒一一丞);
            if(val_2 != null)
            {
                    return val_2.专丟专一丒且丘与丌();
            }
            
            return val_2.专丟专一丒且丘与丌();
        }
        internal static bool 丌七丘七丗下丐七丞()
        {
            var val_7;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            val_7 = 0;
            if(val_2 == null)
            {
                    return (bool)(val_2.丅丌丏与丗丆丁一丑() != val_2.业丈丅丂且丁与丄丂()) ? 1 : 0;
            }
            
            if((PGCompany.BattlePass.BPGetRewards.<不丁丄七丛不丆丁丕>k__BackingField) != 0)
            {
                    return (bool)(val_2.丅丌丏与丗丆丁一丑() != val_2.业丈丅丂且丁与丄丂()) ? 1 : 0;
            }
            
            return (bool)(val_2.丅丌丏与丗丆丁一丑() != val_2.业丈丅丂且丁与丄丂()) ? 1 : 0;
        }
        internal static void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.BattlePass.BPGetRewards.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.BattlePass.BPGetRewards.丛丄业丘不丆丄三丞 != 1152921505684484104);
        
        }
        internal static void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.BattlePass.BPGetRewards.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.BattlePass.BPGetRewards.丛丄业丘不丆丄三丞 != 1152921505684484104);
        
        }
        private void OnEnable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.BattlePass.BPGetRewards::Hide()), 与且专丈不万东一万:  0);
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    if(this._openClip != 0)
            {
                    this = this._openClip;
                UnityEngine.AudioSource val_7 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this);
            }
            
            }
            
            UnityEngine.Debug.Log(message:  ">>>> BPGetRewards enabled");
        }
        private void OnDisable()
        {
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        internal static void 下与丞三丅丛丄七丕(UnityEngine.Transform 丆丏七丟不丒与七专)
        {
            UnityEngine.Transform val_9 = 丆丏七丟不丒与七专;
            UnityEngine.GameObject val_2 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  PGCompany.BattlePass.上丕丁专三丗丝万丆.丏一专东丏丙丐丟丞(丟丈一下东业一丝丆:  "BPGetRewards"));
            if(val_2 == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_4 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_2, 丈东丘丏与丌东东下:  val_9 = 丆丏七丟不丒与七专, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            if(val_4 != 0)
            {
                    PGCompany.BattlePass.BPGetRewards.<不丁丄七丛不丆丁丕>k__BackingField = val_4.GetComponent<PGCompany.BattlePass.BPGetRewards>();
                if((PGCompany.BattlePass.BPGetRewards.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_4);
            }
            
            }
            
            val_9 = PGCompany.BattlePass.BPGetRewards.<不丁丄七丛不丆丁丕>k__BackingField;
            if(val_9 == 0)
            {
                    return;
            }
            
            PGCompany.BattlePass.BPGetRewards.<不丁丄七丛不丆丁丕>k__BackingField.丘上丐世丆丑且丞丒();
        }
        private void 丘上丐世丆丑且丞丒()
        {
            System.Func<System.Int32> val_64;
            var val_65;
            var val_66;
            var val_67;
            var val_68;
            var val_70;
            var val_72;
            var val_73;
            var val_75;
            var val_77;
            System.Func<PGCompany.BattlePass.BPReward, System.Boolean> val_79;
            int val_80;
            var val_81;
            System.Func<PGCompany.BattlePass.BPReward, System.Int32> val_83;
            UnityEngine.GameObject val_84;
            var val_85;
            var val_86;
            System.Func<PGCompany.BattlePass.BPReward, System.Boolean> val_88;
            UnityEngine.GameObject val_89;
            var val_90;
            string val_91;
            string val_92;
            BPGetRewards.丕丛业丁丏下一七丘 val_1 = new BPGetRewards.丕丛业丁丏下一七丘();
            .丝且与丝丒丟万丁专 = this;
            val_64 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_64 == null)
            {
                    return;
            }
            
            .丐万万不丕丛丟丁且 = val_64.丅丌丏与丗丆丁一丑();
            int val_5 = val_64.业丈丅丂且丁与丄丂();
            int val_64 = (BPGetRewards.丕丛业丁丏下一七丘)[1152921560126895840].丐万万不丕丛丟丁且;
            val_65 = 100;
            .丒丆不丏丑丞丛东丐 = val_5;
            val_64 = val_5 - val_64;
            if(val_64 == 1)
            {
                    var val_7 = (val_64.专丟专一丒且丘与丌() == 0) ? 0 : 100;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  33);
            val_64.下下丌丏丆业丞丈丑(丈丘丝一丗下丈丐不:  val_64.业丈丅丂且丁与丄丂());
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万七丘东上世丘万丕(不丒丄下丆丗丞丂一:  54);
            if(this._levelLabels != null)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._levelLabels, 丕丗丘丑丛与丑业丒:  val_64.业丈丅丂且丁与丄丂().ToString());
            }
            
            val_66 = 1152921559919340512;
            this.丑丘七丄万丐三下世 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.BPReward>(source:  System.Linq.Enumerable.ToList<PGCompany.BattlePass.BPReward>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.BPReward>(source:  val_64.丑万丘丈业丁丟丏七(), predicate:  new System.Func<PGCompany.BattlePass.BPReward, System.Boolean>(object:  val_1, method:  System.Boolean BPGetRewards.丕丛业丁丏下一七丘::不丐三丕且丐丘七专(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛)))));
            val_67 = null;
            if(val_7 != 100)
            {
                goto label_12;
            }
            
            val_68 = null;
            if((BPGetRewards.<>c.<>9__15_1) == null)
            {
                goto label_15;
            }
            
            label_76:
            this._freeObjects.ForEach(action:  BPGetRewards.<>c.<>9__15_1);
            val_70 = null;
            val_70 = null;
            if((BPGetRewards.<>c.<>9__15_2) == null)
            {
                goto label_19;
            }
            
            label_80:
            this._premiumObjects.ForEach(action:  BPGetRewards.<>c.<>9__15_2);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buyLevelButton, 丏业丟一东丂东丘丛:  (~val_64.丐丞上丒七丞丁丙丕()) & 1);
            val_72 = 1152921536401737616;
            goto label_32;
            label_12:
            val_73 = null;
            if((BPGetRewards.<>c.<>9__15_6) == null)
            {
                goto label_26;
            }
            
            label_84:
            this._freeObjects.ForEach(action:  BPGetRewards.<>c.<>9__15_6);
            val_75 = null;
            val_75 = null;
            if((BPGetRewards.<>c.<>9__15_7) == null)
            {
                goto label_30;
            }
            
            label_88:
            this._premiumObjects.ForEach(action:  BPGetRewards.<>c.<>9__15_7);
            System.Collections.Generic.IEnumerable<PGCompany.BattlePass.BPReward> val_20 = val_64.业下丈丕丙丁东世丙(上丌丆丁丟上下专丁:  new System.Nullable<PlayerPaymentState>() {HasValue = false}, 丈丘丝一丗下丈丐不:  new System.Nullable<System.Int32>() {HasValue = false}, 不丝丟与丟丈一三与:  true);
            val_72 = 1152921536401737616;
            if(val_20 != null)
            {
                    this.丑丘七丄万丐三下世.AddRange(collection:  val_20);
            }
            
            label_32:
            val_77 = null;
            val_77 = null;
            val_79 = BPGetRewards.<>c.<>9__15_3;
            if(val_79 == null)
            {
                    System.Func<PGCompany.BattlePass.BPReward, System.Boolean> val_21 = null;
                val_79 = val_21;
                val_21 = new System.Func<PGCompany.BattlePass.BPReward, System.Boolean>(object:  BPGetRewards.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BPGetRewards.<>c::丏丈东丟与丙丕丞丂(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛));
                BPGetRewards.<>c.<>9__15_3 = val_79;
            }
            
            System.Collections.Generic.List<TSource> val_23 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.BPReward>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.BPReward>(source:  this.丑丘七丄万丐三下世, predicate:  val_21));
            this.丑丘七丄万丐三下世 = val_23;
            val_80 = 1152921536401730448;
            if(val_23.Count < 1)
            {
                    return;
            }
            
            val_81 = null;
            val_81 = null;
            val_83 = BPGetRewards.<>c.<>9__15_4;
            if(val_83 == null)
            {
                    System.Func<PGCompany.BattlePass.BPReward, System.Int32> val_25 = null;
                val_83 = val_25;
                val_25 = new System.Func<PGCompany.BattlePass.BPReward, System.Int32>(object:  BPGetRewards.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BPGetRewards.<>c::丒丈丂丐丗万丈专丞(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛));
                BPGetRewards.<>c.<>9__15_4 = val_83;
            }
            
            System.Collections.Generic.List<TSource> val_27 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.BPReward>(source:  System.Linq.Enumerable.OrderByDescending<PGCompany.BattlePass.BPReward, System.Int32>(source:  this.丑丘七丄万丐三下世, keySelector:  val_25));
            this.丑丘七丄万丐三下世 = val_27;
            if(val_27.Count == 0)
            {
                goto label_47;
            }
            
            if(val_7 != 100)
            {
                goto label_48;
            }
            
            val_84 = this._smallContainer;
            val_85 = null;
            goto label_51;
            label_47:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._smallContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._largeContainer, 丏业丟一东丂东丘丛:  false);
            goto label_54;
            label_48:
            val_86 = null;
            val_86 = null;
            val_88 = BPGetRewards.<>c.<>9__15_8;
            if(val_88 == null)
            {
                    System.Func<PGCompany.BattlePass.BPReward, System.Boolean> val_29 = null;
                val_88 = val_29;
                val_29 = new System.Func<PGCompany.BattlePass.BPReward, System.Boolean>(object:  BPGetRewards.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BPGetRewards.<>c::东丏三世丞丞丛不业(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛));
                BPGetRewards.<>c.<>9__15_8 = val_88;
            }
            
            PGCompany.BattlePass.BPReward val_30 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.BPReward>(source:  this.丑丘七丄万丐三下世, predicate:  val_29);
            val_84 = this._smallContainer;
            if(val_30 == null)
            {
                goto label_60;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_84, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._largeContainer, 丏业丟一东丂东丘丛:  false);
            bool val_31 = this.丑丘七丄万丐三下世.Remove(item:  val_30);
            this._freeRewardView.<丅丝丌丝丁丏丙东丞>k__BackingField = val_30;
            this._freeRewardView.丝一丅丆三东丂丞七();
            this._freeRewardView.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BPRewardView>(object:  this, method:  System.Void PGCompany.BattlePass.BPGetRewards::丒丂丙丂一丞丟且万(PGCompany.BattlePass.BPRewardView 丁世丛业丟下丕三丟)));
            this._freeRewardView.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BPRewardView>(object:  this, method:  System.Void PGCompany.BattlePass.BPGetRewards::丒丂丙丂一丞丟且万(PGCompany.BattlePass.BPRewardView 丁世丛业丟下丕三丟)));
            if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() == false)
            {
                goto label_69;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._noPremHint, 丏业丟一东丂东丘丛:  true);
            val_89 = this._tutoriaHint;
            val_90 = 0;
            goto label_72;
            label_15:
            BPGetRewards.<>c.<>9__15_1 = new System.Action<UnityEngine.GameObject>(object:  BPGetRewards.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BPGetRewards.<>c::丈丄丌上三万丑与丏(UnityEngine.GameObject 丄三丅七丆丛与与上));
            if(this._freeObjects != null)
            {
                goto label_76;
            }
            
            goto label_76;
            label_19:
            BPGetRewards.<>c.<>9__15_2 = new System.Action<UnityEngine.GameObject>(object:  BPGetRewards.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BPGetRewards.<>c::东丛丈上丗丗丘丒不(UnityEngine.GameObject 丄三丅七丆丛与与上));
            if(this._premiumObjects != null)
            {
                goto label_80;
            }
            
            goto label_80;
            label_26:
            BPGetRewards.<>c.<>9__15_6 = new System.Action<UnityEngine.GameObject>(object:  BPGetRewards.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BPGetRewards.<>c::丏丒且东丂丈丑万丅(UnityEngine.GameObject 丄三丅七丆丛与与上));
            if(this._freeObjects != null)
            {
                goto label_84;
            }
            
            goto label_84;
            label_30:
            BPGetRewards.<>c.<>9__15_7 = new System.Action<UnityEngine.GameObject>(object:  BPGetRewards.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BPGetRewards.<>c::丏丟丘丒世一丗丆丌(UnityEngine.GameObject 丄三丅七丆丛与与上));
            if(this._premiumObjects != null)
            {
                goto label_88;
            }
            
            goto label_88;
            label_60:
            val_85 = null;
            label_51:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_84, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._largeContainer, 丏业丟一东丂东丘丛:  true);
            label_54:
            label_135:
            int val_39 = val_64.万上丁一丞业业万东();
            val_91 = "";
            if(val_7 == 0)
            {
                goto label_91;
            }
            
            if(val_7 != 100)
            {
                goto label_92;
            }
            
            if(this.丑丘七丄万丐三下世.Count < 1)
            {
                goto label_94;
            }
            
            PGCompany.BattlePass.BPReward val_43 = this.丑丘七丄万丐三下世.Item[0];
            val_66 = val_43._item.Count;
            PGCompany.BattlePass.BPReward val_45 = this.丑丘七丄万丐三下世.Item[0];
            val_92 = val_45._item.Id;
            goto label_101;
            label_91:
            if(0 == 0)
            {
                goto label_102;
            }
            
            val_66 = 64.Count;
            val_92 = 64.Id;
            goto label_105;
            label_92:
            val_80 = 0;
            val_66 = 0;
            val_92 = val_91;
            goto label_110;
            label_102:
            val_80 = 0;
            val_92 = val_91;
            goto label_110;
            label_94:
            val_66 = 0;
            val_92 = val_91;
            label_101:
            if(this.丑丘七丄万丐三下世.Count >= 2)
            {
                goto label_109;
            }
            
            label_105:
            val_80 = 0;
            goto label_110;
            label_109:
            PGCompany.BattlePass.BPReward val_50 = this.丑丘七丄万丐三下世.Item[1];
            val_80 = val_50._item.Count;
            PGCompany.BattlePass.BPReward val_52 = this.丑丘七丄万丐三下世.Item[1];
            val_91 = val_52._item.Id;
            label_110:
            PGCompany.Analytics.一业丗丆世世上丁且.三丕与丄一七业丅丐(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 七丐一丙下丌丙丞丝:  (BPGetRewards.丕丛业丁丏下一七丘)[1152921560126895840].丐万万不丕丛丟丁且, 万丗下丙世丞丞东丘:  ((val_39.下丗丈万丞与专丕丂(丌丗丏丝丈丒一一丞:  val_39)) != 0) ? (1 + 1) : 1, 丏丛丏上丐丐丁丐世:  0, 丁丒上不丘业丂上丕:  val_80, 丈且东丁业丈丈东上:  val_92, 且专丝丟丈上丆丟且:  val_91, 世不下丟世一丝丐丗:  val_64.万上丁一丞业业万东(), 丏丐丕丛下丒丏下七:  val_64.丒丑丅丑丕万丞丅丟());
            val_79 = this._largeWrap;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            this.丑丘七丄万丐三下世 = PGCompany.BattlePass.上丕丁专三丗丝万丆.丒不丂一丑丘丄业丁(上业丟世三与七七三:  this.丑丘七丄万丐三下世);
            val_64 = 1152921504848912384;
            if(val_79 == 0)
            {
                    return;
            }
            
            if(val_79 == this._largeWrap)
            {
                    this.SetScrollSize(上专丅业三丏丈丈丗:  this.丑丘七丄万丐三下世.Count);
            }
            
            System.Func<System.Int32> val_62 = null;
            val_64 = val_62;
            val_62 = new System.Func<System.Int32>(object:  val_1, method:  System.Int32 BPGetRewards.丕丛业丁丏下一七丘::不丆丞丑丁万丝丙丞());
            System.Action<UnityEngine.GameObject, System.Int32> val_63 = new System.Action<UnityEngine.GameObject, System.Int32>(object:  this, method:  System.Void PGCompany.BattlePass.BPGetRewards::丂上下丟丕东丁丛不(UnityEngine.GameObject 丕一一丆丌丝丕业万, int 丘丒丌下丕专且七专));
            if(val_79 != 0)
            {
                    val_79.Initialize(下丛一丂不丕东万丐:  val_62, 丆丄丟东专与且丂业:  val_63);
            }
            else
            {
                    0.Initialize(下丛一丂不丕东万丐:  val_62, 丆丄丟东专与且丂业:  val_63);
            }
            
            val_79.UpdateVisibleCells();
            return;
            label_69:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._noPremHint, 丏业丟一东丂东丘丛:  false);
            val_89 = this._tutoriaHint;
            val_90 = 1;
            label_72:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_89, 丏业丟一东丂东丘丛:  true);
            goto label_135;
        }
        private void 丂上下丟丕东丁丛不(UnityEngine.GameObject 丕一一丆丌丝丕业万, int 丘丒丌下丕专且七专)
        {
            if(this.丑丘七丄万丐三下世.Count > 丘丒丌下丕专且七专)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丕一一丆丌丝丕业万, 丏业丟一东丂东丘丛:  true);
                PGCompany.BattlePass.BPRewardView val_2 = 丕一一丆丌丝丕业万.GetComponent<PGCompany.BattlePass.BPRewardView>();
                if(val_2 != 0)
            {
                    val_2.<丅丝丌丝丁丏丙东丞>k__BackingField = this.丑丘七丄万丐三下世.Item[丘丒丌下丕专且七专];
                val_2.丝一丅丆三东丂丞七();
                val_2.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BPRewardView>(object:  this, method:  System.Void PGCompany.BattlePass.BPGetRewards::丒丂丙丂一丞丟且万(PGCompany.BattlePass.BPRewardView 丁世丛业丟下丕三丟)));
                val_2.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BPRewardView>(object:  this, method:  System.Void PGCompany.BattlePass.BPGetRewards::丒丂丙丂一丞丟且万(PGCompany.BattlePass.BPRewardView 丁世丛业丟下丕三丟)));
                return;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丕一一丆丌丝丕业万, 丏业丟一东丂东丘丛:  false);
        }
        public void SetScrollSize(int 上专丅业三丏丈丈丗)
        {
            int val_5 = 上专丅业三丏丈丈丗;
            val_5 = val_5 * 140;
            UnityEngine.Vector4 val_2 = this._scrollPanel.finalClipRegion;
            int val_3 = UnityEngine.Mathf.Clamp(value:  val_5, min:  74, max:  133);
            int val_4 = (UnityEngine.Mathf.Clamp(value:  val_5, min:  145, max:  116)) + 16;
            val_5 = (val_3 < val_4) ? (val_4) : (val_3);
            this._scrollBorder.width = val_5;
        }
        private void 丒丂丙丂一丞丟且万(PGCompany.BattlePass.BPRewardView 丁世丛业丟下丕三丟)
        {
            if(丁世丛业丟下丕三丟 == 0)
            {
                    return;
            }
            
            if((丁世丛业丟下丕三丟.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if((丁世丛业丟下丕三丟.<丅丝丌丝丁丏丙东丞>k__BackingField._item) == null)
            {
                    return;
            }
            
            this = this.transform;
            Rilisoft.ItemViewer val_5 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoViewBattlePass", 丆丏七丟不丒与七专:  this, 丕丁下丌不万丅丞丛:  丁世丛业丟下丕三丟.<丅丝丌丝丁丏丙东丞>k__BackingField._item.Id, 丅三丟世下丞丝丙万:  丁世丛业丟下丕三丟.<丅丝丌丝丁丏丙东丞>k__BackingField._item.Count, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  false);
        }
        public void U_BuyPremium()
        {
            this.Hide();
            if(BattlePassRootUI.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            BattlePassRootUI.丑七不且上丗丁一世().U_BuyPremium();
        }
        public void U_BuyLevel()
        {
            this.Hide();
            if(BattlePassRootUI.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            BattlePassRootUI.丑七不且上丗丁一世().U_BuyLevel();
        }
        public void Hide()
        {
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.gameObject);
            if(PGCompany.BattlePass.BPGetRewards.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            PGCompany.BattlePass.BPGetRewards.丛丄业丘不丆丄三丞.Invoke();
        }
        private void OnDestroy()
        {
            PGCompany.BattlePass.BPGetRewards.<不丁丄七丛不丆丁丕>k__BackingField = 0;
        }
        public BPGetRewards()
        {
        
        }
    
    }

}
