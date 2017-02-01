using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Github.Florent37.Materialviewpager.Header {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.florent37.materialviewpager.header']/class[@name='HeaderDesign']"
	[global::Android.Runtime.Register ("com/github/florent37/materialviewpager/header/HeaderDesign", DoNotGenerateAcw=true)]
	public partial class HeaderDesign : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/github/florent37/materialviewpager/header/HeaderDesign", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HeaderDesign); }
		}

		protected HeaderDesign (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColor);
			return cb_getColor;
		}

		static int n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign __this = global::Java.Lang.Object.GetObject<global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Color;
		}
#pragma warning restore 0169

		static IntPtr id_getColor;
		public virtual unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager.header']/class[@name='HeaderDesign']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getColorRes;
#pragma warning disable 0169
		static Delegate GetGetColorResHandler ()
		{
			if (cb_getColorRes == null)
				cb_getColorRes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColorRes);
			return cb_getColorRes;
		}

		static int n_GetColorRes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign __this = global::Java.Lang.Object.GetObject<global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ColorRes;
		}
#pragma warning restore 0169

		static IntPtr id_getColorRes;
		public virtual unsafe int ColorRes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager.header']/class[@name='HeaderDesign']/method[@name='getColorRes' and count(parameter)=0]"
			[Register ("getColorRes", "()I", "GetGetColorResHandler")]
			get {
				if (id_getColorRes == IntPtr.Zero)
					id_getColorRes = JNIEnv.GetMethodID (class_ref, "getColorRes", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColorRes);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColorRes", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDrawable;
#pragma warning disable 0169
		static Delegate GetGetDrawableHandler ()
		{
			if (cb_getDrawable == null)
				cb_getDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDrawable);
			return cb_getDrawable;
		}

		static IntPtr n_GetDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign __this = global::Java.Lang.Object.GetObject<global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Drawable);
		}
#pragma warning restore 0169

		static IntPtr id_getDrawable;
		public virtual unsafe global::Android.Graphics.Drawables.Drawable Drawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager.header']/class[@name='HeaderDesign']/method[@name='getDrawable' and count(parameter)=0]"
			[Register ("getDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetDrawableHandler")]
			get {
				if (id_getDrawable == IntPtr.Zero)
					id_getDrawable = JNIEnv.GetMethodID (class_ref, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDrawable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImageUrl;
#pragma warning disable 0169
		static Delegate GetGetImageUrlHandler ()
		{
			if (cb_getImageUrl == null)
				cb_getImageUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageUrl);
			return cb_getImageUrl;
		}

		static IntPtr n_GetImageUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign __this = global::Java.Lang.Object.GetObject<global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getImageUrl;
		public virtual unsafe string ImageUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager.header']/class[@name='HeaderDesign']/method[@name='getImageUrl' and count(parameter)=0]"
			[Register ("getImageUrl", "()Ljava/lang/String;", "GetGetImageUrlHandler")]
			get {
				if (id_getImageUrl == IntPtr.Zero)
					id_getImageUrl = JNIEnv.GetMethodID (class_ref, "getImageUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_fromColorAndDrawable_ILandroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager.header']/class[@name='HeaderDesign']/method[@name='fromColorAndDrawable' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("fromColorAndDrawable", "(ILandroid/graphics/drawable/Drawable;)Lcom/github/florent37/materialviewpager/header/HeaderDesign;", "")]
		public static unsafe global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign FromColorAndDrawable (int p0, global::Android.Graphics.Drawables.Drawable p1)
		{
			if (id_fromColorAndDrawable_ILandroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_fromColorAndDrawable_ILandroid_graphics_drawable_Drawable_ = JNIEnv.GetStaticMethodID (class_ref, "fromColorAndDrawable", "(ILandroid/graphics/drawable/Drawable;)Lcom/github/florent37/materialviewpager/header/HeaderDesign;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromColorAndDrawable_ILandroid_graphics_drawable_Drawable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromColorAndUrl_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager.header']/class[@name='HeaderDesign']/method[@name='fromColorAndUrl' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("fromColorAndUrl", "(ILjava/lang/String;)Lcom/github/florent37/materialviewpager/header/HeaderDesign;", "")]
		public static unsafe global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign FromColorAndUrl (int p0, string p1)
		{
			if (id_fromColorAndUrl_ILjava_lang_String_ == IntPtr.Zero)
				id_fromColorAndUrl_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromColorAndUrl", "(ILjava/lang/String;)Lcom/github/florent37/materialviewpager/header/HeaderDesign;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromColorAndUrl_ILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_fromColorResAndDrawable_ILandroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager.header']/class[@name='HeaderDesign']/method[@name='fromColorResAndDrawable' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("fromColorResAndDrawable", "(ILandroid/graphics/drawable/Drawable;)Lcom/github/florent37/materialviewpager/header/HeaderDesign;", "")]
		public static unsafe global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign FromColorResAndDrawable (int p0, global::Android.Graphics.Drawables.Drawable p1)
		{
			if (id_fromColorResAndDrawable_ILandroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_fromColorResAndDrawable_ILandroid_graphics_drawable_Drawable_ = JNIEnv.GetStaticMethodID (class_ref, "fromColorResAndDrawable", "(ILandroid/graphics/drawable/Drawable;)Lcom/github/florent37/materialviewpager/header/HeaderDesign;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromColorResAndDrawable_ILandroid_graphics_drawable_Drawable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromColorResAndUrl_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager.header']/class[@name='HeaderDesign']/method[@name='fromColorResAndUrl' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("fromColorResAndUrl", "(ILjava/lang/String;)Lcom/github/florent37/materialviewpager/header/HeaderDesign;", "")]
		public static unsafe global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign FromColorResAndUrl (int p0, string p1)
		{
			if (id_fromColorResAndUrl_ILjava_lang_String_ == IntPtr.Zero)
				id_fromColorResAndUrl_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromColorResAndUrl", "(ILjava/lang/String;)Lcom/github/florent37/materialviewpager/header/HeaderDesign;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Florent37.Materialviewpager.Header.HeaderDesign> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromColorResAndUrl_ILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
