using UnityEngine;

namespace MessagePack.Formatters.PGCompany
{
    internal sealed class 不不丆丂丈丈东丙丑 : IMessagePackFormatter<PGCompany.丐丐上丝丑七丕三丑>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.丐丐上丝丑七丕三丑 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_46;
            var val_47;
            MessagePack.MessagePackWriter val_48;
            bool val_49;
            MessagePack.IFormatterResolver val_50;
            var val_51;
            Rilisoft.丝丑丂丛万丐丈丘且 val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_56;
            val_46 = 丆与丛丅丂三万一丑;
            val_47 = 丙业与丙丗丝不丈东;
            val_48 = 1152921541937455200;
            val_49 = true;
            if(val_47 != null)
            {
                    val_50 = val_46.Resolver;
                val_51 = 1152921541903703776;
                val_52 = 丙业与丙丗丝不丈东.Index;
                val_54 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_50);
                val_55 = 1152921504968347648;
                var val_45 = 0;
                val_45 = val_45 + 1;
            }
            else
            {
                    val_48 = ???;
                val_46 = ???;
                val_50 = ???;
                val_47 = ???;
                val_53 = ???;
                val_52 = ???;
                val_51 = ???;
                val_54 = ???;
                val_55 = ???;
                val_49 = val_49 + ((X11) << 4);
                val_56 = val_49 + 296;
            }
            
            val_54.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_48, _span = new System.Span<System.Byte>() {_length = val_48}, _segment = new System.ArraySegment<System.Byte>() {_count = val_48}, _buffered = val_48, _bytesCommitted = val_48, _sequencePool = val_48, _rental = new Rental() {owner = val_48, <Value>k__BackingField = val_48}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_48}, <OldSpec>k__BackingField = val_48}, value:  null, options:  null);
            var val_46 = 0;
            val_46 = val_46 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  val_50).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_48, _span = new System.Span<System.Byte>() {_length = val_48}, _segment = new System.ArraySegment<System.Byte>() {_count = val_48}, _buffered = val_48, _bytesCommitted = val_48, _sequencePool = val_48, _rental = new Rental() {owner = val_48, <Value>k__BackingField = val_48}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_48}, <OldSpec>k__BackingField = val_48}, value:  null, options:  null);
            var val_47 = 0;
            val_47 = val_47 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.DateTime>(resolver:  val_50).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_48, _span = new System.Span<System.Byte>() {_length = val_48}, _segment = new System.ArraySegment<System.Byte>() {_count = val_48}, _buffered = val_48, _bytesCommitted = val_48, _sequencePool = val_48, _rental = new Rental() {owner = val_48, <Value>k__BackingField = val_48}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_48}, <OldSpec>k__BackingField = val_48}, value:  null, options:  null);
            var val_48 = 0;
            val_48 = val_48 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.DateTime>(resolver:  val_50).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_48, _span = new System.Span<System.Byte>() {_length = val_48}, _segment = new System.ArraySegment<System.Byte>() {_count = val_48}, _buffered = val_48, _bytesCommitted = val_48, _sequencePool = val_48, _rental = new Rental() {owner = val_48, <Value>k__BackingField = val_48}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_48}, <OldSpec>k__BackingField = val_48}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_9 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_50);
            var val_49 = 0;
            val_49 = val_49 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_11 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_50);
            var val_50 = 0;
            val_50 = val_50 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_13 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_50);
            var val_51 = 0;
            val_51 = val_51 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_15 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_50);
            var val_52 = 0;
            val_52 = val_52 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_17 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_50);
            var val_53 = 0;
            val_53 = val_53 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_19 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_50);
            var val_54 = 0;
            val_54 = val_54 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_21 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_50);
            var val_55 = 0;
            val_55 = val_55 + 1;
            var val_56 = 0;
            val_56 = val_56 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.不万不丑专下三一丁>>(resolver:  val_50).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_48, _span = new System.Span<System.Byte>() {_length = val_48}, _segment = new System.ArraySegment<System.Byte>() {_count = val_48}, _buffered = val_48, _bytesCommitted = val_48, _sequencePool = val_48, _rental = new Rental() {owner = val_48, <Value>k__BackingField = val_48}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_48}, <OldSpec>k__BackingField = val_48}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_25 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_50);
            var val_57 = 0;
            val_57 = val_57 + 1;
            var val_58 = 0;
            val_58 = val_58 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(resolver:  val_50).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_48, _span = new System.Span<System.Byte>() {_length = val_48}, _segment = new System.ArraySegment<System.Byte>() {_count = val_48}, _buffered = val_48, _bytesCommitted = val_48, _sequencePool = val_48, _rental = new Rental() {owner = val_48, <Value>k__BackingField = val_48}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_48}, <OldSpec>k__BackingField = val_48}, value:  null, options:  null);
            var val_59 = 0;
            val_59 = val_59 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.下丄丄丞三且丒下业>>(resolver:  val_50).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_48, _span = new System.Span<System.Byte>() {_length = val_48}, _segment = new System.ArraySegment<System.Byte>() {_count = val_48}, _buffered = val_48, _bytesCommitted = val_48, _sequencePool = val_48, _rental = new Rental() {owner = val_48, <Value>k__BackingField = val_48}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_48}, <OldSpec>k__BackingField = val_48}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_31 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_50);
            var val_60 = 0;
            val_60 = val_60 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_31, typeof(), slot: 0);
        }
        public PGCompany.丐丐上丝丑七丕三丑 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_36;
            string val_37;
            System.DateTime val_38;
            System.DateTime val_39;
            Rilisoft.丝丑丂丛万丐丈丘且 val_40;
            val_36 = 0;
            if((1152921541937760048 & 1) != 0)
            {
                    return (PGCompany.丐丐上丝丑七丕三丑)val_36;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541937760048 < 1)
            {
                goto label_5;
            }
            
            val_37 = 0;
            var val_69 = 0;
            val_38 = 0;
            val_39 = 0;
            val_40 = 0;
            label_136:
            if(val_69 > 18)
            {
                goto label_135;
            }
            
            var val_52 = -19021744;
            val_52 = val_52 + 106069868;
            goto (-19021744 + 106069868);
            label_135:
            val_69 = val_69 + 1;
            if(val_69 != 1152921541937760048)
            {
                goto label_136;
            }
            
            goto label_137;
            label_5:
            val_40 = 0;
            val_39 = 0;
            val_38 = 0;
            val_37 = 0;
            label_137:
            PGCompany.丐丐上丝丑七丕三丑 val_51 = null;
            val_36 = val_51;
            val_51 = new PGCompany.丐丐上丝丑七丕三丑();
            if(val_36 != null)
            {
                    .Index = val_40;
                .StartTime = val_39;
                .EndTime = val_38;
                mem[1152921541937846296] = 0;
                .PriceTier = val_37;
                .LifeTime = 0;
                mem[1152921541937846336] = 0;
                .Cooldown = 0;
                mem[1152921541937846352] = 0;
                .CooldownOnBuy = 0;
                mem[1152921541937846368] = 0;
                .GuiOrder = 0;
                .BuyLimit = 0;
                mem[1152921541937846392] = 0;
                .GroupIndex = 0;
                mem[1152921541937846408] = 0;
                .Priority = 0;
                mem[1152921541937846424] = 0;
                .GuiIndex = 0;
                mem[1152921541937846440] = 0;
                .Platforms = 0;
                ._isEnable = 0;
                mem[1152921541937846464] = 0;
                .Rewards = 0;
                .ConditionItemDatas = 0;
            }
            else
            {
                    mem[16] = val_40;
                mem[24] = 0;
                mem[32] = val_37;
                mem[40] = val_39;
                mem[48] = val_38;
                mem[56] = 0;
                mem[64] = 0;
                mem[72] = 0;
                mem[80] = 0;
                mem[88] = 0;
                mem[96] = 0;
                mem[104] = 0;
                mem[112] = 0;
                mem[120] = 0;
                mem[128] = 0;
                mem[136] = 0;
                mem[144] = 0;
                mem[152] = 0;
                mem[160] = 0;
                mem[168] = 0;
                mem[176] = 0;
                mem[184] = 0;
                mem[192] = 0;
                mem[200] = 0;
                mem[216] = 0;
            }
            
            .LobbyPopupCooldown = 0;
            mem[1152921541937846512] = 0;
            return (PGCompany.丐丐上丝丑七丕三丑)val_36;
        }
        public 不不丆丂丈丈东丙丑()
        {
        
        }
    
    }

}
