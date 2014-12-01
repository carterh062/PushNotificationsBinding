package mono.com.parse.signpost;


public class OAuthProviderListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.parse.signpost.OAuthProviderListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onResponseReceived:(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpResponse;)Z:GetOnResponseReceived_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpResponse_Handler:Com.Parse.Signpost.IOAuthProviderListenerInvoker, ParseNotificationsDroidBinding\n" +
			"n_prepareRequest:(Lcom/parse/signpost/http/HttpRequest;)V:GetPrepareRequest_Lcom_parse_signpost_http_HttpRequest_Handler:Com.Parse.Signpost.IOAuthProviderListenerInvoker, ParseNotificationsDroidBinding\n" +
			"n_prepareSubmission:(Lcom/parse/signpost/http/HttpRequest;)V:GetPrepareSubmission_Lcom_parse_signpost_http_HttpRequest_Handler:Com.Parse.Signpost.IOAuthProviderListenerInvoker, ParseNotificationsDroidBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Parse.Signpost.IOAuthProviderListenerImplementor, ParseNotificationsDroidBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OAuthProviderListenerImplementor.class, __md_methods);
	}


	public boolean onResponseReceived (com.parse.signpost.http.HttpRequest p0, com.parse.signpost.http.HttpResponse p1)
	{
		return n_onResponseReceived (p0, p1);
	}

	private native boolean n_onResponseReceived (com.parse.signpost.http.HttpRequest p0, com.parse.signpost.http.HttpResponse p1);


	public void prepareRequest (com.parse.signpost.http.HttpRequest p0)
	{
		n_prepareRequest (p0);
	}

	private native void n_prepareRequest (com.parse.signpost.http.HttpRequest p0);


	public void prepareSubmission (com.parse.signpost.http.HttpRequest p0)
	{
		n_prepareSubmission (p0);
	}

	private native void n_prepareSubmission (com.parse.signpost.http.HttpRequest p0);

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
