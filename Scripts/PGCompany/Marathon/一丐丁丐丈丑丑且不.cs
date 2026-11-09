using UnityEngine;

namespace PGCompany.Marathon
{
    internal class 一丐丁丐丈丑丑且不
    {
        // Methods
        internal 一丐丁丐丈丑丑且不()
        {
        
        }
        public bool 东一三一万且丕世不(PGCompany.三东丏不丗世丅丌丄 丗丟上上丒丐丗丞丙)
        {
            PGCompany.三东丏不丗世丅丌丄 val_14;
            var val_15;
            var val_16;
            string val_18;
            string val_19;
            string val_20;
            var val_21;
            val_14 = 丗丟上上丒丐丗丞丙;
            PGCompany.ItemSystem.三三丌丞丘不且丗业[] val_1 = new PGCompany.ItemSystem.三三丌丞丘不且丗业[1];
            val_1[0] = 1;
            if((PGCompany.ItemSystem.丂丟丁丗丘与丞丂丟.东一三一万且丕世不(丗丟上上丒丐丗丞丙:  val_14, 丆丗丝丄丄万丂丂且:  val_1)) == false)
            {
                goto label_3;
            }
            
            PGCompany.ItemSystem.三三丌丞丘不且丗业[] val_3 = new PGCompany.ItemSystem.三三丌丞丘不且丗业[1];
            val_3[0] = 4;
            if((PGCompany.ItemSystem.丂丟丁丗丘与丞丂丟.东一三一万且丕世不(丗丟上上丒丐丗丞丙:  val_14, 丆丗丝丄丄万丂丂且:  val_3)) == false)
            {
                goto label_6;
            }
            
            PGCompany.ItemSystem.三三丌丞丘不且丗业[] val_5 = new PGCompany.ItemSystem.三三丌丞丘不且丗业[1];
            val_5[0] = 8;
            if((PGCompany.ItemSystem.丂丟丁丗丘与丞丂丟.东一三一万且丕世不(丗丟上上丒丐丗丞丙:  val_14, 丆丗丝丄丄万丂丂且:  val_5)) == false)
            {
                goto label_9;
            }
            
            val_15 = null;
            val_15 = null;
            val_16 = public static System.Boolean System.Linq.Enumerable::Contains<Rilisoft.OfferItemType>(System.Collections.Generic.IEnumerable<TSource> source, Rilisoft.OfferItemType value);
            if((System.Linq.Enumerable.Contains<Rilisoft.OfferItemType>(source:  Rilisoft.下丐丒一丝丈丝三丞.不三业丁一丄业丁丅, value:  val_14.不业丙丒丂丞下丆丙())) == true)
            {
                goto label_13;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_16 = 0;
            goto label_20;
            label_3:
            val_18 = val_14;
            val_19 = "marathon item skipped. ";
            val_20 = ", ItemCheckerType.ByValid";
            goto label_33;
            label_6:
            val_18 = val_14;
            val_19 = "marathon item skipped. ";
            val_20 = ", ItemCheckerType.ByPlayerLevel";
            goto label_33;
            label_9:
            val_18 = val_14;
            val_19 = "marathon item skipped. ";
            val_20 = ", ItemCheckerType.ByNotEnoughtPartsToCraft";
            goto label_33;
            label_20:
            if((PGCompany.ItemSystem.丈东丗三三丟上且七.一丅丗不丌世丅丂且(丘且丁丟丙东丏丅丗:  3).东一三一万且丕世不(丗丟上上丒丐丗丞丙:  val_14)) == false)
            {
                goto label_27;
            }
            
            label_13:
            PGCompany.ItemSystem.三三丌丞丘不且丗业[] val_12 = new PGCompany.ItemSystem.三三丌丞丘不且丗业[1];
            val_12[0] = 9;
            if((PGCompany.ItemSystem.丂丟丁丗丘与丞丂丟.东一三一万且丕世不(丗丟上上丒丐丗丞丙:  val_14, 丆丗丝丄丄万丂丂且:  val_12)) != false)
            {
                    val_21 = 1;
                return (bool)val_21;
            }
            
            val_18 = val_14;
            val_19 = "marathon item skipped. ";
            val_20 = ", ItemCheckerType.ByGameEventAvailable";
            goto label_33;
            label_27:
            val_18 = val_14;
            val_19 = "marathon item skipped. ";
            val_20 = ", ItemCheckerType.ByNotExists";
            label_33:
            val_14 = val_19 + val_18 + val_20;
            UnityEngine.Debug.Log(message:  val_14);
            val_21 = 0;
            return (bool)val_21;
        }
    
    }

}
