using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Getbase.Floatingactionbutton {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']"
	[global::Android.Runtime.Register ("com/getbase/floatingactionbutton/FloatingActionsMenu", DoNotGenerateAcw=true)]
	public partial class FloatingActionsMenu : global::Android.Views.ViewGroup {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/field[@name='EXPAND_DOWN']"
		[Register ("EXPAND_DOWN")]
		public const int ExpandDown = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/field[@name='EXPAND_LEFT']"
		[Register ("EXPAND_LEFT")]
		public const int ExpandLeft = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/field[@name='EXPAND_RIGHT']"
		[Register ("EXPAND_RIGHT")]
		public const int ExpandRight = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/field[@name='EXPAND_UP']"
		[Register ("EXPAND_UP")]
		public const int ExpandUp = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/field[@name='LABELS_ON_LEFT_SIDE']"
		[Register ("LABELS_ON_LEFT_SIDE")]
		public const int LabelsOnLeftSide = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/field[@name='LABELS_ON_RIGHT_SIDE']"
		[Register ("LABELS_ON_RIGHT_SIDE")]
		public const int LabelsOnRightSide = (int) 1;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu.LayoutParams']"
		[global::Android.Runtime.Register ("com/getbase/floatingactionbutton/FloatingActionsMenu$LayoutParams", DoNotGenerateAcw=true)]
		public partial class LayoutParams : global::Android.Views.ViewGroup.LayoutParams {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/getbase/floatingactionbutton/FloatingActionsMenu$LayoutParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LayoutParams); }
			}

			protected LayoutParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_getbase_floatingactionbutton_FloatingActionsMenu_Landroid_view_ViewGroup_LayoutParams_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu.LayoutParams']/constructor[@name='FloatingActionsMenu.LayoutParams' and count(parameter)=2 and parameter[1][@type='com.getbase.floatingactionbutton.FloatingActionsMenu'] and parameter[2][@type='android.view.ViewGroup.LayoutParams']]"
			[Register (".ctor", "(Lcom/getbase/floatingactionbutton/FloatingActionsMenu;Landroid/view/ViewGroup$LayoutParams;)V", "")]
			public unsafe LayoutParams (global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu __self, global::Android.Views.ViewGroup.LayoutParams p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (LayoutParams)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/ViewGroup$LayoutParams;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/ViewGroup$LayoutParams;)V", __args);
						return;
					}

					if (id_ctor_Lcom_getbase_floatingactionbutton_FloatingActionsMenu_Landroid_view_ViewGroup_LayoutParams_ == IntPtr.Zero)
						id_ctor_Lcom_getbase_floatingactionbutton_FloatingActionsMenu_Landroid_view_ViewGroup_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/getbase/floatingactionbutton/FloatingActionsMenu;Landroid/view/ViewGroup$LayoutParams;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_getbase_floatingactionbutton_FloatingActionsMenu_Landroid_view_ViewGroup_LayoutParams_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_getbase_floatingactionbutton_FloatingActionsMenu_Landroid_view_ViewGroup_LayoutParams_, __args);
				} finally {
				}
			}

			static Delegate cb_setAnimationsTarget_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetSetAnimationsTarget_Landroid_view_View_Handler ()
			{
				if (cb_setAnimationsTarget_Landroid_view_View_ == null)
					cb_setAnimationsTarget_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAnimationsTarget_Landroid_view_View_);
				return cb_setAnimationsTarget_Landroid_view_View_;
			}

			static void n_SetAnimationsTarget_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.LayoutParams __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.LayoutParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetAnimationsTarget (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setAnimationsTarget_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu.LayoutParams']/method[@name='setAnimationsTarget' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setAnimationsTarget", "(Landroid/view/View;)V", "GetSetAnimationsTarget_Landroid_view_View_Handler")]
			public virtual unsafe void SetAnimationsTarget (global::Android.Views.View p0)
			{
				if (id_setAnimationsTarget_Landroid_view_View_ == IntPtr.Zero)
					id_setAnimationsTarget_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setAnimationsTarget", "(Landroid/view/View;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAnimationsTarget_Landroid_view_View_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAnimationsTarget", "(Landroid/view/View;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.getbase.floatingactionbutton']/interface[@name='FloatingActionsMenu.OnFloatingActionsMenuUpdateListener']"
		[Register ("com/getbase/floatingactionbutton/FloatingActionsMenu$OnFloatingActionsMenuUpdateListener", "", "Com.Getbase.Floatingactionbutton.FloatingActionsMenu/IOnFloatingActionsMenuUpdateListenerInvoker")]
		public partial interface IOnFloatingActionsMenuUpdateListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/interface[@name='FloatingActionsMenu.OnFloatingActionsMenuUpdateListener']/method[@name='onMenuCollapsed' and count(parameter)=0]"
			[Register ("onMenuCollapsed", "()V", "GetOnMenuCollapsedHandler:Com.Getbase.Floatingactionbutton.FloatingActionsMenu/IOnFloatingActionsMenuUpdateListenerInvoker, FloatingActionButton")]
			void OnMenuCollapsed ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/interface[@name='FloatingActionsMenu.OnFloatingActionsMenuUpdateListener']/method[@name='onMenuExpanded' and count(parameter)=0]"
			[Register ("onMenuExpanded", "()V", "GetOnMenuExpandedHandler:Com.Getbase.Floatingactionbutton.FloatingActionsMenu/IOnFloatingActionsMenuUpdateListenerInvoker, FloatingActionButton")]
			void OnMenuExpanded ();

		}

		[global::Android.Runtime.Register ("com/getbase/floatingactionbutton/FloatingActionsMenu$OnFloatingActionsMenuUpdateListener", DoNotGenerateAcw=true)]
		internal class IOnFloatingActionsMenuUpdateListenerInvoker : global::Java.Lang.Object, IOnFloatingActionsMenuUpdateListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/getbase/floatingactionbutton/FloatingActionsMenu$OnFloatingActionsMenuUpdateListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnFloatingActionsMenuUpdateListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnFloatingActionsMenuUpdateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnFloatingActionsMenuUpdateListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.getbase.floatingactionbutton.FloatingActionsMenu.OnFloatingActionsMenuUpdateListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnFloatingActionsMenuUpdateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMenuCollapsed;
#pragma warning disable 0169
			static Delegate GetOnMenuCollapsedHandler ()
			{
				if (cb_onMenuCollapsed == null)
					cb_onMenuCollapsed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMenuCollapsed);
				return cb_onMenuCollapsed;
			}

			static void n_OnMenuCollapsed (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMenuCollapsed ();
			}
#pragma warning restore 0169

			IntPtr id_onMenuCollapsed;
			public unsafe void OnMenuCollapsed ()
			{
				if (id_onMenuCollapsed == IntPtr.Zero)
					id_onMenuCollapsed = JNIEnv.GetMethodID (class_ref, "onMenuCollapsed", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMenuCollapsed);
			}

			static Delegate cb_onMenuExpanded;
#pragma warning disable 0169
			static Delegate GetOnMenuExpandedHandler ()
			{
				if (cb_onMenuExpanded == null)
					cb_onMenuExpanded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMenuExpanded);
				return cb_onMenuExpanded;
			}

			static void n_OnMenuExpanded (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMenuExpanded ();
			}
#pragma warning restore 0169

			IntPtr id_onMenuExpanded;
			public unsafe void OnMenuExpanded ()
			{
				if (id_onMenuExpanded == IntPtr.Zero)
					id_onMenuExpanded = JNIEnv.GetMethodID (class_ref, "onMenuExpanded", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMenuExpanded);
			}

		}

		[global::Android.Runtime.Register ("mono/com/getbase/floatingactionbutton/FloatingActionsMenu_OnFloatingActionsMenuUpdateListenerImplementor")]
		internal sealed partial class IOnFloatingActionsMenuUpdateListenerImplementor : global::Java.Lang.Object, IOnFloatingActionsMenuUpdateListener {

			object sender;

			public IOnFloatingActionsMenuUpdateListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/getbase/floatingactionbutton/FloatingActionsMenu_OnFloatingActionsMenuUpdateListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnMenuCollapsedHandler;
#pragma warning restore 0649

			public void OnMenuCollapsed ()
			{
				var __h = OnMenuCollapsedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnMenuExpandedHandler;
#pragma warning restore 0649

			public void OnMenuExpanded ()
			{
				var __h = OnMenuExpandedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnFloatingActionsMenuUpdateListenerImplementor value)
			{
				return value.OnMenuCollapsedHandler == null && value.OnMenuExpandedHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu.RotatingDrawable']"
		[global::Android.Runtime.Register ("com/getbase/floatingactionbutton/FloatingActionsMenu$RotatingDrawable", DoNotGenerateAcw=true)]
		public partial class RotatingDrawable : global::Android.Graphics.Drawables.LayerDrawable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/getbase/floatingactionbutton/FloatingActionsMenu$RotatingDrawable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RotatingDrawable); }
			}

			protected RotatingDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_graphics_drawable_Drawable_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu.RotatingDrawable']/constructor[@name='FloatingActionsMenu.RotatingDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register (".ctor", "(Landroid/graphics/drawable/Drawable;)V", "")]
			public unsafe RotatingDrawable (global::Android.Graphics.Drawables.Drawable p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (RotatingDrawable)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/drawable/Drawable;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/graphics/drawable/Drawable;)V", __args);
						return;
					}

					if (id_ctor_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
						id_ctor_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/drawable/Drawable;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_drawable_Drawable_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_graphics_drawable_Drawable_, __args);
				} finally {
				}
			}

			static Delegate cb_getRotation;
