using UnityEngine;

namespace PGCompany.Marathon
{
    internal sealed class MarathonRewardsContainerUI : PGBehaviour
    {
        // Fields
        private UIWidget widget;
        private WidgetLayout widgetLayout;
        private GridLayout gridLayout;
        internal PGCompany.Marathon.MarathonRewardsContainerUI.专万丛丘下丄丄丞丟 layoutType;
        private System.Collections.Generic.List<UIRect> updateAnchorsOnResize;
        internal System.Collections.Generic.List<PGCompany.Marathon.MarathonRewardUI> 丐上业世业丈世丙丏;
        public bool addAditinalSpacing;
        
        // Methods
        internal void 业丏丗丐丂业东丂丗(PGCompany.Marathon.MarathonRewardUI 丈一丄丑丕丆东下上)
        {
            this.丐上业世业丈世丙丏.Add(item:  丈一丄丑丕丆东下上);
        }
        internal void 世业丒万丘丆专丘丐()
        {
            this.丐上业世业丈世丙丏.Clear();
        }
        internal bool 丟不下下且业丛丄丏(PGCompany.Marathon.MarathonRewardUI 丈一丄丑丕丆东下上)
        {
            if(this.丐上业世业丈世丙丏 != null)
            {
                    return this.丐上业世业丈世丙丏.Contains(item:  丈一丄丑丕丆东下上);
            }
            
            return this.丐上业世业丈世丙丏.Contains(item:  丈一丄丑丕丆东下上);
        }
        internal PGCompany.Marathon.MarathonRewardUI 七丒丂丄丐丙七丂与()
        {
            return System.Linq.Enumerable.FirstOrDefault<PGCompany.Marathon.MarathonRewardUI>(source:  this.丐上业世业丈世丙丏);
        }
        internal void 丁下丏丙一丗下丈七()
        {
            var val_3;
            this.widgetLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.widgetLayout, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.gridLayout, 丏业丟一东丂东丘丛:  false);
            List.Enumerator<T> val_1 = this.丐上业世业丈世丙丏.GetEnumerator();
            label_28:
            if(((-817882768) & 1) == 0)
            {
                goto label_5;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if(this.layoutType == 0)
            {
                goto label_6;
            }
            
            if(this.layoutType != 1)
            {
                goto label_28;
            }
            
            float val_13 = (float)this.丐上业世业丈世丙丏.Count;
            val_13 = val_13 * 0.5f;
            this.gridLayout.cellsInRow = UnityEngine.Mathf.CeilToInt(f:  val_13);
            val_4.transform.SetParent(p:  this.gridLayout.transform);
            丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_4.transform);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.gridLayout, 丏业丟一东丂东丘丛:  true);
            this.gridLayout.Reposition();
            goto label_28;
            label_6:
            val_4.transform.SetParent(p:  this.widgetLayout.transform);
            丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_4.transform);
            this.widgetLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_4);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.widgetLayout, 丏业丟一东丂东丘丛:  true);
            this.widgetLayout.Reposition();
            goto label_28;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.丙丕上世丈丈七丒丙();
        }
        internal void 丙丕上世丈丈七丒丙()
        {
            UIWidget val_5;
            UIWidget val_6;
            GridLayout val_7;
            var val_8;
            if(this.layoutType == 0)
            {
                goto label_1;
            }
            
            if(this.layoutType != 1)
            {
                goto label_2;
            }
            
            val_5 = this;
            val_6 = this.widget;
            val_7 = this.gridLayout;
            UnityEngine.Vector2 val_1 = val_7.Size;
            goto label_4;
            label_1:
            this.widgetLayout.addAditinalSpacing = this.addAditinalSpacing;
            val_5 = this;
            val_6 = this.widget;
            val_7 = this.widgetLayout;
            label_4:
            val_6.width = (int)val_7.GetSize();
            goto label_8;
            label_2:
            val_5 = this.widget;
            label_8:
            mem[this.widget].ResetAndUpdateAnchors();
            List.Enumerator<T> val_3 = this.updateAnchorsOnResize.GetEnumerator();
            val_8 = 1152921524332929712;
            label_13:
            if(((-817656040) & 1) == 0)
            {
                goto label_11;
            }
            
            string val_4 = 0.丐丏七丌丕丗业且上();
            if(val_4 == null)
            {
                goto label_13;
            }
            
            val_4.ResetAndUpdateAnchors();
            goto label_13;
            label_11:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public MarathonRewardsContainerUI()
        {
            this.丐上业世业丈世丙丏 = new System.Collections.Generic.List<PGCompany.Marathon.MarathonRewardUI>();
        }
    
    }

}
