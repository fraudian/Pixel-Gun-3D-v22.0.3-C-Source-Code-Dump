using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPPhoenixHandler : MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform _phoenixPlacePoint;
        private UnityEngine.GameObject _hintObject;
        private UILabel _hintText;
        private UnityEngine.GameObject _helpBotInstance;
        private string 丝丁业丟丞东丅且东;
        private string 下丏东丘丞东丘丏丑;
        private int 丞丝与丆丈丝丐丟丆;
        
        // Methods
        public void Setup()
        {
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_14 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_14 == null)
            {
                    return;
            }
            
            string val_3 = val_14.丕世丝七世与三丞一();
            if(this._helpBotInstance != 0)
            {
                    if((System.String.op_Inequality(a:  this.下丏东丘丞东丘丏丑, b:  val_3)) != false)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this._helpBotInstance);
            }
            
            }
            
            if(this._helpBotInstance == 0)
            {
                    val_14 = val_14.三丈专世专不业丝丆().Load<UnityEngine.GameObject>(丒丘丏上丙丟丑丕丈:  "BPHelpBot", 丗业三丝丁三丘一丟:  false);
                if(val_14 != 0)
            {
                    val_14.SetActive(value:  false);
                int val_10 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
                this._helpBotInstance = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_14, 丈东丘丏与丌东东下:  this._phoenixPlacePoint, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
                val_14.SetActive(value:  true);
                Rilisoft.PetEngine val_12 = this._helpBotInstance.GetComponent<Rilisoft.PetEngine>();
                if(val_12 != 0)
            {
                    val_12.enabled = false;
            }
            
                val_14 = this._helpBotInstance;
                val_14.SetActive(value:  true);
                this.下丏东丘丞东丘丏丑 = val_3;
            }
            
            }
            
            this.丄不专丒丛丕东丏丞();
        }
        private void 丄不专丒丛丕东丏丞()
        {
            int val_18;
            if(this._hintObject == 0)
            {
                    return;
            }
            
            .丝且与丝丒丟万丁专 = this;
            val_18 = Rilisoft.Singleton<BattlePassController>.Instance;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_4 = val_18.丛东丛丕东丟丂丈丝();
            .丅丑丈丂三业丆三万 = val_4;
            if(val_4 == null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._hintObject, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._hintText, 丏业丟一东丂东丘丛:  true);
            PGCompany.BattlePass.BattlePassSettings val_5 = PGCompany.BattlePass.BattlePassSettings.Instance;
            System.Collections.Generic.List<TSource> val_8 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.BPPhrase>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.BPPhrase>(source:  val_5.mascotHelpPhrases, predicate:  new System.Func<PGCompany.BattlePass.BPPhrase, System.Boolean>(object:  new BPPhoenixHandler.丒丑万一丁丕东一丗(), method:  System.Boolean BPPhoenixHandler.丒丑万一丁丕东一丗::丏丕东一丄丏与丂丂(PGCompany.BattlePass.BPPhrase 七丏丄丅丌业与且丙))));
            if(val_8.Count < 1)
            {
                goto label_11;
            }
            
            val_18 = UnityEngine.Random.Range(min:  0, max:  val_8.Count);
            if(val_8.Item[val_18] != null)
            {
                goto label_14;
            }
            
            return;
            label_11:
            PGCompany.BattlePass.BattlePassSettings val_13 = PGCompany.BattlePass.BattlePassSettings.Instance;
            System.Predicate<PGCompany.BattlePass.BPPhrase> val_14 = null;
            val_18 = val_14;
            val_14 = new System.Predicate<PGCompany.BattlePass.BPPhrase>(object:  this, method:  System.Boolean PGCompany.BattlePass.BPPhoenixHandler::丟东下丏七丅七下不(PGCompany.BattlePass.BPPhrase 三丟东丕丄丄下下丑));
            if((val_13.mascotHelpPhrases.Find(match:  val_14)) == null)
            {
                    return;
            }
            
            label_14:
            this.丝丁业丟丞东丅且东 = val_15.locKey;
            string val_16 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_15.locKey);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_16)) != false)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._hintText, 丕丗丘丑丛与丑业丒:  val_16);
        }
        public void RemoveModel()
        {
            if(this._helpBotInstance == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this._helpBotInstance);
        }
        private void OnEnable()
        {
            this.东丝下且专丞且下丄(丛丅丘一丏丙且丌上:  true);
        }
        private void OnDisable()
        {
            this.东丝下且专丞且下丄(丛丅丘一丏丙且丌上:  false);
        }
        internal void 东丝下且专丞且下丄(bool 丛丅丘一丏丙且丌上)
        {
            var val_3;
            UnityEngine.GameObject val_4;
            if(丛丅丘一丏丙且丌上 == false)
            {
                goto label_1;
            }
            
            if(this._helpBotInstance == 0)
            {
                goto label_10;
            }
            
            val_3 = 1;
            val_4 = this._helpBotInstance;
            goto label_7;
            label_1:
            if(this._helpBotInstance == 0)
            {
                goto label_10;
            }
            
            val_4 = this._helpBotInstance;
            val_3 = 0;
            label_7:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  false);
            label_10:
            this.丞丝与丆丈丝丐丟丆 = 0;
        }
        public void U_HintClick()
        {
            int val_7 = this.丞丝与丆丈丝丐丟丆;
            val_7 = val_7 + 1;
            this.丞丝与丆丈丝丐丟丆 = val_7;
            if((val_7 & 1) == 0)
            {
                    this.丄不专丒丛丕东丏丞();
            }
            else
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._hintText, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._hintText, 丏业丟一东丂东丘丛:  false);
            }
            
            if(PGCompany.BattlePass.BattlePassSettings.Instance == 0)
            {
                    return;
            }
            
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
            {
                    return;
            }
            
            UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  PGCompany.BattlePass.BattlePassSettings.Instance.OpenBPRewardInfoAudioClip);
        }
        public BPPhoenixHandler()
        {
        
        }
        private bool 丟东下丏七丅七下不(PGCompany.BattlePass.BPPhrase 三丟东丕丄丄下下丑)
        {
            if(三丟东丕丄丄下下丑 != null)
            {
                    return System.String.op_Equality(a:  三丟东丕丄丄下下丑.locKey, b:  this.丝丁业丟丞东丅且东);
            }
            
            return System.String.op_Equality(a:  三丟东丕丄丄下下丑.locKey, b:  this.丝丁业丟丞东丅且东);
        }
    
    }

}
