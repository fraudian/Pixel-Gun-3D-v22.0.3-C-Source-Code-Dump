using UnityEngine;

namespace PGCompany.Piggy
{
    internal sealed class PiggyLevelSectionView : PGBehaviour
    {
        // Fields
        private UILabel _levelLabel;
        private ItemListUI itemListUI;
        private UnityEngine.Transform itemInfoHolder;
        private UnityEngine.GameObject state_Locked;
        private UnityEngine.GameObject state_Collected;
        private UnityEngine.GameObject state_CanCollect;
        private UnityEngine.GameObject state_NotCollected;
        private PGCompany.MainStore.东丆丒丄丂丆上丈业 丑丘丙上丁丌一丗万;
        private PGCompany.MainStore.七丄不下丘丏一丂丌 万丆一丑丑下丐一东;
        
        // Properties
        internal PGCompany.MainStore.七丄不下丘丏一丂丌 丒七专丝丟丈丒丈一 { get; }
        
        // Methods
        internal PGCompany.MainStore.七丄不下丘丏一丂丌 东丕七世专丑且丆世()
        {
            return (PGCompany.MainStore.七丄不下丘丏一丂丌)this.万丆一丑丑下丐一东;
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.MainStore.东丆丒丄丂丆上丈业 且丘丏丁丑与丙与丁, PGCompany.MainStore.七丄不下丘丏一丂丌 丈上丁丕世七丝丁丘)
        {
            this.丑丘丙上丁丌一丗万 = 且丘丏丁丑与丙与丁;
            this.万丆一丑丑下丐一东 = 丈上丁丕世七丝丁丘;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._levelLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10431"), arg0:  this.万丆一丑丑下丐一东.万丄丅丛下丐丒丞上));
            this.上与丟丗一上丛丌专(丆丌丙丛丄丂丘丟丟:  this.万丆一丑丑下丐一东.下丐丐丁与丂下世七);
            this.丂三万丄丕丏丗丟丒();
        }
        private void 上与丟丗一上丛丌专(System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> 丆丌丙丛丄丂丘丟丟)
        {
            var val_5;
            ItemListUI val_6;
            val_5 = 丆丌丙丛丄丂丘丟丟;
            val_6 = this;
            if(val_5 == null)
            {
                    return;
            }
            
            if(val_5.Count == 0)
            {
                    return;
            }
            
            this.丌丆丒业七且丅丂且();
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_2 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            List.Enumerator<T> val_3 = val_5.GetEnumerator();
            label_6:
            if(((-859679416) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_4 = 0.丐丏七丌丕丗业且上();
            val_2.Add(item:  val_4.m_stringLength);
            goto label_6;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_6 = this.itemListUI;
            val_6.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  val_2);
        }
        private void 丌丆丒业七且丅丂且()
        {
            this.itemListUI.丄一且丄丑专丙丗世();
        }
        private void 丂三万丄丕丏丗丟丒()
        {
            var val_8;
            PGCompany.MainStore.七丄不下丘丏一丂丌 val_9;
            var val_10;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Locked, 丏业丟一东丂东丘丛:  (~this.丑丘丙上丁丌一丗万.丂且与丈且丁专丟丐()) & 1);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Collected, 丏业丟一东丂东丘丛:  this.万丆一丑丑下丐一东.丐与下丁丁丞三丒与);
            if(this.万丆一丑丑下丐一东.丐与下丁丁丞三丒与 != false)
            {
                    val_8 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_CanCollect, 丏业丟一东丂东丘丛:  (this.万丆一丑丑下丐一东.万丄丅丛下丐丒丞上 <= this.丑丘丙上丁丌一丗万.丈一下下丞世三丑丄()) ? 1 : 0);
            val_9 = this.万丆一丑丑下丐一东;
            if(this.万丆一丑丑下丐一东.丐与下丁丁丞三丒与 != false)
            {
                    val_10 = 0;
            }
            else
            {
                    val_9 = this.万丆一丑丑下丐一东.万丄丅丛下丐丒丞上;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_NotCollected, 丏业丟一东丂东丘丛:  (val_9 == (this.丑丘丙上丁丌一丗万.丈一下下丞世三丑丄() + 1)) ? 1 : 0);
        }
        public void U_CollectRewards()
        {
            UnityEngine.Transform val_10;
            string val_11;
            val_10 = this;
            if((this.丑丘丙上丁丌一丗万.丂且与丈且丁专丟丐() != false) && (this.万丆一丑丑下丐一东.丐与下丁丁丞三丒与 != true))
            {
                    if(this.万丆一丑丑下丐一东.万丄丅丛下丐丒丞上 <= this.丑丘丙上丁丌一丗万.丈一下下丞世三丑丄())
            {
                goto label_7;
            }
            
            }
            
            if(this.万丆一丑丑下丐一东.下丐丐丁与丂下世七.Count < 1)
            {
                    return;
            }
            
            if(this.itemInfoHolder == 0)
            {
                    return;
            }
            
            PGCompany.丄与丘丑业专丞七丅 val_5 = this.万丆一丑丑下丐一东.下丐丐丁与丂下世七.Item[0];
            val_10 = this.itemInfoHolder;
            if(val_5.ItemParams != null)
            {
                    val_11 = val_5.ItemParams.业上丙丞丐丄丆丅七();
            }
            else
            {
                    val_11 = 0.业上丙丞丐丄丆丅七();
            }
            
            Rilisoft.ItemViewer val_9 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  val_10, 丕丁下丌不万丅丞丛:  val_11, 丅三丟世下丞丝丙万:  val_5.ItemParams.丂丁丏一丙丛业且丌(), 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  false);
            return;
            label_7:
            this.万丆一丑丑下丐一东.东丗丟丐丞下万且不();
        }
        public PiggyLevelSectionView()
        {
        
        }
    
    }

}
