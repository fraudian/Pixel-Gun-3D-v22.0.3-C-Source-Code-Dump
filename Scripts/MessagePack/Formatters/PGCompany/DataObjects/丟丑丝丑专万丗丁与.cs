using UnityEngine;

namespace MessagePack.Formatters.PGCompany.DataObjects
{
    internal sealed class 丟丑丝丑专万丗丁与 : IMessagePackFormatter<PGCompany.DataObjects.三丏世丟丟丙丟丙万>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.DataObjects.三丏世丟丟丙丟丙万 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_20;
            var val_21;
            MessagePack.MessagePackWriter val_22;
            bool val_23;
            MessagePack.IFormatterResolver val_24;
            System.Collections.Generic.Dictionary<System.Int32, 上丈丕三丐丌丘丅丂> val_25;
            var val_26;
            var val_27;
            val_20 = 丆与丛丅丂三万一丑;
            val_21 = 丙业与丙丗丝不丈东;
            val_22 = 1152921541951862928;
            val_23 = true;
            if(val_21 != null)
            {
                    val_24 = val_20.Resolver;
                val_25 = 丙业与丙丗丝不丈东.WeaponsPrefabNumbersDictionary;
                val_26 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.Dictionary<System.Int32, 上丈丕三丐丌丘丅丂>>(resolver:  val_24);
                var val_19 = 0;
                val_19 = val_19 + 1;
            }
            else
            {
                    val_22 = ???;
                val_20 = ???;
                val_24 = ???;
                val_21 = ???;
                val_26 = ???;
                val_25 = ???;
                val_23 = val_23 + ((X11) << 4);
                val_27 = val_23 + 296;
            }
            
            val_26.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_22, _span = new System.Span<System.Byte>() {_length = val_22}, _segment = new System.ArraySegment<System.Byte>() {_count = val_22}, _buffered = val_22, _bytesCommitted = val_22, _sequencePool = val_22, _rental = new Rental() {owner = val_22, <Value>k__BackingField = val_22}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_22}, <OldSpec>k__BackingField = val_22}, value:  null, options:  null);
            var val_20 = 0;
            val_20 = val_20 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.HashSet<System.Int32>>(resolver:  val_24).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_22, _span = new System.Span<System.Byte>() {_length = val_22}, _segment = new System.ArraySegment<System.Byte>() {_count = val_22}, _buffered = val_22, _bytesCommitted = val_22, _sequencePool = val_22, _rental = new Rental() {owner = val_22, <Value>k__BackingField = val_22}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_22}, <OldSpec>k__BackingField = val_22}, value:  null, options:  null);
            var val_21 = 0;
            val_21 = val_21 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.HashSet<System.Int32>>(resolver:  val_24).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_22, _span = new System.Span<System.Byte>() {_length = val_22}, _segment = new System.ArraySegment<System.Byte>() {_count = val_22}, _buffered = val_22, _bytesCommitted = val_22, _sequencePool = val_22, _rental = new Rental() {owner = val_22, <Value>k__BackingField = val_22}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_22}, <OldSpec>k__BackingField = val_22}, value:  null, options:  null);
            var val_22 = 0;
            val_22 = val_22 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.HashSet<System.Int32>>(resolver:  val_24).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_22, _span = new System.Span<System.Byte>() {_length = val_22}, _segment = new System.ArraySegment<System.Byte>() {_count = val_22}, _buffered = val_22, _bytesCommitted = val_22, _sequencePool = val_22, _rental = new Rental() {owner = val_22, <Value>k__BackingField = val_22}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_22}, <OldSpec>k__BackingField = val_22}, value:  null, options:  null);
        }
        public PGCompany.DataObjects.三丏世丟丟丙丟丙万 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_12;
            System.Collections.Generic.Dictionary<System.Int32, 上丈丕三丐丌丘丅丂> val_13;
            System.Collections.Generic.HashSet<System.Int32> val_14;
            System.Collections.Generic.HashSet<System.Int32> val_15;
            System.Collections.Generic.HashSet<System.Int32> val_16;
            val_12 = 0;
            if((1152921541952073328 & 1) != 0)
            {
                    return (PGCompany.DataObjects.三丏世丟丟丙丟丙万)val_12;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541952073328 < 1)
            {
                goto label_5;
            }
            
            val_13 = 0;
            val_14 = 0;
            val_15 = 0;
            val_16 = 0;
            var val_21 = 0;
            label_39:
            if(val_21 > 3)
            {
                goto label_38;
            }
            
            var val_16 = -21427244;
            val_16 = val_16 + 106067516;
            goto (-21427244 + 106067516);
            label_38:
            val_21 = val_21 + 1;
            if(val_21 != 1152921541952073328)
            {
                goto label_39;
            }
            
            goto label_40;
            label_5:
            val_16 = 0;
            val_15 = 0;
            val_14 = 0;
            val_13 = 0;
            label_40:
            PGCompany.DataObjects.三丏世丟丟丙丟丙万 val_15 = null;
            val_12 = val_15;
            val_15 = new PGCompany.DataObjects.三丏世丟丟丙丟丙万();
            if(val_12 != null)
            {
                    .WeaponsPrefabNumbersDictionary = val_13;
                .UnavailableWeapons = val_14;
                .ExcludedAlmanachWeapons = val_15;
            }
            else
            {
                    mem[24] = val_13;
                mem[32] = val_14;
                mem[40] = val_15;
            }
            
            .ExcludedAlmanachWeaponsForAlternateBuy = val_16;
            return (PGCompany.DataObjects.三丏世丟丟丙丟丙万)val_12;
        }
        public 丟丑丝丑专万丗丁与()
        {
        
        }
    
    }

}
