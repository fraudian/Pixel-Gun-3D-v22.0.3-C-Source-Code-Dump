using UnityEngine;

namespace PGCompany.Clans
{
    public class ChooseLogoClanCreate : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject _gridItemExample;
        private UIGrid _itemsGrid;
        private readonly System.Collections.Generic.List<PGCompany.Clans.ChooseLogoItem> 丛不丞丂七丞世丁丏;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private System.Action<PGCompany.Clans.ChooseLogoItem, int> 丂丈业丌业不三丂三;
        
        // Methods
        public void AddLogoItems(System.Collections.Generic.List<UnityEngine.Texture2D> 不丏业丛丟丒丕丑丘)
        {
            不丏业丛丟丒丕丑丘.ForEach(action:  new System.Action<UnityEngine.Texture2D>(object:  this, method:  public System.Void PGCompany.Clans.ChooseLogoClanCreate::AddLogoItem(UnityEngine.Texture 丁且专丑万万丘丟七)));
        }
        public void AddLogoItem(UnityEngine.Texture 丁且专丑万万丘丟七)
        {
            UnityEngine.GameObject val_2 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this._itemsGrid.gameObject, 丑且不丕与专丄业丙:  this._gridItemExample);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  true);
            this.丛不丞丂七丞世丁丏.Add(item:  val_2.GetComponent<PGCompany.Clans.ChooseLogoItem>());
        }
        public void Clear()
        {
            var val_2 = null;
            if((ChooseLogoClanCreate.<>c.<>9__7_0) == null)
            {
                goto label_3;
            }
            
            label_9:
            this.丛不丞丂七丞世丁丏.ForEach(action:  ChooseLogoClanCreate.<>c.<>9__7_0);
            this.丛不丞丂七丞世丁丏.Clear();
            return;
            label_3:
            ChooseLogoClanCreate.<>c.<>9__7_0 = new System.Action<PGCompany.Clans.ChooseLogoItem>(object:  ChooseLogoClanCreate.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ChooseLogoClanCreate.<>c::业丟下一丛业丛三丌(PGCompany.Clans.ChooseLogoItem 三丟东丕丄丄下下丑));
            if(this.丛不丞丂七丞世丁丏 != null)
            {
                goto label_9;
            }
            
            goto label_9;
        }
        public void Open(System.Action<PGCompany.Clans.ChooseLogoItem, int> 丄丂万丄上丁丑下丝)
        {
            this.丂丈业丌业不三丂三 = 丄丂万丄上丁丑下丝;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
            if(this._itemsGrid == null)
            {
                
            }
        
        }
        public void U_ItemClick(PGCompany.Clans.ChooseLogoItem 下丅丙一丂丗丅丝七)
        {
            .下丅丙一丂丗丅丝七 = 下丅丙一丂丗丅丝七;
            if(this.丂丈业丌业不三丂三 != null)
            {
                    this.丂丈业丌业不三丂三.Invoke(arg1:  (ChooseLogoClanCreate.丌万一一业丝丁丈丝)[1152921559855772672].下丅丙一丂丗丅丝七, arg2:  this.丛不丞丂七丞世丁丏.FindIndex(match:  new System.Predicate<PGCompany.Clans.ChooseLogoItem>(object:  new ChooseLogoClanCreate.丌万一一业丝丁丈丝(), method:  System.Boolean ChooseLogoClanCreate.丌万一一业丝丁丈丝::万丁业丒丂丒三丏丐(PGCompany.Clans.ChooseLogoItem 三丟东丕丄丄下下丑))));
            }
            
            this.Close();
        }
        private void Awake()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gridItemExample, 丏业丟一东丂东丘丛:  false);
        }
        public void Close()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        public void U_Close()
        {
            this.Close();
        }
        private void OnEnable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.Clans.ChooseLogoClanCreate::Close()), 与且专丈不万东一万:  0);
        }
        private void OnDisable()
        {
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        public ChooseLogoClanCreate()
        {
            this.丛不丞丂七丞世丁丏 = new System.Collections.Generic.List<PGCompany.Clans.ChooseLogoItem>();
        }
    
    }

}
