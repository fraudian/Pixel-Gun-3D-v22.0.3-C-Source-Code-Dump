using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal class TabsUI : SelectableButtonController
    {
        // Fields
        private MiniPoolMonoBehaviour tabsPool;
        private MiniPoolGroup _tabContentPool;
        private UnityEngine.Transform tabContentHolder;
        private System.Collections.Generic.List<string> 七丆东上七业一丗丕;
        private System.Collections.Generic.List<PGCompany.GameModeHub.TabView> 丕业丄丁丘丝丗丝丝;
        private PGCompany.GameModeHub.TabContentView 丞丄世业一与丕丞丆;
        
        // Methods
        public override bool SelectButton(SelectableButton 丕丐不丑三上万丝东)
        {
            var val_2;
            if((this.SelectButton(丕丐不丑三上万丝东:  丕丐不丑三上万丝东)) != false)
            {
                    if(丕丐不丑三上万丝东 != null)
            {
                    this.专专丄丕丗丄丑丈丑(丐丅丒专丛丏上与业:  丕丐不丑三上万丝东);
            }
            
                val_2 = 1;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<string> 丄下丞丝丂丈丈专万, string 丛不丄丘丕丘上丈丏)
        {
            var val_5;
            var val_7;
            val_5 = this;
            this.七丆东上七业一丗丕 = 丄下丞丝丂丈丈专万;
            this.下不丅丕东丏丝丝丆();
            if((this.下丏丘丅丛丞丄东丟(不下上丙三与业丌三:  丛不丄丘丕丘上丈丏)) != 0)
            {
                    val_7 = 1;
            }
            else
            {
                    if(this.丕业丄丁丘丝丗丝丝.Count < 1)
            {
                    return;
            }
            
                val_5 = System.Linq.Enumerable.First<PGCompany.GameModeHub.TabView>(source:  this.丕业丄丁丘丝丗丝丝);
                val_7 = 1;
            }
            
            val_5.Select(丛丁三七丅且丝丏丙:  true);
        }
        private void 下不丅丕东丏丝丝丆()
        {
            this.世业丒万丘丆专丘丐();
            List.Enumerator<T> val_1 = this.七丆东上七业一丗丕.GetEnumerator();
            label_8:
            if((66146136 & 1) == 0)
            {
                goto label_2;
            }
            
            PGCompany.GameModeHub.TabView val_3 = this.tabsPool.Get<PGCompany.GameModeHub.TabView>();
            val_3.Reset();
            this.丕业丄丁丘丝丗丝丝.Add(item:  val_3);
            this.AddNewButton(丟丂丄丕下业丗丛丂:  val_3);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_3, 丏业丟一东丂东丘丛:  true);
            val_3.丈且东丑丂且万丒丅(不下上丙三与业丌三:  0.丐丏七丌丕丗业且上());
            goto label_8;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 世业丒万丘丆专丘丐()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.tabsPool.example, 丏业丟一东丂东丘丛:  false);
            List.Enumerator<T> val_1 = this.丕业丄丁丘丝丗丝丝.GetEnumerator();
            label_7:
            if((66308344 & 1) == 0)
            {
                goto label_5;
            }
            
            this.tabsPool.Return(万且万且丑丗且丌丆:  0.丐丏七丌丕丗业且上());
            goto label_7;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.丕业丄丁丘丝丗丝丝.Clear();
            this.Clear();
        }
        private void 专专丄丕丗丄丑丈丑(PGCompany.GameModeHub.TabView 丐丅丒专丛丏上与业)
        {
            if(this.丞丄世业一与丕丞丆 != 0)
            {
                    this._tabContentPool.Return(丛丄业丕且丗下一万:  this.丞丄世业一与丕丞丆.name, 万且万且丑丗且丌丆:  this.丞丄世业一与丕丞丆);
            }
            
            PGCompany.GameModeHub.TabContentView val_3 = this._tabContentPool.Get<PGCompany.GameModeHub.TabContentView>(丛丄业丕且丗下一万:  丐丅丒专丛丏上与业.tabContent);
            this.丞丄世业一与丕丞丆 = val_3;
            if(val_3 == 0)
            {
                    return;
            }
            
            this.丞丄世业一与丕丞丆.transform.SetParent(p:  this.tabContentHolder);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丞丄世业一与丕丞丆, 丏业丟一东丂东丘丛:  true);
            this.丞丄世业一与丕丞丆.丈且东丑丂且万丒丅(丐丅丒专丛丏上与业:  丐丅丒专丛丏上与业);
        }
        internal PGCompany.GameModeHub.TabView 下丏丘丅丛丞丄东丟(string 不下上丙三与业丌三)
        {
            .不下上丙三与业丌三 = 不下上丙三与业丌三;
            return System.Linq.Enumerable.FirstOrDefault<PGCompany.GameModeHub.TabView>(source:  this.丕业丄丁丘丝丗丝丝, predicate:  new System.Func<PGCompany.GameModeHub.TabView, System.Boolean>(object:  new TabsUI.丗丛丘丑丐不丌丑丙(), method:  System.Boolean TabsUI.丗丛丘丑丐不丌丑丙::丌丁与丒丏丟三丒丄(PGCompany.GameModeHub.TabView 三丟东丕丄丄下下丑)));
        }
        public TabsUI()
        {
            this.七丆东上七业一丗丕 = new System.Collections.Generic.List<System.String>();
            this.丕业丄丁丘丝丗丝丝 = new System.Collections.Generic.List<PGCompany.GameModeHub.TabView>();
        }
    
    }

}
