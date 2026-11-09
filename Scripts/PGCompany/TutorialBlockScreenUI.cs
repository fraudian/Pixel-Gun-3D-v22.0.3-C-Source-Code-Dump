using UnityEngine;

namespace PGCompany
{
    internal sealed class TutorialBlockScreenUI : PGBehaviour
    {
        // Fields
        private bool _keepScale;
        private UIWidget _container;
        private UIPanel _parentPanel;
        private System.Collections.Generic.List<UnityEngine.GameObject> _objectsToDisableOnLoading;
        private bool hideContentOnLoading;
        private UIWidget 丛丌丕丐世丑丂七丂;
        
        // Properties
        public UIWidget 丆丌七丁三丕丌丑丌 { get; }
        public UIPanel 丝丘丝丛丏丐世且丏 { get; }
        
        // Methods
        public UIWidget get_Container()
        {
            return (UIWidget)this._container;
        }
        public UIPanel get_ParentPanel()
        {
            return (UIPanel)this._parentPanel;
        }
        private void Update()
        {
            UnityEngine.Object val_26;
            var val_27;
            var val_28;
            MainMenuController val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            UnityEngine.Object val_36;
            var val_37;
            val_26 = this;
            val_27 = 1152921504848912384;
            if(this == 0)
            {
                    return;
            }
            
            if((this.name.Contains(value:  "Clear")) == true)
            {
                    return;
            }
            
            val_28 = null;
            val_28 = null;
            val_29 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_29 != null)
            {
                    if(null != 0)
            {
                    bool val_5 = activeInHierarchy;
                val_29 = 0;
            }
            else
            {
                    val_29 = 0;
            }
            
            }
            
            if(((-54785828) & 1) != 0)
            {
                    val_30 = val_29.GetValueOrDefault();
            }
            else
            {
                    val_30 = 0;
            }
            
            val_31 = null;
            val_31 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 == null)
            {
                goto label_17;
            }
            
            ConnectPanel val_8 = MainMenuController.丄丞丁丈与业上丞丟.丆丂三一丌一丏丁丞();
            if(val_8 == null)
            {
                goto label_17;
            }
            
            UnityEngine.GameObject val_9 = val_8.gameObject;
            if(val_9 == null)
            {
                goto label_17;
            }
            
            bool val_11 = val_9.activeInHierarchy;
            val_32 = 0;
            val_30 = (MainMenuController.丄丞丁丈与业上丞丟 == 0) ? 0 : (val_30);
            goto label_18;
            label_17:
            val_32 = 0;
            label_18:
            if(((-54785828) & 1) != 0)
            {
                    val_33 = val_32.GetValueOrDefault();
            }
            else
            {
                    val_33 = 0;
            }
            
            val_33 = val_30 | val_33;
            bool val_13 = (val_33 == 0) ? 1 : 0;
            System.Collections.IEnumerator val_15 = this.transform.GetEnumerator();
            label_43:
            var val_26 = 0;
            val_26 = val_26 + 1;
            if(val_15.MoveNext() == false)
            {
                goto label_27;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_36 = val_15.Current;
            if(val_36 != null)
            {
                    val_36 = 0;
            }
            
            if((val_36 == 0) || ((System.String.op_Inequality(a:  val_36.name, b:  "Container")) == false))
            {
                goto label_43;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  val_36, 丏业丟一东丂东丘丛:  val_13);
            goto label_43;
            label_27:
            val_27 = 0;
            val_37 = 0;
            if(val_15 != null)
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                val_15.Dispose();
            }
            
            if(this.hideContentOnLoading == false)
            {
                    return;
            }
            
            val_26 = this._objectsToDisableOnLoading;
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_26, 丏业丟一东丂东丘丛:  val_13);
        }
        internal void 三业丒丑丂三丕上丛(UIWidget 丞下万上三丘上与专)
        {
            this.丛丌丕丐世丑丂七丂 = 丞下万上三丘上与专;
            this._container.width = 丞下万上三丘上与专.width;
            this._container.height = this.丛丌丕丐世丑丂七丂.height;
            UnityEngine.Vector3 val_4 = this.丛丌丕丐世丑丂七丂.worldCenter;
            this._container.cachedTransform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            if(this._keepScale != false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_7 = 不丌丂丁丄一与丆丙.与下丆丒下丝世丝丂(东丒不丘东丐丂丅业:  丞下万上三丘上与专.transform);
            this._container.transform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        public void U_Hide()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  false);
        }
        public TutorialBlockScreenUI()
        {
        
        }
    
    }

}
