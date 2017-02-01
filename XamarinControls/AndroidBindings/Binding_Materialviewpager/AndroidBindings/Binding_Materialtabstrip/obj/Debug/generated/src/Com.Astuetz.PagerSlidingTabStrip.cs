using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Astuetz {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']"
	[global::Android.Runtime.Register ("com/astuetz/PagerSlidingTabStrip", DoNotGenerateAcw=true)]
	public partial class PagerSlidingTabStrip : global::Android.Widget.HorizontalScrollView {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/field[@name='DEF_VALUE_TAB_TEXT_ALPHA']"
		[Register ("DEF_VALUE_TAB_TEXT_ALPHA")]
		public const int DefValueTabTextAlpha = (int) 150;

		static IntPtr mDelegatePageListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/field[@name='mDelegatePageListener']"
		[Register ("mDelegatePageListener")]
		public global::Android.Support.V4.View.ViewPager.IOnPageChangeListener MDelegatePageListener {
			get {
				if (mDelegatePageListener_jfieldId == IntPtr.Zero)
					mDelegatePageListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mDelegatePageListener", "Landroid/support/v4/view/ViewPager$OnPageChangeListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mDelegatePageListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager.IOnPageChangeListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDelegatePageListener_jfieldId == IntPtr.Zero)
					mDelegatePageListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mDelegatePageListener", "Landroid/support/v4/view/ViewPager$OnPageChangeListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mDelegatePageListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.astuetz']/interface[@name='PagerSlidingTabStrip.CustomTabProvider']"
		[Register ("com/astuetz/PagerSlidingTabStrip$CustomTabProvider", "", "Com.Astuetz.PagerSlidingTabStrip/ICustomTabProviderInvoker")]
		public partial interface ICustomTabProvider : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/interface[@name='PagerSlidingTabStrip.CustomTabProvider']/method[@name='getCustomTabView' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
			[Register ("getCustomTabView", "(Landroid/view/ViewGroup;I)Landroid/view/View;", "GetGetCustomTabView_Landroid_view_ViewGroup_IHandler:Com.Astuetz.PagerSlidingTabStrip/ICustomTabProviderInvoker, Binding_Materialtabstrip")]
			global::Android.Views.View GetCustomTabView (global::Android.Views.ViewGroup p0, int p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/interface[@name='PagerSlidingTabStrip.CustomTabProvider']/method[@name='tabSelected' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("tabSelected", "(Landroid/view/View;)V", "GetTabSelected_Landroid_view_View_Handler:Com.Astuetz.PagerSlidingTabStrip/ICustomTabProviderInvoker, Binding_Materialtabstrip")]
			void TabSelected (global::Android.Views.View p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/interface[@name='PagerSlidingTabStrip.CustomTabProvider']/method[@name='tabUnselected' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("tabUnselected", "(Landroid/view/View;)V", "GetTabUnselected_Landroid_view_View_Handler:Com.Astuetz.PagerSlidingTabStrip/ICustomTabProviderInvoker, Binding_Materialtabstrip")]
			void TabUnselected (global::Android.Views.View p0);

		}

		[global::Android.Runtime.Register ("com/astuetz/PagerSlidingTabStrip$CustomTabProvider", DoNotGenerateAcw=true)]
		internal class ICustomTabProviderInvoker : global::Java.Lang.Object, ICustomTabProvider {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/astuetz/PagerSlidingTabStrip$CustomTabProvider");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICustomTabProviderInvoker); }
			}

			IntPtr class_ref;

			public static ICustomTabProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICustomTabProvider> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.astuetz.PagerSlidingTabStrip.CustomTabProvider"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICustomTabProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getCustomTabView_Landroid_view_ViewGroup_I;
#pragma warning disable 0169
			static Delegate GetGetCustomTabView_Landroid_view_ViewGroup_IHandler ()
			{
				if (cb_getCustomTabView_Landroid_view_ViewGroup_I == null)
					cb_getCustomTabView_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetCustomTabView_Landroid_view_ViewGroup_I);
				return cb_getCustomTabView_Landroid_view_ViewGroup_I;
			}

			static IntPtr n_GetCustomTabView_Landroid_view_ViewGroup_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Com.Astuetz.PagerSlidingTabStrip.ICustomTabProvider __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip.ICustomTabProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCustomTabView (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getCustomTabView_Landroid_view_ViewGroup_I;
			public unsafe global::Android.Views.View GetCustomTabView (global::Android.Views.ViewGroup p0, int p1)
			{
				if (id_getCustomTabView_Landroid_view_ViewGroup_I == IntPtr.Zero)
					id_getCustomTabView_Landroid_view_ViewGroup_I = JNIEnv.GetMethodID (class_ref, "getCustomTabView", "(Landroid/view/ViewGroup;I)Landroid/view/View;");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustomTabView_Landroid_view_ViewGroup_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_tabSelected_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetTabSelected_Landroid_view_View_Handler ()
			{
				if (cb_tabSelected_Landroid_view_View_ == null)
					cb_tabSelected_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TabSelected_Landroid_view_View_);
				return cb_tabSelected_Landroid_view_View_;
			}

			static void n_TabSelected_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Astuetz.PagerSlidingTabStrip.ICustomTabProvider __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip.ICustomTabProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.TabSelected (p0);
			}
#pragma warning restore 0169

			IntPtr id_tabSelected_Landroid_view_View_;
			public unsafe void TabSelected (global::Android.Views.View p0)
			{
				if (id_tabSelected_Landroid_view_View_ == IntPtr.Zero)
					id_tabSelected_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "tabSelected", "(Landroid/view/View;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_tabSelected_Landroid_view_View_, __args);
			}

			static Delegate cb_tabUnselected_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetTabUnselected_Landroid_view_View_Handler ()
			{
				if (cb_tabUnselected_Landroid_view_View_ == null)
					cb_tabUnselected_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TabUnselected_Landroid_view_View_);
				return cb_tabUnselected_Landroid_view_View_;
			}

			static void n_TabUnselected_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Astuetz.PagerSlidingTabStrip.ICustomTabProvider __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip.ICustomTabProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.TabUnselected (p0);
			}
#pragma warning restore 0169

			IntPtr id_tabUnselected_Landroid_view_View_;
			public unsafe void TabUnselected (global::Android.Views.View p0)
			{
				if (id_tabUnselected_Landroid_view_View_ == IntPtr.Zero)
					id_tabUnselected_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "tabUnselected", "(Landroid/view/View;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_tabUnselected_Landroid_view_View_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.astuetz']/interface[@name='PagerSlidingTabStrip.OnTabReselectedListener']"
		[Register ("com/astuetz/PagerSlidingTabStrip$OnTabReselectedListener", "", "Com.Astuetz.PagerSlidingTabStrip/IOnTabReselectedListenerInvoker")]
		public partial interface IOnTabReselectedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/interface[@name='PagerSlidingTabStrip.OnTabReselectedListener']/method[@name='onTabReselected' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onTabReselected", "(I)V", "GetOnTabReselected_IHandler:Com.Astuetz.PagerSlidingTabStrip/IOnTabReselectedListenerInvoker, Binding_Materialtabstrip")]
			void OnTabReselected (int p0);

		}

		[global::Android.Runtime.Register ("com/astuetz/PagerSlidingTabStrip$OnTabReselectedListener", DoNotGenerateAcw=true)]
		internal class IOnTabReselectedListenerInvoker : global::Java.Lang.Object, IOnTabReselectedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/astuetz/PagerSlidingTabStrip$OnTabReselectedListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnTabReselectedListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnTabReselectedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnTabReselectedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.astuetz.PagerSlidingTabStrip.OnTabReselectedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnTabReselectedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onTabReselected_I;
#pragma warning disable 0169
			static Delegate GetOnTabReselected_IHandler ()
			{
				if (cb_onTabReselected_I == null)
					cb_onTabReselected_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnTabReselected_I);
				return cb_onTabReselected_I;
			}

			static void n_OnTabReselected_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Astuetz.PagerSlidingTabStrip.IOnTabReselectedListener __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip.IOnTabReselectedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTabReselected (p0);
			}
#pragma warning restore 0169

			IntPtr id_onTabReselected_I;
			public unsafe void OnTabReselected (int p0)
			{
				if (id_onTabReselected_I == IntPtr.Zero)
					id_onTabReselected_I = JNIEnv.GetMethodID (class_ref, "onTabReselected", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTabReselected_I, __args);
			}

		}

		public partial class TabReselectedEventArgs : global::System.EventArgs {

			public TabReselectedEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/astuetz/PagerSlidingTabStrip_OnTabReselectedListenerImplementor")]
		internal sealed partial class IOnTabReselectedListenerImplementor : global::Java.Lang.Object, IOnTabReselectedListener {

			object sender;

			public IOnTabReselectedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/astuetz/PagerSlidingTabStrip_OnTabReselectedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<TabReselectedEventArgs> Handler;
#pragma warning restore 0649

			public void OnTabReselected (int p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new TabReselectedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnTabReselectedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip.PageListener']"
		[global::Android.Runtime.Register ("com/astuetz/PagerSlidingTabStrip$PageListener", DoNotGenerateAcw=true)]
		public partial class PageListener : global::Java.Lang.Object, global::Android.Support.V4.View.ViewPager.IOnPageChangeListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/astuetz/PagerSlidingTabStrip$PageListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PageListener); }
			}

			protected PageListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onPageScrollStateChanged_I;
