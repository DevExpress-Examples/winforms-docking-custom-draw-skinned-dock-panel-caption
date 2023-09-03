<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128617118/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2502)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->

<!-- default file list end -->
# WinForms Docking - How to custom paint skinned dock panel captions

> **Important**
>
> This example uses internal APIs that may changed in newer versions.

This example demonstrates how to implement the `CustomDrawDockPanelCaption` event to paint dock panel captions.

![WinForms Docking - How to custom paint skinned dock panel captions](https://raw.githubusercontent.com/DevExpress-Examples/how-to-implement-the-custom-draw-functionality-for-skinned-dock-panels-e2502/16.1.4%2B/media/winforms-dockmanager-draw-panel-caption.png)


## Files to Review

* [Form1.cs](./CS/E2502/Form1.cs) (VB: [Form1.vb](./VB/E2502/Form1.vb))
* [MyCustomDrawArgs.cs](./CS/E2502/MyDockManager/MyCustomDrawArgs.cs) (VB: [MyCustomDrawArgs.vb](./VB/E2502/MyDockManager/MyCustomDrawArgs.vb))
* [MyDockElementsSkinPainter.cs](./CS/E2502/MyDockManager/MyDockElementsSkinPainter.cs) (VB: [MyDockElementsSkinPainter.vb](./VB/E2502/MyDockManager/MyDockElementsSkinPainter.vb))
* [MyDockLayout.cs](./CS/E2502/MyDockManager/MyDockLayout.cs) (VB: [MyDockLayout.vb](./VB/E2502/MyDockManager/MyDockLayout.vb))
* [MyDockManager.cs](./CS/E2502/MyDockManager/MyDockManager.cs) (VB: [MyDockManager.vb](./VB/E2502/MyDockManager/MyDockManager.vb))
* [MyDockPanel.cs](./CS/E2502/MyDockManager/MyDockPanel.cs) (VB: [MyDockPanel.vb](./VB/E2502/MyDockManager/MyDockPanel.vb))
* [MyPaintStyle.cs](./CS/E2502/MyDockManager/MyPaintStyle.cs) (VB: [MyPaintStyle.vb](./VB/E2502/MyDockManager/MyPaintStyle.vb))
* [MyWindowSkinPainter.cs](./CS/E2502/MyDockManager/MyWindowSkinPainter.cs) (VB: [MyWindowSkinPainter.vb](./VB/E2502/MyDockManager/MyWindowSkinPainter.vb))
