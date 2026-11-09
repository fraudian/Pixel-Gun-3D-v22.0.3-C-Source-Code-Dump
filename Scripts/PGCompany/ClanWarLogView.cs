using UnityEngine;

namespace PGCompany
{
    public class ClanWarLogView : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject _closedWarLogContainer;
        private UnityEngine.GameObject _openWarLogContainer;
        private PGCompany.ClanWarLogEntryView _closedWarLogView;
        private PGCompany.DynamicStringWrapGrid _openWarLogGrid;
        private bool 下万丑专且丟丈一万;
        
        // Methods
        private void Awake()
        {
            PGCompany.ClanWarLogController val_1 = Rilisoft.Singleton<PGCompany.ClanWarLogController>.Instance;
            this._openWarLogGrid.UpdateContent(三丏丑不业丏不丂丈:  val_1.丘丐且丈丐不丆丞丌);
            this.CloseLog();
            this.丈丅丕丙丝一七下丒();
            Rilisoft.Singleton<PGCompany.ClanWarLogController>.Instance.丂丞丙丌七丌丙丕世(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void PGCompany.ClanWarLogView::丒丅丒七丘丈丑丆且(string 下上丒丄丅丘丏万丆)));
            Rilisoft.Singleton<PGCompany.ClanWarLogController>.Instance.丗一七丗一丞业丏丏(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void PGCompany.ClanWarLogView::丒丅丒七丘丈丑丆且(string 下上丒丄丅丘丏万丆)));
            PGCompany.ClanWarLogController val_6 = Rilisoft.Singleton<PGCompany.ClanWarLogController>.Instance;
            if(val_6.丘丐且丈丐不丆丞丌 != null)
            {
                    PGCompany.ClanWarLogController val_7 = Rilisoft.Singleton<PGCompany.ClanWarLogController>.Instance;
                var val_12 = 0;
                val_12 = val_12 + 1;
                if(val_7.丘丐且丈丐不丆丞丌.Count != 0)
            {
                    return;
            }
            
            }
            
            Rilisoft.Singleton<PGCompany.ClanWarLogController>.Instance.丙丞不丟不丗丈丞一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanWarLogView::丈丅丕丙丝一七下丒()));
        }
        private void 丈丅丕丙丝一七下丒()
        {
            var val_9;
            PGCompany.ClanWarLogController val_1 = Rilisoft.Singleton<PGCompany.ClanWarLogController>.Instance;
            if(val_1.丘丐且丈丐不丆丞丌 == null)
            {
                    return;
            }
            
            PGCompany.ClanWarLogController val_2 = Rilisoft.Singleton<PGCompany.ClanWarLogController>.Instance;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_9 = 0;
            if(val_2.丘丐且丈丐不丆丞丌.Count == 0)
            {
                    return;
            }
            
            if(this.下万丑专且丟丈一万 != false)
            {
                    PGCompany.ClanWarLogController val_5 = Rilisoft.Singleton<PGCompany.ClanWarLogController>.Instance;
                this._openWarLogGrid.UpdateContent(三丏丑不业丏不丂丈:  val_5.丘丐且丈丐不丆丞丌);
            }
            else
            {
                    PGCompany.ClanWarLogController val_6 = Rilisoft.Singleton<PGCompany.ClanWarLogController>.Instance;
                var val_12 = 0;
                val_12 = val_12 + 1;
                val_9 = 0;
                T val_8 = val_6.丘丐且丈丐不丆丞丌.Item[0];
            }
            
            Rilisoft.Singleton<PGCompany.ClanWarLogController>.Instance.丄丏丘且不丁世上丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanWarLogView::丈丅丕丙丝一七下丒()));
        }
        private void OnDestroy()
        {
            Rilisoft.Singleton<PGCompany.ClanWarLogController>.Instance.丂丞丙丌七丌丙丕世(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void PGCompany.ClanWarLogView::丒丅丒七丘丈丑丆且(string 下上丒丄丅丘丏万丆)));
        }
        public void OpenLog()
        {
            this.丄丑七丘丁且丞丙专(丟专丑下丂丝业丛且:  true);
            PGCompany.ClanWarLogController val_1 = Rilisoft.Singleton<PGCompany.ClanWarLogController>.Instance;
            this._openWarLogGrid.UpdateContent(三丏丑不业丏不丂丈:  val_1.丘丐且丈丐不丆丞丌);
        }
        public void CloseLog()
        {
            var val_5;
            var val_6;
            PGCompany.ClanWarLogEntryView val_8;
            PGCompany.ClanWarLogEntryView val_9;
            PGCompany.丄丙丅万丒丐与七丟<System.String> val_10;
            var val_13;
            this.丄丑七丘丁且丞丙专(丟专丑下丂丝业丛且:  false);
            PGCompany.ClanWarLogController val_1 = Rilisoft.Singleton<PGCompany.ClanWarLogController>.Instance;
            if(val_1.丘丐且丈丐不丆丞丌 == null)
            {
                goto label_2;
            }
            
            var val_7 = 0;
            val_5 = 1152921505630896136;
            val_7 = val_7 + 1;
            val_5 = 1152921505630896152;
            val_6 = 0;
            goto label_6;
            label_2:
            val_8 = this._closedWarLogView;
            goto label_8;
            label_6:
            val_9 = this._closedWarLogView;
            if(val_1.丘丐且丈丐不丆丞丌.Count < 1)
            {
                goto label_8;
            }
            
            PGCompany.ClanWarLogController val_4 = Rilisoft.Singleton<PGCompany.ClanWarLogController>.Instance;
            val_10 = val_4.丘丐且丈丐不丆丞丌;
            var val_8 = 0;
            val_5 = 1152921505630896136;
            val_8 = val_8 + 1;
            val_6 = 0;
            goto label_14;
            label_8:
            if(val_8 != null)
            {
                goto label_16;
            }
            
            label_17:
            label_16:
            val_10 = ???;
            val_13 = ???;
            goto typeof(PGCompany.ClanWarLogEntryView).__il2cppRuntimeField_178;
            label_14:
            T val_6 = val_10.Item[0];
            if(val_13 != 0)
            {
                goto label_16;
            }
            
            goto label_17;
        }
        private void 丄丑七丘丁且丞丙专(bool 丟专丑下丂丝业丛且)
        {
            this.下万丑专且丟丈一万 = 丟专丑下丂丝业丛且;
            if(this._closedWarLogContainer == 0)
            {
                    if(this._openWarLogContainer == 0)
            {
                goto label_6;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._openWarLogContainer, 丏业丟一东丂东丘丛:  丟专丑下丂丝业丛且);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._closedWarLogContainer, 丏业丟一东丂东丘丛:  (~丟专丑下丂丝业丛且) & 1);
            label_6:
            if(ClanWarUI.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            ClanWarUI val_8 = ClanWarUI.丑七不且上丗丁一世();
            val_8.clanWarMapUI.SetBottomAnchor(丙业与丙丗丝不丈东:  (this.下万丑专且丟丈一万 == true) ? 300 : 0);
        }
        private void 丒丅丒七丘丈丑丆且(string 下上丒丄丅丘丏万丆)
        {
            if(this._openWarLogGrid == null)
            {
                goto label_0;
            }
            
            if(this.下万丑专且丟丈一万 == false)
            {
                goto label_1;
            }
            
            label_2:
            this._openWarLogGrid.AddContentItem(下丅丙一丂丗丅丝七:  下上丒丄丅丘丏万丆);
            return;
            label_0:
            if(this.下万丑专且丟丈一万 == true)
            {
                goto label_2;
            }
            
            label_1:
            this._openWarLogGrid.AddContentInner(下丅丙一丂丗丅丝七:  下上丒丄丅丘丏万丆);
            if(this._closedWarLogView == null)
            {
                
            }
        
        }
        public ClanWarLogView()
        {
        
        }
    
    }

}
