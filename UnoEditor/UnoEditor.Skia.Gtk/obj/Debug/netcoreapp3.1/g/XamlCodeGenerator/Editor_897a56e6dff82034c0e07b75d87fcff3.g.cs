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

namespace UnoEditor.Shared.Views
{
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	public partial class Editor : Windows.UI.Xaml.Controls.UserControl
	{
		private void InitializeComponent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			IsParsing = true
			;
			// Source ..\..\..\..\..\..\..\UnoEditor.Shared\Views\Editor.xaml (Line 1:2)
			Content = 
			new global::Windows.UI.Xaml.Controls.ListView
			{
				IsParsing = true
				,
				ItemTemplate = 				new global::Windows.UI.Xaml.DataTemplate(() => 				new _Editor_897a56e6dff82034c0e07b75d87fcff3_UnoEditorSharedViewsEditorSC0().Build()
				)				,
				// Source ..\..\..\..\..\..\..\UnoEditor.Shared\Views\Editor.xaml (Line 12:4)
			}
			.Editor_897a56e6dff82034c0e07b75d87fcff3_XamlApply((Editor_897a56e6dff82034c0e07b75d87fcff3XamlApplyExtensions.XamlApplyHandler0)(c0 => 
			{
				c0.SetBinding(global::Windows.UI.Xaml.Controls.ListView.ItemsSourceProperty, new Windows.UI.Xaml.Data.Binding{ Mode = BindingMode.OneTime }.Apply(___b =>  /*defaultBindModeOneTime*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::UnoEditor.Shared.Views.Editor ___tctx ? (object)(___tctx.filetextlines) : null, null )));
								this._component_0 = c0;
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c0, "file:///E:/Reposs/UnoEditor/UnoEditor/UnoEditor.Shared/Views/Editor.xaml");
				c0.CreationComplete();
			}
			))
			;
			
			this
			.Apply((c1 => 
			{
				// Source E:\Reposs\UnoEditor\UnoEditor\UnoEditor.Shared\Views\Editor.xaml (Line 1:2)
				
				// WARNING Property c1.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}UserControl, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			.Apply((c2 => 
			{
				// Class UnoEditor.Shared.Views.Editor
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c2, "file:///E:/Reposs/UnoEditor/UnoEditor/UnoEditor.Shared/Views/Editor.xaml");
				c2.CreationComplete();
			}
			))
			;
			OnInitializeCompleted();
			InitializeXamlOwner();
			Bindings = new Editor_Bindings(this);
			Loading += delegate
			{
				Bindings.Update();
				_component_0.UpdateResourceBindings();
			}
			;
		}
		partial void OnInitializeCompleted();
		private class _Editor_897a56e6dff82034c0e07b75d87fcff3_UnoEditorSharedViewsEditorSC0
		{
			public _View Build()
			{
				var nameScope = new global::Windows.UI.Xaml.NameScope();
				_View __rootInstance = null;
				__rootInstance = 
				new global::Windows.UI.Xaml.Controls.TextBlock
				{
					IsParsing = true
					,
					Width = *d/* double/, *, TextBlock/Width */,
					// Source ..\..\..\..\..\..\..\UnoEditor.Shared\Views\Editor.xaml (Line 15:10)
				}
				.Editor_897a56e6dff82034c0e07b75d87fcff3_XamlApply((Editor_897a56e6dff82034c0e07b75d87fcff3XamlApplyExtensions.XamlApplyHandler1)(c3 => 
				{
					c3.SetBinding(global::Windows.UI.Xaml.Controls.TextBlock.TextProperty, new Windows.UI.Xaml.Data.Binding{ Mode = BindingMode.OneTime }.Apply(___b => /*defaultBindModeOneTime*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, null, ___ctx => ___ctx is global::System.String ___tctx ? (object)(___tctx) : null, null )));
										this._component_0 = c3;
					global::Uno.UI.FrameworkElementHelper.SetBaseUri(c3, "file:///E:/Reposs/UnoEditor/UnoEditor/UnoEditor.Shared/Views/Editor.xaml");
					c3.CreationComplete();
				}
				))
				;
				if (__rootInstance is FrameworkElement __fe) 
				{
					__fe.Loading += delegate
					{
						_component_0.UpdateResourceBindings();
					}
					;
				}
				if (__rootInstance is DependencyObject d) Windows.UI.Xaml.NameScope.SetNameScope(d, nameScope);
				return __rootInstance;
			}
			private global::Windows.UI.Xaml.Controls.TextBlock _component_0;
		}
		private global::Windows.UI.Xaml.Controls.ListView _component_0;
		private interface IEditor_Bindings
		{
			void Initialize();
			void Update();
			void StopTracking();
		}
		#pragma warning disable 0169 //  Suppress unused field warning in case Bindings is not used.
		private IEditor_Bindings Bindings;
		#pragma warning restore 0169
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		private class Editor_Bindings : IEditor_Bindings
		{
			#if UNO_HAS_UIELEMENT_IMPLICIT_PINNING
			private global::System.WeakReference _ownerReference;
			private Editor Owner { get => (Editor)_ownerReference?.Target; set => _ownerReference = new global::System.WeakReference(value); }
			#else
			private Editor Owner { get; set; }
			#endif
			public Editor_Bindings(Editor owner)
			{
				Owner = owner;
			}
			void IEditor_Bindings.Initialize()
			{
			}
			void IEditor_Bindings.Update()
			{
				var owner = Owner;
				owner._component_0.ApplyXBind();
			}
			void IEditor_Bindings.StopTracking()
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
	static class Editor_897a56e6dff82034c0e07b75d87fcff3XamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.ListView instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.ListView Editor_897a56e6dff82034c0e07b75d87fcff3_XamlApply(this global::Windows.UI.Xaml.Controls.ListView instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.TextBlock instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.TextBlock Editor_897a56e6dff82034c0e07b75d87fcff3_XamlApply(this global::Windows.UI.Xaml.Controls.TextBlock instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