#pragma warning disable 0169
			static Delegate GetOnPageScrollStateChanged_IHandler ()
			{
				if (cb_onPageScrollStateChanged_I == null)
					cb_onPageScrollStateChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPageScrollStateChanged_I);
				return cb_onPageScrollStateChanged_I;
			}

			static void n_OnPageScrollStateChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Astuetz.PagerSlidingTabStrip.PageListener __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip.PageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPageScrollStateChanged (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPageScrollStateChanged_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip.PageListener']/method[@name='onPageScrollStateChanged' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onPageScrollStateChanged", "(I)V", "GetOnPageScrollStateChanged_IHandler")]
			public virtual unsafe void OnPageScrollStateChanged (int p0)
			{
				if (id_onPageScrollStateChanged_I == IntPtr.Zero)
					id_onPageScrollStateChanged_I = JNIEnv.GetMethodID (class_ref, "onPageScrollStateChanged", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPageScrollStateChanged_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPageScrollStateChanged", "(I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onPageScrolled_IFI;
#pragma warning disable 0169
			static Delegate GetOnPageScrolled_IFIHandler ()
			{
				if (cb_onPageScrolled_IFI == null)
					cb_onPageScrolled_IFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, float, int>) n_OnPageScrolled_IFI);
				return cb_onPageScrolled_IFI;
			}

			static void n_OnPageScrolled_IFI (IntPtr jnienv, IntPtr native__this, int p0, float p1, int p2)
			{
				global::Com.Astuetz.PagerSlidingTabStrip.PageListener __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip.PageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPageScrolled (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onPageScrolled_IFI;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip.PageListener']/method[@name='onPageScrolled' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
			[Register ("onPageScrolled", "(IFI)V", "GetOnPageScrolled_IFIHandler")]
			public virtual unsafe void OnPageScrolled (int p0, float p1, int p2)
			{
				if (id_onPageScrolled_IFI == IntPtr.Zero)
					id_onPageScrolled_IFI = JNIEnv.GetMethodID (class_ref, "onPageScrolled", "(IFI)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPageScrolled_IFI, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPageScrolled", "(IFI)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onPageSelected_I;
#pragma warning disable 0169
			static Delegate GetOnPageSelected_IHandler ()
			{
				if (cb_onPageSelected_I == null)
					cb_onPageSelected_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPageSelected_I);
				return cb_onPageSelected_I;
			}

			static void n_OnPageSelected_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Astuetz.PagerSlidingTabStrip.PageListener __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip.PageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPageSelected (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPageSelected_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip.PageListener']/method[@name='onPageSelected' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onPageSelected", "(I)V", "GetOnPageSelected_IHandler")]
			public virtual unsafe void OnPageSelected (int p0)
			{
				if (id_onPageSelected_I == IntPtr.Zero)
					id_onPageSelected_I = JNIEnv.GetMethodID (class_ref, "onPageSelected", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPageSelected_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPageSelected", "(I)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip.PagerAdapterObserver']"
		[global::Android.Runtime.Register ("com/astuetz/PagerSlidingTabStrip$PagerAdapterObserver", DoNotGenerateAcw=true)]
		public partial class PagerAdapterObserver : global::Android.Database.DataSetObserver {

			protected PagerAdapterObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip.SavedState']"
		[global::Android.Runtime.Register ("com/astuetz/PagerSlidingTabStrip$SavedState", DoNotGenerateAcw=true)]
		public partial class SavedState : global::Android.Views.View.BaseSavedState {


			static IntPtr CREATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip.SavedState']/field[@name='CREATOR']"
			[Register ("CREATOR")]
			public static global::Android.OS.IParcelableCreator Creator {
				get {
					if (CREATOR_jfieldId == IntPtr.Zero)
						CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/astuetz/PagerSlidingTabStrip$SavedState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SavedState); }
			}

			protected SavedState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/astuetz/PagerSlidingTabStrip", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PagerSlidingTabStrip); }
		}

		protected PagerSlidingTabStrip (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/constructor[@name='PagerSlidingTabStrip' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe PagerSlidingTabStrip (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (PagerSlidingTabStrip)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/constructor[@name='PagerSlidingTabStrip' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe PagerSlidingTabStrip (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (PagerSlidingTabStrip)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/constructor[@name='PagerSlidingTabStrip' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PagerSlidingTabStrip (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (PagerSlidingTabStrip)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getCurrentPosition;
#pragma warning disable 0169
		static Delegate GetGetCurrentPositionHandler ()
		{
			if (cb_getCurrentPosition == null)
				cb_getCurrentPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentPosition);
			return cb_getCurrentPosition;
		}

		static int n_GetCurrentPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentPosition;
		public virtual unsafe int CurrentPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='getCurrentPosition' and count(parameter)=0]"
			[Register ("getCurrentPosition", "()I", "GetGetCurrentPositionHandler")]
			get {
				if (id_getCurrentPosition == IntPtr.Zero)
					id_getCurrentPosition = JNIEnv.GetMethodID (class_ref, "getCurrentPosition", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentPosition", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentPositionOffset;
#pragma warning disable 0169
		static Delegate GetGetCurrentPositionOffsetHandler ()
		{
			if (cb_getCurrentPositionOffset == null)
				cb_getCurrentPositionOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetCurrentPositionOffset);
			return cb_getCurrentPositionOffset;
		}

		static float n_GetCurrentPositionOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPositionOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentPositionOffset;
		public virtual unsafe float CurrentPositionOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='getCurrentPositionOffset' and count(parameter)=0]"
			[Register ("getCurrentPositionOffset", "()F", "GetGetCurrentPositionOffsetHandler")]
			get {
				if (id_getCurrentPositionOffset == IntPtr.Zero)
					id_getCurrentPositionOffset = JNIEnv.GetMethodID (class_ref, "getCurrentPositionOffset", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentPositionOffset);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentPositionOffset", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_getDividerColor;
#pragma warning disable 0169
		static Delegate GetGetDividerColorHandler ()
		{
			if (cb_getDividerColor == null)
				cb_getDividerColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDividerColor);
			return cb_getDividerColor;
		}

		static int n_GetDividerColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DividerColor;
		}
#pragma warning restore 0169

		static Delegate cb_setDividerColor_I;
#pragma warning disable 0169
		static Delegate GetSetDividerColor_IHandler ()
		{
			if (cb_setDividerColor_I == null)
				cb_setDividerColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDividerColor_I);
			return cb_setDividerColor_I;
		}

		static void n_SetDividerColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DividerColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDividerColor;
		static IntPtr id_setDividerColor_I;
		public virtual unsafe int DividerColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='getDividerColor' and count(parameter)=0]"
			[Register ("getDividerColor", "()I", "GetGetDividerColorHandler")]
			get {
				if (id_getDividerColor == IntPtr.Zero)
					id_getDividerColor = JNIEnv.GetMethodID (class_ref, "getDividerColor", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDividerColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDividerColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setDividerColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDividerColor", "(I)V", "GetSetDividerColor_IHandler")]
			set {
				if (id_setDividerColor_I == IntPtr.Zero)
					id_setDividerColor_I = JNIEnv.GetMethodID (class_ref, "setDividerColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDividerColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDividerColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDividerPadding;
#pragma warning disable 0169
		static Delegate GetGetDividerPaddingHandler ()
		{
			if (cb_getDividerPadding == null)
				cb_getDividerPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDividerPadding);
			return cb_getDividerPadding;
		}

		static int n_GetDividerPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DividerPadding;
		}
#pragma warning restore 0169

		static Delegate cb_setDividerPadding_I;
#pragma warning disable 0169
		static Delegate GetSetDividerPadding_IHandler ()
		{
			if (cb_setDividerPadding_I == null)
				cb_setDividerPadding_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDividerPadding_I);
			return cb_setDividerPadding_I;
		}

		static void n_SetDividerPadding_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DividerPadding = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDividerPadding;
		static IntPtr id_setDividerPadding_I;
		public virtual unsafe int DividerPadding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='getDividerPadding' and count(parameter)=0]"
			[Register ("getDividerPadding", "()I", "GetGetDividerPaddingHandler")]
			get {
				if (id_getDividerPadding == IntPtr.Zero)
					id_getDividerPadding = JNIEnv.GetMethodID (class_ref, "getDividerPadding", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDividerPadding);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDividerPadding", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setDividerPadding' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDividerPadding", "(I)V", "GetSetDividerPadding_IHandler")]
			set {
				if (id_setDividerPadding_I == IntPtr.Zero)
					id_setDividerPadding_I = JNIEnv.GetMethodID (class_ref, "setDividerPadding", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDividerPadding_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDividerPadding", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDividerWidth;
#pragma warning disable 0169
		static Delegate GetGetDividerWidthHandler ()
		{
			if (cb_getDividerWidth == null)
				cb_getDividerWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDividerWidth);
			return cb_getDividerWidth;
		}

		static int n_GetDividerWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DividerWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setDividerWidth_I;
#pragma warning disable 0169
		static Delegate GetSetDividerWidth_IHandler ()
		{
			if (cb_setDividerWidth_I == null)
				cb_setDividerWidth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDividerWidth_I);
			return cb_setDividerWidth_I;
		}

		static void n_SetDividerWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DividerWidth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDividerWidth;
		static IntPtr id_setDividerWidth_I;
		public virtual unsafe int DividerWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='getDividerWidth' and count(parameter)=0]"
			[Register ("getDividerWidth", "()I", "GetGetDividerWidthHandler")]
			get {
				if (id_getDividerWidth == IntPtr.Zero)
					id_getDividerWidth = JNIEnv.GetMethodID (class_ref, "getDividerWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDividerWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDividerWidth", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setDividerWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDividerWidth", "(I)V", "GetSetDividerWidth_IHandler")]
			set {
				if (id_setDividerWidth_I == IntPtr.Zero)
					id_setDividerWidth_I = JNIEnv.GetMethodID (class_ref, "setDividerWidth", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDividerWidth_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDividerWidth", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIndicatorColor;
#pragma warning disable 0169
		static Delegate GetGetIndicatorColorHandler ()
		{
			if (cb_getIndicatorColor == null)
				cb_getIndicatorColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndicatorColor);
			return cb_getIndicatorColor;
		}

		static int n_GetIndicatorColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndicatorColor;
		}
#pragma warning restore 0169

		static Delegate cb_setIndicatorColor_I;
#pragma warning disable 0169
		static Delegate GetSetIndicatorColor_IHandler ()
		{
			if (cb_setIndicatorColor_I == null)
				cb_setIndicatorColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIndicatorColor_I);
			return cb_setIndicatorColor_I;
		}

		static void n_SetIndicatorColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IndicatorColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIndicatorColor;
		static IntPtr id_setIndicatorColor_I;
		public virtual unsafe int IndicatorColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='getIndicatorColor' and count(parameter)=0]"
			[Register ("getIndicatorColor", "()I", "GetGetIndicatorColorHandler")]
			get {
				if (id_getIndicatorColor == IntPtr.Zero)
					id_getIndicatorColor = JNIEnv.GetMethodID (class_ref, "getIndicatorColor", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndicatorColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndicatorColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setIndicatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIndicatorColor", "(I)V", "GetSetIndicatorColor_IHandler")]
			set {
				if (id_setIndicatorColor_I == IntPtr.Zero)
					id_setIndicatorColor_I = JNIEnv.GetMethodID (class_ref, "setIndicatorColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIndicatorColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIndicatorColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIndicatorCoordinates;
#pragma warning disable 0169
		static Delegate GetGetIndicatorCoordinatesHandler ()
		{
			if (cb_getIndicatorCoordinates == null)
				cb_getIndicatorCoordinates = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIndicatorCoordinates);
			return cb_getIndicatorCoordinates;
		}

		static IntPtr n_GetIndicatorCoordinates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IndicatorCoordinates);
		}
#pragma warning restore 0169

		static IntPtr id_getIndicatorCoordinates;
		public virtual unsafe global::Android.Support.V4.Util.Pair IndicatorCoordinates {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='getIndicatorCoordinates' and count(parameter)=0]"
			[Register ("getIndicatorCoordinates", "()Landroid/support/v4/util/Pair;", "GetGetIndicatorCoordinatesHandler")]
			get {
				if (id_getIndicatorCoordinates == IntPtr.Zero)
					id_getIndicatorCoordinates = JNIEnv.GetMethodID (class_ref, "getIndicatorCoordinates", "()Landroid/support/v4/util/Pair;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V4.Util.Pair> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIndicatorCoordinates), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V4.Util.Pair> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndicatorCoordinates", "()Landroid/support/v4/util/Pair;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIndicatorHeight;
#pragma warning disable 0169
		static Delegate GetGetIndicatorHeightHandler ()
		{
			if (cb_getIndicatorHeight == null)
				cb_getIndicatorHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndicatorHeight);
			return cb_getIndicatorHeight;
		}

		static int n_GetIndicatorHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndicatorHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setIndicatorHeight_I;
#pragma warning disable 0169
		static Delegate GetSetIndicatorHeight_IHandler ()
		{
			if (cb_setIndicatorHeight_I == null)
				cb_setIndicatorHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIndicatorHeight_I);
			return cb_setIndicatorHeight_I;
		}

		static void n_SetIndicatorHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IndicatorHeight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIndicatorHeight;
		static IntPtr id_setIndicatorHeight_I;
		public virtual unsafe int IndicatorHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='getIndicatorHeight' and count(parameter)=0]"
			[Register ("getIndicatorHeight", "()I", "GetGetIndicatorHeightHandler")]
			get {
				if (id_getIndicatorHeight == IntPtr.Zero)
					id_getIndicatorHeight = JNIEnv.GetMethodID (class_ref, "getIndicatorHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndicatorHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndicatorHeight", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setIndicatorHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIndicatorHeight", "(I)V", "GetSetIndicatorHeight_IHandler")]
			set {
				if (id_setIndicatorHeight_I == IntPtr.Zero)
					id_setIndicatorHeight_I = JNIEnv.GetMethodID (class_ref, "setIndicatorHeight", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIndicatorHeight_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIndicatorHeight", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isTextAllCaps;
#pragma warning disable 0169
		static Delegate GetIsTextAllCapsHandler ()
		{
			if (cb_isTextAllCaps == null)
				cb_isTextAllCaps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTextAllCaps);
			return cb_isTextAllCaps;
		}

		static bool n_IsTextAllCaps (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTextAllCaps;
		}
#pragma warning restore 0169

		static IntPtr id_isTextAllCaps;
		public virtual unsafe bool IsTextAllCaps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='isTextAllCaps' and count(parameter)=0]"
			[Register ("isTextAllCaps", "()Z", "GetIsTextAllCapsHandler")]
			get {
				if (id_isTextAllCaps == IntPtr.Zero)
					id_isTextAllCaps = JNIEnv.GetMethodID (class_ref, "isTextAllCaps", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTextAllCaps);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTextAllCaps", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getScrollOffset;
#pragma warning disable 0169
		static Delegate GetGetScrollOffsetHandler ()
		{
			if (cb_getScrollOffset == null)
				cb_getScrollOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScrollOffset);
			return cb_getScrollOffset;
		}

		static int n_GetScrollOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScrollOffset;
		}
#pragma warning restore 0169

		static Delegate cb_setScrollOffset_I;
#pragma warning disable 0169
		static Delegate GetSetScrollOffset_IHandler ()
		{
			if (cb_setScrollOffset_I == null)
				cb_setScrollOffset_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetScrollOffset_I);
			return cb_setScrollOffset_I;
		}

		static void n_SetScrollOffset_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollOffset = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getScrollOffset;
		static IntPtr id_setScrollOffset_I;
		public virtual unsafe int ScrollOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='getScrollOffset' and count(parameter)=0]"
			[Register ("getScrollOffset", "()I", "GetGetScrollOffsetHandler")]
			get {
				if (id_getScrollOffset == IntPtr.Zero)
					id_getScrollOffset = JNIEnv.GetMethodID (class_ref, "getScrollOffset", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getScrollOffset);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScrollOffset", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setScrollOffset' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setScrollOffset", "(I)V", "GetSetScrollOffset_IHandler")]
			set {
				if (id_setScrollOffset_I == IntPtr.Zero)
					id_setScrollOffset_I = JNIEnv.GetMethodID (class_ref, "setScrollOffset", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScrollOffset_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScrollOffset", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShouldExpand;
#pragma warning disable 0169
		static Delegate GetGetShouldExpandHandler ()
		{
			if (cb_getShouldExpand == null)
				cb_getShouldExpand = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetShouldExpand);
			return cb_getShouldExpand;
		}

		static bool n_GetShouldExpand (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldExpand;
		}
#pragma warning restore 0169

		static Delegate cb_setShouldExpand_Z;
#pragma warning disable 0169
		static Delegate GetSetShouldExpand_ZHandler ()
		{
			if (cb_setShouldExpand_Z == null)
				cb_setShouldExpand_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShouldExpand_Z);
			return cb_setShouldExpand_Z;
		}

		static void n_SetShouldExpand_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShouldExpand = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getShouldExpand;
		static IntPtr id_setShouldExpand_Z;
		public virtual unsafe bool ShouldExpand {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='getShouldExpand' and count(parameter)=0]"
			[Register ("getShouldExpand", "()Z", "GetGetShouldExpandHandler")]
			get {
				if (id_getShouldExpand == IntPtr.Zero)
					id_getShouldExpand = JNIEnv.GetMethodID (class_ref, "getShouldExpand", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getShouldExpand);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShouldExpand", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setShouldExpand' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShouldExpand", "(Z)V", "GetSetShouldExpand_ZHandler")]
			set {
				if (id_setShouldExpand_Z == IntPtr.Zero)
					id_setShouldExpand_Z = JNIEnv.GetMethodID (class_ref, "setShouldExpand", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShouldExpand_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldExpand", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTabBackground;
#pragma warning disable 0169
		static Delegate GetGetTabBackgroundHandler ()
		{
			if (cb_getTabBackground == null)
				cb_getTabBackground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTabBackground);
			return cb_getTabBackground;
		}

		static int n_GetTabBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TabBackground;
		}
#pragma warning restore 0169

		static Delegate cb_setTabBackground_I;
#pragma warning disable 0169
		static Delegate GetSetTabBackground_IHandler ()
		{
			if (cb_setTabBackground_I == null)
				cb_setTabBackground_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTabBackground_I);
			return cb_setTabBackground_I;
		}

		static void n_SetTabBackground_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TabBackground = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTabBackground;
		static IntPtr id_setTabBackground_I;
		public virtual unsafe int TabBackground {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='getTabBackground' and count(parameter)=0]"
			[Register ("getTabBackground", "()I", "GetGetTabBackgroundHandler")]
			get {
				if (id_getTabBackground == IntPtr.Zero)
					id_getTabBackground = JNIEnv.GetMethodID (class_ref, "getTabBackground", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTabBackground);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTabBackground", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setTabBackground' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTabBackground", "(I)V", "GetSetTabBackground_IHandler")]
			set {
				if (id_setTabBackground_I == IntPtr.Zero)
					id_setTabBackground_I = JNIEnv.GetMethodID (class_ref, "setTabBackground", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTabBackground_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTabBackground", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTabCount;
#pragma warning disable 0169
		static Delegate GetGetTabCountHandler ()
		{
			if (cb_getTabCount == null)
				cb_getTabCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTabCount);
			return cb_getTabCount;
		}

		static int n_GetTabCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TabCount;
		}
#pragma warning restore 0169

		static IntPtr id_getTabCount;
		public virtual unsafe int TabCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='getTabCount' and count(parameter)=0]"
			[Register ("getTabCount", "()I", "GetGetTabCountHandler")]
			get {
				if (id_getTabCount == IntPtr.Zero)
					id_getTabCount = JNIEnv.GetMethodID (class_ref, "getTabCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTabCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTabCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTabPaddingLeftRight;
#pragma warning disable 0169
		static Delegate GetGetTabPaddingLeftRightHandler ()
		{
			if (cb_getTabPaddingLeftRight == null)
				cb_getTabPaddingLeftRight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTabPaddingLeftRight);
			return cb_getTabPaddingLeftRight;
		}

		static int n_GetTabPaddingLeftRight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TabPaddingLeftRight;
		}
#pragma warning restore 0169

		static Delegate cb_setTabPaddingLeftRight_I;
#pragma warning disable 0169
		static Delegate GetSetTabPaddingLeftRight_IHandler ()
		{
			if (cb_setTabPaddingLeftRight_I == null)
				cb_setTabPaddingLeftRight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTabPaddingLeftRight_I);
			return cb_setTabPaddingLeftRight_I;
		}

		static void n_SetTabPaddingLeftRight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TabPaddingLeftRight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTabPaddingLeftRight;
		static IntPtr id_setTabPaddingLeftRight_I;
		public virtual unsafe int TabPaddingLeftRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='getTabPaddingLeftRight' and count(parameter)=0]"
			[Register ("getTabPaddingLeftRight", "()I", "GetGetTabPaddingLeftRightHandler")]
			get {
				if (id_getTabPaddingLeftRight == IntPtr.Zero)
					id_getTabPaddingLeftRight = JNIEnv.GetMethodID (class_ref, "getTabPaddingLeftRight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTabPaddingLeftRight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTabPaddingLeftRight", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setTabPaddingLeftRight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTabPaddingLeftRight", "(I)V", "GetSetTabPaddingLeftRight_IHandler")]
			set {
				if (id_setTabPaddingLeftRight_I == IntPtr.Zero)
					id_setTabPaddingLeftRight_I = JNIEnv.GetMethodID (class_ref, "setTabPaddingLeftRight", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTabPaddingLeftRight_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTabPaddingLeftRight", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTabsContainer;
#pragma warning disable 0169
		static Delegate GetGetTabsContainerHandler ()
		{
			if (cb_getTabsContainer == null)
				cb_getTabsContainer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTabsContainer);
			return cb_getTabsContainer;
		}

		static IntPtr n_GetTabsContainer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TabsContainer);
		}
#pragma warning restore 0169

		static IntPtr id_getTabsContainer;
		public virtual unsafe global::Android.Widget.LinearLayout TabsContainer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='getTabsContainer' and count(parameter)=0]"
			[Register ("getTabsContainer", "()Landroid/widget/LinearLayout;", "GetGetTabsContainerHandler")]
			get {
				if (id_getTabsContainer == IntPtr.Zero)
					id_getTabsContainer = JNIEnv.GetMethodID (class_ref, "getTabsContainer", "()Landroid/widget/LinearLayout;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.LinearLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTabsContainer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.LinearLayout> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTabsContainer", "()Landroid/widget/LinearLayout;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextColor;
#pragma warning disable 0169
		static Delegate GetGetTextColorHandler ()
		{
			if (cb_getTextColor == null)
				cb_getTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextColor);
			return cb_getTextColor;
		}

		static IntPtr n_GetTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextColor);
		}
