using UnityEngine;

namespace PGCompany
{
    internal class InventoryItemInfo : MonoBehaviour, 世丙丘下丝丗上下丏<PGCompany.丗丟丄丈东丝丕丄世>
    {
        // Fields
        protected UIBasicSprite _texture;
        protected System.Collections.Generic.List<UILabel> _nameLabels;
        protected System.Collections.Generic.List<UILabel> _descriptionLabels;
        protected UnityEngine.GameObject _countContainer;
        protected System.Collections.Generic.List<UILabel> _itemCountLabels;
        private PGCompany.丗丟丄丈东丝丕丄世 <丅丝丌丝丁丏丙东丞>k__BackingField;
        
        // Properties
        public PGCompany.丗丟丄丈东丝丕丄世 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
        public PGCompany.丗丟丄丈东丝丕丄世 get_Context()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(PGCompany.丗丟丄丈东丝丕丄世 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public virtual void Setup(PGCompany.丗丟丄丈东丝丕丄世 与且专丈不万东一万)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            goto typeof(PGCompany.InventoryItemInfo).__il2cppRuntimeField_198;
        }
        protected virtual void UpdateView()
        {
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            string val_1 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.ToString();
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) != null)
            {
                    return;
            }
        
        }
        public virtual void SetName(string 丕丗丘丑丛与丑业丒)
        {
            List.Enumerator<T> val_1 = this._nameLabels.GetEnumerator();
            label_7:
            if(((-619639224) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            if(val_2 == 0)
            {
                goto label_7;
            }
            
            val_2.text = 丕丗丘丑丛与丑业丒;
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public virtual void SetDescription(string 丕丗丘丑丛与丑业丒)
        {
            List.Enumerator<T> val_1 = this._descriptionLabels.GetEnumerator();
            label_7:
            if(((-619502648) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            if(val_2 == 0)
            {
                goto label_7;
            }
            
            val_2.text = 丕丗丘丑丛与丑业丒;
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public virtual void SetCount(string 丕丗丘丑丛与丑业丒)
        {
            List.Enumerator<T> val_1 = this._itemCountLabels.GetEnumerator();
            label_7:
            if(((-619366072) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            if(val_2 == 0)
            {
                goto label_7;
            }
            
            val_2.text = 丕丗丘丑丛与丑业丒;
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public virtual void SetTexture(UnityEngine.Texture 与万丆丛丒万丝丙丑)
        {
            if(this._texture == 0)
            {
                    return;
            }
            
            与万丆丛丒万丝丙丑 = ???;
            goto typeof(UIBasicSprite).__il2cppRuntimeField_2E8;
        }
        public InventoryItemInfo()
        {
        
        }
    
    }

}
