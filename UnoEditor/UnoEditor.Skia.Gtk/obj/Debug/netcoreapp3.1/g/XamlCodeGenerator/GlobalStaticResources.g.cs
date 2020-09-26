// <autogenerated />
#pragma warning disable 618  // Ignore obsolete members warnings
#pragma warning disable 105  // Ignore duplicate namespaces
#pragma warning disable 1591 // Ignore missing XML comment warnings
using System;
using System.Linq;
using System.Collections.Generic;
using Uno.Extensions;
using Uno;
using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using UnoEditor.Skia.Gtk;

namespace UnoEditor.Skia.Gtk
{
	/// <summary>
	/// Contains all the static resources defined for the application
	/// </summary>
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	public sealed partial class GlobalStaticResources
	{
		static bool _initialized;
		private static bool _stylesRegistered;
		private static bool _dictionariesRegistered;
		internal static global::Uno.UI.Xaml.XamlParseContext __ParseContext_ {get; } = new global::Uno.UI.Xaml.XamlParseContext()
		{
			AssemblyName = "UnoEditor.Skia.Gtk",
		}
		;

		static GlobalStaticResources()
		{
			Initialize();
		}
		public static void Initialize()
		{
			if (!_initialized)
			{
				_initialized = true;
				global::Uno.UI.GlobalStaticResources.Initialize();
				global::Uno.UI.Toolkit.GlobalStaticResources.Initialize();
				global::Uno.UI.GlobalStaticResources.RegisterDefaultStyles();
				global::Uno.UI.Toolkit.GlobalStaticResources.RegisterDefaultStyles();
				global::Uno.UI.GlobalStaticResources.RegisterResourceDictionariesBySource();
				global::Uno.UI.Toolkit.GlobalStaticResources.RegisterResourceDictionariesBySource();
			}
		}
		public static void RegisterDefaultStyles()
		{
			if(!_stylesRegistered)
			{
				_stylesRegistered = true;
				RegisterDefaultStyles_App_85b4184345a48e89157cf9ab258f40de();
				RegisterDefaultStyles_ColorPaletteOverride_ac565fb807a78858eea58480be979323();
				RegisterDefaultStyles_Editor_897a56e6dff82034c0e07b75d87fcff3();
				RegisterDefaultStyles_MainPage_77666adaa098a2b86ef8a14e7904941d();
				RegisterDefaultStyles_Terminal2_39ce92f6ec666afdd71a77b7216eb7b3();
			}
		}
		// Register ResourceDictionaries using ms-appx:/// syntax, this is called for external resources
		public static void RegisterResourceDictionariesBySource()
		{
			if(!_dictionariesRegistered)
			{
				_dictionariesRegistered = true;
				global::Uno.UI.ResourceResolver.RegisterResourceDictionaryBySource(uri: "ms-appx:///UnoEditor.Skia.Gtk/ColorPaletteOverride.xaml", context: __ParseContext_, dictionary: () => ColorPaletteOverride_ac565fb807a78858eea58480be979323_ResourceDictionary);
			}
		}
		// Register ResourceDictionaries using ms-resource:/// syntax, this is called for local resources
		internal static void RegisterResourceDictionariesBySourceLocal()
		{
			global::Uno.UI.ResourceResolver.RegisterResourceDictionaryBySource(uri: "ms-resource:///Files/ColorPaletteOverride.xaml", context: null, dictionary: () => ColorPaletteOverride_ac565fb807a78858eea58480be979323_ResourceDictionary);
			global::Uno.UI.ResourceResolver.RegisterResourceDictionaryBySource(uri: "ms-appx:///ColorPaletteOverride.xaml", context: null, dictionary: () => ColorPaletteOverride_ac565fb807a78858eea58480be979323_ResourceDictionary);
		}
		static partial void RegisterDefaultStyles_App_85b4184345a48e89157cf9ab258f40de();
		static partial void RegisterDefaultStyles_ColorPaletteOverride_ac565fb807a78858eea58480be979323();
		static partial void RegisterDefaultStyles_Editor_897a56e6dff82034c0e07b75d87fcff3();
		static partial void RegisterDefaultStyles_MainPage_77666adaa098a2b86ef8a14e7904941d();
		static partial void RegisterDefaultStyles_Terminal2_39ce92f6ec666afdd71a77b7216eb7b3();
		[global::System.Obsolete("This method is provided for binary backward compatibility. It will always return null.")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static object FindResource(string name) => null;
		
	}
}
