using UnityEngine;

namespace PGCompany.BattlePass
{
    [Serializable]
    public class BPChallangesProgressForSeason
    {
        // Fields
        public System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeProgress> BpChallengeProgresses;
        public int SeasonId;
        
        // Methods
        internal static PGCompany.BattlePass.BPChallangesProgressForSeason 丝丅丌丁丒丟三丏上(PGCompany.BattlePass.BPChallangesProgressForSeason 丁世一与丝丐丏丒丁, PGCompany.BattlePass.BPChallangesProgressForSeason 与丄丙丐业丗丗丑三, ref bool 东世丞七上丆丏丂业)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_13;
            var val_42;
            object val_43;
            System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeProgress> val_44;
            System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeProgress> val_45;
            var val_46;
            var val_47;
            var val_48;
            System.Func<PGCompany.BattlePass.BPChallangeProgress, System.Int32> val_50;
            bool val_51;
            System.Collections.Generic.List<T> val_52;
            int val_53;
            var val_54;
            var val_56;
            System.Func<PGCompany.BattlePass.BPChallangeProgress, PGCompany.BattlePass.BPChallangeProgress> val_58;
            System.Func<TSource, System.Boolean> val_59;
            var val_60;
            System.Collections.Generic.List<T> val_62;
            System.Func<PGCompany.BattlePass.BPChallangeProgress, PGCompany.BattlePass.BPChallangeProgress> val_63;
            val_42 = 1152921559939616816;
            BPChallangesProgressForSeason.丛与丒丞丁丛上丄丆 val_1 = null;
            val_43 = val_1;
            val_1 = new BPChallangesProgressForSeason.丛与丒丞丁丛上丄丆();
            if((与丄丙丐业丗丗丑三 == null) || (丁世一与丝丐丏丒丁 == null))
            {
                goto label_2;
            }
            
            if(丁世一与丝丐丏丒丁.SeasonId != 与丄丙丐业丗丗丑三.SeasonId)
            {
                    UnityEngine.Debug.LogErrorFormat(format:  "BPChallangesPro_gressForSeason Merge local.SeasonId != cloud.SeasonId", args:  System.Array.Empty<System.Object>());
            }
            
            val_44 = 丁世一与丝丐丏丒丁.BpChallengeProgresses;
            if(val_44 == null)
            {
                    System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeProgress> val_3 = null;
                val_44 = val_3;
                val_3 = new System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeProgress>();
            }
            
            val_45 = 与丄丙丐业丗丗丑三.BpChallengeProgresses;
            if(val_45 == null)
            {
                    System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeProgress> val_4 = null;
                val_45 = val_4;
                val_4 = new System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeProgress>();
            }
            
            .丝丙世万丒东下七丏 = val_45;
            val_46 = 1152921504616005632;
            System.Func<PGCompany.BattlePass.BPChallangeProgress, System.Boolean> val_5 = null;
            val_47 = 1152921542517330320;
            val_5 = new System.Func<PGCompany.BattlePass.BPChallangeProgress, System.Boolean>(object:  val_1, method:  System.Boolean BPChallangesProgressForSeason.丛与丒丞丁丛上丄丆::丕万丘丝丘万丈丌与(PGCompany.BattlePass.BPChallangeProgress 三丟东丕丄丄下下丑));
            val_48 = null;
            val_48 = null;
            val_50 = BPChallangesProgressForSeason.<>c.<>9__2_1;
            if(val_50 == null)
            {
                    System.Func<PGCompany.BattlePass.BPChallangeProgress, System.Int32> val_7 = null;
                val_50 = val_7;
                val_7 = new System.Func<PGCompany.BattlePass.BPChallangeProgress, System.Int32>(object:  BPChallangesProgressForSeason.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BPChallangesProgressForSeason.<>c::与专业东丙专业丛丗(PGCompany.BattlePass.BPChallangeProgress 三丟东丕丄丄下下丑));
                BPChallangesProgressForSeason.<>c.<>9__2_1 = val_50;
            }
            
