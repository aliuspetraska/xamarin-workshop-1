# Xamarin Workshop #1 (Record Store Locator)

During this workshop Alius Petraška, Senior Developer at Adform, will cover the entire Xamarin platform including Xamarin.Forms. You will dive into tooling, project setup, controls, navigation, data-binding, and more fundamentals. You will also go deeper to cover tapping into native functionality, adding custom controls, animations, and advanced XAML data binding. By the end of the workshop you will have built your first mobile application with Xamarin.Forms from start to finish.

## Getting Started with XAML

1. Xamarin.Forms is a cross-platform UI toolkit that allows developers to efficiently create native user interface layouts that can be shared across iOS, Android, Windows Phone, Windows Store, and Universal Windows Platform apps. This series introduces the basics of Xamarin.Forms development and covers creating and running your first multi-platform application, and building multi-screen applications.

   https://developer.xamarin.com/guides/xamarin-forms/getting-started/

2. The NavigationPage class provides a hierarchical navigation experience where the user is able to navigate through pages, forwards and backwards, as desired. The class implements navigation as a last-in, first-out (LIFO) stack of Page objects. This article demonstrates how to use the NavigationPage class to perform navigation in a stack of pages.

   https://developer.xamarin.com/guides/xamarin-forms/user-interface/navigation/hierarchical/

3. In a Xamarin.Forms application, XAML is mostly used to define the visual contents of a page. A XAML file is always associated with a C# code file that provides code support for the markup. Together, these two files comprise a new class definition that includes child views and property initialization. Within the XAML file, classes and properties are referenced with XML elements and attributes, and links between the markup and code are established.

   https://developer.xamarin.com/guides/xamarin-forms/xaml/xaml-basics/getting_started_with_xaml/

4. XAML can be optionally compiled directly into intermediate language (IL) with the XAML compiler (XAMLC).

   https://developer.xamarin.com/guides/xamarin-forms/xaml/xamlc/

5. Xamarin.Forms uses use the native controls of each target platform. This means applications can use Portable Class Libraries or Shared Projects to house this shared code, and then make platform specific applications that will consume the shared code.

   https://developer.xamarin.com/guides/xamarin-forms/controls/

6. Grid supports arranging views into rows and columns. Rows and columns can be set to have proportional sizes or absolute sizes. The Grid layout should not be confused with traditional tables and is not intended to present tabular data. Grid does not have the concept of row, column or cell formatting. Unlike HTML tables, Grid is purely intended for laying out content.

   https://developer.xamarin.com/guides/xamarin-forms/user-interface/layouts/grid/

7. Images can be shared across platforms with Xamarin.Forms, they can be loaded specifically for each platform, or they can be downloaded for display.

   https://developer.xamarin.com/guides/xamarin-forms/working-with/images/
   
8. StackLayout organizes views in a one-dimensional line ("stack"), either horizontally or vertically. Views in a StackLayout can be sized based on the space in the layout using layout options. Positioning is determined by the order views were added to the layout and the layout options of the views.

   https://developer.xamarin.com/guides/xamarin-forms/user-interface/layouts/stack-layout/
   
9. A View control that provides a search box.

   https://developer.xamarin.com/api/type/Xamarin.Forms.SearchBar/
   
10. A visual control used to indicate that something is ongoing.

    https://developer.xamarin.com/api/type/Xamarin.Forms.ActivityIndicator/
   
11. A View that displays text.

    https://developer.xamarin.com/api/type/Xamarin.Forms.Label/
   
12. WebView is a view for displaying web and HTML content in your app. Unlike OpenUri, which takes the user to the web browser on the device, WebView displays the HTML content inside your app.

    https://developer.xamarin.com/guides/xamarin-forms/user-interface/webview/
   
## ListView

13. ListView is a view for presenting lists of data, especially long lists that require scrolling.

    https://developer.xamarin.com/guides/xamarin-forms/user-interface/listview/
   
14. Optimizing Xamarin.Forms Apps for Maximum Performance

    https://blog.xamarin.com/optimizing-xamarin-forms-apps-for-maximum-performance/
   
