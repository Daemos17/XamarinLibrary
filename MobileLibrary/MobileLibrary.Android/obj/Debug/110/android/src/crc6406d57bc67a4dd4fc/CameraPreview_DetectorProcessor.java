package crc6406d57bc67a4dd4fc;


public class CameraPreview_DetectorProcessor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.vision.Detector.Processor
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_receiveDetections:(Lcom/google/android/gms/vision/Detector$Detections;)V:GetReceiveDetections_Lcom_google_android_gms_vision_Detector_Detections_Handler:Android.Gms.Vision.Detector/IProcessorInvoker, Xamarin.GooglePlayServices.Vision.Common\n" +
			"n_release:()V:GetReleaseHandler:Android.Gms.Vision.Detector/IProcessorInvoker, Xamarin.GooglePlayServices.Vision.Common\n" +
			"";
		mono.android.Runtime.register ("GoogleVisionBarCodeScanner.CameraPreview+DetectorProcessor, BarcodeScanner.XF", CameraPreview_DetectorProcessor.class, __md_methods);
	}


	public CameraPreview_DetectorProcessor ()
	{
		super ();
		if (getClass () == CameraPreview_DetectorProcessor.class)
			mono.android.TypeManager.Activate ("GoogleVisionBarCodeScanner.CameraPreview+DetectorProcessor, BarcodeScanner.XF", "", this, new java.lang.Object[] {  });
	}

	public CameraPreview_DetectorProcessor (android.content.Context p0, boolean p1)
	{
		super ();
		if (getClass () == CameraPreview_DetectorProcessor.class)
			mono.android.TypeManager.Activate ("GoogleVisionBarCodeScanner.CameraPreview+DetectorProcessor, BarcodeScanner.XF", "Android.Content.Context, Mono.Android:System.Boolean, mscorlib", this, new java.lang.Object[] { p0, p1 });
	}


	public void receiveDetections (com.google.android.gms.vision.Detector.Detections p0)
	{
		n_receiveDetections (p0);
	}

	private native void n_receiveDetections (com.google.android.gms.vision.Detector.Detections p0);


	public void release ()
	{
		n_release ();
	}

	private native void n_release ();

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
