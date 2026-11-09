using UnityEngine;

namespace PGCompany.WebSocket.Analytics
{
    internal sealed class ConnectionTroubleAnalyticsWatcher : Singleton<PGCompany.WebSocket.Analytics.ConnectionTroubleAnalyticsWatcher>
    {
        // Fields
        private const int 丑丁三丘丒丏一东丌 = 60;
        private readonly System.Collections.Generic.List<string> 七专不东丈丙下不丐;
        private readonly System.Collections.Generic.List<PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专> 丆丅丟丄丈丝一世世;
        private bool 三东丈东丟世专丞且;
        
        // Methods
        internal void 丝且丏丝丟世丟下万(string 丝丏业丅丈东业丝丒, int 丁丅下丒丆万三丞七, object 丆丄不一丗一丑丛丌)
        {
            string val_13;
            var val_14;
            var val_15;
            var val_17;
            if((this.七专不东丈丙下不丐.Contains(item:  丝丏业丅丈东业丝丒)) == false)
            {
                    return;
            }
            
            PGCompany.WebSocket.Analytics.丅丏丏下丈丟世专丂 val_2 = new PGCompany.WebSocket.Analytics.丅丏丏下丈丟世专丂();
            string val_3 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            if(val_2 != null)
            {
                    mem[1152921559495716256] = val_3;
                val_13 = UnityEngine.SystemInfo.deviceUniqueIdentifier;
            }
            else
            {
                    mem[16] = val_3;
                val_13 = UnityEngine.SystemInfo.deviceUniqueIdentifier;
            }
            
            mem[1152921559495716264] = val_13;
            val_14 = null;
            val_14 = null;
            mem[1152921559495716272] = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丑丑丛丄且丛丈下三);
            mem[1152921559495716280] = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.七丕丒丙三丗丐丌丟);
            .<丟万且丞丏丈丛下丙>k__BackingField = 丝丏业丅丈东业丝丒;
            .<丑下丙丛东丅下与丂>k__BackingField = 丁丅下丒丆万三丞七;
            val_15 = null;
            val_15 = null;
            mem[1152921559495716288] = System.TimeSpan.Zero;
            if(PixelTime.丝业丁丌丘东丏世与() != false)
            {
                    long val_9 = PixelTime.丝丗专上三不丄丑丑();
            }
            
