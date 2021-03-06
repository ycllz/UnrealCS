#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// The rich text block
	/// * Fancy Text
	/// * No Children
	/// </summary>
	public partial class URichTextBlock
	{
		static readonly int Text__Offset;
		/// <summary>The text to display</summary>
		public string Text
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+Text__Offset, typeof(FText))).ToString();}
			set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+Text__Offset, false);}
			
		}
		
		static readonly int Font__Offset;
		/// <summary>The default font for the text.</summary>
		public FSlateFontInfo Font
		{
			get{ CheckIsValid();return (FSlateFontInfo)Marshal.PtrToStructure(_this.Get()+Font__Offset, typeof(FSlateFontInfo));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Font__Offset, false);}
			
		}
		
		static readonly int Color__Offset;
		/// <summary>The default color for the text.</summary>
		public FLinearColor Color
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+Color__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Color__Offset, false);}
			
		}
		
		static readonly int Decorators__Offset;
		public TObjectArray<URichTextBlockDecorator>  Decorators
		{
					get{ CheckIsValid();return new TObjectArray<URichTextBlockDecorator>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Decorators__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Decorators__Offset, false);}
			
		}
		
		static URichTextBlock()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("RichTextBlock");
			Text__Offset=GetPropertyOffset(NativeClassPtr,"Text");
			Font__Offset=GetPropertyOffset(NativeClassPtr,"Font");
			Color__Offset=GetPropertyOffset(NativeClassPtr,"Color");
			Decorators__Offset=GetPropertyOffset(NativeClassPtr,"Decorators");
			
		}
		
	}
	
}
#endif
#endif
