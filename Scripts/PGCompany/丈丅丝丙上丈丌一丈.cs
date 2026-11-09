using UnityEngine;

namespace PGCompany
{
    internal class 丈丅丝丙上丈丌一丈
    {
        // Fields
        private static readonly Rilisoft.七丞丞丅东丞专丙丝<PGCompany.丈丅丝丙上丈丌一丈> 丝业丆丁业三丈丟东;
        private readonly System.Collections.Generic.List<PGCompany.丈丅丝丙上丈丌一丈.DropInfo> 丛七下三一不专丄丙;
        
        // Properties
        internal static PGCompany.丈丅丝丙上丈丌一丈 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static PGCompany.丈丅丝丙上丈丌一丈 丑七不且上丗丁一世()
        {
            null = null;
            if(PGCompany.丈丅丝丙上丈丌一丈.丝业丆丁业三丈丟东 != null)
            {
                    return PGCompany.丈丅丝丙上丈丌一丈.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
            }
            
            return PGCompany.丈丅丝丙上丈丌一丈.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
        }
        private 丈丅丝丙上丈丌一丈()
        {
            this.丛七下三一不专丄丙 = new System.Collections.Generic.List<DropInfo>();
            this.丈丕三且专上上东丈();
        }
        private void 丈丕三且专上上东丈()
        {
            if(PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丟东丒三一丐业且专() == 2)
            {
                    PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丛丌丌且下丌丌丂丅(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void PGCompany.丈丅丝丙上丈丌一丈::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
                PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void PGCompany.丈丅丝丙上丈丌一丈::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
                this.不下丌丆东丑丈丕丝();
                return;
            }
            
            this.丛七下三一不专丄丙.Clear();
        }
        private void 丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
        {
            if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 13)
            {
                    return;
            }
            
            this.不下丌丆东丑丈丕丝();
        }
        private void 不下丌丆东丑丈丕丝()
        {
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            object val_35;
            float val_36;
            this.丛七下三一不专丄丙.Clear();
            string val_31 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  13);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_31)) == true)
            {
                    return;
            }
            
            object val_4 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_31);
            if(val_4 == null)
            {
                    return;
            }
            
            val_31 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_4) : 0;
            val_31 = 1152921523884262800;
            val_32 = "place";
            val_33 = 0;
            goto label_9;
            label_54:
            object val_5 = val_31.Item[0];
            if((((val_5 != null) && ((val_5.ContainsKey(key:  "regim")) != false)) && ((val_5.ContainsKey(key:  "place")) != false)) && ((val_5.ContainsKey(key:  "drop")) != false))
            {
                    System.Nullable<T> val_10 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<Rilisoft.七丕丟丏三丈一丄世>(下业七不丑丂丏丟东:  val_5.Item["regim"], 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  false);
                val_32 = "place";
                if(((-788252536) & 1) != 0)
            {
                    int val_12 = 0;
                val_32 = "place";
                if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_5.Item["place"], 丙业与丙丗丝不丈东: out  val_12)) != false)
            {
                    object val_14 = val_5.Item["drop"];
                if((val_14 != null) && (val_14.Count != 0))
            {
                    丈丅丝丙上丈丌一丈.DropInfo val_16 = new 丈丅丝丙上丈丌一丈.DropInfo();
                if(val_16 != null)
            {
                    .Regim = ;
                val_34 = val_12;
            }
            else
            {
                    mem[16] = ;
                val_34 = val_12;
            }
            
                .Place = 0;
                System.Collections.Generic.List<DropItem> val_17 = new System.Collections.Generic.List<DropItem>();
                .ItemsForDrop = val_17;
                if(val_14.Count >= 1)
            {
                    var val_32 = 0;
                do
            {
                object val_19 = val_14.Item[0];
                if(((val_19 != null) && ((val_19.ContainsKey(key:  "item")) != false)) && ((val_19.ContainsKey(key:  "weight")) != false))
            {
                    object val_22 = val_19.Item["weight"];
                if(val_22 == null)
            {
                    val_35 = val_22;
            }
            
                val_35 = val_35;
                if((丞东丑专丛丆丄丝世.丝丐丐丝丒丈且专专(丞丕丒专一下丙业上:  val_35, 丙业与丙丗丝不丈东: out  float val_23 = -3.549269E+10f)) != false)
            {
                    Rilisoft.OfferItem val_26 = Rilisoft.OfferItem.东丝丄丈丆三丘与丈(丞丕丒专一下丙业上:  val_19.Item["item"]);
                if((val_26 != null) && (val_26.IsKnownItem != false))
            {
                    丈丅丝丙上丈丌一丈.DropInfo.DropItem val_28 = new 丈丅丝丙上丈丌一丈.DropInfo.DropItem();
                if(val_28 != null)
            {
                    .Item = val_26;
                val_36 = 0f;
            }
            else
            {
                    mem[16] = val_26;
                val_36 = 0f;
            }
            
                .Weight = val_36;
                val_17.Add(item:  val_28);
                val_31 = 1152921523884262800;
            }
            
            }
            
            }
            
                val_32 = val_32 + 1;
            }
            while(val_32 < val_14.Count);
            
            }
            
                this.丛七下三一不专丄丙.Add(item:  val_16);
                val_32 = "place";
            }
            
            }
            
            }
            
            }
            
            val_33 = 1;
            label_9:
            if(val_33 < val_31.Count)
            {
                goto label_54;
            }
        
        }
        internal PGCompany.丈丅丝丙上丈丌一丈.DropInfo 一下丈且丞七东业丗(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, int 且丒丛与丞世丙丕丌)
        {
            var val_4;
            丈丅丝丙上丈丌一丈.业东下丕世丗丏万丏 val_1 = new 丈丅丝丙上丈丌一丈.业东下丕世丗丏万丏();
            if(val_1 != null)
            {
                    .上且丗一丏丏万丅丌 = 上且丗一丏丏万丅丌;
            }
            else
            {
                    mem[16] = 上且丗一丏丏万丅丌;
            }
            
            .且丒丛与丞世丙丕丌 = 且丒丛与丞世丙丕丌;
            if(this.丛七下三一不专丄丙 != null)
            {
                    DropInfo val_3 = System.Linq.Enumerable.FirstOrDefault<DropInfo>(source:  this.丛七下三一不专丄丙, predicate:  new System.Func<DropInfo, System.Boolean>(object:  val_1, method:  System.Boolean 丈丅丝丙上丈丌一丈.业东下丕世丗丏万丏::与丌丂丐丝丟丁丕且(PGCompany.丈丅丝丙上丈丌一丈.DropInfo 丐丆丂丒丁万丈丛丅)));
                return (DropInfo)val_4;
            }
            
            val_4 = 0;
            return (DropInfo)val_4;
        }
        internal Rilisoft.OfferItem 丂丄东丁丒东丛丗东(Rilisoft.七丕丟丏三丈一丄世 丒七世丈丌丑丏丄丏, int 且丒丛与丞世丙丕丌)
        {
            var val_9;
            System.Collections.Generic.List<DropItem> val_10;
            System.Collections.Generic.IList<T> val_11;
            var val_12;
            System.Func<DropItem, System.Boolean> val_14;
            var val_15;
            System.Func<DropItem, System.Single> val_17;
            val_9 = this;
            val_11 = this.一下丈且丞七东业丗(上且丗一丏丏万丅丌:  丒七世丈丌丑丏丄丏, 且丒丛与丞世丙丕丌:  且丒丛与丞世丙丕丌);
            if(val_11 == null)
            {
                    return (Rilisoft.OfferItem)val_10;
            }
            
            val_10 = val_1.ItemsForDrop;
            if(val_10 == null)
            {
                    return (Rilisoft.OfferItem)val_10;
            }
            
            if(val_10.Count != 0)
            {
                    val_12 = null;
                val_12 = null;
                val_14 = 丈丅丝丙上丈丌一丈.<>c.<>9__9_0;
                if(val_14 == null)
            {
                    System.Func<DropItem, System.Boolean> val_3 = null;
                val_14 = val_3;
                val_3 = new System.Func<DropItem, System.Boolean>(object:  丈丅丝丙上丈丌一丈.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丈丅丝丙上丈丌一丈.<>c::上三丘下东专丕丈丐(PGCompany.丈丅丝丙上丈丌一丈.DropInfo.DropItem 七丞丙丒三丕且丌丟));
                丈丅丝丙上丈丌一丈.<>c.<>9__9_0 = val_14;
            }
            
                val_11 = System.Linq.Enumerable.ToList<DropItem>(source:  System.Linq.Enumerable.Where<DropItem>(source:  val_1.ItemsForDrop, predicate:  val_3));
                if(val_11.Count != 0)
            {
                    val_15 = null;
                val_15 = null;
                val_17 = 丈丅丝丙上丈丌一丈.<>c.<>9__9_1;
                if(val_17 == null)
            {
                    System.Func<DropItem, System.Single> val_7 = null;
                val_17 = val_7;
                val_7 = new System.Func<DropItem, System.Single>(object:  丈丅丝丙上丈丌一丈.<>c.__il2cppRuntimeField_static_fields, method:  System.Single 丈丅丝丙上丈丌一丈.<>c::世东下丘丗丐丄七丌(PGCompany.丈丅丝丙上丈丌一丈.DropInfo.DropItem 丐丆丂丒丁万丈丛丅));
                丈丅丝丙上丈丌一丈.<>c.<>9__9_1 = val_17;
            }
            
                if((丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<DropItem>(丑东与丅丐丅丂丞业:  val_11, 丆万丒下万下业且丑:  val_7)) == null)
            {
                    return (Rilisoft.OfferItem)val_10;
            }
            
                val_10 = val_8.Item;
                return (Rilisoft.OfferItem)val_10;
            }
            
            }
            
            val_10 = 0;
            return (Rilisoft.OfferItem)val_10;
        }
        internal PGCompany.丈丅丝丙上丈丌一丈.下东丙丑丙丞丛丑上 丄上且丏丅丞丂丙上(Rilisoft.七丕丟丏三丈一丄世 丒七世丈丌丑丏丄丏, int 且丒丛与丞世丙丕丌, bool 业东丞丏丒业万丏丘)
        {
            return 0;
        }
        internal PGCompany.丗丟丄丈东丝丕丄世 与丆丝丞丁万丆丏不(且七丏丆万丑丞一丂 丁丅丈丌丟世丗丗丟)
        {
            .丁丅丈丌丟世丗丗丟 = 丁丅丈丌丟世丗丗丟;
            ModuleChestData val_4 = System.Linq.Enumerable.FirstOrDefault<ModuleChestData>(source:  丐东不丅丂丂丅丙不.丁世与业丈丅业丒与(), predicate:  new System.Func<ModuleChestData, System.Boolean>(object:  new 丈丅丝丙上丈丌一丈.丗丛丘丑丐不丌丑丙(), method:  System.Boolean 丈丅丝丙上丈丌一丈.丗丛丘丑丐不丌丑丙::丞丙丐且丕丒丘丆丘(ModuleChestData 三丟东丕丄丄下下丑)));
            if(val_4 == null)
            {
                    return (PGCompany.丗丟丄丈东丝丕丄世)val_4;
            }
            
            PGCompany.世东三上七丂丌下丑 val_5 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            if(val_5 != null)
            {
                    return val_5.一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  136, 丞丅上丏丂且下丅与:  val_4.id);
            }
            
            return val_5.一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  136, 丞丅上丏丂且下丅与:  val_4.id);
        }
        private static 丈丅丝丙上丈丌一丈()
        {
            null = null;
            PGCompany.丈丅丝丙上丈丌一丈.丝业丆丁业三丈丟东 = new Rilisoft.七丞丞丅东丞专丙丝<PGCompany.丈丅丝丙上丈丌一丈>(丙丂丌且丌世丒丐三:  new System.Func<PGCompany.丈丅丝丙上丈丌一丈>(object:  丈丅丝丙上丈丌一丈.<>c.<>9, method:  PGCompany.丈丅丝丙上丈丌一丈 丈丅丝丙上丈丌一丈.<>c::丛业丅丞丗三不与丝()));
        }
    
    }

}