#pragma warning restore 0169

		static Delegate cb_setTextColor_Landroid_content_res_ColorStateList_;
#pragma warning disable 0169
		static Delegate GetSetTextColor_Landroid_content_res_ColorStateList_Handler ()
		{
			if (cb_setTextColor_Landroid_content_res_ColorStateList_ == null)
				cb_setTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextColor_Landroid_content_res_ColorStateList_);
			return cb_setTextColor_Landroid_content_res_ColorStateList_;
		}

		static void n_SetTextColor_Landroid_content_res_ColorStateList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.ColorStateList p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TextColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTextColor;
		static IntPtr id_setTextColor_Landroid_content_res_ColorStateList_;
		public virtual unsafe global::Android.Content.Res.ColorStateList TextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='getTextColor' and count(parameter)=0]"
			[Register ("getTextColor", "()Landroid/content/res/ColorStateList;", "GetGetTextColorHandler")]
			get {
				if (id_getTextColor == IntPtr.Zero)
					id_getTextColor = JNIEnv.GetMethodID (class_ref, "getTextColor", "()Landroid/content/res/ColorStateList;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextColor", "()Landroid/content/res/ColorStateList;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
			[Register ("setTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetTextColor_Landroid_content_res_ColorStateList_Handler")]
			set {
				if (id_setTextColor_Landroid_content_res_ColorStateList_ == IntPtr.Zero)
					id_setTextColor_Landroid_content_res_ColorStateList_ = JNIEnv.GetMethodID (class_ref, "setTextColor", "(Landroid/content/res/ColorStateList;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextColor_Landroid_content_res_ColorStateList_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextColor", "(Landroid/content/res/ColorStateList;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextSize;
#pragma warning disable 0169
		static Delegate GetGetTextSizeHandler ()
		{
			if (cb_getTextSize == null)
				cb_getTextSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTextSize);
			return cb_getTextSize;
		}

		static int n_GetTextSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextSize;
		}
#pragma warning restore 0169

		static Delegate cb_setTextSize_I;
#pragma warning disable 0169
		static Delegate GetSetTextSize_IHandler ()
		{
			if (cb_setTextSize_I == null)
				cb_setTextSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTextSize_I);
			return cb_setTextSize_I;
		}

		static void n_SetTextSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTextSize;
		static IntPtr id_setTextSize_I;
		public virtual unsafe int TextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='getTextSize' and count(parameter)=0]"
			[Register ("getTextSize", "()I", "GetGetTextSizeHandler")]
			get {
				if (id_getTextSize == IntPtr.Zero)
					id_getTextSize = JNIEnv.GetMethodID (class_ref, "getTextSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTextSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setTextSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTextSize", "(I)V", "GetSetTextSize_IHandler")]
			set {
				if (id_setTextSize_I == IntPtr.Zero)
					id_setTextSize_I = JNIEnv.GetMethodID (class_ref, "setTextSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextSize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextSize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUnderlineColor;
#pragma warning disable 0169
		static Delegate GetGetUnderlineColorHandler ()
		{
			if (cb_getUnderlineColor == null)
				cb_getUnderlineColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUnderlineColor);
			return cb_getUnderlineColor;
		}

		static int n_GetUnderlineColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnderlineColor;
		}
