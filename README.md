# Unity Object Pool

A small 2D Unity project demonstrating object pooling with reusable arrows. Instead of creating and destroying an arrow every time, the project pre-instantiates arrows, disables them when they are no longer in use, and reuses them later.

## Features

- Pre-instantiates arrows when the pool starts.
- Reuses inactive arrows for shooting.
- Returns arrows to the pool after their lifetime expires.
- Includes a custom queue implementation.
- Includes Archer and arrow prefabs.

## Requirements

- Unity Editor 6000.6.0f1
- Universal Render Pipeline (URP), included through the project packages

## Getting Started

1. Clone or download this repository.
2. Open the project folder in Unity Hub using Unity Editor 6000.6.0f1.
3. Open `Assets/Scenes/SampleScene.unity`.
4. The scene's `Pool` object is configured with the arrow prefab and an initial pool size of 2,000.
5. To see the archer shoot, add the `Archer` prefab from `Assets/Prefabs` to the scene.
6. Press **Play**. The archer fires automatically; no keyboard input is required.

The shooting script looks for a GameObject named `Pool`. Keep that name unchanged, and make sure the `Pool` component has its arrow prefab and spawn point assigned.

## Project Structure

- `Assets/Scripts/ArcherShoot.cs` — Handles automatic shooting and retrieves arrows from the pool.
- `Assets/Scripts/Pool.cs` — Creates the initial set of arrows and stores them in the pool.
- `Assets/Scripts/Queue.cs` — Custom queue used to manage available arrows.
- `Assets/Scripts/Arrow.cs` — Moves arrows and returns them to the pool after their lifetime.
- `Assets/Prefabs/Archer.prefab` — Archer prefab.
- `Assets/Prefabs/arrow.prefab` — Reusable arrow prefab.
- `Assets/Scenes/SampleScene.unity` — Sample scene containing the pool setup.

## Configuration

The pool size is configured by the `amount` field on the `Pool` component. Shooting and arrow behavior can be adjusted in the scripts, including the firing interval, ammunition, arrow speed, and arrow lifetime.

## How It Works

1. `Pool` instantiates the configured number of arrows at startup and deactivates them.
2. `ArcherShoot` takes an inactive arrow from the queue, places it at the archer, and activates it.
3. `Arrow` moves while active.
4. When its lifetime expires, the arrow is deactivated and added back to the queue for reuse.
