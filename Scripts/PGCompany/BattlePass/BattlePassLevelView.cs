using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BattlePassLevelView : MonoBehaviour
    {
        // Fields
        internal static readonly System.Collections.Generic.List<PGCompany.BattlePass.BattlePassLevelView> 上且七丑与丕丘丒丅;
        private int 丞三丟上与丗丆丕丏;
        private int 丑与丗一丘下丆丐丅;
        private int 世丐丂专上专丌丅丟;
        internal static float 世丑上丝上且丌丌丟;
        private UnityEngine.Coroutine 丛丘丒丛丟世万与世;
        private UILabel _levelLabel;
        private UILabel _progressLabel;
        private UIBasicSprite _progressSprite;
        private UIBasicSprite _updatedProgressSprite;
        
        // Methods
        private void OnEnable()
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            if((PGCompany.BattlePass.BattlePassLevelView.上且七丑与丕丘丒丅.Contains(item:  this)) != true)
            {
                    val_5 = null;
                val_5 = null;
                PGCompany.BattlePass.BattlePassLevelView.上且七丑与丕丘丒丅.Add(item:  this);
            }
            
            PGCompany.BattlePass.上丕丁专三丗丝万丆.专且丈丕丄且丂丒业(丙业与丙丗丝不丈东:  new System.Action<丘丂丐世专丂下丞丈, System.Object>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassLevelView::业丅丛丈丕丏丁丝丁(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)));
            PGCompany.BattlePass.上丕丁专三丗丝万丆.丛丒丂世且不丂丝丐(丙业与丙丗丝不丈东:  new System.Action<丘丂丐世专丂下丞丈, System.Object>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassLevelView::业丅丛丈丕丏丁丝丁(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)));
            this.丑丅丂丐丂不丂丝丞();
        }
        private void OnDisable()
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            if((PGCompany.BattlePass.BattlePassLevelView.上且七丑与丕丘丒丅.Contains(item:  this)) != false)
            {
                    val_6 = null;
                val_6 = null;
                bool val_2 = PGCompany.BattlePass.BattlePassLevelView.上且七丑与丕丘丒丅.Remove(item:  this);
            }
            
            if(this._updatedProgressSprite != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._updatedProgressSprite, 丏业丟一东丂东丘丛:  false);
            }
            
            PGCompany.BattlePass.上丕丁专三丗丝万丆.专且丈丕丄且丂丒业(丙业与丙丗丝不丈东:  new System.Action<丘丂丐世专丂下丞丈, System.Object>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassLevelView::业丅丛丈丕丏丁丝丁(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)));
        }
        private void OnDestroy()
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            if((PGCompany.BattlePass.BattlePassLevelView.上且七丑与丕丘丒丅.Contains(item:  this)) != false)
            {
                    val_6 = null;
                val_6 = null;
                bool val_2 = PGCompany.BattlePass.BattlePassLevelView.上且七丑与丕丘丒丅.Remove(item:  this);
            }
            
            if(this._updatedProgressSprite != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._updatedProgressSprite, 丏业丟一东丂东丘丛:  false);
            }
            
            PGCompany.BattlePass.上丕丁专三丗丝万丆.专且丈丕丄且丂丒业(丙业与丙丗丝不丈东:  new System.Action<丘丂丐世专丂下丞丈, System.Object>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassLevelView::业丅丛丈丕丏丁丝丁(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)));
        }
        private void 业丅丛丈丕丏丁丝丁(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)
        {
            if(this.丛丘丒丛丟世万与世 != null)
            {
                    this.StopCoroutine(routine:  this.丛丘丒丛丟世万与世);
            }
            
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_2 == null)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.丌与丙丕且丑丂下丝(丈丘丝一丗下丈丐不:  val_2.业丈丅丂且丁与丄丂(), 丘丄丙七上下丄丂丄:  val_2.丞专三世丑丗丘专丐(), 丏丟与下业丑丘且丂:  val_2.一不丁丏万丂丑三不(), 三丂东专丕专业丏万:  true));
        }
        private void 丑丅丂丐丂不丂丝丞()
        {
            UIBasicSprite val_15;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_2 == null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._levelLabel, 丕丗丘丑丛与丑业丒:  val_2.业丈丅丂且丁与丄丂().ToString());
            int val_5 = val_2.丞专三世丑丗丘专丐();
            int val_6 = val_2.一不丁丏万丂丑三不();
            if(this._progressLabel != 0)
            {
                    if(val_2.丐丞上丒七丞丁丙丕() != false)
            {
                    string val_9 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6073");
            }
            
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._progressLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/{1}", arg0:  val_5, arg1:  val_6));
            }
            
            if(this._progressSprite != 0)
            {
                    float val_14 = (float)val_5;
                val_14 = val_14 / (float)val_6;
                this._progressSprite.fillAmount = val_14;
            }
            
            val_15 = this._updatedProgressSprite;
            if(val_15 != 0)
            {
                    val_15 = this._updatedProgressSprite;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_15, 丏业丟一东丂东丘丛:  false);
            }
            
            this.丞三丟上与丗丆丕丏 = val_5;
            this.丑与丗一丘下丆丐丅 = val_2.业丈丅丂且丁与丄丂();
            this.世丐丂专上专丌丅丟 = val_6;
        }
        public void AddFakeProgress(int 上丕丈丞丌丘丅不与)
        {
            int val_8;
            int val_9;
            int val_10;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_2 == null)
            {
                    return;
            }
            
            val_8 = val_2.业丈丅丂且丁与丄丂();
            val_9 = val_2.一不丁丏万丂丑三不();
            val_10 = val_2.丞专三世丑丗丘专丐() + 上丕丈丞丌丘丅不与;
            if(val_10 > val_9)
            {
                    val_8 = val_8 + 1;
                if(val_8 == val_2.丄且东且丕丛与丆丒())
            {
                    val_9 = 0;
                val_10 = 0;
            }
            else
            {
                    val_9 = val_2.一丅上世丟下丝丒丂(丈丘丝一丗下丈丐不:  val_8);
            }
            
            }
            
            this.SetFakeProgress(丈丘丝一丗下丈丐不:  val_8, 丘丄丙七上下丄丂丄:  val_10, 丏丟与下业丑丘且丂:  val_9);
        }
        public void SetFakeProgress(int 丈丘丝一丗下丈丐不, int 丘丄丙七上下丄丂丄, int 丏丟与下业丑丘且丂)
        {
            if(this.丛丘丒丛丟世万与世 != null)
            {
                    this.StopCoroutine(routine:  this.丛丘丒丛丟世万与世);
            }
            
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丌与丙丕且丑丂下丝(丈丘丝一丗下丈丐不:  丈丘丝一丗下丈丐不, 丘丄丙七上下丄丂丄:  丘丄丙七上下丄丂丄, 丏丟与下业丑丘且丂:  丏丟与下业丑丘且丂, 三丂东专丕专业丏万:  false));
        }
        private System.Collections.IEnumerator 丌与丙丕且丑丂下丝(int 丈丘丝一丗下丈丐不, int 丘丄丙七上下丄丂丄, int 丏丟与下业丑丘且丂, bool 三丂东专丕专业丏万 = True)
        {
            BattlePassLevelView.丛丐专世丛丄丆三丏 val_1 = new BattlePassLevelView.丛丐专世丛丄丆三丏();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .丈丘丝一丗下丈丐不 = 丈丘丝一丗下丈丐不;
                .丘丄丙七上下丄丂丄 = 丘丄丙七上下丄丂丄;
                .丏丟与下业丑丘且丂 = 丏丟与下业丑丘且丂;
            }
            else
            {
                    mem[40] = this;
                mem[32] = 丈丘丝一丗下丈丐不;
                mem[48] = 丘丄丙七上下丄丂丄;
                .丏丟与下业丑丘且丂 = 丏丟与下业丑丘且丂;
            }
            
            .三丂东专丕专业丏万 = 三丂东专丕专业丏万;
            return (System.Collections.IEnumerator)val_1;
        }
        public BattlePassLevelView()
        {
        
        }
        private static BattlePassLevelView()
        {
            PGCompany.BattlePass.BattlePassLevelView.上且七丑与丕丘丒丅 = new System.Collections.Generic.List<PGCompany.BattlePass.BattlePassLevelView>();
            PGCompany.BattlePass.BattlePassLevelView.世丑上丝上且丌丌丟 = 0f;
        }
    
    }

}
