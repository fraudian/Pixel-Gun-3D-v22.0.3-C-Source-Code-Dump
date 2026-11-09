using UnityEngine;

namespace Rilisoft
{
    public class PetHealingComponent : MonoBehaviour
    {
        // Fields
        private Rilisoft.丛七下丌丑不一丄业 丗下丘世三七一专丕;
        private Rilisoft.PetEngine 丅丑丐东丄丏丝丂一;
        private float 东三丟丆丌丝丟丙一;
        
        // Properties
        private float 与丏丏丅丂丛一丞丈 { get; }
        
        // Methods
        private float 丄丝丏丌丌七丑下丅()
        {
            return UnityEngine.Time.realtimeSinceStartup;
        }
        private void OnEnable()
        {
            Rilisoft.PetEngine val_1 = this.GetComponent<Rilisoft.PetEngine>();
            this.丅丑丐东丄丏丝丂一 = val_1;
            if(val_1 == 0)
            {
                    object[] val_3 = new object[1];
                val_3[0] = this.gameObject.name;
                UnityEngine.Debug.LogErrorFormat(format:  "PET: \'{0}\' Pet Engine not found", args:  val_3);
                this.enabled = false;
                return;
            }
            
            this.丅丑丐东丄丏丝丂一.remove_OnStateChanged(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>(object:  this, method:  System.Void Rilisoft.PetHealingComponent::万与万专专丛七丅丂(Rilisoft.丛七下丌丑不一丄业 上万丗丕丝丂丒下三, Rilisoft.丛七下丌丑不一丄业 专丟丈七丘丑丁世业)));
            this.丅丑丐东丄丏丝丂一.add_OnStateChanged(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>(object:  this, method:  System.Void Rilisoft.PetHealingComponent::万与万专专丛七丅丂(Rilisoft.丛七下丌丑不一丄业 上万丗丕丝丂丒下三, Rilisoft.丛七下丌丑不一丄业 专丟丈七丘丑丁世业)));
            this.东三丟丆丌丝丟丙一 = UnityEngine.Time.realtimeSinceStartup;
        }
        private void 万与万专专丛七丅丂(Rilisoft.丛七下丌丑不一丄业 上万丗丕丝丂丒下三, Rilisoft.丛七下丌丑不一丄业 专丟丈七丘丑丁世业)
        {
            this.丗下丘世三七一专丕 = 上万丗丕丝丂丒下三;
        }
        private void Update()
        {
            float val_18;
            float val_19;
            if(this.丅丑丐东丄丏丝丂一 == 0)
            {
                    return;
            }
            
            if(this.丅丑丐东丄丏丝丂一.enabled == false)
            {
                    return;
            }
            
            if(this.丅丑丐东丄丏丝丂一.丘丒丝七丁下丂与丁() == false)
            {
                    return;
            }
            
            if(this.丅丑丐东丄丏丝丂一.万东丂七东丁与业东() == 0)
            {
                    return;
            }
            
            if(this.丅丑丐东丄丏丝丂一.丙丕丞且丕不丘丙丑() == null)
            {
                    return;
            }
            
            PetInfo val_7 = this.丅丑丐东丄丏丝丂一.丙丕丞且丕不丘丙丑();
            if(val_7.HealDelaySecs < 0)
            {
                    return;
            }
            
            PetInfo val_8 = this.丅丑丐东丄丏丝丂一.丙丕丞且丕不丘丙丑();
            val_18 = val_8.HealPowerSelf;
            val_19 = val_18;
            if((丞东丑专丛丆丄丝世.丕丄丅丆丄丘业且丂(下下丏一丙不丘丌丞:  val_19)) != false)
            {
                    PetInfo val_10 = this.丅丑丐东丄丏丝丂一.丙丕丞且丕不丘丙丑();
                val_18 = val_10.HealPowerOwner;
                val_19 = val_18;
                if((丞东丑专丛丆丄丝世.丕丄丅丆丄丘业且丂(下下丏一丙不丘丌丞:  val_19)) == true)
            {
                    return;
            }
            
            }
            
            if(this.丅丑丐东丄丏丝丂一.丆丙丘业一丛专世丙() == false)
            {
                goto label_28;
            }
            
            Rilisoft.丛七下丌丑不一丄业 val_18 = this.丗下丘世三七一专丕;
            val_18 = val_18 - 5;
            if(val_18 > 1)
            {
                goto label_29;
            }
            
            label_28:
            this.东三丟丆丌丝丟丙一 = UnityEngine.Time.realtimeSinceStartup;
            return;
            label_29:
            PetInfo val_15 = this.丅丑丐东丄丏丝丂一.丙丕丞且丕不丘丙丑();
            if((UnityEngine.Time.realtimeSinceStartup - this.东三丟丆丌丝丟丙一) < val_15.HealDelaySecs)
            {
                    return;
            }
            
            this.东三丟丆丌丝丟丙一 = UnityEngine.Time.realtimeSinceStartup;
            this.不丕万丟丘专丟丄上();
        }
        internal void 不丕万丟丘专丟丄上()
        {
            if(this.丅丑丐东丄丏丝丂一 == 0)
            {
                    return;
            }
            
            if(this.丅丑丐东丄丏丝丂一.enabled == false)
            {
                    return;
            }
            
            if(this.丅丑丐东丄丏丝丂一.万东丂七东丁与业东() == 0)
            {
                    return;
            }
            
            if(this.丅丑丐东丄丏丝丂一.丘丒丝七丁下丂与丁() == false)
            {
                    return;
            }
            
            if(this.丅丑丐东丄丏丝丂一.丙丕丞且丕不丘丙丑() == null)
            {
                    return;
            }
            
            if(this.丅丑丐东丄丏丝丂一.丆丙丘业一丛专世丙() == false)
            {
                    return;
            }
            
            PetInfo val_8 = this.丅丑丐东丄丏丝丂一.丙丕丞且丕不丘丙丑();
            if(val_8.HealPowerSelf > 0f)
            {
                    PetInfo val_9 = this.丅丑丐东丄丏丝丂一.丙丕丞且丕不丘丙丑();
                float val_10 = this.丅丑丐东丄丏丝丂一.丅丝丐丗专丗丝不丈(丞丅丑世丑丅丘万三:  val_9.HealPowerSelf);
            }
            
            if(this.丅丑丐东丄丏丝丂一.万东丂七东丁与业东() == 0)
            {
                    return;
            }
            
            PetInfo val_13 = this.丅丑丐东丄丏丝丂一.丙丕丞且丕不丘丙丑();
            if(val_13.HealPowerOwner <= 0f)
            {
                    return;
            }
            
            PetInfo val_17 = this.丅丑丐东丄丏丝丂一.丙丕丞且丕不丘丙丑();
            float val_20 = 100f;
            val_20 = (this.丅丑丐东丄丏丝丂一.万东丂七东丁与业东().专一丟丏且丆丕丝七() * val_17.HealPowerOwner) / val_20;
            bool val_19 = this.丅丑丐东丄丏丝丂一.万东丂七东丁与业东().丂丟丙丂丕专丂七下(上上丗丁丏丙丄丏七:  val_20, 丑东与丅丐丅丂丞业:  2);
        }
        public PetHealingComponent()
        {
        
        }
    
    }

}
