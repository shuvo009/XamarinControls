using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Github.Florent37.Materialviewpager.Header {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.florent37.materialviewpager.header']/class[@name='MaterialViewPagerImageHelper']"
	[global::Android.Runtime.Register ("com/github/florent37/materialviewpager/header/MaterialViewPagerImageHelper", DoNotGenerateAcw=true)]
	public partial class MaterialViewPagerImageHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/github/florent37/materialviewpager/header/MaterialViewPagerImageHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MaterialViewPagerImageHelper); }
		}

		protected MaterialViewPagerImageHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.florent37.materialviewpager.header']/class[@name='MaterialViewPagerImageHelper']/constructor[@name='MaterialViewPagerImageHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MaterialViewPagerImageHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MaterialViewPagerImageHelper)) {
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

		static IntPtr id_fadeIn_Landroid_view_View_FILandroid_support_v4_view_ViewPropertyAnimatorListenerAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager.header']/class[@name='MaterialViewPagerImageHelper']/method[@name='fadeIn' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='android.support.v4.view.ViewPropertyAnimatorListenerAdapter']]"
		[Register ("fadeIn", "(Landroid/view/View;FILandroid/support/v4/view/ViewPropertyAnimatorListenerAdapter;)V", "")]
		public static unsafe void FadeIn (global::Android.Views.View p0, float p1, int p2, global::Android.Support.V4.View.ViewPropertyAnimatorListenerAdapter p3)
		{
			if (id_fadeIn_Landroid_view_View_FILandroid_support_v4_view_ViewPropertyAnimatorListenerAdapter_ == IntPtr.Zero)
				id_fadeIn_Landroid_view_View_FILandroid_support_v4_view_ViewPropertyAnimatorListenerAdapter_ = JNIEnv.GetStaticMethodID (class_ref, "fadeIn", "(Landroid/view/View;FILandroid/support/v4/view/ViewPropertyAnimatorListenerAdapter;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fadeIn_Landroid_view_View_FILandroid_support_v4_view_ViewPropertyAnimatorListenerAdapter_, __args);
			} finally {
			}
		}

		static IntPtr id_fadeOut_Landroid_view_View_ILandroid_support_v4_view_ViewPropertyAnimatorListenerAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager.header']/class[@name='MaterialViewPagerImageHelper']/method[@name='fadeOut' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='android.support.v4.view.ViewPropertyAnimatorListenerAdapter']]"
		[Register ("fadeOut", "(Landroid/view/View;ILandroid/support/v4/view/ViewPropertyAnimatorListenerAdapter;)V", "")]
		public static unsafe void FadeOut (global::Android.Views.View p0, int p1, global::Android.Support.V4.View.ViewPropertyAnimatorListenerAdapter p2)
		{
			if (id_fadeOut_Landroid_view_View_ILandroid_support_v4_view_ViewPropertyAnimatorListenerAdapter_ == IntPtr.Zero)
				id_fadeOut_Landroid_view_View_ILandroid_support_v4_view_ViewPropertyAnimatorListenerAdapter_ = JNIEnv.GetStaticMethodID (class_ref, "fadeOut", "(Landroid/view/View;ILandroid/support/v4/view/ViewPropertyAnimatorListenerAdapter;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fadeOut_Landroid_view_View_ILandroid_support_v4_view_ViewPropertyAnimatorListenerAdapter_, __args);
			} finally {
			}
		}

		static IntPtr id_setImageDrawable_Landroid_widget_ImageView_Landroid_graphics_drawable_Drawable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager.header']/class[@name='MaterialViewPagerImageHelper']/method[@name='setImageDrawable' and count(parameter)=3 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='android.graphics.drawable.Drawable'] and parameter[3][@type='int']]"
		[Register ("setImageDrawable", "(Landroid/widget/ImageView;Landroid/graphics/drawable/Drawable;I)V", "")]
		public static unsafe void SetImageDrawable (global::Android.Widget.ImageView p0, global::Android.Graphics.Drawables.Drawable p1, int p2)
		{
			if (id_setImageDrawable_Landroid_widget_ImageView_Landroid_graphics_drawable_Drawable_I == IntPtr.Zero)
				id_setImageDrawable_Landroid_widget_ImageView_Landroid_graphics_drawable_Drawable_I = JNIEnv.GetStaticMethodID (class_ref, "setImageDrawable", "(Landroid/widget/ImageView;Landroid/graphics/drawable/Drawable;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setImageDrawable_Landroid_widget_ImageView_Landroid_graphics_drawable_Drawable_I, __args);
			} finally {
			}
		}

		static IntPtr id_setImageLoadListener_Lcom_github_florent37_materialviewpager_MaterialViewPager_OnImageLoadListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager.header']/class[@name='MaterialViewPagerImageHelper']/method[@name='setImageLoadListener' and count(parameter)=1 and parameter[1][@type='com.github.florent37.materialviewpager.MaterialViewPager.OnImageLoadListener']]"
		[Register ("setImageLoadListener", "(Lcom/github/florent37/materialviewpager/MaterialViewPager$OnImageLoadListener;)V", "")]
		public static unsafe void SetImageLoadListener (global::Com.Github.Florent37.Materialviewpager.MaterialViewPager.IOnImageLoadListener p0)
		{
			if (id_setImageLoadListener_Lcom_github_florent37_materialviewpager_MaterialViewPager_OnImageLoadListener_ == IntPtr.Zero)
				id_setImageLoadListener_Lcom_github_florent37_materialviewpager_MaterialViewPager_OnImageLoadListener_ = JNIEnv.GetStaticMethodID (class_ref, "setImageLoadListener", "(Lcom/github/florent37/materialviewpager/MaterialViewPager$OnImageLoadListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setImageLoadListener_Lcom_github_florent37_materialviewpager_MaterialViewPager_OnImageLoadListener_, __args);
			} finally {
			}
		}

		static IntPtr id_setImageUrl_Landroid_widget_ImageView_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager.header']/class[@name='MaterialViewPagerImageHelper']/method[@name='setImageUrl' and count(parameter)=3 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("setImageUrl", "(Landroid/widget/ImageView;Ljava/lang/String;I)V", "")]
		public static unsafe void SetImageUrl (global::Android.Widget.ImageView p0, string p1, int p2)
		{
			if (id_setImageUrl_Landroid_widget_ImageView_Ljava_lang_String_I == IntPtr.Zero)
				id_setImageUrl_Landroid_widget_ImageView_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "setImageUrl", "(Landroid/widget/ImageView;Ljava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setImageUrl_Landroid_widget_ImageView_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

#region "Event implementation for Com.Github.Florent37.Materialviewpager.MaterialViewPager.IOnImageLoadListener"
		public event EventHandler<global::Com.Github.Florent37.Materialviewpager.MaterialViewPager.ImageLoadEventArgs> ImageLoad {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Github.Florent37.Materialviewpager.MaterialViewPager.IOnImageLoadListener, global::Com.Github.Florent37.Materialviewpager.MaterialViewPager.IOnImageLoadListenerImplementor>(
						ref weak_implementor_SetImageLoadListener,
						__CreateIOnImageLoadListenerImplementor,
						SetImageLoadListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Github.Florent37.Materialviewpager.MaterialViewPager.IOnImageLoadListener, global::Com.Github.Florent37.Materialviewpager.MaterialViewPager.IOnImageLoadListenerImplementor>(
						ref weak_implementor_SetImageLoadListener,
						global::Com.Github.Florent37.Materialviewpager.MaterialViewPager.IOnImageLoadListenerImplementor.__IsEmpty,
						__v => SetImageLoadListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetImageLoadListener;

		global::Com.Github.Florent37.Materialviewpager.MaterialViewPager.IOnImageLoadListenerImplementor __CreateIOnImageLoadListenerImplementor ()
		{
			return new global::Com.Github.Florent37.Materialviewpager.MaterialViewPager.IOnImageLoadListenerImplementor (this);
		}
#endregion
	}
}