            mem[1152921559495716296] = 专七专下且专三一且.上且一丈丐三丄一丆();
            var val_13 = ~PixelTime.丝业丁丌丘东丏世与();
            val_13 = val_13 & 1;
            mem[1152921559495716300] = val_13;
            val_17 = 0;
            .<三丄上丄专丝丟丄业>k__BackingField = ;
            this.丆丅丟丄丈丝一世世.Add(item:  val_2);
        }
        internal void 丈丒一上丁丙上丌三(BestHTTP.HTTPRequest 东丞丒丙世丏三下丟)
        {
            var val_19;
            var val_21;
            System.Func<BestHTTP.Forms.HTTPFieldData, System.String> val_23;
            System.Func<BestHTTP.Forms.HTTPFieldData, System.String> val_25;
            string val_26;
            var val_27;
            var val_28;
            val_19 = null;
            val_19 = null;
            if((ConnectionTroubleAnalyticsWatcher.<>c.<>9__5_0) == null)
            {
                goto label_3;
            }
            
            label_21:
            int val_1 = this.丆丅丟丄丈丝一世世.RemoveAll(match:  ConnectionTroubleAnalyticsWatcher.<>c.<>9__5_0);
            val_21 = null;
            val_21 = null;
            val_23 = ConnectionTroubleAnalyticsWatcher.<>c.<>9__5_1;
            if(val_23 == null)
            {
                    System.Func<BestHTTP.Forms.HTTPFieldData, System.String> val_3 = null;
                val_23 = val_3;
                val_3 = new System.Func<BestHTTP.Forms.HTTPFieldData, System.String>(object:  ConnectionTroubleAnalyticsWatcher.<>c.__il2cppRuntimeField_static_fields, method:  System.String ConnectionTroubleAnalyticsWatcher.<>c::丟丙世丅上且丟且东(BestHTTP.Forms.HTTPFieldData 下上丐丆丝丟丝丒不));
                val_21 = null;
                ConnectionTroubleAnalyticsWatcher.<>c.<>9__5_1 = val_23;
            }
            
            val_21 = null;
            val_25 = ConnectionTroubleAnalyticsWatcher.<>c.<>9__5_2;
            if(val_25 == null)
            {
                    System.Func<BestHTTP.Forms.HTTPFieldData, System.String> val_4 = null;
                val_25 = val_4;
                val_4 = new System.Func<BestHTTP.Forms.HTTPFieldData, System.String>(object:  ConnectionTroubleAnalyticsWatcher.<>c.__il2cppRuntimeField_static_fields, method:  System.String ConnectionTroubleAnalyticsWatcher.<>c::专丐丄上与丄一丅丒(BestHTTP.Forms.HTTPFieldData 丙业与丙丗丝不丈东));
                ConnectionTroubleAnalyticsWatcher.<>c.<>9__5_2 = val_25;
            }
            
            PGCompany.WebSocket.Analytics.三东专丂丁不七丛不 val_6 = new PGCompany.WebSocket.Analytics.三东专丂丁不七丛不();
            string val_7 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            if(val_6 == null)
            {
                goto label_16;
            }
            
            mem[1152921559495952160] = val_7;
            val_26 = UnityEngine.SystemInfo.deviceUniqueIdentifier;
            goto label_17;
            label_3:
            ConnectionTroubleAnalyticsWatcher.<>c.<>9__5_0 = new System.Predicate<PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专>(object:  ConnectionTroubleAnalyticsWatcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ConnectionTroubleAnalyticsWatcher.<>c::七丌丒万丂丞丐万丆(PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专 三丟东丕丄丄下下丑));
            if(this.丆丅丟丄丈丝一世世 != null)
            {
                goto label_21;
            }
            
            goto label_21;
            label_16:
            mem[16] = val_7;
            val_26 = UnityEngine.SystemInfo.deviceUniqueIdentifier;
            label_17:
            mem[1152921559495952168] = val_26;
            val_27 = null;
            val_27 = null;
            mem[1152921559495952176] = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丑丑丛丄且丛丈下三);
            mem[1152921559495952184] = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.七丕丒丙三丗丐丌丟);
            val_28 = null;
            val_28 = null;
            mem[1152921559495952192] = System.TimeSpan.Zero;
            if(PixelTime.丝业丁丌丘东丏世与() != false)
            {
                    long val_14 = PixelTime.丝丗专上三不丄丑丑();
            }
            
            mem[1152921559495952200] = 专七专下且专三一且.上且一丈丐三丄一丆();
            var val_19 = ~PixelTime.丝业丁丌丘东丏世与();
            val_19 = val_19 & 1;
            mem[1152921559495952204] = val_19;
            .<且丈丄与丐且一丞丅>k__BackingField = System.Linq.Enumerable.ToDictionary<BestHTTP.Forms.HTTPFieldData, System.String, System.String>(source:  东丞丒丙世丏三下丟.GetFormFields(), keySelector:  val_3, elementSelector:  val_4);
            .<丟丌下丕丁丑丝丟且>k__BackingField = 东丞丒丙世丏三下丟.Uri.OriginalString;
            this.丆丅丟丄丈丝一世世.Add(item:  val_6);
        }
        internal void 专丞不丏世丒丈不一(BestHTTP.HTTPRequest 东丞丒丙世丏三下丟, BestHTTP.HTTPResponse 丑与丂丌世丕丆一丗, PGCompany.丌丐丝三丗世丆世上 世世上丟丞丄丘业专)
        {
            var val_20;
            System.Func<PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专, System.Boolean> val_22;
            val_20 = null;
            val_20 = null;
            val_22 = ConnectionTroubleAnalyticsWatcher.<>c.<>9__6_0;
            if(val_22 == null)
            {
                    System.Func<PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专, System.Boolean> val_1 = null;
                val_22 = val_1;
                val_1 = new System.Func<PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专, System.Boolean>(object:  ConnectionTroubleAnalyticsWatcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ConnectionTroubleAnalyticsWatcher.<>c::丑丏东丙丌丕上七丑(PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专 三丟东丕丄丄下下丑));
                ConnectionTroubleAnalyticsWatcher.<>c.<>9__6_0 = val_22;
            }
            
            if((System.Linq.Enumerable.FirstOrDefault<PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专>(source:  this.丆丅丟丄丈丝一世世, predicate:  val_1)) == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            if((东丞丒丙世丏三下丟.State - 3) <= 4)
            {
                    var val_20 = 106042652 + ((val_4 - 3)) << 2;
                val_20 = val_20 + 106042652;
            }
            else
            {
                    mem2[0] = 1;
            }
        
        }
        internal void 丂丟专丛丈万七丒三(string 七丙不丅丛丘丗万与)
        {
            var val_14;
            System.Func<PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专, System.Boolean> val_16;
            var val_17;
            PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专 val_18;
            var val_19;
            string val_20;
            var val_21;
            var val_22;
            val_14 = null;
            val_14 = null;
            val_16 = ConnectionTroubleAnalyticsWatcher.<>c.<>9__7_0;
            if(val_16 == null)
            {
                    System.Func<PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专, System.Boolean> val_1 = null;
                val_16 = val_1;
                val_1 = new System.Func<PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专, System.Boolean>(object:  ConnectionTroubleAnalyticsWatcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ConnectionTroubleAnalyticsWatcher.<>c::丑丗七丆丆七丑一丘(PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专 三丟东丕丄丄下下丑));
                ConnectionTroubleAnalyticsWatcher.<>c.<>9__7_0 = val_16;
            }
            
            val_18 = 1152921505649602560;
            val_19 = null;
            if((System.Linq.Enumerable.FirstOrDefault<PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专>(source:  this.丆丅丟丄丈丝一世世, predicate:  val_1)) == null)
            {
                goto label_6;
            }
            
            if(null == val_19)
            {
                goto label_7;
            }
            
            val_19 = null;
            label_6:
            PGCompany.WebSocket.Analytics.与丈三丘丝丙丞丐丝 val_4 = null;
            val_18 = val_4;
            val_4 = new PGCompany.WebSocket.Analytics.与丈三丘丝丙丞丐丝();
            string val_5 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            if(val_18 != null)
            {
                    mem[1152921559496398720] = val_5;
                val_20 = UnityEngine.SystemInfo.deviceUniqueIdentifier;
            }
            else
            {
                    mem[16] = val_5;
                val_20 = UnityEngine.SystemInfo.deviceUniqueIdentifier;
            }
            
            mem[1152921559496398728] = val_20;
            val_17 = 1152921505171275776;
            val_21 = null;
            val_21 = null;
            mem[1152921559496398736] = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丑丑丛丄且丛丈下三);
            mem[1152921559496398744] = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.七丕丒丙三丗丐丌丟);
            val_22 = null;
            val_22 = null;
            mem[1152921559496398752] = System.TimeSpan.Zero;
            if(PixelTime.丝业丁丌丘东丏世与() != false)
            {
                    long val_11 = PixelTime.丝丗专上三不丄丑丑();
            }
            
            mem[1152921559496398760] = 专七专下且专三一且.上且一丈丐三丄一丆();
            var val_14 = ~PixelTime.丝业丁丌丘东丏世与();
            val_14 = val_14 & 1;
            .<丟丌下丕丁丑丝丟且>k__BackingField = 七丙不丅丛丘丗万与;
            mem[1152921559496398764] = val_14;
            .<丌丅丝丝丁丑东丁丗>k__BackingField = 1;
            this.丆丅丟丄丈丝一世世.Add(item:  val_4);
            goto label_27;
            label_7:
            mem2[0] = null;
            label_27:
            this.三东丈东丟世专丞且 = true;
        }
        protected override void Awake()
        {
            var val_6;
            this.Awake();
            val_6 = null;
            val_6 = null;
            this.七专不东丈丙下不丐.Add(item:  Rilisoft.WebSocket.业丛世业世不丄丐三.一丈丒一不丗上东专);
            this.七专不东丈丙下不丐.Add(item:  Rilisoft.WebSocket.业丛世业世不丄丐三.业丁丂七上丗丟丙丟);
            this.七专不东丈丙下不丐.Add(item:  Rilisoft.WebSocket.业丛世业世不丄丐三.专丅专丅且万业东下);
            this.七专不东丈丙下不丐.Add(item:  Rilisoft.WebSocket.业丛世业世不丄丐三.与上且丕丂一丐专丕);
            this.七专不东丈丙下不丐.Add(item:  Rilisoft.WebSocket.业丛世业世不丄丐三.丙上丟丏且丐丌不丒);
            this.七专不东丈丙下不丐.Add(item:  Rilisoft.WebSocket.业丛世业世不丄丐三.且丌三业丌世丑且且);
            this.七专不东丈丙下不丐.Add(item:  Rilisoft.WebSocket.业丛世业世不丄丐三.丐世丕且丕丐丗丆丄);
            this.七专不东丈丙下不丐.Add(item:  Rilisoft.WebSocket.业丛世业世不丄丐三.丟三丟丆一东上丟丘);
            this.七专不东丈丙下不丐.Add(item:  Rilisoft.WebSocket.业丛世业世不丄丐三.业丙丞与丞丝丂丑丝);
            this.七专不东丈丙下不丐.Add(item:  Rilisoft.WebSocket.业丛世业世不丄丐三.丙丈专东上一丒一且);
            this.七专不东丈丙下不丐.Add(item:  Rilisoft.WebSocket.业丛世业世不丄丐三.丈丑业万不一丒丘专);
            this.七专不东丈丙下不丐.Add(item:  Rilisoft.WebSocket.业丛世业世不丄丐三.且业丑丌三丂丈不不);
            List.Enumerator<T> val_1 = this.七专不东丈丙下不丐.GetEnumerator();
            label_19:
            if(((-944852824) & 1) == 0)
            {
                goto label_16;
            }
            
            new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上() = new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.WebSocket.Analytics.ConnectionTroubleAnalyticsWatcher::丑丝丗丏丑东三三丘(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不));
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  0.丐丏七丌丕丗业且上(), 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上());
            goto label_19;
            label_16:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            业丞丝东丅丞丐丌专.上三专七丗丗世丟丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.WebSocket.Analytics.ConnectionTroubleAnalyticsWatcher::丛丕丁下丒丞丗上丌()));
            业丞丝东丅丞丐丌专.丘丒丟丙业丗上与专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.WebSocket.Analytics.ConnectionTroubleAnalyticsWatcher::丆三丁丂三丙七丐一()));
        }
        private void OnDestroy()
        {
            业丞丝东丅丞丐丌专.丌三三丑丗丟丒且丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.WebSocket.Analytics.ConnectionTroubleAnalyticsWatcher::丛丕丁下丒丞丗上丌()));
            业丞丝东丅丞丐丌专.丛丂不丗丙丘丝丘丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.WebSocket.Analytics.ConnectionTroubleAnalyticsWatcher::丆三丁丂三丙七丐一()));
        }
        private void Update()
        {
            this.且七丅丄丞一丆丈丟();
            this.丄丘不专丗丛丐业与();
            this.丒丂丐三且丌丕丒业();
            this.丁一丞丑一丛丁一世();
        }
        private void 且七丅丄丞一丆丈丟()
        {
            System.Collections.Generic.List<PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专> val_5 = this.丆丅丟丄丈丝一世世;
            List.Enumerator<T> val_1 = val_5.GetEnumerator();
            goto label_2;
            label_6:
            val_5 = 0.丐丏七丌丕丗业且上();
            System.TimeSpan val_4 = System.TimeSpan.FromSeconds(value:  (double)UnityEngine.Time.unscaledDeltaTime);
            mem2[0] = 0;
            label_2:
            if(((-944418504) & 1) != 0)
            {
                goto label_6;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 丄丘不专丗丛丐业与()
        {
            var val_4;
            var val_10;
            System.Collections.Generic.List<PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专> val_11;
            val_10 = this;
            System.Collections.Generic.List<PGCompany.WebSocket.Analytics.丅丏丏下丈丟世专丂> val_1 = new System.Collections.Generic.List<PGCompany.WebSocket.Analytics.丅丏丏下丈丟世专丂>();
            val_11 = this.丆丅丟丄丈丝一世世;
            List.Enumerator<T> val_2 = val_11.GetEnumerator();
            label_7:
            if(((-944271712) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            if(((val_5 == null) || (null != null)) || (null.TotalSeconds < 60))
            {
                goto label_7;
            }
            
            val_1.Add(item:  val_5);
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            List.Enumerator<T> val_7 = val_1.GetEnumerator();
            label_18:
            if(((-944271744) & 1) == 0)
            {
                goto label_15;
            }
            
            string val_8 = 0.丐丏七丌丕丗业且上();
            bool val_9 = this.丆丅丟丄丈丝一世世.Remove(item:  val_8);
            val_8.丅丛丛丒丘三七万丏();
            PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender.七丏丙丝丏万与丅上(丙丁丌丛业不丄丝丈:  val_8, 丞业丙三且丑丂七上:  true);
            PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender.丂东丙世一丕丗东下(丙丁丌丛业不丄丝丈:  val_8, 丞业丙三且丑丂七上:  true);
            goto label_18;
            label_15:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 丒丂丐三且丌丕丒业()
        {
            var val_8;
            System.Func<PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专, System.Boolean> val_10;
            if(this.三东丈东丟世专丞且 == false)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            val_10 = ConnectionTroubleAnalyticsWatcher.<>c.<>9__13_0;
            if(val_10 == null)
            {
                    System.Func<PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专, System.Boolean> val_1 = null;
                val_10 = val_1;
                val_1 = new System.Func<PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专, System.Boolean>(object:  ConnectionTroubleAnalyticsWatcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ConnectionTroubleAnalyticsWatcher.<>c::且丑丈且丂专东七丘(PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专 三丟东丕丄丄下下丑));
                ConnectionTroubleAnalyticsWatcher.<>c.<>9__13_0 = val_10;
            }
            
            PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专 val_2 = System.Linq.Enumerable.FirstOrDefault<PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专>(source:  this.丆丅丟丄丈丝一世世, predicate:  val_1);
            if(val_2 == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            val_10 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance;
            if(val_10.丕上业丐七丂且不丁() != true)
            {
                    if((val_2.<下丂丌丒丌世丕业不>k__BackingField.TotalSeconds) < 0)
            {
                    return;
            }
            
                val_2.丅丛丛丒丘三七万丏();
                PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender.七丏丙丝丏万与丅上(丙丁丌丛业不丄丝丈:  val_2);
                PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender.丂东丙世一丕丗东下(丙丁丌丛业不丄丝丈:  val_2);
            }
            
            val_10 = this.丆丅丟丄丈丝一世世;
            bool val_7 = val_10.Remove(item:  val_2);
            this.三东丈东丟世专丞且 = false;
        }
        private void 丁一丞丑一丛丁一世()
        {
            var val_4;
            var val_9;
            System.Collections.Generic.List<PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专> val_10;
            val_9 = this;
            System.Collections.Generic.List<PGCompany.WebSocket.Analytics.三东专丂丁不七丛不> val_1 = new System.Collections.Generic.List<PGCompany.WebSocket.Analytics.三东专丂丁不七丛不>();
            val_10 = this.丆丅丟丄丈丝一世世;
            List.Enumerator<T> val_2 = val_10.GetEnumerator();
            label_7:
            if(((-943958624) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            if(((val_5 == null) || (null != null)) || (null == 0))
            {
                goto label_7;
            }
            
            val_1.Add(item:  val_5);
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            List.Enumerator<T> val_6 = val_1.GetEnumerator();
            label_17:
            if(((-943958648) & 1) == 0)
            {
                goto label_14;
            }
            
            string val_7 = 0.丐丏七丌丕丗业且上();
            bool val_8 = this.丆丅丟丄丈丝一世世.Remove(item:  val_7);
            val_7.丅丛丛丒丘三七万丏();
            PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender.七丏丙丝丏万与丅上(丙丁丌丛业不丄丝丈:  val_7);
            PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender.丂东丙世一丕丗东下(丙丁丌丛业不丄丝丈:  val_7);
            goto label_17;
            label_14:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 丛丕丁下丒丞丗上丌()
        {
            this.丆丅丟丄丈丝一世世.Clear();
        }
        private void 丆三丁丂三丙七丐一()
        {
            this.丆丅丟丄丈丝一世世.Clear();
        }
        private void 丑丝丗丏丑东三三丘(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            int val_8 = 0;
            bool val_3 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "req_id", 丙业与丙丗丝不丈东: out  (ConnectionTroubleAnalyticsWatcher.三丅丞丒丕丅专一丅)[1152921559497934448].丁丅下丒丆万三丞七);
            PGCompany.WebSocket.Analytics.丅丏丏下丈丟世专丂 val_6 = System.Linq.Enumerable.FirstOrDefault<PGCompany.WebSocket.Analytics.丅丏丏下丈丟世专丂>(source:  System.Linq.Enumerable.OfType<PGCompany.WebSocket.Analytics.丅丏丏下丈丟世专丂>(source:  this.丆丅丟丄丈丝一世世), predicate:  new System.Func<PGCompany.WebSocket.Analytics.丅丏丏下丈丟世专丂, System.Boolean>(object:  new ConnectionTroubleAnalyticsWatcher.三丅丞丒丕丅专一丅(), method:  System.Boolean ConnectionTroubleAnalyticsWatcher.三丅丞丒丕丅专一丅::丑丟丌丞丂世一下与(PGCompany.WebSocket.Analytics.丅丏丏下丈丟世专丂 三丟东丕丄丄下下丑)));
            if(val_6 == null)
            {
                    return;
            }
            
            bool val_7 = this.丆丅丟丄丈丝一世世.Remove(item:  val_6);
            bool val_9 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "err_code", 丙业与丙丗丝不丈东: out  val_8);
            if((-1406) <= 13)
            {
                    if(4 != 0)
            {
                    return;
            }
            
            }
            
            if(val_8 == 0)
            {
                    return;
            }
            
            val_6.<三丕丂东丙专上丕丆>k__BackingField = 0;
            val_6.<丆丌丞丒丘丞上且丄>k__BackingField = 丑与丂丌世丕丆一丗;
            val_6.丅丛丛丒丘三七万丏();
            PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender.七丏丙丝丏万与丅上(丙丁丌丛业不丄丝丈:  val_6, 丞业丙三且丑丂七上:  false);
            PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender.丂东丙世一丕丗东下(丙丁丌丛业不丄丝丈:  val_6, 丞业丙三且丑丂七上:  false);
        }
        public ConnectionTroubleAnalyticsWatcher()
        {
            this.七专不东丈丙下不丐 = new System.Collections.Generic.List<System.String>();
            this.丆丅丟丄丈丝一世世 = new System.Collections.Generic.List<PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专>();
        }
    
    }

}
