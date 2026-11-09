using UnityEngine;

namespace PGCompany.GiftSystem
{
    internal sealed class 下丂丆万丏万丌丗丘 : 丑世丂丙丛且丟一丁
    {
        // Methods
        internal override System.Collections.Generic.List<GiftRecipientDynamicWrapItem.一丄丙丐丄业丘东丕> 丒七丗丟下丐丟丟与(System.Collections.Generic.IEnumerable<string> 丛丅丈一一丟丂业万)
        {
            var val_25;
            var val_26;
            string val_30;
            var val_31;
            if(丛丅丈一一丟丂业万 != null)
            {
                    val_25 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
                System.Collections.Generic.List<一丄丙丐丄业丘东丕> val_4 = null;
                val_26 = val_4;
                val_4 = new System.Collections.Generic.List<一丄丙丐丄业丘东丕>(capacity:  System.Linq.Enumerable.Count<System.String>(source:  丛丅丈一一丟丂业万));
                if(val_25 == null)
            {
                    return (System.Collections.Generic.List<一丄丙丐丄业丘东丕>)val_26;
            }
            
                var val_28 = 0;
                val_28 = val_28 + 1;
            }
            else
            {
                    System.Collections.Generic.List<一丄丙丐丄业丘东丕> val_5 = null;
                val_26 = val_5;
                val_5 = new System.Collections.Generic.List<一丄丙丐丄业丘东丕>();
                return (System.Collections.Generic.List<一丄丙丐丄业丘东丕>)val_26;
            }
            
            System.Collections.Generic.IEnumerator<T> val_7 = 丛丅丈一一丟丂业万.GetEnumerator();
            label_37:
            var val_29 = 0;
            val_29 = val_29 + 1;
            if(val_7.MoveNext() == false)
            {
                goto label_14;
            }
            
            var val_30 = 0;
            val_30 = val_30 + 1;
            T val_11 = val_7.Current;
            七丈丗不丞丈丝丙七 val_12 = val_25.丘下丏丞丂不三丂七(丄丒且丙三丆丟与丏:  val_11);
            if((System.String.op_Equality(a:  val_12.业丐丐三丕一丗丛丁(), b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == true)
            {
                goto label_37;
            }
            
            new GiftRecipientDynamicWrapItem.与丂世丟丟七一丐丞() = new GiftRecipientDynamicWrapItem.与丂世丟丟七一丐丞();
            new GiftRecipientDynamicWrapItem.与丂世丟丟七一丐丞().东丒万业丌丂丌且丕(丙业与丙丗丝不丈东:  val_12.丙东专丂世丈丏丁丂());
            new GiftRecipientDynamicWrapItem.与丂世丟丟七一丐丞().世丈丁丂丞丙丞丑丝(丙业与丙丗丝不丈东:  val_12.丙丐丅丕丗丁丅丁丐());
            new GiftRecipientDynamicWrapItem.与丂世丟丟七一丐丞().丗丏专丝东丗丟丕东(丙业与丙丗丝不丈东:  val_12.东丙上东业丆不丟丘());
            new GiftRecipientDynamicWrapItem.与丂世丟丟七一丐丞().丙东丗丛且上三丙三(丙业与丙丗丝不丈东:  val_12.业丐丐三丕一丗丛丁());
            val_30 = 丂与专万与丐丌丏不.丑七不且上丗丁一世().专丞丙丟丟丆不丌下(丄丒且丙三丆丟与丏:  val_11);
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_30)) != true)
            {
                    val_30 = 丂与专万与丐丌丏不.丑七不且上丗丁一世().且丆一下丆丙丙丈丄(丄丒且丙三丆丟与丏:  val_11);
            }
            
            new GiftRecipientDynamicWrapItem.与丂世丟丟七一丐丞().丝丁专且丄丂下与且(丙业与丙丗丝不丈东:  Rilisoft.与丄丁丄丙丞下下丙.丒丘上丌上七丕丟丟(丘丈下丛丙丝世丗丏:  val_30, 丁丅丈丌丟世丗丗丟:  1));
            val_4.Add(item:  new GiftRecipientDynamicWrapItem.与丂世丟丟七一丐丞());
            goto label_37;
            label_14:
            val_31 = 0;
            val_25 = 0;
            if(val_7 == null)
            {
                
            }
            else
            {
                    var val_31 = 0;
                val_31 = val_31 + 1;
                val_7.Dispose();
            }
            
            if( != 1)
            {
                    return (System.Collections.Generic.List<一丄丙丐丄业丘东丕>)val_26;
            }
            
            if( == false)
            {
                    return (System.Collections.Generic.List<一丄丙丐丄业丘东丕>)val_26;
            }
            
            return (System.Collections.Generic.List<一丄丙丐丄业丘东丕>)val_26;
        }
        internal override PGCompany.GiftSystem.一丟丙一东丕丏万万 丁下丘丞且丙丕不丅(GiftRecipientDynamicWrapItem.一丄丙丐丄业丘东丕 丟丅上与丗丆东且丝)
        {
            .<丙丘一专丆丟丌世业>k__BackingField = 丟丅上与丗丆东且丝.业丄丁丘丝东丗业与();
            .<三丆专丟七东丆专世>k__BackingField = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁();
            return (PGCompany.GiftSystem.一丟丙一东丕丏万万)new PGCompany.GiftSystem.一丟丙一东丕丏万万();
        }
        public 下丂丆万丏万丌丗丘()
        {
            val_1 = new System.Object();
        }
    
    }

}
