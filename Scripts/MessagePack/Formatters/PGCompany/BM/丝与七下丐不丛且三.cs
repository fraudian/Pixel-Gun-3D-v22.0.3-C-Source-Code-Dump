using UnityEngine;

namespace MessagePack.Formatters.PGCompany.BM
{
    internal sealed class 丝与七下丐不丛且三 : IMessagePackFormatter<PGCompany.BM.丟与业丄世七丏下丌.且丟丐万专丞且下丐>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.BM.丟与业丄世七丏下丌.且丟丐万专丞且下丐 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_21;
            var val_22;
            MessagePack.MessagePackWriter val_23;
            bool val_24;
            MessagePack.IFormatterResolver val_25;
            var val_26;
            Rilisoft.丝丑丂丛万丐丈丘且 val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            val_21 = 丆与丛丅丂三万一丑;
            val_22 = 丙业与丙丗丝不丈东;
            val_23 = 1152921541973729328;
            val_24 = true;
            if(val_22 != null)
            {
                    val_25 = val_21.Resolver;
                val_26 = 1152921541903703776;
                val_27 = 丙业与丙丗丝不丈东._lotsCount;
                val_29 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_25);
                val_30 = 1152921504968347648;
                var val_20 = 0;
                val_20 = val_20 + 1;
            }
            else
            {
                    val_23 = ???;
                val_21 = ???;
                val_25 = ???;
                val_22 = ???;
                val_28 = ???;
                val_27 = ???;
                val_26 = ???;
                val_29 = ???;
                val_30 = ???;
                val_24 = val_24 + ((X11) << 4);
                val_31 = val_24 + 296;
            }
            
            val_29.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_23, _span = new System.Span<System.Byte>() {_length = val_23}, _segment = new System.ArraySegment<System.Byte>() {_count = val_23}, _buffered = val_23, _bytesCommitted = val_23, _sequencePool = val_23, _rental = new Rental() {owner = val_23, <Value>k__BackingField = val_23}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_23}, <OldSpec>k__BackingField = val_23}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_3 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_25);
            var val_21 = 0;
            val_21 = val_21 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_5 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_25);
            var val_22 = 0;
            val_22 = val_22 + 1;
            var val_23 = 0;
            val_23 = val_23 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<PGCompany.三东丏不丗世丅丌丄>(resolver:  val_25).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_23, _span = new System.Span<System.Byte>() {_length = val_23}, _segment = new System.ArraySegment<System.Byte>() {_count = val_23}, _buffered = val_23, _bytesCommitted = val_23, _sequencePool = val_23, _rental = new Rental() {owner = val_23, <Value>k__BackingField = val_23}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_23}, <OldSpec>k__BackingField = val_23}, value:  null, options:  null);
        }
        public PGCompany.BM.丟与业丄世七丏下丌.且丟丐万专丞且下丐 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_12;
            Rilisoft.丝丑丂丛万丐丈丘且 val_13;
            Rilisoft.丝丑丂丛万丐丈丘且 val_14;
            val_12 = 0;
            if((1152921541973935600 & 1) != 0)
            {
                    return (且丟丐万专丞且下丐)val_12;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541973935600 < 1)
            {
                goto label_5;
            }
            
            var val_21 = 0;
            val_13 = 0;
            val_14 = 0;
            label_39:
            if(val_21 > 3)
            {
                goto label_38;
            }
            
            var val_16 = -35407304;
            val_16 = val_16 + 106045800;
            goto (-35407304 + 106045800);
            label_38:
            val_21 = val_21 + 1;
            if(val_21 != 1152921541973935600)
            {
                goto label_39;
            }
            
            goto label_40;
            label_5:
            val_14 = 0;
            val_13 = 0;
            label_40:
            丟与业丄世七丏下丌.且丟丐万专丞且下丐 val_15 = null;
            val_12 = val_15;
            val_15 = new 丟与业丄世七丏下丌.且丟丐万专丞且下丐();
            if(val_12 != null)
            {
                    ._lotsCount = val_14;
                mem[1152921541973972504] = 0;
                ._freeUpCount = val_13;
                mem[1152921541973972520] = 0;
                ._paidUpCount = 0;
                mem[1152921541973972536] = 0;
            }
            else
            {
                    mem[16] = val_14;
                mem[24] = 0;
                mem[32] = val_13;
                mem[40] = 0;
                mem[48] = 0;
                mem[56] = 0;
            }
            
            ._item = 0;
            return (且丟丐万专丞且下丐)val_12;
        }
        public 丝与七下丐不丛且三()
        {
        
        }
    
    }

}
