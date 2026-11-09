using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanStoreTabButton : PGBehaviour
    {
        // Fields
        public SelectableButton SelectableButton;
        private UILabel _titleLabel;
        private UITexture _texture;
        private UnityEngine.GameObject _notificationContainer;
        private UILabel _notificationLabel;
        private PGCompany.ClanStoreTab <丂世丟丌三三业下世>k__BackingField;
        
        // Properties
        internal PGCompany.ClanStoreTab 一丐丛丏东上专丆丐 { get; set; }
        
        // Methods
        internal PGCompany.ClanStoreTab 丁丟丛丑丑与与丝万()
        {
            return (PGCompany.ClanStoreTab)this.<丂世丟丌三三业下世>k__BackingField;
        }
        private void 丄七丞丂丏与丅且丕(PGCompany.ClanStoreTab 丙业与丙丗丝不丈东)
        {
            this.<丂世丟丌三三业下世>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private void Awake()
        {
            I2.Loc.丗丈下丕丟丟丙七丞.三世丅丁丝丟丛丄丝(丙业与丙丗丝不丈东:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.ClanStoreTabButton::专丂万东业丟东不丅()));
        }
        private void OnEnable()
        {
            this.丆且与丑不丈一专专();
            PGCompany.世东三上七丂丌下丑.丅与丝丒且丙丕业丕(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.ClanStoreTabButton::丕丌丟三丝丕一三丌(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
        }
        private void OnDisable()
        {
            PGCompany.世东三上七丂丌下丑.世丝丛丏丑下丐丝丏(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.ClanStoreTabButton::丕丌丟三丝丕一三丌(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
        }
        private void OnDestroy()
        {
            I2.Loc.丗丈下丕丟丟丙七丞.丑丘丆丘世丕丌专七(丙业与丙丗丝不丈东:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.ClanStoreTabButton::专丂万东业丟东不丅()));
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.ClanStoreTab 丐丅丒专丛丏上与业)
        {
            this.<丂世丟丌三三业下世>k__BackingField = 丐丅丒专丛丏上与业;
            this.专丂万东业丟东不丅();
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._texture, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "Clans/StoreTab/{0}", arg0:  丐丅丒专丛丏上与业)));
        }
        private void 专丂万东业丟东不丅()
        {
            UnityEngine.Object val_5;
            var val_6;
            PGCompany.ClanStoreTab val_7;
            var val_8;
            int val_9;
            val_5 = this;
            if(this == 0)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            val_7 = this.<丂世丟丌三三业下世>k__BackingField;
            if((PGCompany.上丟专丆丙世世丘丌.丆三上丙专丁下丄丅.ContainsKey(key:  val_7)) != false)
            {
                    val_8 = null;
                val_8 = null;
                val_7 = this.<丂世丟丌三三业下世>k__BackingField;
                val_9 = PGCompany.上丟专丆丙世世丘丌.丆三上丙专丁下丄丅.Item[val_7];
            }
            else
            {
                    val_9 = System.String.alignConst;
            }
            
            val_5 = this._titleLabel;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_5, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_9));
        }
        private void 丕丌丟三丝丕一三丌(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)
        {
            if((丅一丘丙上东丏丅不.一且丟丁上丑业丕且.不业丙丒丂丞下丆丙() != 10) && (丅一丘丙上东丏丅不.一且丟丁上丑业丕且.不业丙丒丂丞下丆丙() != 70))
            {
                    if(丅一丘丙上东丏丅不.一且丟丁上丑业丕且.不业丙丒丂丞下丆丙() != 1070)
            {
                    if(丅一丘丙上东丏丅不.一且丟丁上丑业丕且.不业丙丒丂丞下丆丙() != 1300)
            {
                    return;
            }
            
            }
            
            }
            
            this.丆且与丑不丈一专专();
        }
        private void 丆且与丑不丈一专专()
        {
            if(this._notificationContainer == 0)
            {
                    return;
            }
            
            PGCompany.ClanStoreTab val_6 = this.<丂世丟丌三三业下世>k__BackingField;
            val_6 = val_6 - 3;
            if(val_6 > 1)
            {
                    return;
            }
            
            if(PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世() != null)
            {
                    int val_4 = PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().丄丐下丘专三一专丈(且丂专丄丄丕丝丈一:  this.<丂世丟丌三三业下世>k__BackingField);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notificationContainer, 丏业丟一东丂东丘丛:  (val_4 > 0) ? 1 : 0);
                this = this._notificationLabel;
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this, 丕丗丘丑丛与丑业丒:  val_4);
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notificationContainer, 丏业丟一东丂东丘丛:  false);
        }
        public ClanStoreTabButton()
        {
        
        }
    
    }

}