            .三万丐丄丁三丟丕与 = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Select<PGCompany.BattlePass.BPChallangeProgress, System.Int32>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.BPChallangeProgress>(source:  val_3, predicate:  val_5), selector:  val_7));
            System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeProgress> val_10 = new System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeProgress>();
            List.Enumerator<T> val_11 = (BPChallangesProgressForSeason.丛与丒丞丁丛上丄丆)[1152921559939620848].三万丐丄丁三丟丕与.GetEnumerator();
            goto label_29;
            label_30:
            new BPChallangesProgressForSeason.丑专业且七丐上丏丂() = new System.Object();
            .丞丅上丏丂且下丅与 = val_13.丙东专丂世丈丏丁丂();
            System.Func<PGCompany.BattlePass.BPChallangeProgress, System.Boolean> val_16 = new System.Func<PGCompany.BattlePass.BPChallangeProgress, System.Boolean>(object:  new BPChallangesProgressForSeason.丑专业且七丐上丏丂(), method:  System.Boolean BPChallangesProgressForSeason.丑专业且七丐上丏丂::丞且丘丗与丄丙业一(PGCompany.BattlePass.BPChallangeProgress 三丟东丕丄丄下下丑));
            PGCompany.BattlePass.BPChallangeProgress val_17 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.BPChallangeProgress>(source:  val_3, predicate:  null);
            System.Func<PGCompany.BattlePass.BPChallangeProgress, System.Boolean> val_18 = new System.Func<PGCompany.BattlePass.BPChallangeProgress, System.Boolean>(object:  new BPChallangesProgressForSeason.丑专业且七丐上丏丂(), method:  System.Boolean BPChallangesProgressForSeason.丑专业且七丐上丏丂::丟丕三丌七丗丂丂丈(PGCompany.BattlePass.BPChallangeProgress 三丟东丕丄丄下下丑));
            PGCompany.BattlePass.BPChallangeProgress val_19 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.BPChallangeProgress>(source:  (BPChallangesProgressForSeason.丛与丒丞丁丛上丄丆)[1152921559939620848].丝丙世万丒东下七丏, predicate:  null);
            new PGCompany.BattlePass.BPChallangeProgress() = new System.Object();
            .Id = (BPChallangesProgressForSeason.丑专业且七丐上丏丂)[1152921559939706864].丞丅上丏丂且下丅与;
            int val_21 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            int val_22 = UnityEngine.Mathf.Max(a:  val_17.PointsContainer, b:  val_19.PointsContainer);
            val_13 = 0;
            .PointsContainer = val_13;
            mem[1152921559939731480] = 0;
            if(val_17.IsCompleted != false)
            {
                    val_51 = 1;
            }
            else
            {
                    val_51 = val_19.IsCompleted;
            }
            
            .IsCompleted = (val_51 == true) ? 1 : 0;
            val_47 = 1152921542517330320;
            val_10.Add(item:  new PGCompany.BattlePass.BPChallangeProgress());
            val_43 = val_43;
            val_46 = 1152921504616005632;
            if(val_17.PointsContainer != 1152921559939731472)
            {
                goto label_28;
            }
            
            var val_24 = (val_17.IsCompleted == true) ? 1 : 0;
            val_24 = val_24 ^ (((PGCompany.BattlePass.BPChallangeProgress)[1152921559939731440].IsCompleted == true) ? 1 : 0);
            if((val_24 & 1) == 0)
            {
                goto label_29;
            }
            
            label_28:
            东世丞七上丆丏丂业 = true;
            label_29:
            val_52 = val_44;
            if(((-501857328) & 1) != 0)
            {
                goto label_30;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_42 = 1152921505673457664;
            goto label_60;
            label_2:
            if(丁世一与丝丐丏丒丁 == null)
            {
                    东世丞七上丆丏丂业 = true;
            }
            
            UnityEngine.Debug.LogErrorFormat(format:  "BPChallangesProg_ressForSeason Merge local == null || cloud == null", args:  System.Array.Empty<System.Object>());
            System.Func<PGCompany.BattlePass.BPChallangeProgress, System.Boolean> val_27 = (丁世一与丝丐丏丒丁 != 0) ? 丁世一与丝丐丏丒丁 : 与丄丙丐业丗丗丑三;
            val_54 = val_27.丕东丞业丗三丅丗万();
            return (PGCompany.BattlePass.BPChallangesProgressForSeason)val_54;
            label_60:
            System.Func<PGCompany.BattlePass.BPChallangeProgress, System.Boolean> val_29 = val_27;
            val_29 = new System.Func<PGCompany.BattlePass.BPChallangeProgress, System.Boolean>(object:  val_1, method:  System.Boolean BPChallangesProgressForSeason.丛与丒丞丁丛上丄丆::上下万下丆一业上专(PGCompany.BattlePass.BPChallangeProgress 三丟东丕丄丄下下丑));
            val_56 = null;
            val_58 = BPChallangesProgressForSeason.<>c.<>9__2_3;
            if(val_58 == null)
            {
                    System.Func<PGCompany.BattlePass.BPChallangeProgress, PGCompany.BattlePass.BPChallangeProgress> val_31 = null;
                val_58 = val_31;
                val_31 = new System.Func<PGCompany.BattlePass.BPChallangeProgress, PGCompany.BattlePass.BPChallangeProgress>(object:  BPChallangesProgressForSeason.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.BattlePass.BPChallangeProgress BPChallangesProgressForSeason.<>c::丄丒丄万世与丛专丄(PGCompany.BattlePass.BPChallangeProgress 三丟东丕丄丄下下丑));
                BPChallangesProgressForSeason.<>c.<>9__2_3 = val_58;
            }
            
            val_10.AddRange(collection:  System.Linq.Enumerable.ToList<PGCompany.BattlePass.BPChallangeProgress>(source:  System.Linq.Enumerable.Select<PGCompany.BattlePass.BPChallangeProgress, PGCompany.BattlePass.BPChallangeProgress>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.BPChallangeProgress>(source:  val_3, predicate:  val_29), selector:  val_31)));
            System.Func<PGCompany.BattlePass.BPChallangeProgress, System.Boolean> val_34 = val_27;
            val_59 = val_34;
            val_34 = new System.Func<PGCompany.BattlePass.BPChallangeProgress, System.Boolean>(object:  val_1, method:  System.Boolean BPChallangesProgressForSeason.丛与丒丞丁丛上丄丆::且丟丞下一丅且丄不(PGCompany.BattlePass.BPChallangeProgress 三丟东丕丄丄下下丑));
            val_60 = null;
            val_60 = null;
            val_62 = val_10;
            val_63 = BPChallangesProgressForSeason.<>c.<>9__2_5;
            if(val_63 == null)
            {
                    System.Func<PGCompany.BattlePass.BPChallangeProgress, PGCompany.BattlePass.BPChallangeProgress> val_36 = null;
                val_63 = val_36;
                val_36 = new System.Func<PGCompany.BattlePass.BPChallangeProgress, PGCompany.BattlePass.BPChallangeProgress>(object:  BPChallangesProgressForSeason.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.BattlePass.BPChallangeProgress BPChallangesProgressForSeason.<>c::东丄丒丅丑丌丙业专(PGCompany.BattlePass.BPChallangeProgress 三丟东丕丄丄下下丑));
                BPChallangesProgressForSeason.<>c.<>9__2_5 = val_63;
                val_62 = val_10;
            }
            
            System.Collections.Generic.List<TSource> val_38 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.BPChallangeProgress>(source:  System.Linq.Enumerable.Select<PGCompany.BattlePass.BPChallangeProgress, PGCompany.BattlePass.BPChallangeProgress>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.BPChallangeProgress>(source:  (BPChallangesProgressForSeason.丛与丒丞丁丛上丄丆)[1152921559939620848].丝丙世万丒东下七丏, predicate:  val_59), selector:  val_36));
            val_10.AddRange(collection:  val_38);
            if(val_38.Count >= 1)
            {
                    东世丞七上丆丏丂业 = true;
            }
            
            PGCompany.BattlePass.BPChallangesProgressForSeason val_40 = null;
            val_54 = val_40;
            val_40 = new PGCompany.BattlePass.BPChallangesProgressForSeason();
            val_53 = mem[丁世一与丝丐丏丒丁 + 24];
            val_53 = 丁世一与丝丐丏丒丁 + 24;
            if(val_54 != null)
            {
                    .SeasonId = val_53;
            }
            else
            {
                    mem[24] = val_53;
            }
            
            .BpChallengeProgresses = val_62;
            return (PGCompany.BattlePass.BPChallangesProgressForSeason)val_54;
        }
        public override string ToString()
        {
            return System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0}_{1}", args:  System.Array.Empty<System.Object>());
        }
        internal PGCompany.BattlePass.BPChallangesProgressForSeason 丕东丞业丗三丅丗万()
        {
            var val_5;
            System.Func<PGCompany.BattlePass.BPChallangeProgress, PGCompany.BattlePass.BPChallangeProgress> val_7;
            .SeasonId = this.SeasonId;
            val_5 = null;
            val_5 = null;
            val_7 = BPChallangesProgressForSeason.<>c.<>9__4_0;
            if(val_7 == null)
            {
                    System.Func<PGCompany.BattlePass.BPChallangeProgress, PGCompany.BattlePass.BPChallangeProgress> val_2 = null;
                val_7 = val_2;
                val_2 = new System.Func<PGCompany.BattlePass.BPChallangeProgress, PGCompany.BattlePass.BPChallangeProgress>(object:  BPChallangesProgressForSeason.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.BattlePass.BPChallangeProgress BPChallangesProgressForSeason.<>c::世丅下丘丒七丞业丕(PGCompany.BattlePass.BPChallangeProgress 三丟东丕丄丄下下丑));
                BPChallangesProgressForSeason.<>c.<>9__4_0 = val_7;
            }
            
            .BpChallengeProgresses = System.Linq.Enumerable.ToList<PGCompany.BattlePass.BPChallangeProgress>(source:  System.Linq.Enumerable.Select<PGCompany.BattlePass.BPChallangeProgress, PGCompany.BattlePass.BPChallangeProgress>(source:  this.BpChallengeProgresses, selector:  val_2));
            return (PGCompany.BattlePass.BPChallangesProgressForSeason)new PGCompany.BattlePass.BPChallangesProgressForSeason();
        }
        public BPChallangesProgressForSeason()
        {
        
        }
    
    }

}
