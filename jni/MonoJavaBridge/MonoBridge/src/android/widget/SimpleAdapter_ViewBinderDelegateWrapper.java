package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class SimpleAdapter_ViewBinderDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.SimpleAdapter.ViewBinder
{
	static
	{
		MonoBridge.link(SimpleAdapter_ViewBinderDelegateWrapper.class, "setViewValue", "(Landroid/view/View;Ljava/lang/Object;Ljava/lang/String;)Z", "android.view.View,java.lang.Object,java.lang.String");

	}

	@Override
	public native boolean setViewValue(android.view.View arg0,java.lang.Object arg1,java.lang.String arg2);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}