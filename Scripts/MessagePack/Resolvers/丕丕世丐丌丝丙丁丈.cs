using UnityEngine;

namespace MessagePack.Resolvers
{
    internal class 丕丕世丐丌丝丙丁丈 : IFormatterResolver
    {
        // Fields
        public static readonly MessagePack.IFormatterResolver 丆丕丝丒不丙且丐丗;
        
        // Methods
        private 丕丕世丐丌丝丙丁丈()
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
        private static 丕丕世丐丌丝丙丁丈()
        {
            MessagePack.Resolvers.丕丕世丐丌丝丙丁丈.丆丕丝丒不丙且丐丗 = new MessagePack.Resolvers.丕丕世丐丌丝丙丁丈();
        }
    
    }

}
