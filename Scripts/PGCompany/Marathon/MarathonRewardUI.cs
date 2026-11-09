using UnityEngine;

namespace PGCompany.Marathon
{
    internal sealed class MarathonRewardUI : PGBehaviour
    {
        // Fields
        private static System.Action<PGCompany.Marathon.MarathonRewardUI> 丁丌丛专业丛丕三丑;
        private static System.Action<PGCompany.Marathon.MarathonRewardUI> 一丈与上世丂丒业世;
        private static System.Action<PGCompany.Marathon.MarathonRewardUI> 丕丟下丈丗丏丅不丘;
        public UIWidget mainWidget;
        private PGCompany.InventoryItemView itemView;
        private UIBasicSprite customTextureUI;
        private UILabel customName;
        private UILabel dayLabel;
        private UnityEngine.GameObject state_NotCollected;
        private UnityEngine.GameObject state_CanCollect;
        private UnityEngine.GameObject state_Collected;
        private UnityEngine.GameObject currentRewardAnimation;
        private UnityEngine.GameObject blinkAnimation;
        private float blinkDuration;
        private UnityEngine.GameObject startCollectAnimation;
        private float startCollectDuration;
        private UnityEngine.GameObject collectedAnimation;
        private float collectedDuration;
        private 丈下与且下万丛丅与 丆三丙上丟且丂丕丟;
        private bool 东业且东丒专丟丁下;
        private PGCompany.Marathon.MarathonRewardUI.丙丟与丐三丐万万丆 丟丄丈上丌东丑丝三;
        private PGCompany.Marathon.MarathonRewardUI.丙丟与丐三丐万万丆 丐业丙丂丛丞丝丗三;
        
        // Properties
        internal 丈下与且下万丛丅与 丈下与且下万丛丅与 { get; }
        public bool 丁丆丌丛世丅丑丛丙 { get; }
        public PGCompany.Marathon.MarathonRewardUI.丙丟与丐三丐万万丆 上丅丑丌丑丏丏丙东 { get; }
        
