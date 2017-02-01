using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Github.Florent37.Materialviewpager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='Utils']"
	[global::Android.Runtime.Register ("com/github/florent37/materialviewpager/Utils", DoNotGenerateAcw=true)]
	public partial class Utils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/github/florent37/materialviewpager/Utils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Utils); }
		}

		protected Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='Utils']/constructor[@name='Utils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Utils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Utils)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_canScroll_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='Utils']/method[@name='canScroll' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("canScroll", "(Landroid/view/View;)Z", "")]
		public static unsafe bool CanScroll (global::Android.Views.View p0)
		{
			if (id_canScroll_Landroid_view_View_ == IntPtr.Zero)
				id_canScroll_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "canScroll", "(Landroid/view/View;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_canScroll_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_colorWithAlpha_IF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='Utils']/method[@name='colorWithAlpha' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("colorWithAlpha", "(IF)I", "")]
		public static unsafe int ColorWithAlpha (int p0, float p1)
		{
			if (id_colorWithAlpha_IF == IntPtr.Zero)
				id_colorWithAlpha_IF = JNIEnv.GetStaticMethodID (class_ref, "colorWithAlpha", "(IF)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_colorWithAlpha_IF, __args);
			} finally {
			}
		}

		static IntPtr id_dpToPx_FLandroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='Utils']/method[@name='dpToPx' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.content.Context']]"
		[Register ("dpToPx", "(FLandroid/content/Context;)F", "")]
		public static unsafe float DpToPx (float p0, global::Android.Content.Context p1)
		{
			if (id_dpToPx_FLandroid_content_Context_ == IntPtr.Zero)
				id_dpToPx_FLandroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "dpToPx", "(FLandroid/content/Context;)F");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_dpToPx_FLandroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getTheVisibileView_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='Utils']/method[@name='getTheVisibileView' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;android.view.View&gt;']]"
		[Register ("getTheVisibileView", "(Ljava/util/List;)Landroid/view/View;", "")]
		public static unsafe global::Android.Views.View GetTheVisibileView (global::System.Collections.Generic.IList<global::Android.Views.View> p0)
		{
			if (id_getTheVisibileView_Ljava_util_List_ == IntPtr.Zero)
				id_getTheVisibileView_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "getTheVisibileView", "(Ljava/util/List;)Landroid/view/View;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Views.View>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTheVisibileView_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_minMax_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='Utils']/method[@name='minMax' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("minMax", "(FFF)F", "")]
		public static unsafe float MinMax (float p0, float p1, float p2)
		{
			if (id_minMax_FFF == IntPtr.Zero)
				id_minMax_FFF = JNIEnv.GetStaticMethodID (class_ref, "minMax", "(FFF)F");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_minMax_FFF, __args);
			} finally {
			}
		}

		static IntPtr id_pxToDp_FLandroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='Utils']/method[@name='pxToDp' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.content.Context']]"
		[Register ("pxToDp", "(FLandroid/content/Context;)F", "")]
		public static unsafe float PxToDp (float p0, global::Android.Content.Context p1)
		{
			if (id_pxToDp_FLandroid_content_Context_ == IntPtr.Zero)
				id_pxToDp_FLandroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "pxToDp", "(FLandroid/content/Context;)F");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_pxToDp_FLandroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_scrollTo_Ljava_lang_Object_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='Utils']/method[@name='scrollTo' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='float']]"
		[Register ("scrollTo", "(Ljava/lang/Object;F)V", "")]
		public static unsafe void ScrollTo (global::Java.Lang.Object p0, float p1)
		{
			if (id_scrollTo_Ljava_lang_Object_F == IntPtr.Zero)
				id_scrollTo_Ljava_lang_Object_F = JNIEnv.GetStaticMethodID (class_ref, "scrollTo", "(Ljava/lang/Object;F)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_scrollTo_Ljava_lang_Object_F, __args);
			} finally {
			}
		}

		static IntPtr id_setBackgroundColor_IarrayLandroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='Utils']/method[@name='setBackgroundColor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.View...']]"
		[Register ("setBackgroundColor", "(I[Landroid/view/View;)V", "")]
		public static unsafe void SetBackgroundColor (int p0, params global:: Android.Views.View[] p1)
		{
			if (id_setBackgroundColor_IarrayLandroid_view_View_ == IntPtr.Zero)
				id_setBackgroundColor_IarrayLandroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "setBackgroundColor", "(I[Landroid/view/View;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setBackgroundColor_IarrayLandroid_view_View_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_setElevation_FarrayLandroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='Utils']/method[@name='setElevation' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.view.View...']]"
		[Register ("setElevation", "(F[Landroid/view/View;)V", "")]
		public static unsafe void SetElevation (float p0, params global:: Android.Views.View[] p1)
		{
			if (id_setElevation_FarrayLandroid_view_View_ == IntPtr.Zero)
				id_setElevation_FarrayLandroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "setElevation", "(F[Landroid/view/View;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setElevation_FarrayLandroid_view_View_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_setScale_FarrayLandroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='Utils']/method[@name='setScale' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.view.View...']]"
		[Register ("setScale", "(F[Landroid/view/View;)V", "")]
		public static unsafe void SetScale (float p0, params global:: Android.Views.View[] p1)
		{
			if (id_setScale_FarrayLandroid_view_View_ == IntPtr.Zero)
				id_setScale_FarrayLandroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "setScale", "(F[Landroid/view/View;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setScale_FarrayLandroid_view_View_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
