// <autogenerated />
#pragma warning disable 618  // Ignore obsolete members warnings
#pragma warning disable 105  // Ignore duplicate namespaces
#pragma warning disable 1591 // Ignore missing XML comment warnings
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Uno.UI.Xaml;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using Uno.UI.Helpers.Xaml;
using UnoEditor.Skia.Gtk;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#elif UNO_REFERENCE_API
using _View = Windows.UI.Xaml.UIElement;
#elif NET461
using _View = Windows.UI.Xaml.UIElement;
#endif

namespace UnoEditor.Shared.Views.Editor
{
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	public partial class Suggestion : Windows.UI.Xaml.Controls.UserControl
	{
		private void InitializeComponent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			IsParsing = true
			;
			// Source ..\..\..\..\..\..\..\UnoEditor.Shared\Views\Editor\suggestbox.xaml (Line 1:2)
			Content = 
			new global::Windows.UI.Xaml.Controls.ListView
			{
				IsParsing = true
				,
				ItemTemplate = 				new global::Windows.UI.Xaml.DataTemplate(() => 				new _suggestbox_7f85175f4a9ff61442a2c120f4c83a43_UnoEditorSharedViewsEditorSuggestionSC0().Build()
				)				,
				// Source ..\..\..\..\..\..\..\UnoEditor.Shared\Views\Editor\suggestbox.xaml (Line 12:4)
			}
			.suggestbox_7f85175f4a9ff61442a2c120f4c83a43_XamlApply((suggestbox_7f85175f4a9ff61442a2c120f4c83a43XamlApplyExtensions.XamlApplyHandler0)(c0 => 
			{
				c0.SetBinding(global::Windows.UI.Xaml.Controls.ListView.ItemsSourceProperty, new Windows.UI.Xaml.Data.Binding{ Mode = BindingMode.OneTime }.Apply(___b =>  /*defaultBindModeOneTime*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::UnoEditor.Shared.Views.Editor.Suggestion ___tctx ? (object)(___tctx.suggestions) : null, null )));
								this._component_0 = c0;
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c0, "file:///E:/Reposs/UnoEditor/UnoEditor/UnoEditor.Shared/Views/Editor/suggestbox.xaml");
				c0.CreationComplete();
			}
			))
			;
			
			this
			.Apply((c1 => 
			{
				// Source E:\Reposs\UnoEditor\UnoEditor\UnoEditor.Shared\Views\Editor\suggestbox.xaml (Line 1:2)
				
				// WARNING Property c1.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}UserControl, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			.Apply((c2 => 
			{
				// Class UnoEditor.Shared.Views.Editor.Suggestion
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c2, "file:///E:/Reposs/UnoEditor/UnoEditor/UnoEditor.Shared/Views/Editor/suggestbox.xaml");
				c2.CreationComplete();
			}
			))
			;
			OnInitializeCompleted();
			InitializeXamlOwner();
			Bindings = new Suggestion_Bindings(this);
			Loading += delegate
			{
				Bindings.Update();
				_component_0.UpdateResourceBindings();
			}
			;
		}
		partial void OnInitializeCompleted();
		private class _suggestbox_7f85175f4a9ff61442a2c120f4c83a43_UnoEditorSharedViewsEditorSuggestionSC0
		{
			public _View Build()
			{
				var nameScope = new global::Windows.UI.Xaml.NameScope();
				_View __rootInstance = null;
				__rootInstance = 
				new global::Windows.UI.Xaml.Controls.Button
				{
					IsParsing = true
					,
					// Source ..\..\..\..\..\..\..\UnoEditor.Shared\Views\Editor\suggestbox.xaml (Line 15:10)
				}
				.suggestbox_7f85175f4a9ff61442a2c120f4c83a43_XamlApply((suggestbox_7f85175f4a9ff61442a2c120f4c83a43XamlApplyExtensions.XamlApplyHandler1)(c3 => 
				{
					global::Uno.UI.FrameworkElementHelper.SetBaseUri(c3, "file:///E:/Reposs/UnoEditor/UnoEditor/UnoEditor.Shared/Views/Editor/suggestbox.xaml");
					c3.CreationComplete();
				}
				))
				;
				if (__rootInstance is DependencyObject d) Windows.UI.Xaml.NameScope.SetNameScope(d, nameScope);
				return __rootInstance;
			}
		}
		private global::Windows.UI.Xaml.Controls.ListView _component_0;
		private interface ISuggestion_Bindings
		{
			void Initialize();
			void Update();
			void StopTracking();
		}
		#pragma warning disable 0169 //  Suppress unused field warning in case Bindings is not used.
		private ISuggestion_Bindings Bindings;
		#pragma warning restore 0169
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		private class Suggestion_Bindings : ISuggestion_Bindings
		{
			#if UNO_HAS_UIELEMENT_IMPLICIT_PINNING
			private global::System.WeakReference _ownerReference;
			private Suggestion Owner { get => (Suggestion)_ownerReference?.Target; set => _ownerReference = new global::System.WeakReference(value); }
			#else
			private Suggestion Owner { get; set; }
			#endif
			public Suggestion_Bindings(Suggestion owner)
			{
				Owner = owner;
			}
			void ISuggestion_Bindings.Initialize()
			{
			}
			void ISuggestion_Bindings.Update()
			{
				var owner = Owner;
				owner._component_0.ApplyXBind();
			}
			void ISuggestion_Bindings.StopTracking()
			{
			}
		}
		private void InitializeXamlOwner()
		{
		}
	}
}
namespace UnoEditor.Skia.Gtk
{
	static class suggestbox_7f85175f4a9ff61442a2c120f4c83a43XamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.ListView instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.ListView suggestbox_7f85175f4a9ff61442a2c120f4c83a43_XamlApply(this global::Windows.UI.Xaml.Controls.ListView instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.Button instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Button suggestbox_7f85175f4a9ff61442a2c120f4c83a43_XamlApply(this global::Windows.UI.Xaml.Controls.Button instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
