package crc64572abb00d954e03d;


public class CameraViewRenderer_BarcodeAnalyzer
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.camera.core.ImageAnalysis.Analyzer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_analyze:(Landroidx/camera/core/ImageProxy;)V:GetAnalyze_Landroidx_camera_core_ImageProxy_Handler:AndroidX.Camera.Core.ImageAnalysis/IAnalyzerInvoker, Xamarin.AndroidX.Camera.Core\n" +
			"";
		mono.android.Runtime.register ("GoogleVisionBarCodeScanner.Renderer.CameraViewRenderer+BarcodeAnalyzer, BarcodeScanner.XF", CameraViewRenderer_BarcodeAnalyzer.class, __md_methods);
	}


	public CameraViewRenderer_BarcodeAnalyzer ()
	{
		super ();
		if (getClass () == CameraViewRenderer_BarcodeAnalyzer.class)
			mono.android.TypeManager.Activate ("GoogleVisionBarCodeScanner.Renderer.CameraViewRenderer+BarcodeAnalyzer, BarcodeScanner.XF", "", this, new java.lang.Object[] {  });
	}

	public CameraViewRenderer_BarcodeAnalyzer (crc64572abb00d954e03d.CameraViewRenderer p0)
	{
		super ();
		if (getClass () == CameraViewRenderer_BarcodeAnalyzer.class)
			mono.android.TypeManager.Activate ("GoogleVisionBarCodeScanner.Renderer.CameraViewRenderer+BarcodeAnalyzer, BarcodeScanner.XF", "GoogleVisionBarCodeScanner.Renderer.CameraViewRenderer, BarcodeScanner.XF", this, new java.lang.Object[] { p0 });
	}


	public void analyze (androidx.camera.core.ImageProxy p0)
	{
		n_analyze (p0);
	}

	private native void n_analyze (androidx.camera.core.ImageProxy p0);

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
