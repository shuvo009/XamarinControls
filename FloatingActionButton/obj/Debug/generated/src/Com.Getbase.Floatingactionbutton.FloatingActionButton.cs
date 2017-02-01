using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Getbase.Floatingactionbutton {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']"
	[global::Android.Runtime.Register ("com/getbase/floatingactionbutton/FloatingActionButton", DoNotGenerateAcw=true)]
	public partial class FloatingActionButton : global::Android.Widget.ImageButton {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/field[@name='SIZE_MINI']"
		[Register ("SIZE_MINI")]
		public const int SizeMini = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/field[@name='SIZE_NORMAL']"
		[Register ("SIZE_NORMAL")]
		public const int SizeNormal = (int) 0;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.getbase.floatingactionbutton']/interface[@name='FloatingActionButton.FAB_SIZE']"
		[Register ("com/getbase/floatingactionbutton/FloatingActionButton$FAB_SIZE", "", "Com.Getbase.Floatingactionbutton.FloatingActionButton/IFAB_SIZEInvoker")]
		public partial interface IFAB_SIZE : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/getbase/floatingactionbutton/FloatingActionButton$FAB_SIZE", DoNotGenerateAcw=true)]
		internal class IFAB_SIZEInvoker : global::Java.Lang.Object, IFAB_SIZE {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/getbase/floatingactionbutton/FloatingActionButton$FAB_SIZE");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IFAB_SIZEInvoker); }
			}

			IntPtr class_ref;

			public static IFAB_SIZE GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFAB_SIZE> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.getbase.floatingactionbutton.FloatingActionButton.FAB_SIZE"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFAB_SIZEInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Getbase.Floatingactionbutton.FloatingActionButton.IFAB_SIZE __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton.IFAB_SIZE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Getbase.Floatingactionbutton.FloatingActionButton.IFAB_SIZE __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton.IFAB_SIZE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Getbase.Floatingactionbutton.FloatingActionButton.IFAB_SIZE __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton.IFAB_SIZE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Getbase.Floatingactionbutton.FloatingActionButton.IFAB_SIZE __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton.IFAB_SIZE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton.TranslucentLayerDrawable']"
		[global::Android.Runtime.Register ("com/getbase/floatingactionbutton/FloatingActionButton$TranslucentLayerDrawable", DoNotGenerateAcw=true)]
		public partial class TranslucentLayerDrawable : global::Android.Graphics.Drawables.LayerDrawable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/getbase/floatingactionbutton/FloatingActionButton$TranslucentLayerDrawable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TranslucentLayerDrawable); }
			}

			protected TranslucentLayerDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_IarrayLandroid_graphics_drawable_Drawable_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton.TranslucentLayerDrawable']/constructor[@name='FloatingActionButton.TranslucentLayerDrawable' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.graphics.drawable.Drawable...']]"
			[Register (".ctor", "(I[Landroid/graphics/drawable/Drawable;)V", "")]
			public unsafe TranslucentLayerDrawable (int p0, params global:: Android.Graphics.Drawables.Drawable[] p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (TranslucentLayerDrawable)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I[Landroid/graphics/drawable/Drawable;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I[Landroid/graphics/drawable/Drawable;)V", __args);
						return;
					}

					if (id_ctor_IarrayLandroid_graphics_drawable_Drawable_ == IntPtr.Zero)
						id_ctor_IarrayLandroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(I[Landroid/graphics/drawable/Drawable;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IarrayLandroid_graphics_drawable_Drawable_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IarrayLandroid_graphics_drawable_Drawable_, __args);
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/getbase/floatingactionbutton/FloatingActionButton", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FloatingActionButton); }
		}

		protected FloatingActionButton (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/constructor[@name='FloatingActionButton' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe FloatingActionButton (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (FloatingActionButton)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/constructor[@name='FloatingActionButton' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe FloatingActionButton (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (FloatingActionButton)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/constructor[@name='FloatingActionButton' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe FloatingActionButton (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (FloatingActionButton)) {
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

		static Delegate cb_getColorDisabled;
#pragma warning disable 0169
		static Delegate GetGetColorDisabledHandler ()
		{
			if (cb_getColorDisabled == null)
				cb_getColorDisabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColorDisabled);
			return cb_getColorDisabled;
		}

		static int n_GetColorDisabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ColorDisabled;
		}
#pragma warning restore 0169

		static Delegate cb_setColorDisabled_I;
#pragma warning disable 0169
		static Delegate GetSetColorDisabled_IHandler ()
		{
			if (cb_setColorDisabled_I == null)
				cb_setColorDisabled_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColorDisabled_I);
			return cb_setColorDisabled_I;
		}

		static void n_SetColorDisabled_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ColorDisabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getColorDisabled;
		static IntPtr id_setColorDisabled_I;
		public virtual unsafe int ColorDisabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/method[@name='getColorDisabled' and count(parameter)=0]"
			[Register ("getColorDisabled", "()I", "GetGetColorDisabledHandler")]
			get {
				if (id_getColorDisabled == IntPtr.Zero)
					id_getColorDisabled = JNIEnv.GetMethodID (class_ref, "getColorDisabled", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColorDisabled);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColorDisabled", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/method[@name='setColorDisabled' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setColorDisabled", "(I)V", "GetSetColorDisabled_IHandler")]
			set {
				if (id_setColorDisabled_I == IntPtr.Zero)
					id_setColorDisabled_I = JNIEnv.GetMethodID (class_ref, "setColorDisabled", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColorDisabled_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorDisabled", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getColorNormal;
#pragma warning disable 0169
		static Delegate GetGetColorNormalHandler ()
		{
			if (cb_getColorNormal == null)
				cb_getColorNormal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColorNormal);
			return cb_getColorNormal;
		}

		static int n_GetColorNormal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ColorNormal;
		}
#pragma warning restore 0169

		static Delegate cb_setColorNormal_I;
#pragma warning disable 0169
		static Delegate GetSetColorNormal_IHandler ()
		{
			if (cb_setColorNormal_I == null)
				cb_setColorNormal_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColorNormal_I);
			return cb_setColorNormal_I;
		}

		static void n_SetColorNormal_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ColorNormal = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getColorNormal;
		static IntPtr id_setColorNormal_I;
		public virtual unsafe int ColorNormal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/method[@name='getColorNormal' and count(parameter)=0]"
			[Register ("getColorNormal", "()I", "GetGetColorNormalHandler")]
			get {
				if (id_getColorNormal == IntPtr.Zero)
					id_getColorNormal = JNIEnv.GetMethodID (class_ref, "getColorNormal", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColorNormal);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColorNormal", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/method[@name='setColorNormal' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setColorNormal", "(I)V", "GetSetColorNormal_IHandler")]
			set {
				if (id_setColorNormal_I == IntPtr.Zero)
					id_setColorNormal_I = JNIEnv.GetMethodID (class_ref, "setColorNormal", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColorNormal_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorNormal", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getColorPressed;
#pragma warning disable 0169
		static Delegate GetGetColorPressedHandler ()
		{
			if (cb_getColorPressed == null)
				cb_getColorPressed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColorPressed);
			return cb_getColorPressed;
		}

		static int n_GetColorPressed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ColorPressed;
		}
#pragma warning restore 0169

		static Delegate cb_setColorPressed_I;
#pragma warning disable 0169
		static Delegate GetSetColorPressed_IHandler ()
		{
			if (cb_setColorPressed_I == null)
				cb_setColorPressed_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColorPressed_I);
			return cb_setColorPressed_I;
		}

		static void n_SetColorPressed_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ColorPressed = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getColorPressed;
		static IntPtr id_setColorPressed_I;
		public virtual unsafe int ColorPressed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/method[@name='getColorPressed' and count(parameter)=0]"
			[Register ("getColorPressed", "()I", "GetGetColorPressedHandler")]
			get {
				if (id_getColorPressed == IntPtr.Zero)
					id_getColorPressed = JNIEnv.GetMethodID (class_ref, "getColorPressed", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColorPressed);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColorPressed", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/method[@name='setColorPressed' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setColorPressed", "(I)V", "GetSetColorPressed_IHandler")]
			set {
				if (id_setColorPressed_I == IntPtr.Zero)
					id_setColorPressed_I = JNIEnv.GetMethodID (class_ref, "setColorPressed", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColorPressed_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorPressed", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSize);
			return cb_getSize;
		}

		static int n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		static Delegate cb_setSize_I;
#pragma warning disable 0169
		static Delegate GetSetSize_IHandler ()
		{
			if (cb_setSize_I == null)
				cb_setSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSize_I);
			return cb_setSize_I;
		}

		static void n_SetSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Size = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSize;
		static IntPtr id_setSize_I;
		public virtual unsafe int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/method[@name='setSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSize", "(I)V", "GetSetSize_IHandler")]
			set {
				if (id_setSize_I == IntPtr.Zero)
					id_setSize_I = JNIEnv.GetMethodID (class_ref, "setSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isStrokeVisible;
#pragma warning disable 0169
		static Delegate GetIsStrokeVisibleHandler ()
		{
			if (cb_isStrokeVisible == null)
				cb_isStrokeVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStrokeVisible);
			return cb_isStrokeVisible;
		}

		static bool n_IsStrokeVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrokeVisible;
		}
#pragma warning restore 0169

		static Delegate cb_setStrokeVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetStrokeVisible_ZHandler ()
		{
			if (cb_setStrokeVisible_Z == null)
				cb_setStrokeVisible_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetStrokeVisible_Z);
			return cb_setStrokeVisible_Z;
		}

		static void n_SetStrokeVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StrokeVisible = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isStrokeVisible;
		static IntPtr id_setStrokeVisible_Z;
		public virtual unsafe bool StrokeVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/method[@name='isStrokeVisible' and count(parameter)=0]"
			[Register ("isStrokeVisible", "()Z", "GetIsStrokeVisibleHandler")]
			get {
				if (id_isStrokeVisible == IntPtr.Zero)
					id_isStrokeVisible = JNIEnv.GetMethodID (class_ref, "isStrokeVisible", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStrokeVisible);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStrokeVisible", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/method[@name='setStrokeVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setStrokeVisible", "(Z)V", "GetSetStrokeVisible_ZHandler")]
			set {
				if (id_setStrokeVisible_Z == IntPtr.Zero)
					id_setStrokeVisible_Z = JNIEnv.GetMethodID (class_ref, "setStrokeVisible", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStrokeVisible_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStrokeVisible", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_String_;
		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTitle_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_setColorDisabledResId_I;
#pragma warning disable 0169
		static Delegate GetSetColorDisabledResId_IHandler ()
		{
			if (cb_setColorDisabledResId_I == null)
				cb_setColorDisabledResId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColorDisabledResId_I);
			return cb_setColorDisabledResId_I;
		}

		static void n_SetColorDisabledResId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColorDisabledResId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColorDisabledResId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/method[@name='setColorDisabledResId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setColorDisabledResId", "(I)V", "GetSetColorDisabledResId_IHandler")]
		public virtual unsafe void SetColorDisabledResId (int p0)
		{
			if (id_setColorDisabledResId_I == IntPtr.Zero)
				id_setColorDisabledResId_I = JNIEnv.GetMethodID (class_ref, "setColorDisabledResId", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColorDisabledResId_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorDisabledResId", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setColorNormalResId_I;
#pragma warning disable 0169
		static Delegate GetSetColorNormalResId_IHandler ()
		{
			if (cb_setColorNormalResId_I == null)
				cb_setColorNormalResId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColorNormalResId_I);
			return cb_setColorNormalResId_I;
		}

		static void n_SetColorNormalResId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColorNormalResId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColorNormalResId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/method[@name='setColorNormalResId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setColorNormalResId", "(I)V", "GetSetColorNormalResId_IHandler")]
		public virtual unsafe void SetColorNormalResId (int p0)
		{
			if (id_setColorNormalResId_I == IntPtr.Zero)
				id_setColorNormalResId_I = JNIEnv.GetMethodID (class_ref, "setColorNormalResId", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColorNormalResId_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorNormalResId", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setColorPressedResId_I;
#pragma warning disable 0169
		static Delegate GetSetColorPressedResId_IHandler ()
		{
			if (cb_setColorPressedResId_I == null)
				cb_setColorPressedResId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColorPressedResId_I);
			return cb_setColorPressedResId_I;
		}

		static void n_SetColorPressedResId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColorPressedResId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColorPressedResId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/method[@name='setColorPressedResId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setColorPressedResId", "(I)V", "GetSetColorPressedResId_IHandler")]
		public virtual unsafe void SetColorPressedResId (int p0)
		{
			if (id_setColorPressedResId_I == IntPtr.Zero)
				id_setColorPressedResId_I = JNIEnv.GetMethodID (class_ref, "setColorPressedResId", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColorPressedResId_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorPressedResId", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setIcon_I;
#pragma warning disable 0169
		static Delegate GetSetIcon_IHandler ()
		{
			if (cb_setIcon_I == null)
				cb_setIcon_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIcon_I);
			return cb_setIcon_I;
		}

		static void n_SetIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIcon (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIcon_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIcon", "(I)V", "GetSetIcon_IHandler")]
		public virtual unsafe void SetIcon (int p0)
		{
			if (id_setIcon_I == IntPtr.Zero)
				id_setIcon_I = JNIEnv.GetMethodID (class_ref, "setIcon", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIcon_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIcon", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setIconDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetIconDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setIconDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setIconDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIconDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setIconDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetIconDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionButton __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIconDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIconDrawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionButton']/method[@name='setIconDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setIconDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetIconDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetIconDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setIconDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setIconDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setIconDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIconDrawable_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIconDrawable", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

	}
}
