using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Getbase.Floatingactionbutton {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='AddFloatingActionButton']"
	[global::Android.Runtime.Register ("com/getbase/floatingactionbutton/AddFloatingActionButton", DoNotGenerateAcw=true)]
	public partial class AddFloatingActionButton : global::Com.Getbase.Floatingactionbutton.FloatingActionButton {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/getbase/floatingactionbutton/AddFloatingActionButton", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AddFloatingActionButton); }
		}

		protected AddFloatingActionButton (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='AddFloatingActionButton']/constructor[@name='AddFloatingActionButton' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe AddFloatingActionButton (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (AddFloatingActionButton)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='AddFloatingActionButton']/constructor[@name='AddFloatingActionButton' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe AddFloatingActionButton (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (AddFloatingActionButton)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='AddFloatingActionButton']/constructor[@name='AddFloatingActionButton' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AddFloatingActionButton (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AddFloatingActionButton)) {
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

		static Delegate cb_getPlusColor;
#pragma warning disable 0169
		static Delegate GetGetPlusColorHandler ()
		{
			if (cb_getPlusColor == null)
				cb_getPlusColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPlusColor);
			return cb_getPlusColor;
		}

		static int n_GetPlusColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Getbase.Floatingactionbutton.AddFloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.AddFloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PlusColor;
		}
#pragma warning restore 0169

		static Delegate cb_setPlusColor_I;
#pragma warning disable 0169
		static Delegate GetSetPlusColor_IHandler ()
		{
			if (cb_setPlusColor_I == null)
				cb_setPlusColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPlusColor_I);
			return cb_setPlusColor_I;
		}

		static void n_SetPlusColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Getbase.Floatingactionbutton.AddFloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.AddFloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PlusColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPlusColor;
		static IntPtr id_setPlusColor_I;
		public virtual unsafe int PlusColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='AddFloatingActionButton']/method[@name='getPlusColor' and count(parameter)=0]"
			[Register ("getPlusColor", "()I", "GetGetPlusColorHandler")]
			get {
				if (id_getPlusColor == IntPtr.Zero)
					id_getPlusColor = JNIEnv.GetMethodID (class_ref, "getPlusColor", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPlusColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlusColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='AddFloatingActionButton']/method[@name='setPlusColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPlusColor", "(I)V", "GetSetPlusColor_IHandler")]
			set {
				if (id_setPlusColor_I == IntPtr.Zero)
					id_setPlusColor_I = JNIEnv.GetMethodID (class_ref, "setPlusColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlusColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPlusColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_setPlusColorResId_I;
#pragma warning disable 0169
		static Delegate GetSetPlusColorResId_IHandler ()
		{
			if (cb_setPlusColorResId_I == null)
				cb_setPlusColorResId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPlusColorResId_I);
			return cb_setPlusColorResId_I;
		}

		static void n_SetPlusColorResId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Getbase.Floatingactionbutton.AddFloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.AddFloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPlusColorResId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPlusColorResId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='AddFloatingActionButton']/method[@name='setPlusColorResId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPlusColorResId", "(I)V", "GetSetPlusColorResId_IHandler")]
		public virtual unsafe void SetPlusColorResId (int p0)
		{
			if (id_setPlusColorResId_I == IntPtr.Zero)
				id_setPlusColorResId_I = JNIEnv.GetMethodID (class_ref, "setPlusColorResId", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlusColorResId_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPlusColorResId", "(I)V"), __args);
			} finally {
			}
		}

	}
}
