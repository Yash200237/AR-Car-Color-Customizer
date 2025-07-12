# 🎨 AR Car Color Customizer

A mobile AR application that lets you repaint a virtual car in real time—built with Unity & the Vuforia Engine for Android.

---

## 🚀 Demo

<table>
  <tr>
    <td align="center">
      <strong>Home Screen</strong><br>
      <img src="docs/home_screen.png" alt="Home Screen" width="260"/>
    </td>
    <td align="center">
      <strong>AR Car View</strong><br>
      <img src="docs/ar_scene.png" alt="AR Scene" width="260"/>
    </td>
    <td align="center">
      <strong>Pick a Color</strong><br>
      <img src="docs/color_palette.png" alt="Color Palette" width="260"/>
    </td>
  </tr>
</table>

## 🎬 Demo

Experience the app in action!  
<!-- Replace the URL or file path below with your actual demo video or GIF -->
[![Watch the Demo](docs/demo_thumbnail.png)](https://youtu.be/your-demo-link)

> Or embed a looping GIF:
> ```markdown
> ![App Demo](docs/demo.gif)
> ```

---

## 💡 What It Does

1. **Home Page**  
   After installing the APK, you land on a clean, minimal welcome screen. Tap the ▶️ arrow to jump into the AR experience.

2. **AR Marker Scan**  
   The app activates your camera. Scan the printed (or on-screen) marker to spawn a sleek 3D car model in your real environment.

3. **Rotate & Paint**  
   - The car rotates slowly so you can examine every angle.  
   - A row of color swatches appears at the bottom.  
   - Tap any swatch to instantly repaint the car’s body—no reload required!

4. **Visual Feedback**  
   Watch how each color interacts with the car’s materials and reflections in real time.

---

## ✨ Features

- **Seamless AR** using Vuforia’s robust image-target tracking  
- **Real-time color swapping** with 10+ preset shades  
- **Touch-driven UI** optimized for mobile  
- **Lightweight Android APK** (< 80 MB)  
- **Extendable framework**—swap in your own 3D models or colors

---

## 🛠️ Built With

- [Unity 2021+](https://unity.com/)  
- [Vuforia Engine](https://developer.vuforia.com/) (via UPM)  
- C# scripting for color & rotation logic  
- Android SDK & NDK

---

## 🔧 Getting Started

### Prerequisites

- Android device running Android 7.0+  
- Unity Editor (tested on 2021.3 LTS)  
- Vuforia Engine package installed via Unity Package Manager  

### Installation

1. **Clone this repo**  
   ```bash
   git clone https://github.com/your-username/AR-Car-Color-Customizer.git
   cd AR-Car-Color-Customizer
