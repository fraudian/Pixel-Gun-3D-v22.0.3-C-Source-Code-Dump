using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal sealed class GMHModeSelector : SelectableButtonController
    {
        // Fields
        private MiniPoolMonoBehaviour tabsPool;
        private ScrollViewHelper scrollHelper;
        private System.Collections.Generic.List<UIRect> rectsToUpdate;
        private System.Collections.Generic.List<PGCompany.GameModeHub.GMHModeTab> 业丄丌万与丗丙上丏;
        internal System.Action<PGCompany.GameModeHub.三丙专上下万七丛东> 丅下且专丅世丒下七;
        private PGCompany.GameModeHub.丟与丗不不上丆丞三 专丄丌且一丕万与丛;
        
        // Properties
        internal PGCompany.GameModeHub.丗丙丈下上丞不丅丑 丌丌万丗丅丘且丟专 { get; }
        
        // Methods
        internal PGCompany.GameModeHub.丗丙丈下上丞不丅丑 下万丑七三丑上且东()
        {
            if(static_value_082C9000 == 0)
            {
                    return 0;
            }
            
            if(this == null)
            {
                    return 0.丘丛丆丕且丂业世丌();
            }
            
            var val_2 = (null == null) ? (this) : 0;
            return 0.丘丛丆丕且丂业世丌();
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.GameModeHub.丟与丗不不上丆丞三 七丆丒与丗丌丄且丂, PGCompany.GameModeHub.丗丙丈下上丞不丅丑 世丞不丐世丁七丒丌)
        {
            PGCompany.GameModeHub.丟与丗不不上丆丞三 val_9;
            System.Collections.Generic.List<PGCompany.GameModeHub.GMHModeTab> val_10;
            var val_11;
            System.Collections.Generic.IEnumerable<TSource> val_12;
            System.Func<TSource, System.Boolean> val_13;
            GMHModeSelector.业东下丕世丗丏万丏 val_1 = new GMHModeSelector.业东下丕世丗丏万丏();
            if(val_1 != null)
            {
                    val_9 = val_1;
                .七丆丒与丗丌丄且丂 = 七丆丒与丗丌丄且丂;
                mem[1152921560504482112] = 世丞不丐世丁七丒丌;
                mem[1152921560504441976] = 0;
            }
            else
            {
                    mem[16] = 世丞不丐世丁七丒丌;
                val_9 = 24;
                mem[24] = 七丆丒与丗丌丄且丂;
                mem[1152921560504441976] = 0;
            }
            
            this.专丄丌且一丕万与丛 = val_9;
            this.下不丅丕东丏丝丝丆();
            val_10 = this.业丄丌万与丗丙上丏;
            if((this.业丄丌万与丗丙上丏.Exists(match:  new System.Predicate<PGCompany.GameModeHub.GMHModeTab>(object:  val_1, method:  System.Boolean GMHModeSelector.业东下丕世丗丏万丏::丆一且世上丗上一丗(PGCompany.GameModeHub.GMHModeTab 三丟东丕丄丄下下丑)))) == false)
            {
                goto label_4;
            }
            
            val_11 = 1152921560504398448;
            val_12 = val_10;
            val_13 = new System.Func<PGCompany.GameModeHub.GMHModeTab, System.Boolean>(object:  val_1, method:  System.Boolean GMHModeSelector.业东下丕世丗丏万丏::一丄业丐丄丒下丏丞(PGCompany.GameModeHub.GMHModeTab 三丟东丕丄丄下下丑));
            goto label_5;
            label_4:
            if((val_10.Exists(match:  new System.Predicate<PGCompany.GameModeHub.GMHModeTab>(object:  val_1, method:  System.Boolean GMHModeSelector.业东下丕世丗丏万丏::丙丛上丏上丘丟丛丘(PGCompany.GameModeHub.GMHModeTab 三丟东丕丄丄下下丑)))) == false)
            {
                goto label_7;
            }
            
            System.Func<PGCompany.GameModeHub.GMHModeTab, System.Boolean> val_7 = null;
            val_10 = val_7;
            val_7 = new System.Func<PGCompany.GameModeHub.GMHModeTab, System.Boolean>(object:  val_1, method:  System.Boolean GMHModeSelector.业东下丕世丗丏万丏::丑丁上世不丁且三丂(PGCompany.GameModeHub.GMHModeTab 三丟东丕丄丄下下丑));
            val_11 = 1152921560504398448;
            val_12 = this.业丄丌万与丗丙上丏;
            val_13 = val_10;
            label_5:
            System.Linq.Enumerable.First<PGCompany.GameModeHub.GMHModeTab>(source:  val_12, predicate:  val_7).Select(丛丁三七丅且丝丏丙:  true);
            return;
            label_7:
            this.下丁万万丅丆东不不();
        }
        private void 下不丅丕东丏丝丝丆()
        {
            var val_3;
            this.世业丒万丘丆专丘丐();
            List.Enumerator<T> val_1 = this.专丄丌且一丕万与丛.下且丅丁丅丐丏世丅.GetEnumerator();
            label_13:
            if((63196752 & 1) == 0)
            {
                goto label_3;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<PGCompany.GameModeHub.万业世丙丗丌与不丆>(丈丆丕与丒丌丘丕且:  0)) == true)
            {
                goto label_13;
            }
            
            PGCompany.GameModeHub.GMHModeTab val_6 = this.tabsPool.Get<PGCompany.GameModeHub.GMHModeTab>();
            this.业丄丌万与丗丙上丏.Add(item:  val_6);
            this.AddNewButton(丟丂丄丕下业丗丛丂:  val_6);
            val_6.transform.SetAsLastSibling();
            val_6.Reset();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_6, 丏业丟一东丂东丘丛:  true);
            goto label_13;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_3 == 0)
            {
                    return;
            }
            
            val_3.丁下丏丙一丗下丈七();
        }
        private void 世业丒万丘丆专丘丐()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.tabsPool.example, 丏业丟一东丂东丘丛:  false);
            if(this.scrollHelper != null)
            {
                    this.scrollHelper.ScrollToStart(丌与丟丁万丝丞丄丏:  false);
            }
            
            if(this.rectsToUpdate != null)
            {
                    专且丝丄丙丗丈不丞.丞丝一三丟东丛东且(丐丗一业丒丐七丗且:  this.rectsToUpdate);
            }
            
            List.Enumerator<T> val_1 = this.业丄丌万与丗丙上丏.GetEnumerator();
            label_11:
            if((63375352 & 1) == 0)
            {
                goto label_9;
            }
            
            this.tabsPool.Return(万且万且丑丗且丌丆:  0.丐丏七丌丕丗业且上());
            goto label_11;
            label_9:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem[1152921560504809336] = 0;
            this.业丄丌万与丗丙上丏.Clear();
            this.业丄丌万与丗丙上丏.Clear();
            this.ClearLayout();
        }
        public GMHModeSelector()
        {
            this.业丄丌万与丗丙上丏 = new System.Collections.Generic.List<PGCompany.GameModeHub.GMHModeTab>();
        }
    
    }

}
