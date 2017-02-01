package md57c19df6033cd7d8e88bdcfe10c84fa68;


public class FloatingActionButton
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("XamarinControls.FloatingActionButton, XamarinControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", FloatingActionButton.class, __md_methods);
	}


	public FloatingActionButton () throws java.lang.Throwable
	{
		super ();
		if (getClass () == FloatingActionButton.class)
			mono.android.TypeManager.Activate ("XamarinControls.FloatingActionButton, XamarinControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
