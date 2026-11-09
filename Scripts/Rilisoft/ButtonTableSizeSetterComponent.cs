using UnityEngine;

namespace Rilisoft
{
    public class ButtonTableSizeSetterComponent : MonoBehaviour
    {
        // Fields
        private int _padding;
        private UITable _table;
        private System.Collections.Generic.List<UIWidget> _tableWidgets;
        
        // Methods
        private void Awake()
        {
            object val_7;
            下一丒下丂丙万丁丞 val_8;
            val_7 = this;
            if(this._table == 0)
            {
                    return;
            }
            
            val_8 = System.Delegate.Remove(source:  this._table.onReposition, value:  new UITable.下一丒下丂丙万丁丞(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void Rilisoft.ButtonTableSizeSetterComponent::Execute()));
            if(this._table == null)
            {
                goto label_5;
            }
            
            if(val_8 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(val_8 == null)
            {
                goto label_9;
            }
            
            label_6:
            if(null != null)
            {
                    val_8 = 0;
            }
            
            label_9:
            this._table.onReposition = val_8;
            val_7 = System.Delegate.Combine(a:  this._table.onReposition, b:  new UITable.下一丒下丂丙万丁丞(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void Rilisoft.ButtonTableSizeSetterComponent::Execute()));
            if(this._table == null)
            {
                goto label_11;
            }
            
            if(val_7 != null)
            {
                goto label_12;
            }
            
            goto label_15;
            label_11:
            if(val_7 == null)
            {
                goto label_15;
            }
            
            label_12:
            if(null != null)
            {
                    val_7 = 0;
            }
            
            label_15:
            this._table.onReposition = val_7;
        }
        private void OnDestroy()
        {
            System.Delegate val_4 = System.Delegate.Remove(source:  this._table.onReposition, value:  new UITable.下一丒下丂丙万丁丞(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void Rilisoft.ButtonTableSizeSetterComponent::Execute()));
            if(this._table == null)
            {
                goto label_2;
            }
            
            if(val_4 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_4 == null)
            {
                goto label_6;
            }
            
            label_3:
            if(null != null)
            {
                    val_4 = 0;
            }
            
            label_6:
            this._table.onReposition = val_4;
        }
        public void Execute()
        {
            var val_10;
            List.Enumerator<T> val_3 = this._tableWidgets.GetEnumerator();
            val_10 = 0;
            goto label_6;
            label_8:
            string val_4 = 0.丐丏七丌丕丗业且上();
            if(val_4 != 0)
            {
                    val_10 = val_4.width + val_10;
            }
            
            label_6:
            if((5701112 & 1) != 0)
            {
                goto label_8;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            float val_10 = (float)this._tableWidgets.Count;
            val_10 = this._table.padding * val_10;
            this.gameObject.GetComponent<UIWidget>().width = (val_10 + (this._padding << 1)) + (int)val_10;
        }
        public ButtonTableSizeSetterComponent()
        {
            this._padding = 4;
        }
    
    }

}
