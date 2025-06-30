# YYCSharpLab

A personal C#/.NET framework lab for reusable, modular, and extensible engineering tools.
這是我的 C#/.NET 個人工具與模組化練習專案，包含多種可重用元件與範例應用程式。

---

## 🗂️ Solution Structure

~~~
YYCSharpLab/
├─ Applications/ # 範例/測試應用程式
│ ├─ Project_ImageViewer
│ └─ Project_TrafficLight_StatePattern
├─ Libraries/ # 各類通用程式庫
│ ├─ CollectionUtilities
│ ├─ CustomControls
│ ├─ DateTimeUtilities
│ ├─ FileUtilities
│ ├─ ImageProcessingUtilities
│ ├─ ImageViewerApp
│ ├─ MathUtilities
│ ├─ RJContumControls
├─ Plugins/ # 插件式元件（可擴充架構）
├─ SharedResources/ # 共用資源（圖示、配置檔等）
├─ Tests/ # 測試專案
└─ YYCSharpLab.sln
~~~

---

## 📦 **Projects Overview 專案說明**

### **Applications/**
- `Project_ImageViewer`  
  WinForms 圖像檢視器範例，支援插件 Overlay。
- `Project_TrafficLight_StatePattern`  
  燈號控制與狀態機範例。

### **Libraries/**
- `CollectionUtilities`  
  集合、Dictionary 等泛型工具方法。
- `CustomControls`  
  WinForms/WPF 自訂控制項、對話框、UI 編輯器。
- `DateTimeUtilities`  
  時間/日期相關工具。
- `FileUtilities`  
  檔案/資料夾處理工具。
- `ImageProcessingUtilities`  
  影像處理演算法。
- `ImageViewerApp`  
  可重用的圖像檢視元件（UserControl）。
- `MathUtilities`  
  數學/數值演算法（如高斯擬合、統計等）。
- `RJContumControls`  
  第三方或自訂UI元件集。

### **Plugins/**
- 插件式設計之可擴充功能模組。

### **SharedResources/**
- 全局共用資源（icon、共用 config、預設參數等）。

### **Tests/**
- 單元測試與集成測試專案。

---


---

## 📦 **Projects Overview 專案說明**

### **Applications/**
- `Project_ImageViewer`  
  WinForms 圖像檢視器範例，支援插件 Overlay。
- `Project_TrafficLight_StatePattern`  
  燈號控制與狀態機範例。

### **Libraries/**
- `CollectionUtilities`  
  集合、Dictionary 等泛型工具方法。
- `CustomControls`  
  WinForms/WPF 自訂控制項、對話框、UI 編輯器。
- `DateTimeUtilities`  
  時間/日期相關工具。
- `FileUtilities`  
  檔案/資料夾處理工具。
- `ImageProcessingUtilities`  
  影像處理演算法。
- `ImageViewerApp`  
  可重用的圖像檢視元件（UserControl）。
- `MathUtilities`  
  數學/數值演算法（如高斯擬合、統計等）。
- `RJContumControls`  
  第三方或自訂UI元件集。

### **Plugins/**
- 插件式設計之可擴充功能模組。

### **SharedResources/**
- 全局共用資源（icon、共用 config、預設參數等）。

### **Tests/**
- 單元測試與集成測試專案。

---

## 📝 **How to Use 使用說明**

1. Clone or fork this repository.
2. Open `YYCSharpLab.sln` with Visual Studio 2019+ (build with .NET Framework 4.8).
3. Explore the `Applications` folder for usage examples, or reference any library in your own project.

---

## 💡 **Why this repo?**

本專案用於平時練習、累積可重用模組、快速驗證設計概念，以及團隊新成員 onboarding。

---

## 📄 **License**

*個人練習用，如需商業/公司內部共用，請先聯絡本人協議授權。*

