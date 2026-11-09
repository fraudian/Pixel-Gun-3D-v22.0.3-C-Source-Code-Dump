using UnityEngine;

namespace MessagePack.Formatters.PGCompany
{
    internal sealed class 丝丏丒且丐丒丒丝丒 : IMessagePackFormatter<PGCompany.丅丝丂丕上业与丐丏.七东万一万丞丂且丒>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.丅丝丂丕上业与丐丏.七东万一万丞丂且丒 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_32;
            var val_33;
            MessagePack.MessagePackWriter val_34;
            bool val_35;
            MessagePack.IFormatterResolver val_36;
            var val_37;
            Rilisoft.丝丑丂丛万丐丈丘且 val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            val_32 = 丆与丛丅丂三万一丑;
            val_33 = 丙业与丙丗丝不丈东;
            val_34 = 1152921541915668256;
            val_35 = true;
            if(val_33 != null)
            {
                    val_36 = val_32.Resolver;
                val_37 = 1152921541903703776;
                val_38 = 丙业与丙丗丝不丈东.Version;
                val_40 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_36);
                val_41 = 1152921504968347648;
                var val_31 = 0;
                val_31 = val_31 + 1;
            }
            else
            {
                    val_34 = ???;
                val_32 = ???;
                val_36 = ???;
                val_33 = ???;
                val_39 = ???;
                val_38 = ???;
                val_37 = ???;
                val_40 = ???;
                val_41 = ???;
                val_35 = val_35 + ((X11) << 4);
                val_42 = val_35 + 296;
            }
            
            val_40.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_34, _span = new System.Span<System.Byte>() {_length = val_34}, _segment = new System.ArraySegment<System.Byte>() {_count = val_34}, _buffered = val_34, _bytesCommitted = val_34, _sequencePool = val_34, _rental = new Rental() {owner = val_34, <Value>k__BackingField = val_34}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_34}, <OldSpec>k__BackingField = val_34}, value:  null, options:  null);
            var val_32 = 0;
            val_32 = val_32 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.DateTime>(resolver:  val_36).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_34, _span = new System.Span<System.Byte>() {_length = val_34}, _segment = new System.ArraySegment<System.Byte>() {_count = val_34}, _buffered = val_34, _bytesCommitted = val_34, _sequencePool = val_34, _rental = new Rental() {owner = val_34, <Value>k__BackingField = val_34}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_34}, <OldSpec>k__BackingField = val_34}, value:  null, options:  null);
            var val_33 = 0;
            val_33 = val_33 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.DateTime>(resolver:  val_36).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_34, _span = new System.Span<System.Byte>() {_length = val_34}, _segment = new System.ArraySegment<System.Byte>() {_count = val_34}, _buffered = val_34, _bytesCommitted = val_34, _sequencePool = val_34, _rental = new Rental() {owner = val_34, <Value>k__BackingField = val_34}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_34}, <OldSpec>k__BackingField = val_34}, value:  null, options:  null);
            var val_34 = 0;
            val_34 = val_34 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.DateTime>(resolver:  val_36).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_34, _span = new System.Span<System.Byte>() {_length = val_34}, _segment = new System.ArraySegment<System.Byte>() {_count = val_34}, _buffered = val_34, _bytesCommitted = val_34, _sequencePool = val_34, _rental = new Rental() {owner = val_34, <Value>k__BackingField = val_34}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_34}, <OldSpec>k__BackingField = val_34}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_9 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_36);
            var val_35 = 0;
            val_35 = val_35 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_11 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_36);
            var val_36 = 0;
            val_36 = val_36 + 1;
            var val_37 = 0;
            val_37 = val_37 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.Dictionary<世丕上丞与业丂丞丞, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(resolver:  val_36).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_34, _span = new System.Span<System.Byte>() {_length = val_34}, _segment = new System.ArraySegment<System.Byte>() {_count = val_34}, _buffered = val_34, _bytesCommitted = val_34, _sequencePool = val_34, _rental = new Rental() {owner = val_34, <Value>k__BackingField = val_34}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_34}, <OldSpec>k__BackingField = val_34}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_15 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_36);
            var val_38 = 0;
            val_38 = val_38 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_17 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_36);
            var val_39 = 0;
            val_39 = val_39 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_17, typeof(), slot: 0);
        }
        public PGCompany.丅丝丂丕上业与丐丏.七东万一万丞丂且丒 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_22;
            var val_23;
            System.DateTime val_24;
            System.DateTime val_25;
            System.DateTime val_26;
            val_23 = 0;
            if((1152921541915915616 & 1) != 0)
            {
                    return (七东万一万丞丂且丒)val_23;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            if(1152921541915915616 >= 1)
            {
                    var val_40 = 0;
                val_24 = 0;
                val_25 = 0;
                val_26 = 0;
                val_22 = 0;
                do
            {
                if(val_40 <= 8)
            {
                    var val_31 = 0;
                val_31 = val_31 + 1;
                val_22 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  丆与丛丅丂三万一丑.Resolver).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            }
            
                val_40 = val_40 + 1;
            }
            while(val_40 != 1152921541915915616);
            
            }
            else
            {
                    val_22 = 0;
                val_26 = 0;
                val_25 = 0;
                val_24 = 0;
            }
            
            丅丝丂丕上业与丐丏.七东万一万丞丂且丒 val_30 = null;
            val_23 = val_30;
            val_30 = new 丅丝丂丕上业与丐丏.七东万一万丞丂且丒();
            if(val_23 != null)
            {
                    .Version = val_22;
                .StartTime = val_25;
                .EndTime = val_24;
                mem[1152921541915973080] = 0;
                .PresentationTime = val_26;
                .OffersCount = 0;
                mem[1152921541915973120] = 0;
                .PayCount = 0;
                mem[1152921541915973136] = 0;
                .AvailableItemsParams = 0;
                .CooldownInLobby = 0;
                mem[1152921541915973160] = 0;
            }
            else
            {
                    mem[16] = val_22;
                mem[24] = 0;
                mem[32] = val_26;
                mem[40] = val_25;
                mem[48] = val_24;
                mem[56] = 0;
                mem[64] = 0;
                mem[72] = 0;
                mem[80] = 0;
                mem[88] = 0;
                mem[96] = 0;
                mem[104] = 0;
            }
            
            .LevelOpen = 0;
            mem[1152921541915973176] = 0;
            return (七东万一万丞丂且丒)val_23;
        }
        public 丝丏丒且丐丒丒丝丒()
        {
        
        }
    
    }

}
