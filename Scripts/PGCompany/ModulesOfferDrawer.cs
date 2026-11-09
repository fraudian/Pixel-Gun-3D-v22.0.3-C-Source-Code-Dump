using UnityEngine;

namespace PGCompany
{
    internal class ModulesOfferDrawer : BaseOfferPackDrawer, 丄与且丈丘丄三丗丐
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, string> 丘丒丑丏丁丕丝丒七;
        private Rilisoft.ItemViewer 丂不丆丆丞东丌丌且;
        private UIGrid _itemGrid;
        private PGCompany.InventoryItemView _itemViewExample;
        private UILabel _moduleDescription;
        
        // Properties
        public override int 下丄丈不与世丐业专 { get; }
        
        // Methods
        public override int get_Id()
        {
            return 4;
        }
        public override bool Show(Rilisoft.业丙丘丆东丈丕丂丄 不专一业下丞丝丑丗, Rilisoft.BonusData 丛丝丙丄七一丁丅三)
        {
            var val_6;
            Rilisoft.BonusData val_15;
            var val_16;
            val_15 = 丛丝丙丄七一丁丅三;
            if((this.Show(不专一业下丞丝丑丗:  不专一业下丞丝丑丗, 丛丝丙丄七一丁丅三:  val_15)) == false)
            {
                goto label_1;
            }
            
            val_15 = this._moduleDescription;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_15, 丕丗丘丑丛与丑业丒:  this.东丏丘丕丟丙丞东上());
            List.Enumerator<T> val_4 = 不专一业下丞丝丑丗.丏与丅专三丙与丘丒().GetEnumerator();
            label_21:
            if(((-631875392) & 1) == 0)
            {
                goto label_6;
            }
            
            UnityEngine.GameObject val_10 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._itemViewExample.gameObject, 丈东丘丏与丌东东下:  this._itemGrid.transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            if(val_10 == 0)
            {
                goto label_21;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_10, 丏业丟一东丂东丘丛:  true);
            PGCompany.InventoryItemView val_12 = val_10.GetComponent<PGCompany.InventoryItemView>();
            if(val_12 == 0)
            {
                goto label_21;
            }
            
            val_12.Setup(丏且丕丄丁丟丆丏丁:  val_6.丐丏七丌丕丗业且上());
            goto label_21;
            label_1:
            val_16 = 0;
            return (bool)val_16;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.东不丞丂万下三与丕();
            val_16 = 1;
            return (bool)val_16;
        }
        private string 不世下丘丑丘丛丂世()
        {
            Rilisoft.Offers.丌丒且丑丐丐丒丗且 val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丌丒且丑丐丐丒丗且>(丗与丟上上丑专世丗:  80);
            if(val_2 == null)
            {
                    return (string)System.String.alignConst;
            }
            
            return val_2.不世下丘丑丘丛丂世();
        }
        private string 东丏丘丕丟丙丞东上()
        {
            string val_1 = this.不世下丘丑丘丛丂世();
            if((this.丘丒丑丏丁丕丝丒七.ContainsKey(key:  val_1)) == false)
            {
                    return (string)System.String.alignConst;
            }
            
            return I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丘丒丑丏丁丕丝丒七.Item[val_1]);
        }
        public void U_ItemView(PGCompany.InventoryItemView 丑丂不下丁丄与万丏)
        {
            PGCompany.InventoryItemView val_9 = 丑丂不下丁丄与万丏;
            if(val_9.ItemParams == null)
            {
                    return;
            }
            
            Rilisoft.OfferItem val_7 = null;
            val_9 = val_7;
            val_7 = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  val_9.ItemParams.不业丙丒丂丞下丆丙(), 丞一丁业丄一一业且:  val_9.ItemParams.业上丙丞丐丄丆丅七(), 丂丕丂丏专丂丄丕且:  1);
            this.丂不丆丆丞东丌丌且 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  this.transform, 丏且丕丄丁丟丆丏丁:  val_7, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 丒不业且丄丅世世下:  false);
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            if(this.丂不丆丆丞东丌丌且 == 0)
            {
                    return;
            }
            
            this = ???;
            goto typeof(Rilisoft.ItemViewer).__il2cppRuntimeField_178;
        }
        public ModulesOfferDrawer()
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(val_1 != null)
            {
                    val_1.Add(key:  "kinetic", value:  "Key_7430");
            }
            else
            {
                    val_1.Add(key:  "kinetic", value:  "Key_7430");
            }
            
            val_1.Add(key:  "magic", value:  "Key_7431");
            this.丘丒丑丏丁丕丝丒七 = val_1;
        }
    
    }

}
