using UnityEngine;

namespace PGCompany
{
    public static class 丟不丛丈三丝丝万东
    {
        // Methods
        public static string 丕丆丁万丈上丈丆东(PGCompany.ModuleDataV1 丕上业丕丘上丘七一)
        {
            string val_22;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            System.Text.StringBuilder val_2 = val_1.Append(value:  "new ModuleDataV1 {");
            System.Text.StringBuilder val_3 = val_1.AppendFormat(format:  "Id = \"{0}\", ", arg0:  丕上业丕丘上丘七一.Id);
            System.Text.StringBuilder val_5 = val_1.AppendFormat(format:  "Index = {0}, ", arg0:  丕上业丕丘上丘七一.Index);
            System.Text.StringBuilder val_6 = val_1.AppendFormat(format:  "Type = ModuleData.ModuleType.{0}, ", arg0:  丕上业丕丘上丘七一.Type);
            System.Text.StringBuilder val_7 = val_1.AppendFormat(format:  "Category = ModuleData.ModuleCategory.{0}, ", arg0:  丕上业丕丘上丘七一.Category);
            System.Text.StringBuilder val_10 = val_1.AppendFormat(format:  "Up = new SaltedInt(SaltedInt.NextRandomInt(),{0}), ", arg0:  丕上业丕丘上丘七一.Up.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture));
            System.Text.StringBuilder val_13 = val_1.AppendFormat(format:  "Weight = new SaltedInt(SaltedInt.NextRandomInt(),{0}), ", arg0:  丕上业丕丘上丘七一.Weight.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture));
            string val_15 = 丕上业丕丘上丘七一.CountForUp.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
            if(val_1 != null)
            {
                    System.Text.StringBuilder val_16 = val_1.AppendFormat(format:  "CountForUp = new SaltedInt(SaltedInt.NextRandomInt(),{0}), ", arg0:  val_15);
                val_22 = "}";
                System.Text.StringBuilder val_17 = val_1.Append(value:  val_22);
            }
            else
            {
                    System.Text.StringBuilder val_18 = val_1.AppendFormat(format:  "CountForUp = new SaltedInt(SaltedInt.NextRandomInt(),{0}), ", arg0:  val_15);
                val_22 = "}";
                System.Text.StringBuilder val_19 = val_1.Append(value:  val_22);
            }
            
