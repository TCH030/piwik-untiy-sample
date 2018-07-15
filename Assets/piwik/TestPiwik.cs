using UnityEngine;
using System.Collections;
using Piwik.Tracker;
using System.Threading;

public class TestPiwik : MonoBehaviour {

    private int SiteId = 7;
    private string PiwikBaseUrl = "http://ti15eb.asuscomm.com/piwik";
    string useridno = System.Guid.NewGuid().ToString().Substring(0, 15);


    // Use this for initialization
    void Start () {
        //首页

        //string UA = "unity3d";
        string UA = "Charome";
        var piwikTracker = new PiwikTracker(SiteId, PiwikBaseUrl);
        piwikTracker.SetCurrentUrl("http://ti15eb.asuscomm.com/myshoppingcar.html");
        piwikTracker.SetUserAgent(UA);
        piwikTracker.SetResolution(1600, 1400);
        piwikTracker.SetVisitorId("83c31B01394bdc65");
        piwikTracker.SetUserId(useridno);
        piwikTracker.SetResolution(1600, 1400);
        piwikTracker.SetCustomVariable(1, "age", "25");
        piwikTracker.SetCustomVariable(2, "Grender", "男");
        piwikTracker.SetCustomVariable(1, "variable1", "1", Scopes.Page);
        piwikTracker.SetCustomVariable(2, "variable2", "2", Scopes.Page);
        piwikTracker.SetTokenAuth("XYZ");
        var response = piwikTracker.DoTrackPageView("ShoppingCar");
        DisplayDebugInfo(response);

        Thread.Sleep(5000);

        piwikTracker = new PiwikTracker(SiteId, PiwikBaseUrl);
        piwikTracker.SetCurrentUrl("http://ti15eb.asuscomm.com/index.html");
        piwikTracker.SetUserAgent(UA);
        piwikTracker.SetResolution(1600, 1400);
        piwikTracker.SetVisitorId("83c31B01394bdc65");
        piwikTracker.SetUserId(useridno);
        piwikTracker.SetResolution(1600, 1400);
        piwikTracker.SetCustomVariable(1, "年龄", "25");
        piwikTracker.SetCustomVariable(2, "性别", "男");
        piwikTracker.SetCustomVariable(1, "页面变量1", "页面变量值1", Scopes.Page);
        piwikTracker.SetCustomVariable(2, "页面变量2", "页面变量值2", Scopes.Page);
        piwikTracker.SetTokenAuth("XYZ");
        response = piwikTracker.DoTrackPageView("Sales Management Page");
        DisplayDebugInfo(response);
                
        Thread.Sleep(10000);

        //周边配套
        piwikTracker = new PiwikTracker(SiteId, PiwikBaseUrl);
        piwikTracker.SetCurrentUrl("http://ti15eb.asuscomm.com/no_javascript.html");
        piwikTracker.SetUserAgent(UA);
        piwikTracker.SetResolution(1600, 1400);
        piwikTracker.SetVisitorId("83c31B01394bdc65");
        piwikTracker.SetUserId(useridno);
        response = piwikTracker.DoTrackPageView("周边配套");
        DisplayDebugInfo(response);
        
    }

    static private void DisplayDebugInfo(TrackingResponse response)
    {
        Debug.Log("DEBUG_LAST_REQUESTED_URL :");
        Debug.Log(response.RequestedUrl);
        Debug.Log("\r\n");
        Debug.Log(response.HttpStatusCode);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
