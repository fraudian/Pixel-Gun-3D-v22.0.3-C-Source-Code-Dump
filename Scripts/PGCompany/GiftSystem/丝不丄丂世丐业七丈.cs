using UnityEngine;

namespace PGCompany.GiftSystem
{
    internal sealed class 丝不丄丂世丐业七丈 : 丑世丂丙丛且丟一丁
    {
        // Methods
        internal override System.Collections.Generic.List<GiftRecipientDynamicWrapItem.一丄丙丐丄业丘东丕> 丒七丗丟下丐丟丟与(System.Collections.Generic.IEnumerable<string> 丛丅丈一一丟丂业万)
        {
            var val_23;
            string val_27;
            var val_28;
            var val_29;
            if(丛丅丈一一丟丂业万 != null)
            {
                    System.Collections.Generic.List<一丄丙丐丄业丘东丕> val_2 = null;
                val_23 = val_2;
                val_2 = new System.Collections.Generic.List<一丄丙丐丄业丘东丕>(capacity:  System.Linq.Enumerable.Count<System.String>(source:  丛丅丈一一丟丂业万));
                var val_26 = 0;
                val_26 = val_26 + 1;
            }
            else
            {
                    System.Collections.Generic.List<一丄丙丐丄业丘东丕> val_3 = null;
                val_23 = val_3;
                val_3 = new System.Collections.Generic.List<一丄丙丐丄业丘东丕>();
                return (System.Collections.Generic.List<一丄丙丐丄业丘东丕>)val_23;
            }
            
            System.Collections.Generic.IEnumerator<T> val_5 = 丛丅丈一一丟丂业万.GetEnumerator();
            label_33:
            var val_27 = 0;
            val_27 = val_27 + 1;
            if(val_5.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_28 = 0;
            val_28 = val_28 + 1;
            T val_9 = val_5.Current;
            if(((System.String.op_Equality(a:  val_9, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == true) || ((丂与专万与丐丌丏不.丑七不且上丗丁一世().三丐丁一且一丏三丞(丄丒且丙三丆丟与丏:  val_9)) == null))
            {
                goto label_33;
            }
            
            new GiftRecipientDynamicWrapItem.一丄丙丐丄业丘东丕() = new GiftRecipientDynamicWrapItem.一丄丙丐丄业丘东丕();
            new GiftRecipientDynamicWrapItem.一丄丙丐丄业丘东丕().东丒万业丌丂丌且丕(丙业与丙丗丝不丈东:  丂与专万与丐丌丏不.丑七不且上丗丁一世().七丙丞且世七丙丐下(丄丒且丙三丆丟与丏:  val_9));
            new GiftRecipientDynamicWrapItem.一丄丙丐丄业丘东丕().丗丏专丝东丗丟丕东(丙业与丙丗丝不丈东:  丂与专万与丐丌丏不.丑七不且上丗丁一世().三业三一丟上丁丌丅(丄丒且丙三丆丟与丏:  val_9));
            new GiftRecipientDynamicWrapItem.一丄丙丐丄业丘东丕().丙东丗丛且上三丙三(丙业与丙丗丝不丈东:  val_9);
            val_27 = 丂与专万与丐丌丏不.丑七不且上丗丁一世().专丞丙丟丟丆不丌下(丄丒且丙三丆丟与丏:  val_9);
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_27)) != true)
            {
                    val_27 = 丂与专万与丐丌丏不.丑七不且上丗丁一世().且丆一下丆丙丙丈丄(丄丒且丙三丆丟与丏:  val_9);
            }
            
            new GiftRecipientDynamicWrapItem.一丄丙丐丄业丘东丕().丝丁专且丄丂下与且(丙业与丙丗丝不丈东:  Rilisoft.与丄丁丄丙丞下下丙.丒丘上丌上七丕丟丟(丘丈下丛丙丝世丗丏:  val_27, 丁丅丈丌丟世丗丗丟:  1));
            val_2.Add(item:  new GiftRecipientDynamicWrapItem.一丄丙丐丄业丘东丕());
            goto label_33;
            label_12:
            val_28 = 0;
            val_29 = 0;
            if(val_5 == null)
            {
                
            }
            else
            {
                    var val_29 = 0;
                val_29 = val_29 + 1;
                val_5.Dispose();
            }
            
            if( != 1)
            {
                    return (System.Collections.Generic.List<一丄丙丐丄业丘东丕>)val_23;
            }
            
            if( == false)
            {
                    return (System.Collections.Generic.List<一丄丙丐丄业丘东丕>)val_23;
            }
            
            return (System.Collections.Generic.List<一丄丙丐丄业丘东丕>)val_23;
        }
        internal override PGCompany.GiftSystem.一丟丙一东丕丏万万 丁下丘丞且丙丕不丅(GiftRecipientDynamicWrapItem.一丄丙丐丄业丘东丕 丟丅上与丗丆东且丝)
        {
            .<丙丘一专丆丟丌世业>k__BackingField = 丟丅上与丗丆东且丝.业丄丁丘丝东丗业与();
            return (PGCompany.GiftSystem.一丟丙一东丕丏万万)new PGCompany.GiftSystem.一丟丙一东丕丏万万();
        }
        public 丝不丄丂世丐业七丈()
        {
            val_1 = new System.Object();
        }
    
    }

}
