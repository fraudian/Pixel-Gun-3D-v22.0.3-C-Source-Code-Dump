using UnityEngine;

namespace PGCompany.UpdateBanner
{
    internal sealed class UpdateBannerView : PGBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UILabel> _titleTextLabel;
        private UILabel _mainTextLabel;
        private UITextureMasked _backgroundImage;
        private WidgetLayout _widgetLayout;
        private UnityEngine.GameObject _blockCellExample;
        private UIWidget _headerCellWidget;
        private UIWidget _bottomCellWidget;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private System.Action 与且且业三丏丑专丌;
        
        // Properties
        internal int 丛丙丐丅丁丌丑丗丕 { get; }
        
        // Methods
        internal int 丑丝与丘丄下丄丕东()
        {
            int val_1 = this._widgetLayout.widgets.Count;
            val_1 = val_1 - 2;
            return (int)val_1;
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.UpdateBanner.三世丘三丈丅与七丆 丐丞丟万丐三一且丞, System.Action 丅丐业业丒丆丗万丈, System.Action<PGCompany.UpdateBanner.下丕丞丏丘业丏上丙> 丑丛东丐丗丏丛丒丝)
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._titleTextLabel, 丕丗丘丑丛与丑业丒:  丐丞丟万丐三一且丞.业丈丂丌丏一一丕上());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._mainTextLabel, 丕丗丘丑丛与丑业丒:  丐丞丟万丐三一且丞.丒一丞万丆丟丙不丌());
            this._backgroundImage.isOfferTexture = false;
            UnityEngine.Texture val_3 = 0.且丐业丒丘丈丙丟丝();
            this.与且且业三丏丑专丌 = 丅丐业业丒丆丗万丈;
            this.丁丟与丗业丗业丐丂(丐丞丟万丐三一且丞:  丐丞丟万丐三一且丞, 丑丛东丐丗丏丛丒丝:  丑丛东丐丗丏丛丒丝);
        }
        private void 丁丟与丗业丗业丐丂(PGCompany.UpdateBanner.三世丘三丈丅与七丆 丐丞丟万丐三一且丞, System.Action<PGCompany.UpdateBanner.下丕丞丏丘业丏上丙> 丑丛东丐丗丏丛丒丝)
        {
            var val_9;
            var val_25;
            WidgetLayout val_26;
            WidgetLayout val_27;
            var val_28;
            var val_29;
            System.Func<PGCompany.UpdateBanner.UpdateBannerBlockView, System.Int32> val_31;
            val_25 = 1152921526159197008;
            if(this._widgetLayout.widgets.Count >= 2)
            {
                    UIWidget val_2 = this._widgetLayout.widgets.Item[0];
                this._widgetLayout.RemoveElement(世丌丌丙丞丟下东丞:  val_2, 丏丞丙丌丆丙万丂丛:  false);
                val_26 = this._widgetLayout;
                val_27 = val_26;
                if(val_26 == null)
            {
                    val_27 = this._widgetLayout;
                if(val_27 == null)
            {
                goto label_42;
            }
            
            }
            
                val_26.RemoveElement(世丌丌丙丞丟下东丞:  this._widgetLayout.widgets.Item[this._widgetLayout.widgets.Count - 1], 丏丞丙丌丆丙万丂丛:  false);
            }
            
            this._widgetLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  true);
            this._widgetLayout.AddElement(世丌丌丙丞丟下东丞:  this._headerCellWidget);
            System.Collections.Generic.List<PGCompany.UpdateBanner.UpdateBannerBlockView> val_6 = null;
            val_26 = val_6;
            val_6 = new System.Collections.Generic.List<PGCompany.UpdateBanner.UpdateBannerBlockView>();
            List.Enumerator<T> val_7 = 丐丞丟万丐三一且丞.<万世丟且丏一丛一东>k__BackingField.GetEnumerator();
            val_25 = 1152921505132351488;
            label_31:
            if(((-914496464) & 1) == 0)
            {
                goto label_14;
            }
            
            string val_10 = val_9.丐丏七丌丕丗业且上();
            if(this._headerCellWidget > ExperienceController.丞丞丘业东丙丏七丌())
            {
                    var val_15 = (丅丛丟上丁丆上丛专.不七不丙丏上与三一().世专七与丈不丛丙丏().Count == 1) ? 1 : 0;
            }
            else
            {
                    val_28 = 0;
            }
            
            bool val_17 = val_10.丐丄东丛东丛丕丘且();
            val_17 = val_28 | val_17;
            if(val_17 == true)
            {
                goto label_31;
            }
            
            UnityEngine.GameObject val_19 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._blockCellExample, 丈东丘丏与丌东东下:  this._widgetLayout.transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_19, 丏业丟一东丂东丘丛:  true);
            PGCompany.UpdateBanner.UpdateBannerBlockView val_20 = val_19.GetComponent<PGCompany.UpdateBanner.UpdateBannerBlockView>();
            val_20.丈且东丑丂且万丒丅(丐丞丟万丐三一且丞:  val_10, 丑丛东丐丗丏丛丒丝:  丑丛东丐丗丏丛丒丝);
            val_6.Add(item:  val_20);
            goto label_31;
            label_14:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_44;
            label_42:
            if(val_2 != 1)
            {
                goto label_43;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_44:
            val_29 = null;
            val_29 = null;
            val_31 = UpdateBannerView.<>c.<>9__12_0;
            if(val_31 == null)
            {
                    System.Func<PGCompany.UpdateBanner.UpdateBannerBlockView, System.Int32> val_21 = null;
                val_31 = val_21;
                val_21 = new System.Func<PGCompany.UpdateBanner.UpdateBannerBlockView, System.Int32>(object:  UpdateBannerView.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 UpdateBannerView.<>c::丙丒丏丐丂丅丘与丙(PGCompany.UpdateBanner.UpdateBannerBlockView 三丟东丕丄丄下下丑));
                UpdateBannerView.<>c.<>9__12_0 = val_31;
            }
            
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<PGCompany.UpdateBanner.UpdateBannerBlockView>(丌丛丏业世丄丞三丌:  System.Linq.Enumerable.OrderBy<PGCompany.UpdateBanner.UpdateBannerBlockView, System.Int32>(source:  val_26, keySelector:  val_21), 七丐丅专且专七三丆:  new System.Action<PGCompany.UpdateBanner.UpdateBannerBlockView>(object:  this._widgetLayout, method:  public System.Void WidgetLayout::AddElement(UnityEngine.MonoBehaviour 丅丆东丏丙丝丅丆丟)));
            this._widgetLayout.AddElement(世丌丌丙丞丟下东丞:  this._bottomCellWidget);
            this._widgetLayout.Reposition();
            return;
            label_43:
        }
        public void U_OkClicked()
        {
            if(this.与且且业三丏丑专丌 == null)
            {
                    return;
            }
            
            this.与且且业三丏丑专丌.Invoke();
        }
        private void OnEnable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  0);
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
        public UpdateBannerView()
        {
        
        }
    
    }

}
