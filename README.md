# 🐦 Flappy Bird 2D — Unity Passion Project

This is a hands-on learning and passion project built in Unity using C#. It was created to master the fundamentals of 2D game development—specifically focus-firing on Unity's physics systems, user input handling, and synchronized sprite animations. 

This project represents the foundation of my game development journey, and I plan to continuously polish, optimize, and add features to it down the line.

---

## 🎮 Gameplay Demo

<!-- TIP: Record a 5-second GIF of your game playing, drag the .gif file directly into this editor, and GitHub will automatically generate the code to display it! -->
![Gameplay Preview](your-gif-link-here.gif)

---

## 🛠️ Technical Highlights

* **Input-Synchronized Animation:** Instead of letting the wings flap on an endless loop, I mapped the animation directly to the spacebar. The bird flaps exactly when the player jumps, creating punchy, responsive visual feedback.
* **Physics & Collision Management:** Leveraged Unity's 2D physics engine (`Rigidbody2D`) to manage gravity and jump velocity, paired with custom 2D collision triggers to handle seamless game-over states.
* **Clean Code Architecture:** Structured with a dedicated game manager (`LogicScript`) handling overall game states while the bird handles its own physics and animations.

---

## 💻 Code Spotlight: Synchronized Flap

This excerpt from `BirdScript.cs` highlights how I synchronized the physical jump force with the visual sprite sheet animation to ensure the action feels highly responsive to the player:

```csharp
// Inside Update(), running every frame
if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
{
    // Apply instant upward physical velocity
    myRigidbody.linearVelocity = Vector2.up * flapStrength;
    
    // Play the flap animation cycle from frame zero instantly
    birdAnimator.Play("Bird_Flap_Cycle", -1, 0f);
}

---

🚀 The Polish Road Map (Upcoming Features)
As part of my continuous learning path, I plan to build upon this strong foundation with the following features:

[ ] Dynamic Environment: Implement an automatic cloud spawner that randomly scales and drifts individual background clouds for added depth.

[ ] Audio & SFX: Add crisp 8-bit sound effects synchronized with jumping and hitting obstacles.

[ ] UI/UX Polish: Build a main menu and high-score saving system.