15. When the built-in cells aren't enough, custom cells can be used to present list data in a way that makes sense for your app. For example, you may want to present a cell with two labels that have equal weight. A LabelCell would be insufficient because the LabelCell has one label that is smaller.
   
    https://developer.xamarin.com/guides/xamarin-forms/user-interface/listview/customizing-cell-appearance/#Custom_Cells
   
## Navigation

16. Xamarin.Forms provides a number of different page navigation experiences, depending upon the Page type being used.

    https://developer.xamarin.com/guides/xamarin-forms/user-interface/navigation/
   
17. The NavigationPage class provides a hierarchical navigation experience where the user is able to navigate through pages, forwards and backwards, as desired. The class implements navigation as a last-in, first-out (LIFO) stack of Page objects. This article demonstrates how to use the NavigationPage class to perform navigation in a stack of pages.

    https://developer.xamarin.com/guides/xamarin-forms/user-interface/navigation/hierarchical/
   
## ObservableCollection

18. Represents a dynamic data collection that provides notifications when items get added, removed, or when the whole list is refreshed.

    https://developer.xamarin.com/api/type/System.Collections.ObjectModel.ObservableCollection%3CT%3E/

## Device.BeginInvoke

19. Invokes an Action on the device main (UI) thread.

    https://developer.xamarin.com/api/member/Xamarin.Forms.Device.BeginInvokeOnMainThread/p/System.Action/
    
20. The Device class contains a number of properties and methods to help developers customize layout and functionality on a per-platform basis.

    https://developer.xamarin.com/guides/xamarin-forms/platform-features/device/

## OnAppearing

21. When overridden, allows application developers to customize behavior immediately prior to the Page becoming visible.

    https://developer.xamarin.com/api/member/Xamarin.Forms.Page.OnAppearing/
    
## REST communication with your external data

22. RESTSharp, is powerful library for any kind of .NET technology. Especially for Mobile Phones where you have to use REST or SOAP to communicate with your external data.

    http://restsharp.org/
    
23. Popular high-performance JSON framework for .NET (Json.NET)

    http://www.newtonsoft.com/json

24. Generate c# classes from json

    http://json2csharp.com/

## Custom Controls

25. Circle Image Control Plugin for Xamarin.Forms. Simple but elegant way of display circle images in your Xamarin.Forms projects.

    https://github.com/jamesmontemagno/ImageCirclePlugin
   
26. Geolocator Plugin for Xamarin.Forms. Simple cross platform plugin to get GPS location including heading, speed, and more. Additionally, you can track geolocation changes.

    https://github.com/jamesmontemagno/GeolocatorPlugin
    
## vinylshop.herokuapp.com/api/

* http://vinylshop.herokuapp.com/api/getaddress.php
  
  Parameter | Type | Example
  ---|---|---
  lat | double | 37.785834
  lon | double | -122.406417
  
  Example: http://vinylshop.herokuapp.com/api/getaddress.php?lat=37.785834&lon=-122.406417

* http://vinylshop.herokuapp.com/api/getstores.php

  Parameter | Type | Example
  ---|---|---
  query | string | Tenderloin%252c%2BSan%2BFrancisco%252c%2BCA%252c%2BUSA
  
  Example: http://vinylshop.herokuapp.com/api/getstores.php?query=Tenderloin%252c%2BSan%2BFrancisco%252c%2BCA%252c%2BUSA

* http://vinylshop.herokuapp.com/api/showmap.php

  Parameter | Type | Example
  ---|---|---
  width | int | 375
  height | int | 603
  origin | string | Tenderloin%2c+San+Francisco%2c+CA%2c+USA
  destination | string | 1797+Market+St%2c+San+Francisco%2c+CA+94103%2c+United+States

  Example: http://vinylshop.herokuapp.com/api/showmap.php?width=375&height=603&origin=Tenderloin%2c+San+Francisco%2c+CA%2c+USA&destination=1797+Market+St%2c+San+Francisco%2c+CA+94103%2c+United+States