#pragma warning disable 0169
			static Delegate GetGetRotationHandler ()
			{
				if (cb_getRotation == null)
					cb_getRotation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetRotation);
				return cb_getRotation;
			}

			static float n_GetRotation (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.RotatingDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.RotatingDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Rotation;
			}
#pragma warning restore 0169

			static Delegate cb_setRotation_F;
#pragma warning disable 0169
			static Delegate GetSetRotation_FHandler ()
			{
				if (cb_setRotation_F == null)
					cb_setRotation_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRotation_F);
				return cb_setRotation_F;
			}

			static void n_SetRotation_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.RotatingDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.RotatingDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Rotation = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getRotation;
			static IntPtr id_setRotation_F;
			public virtual unsafe float Rotation {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu.RotatingDrawable']/method[@name='getRotation' and count(parameter)=0]"
				[Register ("getRotation", "()F", "GetGetRotationHandler")]
				get {
					if (id_getRotation == IntPtr.Zero)
						id_getRotation = JNIEnv.GetMethodID (class_ref, "getRotation", "()F");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getRotation);
						else
							return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRotation", "()F"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu.RotatingDrawable']/method[@name='setRotation' and count(parameter)=1 and parameter[1][@type='float']]"
				[Register ("setRotation", "(F)V", "GetSetRotation_FHandler")]
				set {
					if (id_setRotation_F == IntPtr.Zero)
						id_setRotation_F = JNIEnv.GetMethodID (class_ref, "setRotation", "(F)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRotation_F, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRotation", "(F)V"), __args);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu.SavedState']"
		[global::Android.Runtime.Register ("com/getbase/floatingactionbutton/FloatingActionsMenu$SavedState", DoNotGenerateAcw=true)]
		public partial class SavedState : global::Android.Views.View.BaseSavedState {


			static IntPtr CREATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu.SavedState']/field[@name='CREATOR']"
			[Register ("CREATOR")]
			public static global::Android.OS.IParcelableCreator Creator {
				get {
					if (CREATOR_jfieldId == IntPtr.Zero)
						CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr mExpanded_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu.SavedState']/field[@name='mExpanded']"
			[Register ("mExpanded")]
			public bool MExpanded {
				get {
					if (mExpanded_jfieldId == IntPtr.Zero)
						mExpanded_jfieldId = JNIEnv.GetFieldID (class_ref, "mExpanded", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mExpanded_jfieldId);
				}
				set {
					if (mExpanded_jfieldId == IntPtr.Zero)
						mExpanded_jfieldId = JNIEnv.GetFieldID (class_ref, "mExpanded", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mExpanded_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/getbase/floatingactionbutton/FloatingActionsMenu$SavedState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SavedState); }
			}

			protected SavedState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_os_Parcelable_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu.SavedState']/constructor[@name='FloatingActionsMenu.SavedState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
			[Register (".ctor", "(Landroid/os/Parcelable;)V", "")]
			public unsafe SavedState (global::Android.OS.IParcelable p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (SavedState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcelable;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcelable;)V", __args);
						return;
					}

					if (id_ctor_Landroid_os_Parcelable_ == IntPtr.Zero)
						id_ctor_Landroid_os_Parcelable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcelable;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcelable_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcelable_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/getbase/floatingactionbutton/FloatingActionsMenu", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FloatingActionsMenu); }
		}

		protected FloatingActionsMenu (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/constructor[@name='FloatingActionsMenu' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe FloatingActionsMenu (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (FloatingActionsMenu)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/constructor[@name='FloatingActionsMenu' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe FloatingActionsMenu (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (FloatingActionsMenu)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/constructor[@name='FloatingActionsMenu' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe FloatingActionsMenu (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (FloatingActionsMenu)) {
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

		static Delegate cb_isExpanded;
#pragma warning disable 0169
		static Delegate GetIsExpandedHandler ()
		{
			if (cb_isExpanded == null)
				cb_isExpanded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExpanded);
			return cb_isExpanded;
		}

		static bool n_IsExpanded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExpanded;
		}
#pragma warning restore 0169

		static IntPtr id_isExpanded;
		public virtual unsafe bool IsExpanded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/method[@name='isExpanded' and count(parameter)=0]"
			[Register ("isExpanded", "()Z", "GetIsExpandedHandler")]
			get {
				if (id_isExpanded == IntPtr.Zero)
					id_isExpanded = JNIEnv.GetMethodID (class_ref, "isExpanded", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExpanded);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isExpanded", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_addButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_;
#pragma warning disable 0169
		static Delegate GetAddButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_Handler ()
		{
			if (cb_addButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_ == null)
				cb_addButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_);
			return cb_addButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_;
		}

		static void n_AddButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Getbase.Floatingactionbutton.FloatingActionButton p0 = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddButton (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/method[@name='addButton' and count(parameter)=1 and parameter[1][@type='com.getbase.floatingactionbutton.FloatingActionButton']]"
		[Register ("addButton", "(Lcom/getbase/floatingactionbutton/FloatingActionButton;)V", "GetAddButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_Handler")]
		public virtual unsafe void AddButton (global::Com.Getbase.Floatingactionbutton.FloatingActionButton p0)
		{
			if (id_addButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_ == IntPtr.Zero)
				id_addButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_ = JNIEnv.GetMethodID (class_ref, "addButton", "(Lcom/getbase/floatingactionbutton/FloatingActionButton;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addButton", "(Lcom/getbase/floatingactionbutton/FloatingActionButton;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_collapse;
#pragma warning disable 0169
		static Delegate GetCollapseHandler ()
		{
			if (cb_collapse == null)
				cb_collapse = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Collapse);
			return cb_collapse;
		}

		static void n_Collapse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Collapse ();
		}
#pragma warning restore 0169

		static IntPtr id_collapse;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/method[@name='collapse' and count(parameter)=0]"
		[Register ("collapse", "()V", "GetCollapseHandler")]
		public virtual unsafe void Collapse ()
		{
			if (id_collapse == IntPtr.Zero)
				id_collapse = JNIEnv.GetMethodID (class_ref, "collapse", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_collapse);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "collapse", "()V"));
			} finally {
			}
		}

		static Delegate cb_collapseImmediately;
#pragma warning disable 0169
		static Delegate GetCollapseImmediatelyHandler ()
		{
			if (cb_collapseImmediately == null)
				cb_collapseImmediately = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CollapseImmediately);
			return cb_collapseImmediately;
		}

		static void n_CollapseImmediately (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CollapseImmediately ();
		}
#pragma warning restore 0169

		static IntPtr id_collapseImmediately;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/method[@name='collapseImmediately' and count(parameter)=0]"
		[Register ("collapseImmediately", "()V", "GetCollapseImmediatelyHandler")]
		public virtual unsafe void CollapseImmediately ()
		{
			if (id_collapseImmediately == IntPtr.Zero)
				id_collapseImmediately = JNIEnv.GetMethodID (class_ref, "collapseImmediately", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_collapseImmediately);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "collapseImmediately", "()V"));
			} finally {
			}
		}

		static Delegate cb_expand;
#pragma warning disable 0169
		static Delegate GetExpandHandler ()
		{
			if (cb_expand == null)
				cb_expand = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Expand);
			return cb_expand;
		}

		static void n_Expand (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Expand ();
		}
#pragma warning restore 0169

		static IntPtr id_expand;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/method[@name='expand' and count(parameter)=0]"
		[Register ("expand", "()V", "GetExpandHandler")]
		public virtual unsafe void Expand ()
		{
			if (id_expand == IntPtr.Zero)
				id_expand = JNIEnv.GetMethodID (class_ref, "expand", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_expand);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "expand", "()V"));
			} finally {
			}
		}

		static Delegate cb_onLayout_ZIIII;
