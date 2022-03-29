package crc64572abb00d954e03d;


public class CameraViewRenderer_TorchStateObserver
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.lifecycle.Observer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onChanged:(Ljava/lang/Object;)V:GetOnChanged_Ljava_lang_Object_Handler:AndroidX.Lifecycle.IObserverInvoker, Xamarin.AndroidX.Lifecycle.LiveData.Core\n" +
			"";
		mono.android.Runtime.register ("GoogleVisionBarCodeScanner.Renderer.CameraViewRenderer+TorchStateObserver, BarcodeScanner.XF", CameraViewRenderer_TorchStateObserver.class, __md_methods);
	}


	public CameraViewRenderer_TorchStateObserver ()
	{
		super ();
		if (getClass () == CameraViewRenderer_TorchStateObserver.class)
			mono.android.TypeManager.Activate ("GoogleVisionBarCodeScanner.Renderer.CameraViewRenderer+TorchStateObserver, BarcodeScanner.XF", "", this, new java.lang.Object[] {  });
	}

	public CameraViewRenderer_TorchStateObserver (crc64572abb00d954e03d.CameraViewRenderer p0)
	{
		super ();
		if (getClass () == CameraViewRenderer_TorchStateObserver.class)
			mono.android.TypeManager.Activate ("GoogleVisionBarCodeScanner.Renderer.CameraViewRenderer+TorchStateObserver, BarcodeScanner.XF", "GoogleVisionBarCodeScanner.Renderer.CameraViewRenderer, BarcodeScanner.XF", this, new java.lang.Object[] { p0 });
	}


	public void onChanged (java.lang.Object p0)
	{
		n_onChanged (p0);
	}

	private native void n_onChanged (java.lang.Object p0);

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
