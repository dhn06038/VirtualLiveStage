# VirtualLiveStage

The **VirtualLiveStage** repository is dedicated to creating live stages in virtual environments using Unreal Engine and Unity. This project aims to enable musicians, virtual singers, and performers to host live shows in virtual worlds and stream them online.

## Project Overview

### Engines Used
- **Unreal Engine (5.4.3)**
- **Unity**

### Folder Structure

1. **VLStage_Unreal**
   - This folder contains the Unreal Engine project, including stage modeling and the DMX plugin setup to connect MagicQ with Unreal Engine. I am using Unreal’s built-in DMX plugin to achieve this connection.

2. **VLStage_Unity**
   - This folder is set up for the Unity project and contains stage modeling and a custom DMX package. For DMX integration in Unity, I am using a custom package from [igolinin's DMXtools](https://github.com/igolinin/DMXtools).

3. **VirtualStudio**
   - This is the main project folder containing the completed Unreal Engine 5.4.3 project. It includes a demo light show synchronized to a song from YouTube, showcasing the potential of virtual stage design. The light show was primarily created using the MagicQ software to design the timeline, with the option for real-time interaction between MagicQ and Unreal Engine’s light objects via the DMX plugin. The demo video was captured using Unreal’s CineCamera.

### Lighting Implementation with DMX and MagicQ

For stage lighting, this project uses the DMX tool MagicQ by Chamsys. MagicQ offers several advantages for implementing a stage lighting system within Unreal and Unity environments:

- **Precision**: MagicQ provides precise control over lighting, ideal for creating intricate light shows.
- **Integration**: Seamless integration with Unreal Engine through its DMX plugin allows for real-time interaction between MagicQ and Unreal’s light objects.
- **Flexibility**: MagicQ supports both timeline-based light shows and real-time interaction, offering a versatile approach to stage lighting.

In Unity, the custom DMX package from [igolinin](https://github.com/igolinin/DMXtools) is used to achieve similar integration, allowing for the creation of dynamic light shows within the Unity environment.

### Future Work

I plan to continue working on the Unity project, comparing the strengths and weaknesses of both Unreal Engine and Unity in the context of virtual stage design. This comparison will help identify the best practices for creating immersive virtual live performances in both environments.

Stay tuned for updates as I continue to explore and develop this exciting project!