        // Methods
        internal static void 丈上丛东下丌一丐世(System.Action<PGCompany.Marathon.MarathonRewardUI> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.Marathon.MarathonRewardUI.丁丌丛专业丛丕三丑, b:  丙业与丙丗丝不丈东);
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
        internal static void 丌丘丈丞专下一世丗(System.Action<PGCompany.Marathon.MarathonRewardUI> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.Marathon.MarathonRewardUI.丁丌丛专业丛丕三丑, value:  丙业与丙丗丝不丈东);
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
        internal static void 丂世下丗七丕丏丏丑(System.Action<PGCompany.Marathon.MarathonRewardUI> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.Marathon.MarathonRewardUI.一丈与上世丂丒业世, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.Marathon.MarathonRewardUI.一丈与上世丂丒业世 != 1152921505654611976);
        
        }
        internal static void 一下不专丙上丏丂丈(System.Action<PGCompany.Marathon.MarathonRewardUI> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.Marathon.MarathonRewardUI.一丈与上世丂丒业世, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.Marathon.MarathonRewardUI.一丈与上世丂丒业世 != 1152921505654611976);
        
        }
        internal static void 万且丁丗丗丗丝且丄(System.Action<PGCompany.Marathon.MarathonRewardUI> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.Marathon.MarathonRewardUI.丕丟下丈丗丏丅不丘, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.Marathon.MarathonRewardUI.丕丟下丈丗丏丅不丘 != 1152921505654611984);
        
        }
        internal static void 业下丞七一下七丐丞(System.Action<PGCompany.Marathon.MarathonRewardUI> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.Marathon.MarathonRewardUI.丕丟下丈丗丏丅不丘, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.Marathon.MarathonRewardUI.丕丟下丈丗丏丅不丘 != 1152921505654611984);
        
        }
        internal 丈下与且下万丛丅与 丆丏丂丂三丒上一与()
        {
            return (丈下与且下万丛丅与)this.丆三丙上丟且丂丕丟;
        }
        public bool get_StartCollectPlaying()
        {
            return (bool)this.东业且东丒专丟丁下;
        }
        private void OnEnable()
        {
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.currentRewardAnimation, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.blinkAnimation, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.startCollectAnimation, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.collectedAnimation, 丏业丟一东丂东丘丛:  false);
            PGCompany.Marathon.且丐丝七丅一丟丕丈.丈三不不丂丄丆世丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.专丟专世丅丂丁且专>(object:  this, method:  System.Void PGCompany.Marathon.MarathonRewardUI::丅万丄丅专丙丒丅世(PGCompany.专丟专世丅丂丁且专 一丗与一专丙丙丅丄)));
            丈下与且下万丛丅与.七七东专世丘一丆丏(丙业与丙丗丝不丈东:  new System.Action<丈下与且下万丛丅与>(object:  this, method:  System.Void PGCompany.Marathon.MarathonRewardUI::丐且丌丟丛万丗丙丑(丈下与且下万丛丅与 丘业丕不丏丂丌丙且)));
        }
        private void OnDisable()
        {
            PGCompany.Marathon.且丐丝七丅一丟丕丈.丄丌专丒丆一专丝丅(丙业与丙丗丝不丈东:  new System.Action<PGCompany.专丟专世丅丂丁且专>(object:  this, method:  System.Void PGCompany.Marathon.MarathonRewardUI::丅万丄丅专丙丒丅世(PGCompany.专丟专世丅丂丁且专 一丗与一专丙丙丅丄)));
            丈下与且下万丛丅与.丆丆丑丒丛七不丈丆(丙业与丙丗丝不丈东:  new System.Action<丈下与且下万丛丅与>(object:  this, method:  System.Void PGCompany.Marathon.MarathonRewardUI::丐且丌丟丛万丗丙丑(丈下与且下万丛丅与 丘业丕不丏丂丌丙且)));
        }
        private void 丅万丄丅专丙丒丅世(PGCompany.专丟专世丅丂丁且专 一丗与一专丙丙丅丄)
        {
            if(this.丆三丙上丟且丂丕丟 == null)
            {
                    return;
            }
            
            PGCompany.专丟专世丅丂丁且专 val_1 = this.丆三丙上丟且丂丕丟.七丈丒丒下下且万与();
            var val_4 = 0;
            val_4 = val_4 + 1;
            if((一丗与一专丙丙丅丄.Equals(other:  ???)) == false)
            {
                    return;
            }
            
            this.StartCollectAnimation();
        }
        private void 丐且丌丟丛万丗丙丑(丈下与且下万丛丅与 丘业丕不丏丂丌丙且)
        {
            var val_4;
            if(丘业丕不丏丂丌丙且 == null)
            {
                    return;
            }
            
            if(this.丆三丙上丟且丂丕丟 == null)
            {
                    return;
            }
            
            val_4 = this.丆三丙上丟且丂丕丟.七丈丒丒下下且万与();
            PGCompany.专丟专世丅丂丁且专 val_2 = 丘业丕不丏丂丌丙且.七丈丒丒下下且万与();
            var val_5 = 0;
            val_5 = val_5 + 1;
            if((val_4.Equals(other:  ???)) == false)
            {
                    return;
            }
            
            this.丆三丙上丟且丂丕丟 = 丘业丕不丏丂丌丙且;
            if(this.东业且东丒专丟丁下 != false)
            {
                    return;
            }
            
            this.丝一丅丆三东丂丞七();
        }
        internal void 丈且东丑丂且万丒丅(丈下与且下万丛丅与 不丟丑丗丙丁丟丐专)
        {
            this.丆三丙上丟且丂丕丟 = 不丟丑丗丙丁丟丐专;
            if(this.东业且东丒专丟丁下 != true)
            {
                    this.丝一丅丆三东丂丞七();
            }
            
            this.东业且东丒专丟丁下 = false;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.startCollectAnimation, 丏业丟一东丂东丘丛:  false);
            this.丟丄丈上丌东丑丝三 = 0;
            this.丝一丅丆三东丂丞七();
        }
        private void 且丞丝丑丛一丝七丞(丈下与且下万丛丅与 不丟丑丗丙丁丟丐专)
        {
            this.丆三丙上丟且丂丕丟 = 不丟丑丗丙丁丟丐专;
            if(this.东业且东丒专丟丁下 != false)
            {
                    return;
            }
            
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            PGCompany.三东丏不丗世丅丌丄 val_11;
            UILabel val_12;
            string val_13;
            var val_14;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.customTextureUI, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.itemView, 丏业丟一东丂东丘丛:  true);
            val_11 = public static PGCompany.三东丏不丗世丅丌丄 System.Linq.Enumerable::FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(System.Collections.Generic.IEnumerable<TSource> source);
            PGCompany.三东丏不丗世丅丌丄 val_1 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.丆三丙上丟且丂丕丟);
            if(this.itemView != null)
            {
                    val_11 = val_1;
                this.itemView.Setup(丈丄不七三万丄丁不:  val_11);
            }
            
            if(this.丆三丙上丟且丂丕丟 != 0)
            {
                    丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.customTextureUI, 与万丆丛丒万丝丙丑:  this.丆三丙上丟且丂丕丟);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.customTextureUI, 丏业丟一东丂东丘丛:  true);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.itemView, 丏业丟一东丂东丘丛:  false);
            }
            
            if((System.String.IsNullOrEmpty(value:  this.丆三丙上丟且丂丕丟.丞丁丑丛三不下丄丑())) == false)
            {
                goto label_12;
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_5 = PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  val_1);
            val_12 = this.customName;
            if(val_5 == null)
            {
                goto label_15;
            }
            
            val_13 = val_5;
            goto label_16;
            label_12:
            val_12 = this.customName;
            val_13 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丆三丙上丟且丂丕丟.丞丁丑丛三不下丄丑());
            val_14 = null;
            goto label_22;
            label_15:
            val_13 = 0;
            label_16:
            val_14 = null;
            label_22:
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_12, 丕丗丘丑丛与丑业丒:  val_13);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.dayLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10298"), arg0:  this.丆三丙上丟且丂丕丟.三万七与东丄业丐丙()));
            this.丕丕业七丙七丅丈丄();
            if(this.丐业丙丂丛丞丝丗三 != 1)
            {
                    return;
            }
            
            if(this.丟丄丈上丌东丑丝三 != 2)
            {
                    return;
            }
            
            if(PGCompany.Marathon.MarathonRewardUI.一丈与上世丂丒业世 == null)
            {
                    return;
            }
            
            PGCompany.Marathon.MarathonRewardUI.一丈与上世丂丒业世.Invoke(obj:  this);
        }
        private void 丕丕业七丙七丅丈丄()
        {
            var val_5;
            UnityEngine.GameObject val_6;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_NotCollected, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_CanCollect, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Collected, 丏业丟一东丂东丘丛:  false);
            this.丐业丙丂丛丞丝丗三 = this.丟丄丈上丌东丑丝三;
            if((this.丆三丙上丟且丂丕丟.与不丞丑七丘丁丂丛().丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "can-collect")) != false)
            {
                    this.丟丄丈上丌东丑丝三 = 2;
                val_5 = null;
                val_6 = this.state_CanCollect;
            }
            else
            {
                    if((this.丆三丙上丟且丂丕丟.与不丞丑七丘丁丂丛().丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "collected")) != false)
            {
                    this.丟丄丈上丌东丑丝三 = 3;
                val_5 = null;
                val_6 = this.state_Collected;
            }
            else
            {
                    this.丟丄丈上丌东丑丝三 = 1;
                val_5 = null;
                val_6 = this.state_NotCollected;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  true);
        }
        public void CurrentRewardAnimation(bool 丛丅丘一丏丙且丌上)
        {
            丛丅丘一丏丙且丌上 = 丛丅丘一丏丙且丌上;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.currentRewardAnimation, 丏业丟一东丂东丘丛:  丛丅丘一丏丙且丌上);
        }
        public void BlinkAnimation()
        {
            if(this.丟丄丈上丌东丑丝三 != 1)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.blinkAnimation, 丏业丟一东丂东丘丛:  true);
            UnityEngine.Coroutine val_2 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void PGCompany.Marathon.MarathonRewardUI::丘丝丏专丟丞万丐丄()), 丆丐七丅丆丗丛上与:  this.blinkDuration);
        }
        public void StartCollectAnimation()
        {
            this.东业且东丒专丟丁下 = true;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.startCollectAnimation, 丏业丟一东丂东丘丛:  true);
            UnityEngine.Coroutine val_2 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void PGCompany.Marathon.MarathonRewardUI::丂丁丈万世七上丛丝()), 丆丐七丅丆丗丛上与:  this.startCollectDuration);
        }
        public void CollectedAnimation()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.collectedAnimation, 丏业丟一东丂东丘丛:  true);
            UnityEngine.Coroutine val_2 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void PGCompany.Marathon.MarathonRewardUI::上丈万世丄丈万丑丛()), 丆丐七丅丆丗丛上与:  this.collectedDuration);
        }
        public void U_OnClickReward()
        {
            if(PGCompany.Marathon.MarathonRewardUI.丁丌丛专业丛丕三丑 == null)
            {
                    return;
            }
            
            PGCompany.Marathon.MarathonRewardUI.丁丌丛专业丛丕三丑.Invoke(obj:  this);
        }
        public PGCompany.Marathon.MarathonRewardUI.丙丟与丐三丐万万丆 get_CurrentState()
        {
            return (丙丟与丐三丐万万丆)this.丟丄丈上丌东丑丝三;
        }
        public MarathonRewardUI()
        {
            this.blinkDuration = 3f;
            this.startCollectDuration = 1f;
            this.collectedDuration = 1f;
        }
        private void 丘丝丏专丟丞万丐丄()
        {
            if(this == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.blinkAnimation, 丏业丟一东丂东丘丛:  false);
        }
        private void 丂丁丈万世七上丛丝()
        {
            if(this == 0)
            {
                    return;
            }
            
            this.东业且东丒专丟丁下 = false;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.startCollectAnimation, 丏业丟一东丂东丘丛:  false);
            this.丝一丅丆三东丂丞七();
            this.CollectedAnimation();
            if(PGCompany.Marathon.MarathonRewardUI.丕丟下丈丗丏丅不丘 == null)
            {
                    return;
            }
            
            PGCompany.Marathon.MarathonRewardUI.丕丟下丈丗丏丅不丘.Invoke(obj:  this);
        }
        private void 上丈万世丄丈万丑丛()
        {
            if(this == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.collectedAnimation, 丏业丟一东丂东丘丛:  false);
        }
    
    }

}
