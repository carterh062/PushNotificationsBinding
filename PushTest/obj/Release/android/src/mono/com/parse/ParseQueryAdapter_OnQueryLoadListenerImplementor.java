package mono.com.parse;


public class ParseQueryAdapter_OnQueryLoadListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.parse.ParseQueryAdapter.OnQueryLoadListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onLoaded:(Ljava/util/List;Ljava/lang/Exception;)V:GetOnLoaded_Ljava_util_List_Ljava_lang_Exception_Handler:Com.Parse.ParseQueryAdapter/IOnQueryLoadListenerInvoker, ParseNotificationsDroidBinding\n" +
			"n_onLoading:()V:GetOnLoadingHandler:Com.Parse.ParseQueryAdapter/IOnQueryLoadListenerInvoker, ParseNotificationsDroidBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Parse.ParseQueryAdapter/IOnQueryLoadListenerImplementor, ParseNotificationsDroidBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ParseQueryAdapter_OnQueryLoadListenerImplementor.class, __md_methods);
	}


	public void onLoaded (java.util.List p0, java.lang.Exception p1)
	{
		n_onLoaded (p0, p1);
	}

	private native void n_onLoaded (java.util.List p0, java.lang.Exception p1);


	public void onLoading ()
	{
		n_onLoading ();
	}

	private native void n_onLoading ();

	java.util.ArrayList refList;
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
