package crc6406d57bc67a4dd4fc;


public class CameraPreview_SurfaceHolderCallback
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.view.SurfaceHolder.Callback
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_surfaceChanged:(Landroid/view/SurfaceHolder;III)V:GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler:Android.Views.ISurfaceHolderCallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_surfaceCreated:(Landroid/view/SurfaceHolder;)V:GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler:Android.Views.ISurfaceHolderCallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_surfaceDestroyed:(Landroid/view/SurfaceHolder;)V:GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler:Android.Views.ISurfaceHolderCallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("GoogleVisionBarCodeScanner.CameraPreview+SurfaceHolderCallback, BarcodeScanner.XF", CameraPreview_SurfaceHolderCallback.class, __md_methods);
	}


	public CameraPreview_SurfaceHolderCallback ()
	{
		super ();
		if (getClass () == CameraPreview_SurfaceHolderCallback.class)
			mono.android.TypeManager.Activate ("GoogleVisionBarCodeScanner.CameraPreview+SurfaceHolderCallback, BarcodeScanner.XF", "", this, new java.lang.Object[] {  });
	}

	public CameraPreview_SurfaceHolderCallback (com.google.android.gms.vision.CameraSource p0, android.view.SurfaceView p1)
	{
		super ();
		if (getClass () == CameraPreview_SurfaceHolderCallback.class)
			mono.android.TypeManager.Activate ("GoogleVisionBarCodeScanner.CameraPreview+SurfaceHolderCallback, BarcodeScanner.XF", "Android.Gms.Vision.CameraSource, Xamarin.GooglePlayServices.Vision.Common:Android.Views.SurfaceView, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public void surfaceChanged (android.view.SurfaceHolder p0, int p1, int p2, int p3)
	{
		n_surfaceChanged (p0, p1, p2, p3);
	}

	private native void n_surfaceChanged (android.view.SurfaceHolder p0, int p1, int p2, int p3);


	public void surfaceCreated (android.view.SurfaceHolder p0)
	{
		n_surfaceCreated (p0);
	}

	private native void n_surfaceCreated (android.view.SurfaceHolder p0);


	public void surfaceDestroyed (android.view.SurfaceHolder p0)
	{
		n_surfaceDestroyed (p0);
	}

	private native void n_surfaceDestroyed (android.view.SurfaceHolder p0);

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
