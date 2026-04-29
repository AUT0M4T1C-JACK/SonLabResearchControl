# Research Control

This Unity project controls experiments on the Meta Quest 3 using networked Photon PUN (Photon Unity Networking) to synchronize interactions between a control device and the headset. It manages visual displays, heartbeat stimuli, pricing reveals, and scene transitions.

## Quick Start

### Prerequisites
- Unity (version compatible with this project)
- Photon PUN 2 networking library (already included)
- Meta Quest 3 with connected tracking

### Getting Started

1. **Open the Project**: Load this project in Unity.
2. **Main Scene**: Navigate to the main scene that contains UI buttons for experiment controls.
3. **Network Connection**: The `ControlScript` automatically connects to Photon when the scene starts and creates/joins a room.
4. **Run**: Press Play to start the networking connection and UI controls.

---

## Scripts Overview

### 1. **ControlScript.cs**
**Purpose**: Main networking controller that sends experiment commands from the control interface to all connected devices.

**Setup in Scene**:
- Attach this script to an empty GameObject (e.g., `ControlManager`)
- The script automatically initializes Photon networking on Start
- No inspector configuration needed—it handles connection automatically

**Functionality**:
- Connects to Photon Master Server on startup
- Creates or joins a hidden room for up to 4 players
- Provides public methods for UI buttons to trigger networked events:
  - **Heartbeat Control**: `StartHeartbeatButtonClicked()` / `StopHeartbeatButtonClicked()`
  - **Price Reveals**: `RevealPrice1ButtonClicked()` through `RevealPrice5ButtonClicked()` and `HideAllPricesButtonClicked()`
  - **Scene Loading**: `LoadScene1ButtonClicked()` / `LoadScene2ButtonClicked()` / `LoadScene3ButtonClicked()`
- All commands are sent to other connected devices (not the sender)

**UI Setup**:
- Create UI buttons in your Canvas
- Attach each button's `OnClick` event to `ControlScript` methods
- Example: Button ? OnClick ? ControlScript.StartHeartbeatButtonClicked()

---


### 3. **Utility.cs**
**Purpose**: Central registry of all networked event codes used throughout the system.

**Setup**: No setup needed—this is a static utility class automatically referenced by other scripts.

**Event Codes** (used internally):
- **Movement**: MoveLeft (1), MoveRight (2), MoveUp (3), MoveDown (4)
- **Scaling**: ScaleUp (5), ScaleDown (6)
- **Image Control**: Next (7), Previous (8)
- **Flashing**: EnableFlashing (9), DisableFlashing (23)
- **Heartbeat**: StartHeartbeat (29), StopHeartbeat (30)
- **Pricing**: RevealPrice1-5 (31-35), HideAllPrices (36)
- **Scenes**: LoadScene1 (37), LoadScene2 (38), LoadScene3 (39)
- Additional codes for FOV toggles, aspect ratios, and screen controls

---

## Scene Setup Workflow

1. **Create Control Manager**:
   - Empty GameObject named "ControlManager"
   - Add `ControlScript.cs` component

2. **Create UI Canvas** (if not exists):
   - Right-click in Hierarchy ? UI ? Canvas
   - Add buttons for each command (Heartbeat, Prices, Scene Loading)
   - Connect button OnClick events to `ControlScript` public methods

5. **Network Configuration**:
   - Verify Photon settings are configured (PhotonNetwork settings asset)
   - Ensure all connected devices use the same room name and configuration


---

## Notes

- All commands are sent to **other connected players only** (not the sender)
- Ensure all scripts are in the `Assets/Scripts/` directory for proper compilation
- The room is set to `IsVisible = false` and supports up to 4 players
- Debug logs are printed for all major events (check the Console)
