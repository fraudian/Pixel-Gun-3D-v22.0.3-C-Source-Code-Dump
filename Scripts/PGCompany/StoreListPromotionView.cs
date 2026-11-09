using UnityEngine;

namespace PGCompany
{
    internal class StoreListPromotionView : PGBehaviour
    {
        // Fields
        private UIScrollView _scrollView;
        private WidgetLayout _widgetLayout;
        private ScrollViewHelper _scrollViewHelper;
        private System.Collections.Generic.List<PGCompany.StorePromotionView> 专三丄丞丈丛丌七东;
        private System.Collections.Generic.Dictionary<string, PGCompany.StorePromotionPoolUI> 东丒丆丙丂丞业丈丟;
        private System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> 三丒丕丙丅一与丙下;
        private PGCompany.StorePromotionInfoUIAbstract 丌丅丝七丂七七丛东;
        private System.Collections.Generic.List<UIRect> rectsToUpdate;
        
        // Methods
        internal void 下与丞三丅丛丄七丕(System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> 七丄丆丘丒与丐丘丅)
        {
            this.gameObject.SetActive(value:  true);
            this.丈且东丑丂且万丒丅(七丄丆丘丒与丐丘丅:  七丄丆丘丒与丐丘丅);
        }
        internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> 七丄丆丘丒与丐丘丅)
        {
            if(七丄丆丘丒与丐丘丅 == null)
            {
                goto label_2;
            }
            
            System.Collections.Generic.List<TSource> val_1 = System.Linq.Enumerable.ToList<PGCompany.东丑丆丗丏丐丟下丄>(source:  七丄丆丘丒与丐丘丅);
            if(val_1 == null)
            {
                goto label_2;
            }
            
            label_5:
            this.三丒丕丙丅一与丙下 = val_1;
            this.丝一丅丆三东丂丞七();
            return;
            label_2:
            System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> val_2 = new System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄>();
            if(this != null)
            {
                goto label_5;
            }
            
            goto label_5;
        }
        internal void 丝一丅丆三东丂丞七()
        {
            var val_3;
            this.Reset();
            List.Enumerator<T> val_1 = this.三丒丕丙丅一与丙下.GetEnumerator();
            label_19:
            if(((-161837120) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if(val_4.丕世一与业丅万专丑() == false)
            {
                goto label_19;
            }
            
            PGCompany.StorePromotionPoolUI val_7 = this.丟业丏东丈丂三丛丘(丟丈一下东业一丝丆:  val_4.丄下丕丗一丙丑丝一());
            if(val_7 == 0)
            {
                goto label_19;
            }
            
            System.Action<UnityEngine.MonoBehaviour> val_9 = new System.Action<UnityEngine.MonoBehaviour>(object:  this, method:  System.Void PGCompany.StoreListPromotionView::东东丏且丞丁丅专七(UnityEngine.MonoBehaviour 丗且一且丙专丒丕丞));
            PGCompany.StorePromotionView val_10 = val_7.Get<PGCompany.StorePromotionView>(丏东下下一丗专下丏:  null);
            if(val_10 == 0)
            {
                goto label_19;
            }
            
            System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Object> val_12 = new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Object>(object:  this, method:  System.Void PGCompany.StoreListPromotionView::下不东丆上丆与下丌(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, object 一丐丗丁丞丆丅丟丄));
            val_10.业丝丝专丂三世丅不(丙业与丙丗丝不丈东:  null);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_10, 丏业丟一东丂东丘丛:  true);
            this.专三丄丞丈丛丌七东.Add(item:  val_10);
            this._widgetLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_10);
            goto label_19;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal void 三且东丐丕专下万东(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)
        {
            var val_4;
            System.Collections.Generic.List<PGCompany.StorePromotionView> val_11;
            StoreListPromotionView.下丌丛三下专丘丐丕 val_1 = new StoreListPromotionView.下丌丛三下专丘丐丕();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .且丂丘丁丏丑上丗丄 = 0;
            val_11 = this.专三丄丞丈丛丌七东;
            List.Enumerator<T> val_2 = val_11.GetEnumerator();
            goto label_7;
            label_9:
            val_11 = val_4.丐丏七丌丕丗业且上();
            if((val_11.与丞丆丑东东丟丆丌().Equals(丘丛丏丘丝七世七丅:  丐丆丝业丙丈下世丁)) != false)
            {
                    .且丂丘丁丏丑上丗丄 = val_11;
            }
            
            label_7:
            if(((-161650336) & 1) != 0)
            {
                goto label_9;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((StoreListPromotionView.下丌丛三下专丘丐丕)[1152921555984852384].且丂丘丁丏丑上丗丄 == 0)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_10 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  val_1, method:  System.Void StoreListPromotionView.下丌丛三下专丘丐丕::专丞丈丅丆丝不七丝()), 业丗七丕万万不丈丗:  1);
        }
        internal PGCompany.StorePromotionInfoUIAbstract 丛下丈丙万丈万丅且(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, object 一丐丗丁丞丆丅丟丄)
        {
            object val_10;
            var val_11;
            val_10 = this;
            if((System.String.op_Equality(a:  丐丆丝业丙丈下世丁.丐万丐丌丌丆丒丐丝(), b:  "disable")) != false)
            {
                    UnityEngine.Debug.LogError(message:  "info window for promotion disabled, look at \'InfoPrefabName\'");
                val_11 = 0;
                return (PGCompany.StorePromotionInfoUIAbstract)val_11;
            }
            
            PGCompany.StorePromotionPoolUI val_5 = this.东东丅丛丁三丒三丌(丟丈一下东业一丝丆:  丐丆丝业丙丈下世丁.丐万丐丌丌丆丒丐丝(), 丈东丘丏与丌东东下:  this.transform);
            val_11 = 0;
            if(val_5 == 0)
            {
                    return (PGCompany.StorePromotionInfoUIAbstract)val_11;
            }
            
            val_10 = val_5.Get<PGCompany.StorePromotionInfoUIAbstract>(丏东下下一丗专下丏:  new System.Action<UnityEngine.MonoBehaviour>(object:  this, method:  System.Void PGCompany.StoreListPromotionView::世下丕丄丄丛丙丅丌(UnityEngine.MonoBehaviour 丗且一且丙专丒丕丞)));
            val_11 = 0;
            if(val_10 == 0)
            {
                    return (PGCompany.StorePromotionInfoUIAbstract)val_11;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_10, 丏业丟一东丂东丘丛:  true);
            val_11 = val_10;
            return (PGCompany.StorePromotionInfoUIAbstract)val_11;
        }
        private void 下不东丆上丆与下丌(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, object 一丐丗丁丞丆丅丟丄)
        {
            this.丌丅丝七丂七七丛东 = this.丛下丈丙万丈万丅且(丐丆丝业丙丈下世丁:  丐丆丝业丙丈下世丁, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        private void 丁不丈业丂丈与丝丆(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三, object 一丐丗丁丞丆丅丟丄)
        {
            UnityEngine.Object val_10;
            if((System.String.IsNullOrEmpty(value:  丐丆丝业丙丈下世丁.七丕丙丕丗三丏丙专())) == true)
            {
                    return;
            }
            
            if(上业丟世三与七七三.Count == 0)
            {
                    return;
            }
            
            val_10 = this.丒一世上丘业丒七上(丟丈一下东业一丝丆:  丐丆丝业丙丈下世丁.七丕丙丕丗三丏丙专());
            if(val_10 == 0)
            {
                    return;
            }
            
            PGCompany.StorePromotionRewardUIAbstract val_8 = val_10.Get<PGCompany.StorePromotionRewardUIAbstract>(丏东下下一丗专下丏:  new System.Action<UnityEngine.MonoBehaviour>(object:  this, method:  System.Void PGCompany.StoreListPromotionView::丙与丂丝一上丈丅丒(UnityEngine.MonoBehaviour 丗且一且丙专丒丕丞)));
            if(val_8 == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_8, 丏业丟一东丂东丘丛:  true);
            if(val_8 == null)
            {
                
            }
        
        }
        private void 东东丏且丞丁丅专七(UnityEngine.MonoBehaviour 丗且一且丙专丒丕丞)
        {
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UIDragScrollView>(丌丛丏业世丄丞三丌:  丗且一且丙专丒丕丞.GetComponentsInChildren<UIDragScrollView>(), 七丐丅专且专七三丆:  new System.Action<UIDragScrollView>(object:  this, method:  System.Void PGCompany.StoreListPromotionView::丕一丄东丏丞丆丑世(UIDragScrollView 三丟东丕丄丄下下丑)));
        }
        private void 世下丕丄丄丛丙丅丌(UnityEngine.MonoBehaviour 丗且一且丙专丒丕丞)
        {
            UnityEngine.MonoBehaviour val_5 = 丗且一且丙专丒丕丞;
            if(val_5 != null)
            {
                    val_5 = 0;
            }
            
            if(val_5 == 0)
            {
                    return;
            }
            
            val_5.东丑业丒且业丌丝丙(丙业与丙丗丝不丈东:  new System.Action<PGCompany.StorePromotionInfoUIAbstract>(object:  this, method:  System.Void PGCompany.StoreListPromotionView::东三丘与丟丛丄丙丟(PGCompany.StorePromotionInfoUIAbstract 世不上丐上丛与丘丝)));
        }
        private void 丙与丂丝一上丈丅丒(UnityEngine.MonoBehaviour 丗且一且丙专丒丕丞)
        {
            UnityEngine.MonoBehaviour val_5 = 丗且一且丙专丒丕丞;
            if(val_5 != null)
            {
                    val_5 = 0;
            }
            
            if(val_5 == 0)
            {
                    return;
            }
            
            val_5.东丑业丒且业丌丝丙(丙业与丙丗丝不丈东:  new System.Action<PGCompany.StorePromotionRewardUIAbstract>(object:  this, method:  System.Void PGCompany.StoreListPromotionView::丐丆一丆丒丑不丈丏(PGCompany.StorePromotionRewardUIAbstract 业丝世丄丄丑丏与七)));
        }
        private void 一丟丆丂丁三丝七丑(PGCompany.StorePromotionView 一丞丞丆丏丄一下与)
        {
            this.丟业丏东丈丂三丛丘(丟丈一下东业一丝丆:  一丞丞丆丏丄一下与.与丞丆丑东东丟丆丌().丄下丕丗一丙丑丝一()).Return(万且万且丑丗且丌丆:  一丞丞丆丏丄一下与);
            一丞丞丆丏丄一下与.丗一丞丌与东与三且(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Object>(object:  this, method:  System.Void PGCompany.StoreListPromotionView::下不东丆上丆与下丌(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, object 一丐丗丁丞丆丅丟丄)));
        }
        private void 东三丘与丟丛丄丙丟(PGCompany.StorePromotionInfoUIAbstract 世不上丐上丛与丘丝)
        {
            this.东东丅丛丁三丒三丌(丟丈一下东业一丝丆:  世不上丐上丛与丘丝.<丒丄丙世且丑丑丄不>k__BackingField.丐万丐丌丌丆丒丐丝(), 丈东丘丏与丌东东下:  this.transform).Return(万且万且丑丗且丌丆:  世不上丐上丛与丘丝);
        }
        private void 丐丆一丆丒丑不丈丏(PGCompany.StorePromotionRewardUIAbstract 业丝世丄丄丑丏与七)
        {
            this.东东丅丛丁三丒三丌(丟丈一下东业一丝丆:  业丝世丄丄丑丏与七.<丒丄丙世且丑丑丄不>k__BackingField.七丕丙丕丗三丏丙专(), 丈东丘丏与丌东东下:  this.transform).Return(万且万且丑丗且丌丆:  业丝世丄丄丑丏与七);
        }
        private PGCompany.StorePromotionPoolUI 丟业丏东丈丂三丛丘(string 丟丈一下东业一丝丆)
        {
            return this.东东丅丛丁三丒三丌(丟丈一下东业一丝丆:  丟丈一下东业一丝丆, 丈东丘丏与丌东东下:  this._widgetLayout.transform);
        }
        private PGCompany.StorePromotionPoolUI 丙丕丁且一一丒上下(string 丟丈一下东业一丝丆)
        {
            return this.东东丅丛丁三丒三丌(丟丈一下东业一丝丆:  丟丈一下东业一丝丆, 丈东丘丏与丌东东下:  this.transform);
        }
        private PGCompany.StorePromotionPoolUI 丒一世上丘业丒七上(string 丟丈一下东业一丝丆)
        {
            if(PGCompany.ClanStoreMainUI.丑七不且上丗丁一世() != null)
            {
                    return this.东东丅丛丁三丒三丌(丟丈一下东业一丝丆:  丟丈一下东业一丝丆, 丈东丘丏与丌东东下:  val_1.MainContainer);
            }
            
            return this.东东丅丛丁三丒三丌(丟丈一下东业一丝丆:  丟丈一下东业一丝丆, 丈东丘丏与丌东东下:  val_1.MainContainer);
        }
        private PGCompany.StorePromotionPoolUI 东东丅丛丁三丒三丌(string 丟丈一下东业一丝丆, UnityEngine.Transform 丈东丘丏与丌东东下)
        {
            UnityEngine.Transform val_5 = 丈东丘丏与丌东东下;
            if((this.东丒丆丙丂丞业丈丟.ContainsKey(key:  丟丈一下东业一丝丆)) != true)
            {
                    val_3.parent = val_5;
                val_3.example = UnityEngine.Resources.Load<UnityEngine.MonoBehaviour>(path:  丟丈一下东业一丝丆);
                val_5 = this.东丒丆丙丂丞业丈丟;
                val_5.set_Item(key:  丟丈一下东业一丝丆, value:  this.gameObject.AddComponent<PGCompany.StorePromotionPoolUI>());
            }
            
            if(this.东丒丆丙丂丞业丈丟 != null)
            {
                    return this.东丒丆丙丂丞业丈丟.Item[丟丈一下东业一丝丆];
            }
            
            return this.东丒丆丙丂丞业丈丟.Item[丟丈一下东业一丝丆];
        }
        private void OnEnable()
        {
            PGCompany.东丑丆丗丏丐丟下丄.三七一不丆丒不三丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void PGCompany.StoreListPromotionView::丁不丈业丂丈与丝丆(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三, object 一丐丗丁丞丆丅丟丄)));
            PGCompany.东丑丆丗丏丐丟下丄.丘下丟一丌上业丘万(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void PGCompany.StoreListPromotionView::丁不丈业丂丈与丝丆(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三, object 一丐丗丁丞丆丅丟丄)));
            PixelTime.丑世世上丘丑与万丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.StoreListPromotionView::丏丝不万东东一上丂()));
            PixelTime.丗丛东丏丛丏丑丂丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.StoreListPromotionView::丏丝不万东东一上丂()));
            PixelTime.业一丑上丑三丐七专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.StoreListPromotionView::丝一丅丆三东丂丞七()));
            PixelTime.业丂三上七专丌与丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.StoreListPromotionView::丝一丅丆三东丂丞七()));
        }
        private void 丏丝不万东东一上丂()
        {
            this.丝一丅丆三东丂丞七();
        }
        private void OnDisable()
        {
            PixelTime.业一丑上丑三丐七专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.StoreListPromotionView::丝一丅丆三东丂丞七()));
            PixelTime.丑世世上丘丑与万丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.StoreListPromotionView::丏丝不万东东一上丂()));
            PGCompany.东丑丆丗丏丐丟下丄.三七一不丆丒不三丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void PGCompany.StoreListPromotionView::丁不丈业丂丈与丝丆(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三, object 一丐丗丁丞丆丅丟丄)));
        }
        private void OnDestroy()
        {
            PGCompany.东丑丆丗丏丐丟下丄.三七一不丆丒不三丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void PGCompany.StoreListPromotionView::丁不丈业丂丈与丝丆(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三, object 一丐丗丁丞丆丅丟丄)));
            this.专三丄丞丈丛丌七东.ForEach(action:  new System.Action<PGCompany.StorePromotionView>(object:  this, method:  System.Void PGCompany.StoreListPromotionView::一丟丆丂丁三丝七丑(PGCompany.StorePromotionView 一丞丞丆丏丄一下与)));
        }
        private void Reset()
        {
            this.丕丑丌丛丅丐东丙丒();
            this.专三丄丞丈丛丌七东.ForEach(action:  new System.Action<PGCompany.StorePromotionView>(object:  this, method:  System.Void PGCompany.StoreListPromotionView::一丟丆丂丁三丝七丑(PGCompany.StorePromotionView 一丞丞丆丏丄一下与)));
            this.专三丄丞丈丛丌七东.Clear();
            this._widgetLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        }
        private void 丄上七丂丄丗不丝七()
        {
            List.Enumerator<T> val_1 = this.rectsToUpdate.GetEnumerator();
            label_7:
            if(((-158786888) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            if(val_2 == 0)
            {
                goto label_7;
            }
            
            val_2.ResetAndUpdateAnchors();
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 丕丑丌丛丅丐东丙丒()
        {
            this._scrollView.StopMomentumForce();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this._scrollView.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
            this._scrollView.panel.clipOffset = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            this.丄上七丂丄丗不丝七();
        }
        public StoreListPromotionView()
        {
            this.专三丄丞丈丛丌七东 = new System.Collections.Generic.List<PGCompany.StorePromotionView>();
            this.东丒丆丙丂丞业丈丟 = new System.Collections.Generic.Dictionary<System.String, PGCompany.StorePromotionPoolUI>();
            this.三丒丕丙丅一与丙下 = new System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄>();
        }
        private void 丕一丄东丏丞丆丑世(UIDragScrollView 三丟东丕丄丄下下丑)
        {
            三丟东丕丄丄下下丑.scrollView = this._scrollView;
        }
    
    }

}