#pragma warning restore 0169

		static Delegate cb_setUnderlineColor_I;
#pragma warning disable 0169
		static Delegate GetSetUnderlineColor_IHandler ()
		{
			if (cb_setUnderlineColor_I == null)
				cb_setUnderlineColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUnderlineColor_I);
			return cb_setUnderlineColor_I;
		}

		static void n_SetUnderlineColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnderlineColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUnderlineColor;
		static IntPtr id_setUnderlineColor_I;
		public virtual unsafe int UnderlineColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='getUnderlineColor' and count(parameter)=0]"
			[Register ("getUnderlineColor", "()I", "GetGetUnderlineColorHandler")]
			get {
				if (id_getUnderlineColor == IntPtr.Zero)
					id_getUnderlineColor = JNIEnv.GetMethodID (class_ref, "getUnderlineColor", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getUnderlineColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnderlineColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setUnderlineColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUnderlineColor", "(I)V", "GetSetUnderlineColor_IHandler")]
			set {
				if (id_setUnderlineColor_I == IntPtr.Zero)
					id_setUnderlineColor_I = JNIEnv.GetMethodID (class_ref, "setUnderlineColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUnderlineColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUnderlineColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUnderlineHeight;
#pragma warning disable 0169
		static Delegate GetGetUnderlineHeightHandler ()
		{
			if (cb_getUnderlineHeight == null)
				cb_getUnderlineHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUnderlineHeight);
			return cb_getUnderlineHeight;
		}

		static int n_GetUnderlineHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnderlineHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setUnderlineHeight_I;
#pragma warning disable 0169
		static Delegate GetSetUnderlineHeight_IHandler ()
		{
			if (cb_setUnderlineHeight_I == null)
				cb_setUnderlineHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUnderlineHeight_I);
			return cb_setUnderlineHeight_I;
		}

		static void n_SetUnderlineHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnderlineHeight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUnderlineHeight;
		static IntPtr id_setUnderlineHeight_I;
		public virtual unsafe int UnderlineHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='getUnderlineHeight' and count(parameter)=0]"
			[Register ("getUnderlineHeight", "()I", "GetGetUnderlineHeightHandler")]
			get {
				if (id_getUnderlineHeight == IntPtr.Zero)
					id_getUnderlineHeight = JNIEnv.GetMethodID (class_ref, "getUnderlineHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getUnderlineHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnderlineHeight", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setUnderlineHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUnderlineHeight", "(I)V", "GetSetUnderlineHeight_IHandler")]
			set {
				if (id_setUnderlineHeight_I == IntPtr.Zero)
					id_setUnderlineHeight_I = JNIEnv.GetMethodID (class_ref, "setUnderlineHeight", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUnderlineHeight_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUnderlineHeight", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_notifyDataSetChanged;
#pragma warning disable 0169
		static Delegate GetNotifyDataSetChangedHandler ()
		{
			if (cb_notifyDataSetChanged == null)
				cb_notifyDataSetChanged = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyDataSetChanged);
			return cb_notifyDataSetChanged;
		}

		static void n_NotifyDataSetChanged (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataSetChanged ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyDataSetChanged;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='notifyDataSetChanged' and count(parameter)=0]"
		[Register ("notifyDataSetChanged", "()V", "GetNotifyDataSetChangedHandler")]
		public virtual unsafe void NotifyDataSetChanged ()
		{
			if (id_notifyDataSetChanged == IntPtr.Zero)
				id_notifyDataSetChanged = JNIEnv.GetMethodID (class_ref, "notifyDataSetChanged", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyDataSetChanged);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyDataSetChanged", "()V"));
			} finally {
			}
		}

		static Delegate cb_onRestoreInstanceState_Landroid_os_Parcelable_;
#pragma warning disable 0169
		static Delegate GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler ()
		{
			if (cb_onRestoreInstanceState_Landroid_os_Parcelable_ == null)
				cb_onRestoreInstanceState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRestoreInstanceState_Landroid_os_Parcelable_);
			return cb_onRestoreInstanceState_Landroid_os_Parcelable_;
		}

		static void n_OnRestoreInstanceState_Landroid_os_Parcelable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IParcelable p0 = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRestoreInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRestoreInstanceState_Landroid_os_Parcelable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='onRestoreInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
		[Register ("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", "GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler")]
		public virtual unsafe void OnRestoreInstanceState (global::Android.OS.IParcelable p0)
		{
			if (id_onRestoreInstanceState_Landroid_os_Parcelable_ == IntPtr.Zero)
				id_onRestoreInstanceState_Landroid_os_Parcelable_ = JNIEnv.GetMethodID (class_ref, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRestoreInstanceState_Landroid_os_Parcelable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSaveInstanceState;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceStateHandler ()
		{
			if (cb_onSaveInstanceState == null)
				cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState);
			return cb_onSaveInstanceState;
		}

		static IntPtr n_OnSaveInstanceState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnSaveInstanceState ());
		}
#pragma warning restore 0169

		static IntPtr id_onSaveInstanceState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='onSaveInstanceState' and count(parameter)=0]"
		[Register ("onSaveInstanceState", "()Landroid/os/Parcelable;", "GetOnSaveInstanceStateHandler")]
		public virtual unsafe global::Android.OS.IParcelable OnSaveInstanceState ()
		{
			if (id_onSaveInstanceState == IntPtr.Zero)
				id_onSaveInstanceState = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onSaveInstanceState), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSaveInstanceState", "()Landroid/os/Parcelable;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAllCaps_Z;
