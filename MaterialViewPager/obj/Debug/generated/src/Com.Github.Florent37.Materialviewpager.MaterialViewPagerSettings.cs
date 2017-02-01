using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Github.Florent37.Materialviewpager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']"
	[global::Android.Runtime.Register ("com/github/florent37/materialviewpager/MaterialViewPagerSettings", DoNotGenerateAcw=true)]
	public partial class MaterialViewPagerSettings : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr animatedHeaderImage_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='animatedHeaderImage']"
		[Register ("animatedHeaderImage")]
		protected bool AnimatedHeaderImage {
			get {
				if (animatedHeaderImage_jfieldId == IntPtr.Zero)
					animatedHeaderImage_jfieldId = JNIEnv.GetFieldID (class_ref, "animatedHeaderImage", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, animatedHeaderImage_jfieldId);
			}
			set {
				if (animatedHeaderImage_jfieldId == IntPtr.Zero)
					animatedHeaderImage_jfieldId = JNIEnv.GetFieldID (class_ref, "animatedHeaderImage", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, animatedHeaderImage_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr color_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='color']"
		[Register ("color")]
		protected int Color {
			get {
				if (color_jfieldId == IntPtr.Zero)
					color_jfieldId = JNIEnv.GetFieldID (class_ref, "color", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, color_jfieldId);
			}
			set {
				if (color_jfieldId == IntPtr.Zero)
					color_jfieldId = JNIEnv.GetFieldID (class_ref, "color", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, color_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr disableToolbar_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='disableToolbar']"
		[Register ("disableToolbar")]
		protected bool DisableToolbar {
			get {
				if (disableToolbar_jfieldId == IntPtr.Zero)
					disableToolbar_jfieldId = JNIEnv.GetFieldID (class_ref, "disableToolbar", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, disableToolbar_jfieldId);
			}
			set {
				if (disableToolbar_jfieldId == IntPtr.Zero)
					disableToolbar_jfieldId = JNIEnv.GetFieldID (class_ref, "disableToolbar", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, disableToolbar_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr displayToolbarWhenSwipe_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='displayToolbarWhenSwipe']"
		[Register ("displayToolbarWhenSwipe")]
		protected bool DisplayToolbarWhenSwipe {
			get {
				if (displayToolbarWhenSwipe_jfieldId == IntPtr.Zero)
					displayToolbarWhenSwipe_jfieldId = JNIEnv.GetFieldID (class_ref, "displayToolbarWhenSwipe", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, displayToolbarWhenSwipe_jfieldId);
			}
			set {
				if (displayToolbarWhenSwipe_jfieldId == IntPtr.Zero)
					displayToolbarWhenSwipe_jfieldId = JNIEnv.GetFieldID (class_ref, "displayToolbarWhenSwipe", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, displayToolbarWhenSwipe_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr enableToolbarElevation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='enableToolbarElevation']"
		[Register ("enableToolbarElevation")]
		protected bool EnableToolbarElevation {
			get {
				if (enableToolbarElevation_jfieldId == IntPtr.Zero)
					enableToolbarElevation_jfieldId = JNIEnv.GetFieldID (class_ref, "enableToolbarElevation", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, enableToolbarElevation_jfieldId);
			}
			set {
				if (enableToolbarElevation_jfieldId == IntPtr.Zero)
					enableToolbarElevation_jfieldId = JNIEnv.GetFieldID (class_ref, "enableToolbarElevation", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, enableToolbarElevation_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr headerAdditionalHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='headerAdditionalHeight']"
		[Register ("headerAdditionalHeight")]
		protected int HeaderAdditionalHeight {
			get {
				if (headerAdditionalHeight_jfieldId == IntPtr.Zero)
					headerAdditionalHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "headerAdditionalHeight", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, headerAdditionalHeight_jfieldId);
			}
			set {
				if (headerAdditionalHeight_jfieldId == IntPtr.Zero)
					headerAdditionalHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "headerAdditionalHeight", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, headerAdditionalHeight_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr headerAlpha_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='headerAlpha']"
		[Register ("headerAlpha")]
		protected float HeaderAlpha {
			get {
				if (headerAlpha_jfieldId == IntPtr.Zero)
					headerAlpha_jfieldId = JNIEnv.GetFieldID (class_ref, "headerAlpha", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, headerAlpha_jfieldId);
			}
			set {
				if (headerAlpha_jfieldId == IntPtr.Zero)
					headerAlpha_jfieldId = JNIEnv.GetFieldID (class_ref, "headerAlpha", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, headerAlpha_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr headerHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='headerHeight']"
		[Register ("headerHeight")]
		protected int HeaderHeight {
			get {
				if (headerHeight_jfieldId == IntPtr.Zero)
					headerHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "headerHeight", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, headerHeight_jfieldId);
			}
			set {
				if (headerHeight_jfieldId == IntPtr.Zero)
					headerHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "headerHeight", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, headerHeight_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr headerHeightPx_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='headerHeightPx']"
		[Register ("headerHeightPx")]
		protected int HeaderHeightPx {
			get {
				if (headerHeightPx_jfieldId == IntPtr.Zero)
					headerHeightPx_jfieldId = JNIEnv.GetFieldID (class_ref, "headerHeightPx", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, headerHeightPx_jfieldId);
			}
			set {
				if (headerHeightPx_jfieldId == IntPtr.Zero)
					headerHeightPx_jfieldId = JNIEnv.GetFieldID (class_ref, "headerHeightPx", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, headerHeightPx_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr headerLayoutId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='headerLayoutId']"
		[Register ("headerLayoutId")]
		protected int HeaderLayoutId {
			get {
				if (headerLayoutId_jfieldId == IntPtr.Zero)
					headerLayoutId_jfieldId = JNIEnv.GetFieldID (class_ref, "headerLayoutId", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, headerLayoutId_jfieldId);
			}
			set {
				if (headerLayoutId_jfieldId == IntPtr.Zero)
					headerLayoutId_jfieldId = JNIEnv.GetFieldID (class_ref, "headerLayoutId", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, headerLayoutId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr hideLogoWithFade_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='hideLogoWithFade']"
		[Register ("hideLogoWithFade")]
		protected bool HideLogoWithFade {
			get {
				if (hideLogoWithFade_jfieldId == IntPtr.Zero)
					hideLogoWithFade_jfieldId = JNIEnv.GetFieldID (class_ref, "hideLogoWithFade", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, hideLogoWithFade_jfieldId);
			}
			set {
				if (hideLogoWithFade_jfieldId == IntPtr.Zero)
					hideLogoWithFade_jfieldId = JNIEnv.GetFieldID (class_ref, "hideLogoWithFade", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, hideLogoWithFade_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr hideToolbarAndTitle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='hideToolbarAndTitle']"
		[Register ("hideToolbarAndTitle")]
		protected bool HideToolbarAndTitle {
			get {
				if (hideToolbarAndTitle_jfieldId == IntPtr.Zero)
					hideToolbarAndTitle_jfieldId = JNIEnv.GetFieldID (class_ref, "hideToolbarAndTitle", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, hideToolbarAndTitle_jfieldId);
			}
			set {
				if (hideToolbarAndTitle_jfieldId == IntPtr.Zero)
					hideToolbarAndTitle_jfieldId = JNIEnv.GetFieldID (class_ref, "hideToolbarAndTitle", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, hideToolbarAndTitle_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr imageHeaderDarkLayerAlpha_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='imageHeaderDarkLayerAlpha']"
		[Register ("imageHeaderDarkLayerAlpha")]
		protected float ImageHeaderDarkLayerAlpha {
			get {
				if (imageHeaderDarkLayerAlpha_jfieldId == IntPtr.Zero)
					imageHeaderDarkLayerAlpha_jfieldId = JNIEnv.GetFieldID (class_ref, "imageHeaderDarkLayerAlpha", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, imageHeaderDarkLayerAlpha_jfieldId);
			}
			set {
				if (imageHeaderDarkLayerAlpha_jfieldId == IntPtr.Zero)
					imageHeaderDarkLayerAlpha_jfieldId = JNIEnv.GetFieldID (class_ref, "imageHeaderDarkLayerAlpha", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, imageHeaderDarkLayerAlpha_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr logoLayoutId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='logoLayoutId']"
		[Register ("logoLayoutId")]
		protected int LogoLayoutId {
			get {
				if (logoLayoutId_jfieldId == IntPtr.Zero)
					logoLayoutId_jfieldId = JNIEnv.GetFieldID (class_ref, "logoLayoutId", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, logoLayoutId_jfieldId);
			}
			set {
				if (logoLayoutId_jfieldId == IntPtr.Zero)
					logoLayoutId_jfieldId = JNIEnv.GetFieldID (class_ref, "logoLayoutId", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, logoLayoutId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr logoMarginTop_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='logoMarginTop']"
		[Register ("logoMarginTop")]
		protected int LogoMarginTop {
			get {
				if (logoMarginTop_jfieldId == IntPtr.Zero)
					logoMarginTop_jfieldId = JNIEnv.GetFieldID (class_ref, "logoMarginTop", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, logoMarginTop_jfieldId);
			}
			set {
				if (logoMarginTop_jfieldId == IntPtr.Zero)
					logoMarginTop_jfieldId = JNIEnv.GetFieldID (class_ref, "logoMarginTop", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, logoMarginTop_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr pagerTitleStripId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='pagerTitleStripId']"
		[Register ("pagerTitleStripId")]
		protected int PagerTitleStripId {
			get {
				if (pagerTitleStripId_jfieldId == IntPtr.Zero)
					pagerTitleStripId_jfieldId = JNIEnv.GetFieldID (class_ref, "pagerTitleStripId", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, pagerTitleStripId_jfieldId);
			}
			set {
				if (pagerTitleStripId_jfieldId == IntPtr.Zero)
					pagerTitleStripId_jfieldId = JNIEnv.GetFieldID (class_ref, "pagerTitleStripId", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pagerTitleStripId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr parallaxHeaderFactor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='parallaxHeaderFactor']"
		[Register ("parallaxHeaderFactor")]
		protected float ParallaxHeaderFactor {
			get {
				if (parallaxHeaderFactor_jfieldId == IntPtr.Zero)
					parallaxHeaderFactor_jfieldId = JNIEnv.GetFieldID (class_ref, "parallaxHeaderFactor", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, parallaxHeaderFactor_jfieldId);
			}
			set {
				if (parallaxHeaderFactor_jfieldId == IntPtr.Zero)
					parallaxHeaderFactor_jfieldId = JNIEnv.GetFieldID (class_ref, "parallaxHeaderFactor", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, parallaxHeaderFactor_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr toolbarTransparent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='toolbarTransparent']"
		[Register ("toolbarTransparent")]
		protected bool ToolbarTransparent {
			get {
				if (toolbarTransparent_jfieldId == IntPtr.Zero)
					toolbarTransparent_jfieldId = JNIEnv.GetFieldID (class_ref, "toolbarTransparent", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, toolbarTransparent_jfieldId);
			}
			set {
				if (toolbarTransparent_jfieldId == IntPtr.Zero)
					toolbarTransparent_jfieldId = JNIEnv.GetFieldID (class_ref, "toolbarTransparent", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, toolbarTransparent_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr viewpagerId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/field[@name='viewpagerId']"
		[Register ("viewpagerId")]
		protected int ViewpagerId {
			get {
				if (viewpagerId_jfieldId == IntPtr.Zero)
					viewpagerId_jfieldId = JNIEnv.GetFieldID (class_ref, "viewpagerId", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, viewpagerId_jfieldId);
			}
			set {
				if (viewpagerId_jfieldId == IntPtr.Zero)
					viewpagerId_jfieldId = JNIEnv.GetFieldID (class_ref, "viewpagerId", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, viewpagerId_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/github/florent37/materialviewpager/MaterialViewPagerSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MaterialViewPagerSettings); }
		}

		protected MaterialViewPagerSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/constructor[@name='MaterialViewPagerSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MaterialViewPagerSettings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MaterialViewPagerSettings)) {
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

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Florent37.Materialviewpager.MaterialViewPagerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Github.Florent37.Materialviewpager.MaterialViewPagerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_handleAttributes_Landroid_content_Context_Landroid_util_AttributeSet_;
#pragma warning disable 0169
		static Delegate GetHandleAttributes_Landroid_content_Context_Landroid_util_AttributeSet_Handler ()
		{
			if (cb_handleAttributes_Landroid_content_Context_Landroid_util_AttributeSet_ == null)
				cb_handleAttributes_Landroid_content_Context_Landroid_util_AttributeSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_HandleAttributes_Landroid_content_Context_Landroid_util_AttributeSet_);
			return cb_handleAttributes_Landroid_content_Context_Landroid_util_AttributeSet_;
		}

		static void n_HandleAttributes_Landroid_content_Context_Landroid_util_AttributeSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Github.Florent37.Materialviewpager.MaterialViewPagerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Github.Florent37.Materialviewpager.MaterialViewPagerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Util.IAttributeSet p1 = (global::Android.Util.IAttributeSet)global::Java.Lang.Object.GetObject<global::Android.Util.IAttributeSet> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.HandleAttributes (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_handleAttributes_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/method[@name='handleAttributes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register ("handleAttributes", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "GetHandleAttributes_Landroid_content_Context_Landroid_util_AttributeSet_Handler")]
		protected virtual unsafe void HandleAttributes (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
		{
			if (id_handleAttributes_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_handleAttributes_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "handleAttributes", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleAttributes_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleAttributes", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Github.Florent37.Materialviewpager.MaterialViewPagerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Github.Florent37.Materialviewpager.MaterialViewPagerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.florent37.materialviewpager']/class[@name='MaterialViewPagerSettings']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
