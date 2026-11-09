using UnityEngine;
internal class ClanRankView : MonoBehaviour
{
    // Fields
    private PGCompany.ProgressBarView rankBar;
    private UISprite currentRankSprite;
    private UISprite nextRankSprite;
    private UISprite lastRankSprite;
    private PGCompany.MultiCountingLabel newExpCountLabel;
    private UnityEngine.Animator animator;
    private float newExpVisibleDuration;
    private UnityEngine.GameObject regularContainer;
    private UnityEngine.GameObject lastRankContainer;
    private TweenAlpha countingBarFlash;
    private UnityEngine.GameObject tutorObject;
    private UnityEngine.GameObject rewardNotif;
    private UnityEngine.GameObject soundObject;
    private string 业丂丘丑丐东丝丙丗;
    private string 丙丈丄丑丕丐丈七世;
    private 丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 丂万丝丟丏丅丒业丛;
    private UnityEngine.Coroutine 丌丒丂丗丈丏丈且不;
    
    // Methods
    private void OnEnable()
    {
        丌丅且丗七丘丅丛丑.丈不丄且丐丛与丕丆(丙业与丙丗丝不丈东:  new System.Action<上丑下丆丄下丝东世>(object:  this, method:  System.Void ClanRankView::丞丟丅丅丑丒丗上丞(丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 与上丟丏业专业与专)));
        丌丅且丗七丘丅丛丑.丌业三专丞丆万丏丁(丙业与丙丗丝不丈东:  new System.Action<上丑下丆丄下丝东世>(object:  this, method:  System.Void ClanRankView::丞丟丅丅丑丒丗上丞(丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 与上丟丏业专业与专)));
        丌丅且丗七丘丅丛丑.丞丅丞与丞七丗丏丈(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanRankView::丂丅专丅丒三七丂业(int 专世专丟丝丌与丘上)));
        丌丅且丗七丘丅丛丑.丂一丗东丟丛丘业专(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanRankView::丂丅专丅丒三七丂业(int 专世专丟丝丌与丘上)));
        int val_6 = 丌丅且丗七丘丅丛丑.丛丏丒业丂丅丂丕丐();
        this.丂万丝丟丏丅丒业丛 = 丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与();
        mem[1152921536628726424] = 0;
        this.上不丕丌丄世丆丘丘(下万丗三丛丒丆且丌:  丌丅且丗七丘丅丛丑.丛丏丒业丂丅丂丕丐(), 专且丅丄且丘丟丅业:  丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与());
        this.countingBarFlash.enabled = false;
        this.countingBarFlash.value = 0f;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rewardNotif, 丏业丟一东丂东丘丛:  丌丅且丗七丘丅丛丑.丐专与世丐丌丏七万());
        if(丌丅且丗七丘丅丛丑.丟丐一丑丑业且且丕() != false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tutorObject, 丏业丟一东丂东丘丛:  true);
        丌丅且丗七丘丅丛丑.丗与上丝东三丙东下();
    }
    private void 丂丅专丅丒三七丂业(int 专世专丟丝丌与丘上)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rewardNotif, 丏业丟一东丂东丘丛:  丌丅且丗七丘丅丛丑.丐专与世丐丌丏七万());
    }
    internal void 丞丟丅丅丑丒丗上丞(丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 与上丟丏业专业与专)
    {
        UnityEngine.GameObject val_8;
        int val_9;
        val_8 = this;
        this.丂万丝丟丏丅丒业丛 = 与上丟丏业专业与专;
        mem[1152921536629036664] = 与上丟丏业专业与专.世丛丘丙世丝丟一丂;
        mem[1152921536629036668] = 与上丟丏业专业与专.丟专丙丐专世丁与一;
        this.newExpCountLabel.丌丄丏下七丁专丂世();
        this.newExpCountLabel.且丟丘专丕丗丟专下(与丈业丛丝丒丙一丏:  this.newExpVisibleDuration);
        int[] val_1 = new int[2];
        val_9 = val_1.Length;
        if(val_9 == 0)
        {
                val_9 = val_1.Length;
        }
        
        val_1[0] = ;
        int val_2 = W9 - W10;
        val_1[0] = val_2;
        int[] val_3 = new int[2];
        val_3[0] = val_2;
        this.newExpCountLabel.且丏丂丐丏业丕七丞(丟丘下不上丁丈专一:  val_1, 专丝东丂丏三丘且不:  val_3, 丕丂丐丌丆丝且万丗:  "{0}/"("{0}/") + 丌丅且丗七丘丅丛丑.丝万丏丒丟不丏丑专(专且丅丄且丘丟丅业:  this.丂万丝丟丏丅丒业丛)(丌丅且丗七丘丅丛丑.丝万丏丒丟不丏丑专(专且丅丄且丘丟丅业:  this.丂万丝丟丏丅丒业丛)) + " [FEF147]+{1}[-]"(" [FEF147]+{1}[-]"));
        this.animator.SetTrigger(name:  this.业丂丘丑丐东丝丙丗);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rewardNotif, 丏业丟一东丂东丘丛:  丌丅且丗七丘丅丛丑.丐专与世丐丌丏七万());
        val_8 = this.tutorObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  false);
    }
    private void 上不丕丌丄世丆丘丘(int 下万丗三丛丒丆且丌, int 专且丅丄且丘丟丅业)
    {
        int val_15;
        UISprite val_16;
        UnityEngine.GameObject val_17;
        UISprite val_18;
        string val_19;
        val_15 = 专且丅丄且丘丟丅业;
        val_16 = 下万丗三丛丒丆且丌;
        int val_1 = 丌丅且丗七丘丅丛丑.丅不不丝不不丒下丂();
        val_17 = this.regularContainer;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_17, 丏业丟一东丂东丘丛:  (val_1 != val_15) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lastRankContainer, 丏业丟一东丂东丘丛:  (val_1 == val_15) ? 1 : 0);
        if(val_1 == val_15)
        {
                val_15 = 丌丅且丗七丘丅丛丑.一丅丗东三一丁丈丑(专且丅丄且丘丟丅业:  val_15);
            val_18 = this.lastRankSprite;
            val_19 = val_15;
        }
        else
        {
                val_17 = 丌丅且丗七丘丅丛丑.丒不丐丁丕丝丟与丗(专世专丟丝丌与丘上:  val_15);
            int val_6 = 丌丅且丗七丘丅丛丑.丙丆与丕万丁丘丁丒(专且丅丄且丘丟丅业:  val_15);
            if((val_6 >= 1) && (this.rankBar != 0))
        {
                int val_8 = val_16 - val_17;
            int val_9 = val_8 * 100;
            val_9 = val_9 / val_6;
            val_17 = val_9.ToString() + "%"("%");
            this.rankBar.丝一丅丆三东丂丞七(上丞丕专丈业丁世专:  (float)val_8, 七丝东丛东丝且丆不:  (float)val_6, 下三丝东东且且且丙:  val_17);
        }
        
            val_16 = this.currentRankSprite;
            丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  val_16, 万丑丞一丝丌丐丒丘:  丌丅且丗七丘丅丛丑.一丅丗东三一丁丈丑(专且丅丄且丘丟丅业:  val_15));
            val_19 = 丌丅且丗七丘丅丛丑.一丅丗东三一丁丈丑(专且丅丄且丘丟丅业:  val_15 + 1);
            val_18 = this.nextRankSprite;
        }
        
        丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  val_18, 万丑丞一丝丌丐丒丘:  val_19);
    }
    public void OnCountStarted()
    {
        this.newExpCountLabel.丄丄丛万丁丐丐与丏();
        this.countingBarFlash.enabled = true;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.soundObject, 丏业丟一东丂东丘丛:  true);
        this.丌丒丂丗丈丏丈且不 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  this.newExpVisibleDuration, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void ClanRankView::不万丒且且丟业丞丛()));
    }
    private void 不万丒且且丟业丞丛()
    {
        this.animator.SetTrigger(name:  this.丙丈丄丑丕丐丈七世);
        this.countingBarFlash.enabled = false;
        this.countingBarFlash.value = 0f;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.soundObject, 丏业丟一东丂东丘丛:  false);
    }
    private void OnDisable()
    {
        this.不万丒且且丟业丞丛();
        if(this.丌丒丂丗丈丏丈且不 != null)
        {
                CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丌丒丂丗丈丏丈且不);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tutorObject, 丏业丟一东丂东丘丛:  false);
        丌丅且丗七丘丅丛丑.丞丅丞与丞七丗丏丈(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanRankView::丂丅专丅丒三七丂业(int 专世专丟丝丌与丘上)));
        丌丅且丗七丘丅丛丑.丈不丄且丐丛与丕丆(丙业与丙丗丝不丈东:  new System.Action<上丑下丆丄下丝东世>(object:  this, method:  System.Void ClanRankView::丞丟丅丅丑丒丗上丞(丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 与上丟丏业专业与专)));
    }
    public void OnCountEnded()
    {
        this.上不丕丌丄世丆丘丘(下万丗三丛丒丆且丌:  0, 专且丅丄且丘丟丅业:  0);
    }
    public void U_OnClicked()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tutorObject, 丏业丟一东丂东丘丛:  false);
        丌丅且丗七丘丅丛丑.丏丂专丄七且不丌丛();
    }
    public ClanRankView()
    {
        this.newExpVisibleDuration = 5f;
        this.业丂丘丑丐东丝丙丗 = "StartCount";
        this.丙丈丄丑丕丐丈七世 = "StopCount";
    }

}
