package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ViewStub_OnInflateListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.view.ViewStub.OnInflateListener
{
	static
	{
		MonoBridge.link(ViewStub_OnInflateListenerDelegateWrapper.class, "onInflate", "(Landroid/view/ViewStub;Landroid/view/View;)V", "android.view.ViewStub,android.view.View");

	}

	@Override
	public native void onInflate(android.view.ViewStub arg0,android.view.View arg1);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}