            string[] val_20 = new string[5];
            val_20[0] = "{ \"";
            val_20[1] = 丕上业丕丘上丘七一.Id;
            val_20[2] = "\", ";
            val_20[3] = val_1;
            val_20[4] = " }";
            return (string)+val_20;
        }
        public static string 丁丐丂专一丄丞丐上(PGCompany.ModuleData 丕上业丕丘上丘七一)
        {
            string val_22;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            System.Text.StringBuilder val_2 = val_1.Append(value:  "new ModuleData {");
            System.Text.StringBuilder val_3 = val_1.AppendFormat(format:  "Id = \"{0}\", ", arg0:  丕上业丕丘上丘七一.Id);
            System.Text.StringBuilder val_5 = val_1.AppendFormat(format:  "Index = {0}, ", arg0:  丕上业丕丘上丘七一.Index);
            System.Text.StringBuilder val_6 = val_1.AppendFormat(format:  "Type = ModuleData.ModuleType.{0}, ", arg0:  丕上业丕丘上丘七一.Type);
            if(val_1 != null)
            {
                    System.Text.StringBuilder val_7 = val_1.AppendFormat(format:  "Category = ModuleData.ModuleCategory.{0}, ", arg0:  丕上业丕丘上丘七一.Category);
            }
            else
            {
                    System.Text.StringBuilder val_8 = val_1.AppendFormat(format:  "Category = ModuleData.ModuleCategory.{0}, ", arg0:  丕上业丕丘上丘七一.Category);
            }
            
            System.Text.StringBuilder val_9 = val_1.Append(value:  "PointData = new ModulePointData {");
            System.Text.StringBuilder val_10 = val_1.AppendFormat(format:  "Id = \"{0}\", ", arg0:  丕上业丕丘上丘七一.PointData.Id);
            System.Text.StringBuilder val_12 = val_1.AppendFormat(format:  "Index = {0}, ", arg0:  丕上业丕丘上丘七一.PointData.Index);
            int val_13 = 丕上业丕丘上丘七一.PointData.IndexItemModule;
            if(val_1 != null)
            {
                    System.Text.StringBuilder val_14 = val_1.AppendFormat(format:  "IndexItemModule = {0}, ", arg0:  val_13);
                System.Text.StringBuilder val_15 = val_1.Append(value:  "},");
                val_22 = "}";
                System.Text.StringBuilder val_16 = val_1.Append(value:  val_22);
            }
            else
            {
                    System.Text.StringBuilder val_17 = val_1.AppendFormat(format:  "IndexItemModule = {0}, ", arg0:  val_13);
                System.Text.StringBuilder val_18 = val_1.Append(value:  "},");
                val_22 = "}";
                System.Text.StringBuilder val_19 = val_1.Append(value:  val_22);
            }
            
            string[] val_20 = new string[5];
            val_20[0] = "{ \"";
            val_20[1] = 丕上业丕丘上丘七一.Id;
            val_20[2] = "\", ";
            val_20[3] = val_1;
            val_20[4] = " }";
            return (string)+val_20;
        }
        public static void 丗丁东丟上且万下世(string 丞丕丒专一下丙业上, out System.Collections.Generic.List<PGCompany.ModuleDataV1> 丈丄丛丆丅丟丈业丕, out System.Collections.Generic.List<PGCompany.ModuleData> 丌丑丟一丐且东且上)
        {
            丈丄丛丆丅丟丈业丕 = new System.Collections.Generic.List<PGCompany.ModuleDataV1>();
            丌丑丟一丐且东且上 = new System.Collections.Generic.List<PGCompany.ModuleData>();
            DataSystem.丈且丈上不下且丝丒 val_3 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            var val_7 = 0;
            val_7 = val_7 + 1;
            if(val_3 == null)
            {
                    return;
            }
            
            System.Collections.Generic.List<TSource> val_5 = System.Linq.Enumerable.ToList<PGCompany.ModuleDataV1>(source:  val_3);
            丈丄丛丆丅丟丈业丕 = val_5;
            丌丑丟一丐且东且上 = System.Linq.Enumerable.ToList<PGCompany.ModuleData>(source:  val_5);
        }
        public static string 七丁丟丘丁丆一丐丕(PGCompany.ModuleData 丕上业丕丘上丘七一)
        {
            return (string)System.String.Format(format:  "{{ {0}, new ItemClientId(Rilisoft.OfferItemType.Module, \"{1}\") }}", arg0:  丕上业丕丘上丘七一.Index, arg1:  丕上业丕丘上丘七一.Id);
        }
        public static string 丌丝丞丆丈三丒七与(PGCompany.ModuleData 丕上业丕丘上丘七一)
        {
            string val_3;
            if(丕上业丕丘上丘七一 != null)
            {
                    val_3 = 丕上业丕丘上丘七一.Id;
                return (string)System.String.Format(format:  "new TagIndexStruct(\"{0}\", {1})", arg0:  val_3 = 11993091, arg1:  丕上业丕丘上丘七一.Index);
            }
            
            return (string)System.String.Format(format:  "new TagIndexStruct(\"{0}\", {1})", arg0:  val_3, arg1:  丕上业丕丘上丘七一.Index);
        }
        public static string 丌丁一丁丟丄丅上不(PGCompany.ModuleData 丕上业丕丘上丘七一)
        {
            return (string)System.String.Format(format:  "{{ {0}, new ItemClientId(Rilisoft.OfferItemType.ModulePoint, \"{1}\") }}", arg0:  丕上业丕丘上丘七一.PointData.Index, arg1:  丕上业丕丘上丘七一.PointData.Id);
        }
        public static string 丕丁丐丝丘丁丐世丌(PGCompany.ModuleData 丕上业丕丘上丘七一)
        {
            PGCompany.ModulePointData val_3;
            string val_4;
            val_3 = 丕上业丕丘上丘七一.PointData;
            if(val_3 != null)
            {
                    val_4 = 丕上业丕丘上丘七一.PointData.Id;
                return (string)System.String.Format(format:  "new TagIndexStruct(\"{0}\", {1})", arg0:  val_4 = 丕上业丕丘上丘七一.PointData.Id, arg1:  val_3.Index);
            }
            
            if(丕上业丕丘上丘七一.PointData != null)
            {
                    val_3 = 丕上业丕丘上丘七一.PointData;
                return (string)System.String.Format(format:  "new TagIndexStruct(\"{0}\", {1})", arg0:  val_4, arg1:  val_3.Index);
            }
            
            val_3 = 0;
            return (string)System.String.Format(format:  "new TagIndexStruct(\"{0}\", {1})", arg0:  val_4, arg1:  val_3.Index);
        }
        public static string 不丕丙丁丛丐丞东丁(PGCompany.ModuleData 丕上业丕丘上丘七一)
        {
            if(丕上业丕丘上丘七一 != null)
            {
                    return "new ItemModule (new ItemParams (Rilisoft.OfferItemType.Module, \"" + 丕上业丕丘上丘七一.Id + "\") {Count = 1 })"("\") {Count = 1 })");
            }
            
            return "new ItemModule (new ItemParams (Rilisoft.OfferItemType.Module, \"" + 丕上业丕丘上丘七一.Id + "\") {Count = 1 })"("\") {Count = 1 })");
        }
        public static string 且且丏东东下业丁七(PGCompany.ModuleData 丕上业丕丘上丘七一)
        {
            if(丕上业丕丘上丘七一.PointData != null)
            {
                    return "new ItemModulePoint (new ItemParams (Rilisoft.OfferItemType.ModulePoint, \"" + 丕上业丕丘上丘七一.PointData.Id + "\") {Count = 1 })"("\") {Count = 1 })");
            }
            
            return "new ItemModulePoint (new ItemParams (Rilisoft.OfferItemType.ModulePoint, \"" + 丕上业丕丘上丘七一.PointData.Id + "\") {Count = 1 })"("\") {Count = 1 })");
        }
    
    }

}
