using UnityEngine;

namespace PGCompany.Marathon
{
    internal sealed class MarathonView : PGBehaviour
    {
        // Fields
        private static PGCompany.Marathon.MarathonView 丝业丆丁业三丈丟东;
        private UnityEngine.GameObject firstBanner;
        private UnityEngine.GameObject lastBanner;
        private WidgetLayout containerLayout;
        private ScrollViewHelper scrollHelper;
        private MiniPoolGroup poolGroup;
        private PGCompany.TimerUI timerUI;
        private UnityEngine.GameObject button_CollectReward;
        private UnityEngine.GameObject button_ScrollToCurrent;
        private UnityEngine.GameObject button_ScrollToMega;
        private UnityEngine.GameObject button_Back;
        private UnityEngine.AudioClip onSetup;
        private UnityEngine.AudioClip rewardPressed;
        private UnityEngine.AudioClip rewardCollect;
        private UnityEngine.AudioClip canCollectReward;
        private System.Collections.Generic.List<PGCompany.Marathon.MarathonRewardsContainerUI> 丞丆上丞且业东一丒;
        private System.Collections.Generic.List<PGCompany.Marathon.MarathonRewardUI> 下丒丝丕东丒丌丁丈;
        private PGCompany.Marathon.MarathonRewardUI 丂上世世丐与东东丒;
        private PGCompany.Marathon.MarathonRewardUI 七丘下万万东上下一;
        private UnityEngine.Transform promotionInfoUIHolder;
        private PGCompany.StorePromotionInfoUIAbstract 丒丈丞丁丌丗业上业;
        protected System.IDisposable 东丆专丏丝丆丙东世;
        private UnityEngine.Vector3 上丄丗丘丒丒丂丁丈;
        
        // Properties
        internal static PGCompany.Marathon.MarathonView 丆丕丝丒不丙且丐丗 { get; }
        internal PGCompany.Marathon.MarathonRewardUI 世不丌一丌东丟且丅 { get; }
        
