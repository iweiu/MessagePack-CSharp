﻿// <auto-generated />

#pragma warning disable 618, 612, 414, 168, CS1591, SA1129, SA1309, SA1312, SA1403, SA1649

#pragma warning disable CS8669 // We may leak nullable annotations into generated code.

using MsgPack = global::MessagePack;

namespace MessagePack {
partial class GeneratedMessagePackResolver {
internal partial class TempProject {

	internal sealed class MyObjectFormatter : MsgPack::Formatters.IMessagePackFormatter<global::TempProject.MyObject>
	{

		public void Serialize(ref MsgPack::MessagePackWriter writer, global::TempProject.MyObject value, MsgPack::MessagePackSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNil();
				return;
			}

			MsgPack::IFormatterResolver formatterResolver = options.Resolver;
			writer.WriteArrayHeader(3);
			MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<int?>(formatterResolver).Serialize(ref writer, value.ValueNullableInt, options);
			MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<global::TempProject.MyEnum?>(formatterResolver).Serialize(ref writer, value.ValueNullableEnum, options);
			MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<(int, long)?>(formatterResolver).Serialize(ref writer, value.ValueNullableStruct, options);
		}

		public global::TempProject.MyObject Deserialize(ref MsgPack::MessagePackReader reader, MsgPack::MessagePackSerializerOptions options)
		{
			if (reader.TryReadNil())
			{
				return null;
			}

			options.Security.DepthStep(ref reader);
			MsgPack::IFormatterResolver formatterResolver = options.Resolver;
			var length = reader.ReadArrayHeader();
			var ____result = new global::TempProject.MyObject();

			for (int i = 0; i < length; i++)
			{
				switch (i)
				{
					case 0:
						____result.ValueNullableInt = MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<int?>(formatterResolver).Deserialize(ref reader, options);
						break;
					case 1:
						____result.ValueNullableEnum = MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<global::TempProject.MyEnum?>(formatterResolver).Deserialize(ref reader, options);
						break;
					case 2:
						____result.ValueNullableStruct = MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<(int, long)?>(formatterResolver).Deserialize(ref reader, options);
						break;
					default:
						reader.Skip();
						break;
				}
			}

			reader.Depth--;
			return ____result;
		}
	}
}
}
}