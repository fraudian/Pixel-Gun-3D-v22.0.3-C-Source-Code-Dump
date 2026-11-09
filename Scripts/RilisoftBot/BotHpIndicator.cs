using UnityEngine;

namespace RilisoftBot
{
    public class BotHpIndicator : MonoBehaviour
    {
        // Fields
        private float _currentScale;
        private float 不丟丏与丘丗下丛丂;
        private UnityEngine.GameObject _frame;
        private UnityEngine.Transform 丐丌且丕丅不一丁丏;
        internal bool 三丕万丕丈丄丄丗万;
        private UnityEngine.Transform _healthBar;
        private RilisoftBot.BotHpIndicator.不且丅丙上丕与丂下 丞专下三丞丐世七丙;
        private IconModuleMob 上丝丄丙丐丈丞丈三;
        private float 业上丅不丘上与丅万;
        internal UnityEngine.GameObject 丏丁丒丟下世丗丑丞;
        private readonly string 不丘丒丘丘丑一东丌;
        private readonly string 东丙丏一丝丒世丄丑;
        
        // Properties
        internal bool 七不丌丒丄丗丟丑丄 { get; }
        internal UnityEngine.Transform 丞丗丈世丝与丂三专 { get; }
        
        // Methods
        internal bool 丝丕丘丅丁丕七丞丘()
        {
            if(this.不丟丏与丘丗下丛丂 > 0f)
            {
                    return true;
            }
            
            return GameConnect.东丒七专丂世丝丏丗();
        }
        internal UnityEngine.Transform 丙丄不上东丟丞七世()
        {
            UnityEngine.Transform val_3;
            if(this.丐丌且丕丅不一丁丏 == 0)
            {
                    this.丐丌且丕丅不一丁丏 = this._frame.transform;
                return val_3;
            }
            
            val_3 = this.丐丌且丕丅不一丁丏;
            return val_3;
        }
        private void Awake()
        {
            if(GameConnect.丅丟下专不丁一丈七() != true)
            {
                    if(GameConnect.七丂万专且丏丘一丙() == false)
            {
                    return;
            }
            
            }
            
            if((this.GetComponentInParent<RilisoftBot.BaseBot>()) == 0)
            {
                    return;
            }
            
            val_3.丆丆丂丑丁世上丟上 = this;
        }
        private System.Collections.IEnumerator Start()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BotHpIndicator.七丒业丅丝丒世世丑();
        }
        internal void 下与丞三丅丛丄七丕()
        {
            this._frame.SetActive(value:  true);
            this.不丟丏与丘丗下丛丂 = 2f;
            UnityEngine.Vector3 val_1 = this._healthBar.localScale;
            UnityEngine.Vector3 val_2 = this._healthBar.localScale;
            this._healthBar.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private System.Collections.IEnumerator 丙丟丄下万丙丗丑万()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BotHpIndicator.一万东丄业丝丐丐丝();
        }
        internal void 丆丐丘丂丂丑世丈丞()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.东丒世三下丝丒业丈());
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丙丟丄下万丙丗丑万());
        }
        private System.Collections.IEnumerator 东丒世三下丝丒业丈()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BotHpIndicator.上东丙丌丞丈七丝丄();
        }
        private RilisoftBot.BotHpIndicator.不且丅丙上丕与丂下 丞丆丑丞与丆七且丒(SkinName 丝丘丅与丌丗丅丈下)
        {
            BotHpIndicator.丌丐丝丐下上三丛丌 val_1 = new BotHpIndicator.丌丐丝丐下上三丛丌();
            .丝丘丅与丌丗丅丈下 = 丝丘丅与丌丗丅丈下;
            return (不且丅丙上丕与丂下)new BotHpIndicator.不且丅丙上丕与丂下(丑丆三丑丒丌丌丁丟:  new System.Func<System.Single>(object:  val_1, method:  System.Single BotHpIndicator.丌丐丝丐下上三丛丌::且世丏东丕与与丆丁()), 不丛丄丕丑专三七业:  new System.Func<System.Single>(object:  val_1, method:  System.Single BotHpIndicator.丌丐丝丐下上三丛丌::一丒丙且一丑一专丗()));
        }
        public BotHpIndicator()
        {
            this.业上丅不丘上与丅万 = 1f;
            this.不丘丒丘丘丑一东丌 = "IconModuleMob";
            this.东丙丏一丝丒世丄丑 = "IconCursedMob";
        }
    
    }

}
