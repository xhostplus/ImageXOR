ImageXOR
========

Two Time Pad Demonstration with Images

**How does it work**

This application shows how using the same key multiple times in a One Time Pad encryption can lead to an attacker gathering information.  Using images is an easy way to demonstrate this effect.  Once the key and images are loaded, the difference image can easily be recognized.

**To use ImageXOR**

1. Click the _Generate Random Key_ button to create a unique 128x128 random image.
2. Click the _Load Image Message 1_ button to load a 128x128 image (a few sample images are provided in the Images folder).
3. Click the _Load Image Message 2_ button to load a different 128x128 image.
4. Notice both C1 and C2 are generated.  These are the ciphertexts of Message 1 and Message 2 respectively.
5. Notice the C1 XOR C2 image contains the difference of the original messages.

![alt tag](https://raw.githubusercontent.com/xhostplus/ImageXOR/master/Images/Screenshot.png)