#pragma warning disable 0169
		static Delegate GetSetAllCaps_ZHandler ()
		{
			if (cb_setAllCaps_Z == null)
				cb_setAllCaps_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAllCaps_Z);
			return cb_setAllCaps_Z;
		}

		static void n_SetAllCaps_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAllCaps (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAllCaps_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setAllCaps' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllCaps", "(Z)V", "GetSetAllCaps_ZHandler")]
		public virtual unsafe void SetAllCaps (bool p0)
		{
			if (id_setAllCaps_Z == IntPtr.Zero)
				id_setAllCaps_Z = JNIEnv.GetMethodID (class_ref, "setAllCaps", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAllCaps_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAllCaps", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDividerColorResource_I;
#pragma warning disable 0169
		static Delegate GetSetDividerColorResource_IHandler ()
		{
			if (cb_setDividerColorResource_I == null)
				cb_setDividerColorResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDividerColorResource_I);
			return cb_setDividerColorResource_I;
		}

		static void n_SetDividerColorResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDividerColorResource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDividerColorResource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setDividerColorResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDividerColorResource", "(I)V", "GetSetDividerColorResource_IHandler")]
		public virtual unsafe void SetDividerColorResource (int p0)
		{
			if (id_setDividerColorResource_I == IntPtr.Zero)
				id_setDividerColorResource_I = JNIEnv.GetMethodID (class_ref, "setDividerColorResource", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDividerColorResource_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDividerColorResource", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setIndicatorColorResource_I;
#pragma warning disable 0169
		static Delegate GetSetIndicatorColorResource_IHandler ()
		{
			if (cb_setIndicatorColorResource_I == null)
				cb_setIndicatorColorResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIndicatorColorResource_I);
			return cb_setIndicatorColorResource_I;
		}

		static void n_SetIndicatorColorResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIndicatorColorResource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIndicatorColorResource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setIndicatorColorResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIndicatorColorResource", "(I)V", "GetSetIndicatorColorResource_IHandler")]
		public virtual unsafe void SetIndicatorColorResource (int p0)
		{
			if (id_setIndicatorColorResource_I == IntPtr.Zero)
				id_setIndicatorColorResource_I = JNIEnv.GetMethodID (class_ref, "setIndicatorColorResource", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIndicatorColorResource_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIndicatorColorResource", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_Handler ()
		{
			if (cb_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_ == null)
				cb_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_);
			return cb_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_;
		}

		static void n_SetOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager.IOnPageChangeListener p0 = (global::Android.Support.V4.View.ViewPager.IOnPageChangeListener)global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager.IOnPageChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnPageChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setOnPageChangeListener' and count(parameter)=1 and parameter[1][@type='android.support.v4.view.ViewPager.OnPageChangeListener']]"
		[Register ("setOnPageChangeListener", "(Landroid/support/v4/view/ViewPager$OnPageChangeListener;)V", "GetSetOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_Handler")]
		public virtual unsafe void SetOnPageChangeListener (global::Android.Support.V4.View.ViewPager.IOnPageChangeListener p0)
		{
			if (id_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_ == IntPtr.Zero)
				id_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnPageChangeListener", "(Landroid/support/v4/view/ViewPager$OnPageChangeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnPageChangeListener", "(Landroid/support/v4/view/ViewPager$OnPageChangeListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnTabReselectedListener_Lcom_astuetz_PagerSlidingTabStrip_OnTabReselectedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnTabReselectedListener_Lcom_astuetz_PagerSlidingTabStrip_OnTabReselectedListener_Handler ()
		{
			if (cb_setOnTabReselectedListener_Lcom_astuetz_PagerSlidingTabStrip_OnTabReselectedListener_ == null)
				cb_setOnTabReselectedListener_Lcom_astuetz_PagerSlidingTabStrip_OnTabReselectedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnTabReselectedListener_Lcom_astuetz_PagerSlidingTabStrip_OnTabReselectedListener_);
			return cb_setOnTabReselectedListener_Lcom_astuetz_PagerSlidingTabStrip_OnTabReselectedListener_;
		}

		static void n_SetOnTabReselectedListener_Lcom_astuetz_PagerSlidingTabStrip_OnTabReselectedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Astuetz.PagerSlidingTabStrip.IOnTabReselectedListener p0 = (global::Com.Astuetz.PagerSlidingTabStrip.IOnTabReselectedListener)global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip.IOnTabReselectedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnTabReselectedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnTabReselectedListener_Lcom_astuetz_PagerSlidingTabStrip_OnTabReselectedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setOnTabReselectedListener' and count(parameter)=1 and parameter[1][@type='com.astuetz.PagerSlidingTabStrip.OnTabReselectedListener']]"
		[Register ("setOnTabReselectedListener", "(Lcom/astuetz/PagerSlidingTabStrip$OnTabReselectedListener;)V", "GetSetOnTabReselectedListener_Lcom_astuetz_PagerSlidingTabStrip_OnTabReselectedListener_Handler")]
		public virtual unsafe void SetOnTabReselectedListener (global::Com.Astuetz.PagerSlidingTabStrip.IOnTabReselectedListener p0)
		{
			if (id_setOnTabReselectedListener_Lcom_astuetz_PagerSlidingTabStrip_OnTabReselectedListener_ == IntPtr.Zero)
				id_setOnTabReselectedListener_Lcom_astuetz_PagerSlidingTabStrip_OnTabReselectedListener_ = JNIEnv.GetMethodID (class_ref, "setOnTabReselectedListener", "(Lcom/astuetz/PagerSlidingTabStrip$OnTabReselectedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnTabReselectedListener_Lcom_astuetz_PagerSlidingTabStrip_OnTabReselectedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnTabReselectedListener", "(Lcom/astuetz/PagerSlidingTabStrip$OnTabReselectedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetTextColor_IHandler ()
		{
			if (cb_setTextColor_I == null)
				cb_setTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTextColor_I);
			return cb_setTextColor_I;
		}

		static void n_SetTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTextColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTextColor", "(I)V", "GetSetTextColor_IHandler")]
		public virtual unsafe void SetTextColor (int p0)
		{
			if (id_setTextColor_I == IntPtr.Zero)
				id_setTextColor_I = JNIEnv.GetMethodID (class_ref, "setTextColor", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextColor_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextColor", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTextColorResource_I;
#pragma warning disable 0169
		static Delegate GetSetTextColorResource_IHandler ()
		{
			if (cb_setTextColorResource_I == null)
				cb_setTextColorResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTextColorResource_I);
			return cb_setTextColorResource_I;
		}

		static void n_SetTextColorResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTextColorResource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTextColorResource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setTextColorResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTextColorResource", "(I)V", "GetSetTextColorResource_IHandler")]
		public virtual unsafe void SetTextColorResource (int p0)
		{
			if (id_setTextColorResource_I == IntPtr.Zero)
				id_setTextColorResource_I = JNIEnv.GetMethodID (class_ref, "setTextColorResource", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextColorResource_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextColorResource", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTextColorStateListResource_I;
#pragma warning disable 0169
		static Delegate GetSetTextColorStateListResource_IHandler ()
		{
			if (cb_setTextColorStateListResource_I == null)
				cb_setTextColorStateListResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTextColorStateListResource_I);
			return cb_setTextColorStateListResource_I;
		}

		static void n_SetTextColorStateListResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTextColorStateListResource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTextColorStateListResource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setTextColorStateListResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTextColorStateListResource", "(I)V", "GetSetTextColorStateListResource_IHandler")]
		public virtual unsafe void SetTextColorStateListResource (int p0)
		{
			if (id_setTextColorStateListResource_I == IntPtr.Zero)
				id_setTextColorStateListResource_I = JNIEnv.GetMethodID (class_ref, "setTextColorStateListResource", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextColorStateListResource_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextColorStateListResource", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTypeface_Landroid_graphics_Typeface_I;
#pragma warning disable 0169
		static Delegate GetSetTypeface_Landroid_graphics_Typeface_IHandler ()
		{
			if (cb_setTypeface_Landroid_graphics_Typeface_I == null)
				cb_setTypeface_Landroid_graphics_Typeface_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetTypeface_Landroid_graphics_Typeface_I);
			return cb_setTypeface_Landroid_graphics_Typeface_I;
		}

		static void n_SetTypeface_Landroid_graphics_Typeface_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTypeface (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setTypeface_Landroid_graphics_Typeface_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setTypeface' and count(parameter)=2 and parameter[1][@type='android.graphics.Typeface'] and parameter[2][@type='int']]"
		[Register ("setTypeface", "(Landroid/graphics/Typeface;I)V", "GetSetTypeface_Landroid_graphics_Typeface_IHandler")]
		public virtual unsafe void SetTypeface (global::Android.Graphics.Typeface p0, int p1)
		{
			if (id_setTypeface_Landroid_graphics_Typeface_I == IntPtr.Zero)
				id_setTypeface_Landroid_graphics_Typeface_I = JNIEnv.GetMethodID (class_ref, "setTypeface", "(Landroid/graphics/Typeface;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTypeface_Landroid_graphics_Typeface_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTypeface", "(Landroid/graphics/Typeface;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setUnderlineColorResource_I;
#pragma warning disable 0169
		static Delegate GetSetUnderlineColorResource_IHandler ()
		{
			if (cb_setUnderlineColorResource_I == null)
				cb_setUnderlineColorResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUnderlineColorResource_I);
			return cb_setUnderlineColorResource_I;
		}

		static void n_SetUnderlineColorResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUnderlineColorResource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUnderlineColorResource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setUnderlineColorResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setUnderlineColorResource", "(I)V", "GetSetUnderlineColorResource_IHandler")]
		public virtual unsafe void SetUnderlineColorResource (int p0)
		{
			if (id_setUnderlineColorResource_I == IntPtr.Zero)
				id_setUnderlineColorResource_I = JNIEnv.GetMethodID (class_ref, "setUnderlineColorResource", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUnderlineColorResource_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUnderlineColorResource", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setViewPager_Landroid_support_v4_view_ViewPager_;
#pragma warning disable 0169
		static Delegate GetSetViewPager_Landroid_support_v4_view_ViewPager_Handler ()
		{
			if (cb_setViewPager_Landroid_support_v4_view_ViewPager_ == null)
				cb_setViewPager_Landroid_support_v4_view_ViewPager_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetViewPager_Landroid_support_v4_view_ViewPager_);
			return cb_setViewPager_Landroid_support_v4_view_ViewPager_;
		}

		static void n_SetViewPager_Landroid_support_v4_view_ViewPager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Astuetz.PagerSlidingTabStrip __this = global::Java.Lang.Object.GetObject<global::Com.Astuetz.PagerSlidingTabStrip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetViewPager (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setViewPager_Landroid_support_v4_view_ViewPager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.astuetz']/class[@name='PagerSlidingTabStrip']/method[@name='setViewPager' and count(parameter)=1 and parameter[1][@type='android.support.v4.view.ViewPager']]"
		[Register ("setViewPager", "(Landroid/support/v4/view/ViewPager;)V", "GetSetViewPager_Landroid_support_v4_view_ViewPager_Handler")]
		public virtual unsafe void SetViewPager (global::Android.Support.V4.View.ViewPager p0)
		{
			if (id_setViewPager_Landroid_support_v4_view_ViewPager_ == IntPtr.Zero)
				id_setViewPager_Landroid_support_v4_view_ViewPager_ = JNIEnv.GetMethodID (class_ref, "setViewPager", "(Landroid/support/v4/view/ViewPager;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setViewPager_Landroid_support_v4_view_ViewPager_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setViewPager", "(Landroid/support/v4/view/ViewPager;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Astuetz.PagerSlidingTabStrip.IOnTabReselectedListener"
		public event EventHandler<global::Com.Astuetz.PagerSlidingTabStrip.TabReselectedEventArgs> TabReselected {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Astuetz.PagerSlidingTabStrip.IOnTabReselectedListener, global::Com.Astuetz.PagerSlidingTabStrip.IOnTabReselectedListenerImplementor>(
						ref weak_implementor_SetOnTabReselectedListener,
						__CreateIOnTabReselectedListenerImplementor,
						SetOnTabReselectedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Astuetz.PagerSlidingTabStrip.IOnTabReselectedListener, global::Com.Astuetz.PagerSlidingTabStrip.IOnTabReselectedListenerImplementor>(
						ref weak_implementor_SetOnTabReselectedListener,
						global::Com.Astuetz.PagerSlidingTabStrip.IOnTabReselectedListenerImplementor.__IsEmpty,
						__v => SetOnTabReselectedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnTabReselectedListener;

		global::Com.Astuetz.PagerSlidingTabStrip.IOnTabReselectedListenerImplementor __CreateIOnTabReselectedListenerImplementor ()
		{
			return new global::Com.Astuetz.PagerSlidingTabStrip.IOnTabReselectedListenerImplementor (this);
		}
#endregion
	}
}
