package md5b2869bd247eccacecd936a60287d06ac;


public class MainActivity_HybridWebViewClient
	extends android.webkit.WebViewClient
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLoadResource:(Landroid/webkit/WebView;Ljava/lang/String;)V:GetOnLoadResource_Landroid_webkit_WebView_Ljava_lang_String_Handler\n" +
			"";
		mono.android.Runtime.register ("IDCoinAndroid.MainActivity+HybridWebViewClient, IDCoinAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity_HybridWebViewClient.class, __md_methods);
	}


	public MainActivity_HybridWebViewClient () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainActivity_HybridWebViewClient.class)
			mono.android.TypeManager.Activate ("IDCoinAndroid.MainActivity+HybridWebViewClient, IDCoinAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onLoadResource (android.webkit.WebView p0, java.lang.String p1)
	{
		n_onLoadResource (p0, p1);
	}

	private native void n_onLoadResource (android.webkit.WebView p0, java.lang.String p1);

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