#pragma warning disable 0169
		static Delegate GetOnLayout_ZIIIIHandler ()
		{
			if (cb_onLayout_ZIIII == null)
				cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int, int, int>) n_OnLayout_ZIIII);
			return cb_onLayout_ZIIII;
		}

		static void n_OnLayout_ZIIII (IntPtr jnienv, IntPtr native__this, bool p0, int p1, int p2, int p3, int p4)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onLayout_ZIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected override unsafe void OnLayout (bool p0, int p1, int p2, int p3, int p4)
		{
			if (id_onLayout_ZIIII == IntPtr.Zero)
				id_onLayout_ZIIII = JNIEnv.GetMethodID (class_ref, "onLayout", "(ZIIII)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLayout_ZIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLayout", "(ZIIII)V"), __args);
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
			global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IParcelable p0 = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRestoreInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRestoreInstanceState_Landroid_os_Parcelable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/method[@name='onRestoreInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
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
			global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnSaveInstanceState ());
		}
#pragma warning restore 0169

		static IntPtr id_onSaveInstanceState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/method[@name='onSaveInstanceState' and count(parameter)=0]"
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

		static Delegate cb_removeButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_;
#pragma warning disable 0169
		static Delegate GetRemoveButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_Handler ()
		{
			if (cb_removeButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_ == null)
				cb_removeButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_);
			return cb_removeButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_;
		}

		static void n_RemoveButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Getbase.Floatingactionbutton.FloatingActionButton p0 = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionButton> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveButton (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/method[@name='removeButton' and count(parameter)=1 and parameter[1][@type='com.getbase.floatingactionbutton.FloatingActionButton']]"
		[Register ("removeButton", "(Lcom/getbase/floatingactionbutton/FloatingActionButton;)V", "GetRemoveButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_Handler")]
		public virtual unsafe void RemoveButton (global::Com.Getbase.Floatingactionbutton.FloatingActionButton p0)
		{
			if (id_removeButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_ == IntPtr.Zero)
				id_removeButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_ = JNIEnv.GetMethodID (class_ref, "removeButton", "(Lcom/getbase/floatingactionbutton/FloatingActionButton;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeButton_Lcom_getbase_floatingactionbutton_FloatingActionButton_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeButton", "(Lcom/getbase/floatingactionbutton/FloatingActionButton;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnFloatingActionsMenuUpdateListener_Lcom_getbase_floatingactionbutton_FloatingActionsMenu_OnFloatingActionsMenuUpdateListener_;
#pragma warning disable 0169
		static Delegate GetSetOnFloatingActionsMenuUpdateListener_Lcom_getbase_floatingactionbutton_FloatingActionsMenu_OnFloatingActionsMenuUpdateListener_Handler ()
		{
			if (cb_setOnFloatingActionsMenuUpdateListener_Lcom_getbase_floatingactionbutton_FloatingActionsMenu_OnFloatingActionsMenuUpdateListener_ == null)
				cb_setOnFloatingActionsMenuUpdateListener_Lcom_getbase_floatingactionbutton_FloatingActionsMenu_OnFloatingActionsMenuUpdateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnFloatingActionsMenuUpdateListener_Lcom_getbase_floatingactionbutton_FloatingActionsMenu_OnFloatingActionsMenuUpdateListener_);
			return cb_setOnFloatingActionsMenuUpdateListener_Lcom_getbase_floatingactionbutton_FloatingActionsMenu_OnFloatingActionsMenuUpdateListener_;
		}

		static void n_SetOnFloatingActionsMenuUpdateListener_Lcom_getbase_floatingactionbutton_FloatingActionsMenu_OnFloatingActionsMenuUpdateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListener p0 = (global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListener)global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnFloatingActionsMenuUpdateListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnFloatingActionsMenuUpdateListener_Lcom_getbase_floatingactionbutton_FloatingActionsMenu_OnFloatingActionsMenuUpdateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/method[@name='setOnFloatingActionsMenuUpdateListener' and count(parameter)=1 and parameter[1][@type='com.getbase.floatingactionbutton.FloatingActionsMenu.OnFloatingActionsMenuUpdateListener']]"
		[Register ("setOnFloatingActionsMenuUpdateListener", "(Lcom/getbase/floatingactionbutton/FloatingActionsMenu$OnFloatingActionsMenuUpdateListener;)V", "GetSetOnFloatingActionsMenuUpdateListener_Lcom_getbase_floatingactionbutton_FloatingActionsMenu_OnFloatingActionsMenuUpdateListener_Handler")]
		public virtual unsafe void SetOnFloatingActionsMenuUpdateListener (global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListener p0)
		{
			if (id_setOnFloatingActionsMenuUpdateListener_Lcom_getbase_floatingactionbutton_FloatingActionsMenu_OnFloatingActionsMenuUpdateListener_ == IntPtr.Zero)
				id_setOnFloatingActionsMenuUpdateListener_Lcom_getbase_floatingactionbutton_FloatingActionsMenu_OnFloatingActionsMenuUpdateListener_ = JNIEnv.GetMethodID (class_ref, "setOnFloatingActionsMenuUpdateListener", "(Lcom/getbase/floatingactionbutton/FloatingActionsMenu$OnFloatingActionsMenuUpdateListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnFloatingActionsMenuUpdateListener_Lcom_getbase_floatingactionbutton_FloatingActionsMenu_OnFloatingActionsMenuUpdateListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnFloatingActionsMenuUpdateListener", "(Lcom/getbase/floatingactionbutton/FloatingActionsMenu$OnFloatingActionsMenuUpdateListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_toggle;
#pragma warning disable 0169
		static Delegate GetToggleHandler ()
		{
			if (cb_toggle == null)
				cb_toggle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Toggle);
			return cb_toggle;
		}

		static void n_Toggle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu __this = global::Java.Lang.Object.GetObject<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Toggle ();
		}
#pragma warning restore 0169

		static IntPtr id_toggle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.getbase.floatingactionbutton']/class[@name='FloatingActionsMenu']/method[@name='toggle' and count(parameter)=0]"
		[Register ("toggle", "()V", "GetToggleHandler")]
		public virtual unsafe void Toggle ()
		{
			if (id_toggle == IntPtr.Zero)
				id_toggle = JNIEnv.GetMethodID (class_ref, "toggle", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toggle);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toggle", "()V"));
			} finally {
			}
		}

#region "Event implementation for Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListener"
		public event EventHandler MenuCollapsed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListener, global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListenerImplementor>(
						ref weak_implementor_SetOnFloatingActionsMenuUpdateListener,
						__CreateIOnFloatingActionsMenuUpdateListenerImplementor,
						SetOnFloatingActionsMenuUpdateListener,
						__h => __h.OnMenuCollapsedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListener, global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListenerImplementor>(
						ref weak_implementor_SetOnFloatingActionsMenuUpdateListener,
						global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListenerImplementor.__IsEmpty,
						__v => SetOnFloatingActionsMenuUpdateListener (null),
						__h => __h.OnMenuCollapsedHandler -= value);
			}
		}

		public event EventHandler MenuExpanded {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListener, global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListenerImplementor>(
						ref weak_implementor_SetOnFloatingActionsMenuUpdateListener,
						__CreateIOnFloatingActionsMenuUpdateListenerImplementor,
						SetOnFloatingActionsMenuUpdateListener,
						__h => __h.OnMenuExpandedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListener, global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListenerImplementor>(
						ref weak_implementor_SetOnFloatingActionsMenuUpdateListener,
						global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListenerImplementor.__IsEmpty,
						__v => SetOnFloatingActionsMenuUpdateListener (null),
						__h => __h.OnMenuExpandedHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnFloatingActionsMenuUpdateListener;

		global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListenerImplementor __CreateIOnFloatingActionsMenuUpdateListenerImplementor ()
		{
			return new global::Com.Getbase.Floatingactionbutton.FloatingActionsMenu.IOnFloatingActionsMenuUpdateListenerImplementor (this);
		}
#endregion
	}
}
