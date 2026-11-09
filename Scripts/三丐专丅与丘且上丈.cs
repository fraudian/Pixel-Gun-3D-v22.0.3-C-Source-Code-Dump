using UnityEngine;
private sealed class 丟丂丗丁丝丞一且业.三丐专丅与丘且上丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public bool 且丏下一下上丟与丐;
    public Rilisoft.丟丂丗丁丝丞一且业 丝且与丝丒丟万丁专;
    public bool 丟东丈丗丏丛世万一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丟丂丗丁丝丞一且业.三丐专丅与丘且上丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_189;
        var val_190;
        var val_191;
        System.Collections.Generic.List<System.Object> val_192;
        var val_193;
        System.Func<System.String, System.Boolean> val_195;
        var val_196;
        System.Func<System.Int32, System.String> val_198;
        var val_199;
        System.Func<System.String, System.Boolean> val_201;
        var val_202;
        System.Func<丟丄七万东与上丒丟, System.Boolean> val_204;
        var val_205;
        System.Func<丟丄七万东与上丒丟, System.String> val_207;
        var val_208;
        System.Func<丟丄七万东与上丒丟, System.Boolean> val_210;
        var val_211;
        System.Func<丟丄七万东与上丒丟, System.String> val_213;
        var val_214;
        var val_215;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, Progress.不专丂万丐丄七上丗>, System.Boolean> val_217;
        var val_218;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, Progress.不专丂万丐丄七上丗>, System.String> val_220;
        var val_221;
        System.Func<System.Collections.Generic.List<System.Collections.Generic.List<System.String>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.List<System.String>>> val_223;
        var val_224;
        System.Func<System.Collections.Generic.List<System.String>, System.Collections.Generic.IEnumerable<System.String>> val_226;
        var val_227;
        var val_228;
        System.Func<丟丄七万东与上丒丟, System.Boolean> val_230;
        var val_231;
        System.Func<丟丄七万东与上丒丟, System.String> val_233;
        var val_234;
        System.Func<丟丄七万东与上丒丟, System.Boolean> val_236;
        var val_237;
        System.Func<丟丄七万东与上丒丟, System.String> val_239;
        var val_240;
        var val_241;
        var val_242;
        object val_244;
        var val_245;
        PGCompany.丒且丌丑丆上一丘丆<System.String> val_246;
        var val_247;
        var val_248;
        var val_249;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.且丏下一下上丟与丐 == false)
        {
                return false;
        }
        
        if(this.丝且与丝丒丟万丁专.不丏丟丐丙丏丁下丕() == null)
        {
            goto label_4;
        }
        
        val_189 = this.丝且与丝丒丟万丁专.不丏丟丐丙丏丁下丕();
        if(val_189 == null)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "PurchasesCloudApplyer currentPullResult == null", args:  System.Array.Empty<System.Object>());
        }
        
        val_190 = null;
        val_190 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_191 = null;
            val_191 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.业一丞七万丁丏丑丅() != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "PurchasesCloudApplyer: WeaponManager.sharedManager.ResetLockSet point 1", args:  System.Array.Empty<System.Object>());
        }
        
        }
        
        if(val_189 == null)
        {
                val_189 = System.String.alignConst;
        }
        
        System.Collections.Generic.List<System.Object> val_7 = null;
        val_192 = val_7;
        val_7 = new System.Collections.Generic.List<System.Object>();
        if((System.String.op_Inequality(a:  val_189, b:  System.String.alignConst)) != false)
        {
                object val_9 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_189);
            val_192 = null;
            val_192 = new System.Collections.Generic.List<System.Object>();
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_11 = System.Linq.Enumerable.OfType<System.String>(source:  null);
        if(val_11 == null)
        {
            goto label_26;
        }
        
        System.Collections.Generic.List<TSource> val_12 = System.Linq.Enumerable.ToList<System.String>(source:  val_11);
        goto label_27;
        label_4:
        label_693:
        UnityEngine.Debug.LogErrorFormat(format:  "PurchasesCloudApplyer.Apply: SlotSynchronizer == null", args:  System.Array.Empty<System.Object>());
        return false;
        label_26:
        System.Collections.Generic.List<System.String> val_14 = new System.Collections.Generic.List<System.String>();
        label_27:
        val_193 = null;
        val_193 = null;
        val_195 = 丟丂丗丁丝丞一且业.<>c.<>9__2_0;
        if(val_195 == null)
        {
                val_195 = null;
            val_195 = new System.Func<System.String, System.Boolean>(object:  丟丂丗丁丝丞一且业.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丟丂丗丁丝丞一且业.<>c::不丌丏一丙丞丐丏与(string 三丟东丕丄丄下下丑));
            丟丂丗丁丝丞一且业.<>c.<>9__2_0 = val_195;
        }
        
        val_196 = null;
        val_196 = null;
        val_198 = 丟丂丗丁丝丞一且业.<>c.<>9__2_1;
        if(val_198 == null)
        {
                val_198 = null;
            val_198 = new System.Func<System.Int32, System.String>(object:  丟丂丗丁丝丞一且业.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丟丂丗丁丝丞一且业.<>c::丆业万世丄不七业丙(int 三丟东丕丄丄下下丑));
            丟丂丗丁丝丞一且业.<>c.<>9__2_1 = val_198;
        }
        
        val_199 = null;
        val_199 = null;
        val_201 = 丟丂丗丁丝丞一且业.<>c.<>9__2_2;
        if(val_201 == null)
        {
                val_201 = null;
            val_201 = new System.Func<System.String, System.Boolean>(object:  丟丂丗丁丝丞一且业.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丟丂丗丁丝丞一且业.<>c::丑丈丛万不丌丗专下(string 三丟东丕丄丄下下丑));
            丟丂丗丁丝丞一且业.<>c.<>9__2_2 = val_201;
        }
        
        val_202 = null;
        val_202 = null;
        val_204 = 丟丂丗丁丝丞一且业.<>c.<>9__2_3;
        if(val_204 == null)
        {
                val_204 = null;
            val_204 = new System.Func<丟丄七万东与上丒丟, System.Boolean>(object:  丟丂丗丁丝丞一且业.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丟丂丗丁丝丞一且业.<>c::七丛丟丞东丒不丛丄(丟丄七万东与上丒丟 三丟东丕丄丄下下丑));
            丟丂丗丁丝丞一且业.<>c.<>9__2_3 = val_204;
        }
        
        val_205 = null;
        val_205 = null;
        val_207 = 丟丂丗丁丝丞一且业.<>c.<>9__2_4;
        if(val_207 == null)
        {
                val_207 = null;
            val_207 = new System.Func<丟丄七万东与上丒丟, System.String>(object:  丟丂丗丁丝丞一且业.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丟丂丗丁丝丞一且业.<>c::丐一万丑七东与三三(丟丄七万东与上丒丟 三丟东丕丄丄下下丑));
            丟丂丗丁丝丞一且业.<>c.<>9__2_4 = val_207;
        }
        
        val_208 = null;
        val_208 = null;
        val_210 = 丟丂丗丁丝丞一且业.<>c.<>9__2_5;
        if(val_210 == null)
        {
                val_210 = null;
            val_210 = new System.Func<丟丄七万东与上丒丟, System.Boolean>(object:  丟丂丗丁丝丞一且业.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丟丂丗丁丝丞一且业.<>c::业丝三丄丙丗专丞丂(丟丄七万东与上丒丟 三丟东丕丄丄下下丑));
            丟丂丗丁丝丞一且业.<>c.<>9__2_5 = val_210;
        }
        
        val_211 = null;
        val_211 = null;
        val_213 = 丟丂丗丁丝丞一且业.<>c.<>9__2_6;
        if(val_213 == null)
        {
                val_213 = null;
            val_213 = new System.Func<丟丄七万东与上丒丟, System.String>(object:  丟丂丗丁丝丞一且业.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丟丂丗丁丝丞一且业.<>c::丐三丁丅下七丟万世(丟丄七万东与上丒丟 三丟东丕丄丄下下丑));
            丟丂丗丁丝丞一且业.<>c.<>9__2_6 = val_213;
        }
        
        val_214 = null;
        val_214 = null;
        val_215 = null;
        val_215 = null;
        val_217 = 丟丂丗丁丝丞一且业.<>c.<>9__2_7;
        if(val_217 == null)
        {
                val_217 = null;
            val_217 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, Progress.不专丂万丐丄七上丗>, System.Boolean>(object:  丟丂丗丁丝丞一且业.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丟丂丗丁丝丞一且业.<>c::丝丑丌丒丙丘上丁世(System.Collections.Generic.KeyValuePair<string, Progress.不专丂万丐丄七上丗> 丈丏万丄丒业丅丒一));
            丟丂丗丁丝丞一且业.<>c.<>9__2_7 = val_217;
        }
        
        val_218 = null;
        val_218 = null;
        val_220 = 丟丂丗丁丝丞一且业.<>c.<>9__2_8;
        if(val_220 == null)
        {
                val_220 = null;
            val_220 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, Progress.不专丂万丐丄七上丗>, System.String>(object:  丟丂丗丁丝丞一且业.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丟丂丗丁丝丞一且业.<>c::丘丌三一不与东丙丌(System.Collections.Generic.KeyValuePair<string, Progress.不专丂万丐丄七上丗> 丈丏万丄丒业丅丒一));
            丟丂丗丁丝丞一且业.<>c.<>9__2_8 = val_220;
        }
        
        val_221 = null;
        val_221 = null;
        val_223 = 丟丂丗丁丝丞一且业.<>c.<>9__2_9;
        if(val_223 == null)
        {
                val_223 = null;
            val_223 = new System.Func<System.Collections.Generic.List<System.Collections.Generic.List<System.String>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.List<System.String>>>(object:  丟丂丗丁丝丞一且业.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<System.Collections.Generic.List<System.String>> 丟丂丗丁丝丞一且业.<>c::丝丁丂专下丗不丏下(System.Collections.Generic.List<System.Collections.Generic.List<string>> 三丟东丕丄丄下下丑));
            丟丂丗丁丝丞一且业.<>c.<>9__2_9 = val_223;
        }
        
        val_224 = null;
        val_224 = null;
        val_226 = 丟丂丗丁丝丞一且业.<>c.<>9__2_10;
        if(val_226 == null)
        {
                val_226 = null;
            val_226 = new System.Func<System.Collections.Generic.List<System.String>, System.Collections.Generic.IEnumerable<System.String>>(object:  丟丂丗丁丝丞一且业.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<System.String> 丟丂丗丁丝丞一且业.<>c::七丗与丐不三东且丛(System.Collections.Generic.List<string> 三丟东丕丄丄下下丑));
            丟丂丗丁丝丞一且业.<>c.<>9__2_10 = val_226;
        }
        
        val_227 = null;
        val_227 = null;
        System.Collections.Generic.List<TSource> val_55 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Except<System.String>(first:  System.Linq.Enumerable.Except<System.String>(first:  System.Linq.Enumerable.Intersect<System.String>(first:  val_14, second:  System.Linq.Enumerable.SelectMany<System.Collections.Generic.List<System.String>, System.String>(source:  System.Linq.Enumerable.SelectMany<System.Collections.Generic.List<System.Collections.Generic.List<System.String>>, System.Collections.Generic.List<System.String>>(source:  七丌丞万七万丁丐丙.且不业七三丏与丐丙().Values, selector:  null), selector:  null)), second:  Progress.七七世万专丕丁上业.东丛丂丌业与丝不丙().万丗三与三丁丘且丛()), second:  Progress.上与丙丁丟丌丏丑丆.丑丗七下三丙丒丁丑));
        System.Collections.Generic.List<TSource> val_59 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Except<System.String>(first:  System.Linq.Enumerable.Intersect<System.String>(first:  val_14, second:  SkinsController.丂丈与丙丏丁丘三下()), second:  System.Linq.Enumerable.Where<System.String>(source:  SkinsController.丂丈与丙丏丁丘三下(), predicate:  null)));
        System.Collections.Generic.List<TSource> val_63 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Except<System.String>(first:  System.Linq.Enumerable.Intersect<System.String>(first:  val_14, second:  Rilisoft.上丑业三丆丆丅丕三.丅下七丘世丟丑丆与()), second:  System.Linq.Enumerable.Select<System.Int32, System.String>(source:  Progress.七七世万专丕丁上业.专不丛丛丕一丌丂丕().与丆丄丈丅丟下丙丞(), selector:  null)));
        System.Collections.Generic.List<TSource> val_68 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Except<System.String>(first:  System.Linq.Enumerable.Intersect<System.String>(first:  val_14, second:  丁下万丟且丟丛下业.一三专丞丒丅上业上().Keys), second:  System.Linq.Enumerable.Where<System.String>(source:  丁下万丟且丟丛下业.一三专丞丒丅上业上().Keys, predicate:  null)));
        val_228 = null;
        val_228 = null;
        val_230 = 丟丂丗丁丝丞一且业.<>c.<>9__2_11;
        if(val_230 == null)
        {
                val_230 = null;
            val_230 = new System.Func<丟丄七万东与上丒丟, System.Boolean>(object:  丟丂丗丁丝丞一且业.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丟丂丗丁丝丞一且业.<>c::丑丛丆丂丏丘专丝丌(丟丄七万东与上丒丟 三丟东丕丄丄下下丑));
            丟丂丗丁丝丞一且业.<>c.<>9__2_11 = val_230;
        }
        
        val_231 = null;
        val_231 = null;
        val_233 = 丟丂丗丁丝丞一且业.<>c.<>9__2_12;
        if(val_233 == null)
        {
                val_233 = null;
            val_233 = new System.Func<丟丄七万东与上丒丟, System.String>(object:  丟丂丗丁丝丞一且业.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丟丂丗丁丝丞一且业.<>c::丅丐上丅且丅丛七业(丟丄七万东与上丒丟 三丟东丕丄丄下下丑));
            丟丂丗丁丝丞一且业.<>c.<>9__2_12 = val_233;
        }
        
        System.Collections.Generic.List<TSource> val_77 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Except<System.String>(first:  System.Linq.Enumerable.Intersect<System.String>(first:  val_14, second:  System.Linq.Enumerable.Select<丟丄七万东与上丒丟, System.String>(source:  System.Linq.Enumerable.Where<丟丄七万东与上丒丟>(source:  丛且丗丌丏下七下丈.一三专丞丒丅上业上().Values, predicate:  null), selector:  null)), second:  System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<丟丄七万东与上丒丟, System.String>(source:  System.Linq.Enumerable.Where<丟丄七万东与上丒丟>(source:  丛且丗丌丏下七下丈.一三专丞丒丅上业上().Values, predicate:  null), selector:  null))));
        val_234 = null;
        val_234 = null;
        val_236 = 丟丂丗丁丝丞一且业.<>c.<>9__2_13;
        if(val_236 == null)
        {
                val_236 = null;
            val_236 = new System.Func<丟丄七万东与上丒丟, System.Boolean>(object:  丟丂丗丁丝丞一且业.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丟丂丗丁丝丞一且业.<>c::丄三丘下丐丈丅丐且(丟丄七万东与上丒丟 三丟东丕丄丄下下丑));
            丟丂丗丁丝丞一且业.<>c.<>9__2_13 = val_236;
        }
        
        val_237 = null;
        val_237 = null;
        val_239 = 丟丂丗丁丝丞一且业.<>c.<>9__2_14;
        if(val_239 == null)
        {
                val_239 = null;
            val_239 = new System.Func<丟丄七万东与上丒丟, System.String>(object:  丟丂丗丁丝丞一且业.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丟丂丗丁丝丞一且业.<>c::丙与七且丅一东三专(丟丄七万东与上丒丟 三丟东丕丄丄下下丑));
            丟丂丗丁丝丞一且业.<>c.<>9__2_14 = val_239;
        }
        
        System.Collections.Generic.List<TSource> val_86 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Except<System.String>(first:  System.Linq.Enumerable.Intersect<System.String>(first:  val_14, second:  System.Linq.Enumerable.Select<丟丄七万东与上丒丟, System.String>(source:  System.Linq.Enumerable.Where<丟丄七万东与上丒丟>(source:  丛且丗丌丏下七下丈.一三专丞丒丅上业上().Values, predicate:  null), selector:  null)), second:  System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<丟丄七万东与上丒丟, System.String>(source:  System.Linq.Enumerable.Where<丟丄七万东与上丒丟>(source:  丛且丗丌丏下七下丈.一三专丞丒丅上业上().Values, predicate:  null), selector:  null))));
        val_240 = null;
        val_240 = null;
        System.Collections.Generic.List<TSource> val_90 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Except<System.String>(first:  System.Linq.Enumerable.Intersect<System.String>(first:  val_14, second:  Progress.东丐世上丛丌丛丛丝.丒七七东三丗丂丅业.Keys), second:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, Progress.不专丂万丐丄七上丗>, System.String>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, Progress.不专丂万丐丄七上丗>>(source:  Progress.东丐世上丛丌丛丛丝.丒七七东三丗丂丅业, predicate:  null), selector:  null)));
        val_241 = null;
        val_241 = null;
        if(Rilisoft.丐丌丝七下丈丒丅丗.业七丈万丏丑丅丟且 != null)
        {
                val_242 = 0;
        }
        else
        {
                bool val_189 = this.丟东丈丗丏丛世万一;
            val_189 = val_189 ^ 1;
            val_242 = val_189 & 255;
        }
        
        val_242 = val_242 & this.且丏下一下上丟与丐;
        if((val_242 == false) || (AuthSceneController.丑七不且上丗丁一世() != 0))
        {
            goto label_469;
        }
        
        UnityEngine.Debug.LogFormat(format:  "start migr purchases to slots", args:  System.Array.Empty<System.Object>());
        int val_190 = 0;
        if(val_55 != null)
        {
            goto label_192;
        }
        
        label_193:
        label_192:
        if(val_190 >= val_55.Count)
        {
            goto label_157;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_55.Item[0])) == false)
        {
            goto label_161;
        }
        
        UnityEngine.Debug.LogErrorFormat(format:  "newWear[ i ].IsNullOrEmpty", args:  System.Array.Empty<System.Object>());
        goto label_218;
        label_161:
        if((丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_55.Item[0])) == 1)
        {
            goto label_168;
        }
        
        if((七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  val_55.Item[0])) != 七丌丞万七万丁丐丙.丑丒丆与丘下丛上业)
        {
            goto label_172;
        }
        
        object[] val_102 = new object[1];
        val_102[0] = val_55.Item[0];
        UnityEngine.Debug.LogErrorFormat(format:  "index == NOT_VALID_ID {0}", args:  val_102);
        goto label_218;
        label_168:
        object[] val_104 = new object[1];
        val_104[0] = val_55.Item[0];
        UnityEngine.Debug.LogErrorFormat(format:  "(int)category == -1 {0}", args:  val_104);
        goto label_218;
        label_172:
        label_218:
        val_190 = val_190 + 1;
        if(val_55 != null)
        {
            goto label_192;
        }
        
        goto label_193;
        label_157:
        if(val_55.Count >= 1)
        {
                Progress.七七世万专丕丁上业.东丛丂丌业与丝不丙().丂且不业丂专丛丆东();
        }
        
        int val_191 = 0;
        if(val_59 != 0)
        {
            goto label_256;
        }
        
        label_257:
        label_256:
        if(val_191 >= val_59.Count)
        {
            goto label_225;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_59.Item[0])) == false)
        {
            goto label_229;
        }
        
        UnityEngine.Debug.LogErrorFormat(format:  "newSkins[ i ].IsNullOrEmpty", args:  System.Array.Empty<System.Object>());
        goto label_274;
        label_229:
        val_245 = null;
        val_245 = null;
        val_246 = SkinsController.丈丁业下丕上丐与丈;
        if(val_246 == null)
        {
            goto label_240;
        }
        
        val_246 = SkinsController.丈丁业下丕上丐与丈;
        if((val_246.ContainsKey(下上丐丆丝丟丝丒不:  val_59.Item[0])) == false)
        {
            goto label_240;
        }
        
        val_247 = null;
        val_247 = null;
        Progress.七七世万专丕丁上业.万丆业丁下丗丁七万().丒三丐丄东丟丁丅丏(下下丏一丙不丘丌丞:  SkinsController.丈丁业下丕上丐与丈.Item[val_59.Item[0]]);
        goto label_274;
        label_240:
        object[] val_122 = new object[1];
        val_122[0] = val_59.Item[0];
        UnityEngine.Debug.LogErrorFormat(format:  "SkinsController.skinIndexes == null || ! SkinsController.skinIndexes.ContainsKey(newSkins[i]) {0}", args:  val_122);
        label_274:
        val_191 = val_191 + 1;
        if(val_59 != 0)
        {
            goto label_256;
        }
        
        goto label_257;
        label_225:
        if(val_59.Count >= 1)
        {
                Progress.丑丑丕丘一三上丕丙 val_127 = Progress.七七世万专丕丁上业.万丆业丁下丗丁七万();
        }
        
        int val_192 = 0;
        if(val_63 != 0)
        {
            goto label_296;
        }
        
        label_297:
        label_296:
        if(val_192 >= val_63.Count)
        {
            goto label_282;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_63.Item[0])) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "newWeaponSkins[ i ].IsNullOrEmpty", args:  System.Array.Empty<System.Object>());
        }
        else
        {
                int val_133 = Rilisoft.上丑业三丆丆丅丕三.丁丝东万三丂丏丒丟(且丘世丏丛丛万丟万:  val_63.Item[0]);
        }
        
        val_192 = val_192 + 1;
        if(val_63 != 0)
        {
            goto label_296;
        }
        
        goto label_297;
        label_282:
        if(val_63.Count >= 1)
        {
                Progress.七七世万专丕丁上业.专不丛丛丕一丌丂丕().丂且不业丂专丛丆东();
        }
        
        val_248 = 0;
        goto label_319;
        label_327:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_68.Item[0])) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "newGadgets[ i ].IsNullOrEmpty", args:  System.Array.Empty<System.Object>());
        }
        
        val_248 = 1;
        label_319:
        if(val_248 < val_68.Count)
        {
            goto label_327;
        }
        
        if(val_68.Count >= 1)
        {
                Progress.下业丅丑丌丝丒丅丛 val_145 = Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒();
        }
        
        int val_193 = 0;
        if(val_77 != 0)
        {
            goto label_357;
        }
        
        label_358:
        label_357:
        if(val_193 >= val_77.Count)
        {
            goto label_334;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_77.Item[0])) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "newRoyale[ i ].IsNullOrEmpty", args:  System.Array.Empty<System.Object>());
        }
        else
        {
                int val_151 = 丛且丗丌丏下七下丈.业丅万上丌专丄下丛(丙万丅万丅七丕业下:  val_77.Item[0]);
            if(val_151 != 1)
        {
                Progress.七七世万专丕丁上业.丝丞丂丟业丈不丑东().丒三丐丄东丟丁丅丏(下下丏一丙不丘丌丞:  val_151);
        }
        else
        {
                object[] val_153 = new object[1];
            val_153[0] = val_77.Item[0];
            UnityEngine.Debug.LogErrorFormat(format:  "royale index == -1 {0}", args:  val_153);
        }
        
        }
        
        val_193 = val_193 + 1;
        if(val_77 != 0)
        {
            goto label_357;
        }
        
        goto label_358;
        label_334:
        if(val_77.Count >= 1)
        {
                Progress.丟丝丈不七丑丙万丌 val_158 = Progress.七七世万专丕丁上业.丝丞丂丟业丈不丑东();
        }
        
        int val_194 = 0;
        label_406:
        if(val_194 >= val_86.Count)
        {
            goto label_383;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_86.Item[0])) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "newVehicles[ i ].IsNullOrEmpty", args:  System.Array.Empty<System.Object>());
        }
        else
        {
                int val_164 = 丛且丗丌丏下七下丈.业丅万上丌专丄下丛(丙万丅万丅七丕业下:  val_86.Item[0]);
            if(val_164 != 1)
        {
                bool val_166 = Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().万不丘万丘万与丐丒(丒丑丂万不丆且丒丝:  val_164, 上丟与丗七丅丈丅丁:  0, 丞不丌丘三丐丘东东:  true);
        }
        else
        {
                object[] val_167 = new object[1];
            val_167[0] = val_86.Item[0];
            UnityEngine.Debug.LogErrorFormat(format:  "vehicle index == -1 {0}", args:  val_167);
        }
        
        }
        
        val_194 = val_194 + 1;
        goto label_406;
        label_383:
        if(val_86.Count >= 1)
        {
                Progress.丂丂丑上丁丌业丑丈 val_172 = Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟();
        }
        
        int val_195 = 0;
        label_446:
        if(val_195 >= val_90.Count)
        {
            goto label_431;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_90.Item[0])) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "newUtility[ i ].IsNullOrEmpty", args:  System.Array.Empty<System.Object>());
        }
        else
        {
                val_249 = null;
            val_249 = null;
            Progress.不专丂万丐丄七上丗 val_178 = Progress.东丐世上丛丌丛丛丝.丒七七东三丗丂丅业.Item[val_90.Item[0]];
        }
        
        val_195 = val_195 + 1;
        goto label_446;
        label_431:
        if(val_90.Count >= 1)
        {
                Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丂且不业丂专丛丆东();
        }
        
        label_469:
        object[] val_187 = new object[2];
        val_187[0] = val_189;
        val_187[1] = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_14);
        UnityEngine.Debug.LogFormat(format:  "PurchasesCloudApplyer: Succeeded to apply purchases:\n\'currentPullResult\':{0},\n\'cloudPurchases\':{1}", args:  val_187);
        return false;
        label_694:
        val_244 = ;
        do
        {
        
        }
        while( != 1);
        
        if((null & 1) == 0)
        {
            goto label_686;
        }
        
        public System.String System.Collections.Generic.List<System.String>::get_Item(int index).__il2cppRuntimeField_20 = ;
        goto label_693;
        label_686:
        mem[8] = ;
        goto label_694;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
