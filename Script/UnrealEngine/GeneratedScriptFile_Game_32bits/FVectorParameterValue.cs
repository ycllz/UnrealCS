#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FVectorParameterValue
	{
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(8)]
		public FLinearColor ParameterValue;
		[FieldOffset(24)]
		public FGuid ExpressionGUID;
		
	}
	
}
#endif
#endif