        // Methods
        internal static PGCompany.Marathon.MarathonView 丑七不且上丗丁一世()
        {
            return (PGCompany.Marathon.MarathonView)PGCompany.Marathon.MarathonView.丝业丆丁业三丈丟东;
        }
        internal PGCompany.Marathon.MarathonRewardUI 丅业且丑丁七上与丌()
        {
            return (PGCompany.Marathon.MarathonRewardUI)this.丂上世世丐与东东丒;
        }
        private void OnEnable()
        {
            PGCompany.Marathon.MarathonView.丝业丆丁业三丈丟东 = this;
            PGCompany.Marathon.且丐丝七丅一丟丕丈.七上丑丝七丒业丈业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Marathon.MarathonView::丟七丄丘七丛世丒丁()));
            PGCompany.Marathon.且丐丝七丅一丟丕丈.丈三不不丂丄丆世丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.专丟专世丅丂丁且专>(object:  this, method:  System.Void PGCompany.Marathon.MarathonView::丅万丄丅专丙丒丅世(PGCompany.专丟专世丅丂丁且专 一丗与一专丙丙丅丄)));
            PGCompany.Marathon.MarathonRewardUI.丈上丛东下丌一丐世(丙业与丙丗丝不丈东:  new System.Action<PGCompany.Marathon.MarathonRewardUI>(object:  this, method:  System.Void PGCompany.Marathon.MarathonView::丅丌丕丅丗东丏不与(PGCompany.Marathon.MarathonRewardUI 丈一丄丑丕丆东下上)));
            PGCompany.Marathon.MarathonRewardUI.万且丁丗丗丗丝且丄(丙业与丙丗丝不丈东:  new System.Action<PGCompany.Marathon.MarathonRewardUI>(object:  this, method:  System.Void PGCompany.Marathon.MarathonView::世丝专与丛丂丆七丅(PGCompany.Marathon.MarathonRewardUI 丈一丄丑丕丆东下上)));
            PGCompany.Marathon.MarathonRewardUI.丂世下丗七丕丏丏丑(丙业与丙丗丝不丈东:  new System.Action<PGCompany.Marathon.MarathonRewardUI>(object:  this, method:  System.Void PGCompany.Marathon.MarathonView::丄丗丈三丑丑世上丅(PGCompany.Marathon.MarathonRewardUI 丈一丄丑丕丆东下上)));
            丈下与且下万丛丅与.七七东专世丘一丆丏(丙业与丙丗丝不丈东:  new System.Action<丈下与且下万丛丅与>(object:  this, method:  System.Void PGCompany.Marathon.MarathonView::丐且丌丟丛万丗丙丑(丈下与且下万丛丅与 丘业丕不丏丂丌丙且)));
            PGCompany.StorePromotionInfoUIAbstract.世丌下与丁与与丛丈(丙业与丙丗丝不丈东:  new System.Action<PGCompany.StorePromotionInfoUIAbstract>(object:  this, method:  System.Void PGCompany.Marathon.MarathonView::丙丈东且丛丞上丏不(PGCompany.StorePromotionInfoUIAbstract 专上丄丂丙下丑东丆)));
        }
        private void OnDisable()
        {
            PGCompany.Marathon.且丐丝七丅一丟丕丈.与且东与丏下三业丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Marathon.MarathonView::丟七丄丘七丛世丒丁()));
            PGCompany.Marathon.且丐丝七丅一丟丕丈.丄丌专丒丆一专丝丅(丙业与丙丗丝不丈东:  new System.Action<PGCompany.专丟专世丅丂丁且专>(object:  this, method:  System.Void PGCompany.Marathon.MarathonView::丅万丄丅专丙丒丅世(PGCompany.专丟专世丅丂丁且专 一丗与一专丙丙丅丄)));
            PGCompany.Marathon.MarathonRewardUI.丌丘丈丞专下一世丗(丙业与丙丗丝不丈东:  new System.Action<PGCompany.Marathon.MarathonRewardUI>(object:  this, method:  System.Void PGCompany.Marathon.MarathonView::丅丌丕丅丗东丏不与(PGCompany.Marathon.MarathonRewardUI 丈一丄丑丕丆东下上)));
            PGCompany.Marathon.MarathonRewardUI.业下丞七一下七丐丞(丙业与丙丗丝不丈东:  new System.Action<PGCompany.Marathon.MarathonRewardUI>(object:  this, method:  System.Void PGCompany.Marathon.MarathonView::世丝专与丛丂丆七丅(PGCompany.Marathon.MarathonRewardUI 丈一丄丑丕丆东下上)));
            PGCompany.Marathon.MarathonRewardUI.一下不专丙上丏丂丈(丙业与丙丗丝不丈东:  new System.Action<PGCompany.Marathon.MarathonRewardUI>(object:  this, method:  System.Void PGCompany.Marathon.MarathonView::丄丗丈三丑丑世上丅(PGCompany.Marathon.MarathonRewardUI 丈一丄丑丕丆东下上)));
            丈下与且下万丛丅与.丆丆丑丒丛七不丈丆(丙业与丙丗丝不丈东:  new System.Action<丈下与且下万丛丅与>(object:  this, method:  System.Void PGCompany.Marathon.MarathonView::丐且丌丟丛万丗丙丑(丈下与且下万丛丅与 丘业丕不丏丂丌丙且)));
            PGCompany.StorePromotionInfoUIAbstract.丆丘世丁丈丅万业专(丙业与丙丗丝不丈东:  new System.Action<PGCompany.StorePromotionInfoUIAbstract>(object:  this, method:  System.Void PGCompany.Marathon.MarathonView::丙丈东且丛丞上丏不(PGCompany.StorePromotionInfoUIAbstract 专上丄丂丙下丑东丆)));
        }
        private void 丟七丄丘七丛世丒丁()
        {
            this.丝一丅丆三东丂丞七();
        }
        private void 丅万丄丅专丙丒丅世(PGCompany.专丟专世丅丂丁且专 一丗与一专丙丙丅丄)
        {
        
        }
        private void 世丝专与丛丂丆七丅(PGCompany.Marathon.MarathonRewardUI 丈一丄丑丕丆东下上)
        {
            this.丝丂丕东专世丅丝丁();
            if(PGCompany.Marathon.且丐丝七丅一丟丕丈.丑三丐丒业丞丘丐丗() == false)
            {
                    return;
            }
            
            this.下丗丈专东丝七专不();
        }
        private void 丐且丌丟丛万丗丙丑(丈下与且下万丛丅与 丘业丕不丏丂丌丙且)
        {
            this.丝丂丕东专世丅丝丁();
            if(this.丂上世世丐与东东丒 == null)
            {
                    return;
            }
            
            this.丂上世世丐与东东丒.BlinkAnimation();
        }
        private void 丄丗丈三丑丑世上丅(PGCompany.Marathon.MarathonRewardUI 丈一丄丑丕丆东下上)
        {
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
            {
                    return;
            }
            
            UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.canCollectReward);
        }
        internal void 丈且东丑丂且万丒丅()
        {
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.onSetup);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.firstBanner, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lastBanner, 丏业丟一东丂东丘丛:  false);
            this.丝一丅丆三东丂丞七();
            this.ScrollToStart(丌与丟丁万丝丞丄丏:  false);
            if(PGCompany.Marathon.且丐丝七丅一丟丕丈.丈专丅丆丄丐下丐丐() != false)
            {
                    this.世丕丈丂丁上世丑丒();
                return;
            }
            
            if(PGCompany.Marathon.且丐丝七丅一丟丕丈.丑三丐丒业丞丘丐丗() != false)
            {
                    this.下丗丈专东丝七专不();
                return;
            }
            
            UnityEngine.Coroutine val_6 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void PGCompany.Marathon.MarathonView::丗上丆丐丅七丏东下()), 业丗七丕万万不丈丗:  1);
        }
        internal void 丝一丅丆三东丂丞七()
        {
            this.世业丒万丘丆专丘丐();
            this.上东与丛丞下丈专丈();
            this.丝丂丕东专世丅丝丁();
        }
        internal void 世业丒万丘丆专丘丐()
        {
            var val_3;
            List.Enumerator<T> val_1 = this.丞丆上丞且业东一丒.GetEnumerator();
            label_6:
            if(((-812294608) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            val_4.世业丒万丘丆专丘丐();
            this.poolGroup.Return(丛丄业丕且丗下一万:  val_4.name, 万且万且丑丗且丌丆:  val_4);
            goto label_6;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.丞丆上丞且业东一丒.Clear();
            List.Enumerator<T> val_6 = this.下丒丝丕东丒丌丁丈.GetEnumerator();
            label_18:
            if(((-812294632) & 1) == 0)
            {
                goto label_15;
            }
            
            string val_7 = 0.丐丏七丌丕丗业且上();
            this.poolGroup.Return(丛丄业丕且丗下一万:  val_7.name, 万且万且丑丗且丌丆:  val_7);
            goto label_18;
            label_15:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.下丒丝丕东丒丌丁丈.Clear();
        }
        private void 上东与丛丞下丈专丈()
        {
            var val_7;
            string val_29;
            var val_30;
            PGCompany.东丑丒丗一丞下丙丙<T> val_1 = PGCompany.东丑丒丗一丞下丙丙<丈下与且下万丛丅与>.万世丅七一专丕丞不();
            bool val_4 = PGCompany.Marathon.且丐丝七丅一丟丕丈.丑七不且上丗丁一世().且业上丞丄丁专不丙(专丂丕丗丗东世丞下: ref  val_1);
            List.Enumerator<T> val_5 = val_1.GetEnumerator();
            val_29 = 0;
            goto label_6;
            label_34:
            string val_8 = val_7.丐丏七丌丕丗业且上();
            if(0 == 0)
            {
                    this.丌丁一丒丘丈丄上丞();
            }
            
            if((val_8.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "view-type.small")) != false)
            {
                    val_30 = "view-type.small";
            }
            else
            {
                    string val_13 = ((val_8.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "view-type.large")) != true) ? "view-type.large" : 0;
            }
            
            if((System.String.op_Inequality(a:  val_13, b:  val_29)) != true)
            {
                    if(0 != 0)
            {
                goto label_17;
            }
            
            }
            
            PGCompany.Marathon.MarathonRewardsContainerUI val_16 = this.poolGroup.Get<PGCompany.Marathon.MarathonRewardsContainerUI>(丛丄业丕且丗下一万:  "Marathon/Prefabs/RewardsContainer");
            val_16.transform.SetParent(p:  this.containerLayout.transform);
            丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_16.transform);
            val_16.addAditinalSpacing = false;
            this.丞丆上丞且业东一丒.Add(item:  val_16);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_16, 丏业丟一东丂东丘丛:  true);
            val_16.layoutType = System.String.op_Equality(a:  val_13, b:  "view-type.small");
            label_17:
            PGCompany.Marathon.MarathonRewardUI val_24 = this.poolGroup.Get<PGCompany.Marathon.MarathonRewardUI>(丛丄业丕且丗下一万:  "Marathon/Prefabs/"("Marathon/Prefabs/") + val_8.丄下丕丗一丙丑丝一());
            val_24.丈且东丑丂且万丒丅(不丟丑丗丙丁丟丐专:  val_8);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_24, 丏业丟一东丂东丘丛:  true);
            this.下丒丝丕东丒丌丁丈.Add(item:  val_24);
            val_16.业丏丗丐丂业东丂丗(丈一丄丑丕丆东下上:  val_24);
            val_29 = val_13;
            label_6:
            if(((-812043120) & 1) != 0)
            {
                goto label_34;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((System.Linq.Enumerable.LastOrDefault<PGCompany.Marathon.MarathonRewardsContainerUI>(source:  this.丞丆上丞且业东一丒)) != 0)
            {
                    val_25.addAditinalSpacing = true;
            }
            
            List.Enumerator<T> val_27 = this.丞丆上丞且业东一丒.GetEnumerator();
            label_68:
            if(((-812043144) & 1) == 0)
            {
                goto label_66;
            }
            
            0.丐丏七丌丕丗业且上().丁下丏丙一丗下丈七();
            goto label_68;
            label_66:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.containerLayout.CollectWidgets();
            this.containerLayout.Reposition();
        }
        private void 丌丁一丒丘丈丄上丞()
        {
            PGCompany.Marathon.MarathonRewardsContainerUI val_1 = this.poolGroup.Get<PGCompany.Marathon.MarathonRewardsContainerUI>(丛丄业丕且丗下一万:  "Marathon/Prefabs/RewardsContainer");
            val_1.transform.SetParent(p:  this.containerLayout.transform);
            丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_1.transform);
            if(val_1 != null)
            {
                    val_1.addAditinalSpacing = true;
            }
            else
            {
                    mem[120] = 1;
            }
            
            val_1.layoutType = 1;
            this.丞丆上丞且业东一丒.Add(item:  val_1);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_1, 丏业丟一东丂东丘丛:  true);
        }
        private void 丝丂丕东专世丅丝丁()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.timerUI, 丏业丟一东丂东丘丛:  false);
            this.button_CollectReward.SetActive(value:  false);
            if(PGCompany.Marathon.且丐丝七丅一丟丕丈.丑七不且上丗丁一世().丐丘不丈丝丒丕丑业() >= 1)
            {
                    this.timerUI.丏丗丐丝丞丆一丙与(下上丐丆丝丟丝丒不:  "Key_10274");
                this.timerUI.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  PGCompany.Marathon.且丐丝七丅一丟丕丈.丑七不且上丗丁一世().丐丘不丈丝丒丕丑业(), 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void PGCompany.Marathon.MarathonView::丝一丅丆三东丂丞七()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.timerUI, 丏业丟一东丂东丘丛:  true);
            }
            
            if(this.丂上世世丐与东东丒 != null)
            {
                    this.丂上世世丐与东东丒.CurrentRewardAnimation(丛丅丘一丏丙且丌上:  false);
            }
            
            this.七丘下万万东上下一 = System.Linq.Enumerable.LastOrDefault<PGCompany.Marathon.MarathonRewardUI>(source:  this.下丒丝丕东丒丌丁丈);
            PGCompany.Marathon.MarathonRewardUI val_7 = this.上专下丌丛丝丄丌不();
            this.丂上世世丐与东东丒 = val_7;
            if(val_7 == null)
            {
                    return;
            }
            
            val_7.CurrentRewardAnimation(丛丅丘一丏丙且丌上:  true);
        }
        private void 丅丌丕丅丗东丏不与(PGCompany.Marathon.MarathonRewardUI 丈一丄丑丕丆东下上)
        {
            if((丈一丄丑丕丆东下上.丆三丙上丟且丂丕丟.与不丞丑七丘丁丂丛().丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "can-collect")) != false)
            {
                    if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioSource val_4 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.rewardCollect);
            }
            
                PGCompany.Marathon.且丐丝七丅一丟丕丈.丑七不且上丗丁一世().且丞丅丘七三万丐东(且丘丏丁丑与丙与丁:  丈一丄丑丕丆东下上.丆三丙上丟且丂丕丟);
                return;
            }
            
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioSource val_7 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.rewardPressed);
            }
            
            this.万东三丈上丙丈丆下(丈一丄丑丕丆东下上:  丈一丄丑丕丆东下上);
        }
        private void 万东三丈上丙丈丆下(PGCompany.Marathon.MarathonRewardUI 丈一丄丑丕丆东下上)
        {
            PGCompany.StorePromotionInfoUIAbstract val_16;
            PGCompany.StorePromotionInfoUIAbstract val_17;
            val_16 = 丈一丄丑丕丆东下上.丆三丙上丟且丂丕丟;
            if(val_16.Count == 0)
            {
                    return;
            }
            
            if(丈一丄丑丕丆东下上.丆三丙上丟且丂丕丟.Count == 1)
            {
                    Rilisoft.ItemViewer val_5 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  this.丌丟丄业且三丛丕丄(), 丈丄不七三万丄丁不:  System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  丈一丄丑丕丆东下上.丆三丙上丟且丂丕丟), 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 丒不业且丄丅世世下:  false);
                return;
            }
            
            val_16 = this.丒丈丞丁丌丗业上业;
            if(val_16 != 0)
            {
                    val_16 = this.丒丈丞丁丌丗业上业;
            }
            
            if(丈一丄丑丕丆东下上.丆三丙上丟且丂丕丟 == null)
            {
                    return;
            }
            
            PGCompany.StorePromotionInfoUIAbstract val_8 = this.poolGroup.Get<PGCompany.StorePromotionInfoUIAbstract>(丛丄业丕且丗下一万:  丈一丄丑丕丆东下上.丆三丙上丟且丂丕丟.丐万丐丌丌丆丒丐丝());
            this.丒丈丞丁丌丗业上业 = val_8;
            if(val_8 != 0)
            {
                goto label_19;
            }
            
            UnityEngine.Debug.LogError(message:  System.String.Format(format:  "No info prefab with name: {0} for promotion: {1}", arg0:  丈一丄丑丕丆东下上.丆三丙上丟且丂丕丟.丐万丐丌丌丆丒丐丝(), arg1:  丈一丄丑丕丆东下上.丆三丙上丟且丂丕丟.七丈丒丒下下且万与()));
            val_17 = this.poolGroup.Get<PGCompany.StorePromotionInfoUIAbstract>(丛丄业丕且丗下一万:  "MainStorePromotion/MainStorePromo_InfoUI");
            this.丒丈丞丁丌丗业上业 = val_17;
            if(val_17 != null)
            {
                goto label_27;
            }
            
            goto label_26;
            label_19:
            val_17 = this.丒丈丞丁丌丗业上业;
            if(val_17 != null)
            {
                goto label_27;
            }
            
            label_26:
            label_27:
            val_17.transform.SetParent(p:  this.promotionInfoUIHolder);
            丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  this.丒丈丞丁丌丗业上业.transform);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丒丈丞丁丌丗业上业, 丏业丟一东丂东丘丛:  true);
            if(this.丒丈丞丁丌丗业上业 == null)
            {
                
            }
        
        }
        private void 丙丈东且丛丞上丏不(PGCompany.StorePromotionInfoUIAbstract 专上丄丂丙下丑东丆)
        {
            PGCompany.StorePromotionInfoUIAbstract val_4 = this.丒丈丞丁丌丗业上业;
            if(专上丄丂丙下丑东丆 != val_4)
            {
                    return;
            }
            
            if(this.丒丈丞丁丌丗业上业 == 0)
            {
                    return;
            }
            
            val_4 = this.丒丈丞丁丌丗业上业;
            this.poolGroup.Return(丛丄业丕且丗下一万:  this.丒丈丞丁丌丗业上业.name, 万且万且丑丗且丌丆:  val_4);
            this.丒丈丞丁丌丗业上业 = 0;
        }
        internal PGCompany.Marathon.MarathonRewardUI 上专下丌丛丝丄丌不()
        {
            var val_7;
            System.Func<PGCompany.Marathon.MarathonRewardUI, System.Boolean> val_9;
            UnityEngine.Object val_10;
            var val_11;
            val_7 = 53176;
            if(((0 & 2) != 0) && (123443624 == 0))
            {
                    val_7 = null;
            }
            
            val_9 = MarathonView.<>c.<>9__41_0;
            if(val_9 == null)
            {
                    System.Func<PGCompany.Marathon.MarathonRewardUI, System.Boolean> val_1 = null;
                val_9 = val_1;
                val_1 = new System.Func<PGCompany.Marathon.MarathonRewardUI, System.Boolean>(object:  MarathonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MarathonView.<>c::世东丒一丒丕丒万万(PGCompany.Marathon.MarathonRewardUI 三丟东丕丄丄下下丑));
                MarathonView.<>c.<>9__41_0 = val_9;
            }
            
            val_10 = System.Linq.Enumerable.FirstOrDefault<PGCompany.Marathon.MarathonRewardUI>(source:  this.下丒丝丕东丒丌丁丈, predicate:  val_1);
            if(val_10 == 0)
            {
                    val_11 = null;
                val_11 = null;
                val_9 = MarathonView.<>c.<>9__41_1;
                if(val_9 == null)
            {
                    System.Func<PGCompany.Marathon.MarathonRewardUI, System.Boolean> val_4 = null;
                val_9 = val_4;
                val_4 = new System.Func<PGCompany.Marathon.MarathonRewardUI, System.Boolean>(object:  MarathonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MarathonView.<>c::丁丒万丟下丒下世三(PGCompany.Marathon.MarathonRewardUI 三丟东丕丄丄下下丑));
                MarathonView.<>c.<>9__41_1 = val_9;
            }
            
                val_10 = System.Linq.Enumerable.FirstOrDefault<PGCompany.Marathon.MarathonRewardUI>(source:  this.下丒丝丕东丒丌丁丈, predicate:  val_4);
            }
            
            if(val_10 != 0)
            {
                    return (PGCompany.Marathon.MarathonRewardUI)val_10;
            }
            
            return System.Linq.Enumerable.LastOrDefault<PGCompany.Marathon.MarathonRewardUI>(source:  this.下丒丝丕东丒丌丁丈);
        }
        internal PGCompany.Marathon.MarathonRewardUI 丂不丕丕丟专丁丆且()
        {
            UnityEngine.Object val_9 = 0;
            if(this.丂上世世丐与东东丒 == 0)
            {
                goto label_12;
            }
            
            if(this.丂上世世丐与东东丒.丆三丙上丟且丂丕丟 == null)
            {
                goto label_5;
            }
            
            val_9 = 0;
            if((this.丂上世世丐与东东丒.丆三丙上丟且丂丕丟.丄下丕丗一丙丑丝一().EndsWith(value:  "_small")) == false)
            {
                goto label_12;
            }
            
            PGCompany.Marathon.MarathonRewardsContainerUI val_5 = System.Linq.Enumerable.FirstOrDefault<PGCompany.Marathon.MarathonRewardsContainerUI>(source:  this.丞丆上丞且业东一丒, predicate:  new System.Func<PGCompany.Marathon.MarathonRewardsContainerUI, System.Boolean>(object:  this, method:  System.Boolean PGCompany.Marathon.MarathonView::丄丌与丂丞丒与丒丕(PGCompany.Marathon.MarathonRewardsContainerUI 三丟东丕丄丄下下丑)));
            val_9 = 0;
            if(val_5 == 0)
            {
                goto label_12;
            }
            
            val_9 = val_5.七丒丂丄丐丙七丂与();
            goto label_12;
            label_5:
            val_9 = 0;
            label_12:
            if(val_9 != 0)
            {
                    return (PGCompany.Marathon.MarathonRewardUI)val_9;
            }
            
            return this.上专下丌丛丝丄丌不();
        }
        private void 一丂丑万丒东丏丒丙(bool 丛丅丘一丏丙且丌上)
        {
            if(this.东丆专丏丝丆丙东世 != null)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                this.东丆专丏丝丆丙东世.Dispose();
            }
            
            if(丛丅丘一丏丙且丌上 == true)
            {
                    return;
            }
            
            this.东丆专丏丝丆丙东世 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  "BannerWindowWithBack");
        }
        public void ScrollToCurrentReward(bool 丌与丟丁万丝丞丄丏)
        {
            PGCompany.Marathon.MarathonRewardUI val_1 = this.丂不丕丕丟专丁丆且();
            if(val_1 == 0)
            {
                    return;
            }
            
            this.丛丙东丟丞万不业世(下且丕丘万丂丗上丟:  val_1, 丝丅丞丏丛不与专丝:  丌与丟丁万丝丞丄丏);
        }
        public void ScrollToMeraReward(bool 丌与丟丁万丝丞丄丏)
        {
            this.ScrollToEnd(丌与丟丁万丝丞丄丏:  丌与丟丁万丝丞丄丏);
        }
        public void ScrollToStart(bool 丌与丟丁万丝丞丄丏)
        {
            丌与丟丁万丝丞丄丏 = 丌与丟丁万丝丞丄丏;
            this.scrollHelper.ScrollToStart(丌与丟丁万丝丞丄丏:  丌与丟丁万丝丞丄丏);
        }
        public void ScrollToEnd(bool 丌与丟丁万丝丞丄丏)
        {
            丌与丟丁万丝丞丄丏 = 丌与丟丁万丝丞丄丏;
            this.scrollHelper.ScrollToEnd(丌与丟丁万丝丞丄丏:  丌与丟丁万丝丞丄丏);
        }
        private void 丛丙东丟丞万不业世(PGCompany.Marathon.MarathonRewardUI 下且丕丘万丂丗上丟, bool 丝丅丞丏丛不与专丝)
        {
            UnityEngine.Object val_16;
            float val_17;
            val_16 = 下且丕丘万丂丗上丟;
            if(val_16 == 0)
            {
                    return;
            }
            
            if((this.下丒丝丕东丒丌丁丈.Contains(item:  val_16)) == false)
            {
                    return;
            }
            
            UnityEngine.Matrix4x4 val_4 = this.containerLayout.transform.worldToLocalMatrix;
            val_16 = val_16.transform;
            UnityEngine.Vector3 val_10 = val_16.position;
            万丗丞丂丒世丁丟丟 val_11 = this.丏与丌与下专下丆丁(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_10.x, y = 0f, z = val_10.z});
            if(val_11 == 0)
            {
                goto label_10;
            }
            
            if(val_11 == 1)
            {
                goto label_11;
            }
            
            if(val_11 != 2)
            {
                    return;
            }
            
            this.scrollHelper.ScrollToEnd(丌与丟丁万丝丞丄丏:  丝丅丞丏丛不与专丝);
            return;
            label_10:
            this.scrollHelper.ScrollToStart(丌与丟丁万丝丞丄丏:  丝丅丞丏丛不与专丝);
            return;
            label_11:
            if(this.scrollHelper != null)
            {
                    val_17 = this.scrollHelper.scrollDelta;
            }
            else
            {
                    val_17 = 0f;
            }
            
            this.scrollHelper.ScrollTo(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_10.x, y = 0f, z = val_10.z}, 七丙不一下丞与丞一:  val_17, 丌与丟丁万丝丞丄丏:  丝丅丞丏丛不与专丝);
        }
        private PGCompany.Marathon.MarathonView.万丗丞丂丒世丁丟丟 丏与丌与下专下丆丁(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
        {
            var val_5;
            float val_2 = this.scrollHelper.Panel.width;
            float val_3 = this.containerLayout.GetSize();
            if(val_3 > val_2)
            {
                    val_3 = val_3 - 业丒丝丗与丐丛丟丏.x;
                var val_4 = (val_3 < val_2) ? 2 : (0 + 1);
                return (万丗丞丂丒世丁丟丟)val_5;
            }
            
            val_5 = 0;
            return (万丗丞丂丒世丁丟丟)val_5;
        }
        public void U_CollectRewardPressed()
        {
            if(this.上专下丌丛丝丄丌不() == 0)
            {
                    return;
            }
            
            if((val_1.丆三丙上丟且丂丕丟.与不丞丑七丘丁丂丛().丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "can-collect")) == false)
            {
                    return;
            }
            
            PGCompany.Marathon.且丐丝七丅一丟丕丈.丑七不且上丗丁一世().且丞丅丘七三万丐东(且丘丏丁丑与丙与丁:  val_1.丆三丙上丟且丂丕丟);
        }
        public void UI_ScrollToCurrent()
        {
            this.ScrollToCurrentReward(丌与丟丁万丝丞丄丏:  true);
        }
        public void UI_ScrollToMega()
        {
            this.ScrollToEnd(丌与丟丁万丝丞丄丏:  true);
        }
        private void 世丕丈丂丁上世丑丒()
        {
            this.一丂丑万丒东丏丒丙(丛丅丘一丏丙且丌上:  false);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  66);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.firstBanner, 丏业丟一东丂东丘丛:  true);
            UnityEngine.Coroutine val_3 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void PGCompany.Marathon.MarathonView::不业与业且下丄丙丈()), 业丗七丕万万不丈丗:  1);
        }
        private void 下丗丈专东丝七专不()
        {
            this.一丂丑万丒东丏丒丙(丛丅丘一丏丙且丌上:  false);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  67);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lastBanner, 丏业丟一东丂东丘丛:  true);
            UnityEngine.Debug.LogError(message:  "[MarathonView] ShowLastBanner");
        }
        public void U_HideFirstBanner()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.firstBanner, 丏业丟一东丂东丘丛:  false);
            UnityEngine.Coroutine val_2 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void PGCompany.Marathon.MarathonView::不七专丙丕万丑下丂()), 丆丐七丅丆丗丛上与:  2f);
        }
        public void U_HideLastBanner()
        {
            this.一丂丑万丒东丏丒丙(丛丅丘一丏丙且丌上:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.firstBanner, 丏业丟一东丂东丘丛:  false);
        }
        private bool 七七业丒丟丝丘不丞(PGCompany.Marathon.MarathonRewardUI 丈一丄丑丕丆东下上)
        {
            var val_14;
            var val_15;
            var val_16;
            val_15 = this;
            if(丈一丄丑丕丆东下上 == 0)
            {
                    val_16 = 0;
                return (bool)val_16;
            }
            
            UIPanel val_2 = this.scrollHelper.Panel;
            UIPanel val_3 = this.scrollHelper.Panel;
            val_14 = 丈一丄丑丕丆东下上.transform;
            UnityEngine.Vector3 val_5 = val_14.position;
            val_15 = 丈一丄丑丕丆东下上.mainWidget.width;
            UnityEngine.Vector3 val_10 = this.scrollHelper.Panel.root.transform.localScale;
            float val_13 = (float)val_15;
            val_13 = val_13 * 0.5f;
            val_10.x = val_13 * val_10.x;
            val_10.x = val_5.x + val_10.x;
            val_16 = ((val_10.x > S9) ? 1 : 0) & ((val_10.x < 0) ? 1 : 0);
            return (bool)val_16;
        }
        private void Update()
        {
            UnityEngine.Vector3 val_2 = this.scrollHelper.scrollView.transform.localPosition;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = this.上丄丗丘丒丒丂丁丈, y = V11.16B, z = V10.16B})) != false)
            {
                    PGCompany.Marathon.MarathonRewardUI val_8 = this.丂上世世丐与东东丒;
                val_8 = (~(this.七七业丒丟丝丘不丞(丈一丄丑丕丆东下上:  val_8))) & 1;
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.button_ScrollToCurrent, 丏业丟一东丂东丘丛:  val_8);
                PGCompany.Marathon.MarathonRewardUI val_9 = this.七丘下万万东上下一;
                val_9 = (~(this.七七业丒丟丝丘不丞(丈一丄丑丕丆东下上:  val_9))) & 1;
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.button_ScrollToMega, 丏业丟一东丂东丘丛:  val_9);
            }
            
            UnityEngine.Vector3 val_7 = this.scrollHelper.scrollView.transform.localPosition;
            this.上丄丗丘丒丒丂丁丈 = val_7;
            mem[1152921559633121588] = val_7.y;
            mem[1152921559633121592] = val_7.z;
        }
        public MarathonView()
        {
            this.丞丆上丞且业东一丒 = new System.Collections.Generic.List<PGCompany.Marathon.MarathonRewardsContainerUI>();
            this.下丒丝丕东丒丌丁丈 = new System.Collections.Generic.List<PGCompany.Marathon.MarathonRewardUI>();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            this.上丄丗丘丒丒丂丁丈 = val_3;
            mem[1152921559633283764] = val_3.y;
            mem[1152921559633283768] = val_3.z;
        }
        private void 丗上丆丐丅七丏东下()
        {
            if(this == 0)
            {
                    return;
            }
            
            this.ScrollToCurrentReward(丌与丟丁万丝丞丄丏:  true);
        }
        private bool 丄丌与丂丞丒与丒丕(PGCompany.Marathon.MarathonRewardsContainerUI 三丟东丕丄丄下下丑)
        {
            if(三丟东丕丄丄下下丑 != null)
            {
                    return 三丟东丕丄丄下下丑.丟不下下且业丛丄丏(丈一丄丑丕丆东下上:  this.丂上世世丐与东东丒);
            }
            
            return 三丟东丕丄丄下下丑.丟不下下且业丛丄丏(丈一丄丑丕丆东下上:  this.丂上世世丐与东东丒);
        }
        private void 不业与业且下丄丙丈()
        {
            if(this == 0)
            {
                    return;
            }
            
            this.ScrollToEnd(丌与丟丁万丝丞丄丏:  false);
        }
        private void 不七专丙丕万丑下丂()
        {
            this.ScrollToCurrentReward(丌与丟丁万丝丞丄丏:  true);
            this.一丂丑万丒东丏丒丙(丛丅丘一丏丙且丌上:  true);
        }
    
    }

}
