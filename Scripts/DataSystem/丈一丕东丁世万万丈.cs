using UnityEngine;

namespace DataSystem
{
    internal class 丈一丕东丁世万万丈 : 丈且丈上不下且丝丒, 丌丈丕丑丛丕世丒世, 丒丕丑下业专七且丝, 丈专丈丐丈丆丛三丁, 下一与丏专丒七丙丑
    {
        // Fields
        private static bool 专万丕丗丘不丙上丁;
        
        // Methods
        internal 丈一丕东丁世万万丈()
        {
            MessagePack.MessagePackSerializerOptions val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_4 = this;
            if(DataSystem.丈一丕东丁世万万丈.专万丕丗丘不丙上丁 == true)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            MessagePack.IFormatterResolver[] val_1 = new MessagePack.IFormatterResolver[4];
            val_6 = null;
            val_6 = null;
            if(val_1 == null)
            {
                    val_7 = 0;
            }
            
            if(MessagePack.Resolvers.StandardResolver.Instance != null)
            {
                    val_7 = MessagePack.Resolvers.StandardResolver.Instance;
            }
            
            val_1[0] = MessagePack.Resolvers.StandardResolver.Instance;
            if((((MessagePack.Resolvers.StandardResolver.Instance + 295) & 2) != 0) && ((MessagePack.Resolvers.StandardResolver.Instance + 216) == 0))
            {
                    val_7 = null;
            }
            
            val_1[1] = DataSystem.丐万且丘不丌万丝专.丆丕丝丒不丙且丐丗;
            val_8 = null;
            val_8 = null;
            val_1[2] = MessagePack.Resolvers.丕丕世丐丌丝丙丁丈.丆丕丝丒不丙且丐丗;
            val_9 = null;
            val_9 = null;
            val_1[3] = MessagePack.Unity.UnityResolver.Instance;
            MessagePack.Resolvers.StaticCompositeResolver.Instance.Register(resolvers:  val_1);
            val_4 = MessagePack.MessagePackSerializerOptions.Standard.WithResolver(resolver:  MessagePack.Resolvers.StaticCompositeResolver.Instance);
            MessagePack.MessagePackSerializer.DefaultOptions = val_4;
            DataSystem.丈一丕东丁世万万丈.专万丕丗丘不丙上丁 = true;
        }
        public string 丙业不丝丗丌丗世下(object 万且万且丑丗且丌丆)
        {
            return (string)System.Convert.ToBase64String(inArray:  this.东丕丂丑丞丞丆丅丏(万且万且丑丗且丌丆:  万且万且丑丗且丌丆));
        }
        public System.Threading.Tasks.Task<string> 专东三上丐丝丈与丒(object 万且万且丑丗且丌丆)
        {
            丈一丕东丁世万万丈.上丌专丄丘丂东且丒 val_1 = new 丈一丕东丁世万万丈.上丌专丄丘丂东且丒();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .万且万且丑丗且丌丆 = 万且万且丑丗且丌丆;
            return System.Threading.Tasks.Task.Run<System.String>(function:  new System.Func<System.String>(object:  val_1, method:  System.String 丈一丕东丁世万万丈.上丌专丄丘丂东且丒::丏丑专丏丘丈丒专丅()));
        }
        public T 丂东专丙丒丏且丛丁<T>(string 丞丕丒专一下丙业上)
        {
            System.Byte[] val_1 = System.Convert.FromBase64String(s:  丞丕丒专一下丙业上);
            if(this != null)
            {
                    return (object)this;
            }
            
            return (object)this;
        }
        public object 丂东专丙丒丏且丛丁(string 丞丕丒专一下丙业上, System.Type 丐不丄七丐丁丛丐下)
        {
            new System.IO.MemoryStream() = new System.IO.MemoryStream(buffer:  System.Convert.FromBase64String(s:  丞丕丒专一下丙业上));
            return (object)MessagePack.MessagePackSerializer.Deserialize(type:  丐不丄七丐丁丛丐下, stream:  new System.IO.MemoryStream(), options:  0, cancellationToken:  new System.Threading.CancellationToken());
        }
        public object 丂东专丙丒丏且丛丁(byte[] 丝丆丁丞丛三丁丑丙, System.Type 丐不丄七丐丁丛丐下)
        {
            new System.IO.MemoryStream() = new System.IO.MemoryStream(buffer:  丝丆丁丞丛三丁丑丙);
            return (object)MessagePack.MessagePackSerializer.Deserialize(type:  丐不丄七丐丁丛丐下, stream:  new System.IO.MemoryStream(), options:  0, cancellationToken:  new System.Threading.CancellationToken());
        }
        public System.Threading.Tasks.Task<T> 丂丟丐丙且东丙丈丅<T>(string 丞丕丒专一下丙业上)
        {
            if((__RuntimeMethodHiddenParam + 48) != 0)
            {
                    mem2[0] = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            mem2[0] = 丞丕丒专一下丙业上;
            goto __RuntimeMethodHiddenParam + 48 + 40;
        }
        public System.Threading.Tasks.Task<object> 丂丟丐丙且东丙丈丅(string 丞丕丒专一下丙业上, System.Type 丁丅丈丌丟世丗丗丟)
        {
            丈一丕东丁世万万丈.业东下丕世丗丏万丏 val_1 = new 丈一丕东丁世万万丈.业东下丕世丗丏万丏();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .丞丕丒专一下丙业上 = 丞丕丒专一下丙业上;
            }
            else
            {
                    mem[16] = this;
                mem[24] = 丞丕丒专一下丙业上;
            }
            
            .丁丅丈丌丟世丗丗丟 = 丁丅丈丌丟世丗丗丟;
            return System.Threading.Tasks.Task.Run<System.Object>(function:  new System.Func<System.Object>(object:  val_1, method:  System.Object 丈一丕东丁世万万丈.业东下丕世丗丏万丏::下东丌丒丕丒一世丅()));
        }
        public byte[] 东丕丂丑丞丞丆丅丏(object 万且万且丑丗且丌丆)
        {
            return (System.Byte[])MessagePack.MessagePackSerializer.Serialize<System.Object>(value:  万且万且丑丗且丌丆, options:  0, cancellationToken:  new System.Threading.CancellationToken());
        }
        public System.Threading.Tasks.Task<byte[]> 万世上一三丕且万丏(object 万且万且丑丗且丌丆)
        {
            丈一丕东丁世万万丈.下丌丛三下专丘丐丕 val_1 = new 丈一丕东丁世万万丈.下丌丛三下专丘丐丕();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .万且万且丑丗且丌丆 = 万且万且丑丗且丌丆;
            return System.Threading.Tasks.Task.Run<System.Byte[]>(function:  new System.Func<System.Byte[]>(object:  val_1, method:  System.Byte[] 丈一丕东丁世万万丈.下丌丛三下专丘丐丕::万上丝丏丌丟万七丗()));
        }
        public T 丂东专丙丒丏且丛丁<T>(byte[] 丞丕丒专一下丙业上)
        {
            var val_5;
            string val_6;
            string val_7;
            val_5 = __RuntimeMethodHiddenParam;
            if(丞丕丒专一下丙业上 == null)
            {
                goto label_1;
            }
            
            if(丞丕丒专一下丙业上.Length <= 0)
            {
                goto label_2;
            }
            
            System.ReadOnlyMemory<T> val_1 = System.ReadOnlyMemory<System.Byte>.op_Implicit(array:  丞丕丒专一下丙业上);
            val_5 = ???;
            goto __RuntimeMethodHiddenParam + 48 + 8;
            label_1:
            val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_5 + 48});
            val_7 = "deserialization fail, cant deserialize null to ";
            goto label_8;
            label_2:
            val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48});
            val_7 = "deserialization fail, cant deserialize empty bytes array to ";
            label_8:
            UnityEngine.Debug.LogError(message:  val_7 + val_6);
            return 0;
        }
        public System.Threading.Tasks.Task<T> 丂丟丐丙且东丙丈丅<T>(byte[] 丞丕丒专一下丙业上)
        {
            if((__RuntimeMethodHiddenParam + 48) != 0)
            {
                    mem2[0] = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            mem2[0] = 丞丕丒专一下丙业上;
            goto __RuntimeMethodHiddenParam + 48 + 40;
        }
        public System.Threading.Tasks.Task<object> 丂丟丐丙且东丙丈丅(byte[] 丞丕丒专一下丙业上, System.Type 丁丅丈丌丟世丗丗丟)
        {
            丈一丕东丁世万万丈.世东丒与丞七不不东 val_1 = new 丈一丕东丁世万万丈.世东丒与丞七不不东();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .丞丕丒专一下丙业上 = 丞丕丒专一下丙业上;
            }
            else
            {
                    mem[16] = this;
                mem[24] = 丞丕丒专一下丙业上;
            }
            
            .丁丅丈丌丟世丗丗丟 = 丁丅丈丌丟世丗丗丟;
            return System.Threading.Tasks.Task.Run<System.Object>(function:  new System.Func<System.Object>(object:  val_1, method:  System.Object 丈一丕东丁世万万丈.世东丒与丞七不不东::下东丌丒丕丒一世丅()));
        }
    
    }

}
