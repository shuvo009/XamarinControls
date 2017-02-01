package mono.com.astuetz;


public class PagerSlidingTabStrip_OnTabReselectedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.astuetz.PagerSlidingTabStrip.OnTabReselectedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTabReselected:(I)V:GetOnTabReselected_IHandler:Com.Astuetz.PagerSlidingTabStrip/IOnTabReselectedListenerInvoker, Binding_Materialtabstrip\n" +
			"";
		mono.android.Runtime.register ("Com.Astuetz.PagerSlidingTabStrip+IOnTabReselectedListenerImplementor, Binding_Materialtabstrip, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PagerSlidingTabStrip_OnTabReselectedListenerImplementor.class, __md_methods);
	}


	public PagerSlidingTabStrip_OnTabReselectedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PagerSlidingTabStrip_OnTabReselectedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Astuetz.PagerSlidingTabStrip+IOnTabReselectedListenerImplementor, Binding_Materialtabstrip, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onTabReselected (int p0)
	{
		n_onTabReselected (p0);
	}

	private native void n_onTabReselected (int p0);

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
