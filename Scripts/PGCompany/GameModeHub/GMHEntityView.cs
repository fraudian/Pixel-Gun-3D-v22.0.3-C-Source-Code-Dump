using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal class GMHEntityView : PGBehaviour, IDisposable
    {
        // Fields
        protected UIBasicSprite texture;
        protected UIBasicSprite icon;
        protected UILabel nameLabel;
        protected UILabel descriptionLabel;
        protected GuiApplyersGroup applyersGroup;
        protected TagSpecificObject tagSpecificObject;
        protected lockedOnProgressUI lockedOnProgressUI;
        protected System.Collections.Generic.List<PGCompany.UI.七与世丅丟丈下下不<PGCompany.GameModeHub.三丙专上下万七丛东>> 丞丒丄一丞七丒且丛;
        protected PGCompany.GameModeHub.三丙专上下万七丛东 丅丒不七丒丘与丟丅;
        
        // Properties
        internal PGCompany.GameModeHub.三丙专上下万七丛东 丙不一丒下三一七丙 { get; }
        
        // Methods
        internal PGCompany.GameModeHub.三丙专上下万七丛东 丆不且一丞不东丐下()
        {
            return (PGCompany.GameModeHub.三丙专上下万七丛东)this.丅丒不七丒丘与丟丅;
        }
        internal virtual void 丈且东丑丂且万丒丅(PGCompany.GameModeHub.三丙专上下万七丛东 不丕三丌万丈丟丆世)
        {
            this.丅丒不七丒丘与丟丅 = 不丕三丌万丈丟丆世;
            if(this.丅丒不七丒丘与丟丅 == null)
            {
                    return;
            }
            
            this.丅丒不七丒丘与丟丅.与且东与丏下三业丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHEntityView::丈丑业丈三世与丌丁()));
            this.丅丒不七丒丘与丟丅.七上丑丝七丒业丈业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHEntityView::丈丑业丈三世与丌丁()));
        }
        protected virtual void OnDestroy()
        {
            this.Dispose();
        }
        private void 丈丑业丈三世与丌丁()
        {
            goto typeof(PGCompany.GameModeHub.GMHEntityView).__il2cppRuntimeField_198;
        }
        internal virtual void 丝一丅丆三东丂丞七()
        {
            UIBasicSprite val_7;
            var val_8;
            PGCompany.GameModeHub.三丙专上下万七丛东 val_9;
            if(this.丅丒不七丒丘与丟丅 == null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.texture, 与万丆丛丒万丝丙丑:  this.丅丒不七丒丘与丟丅.丑东丐下专丞丕丘世());
            UnityEngine.Texture2D val_2 = this.丅丒不七丒丘与丟丅.三丗一丄不丆不丏三();
            if(val_2 != 0)
            {
                    丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.icon, 与万丆丛丒万丝丙丑:  val_2);
                val_7 = this.icon;
                val_8 = 1;
            }
            else
            {
                    val_7 = this.icon;
                val_8 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_7, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.nameLabel, 丕丗丘丑丛与丑业丒:  this.丅丒不七丒丘与丟丅);
            val_9 = this.丅丒不七丒丘与丟丅;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.descriptionLabel, 丕丗丘丑丛与丑业丒:  val_9.东且丏丆万与东丙万());
            if(this.applyersGroup != 0)
            {
                    if((this.丅丒不七丒丘与丟丅.<丙丝万丈丟丕丛丑丗>k__BackingField.丂丆世世丕丅丕丅上(丆万一不丌且东丐丐:  "locked", 丟且丒专下丈七丗丕:  4)) != false)
            {
                    if(this.applyersGroup != null)
            {
                goto label_25;
            }
            
            }
            else
            {
                    val_9 = this.丅丒不七丒丘与丟丅.世丄三丌丁业世丏丞;
            }
            
            }
            
            label_25:
            if(this.tagSpecificObject == null)
            {
                    return;
            }
            
            this.tagSpecificObject.丈且东丑丂且万丒丅(丏万且丈丙丁丁且世:  this.丅丒不七丒丘与丟丅.<丙丝万丈丟丕丛丑丗>k__BackingField);
        }
        protected virtual void 业上七丟与丅专一丅()
        {
            var val_6 = this;
            if(this.丞丒丄一丞七丒且丛 == null)
            {
                    this.丞丒丄一丞七丒且丛 = System.Linq.Enumerable.ToList<PGCompany.UI.七与世丅丟丈下下不<PGCompany.GameModeHub.三丙专上下万七丛东>>(source:  this.GetComponentsInChildren<PGCompany.UI.七与世丅丟丈下下不<PGCompany.GameModeHub.三丙专上下万七丛东>>());
            }
            
            List.Enumerator<T> val_3 = 0.GetEnumerator();
            label_9:
            if((44176888 & 1) == 0)
            {
                goto label_3;
            }
            
            string val_4 = 0.丐丏七丌丕丗业且上();
            if(val_4 == null)
            {
                goto label_9;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_4.Setup(与且专丈不万东一万:  null);
            goto label_9;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public void Dispose()
        {
            if(this.丅丒不七丒丘与丟丅 == null)
            {
                    return;
            }
            
            this.丅丒不七丒丘与丟丅.与且东与丏下三业丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHEntityView::丈丑业丈三世与丌丁()));
        }
        public GMHEntityView()
        {
        
        }
    
    }

}
