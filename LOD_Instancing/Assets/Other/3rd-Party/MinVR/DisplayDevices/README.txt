============================== V2.0 ==============================
0. Currently, in VRDisplayDevices V2.0,
Cave               has four quad-buffered stereo walls.
CaveNonStereo      has four non-stereo walls.
CoffeyTable        has one quad-buffered stereo wall, one non-stereo wall, one side-by-side stereo table, one non-stereo table (parallel projection). 

!!! Make sure "Virtual Reality Support" is checked and "Stereo Display (non head-mounted)" is on the top in the Player Settings !!!
!!! V2 is different from V1 in that... it is using Unity3D built-in features for quad-buffered stereo; V1 used DLL injections !!!


============================== Legacy ==============================
!!! V2 is different from V1 in that... it is using Unity3D built-in features for quad-buffered stereo; V1 used DLL injections !!!


============================== Notes ==============================
1. Making a new device
You can use the walls or the tables in the existing prefabs to compose a new one. 
[info] We could have built bases of display devices (such as quad-buffered stereo, side-by-side, non-stereo walls) as prefabs and use those to compose the Cave, CaveNonStereo and CoffeyTable. But we decided not to do this because user might mistakenly change the base prefabs, which might affect all the associated display devices. We decided that each display device is an unique prefab (i.e. it is not a composition of other prefabs). Therefore every display devices are localized (immune to the mistakes, which spread over all the display devices). 

3. Support for Head Mount Display (HMD)
Starting V1.2, we no longer supports HMD (we used to support iPhone 4). Google Cardboard Unity SDK supports multiple hand-held display devices (including iPhones and some Android devices). If you want a HMD with MinVR2, import the Cardboard SDK, apply the position and rotation from the data received from the MinVR server (see how each wall is positioning its cameras - see VRTrackerListener script in one of the Cave walls). Make sure to turn off the position and rotation tracking from the Google Cardboard SDK (so it does not override MinVR's position and rotation tracking). In the current version of the Cardboard SDK, V0.5.2, check off "Track Position" and "Track Rotation" in CardboardHead script in Head gameobject, which is under CardboardMain gameobjct.
