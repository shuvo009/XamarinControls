using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Getbase.Floatingactionbutton {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='TouchDelegateGroup']"
	[global::Android.Runtime.Register ("com/getbase/floatingactionbutton/TouchDelegateGroup", DoNotGenerateAcw=true)]
	public partial class TouchDelegateGroup : global::Android.Views.TouchDelegate {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/getbase/floatingactionbutton/TouchDelegateGroup", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TouchDelegateGroup); }
		}

		protected TouchDelegateGroup (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='TouchDelegateGroup']/constructor[@name='TouchDelegateGroup' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe TouchDelegateGroup (global::Android.Views.View p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TouchDelegateGroup)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/View;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/view/View;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_View_ == IntPtr.Zero)
					id_ctor_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_view_View_, __args);
			} finally {
			}
		}

		static Delegate cb_addTouchDelegate_Landroid_view_TouchDelegate_;
#pragma warning disable 0169
		static Delegate GetAddTouchDelegate_Landroid_view_TouchDelegate_Handler ()
		{
			if (cb_addTouchDelegate_Landroid_view_TouchDelegate_ == null)
				cb_addTouchDelegate_Landroid_view_TouchDelegate_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddTouchDelegate_Landroid_view_TouchDelegate_);
			return cb_addTouchDelegate_Landroid_view_TouchDelegate_;
		}

		static void n_AddTouchDelegate_Landroid_view_TouchDelegate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Getbase.Floatingactionbutton.TouchDelegateGroup __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.TouchDelegateGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.TouchDelegate p0 = global::Java.Lang.Object.GetObject<global::Android.Views.TouchDelegate> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddTouchDelegate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addTouchDelegate_Landroid_view_TouchDelegate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='TouchDelegateGroup']/method[@name='addTouchDelegate' and count(parameter)=1 and parameter[1][@type='android.view.TouchDelegate']]"
		[Register ("addTouchDelegate", "(Landroid/view/TouchDelegate;)V", "GetAddTouchDelegate_Landroid_view_TouchDelegate_Handler")]
		public virtual unsafe void AddTouchDelegate (global::Android.Views.TouchDelegate p0)
		{
			if (id_addTouchDelegate_Landroid_view_TouchDelegate_ == IntPtr.Zero)
				id_addTouchDelegate_Landroid_view_TouchDelegate_ = JNIEnv.GetMethodID (class_ref, "addTouchDelegate", "(Landroid/view/TouchDelegate;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addTouchDelegate_Landroid_view_TouchDelegate_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addTouchDelegate", "(Landroid/view/TouchDelegate;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_clearTouchDelegates;
#pragma warning disable 0169
		static Delegate GetClearTouchDelegatesHandler ()
		{
			if (cb_clearTouchDelegates == null)
				cb_clearTouchDelegates = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearTouchDelegates);
			return cb_clearTouchDelegates;
		}

		static void n_ClearTouchDelegates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Getbase.Floatingactionbutton.TouchDelegateGroup __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.TouchDelegateGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearTouchDelegates ();
		}
#pragma warning restore 0169

		static IntPtr id_clearTouchDelegates;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='TouchDelegateGroup']/method[@name='clearTouchDelegates' and count(parameter)=0]"
		[Register ("clearTouchDelegates", "()V", "GetClearTouchDelegatesHandler")]
		public virtual unsafe void ClearTouchDelegates ()
		{
			if (id_clearTouchDelegates == IntPtr.Zero)
				id_clearTouchDelegates = JNIEnv.GetMethodID (class_ref, "clearTouchDelegates", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearTouchDelegates);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearTouchDelegates", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeTouchDelegate_Landroid_view_TouchDelegate_;
#pragma warning disable 0169
		static Delegate GetRemoveTouchDelegate_Landroid_view_TouchDelegate_Handler ()
		{
			if (cb_removeTouchDelegate_Landroid_view_TouchDelegate_ == null)
				cb_removeTouchDelegate_Landroid_view_TouchDelegate_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveTouchDelegate_Landroid_view_TouchDelegate_);
			return cb_removeTouchDelegate_Landroid_view_TouchDelegate_;
		}

		static void n_RemoveTouchDelegate_Landroid_view_TouchDelegate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Getbase.Floatingactionbutton.TouchDelegateGroup __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.TouchDelegateGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.TouchDelegate p0 = global::Java.Lang.Object.GetObject<global::Android.Views.TouchDelegate> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveTouchDelegate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeTouchDelegate_Landroid_view_TouchDelegate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='TouchDelegateGroup']/method[@name='removeTouchDelegate' and count(parameter)=1 and parameter[1][@type='android.view.TouchDelegate']]"
		[Register ("removeTouchDelegate", "(Landroid/view/TouchDelegate;)V", "GetRemoveTouchDelegate_Landroid_view_TouchDelegate_Handler")]
		public virtual unsafe void RemoveTouchDelegate (global::Android.Views.TouchDelegate p0)
		{
			if (id_removeTouchDelegate_Landroid_view_TouchDelegate_ == IntPtr.Zero)
				id_removeTouchDelegate_Landroid_view_TouchDelegate_ = JNIEnv.GetMethodID (class_ref, "removeTouchDelegate", "(Landroid/view/TouchDelegate;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeTouchDelegate_Landroid_view_TouchDelegate_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeTouchDelegate", "(Landroid/view/TouchDelegate;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetEnabled_ZHandler ()
		{
			if (cb_setEnabled_Z == null)
				cb_setEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEnabled_Z);
			return cb_setEnabled_Z;
		}

		static void n_SetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Getbase.Floatingactionbutton.TouchDelegateGroup __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.TouchDelegateGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='TouchDelegateGroup']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnabled", "(Z)V", "GetSetEnabled_ZHandler")]
		public virtual unsafe void SetEnabled (bool p0)
		{
			if (id_setEnabled_Z == IntPtr.Zero)
				id_setEnabled_Z = JNIEnv.GetMethodID (class_ref, "setEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEnabled_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnabled", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
