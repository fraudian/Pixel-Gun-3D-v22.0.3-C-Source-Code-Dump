using UnityEngine;

namespace PGCompany.Piggy
{
    internal sealed class PiggyOffersLobby : PGBehaviour
    {
        // Fields
        private static PGCompany.Piggy.PiggyOffersLobby 丝业丆丁业三丈丟东;
        private UnityEngine.GameObject _holder;
        private GoblinHeader _headerTime;
        private TextMeshBounds _textMeshLevel;
        private UnityEngine.Coroutine 丟丁东丘丝丙丑上万;
        
        // Properties
        internal static PGCompany.Piggy.PiggyOffersLobby 丆丕丝丒不丙且丐丗 { get; }
        internal UnityEngine.GameObject 不丏丌丈丈丗万七丏 { get; }
        
        // Methods
        internal static PGCompany.Piggy.PiggyOffersLobby 丑七不且上丗丁一世()
        {
            return (PGCompany.Piggy.PiggyOffersLobby)PGCompany.Piggy.PiggyOffersLobby.丝业丆丁业三丈丟东;
        }
        internal UnityEngine.GameObject 三下且丁专业丝丅丙()
        {
            return (UnityEngine.GameObject)this._holder;
        }
        internal UnityEngine.Vector3 丘丛丝七丐丁七一丐()
        {
            if(this._holder == 0)
            {
                    return UnityEngine.Vector3.zero;
            }
            
            UnityEngine.Transform val_2 = this._holder.transform;
            if(val_2 != null)
            {
                    return val_2.position;
            }
            
            return val_2.position;
        }
        private void Awake()
        {
            PGCompany.Piggy.PiggyOffersLobby.丝业丆丁业三丈丟东 = this;
        }
        private void OnEnable()
        {
            this.丝一丅丆三东丂丞七();
            PGCompany.Piggy.业世且丐丕专丛专丐.万丞下世东且专丂丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Piggy.PiggyOffersLobby::丝一丅丆三东丂丞七()));
            PGCompany.Piggy.业世且丐丕专丛专丐.丁万丘丑世丝世丂专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Piggy.PiggyOffersLobby::丝一丅丆三东丂丞七()));
            PGCompany.Piggy.业世且丐丕专丛专丐.丂与下三丌一丙丏一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Piggy.PiggyOffersLobby::丝一丅丆三东丂丞七()));
            PGCompany.Piggy.业世且丐丕专丛专丐.丛万丌丂下丅丛丏万(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Piggy.PiggyOffersLobby::丝一丅丆三东丂丞七()));
            PGCompany.Piggy.业世且丐丕专丛专丐.丐丏三万丐且丗专世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Piggy.PiggyOffersLobby::丝一丅丆三东丂丞七()));
            Rilisoft.LobbyCraftController.三且丟丂丄丈世万七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Piggy.PiggyOffersLobby::丝一丅丆三东丂丞七()));
        }
        private void OnDisable()
        {
            if(this.丟丁东丘丝丙丑上万 != null)
            {
                    CoroutineRunner.Instance.StopCoroutine(routine:  this.丟丁东丘丝丙丑上万);
            }
            
            PGCompany.Piggy.业世且丐丕专丛专丐.三丗丆丕丟上丈万三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Piggy.PiggyOffersLobby::丝一丅丆三东丂丞七()));
            PGCompany.Piggy.业世且丐丕专丛专丐.万丗丟丏丌丄丄一与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Piggy.PiggyOffersLobby::丝一丅丆三东丂丞七()));
            PGCompany.Piggy.业世且丐丕专丛专丐.丐不丈丟丛丌万世丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Piggy.PiggyOffersLobby::丝一丅丆三东丂丞七()));
            PGCompany.Piggy.业世且丐丕专丛专丐.丁不丈东下东丘丈且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Piggy.PiggyOffersLobby::丝一丅丆三东丂丞七()));
            PGCompany.Piggy.业世且丐丕专丛专丐.丑丂丂丄丂专丐丘与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Piggy.PiggyOffersLobby::丝一丅丆三东丂丞七()));
            Rilisoft.LobbyCraftController.丂丄专丁丗丕丌丅丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Piggy.PiggyOffersLobby::丝一丅丆三东丂丞七()));
        }
        internal void 丝一丅丆三东丂丞七()
        {
            string val_11;
            var val_12;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  false);
            if(this.丟丁东丘丝丙丑上万 != null)
            {
                    val_11 = CoroutineRunner.Instance;
                val_11.StopCoroutine(routine:  this.丟丁东丘丝丙丑上万);
            }
            
            if((PGCompany.Piggy.业世且丐丕专丛专丐.<不丁丄七丛不丆丁丕>k__BackingField.丙三丁与丕三丄丄丆()) == false)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  true);
            val_11 = 1152921504848912384;
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
            {
                    if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.万丂专世丄丆丒且下() != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._textMeshLevel, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._headerTime, 丏业丟一东丂东丘丛:  false);
                return;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._textMeshLevel, 丏业丟一东丂东丘丛:  true);
            if(this._textMeshLevel != 0)
            {
                    val_12 = 97931;
                if((PGCompany.Piggy.业世且丐丕专丛专丐.<不丁丄七丛不丆丁丕>k__BackingField) == null)
            {
                    val_12 = 0;
            }
            
                val_11 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10431"), arg0:  val_12.丈一下下丞世三丑丄());
                this._textMeshLevel.Text = val_11;
            }
            
            this.丟丁东丘丝丙丑上万 = this.StartCoroutine(routine:  this.丗丘且且万丕丛东一());
        }
        private System.Collections.IEnumerator 丗丘且且万丕丛东一()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new PiggyOffersLobby.丒万七与丂下丌不丕();
        }
        public PiggyOffersLobby()
        {
        
        }
    
    }

}
