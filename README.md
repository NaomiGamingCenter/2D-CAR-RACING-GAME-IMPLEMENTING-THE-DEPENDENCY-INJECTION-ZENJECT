# 2D-CAR-RACING-GAME-IMPLEMENTING-THE-DEPENDENCY-INJECTION-ZENJECT
Zenject is a lightweight highly performant dependency injection framework built specifically to target Unity 3D (however it can be used outside of Unity as well). It can be used to turn your application into a collection of loosely coupled parts with highly segmented responsibilities
I use zenject to call the script uiManager to the script carController. This is because the instance uiManager can be called many times.
Zenject allows me to edit the frequently called class. Without having to make changes to the script that is calling it.
Zenject is used in place of GetObject<>(); and FindObjectofType<>();, but in zenject you dont have to edit the code dependancies


https://user-images.githubusercontent.com/119212839/206856067-3eab9437-3706-44f8-82cf-f7a64c61a20a.mp4

