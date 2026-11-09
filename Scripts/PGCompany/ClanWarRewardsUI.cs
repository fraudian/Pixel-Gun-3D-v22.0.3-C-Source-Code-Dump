using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanWarRewardsUI : BannerWindow
    {
        // Fields
        private static System.Action<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> 专丏丌丅上丄丝万丁;
        private PGTweenerScale scaleTwinner;
        private PGTweenerUILabelInt totalSilverTwinner;
        private PGTweenerUILabelInt buffedSilverTwinner;
        private float silverBuffAnimationDelay;
        private UILabel totalSilverLabel;
        private UILabel buffedSilverLabel;
        private UILabel totalValorLabel;
        private UILabel totalClanRankExpLabel;
        private UIWidget bodyWidget;
        private UnityEngine.GameObject slider;
        private WidgetLayout scrollWidgetLayout;
        private MiniBuffRewardUI miniBuffView;
        private PGCompany.ClanWarRewardCellTaskView scrollItemTaskView;
        private PGCompany.ClanWarRewardEventRaidView scrollItemRaidView;
        private PGCompany.ClanWarRewardEventSiegeView scrollItemSiegeView;
        private int additionalUIsize;
        private int maxUIsize;
        private int 三七丗业丒丁丗丂丞;
        private int 三丄且丒丑丐丁上丈;
        private int 东丅丝丙丆与三且丂;
        private System.Collections.Generic.List<PGCompany.丛丝丏丂东丏专三丁> 世丄丝世丄且丂丕丏;
        private System.Collections.Generic.Dictionary<string, int> 丄上业且七丅丄与丝;
        private System.Collections.Generic.List<string> 丕专七上丁丕丑丂丐;
        private System.Collections.Generic.List<PGCompany.丟与丞丗丌丂万丕丝> 上丅业东丞丞丑且丕;
        private System.Collections.Generic.List<PGCompany.丟与丞丗丌丂万丕丝> 下万三专丕三丟丘下;
        private System.Collections.Generic.List<MiniBuffRewardUI> 万丆七丞丏丁专万一;
        private PGCompany.且丟一七万东丁三上<PGCompany.ClanWarRewardItemViewBase> 世下丈下与丟一丗丅;
        private ObjectListEnabler rewardsEnabler;
        private System.IDisposable 东三世丝丒三一丈丛;
        private PGCompany.三东丏不丗世丅丌丄 三丑东世丐丒一丒丝;
        private PGCompany.三东丏不丗世丅丌丄 与丒丑七专丘万东专;
        private UnityEngine.Coroutine 丝丅丄丝不丘丈专专;
        
        // Methods
        internal static void 不丂东丑丏上丘丏东(System.Action<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.ClanWarRewardsUI.专丏丌丅上丄丝万丁, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 丆丟丏丂世丞一丌丘(System.Action<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.ClanWarRewardsUI.专丏丌丅上丄丝万丁, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        public override void Show()
        {
            var val_9;
            int val_26;
            System.Collections.Generic.List<PGCompany.丛丝丏丂东丏专三丁> val_27;
            this.Show();
            this.三七丗业丒丁丗丂丞 = 0;
            this.三丄且丒丑丐丁上丈 = 0;
            this.东丅丝丙丆与三且丂 = 0;
            this.丄上业且七丅丄与丝 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丆丑下业一业丐丗一();
            this.丕专七上丁丕丑丂丐 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丐丟丏丁业七丈丞丄();
            this.上丅业东丞丞丑且丕.Clear();
            this.下万三专丕三丟丘下.Clear();
            val_26 = this.三丄且丒丑丐丁上丈;
            List.Enumerator<T> val_7 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丟丛上丅七丂七丛下().GetEnumerator();
            label_15:
            if(((-1997234256) & 1) == 0)
            {
                goto label_7;
            }
            
            string val_10 = val_9.丐丏七丌丕丗业且上();
            if(((val_10 & 1) == 0) || ((val_10 & 1) == 0))
            {
                goto label_15;
            }
            
            if(val_10.不业丙丒丂丞下丆丙() == 2)
            {
                    this.上丅业东丞丞丑且丕.Add(item:  val_10);
            }
            
            if(val_10.不业丙丒丂丞下丆丙() != 1)
            {
                goto label_15;
            }
            
            this.下万三专丕三丟丘下.Add(item:  val_10);
            goto label_15;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_27 = PGCompany.丗丕东丈三东丛丒三.丗丞万七丙丐下丟丂(一丈丛业丞与丗丙丄:  this.丄上业且七丅丄与丝);
            System.Collections.Generic.List<PGCompany.丛丝丏丂东丏专三丁> val_14 = PGCompany.丗丕东丈三东丛丒三.丞丄丆丑丄且东丐丆(且一丗丒业丂丅丞丂:  this.上丅业东丞丞丑且丕);
            System.Collections.Generic.List<PGCompany.丛丝丏丂东丏专三丁> val_15 = PGCompany.丗丕东丈三东丛丒三.丞丄丆丑丄且东丐丆(且一丗丒业丂丅丞丂:  this.下万三专丕三丟丘下);
            this.世丄丝世丄且丂丕丏 = PGCompany.丗丕东丈三东丛丒三.丒丌专万丗丞下与下(不丗丅东丐丏丁丘丄:  val_27);
            this.业丙丅业丒丒万丅上(丄东丙丕丞不业丆丞:  val_27);
            this.业丙丅业丒丒万丅上(丄东丙丕丞不业丆丞:  val_14);
            this.业丙丅业丒丒万丅上(丄东丙丕丞不业丆丞:  val_15);
            int val_20 = val_14.Count + val_27.Count;
            val_20 = val_20 + val_15.Count;
            if(val_20 < 1)
            {
                    return;
            }
            
            this.与业丈万七丟丈丒与(丘万丙丟丘丝丒专丕:  this.世丄丝世丄且丂丕丏, 不丗丅东丐丏丁丘丄:  val_27, 丙一东丅丟丈业丙丒:  val_14, 丞丙世专丑丞且世上:  val_15);
            this.世丆丙丛万丂丏与丏(丌丆一一七上丕下丈:  this.世丄丝世丄且丂丕丏, 不丗丅东丐丏丁丘丄:  val_27, 丙一东丅丟丈业丙丒:  val_14, 丞丙世专丑丞且世上:  val_15);
            val_27 = this.totalSilverLabel;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_27, 丕丗丘丑丛与丑业丒:  this.三七丗业丒丁丗丂丞.ToString());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.totalValorLabel, 丕丗丘丑丛与丑业丒:  val_26.ToString());
            val_26 = this.totalClanRankExpLabel;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_26, 丕丗丘丑丛与丑业丒:  this.东丅丝丙丆与三且丂.ToString());
            this.丂世三丛丄丝丒丑丞();
            UnityEngine.Coroutine val_25 = this.StartCoroutine(routine:  this.不丟三丐下丁三东丁());
        }
        private void 业丙丅业丒丒万丅上(System.Collections.Generic.IEnumerable<PGCompany.丛丝丏丂东丏专三丁> 丄东丙丕丞不业丆丞)
        {
            var val_21;
            var val_22;
            var val_25;
            var val_26;
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_21 = 1152921504691191808;
            val_22 = 丄东丙丕丞不业丆丞.GetEnumerator();
            goto label_6;
            label_20:
            var val_24 = 0;
            val_24 = val_24 + 1;
            T val_4 = val_22.Current;
            this.三七丗业丒丁丗丂丞 = val_4.丁丘丕丈丄世丞丁丆() + this.三七丗业丒丁丗丂丞;
            this.三丄且丒丑丐丁上丈 = val_4.丛且丁上业万丟丒丈() + this.三丄且丒丑丐丁上丈;
            this.东丅丝丙丆与三且丂 = val_4.丗三与一业丘世一与() + this.东丅丝丙丆与三且丂;
            label_6:
            var val_25 = 0;
            val_25 = val_25 + 1;
            if(val_22.MoveNext() == true)
            {
                goto label_20;
            }
            
            val_25 = 0;
            val_26 = 0;
            if(val_22 == null)
            {
                
            }
            else
            {
                    var val_26 = 0;
                val_26 = val_26 + 1;
                val_22.Dispose();
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_22 = ???;
            val_25 = ???;
            val_21 = ???;
        }
        private void 世丆丙丛万丂丏与丏(System.Collections.Generic.List<PGCompany.丛丝丏丂东丏专三丁> 丌丆一一七上丕下丈, System.Collections.Generic.List<PGCompany.丛丝丏丂东丏专三丁> 不丗丅东丐丏丁丘丄, System.Collections.Generic.List<PGCompany.丛丝丏丂东丏专三丁> 丙一东丅丟丈业丙丒, System.Collections.Generic.List<PGCompany.丛丝丏丂东丏专三丁> 丞丙世专丑丞且世上)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.slider, 丏业丟一东丂东丘丛:  false);
            int val_2 = this.additionalUIsize + (int)this.scrollWidgetLayout.GetSize();
            if(val_2 > this.maxUIsize)
            {
                    this.bodyWidget.height = this.maxUIsize;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.slider, 丏业丟一东丂东丘丛:  true);
                return;
            }
            
            this.bodyWidget.height = val_2;
        }
        private void 与业丈万七丟丈丒与(System.Collections.Generic.List<PGCompany.丛丝丏丂东丏专三丁> 丘万丙丟丘丝丒专丕, System.Collections.Generic.List<PGCompany.丛丝丏丂东丏专三丁> 不丗丅东丐丏丁丘丄, System.Collections.Generic.List<PGCompany.丛丝丏丂东丏专三丁> 丙一东丅丟丈业丙丒, System.Collections.Generic.List<PGCompany.丛丝丏丂东丏专三丁> 丞丙世专丑丞且世上)
        {
            var val_3;
            var val_40;
            PGCompany.且丟一七万东丁三上<PGCompany.ClanWarRewardItemViewBase> val_41;
            this.丆丗一丐与东与不丙();
            List.Enumerator<T> val_1 = 丘万丙丟丘丝丒专丕.GetEnumerator();
            val_40 = 1152921554149763664;
            label_11:
            if(((-1996518192) & 1) == 0)
            {
                goto label_2;
            }
            
            MiniBuffRewardUI val_5 = UnityEngine.Object.Instantiate<MiniBuffRewardUI>(original:  this.miniBuffView);
            val_5.丈且东丑丂且万丒丅(丒不专世丙丝丑业万:  val_3.丐丏七丌丕丗业且上());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  true);
            this.scrollWidgetLayout.AddElement(世丌丌丙丞丟下东丞:  val_5.widget);
            this.万丆七丞丏丁专万一.Add(item:  val_5);
            goto label_11;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            int[] val_6 = new int[3];
            val_6[0] = 不丗丅东丐丏丁丘丄.Count;
            val_6[0] = 丙一东丅丟丈业丙丒.Count;
            val_6[1] = 丞丙世专丑丞且世上.Count;
            int val_10 = UnityEngine.Mathf.Max(values:  val_6);
            if(val_10 >= 1)
            {
                    val_40 = 1152921554149797488;
                var val_40 = 0;
                do
            {
                if(val_40 < 不丗丅东丐丏丁丘丄.Count)
            {
                    val_41 = this.世下丈下与丟一丗丅;
                if((val_41.ContainsKey(下上丐丆丝丟丝丒不:  不丗丅东丐丏丁丘丄.Item[0].业上丙丞丐丄丆丅七())) != true)
            {
                    val_41 = UnityEngine.Object.Instantiate<PGCompany.ClanWarRewardCellTaskView>(original:  this.scrollItemTaskView);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_41, 丏业丟一东丂东丘丛:  true);
                val_41.上丛丌丆丑上七世三(丗七丟丈三不丕一三:  不丗丅东丐丏丁丘丄.Item[0]);
                this.世下丈下与丟一丗丅.Add(下上丐丆丝丟丝丒不:  不丗丅东丐丏丁丘丄.Item[0].业上丙丞丐丄丆丅七(), 丙业与丙丗丝不丈东:  val_41);
                val_40 = 1152921554149797488;
            }
            
            }
            
                if(val_40 < 丙一东丅丟丈业丙丒.Count)
            {
                    val_41 = this.世下丈下与丟一丗丅;
                if((val_41.ContainsKey(下上丐丆丝丟丝丒不:  丙一东丅丟丈业丙丒.Item[0].业上丙丞丐丄丆丅七())) != true)
            {
                    val_41 = UnityEngine.Object.Instantiate<PGCompany.ClanWarRewardEventRaidView>(original:  this.scrollItemRaidView);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_41, 丏业丟一东丂东丘丛:  true);
                val_41.上丛丌丆丑上七世三(丗七丟丈三不丕一三:  丙一东丅丟丈业丙丒.Item[0]);
                this.世下丈下与丟一丗丅.Add(下上丐丆丝丟丝丒不:  丙一东丅丟丈业丙丒.Item[0].业上丙丞丐丄丆丅七(), 丙业与丙丗丝不丈东:  val_41);
                val_40 = 1152921554149797488;
            }
            
            }
            
                if(val_40 < 丞丙世专丑丞且世上.Count)
            {
                    val_41 = this.世下丈下与丟一丗丅;
                if((val_41.ContainsKey(下上丐丆丝丟丝丒不:  丞丙世专丑丞且世上.Item[0].业上丙丞丐丄丆丅七())) != true)
            {
                    val_41 = UnityEngine.Object.Instantiate<PGCompany.ClanWarRewardEventSiegeView>(original:  this.scrollItemSiegeView);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_41, 丏业丟一东丂东丘丛:  true);
                val_41.上丛丌丆丑上七世三(丗七丟丈三不丕一三:  丞丙世专丑丞且世上.Item[0]);
                this.世下丈下与丟一丗丅.Add(下上丐丆丝丟丝丒不:  丞丙世专丑丞且世上.Item[0].业上丙丞丐丄丆丅七(), 丙业与丙丗丝不丈东:  val_41);
                val_40 = 1152921554149797488;
            }
            
            }
            
                val_40 = val_40 + 1;
            }
            while(val_10 != val_40);
            
            }
            
            System.Collections.Generic.List<TSource> val_36 = System.Linq.Enumerable.ToList<PGCompany.ClanWarRewardItemViewBase>(source:  this.世下丈下与丟一丗丅.Values);
            if(val_36 != null)
            {
                    val_36.Sort();
            }
            else
            {
                    0.Sort();
            }
            
            List.Enumerator<T> val_37 = val_36.GetEnumerator();
            label_83:
            if(((-1996518216) & 1) == 0)
            {
                goto label_80;
            }
            
            this.scrollWidgetLayout.AddElement(世丌丌丙丞丟下东丞:  0.丐丏七丌丕丗业且上().专丘丝丅丝丟万丅与());
            goto label_83;
            label_80:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.scrollWidgetLayout.Reposition();
        }
        public void GetRewards()
        {
            null = null;
            丌丅且丗七丘丅丛丑.与丒丌丏丝丑与丌世.Clear();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  226);
            System.Collections.Generic.List<PGCompany.丛丝丏丂东丏专三丁> val_2 = PGCompany.丗丕东丈三东丛丒三.丒丁丙丙丒且上万一(一丈丛业丞与丗丙丄:  this.丄上业且七丅丄与丝);
            System.Collections.Generic.List<PGCompany.丛丝丏丂东丏专三丁> val_3 = PGCompany.丗丕东丈三东丛丒三.丒一丄丝丒丁丈丙丈(且一丗丒业丂丅丞丂:  this.下万三专丕三丟丘下);
            System.Collections.Generic.List<PGCompany.丛丝丏丂东丏专三丁> val_4 = PGCompany.丗丕东丈三东丛丒三.丒一丄丝丒丁丈丙丈(且一丗丒业丂丅丞丂:  this.上丅业东丞丞丑且丕);
            丌丅且丗七丘丅丛丑.丑丕东丝与丆且丏丞(业不七丗东丛下一东:  this.东丅丝丙丆与三且丂);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            if(PGCompany.ClanWarRewardsUI.专丏丌丅上丄丝万丁 != null)
            {
                    PGCompany.ClanWarRewardsUI.专丏丌丅上丄丝万丁.Invoke(obj:  PGCompany.丗丕东丈三东丛丒三.东东丒丌不七一丂丂(丐万丌东丗一丅万丈:  this.世丄丝世丄且丂丕丏));
            }
            
            this.HideSelf();
        }
        internal void 丆丗一丐与东与不丙()
        {
            var val_11;
            var val_12;
            System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32, TValue>> val_1 = this.世下丈下与丟一丗丅.GetEnumerator();
            label_16:
            var val_12 = 0;
            val_12 = val_12 + 1;
            if(val_1.MoveNext() == false)
            {
                goto label_7;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            UnityEngine.Object.Destroy(obj:  val_1.Current.gameObject);
            goto label_16;
            label_7:
            val_11 = 0;
            val_12 = 0;
            if(val_1 == null)
            {
                
            }
            else
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_1.Dispose();
            }
            
            if(( != 1) && (58 == 58))
            {
                    val_11 = 0;
            }
            else
            {
                    if( != false)
            {
                    val_12 = 0;
            }
            
            }
            
            List.Enumerator<T> val_8 = this.万丆七丞丏丁专万一.GetEnumerator();
            label_38:
            if(((-1996003288) & 1) == 0)
            {
                goto label_34;
            }
            
            UnityEngine.Object.Destroy(obj:  0.丐丏七丌丕丗业且上().gameObject);
            goto label_38;
            label_34:
            mem2[0] = 114;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((0 + 1) == 1)
            {
                goto label_43;
            }
            
            if(( == 0) || ((1152921554150451216 + ((0 + 1)) << 2) == 114))
            {
                goto label_51;
            }
            
            label_50:
            label_51:
            this.万丆七丞丏丁专万一.Clear();
            this.世下丈下与丟一丗丅.Clear();
            this.scrollWidgetLayout.widgets.Clear();
            return;
            label_43:
            if( != 0)
            {
                goto label_50;
            }
            
            goto label_51;
        }
        public void U_Hide()
        {
            this.HideSelf();
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  "ClanWarRewardUI_" + this.gameObject.name);
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.东三世丝丒三一丈丛.Dispose();
        }
        private void 丂世三丛丄丝丒丑丞()
        {
            System.Action val_17;
            if(this.丝丅丄丝不丘丈专专 != null)
            {
                    this.StopCoroutine(routine:  this.丝丅丄丝不丘丈专专);
            }
            
            this.totalSilverTwinner.丐上丑丌七下丏丘丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanWarRewardsUI::东业丑下丒且下业丈()));
            this.scaleTwinner.丐上丑丌七下丏丘丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanWarRewardsUI::丘丑丈丟丙丘丐上上()));
            this.rewardsEnabler.remove_onFinish(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanWarRewardsUI::丘丑丈丟丙丘丐上上()));
            this.totalSilverTwinner.丄与丒丂丂丘专丝万();
            this.buffedSilverTwinner.丄与丒丂丂丘专丝万();
            PGCompany.三东丏不丗世丅丌丄 val_4 = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  79);
            this.三丑东世丐丒一丒丝 = val_4;
            val_4.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  this.三七丗业丒丁丗丂丞);
            PGCompany.三东丏不丗世丅丌丄 val_5 = PGCompany.万丞丘与丕丞下万丌.丐丝不七与丑且丟丝(丈丄不七三万丄丁不:  this.三丑东世丐丒一丒丝);
            this.与丒丑七专丘万东专 = val_5;
            val_5.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_5.丂丁丏一丙丛业且丌() - this.三丑东世丐丒一丒丝.丂丁丏一丙丛业且丌());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.buffedSilverLabel, 丏业丟一东丂东丘丛:  (this.与丒丑七专丘万东专.丂丁丏一丙丛业且丌() > 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.buffedSilverLabel, 丕丗丘丑丛与丑业丒:  this.与丒丑七专丘万东专.丂丁丏一丙丛业且丌());
            if(this.与丒丑七专丘万东专.丂丁丏一丙丛业且丌() >= 1)
            {
                    System.Action val_13 = null;
                val_17 = val_13;
                val_13 = new System.Action(object:  this, method:  System.Void PGCompany.ClanWarRewardsUI::丘丑丈丟丙丘丐上上());
                this.scaleTwinner.丁七丙丈丑万丕丆与(丙业与丙丗丝不丈东:  val_13);
                this.丝丅丄丝不丘丈专专 = this.StartCoroutine(routine:  this.丕丘业三丕不丏丄丄());
                return;
            }
            
            System.Action val_16 = null;
            val_17 = val_16;
            val_16 = new System.Action(object:  this, method:  System.Void PGCompany.ClanWarRewardsUI::丘丑丈丟丙丘丐上上());
            this.rewardsEnabler.add_onFinish(丙业与丙丗丝不丈东:  val_16);
        }
        private System.Collections.IEnumerator 丕丘业三丕不丏丄丄()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new ClanWarRewardsUI.丘丟不不一丐丑丞丌();
        }
        private void 东业丑下丒且下业丈()
        {
            this.totalSilverTwinner.丐上丑丌七下丏丘丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanWarRewardsUI::东业丑下丒且下业丈()));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.buffedSilverLabel, 丏业丟一东丂东丘丛:  false);
            this.scaleTwinner.丗万丞丒东万丂丛三();
        }
        private void 丘丑丈丟丙丘丐上上()
        {
            this.scaleTwinner.丐上丑丌七下丏丘丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanWarRewardsUI::丘丑丈丟丙丘丐上上()));
            this.rewardsEnabler.remove_onFinish(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanWarRewardsUI::丘丑丈丟丙丘丐上上()));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
        }
        private System.Collections.IEnumerator 不丟三丐下丁三东丁()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new ClanWarRewardsUI.丌丆七丑一三万东丝();
        }
        public ClanWarRewardsUI()
        {
            this.silverBuffAnimationDelay = 3f;
            this.additionalUIsize = 270;
            this.maxUIsize = 733;
            this.世丄丝世丄且丂丕丏 = new System.Collections.Generic.List<PGCompany.丛丝丏丂东丏专三丁>();
            this.丄上业且七丅丄与丝 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            this.丕专七上丁丕丑丂丐 = new System.Collections.Generic.List<System.String>();
            this.上丅业东丞丞丑且丕 = new System.Collections.Generic.List<PGCompany.丟与丞丗丌丂万丕丝>();
            this.下万三专丕三丟丘下 = new System.Collections.Generic.List<PGCompany.丟与丞丗丌丂万丕丝>();
            this.万丆七丞丏丁专万一 = new System.Collections.Generic.List<MiniBuffRewardUI>();
            this.世下丈下与丟一丗丅 = new PGCompany.且丟一七万东丁三上<PGCompany.ClanWarRewardItemViewBase>();
        }
    
    }

}
