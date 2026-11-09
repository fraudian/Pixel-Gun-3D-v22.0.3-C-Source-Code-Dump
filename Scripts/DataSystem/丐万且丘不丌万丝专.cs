using UnityEngine;

namespace DataSystem
{
    public class 丐万且丘不丌万丝专 : IFormatterResolver
    {
        // Fields
        public static readonly DataSystem.丐万且丘不丌万丝专 丆丕丝丒不丙且丐丗;
        
        // Methods
        private 丐万且丘不丌万丝专()
        {
        
        }
        public MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>()
        {
            var val_1 = mem[__RuntimeMethodHiddenParam + 48 + 294];
            val_1 = __RuntimeMethodHiddenParam + 48 + 294;
            if((val_1 & 1) == 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 48 + 294];
                val_1 = __RuntimeMethodHiddenParam + 48 + 294;
            }
            
            if(((__RuntimeMethodHiddenParam + 48 + 294) & 1) != 0)
            {
                    return (MessagePack.Formatters.IMessagePackFormatter<T>)__RuntimeMethodHiddenParam + 48 + 184;
            }
            
            return (MessagePack.Formatters.IMessagePackFormatter<T>)__RuntimeMethodHiddenParam + 48 + 184;
        }
        private static 丐万且丘不丌万丝专()
        {
            DataSystem.丐万且丘不丌万丝专.丆丕丝丒不丙且丐丗 = new DataSystem.丐万且丘不丌万丝专();
        }
    
    }

}
