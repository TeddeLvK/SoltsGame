# Plan for conducting all of the work.

## Fileds of work (Who does what)


1. slotMech.cs (The Engine)
---------------------------
_This file acts as the core **"brain"** of the machine. It handles the mathematical generation of results and the timing of the reels._

*   **Reel Logic:** Defines the grid dimensions (e.g., a 3×5 layout) and the order of symbols on each virtual reel strip.
*   **RNG Integration:** Generates random indices for each reel. This is the "pull" that determines what symbols are selected from the available pool.
*   **Stop Logic:** Controls the timing of when each reel stops spinning, whether they stop one by one (sequential) or all at once (simultaneous).
*   **Result Matrix:** Creates a data structure (like a 2D array) that represents the final state of the symbols on the screen to be read by the paytable.


2. symbVal.cs (The Data)
------------------------
_This file defines what a **"symbol"** is and how the game values them. It serves as the configuration layer for the game's economy._

*   **Symbol Definition:** A structure containing properties for every icon, such as a unique ID, its display name, and references to visual assets.
*   **Paytable:** A mapping system that calculates rewards based on matches. It defines what a player wins for getting 3, 4, or 5 of a specific symbol on a payline.
*   **Weighting System:** Determines the "rarity" of each symbol. By assigning different weights, you ensure that high-value symbols (like Jackpots) appear less frequently than low-value symbols (like Cherries).


3. bonus.cs (The Special Features)
----------------------------------
_This file manages game states and logic that occur outside of standard base-game spins. (will be completed if time allows it)_

*   **Free Spin Controller:** Tracks the number of remaining free rounds and applies specific multipliers to any wins occurring during this state.
*   **Scatter Logic:** Checks for "Scatter" symbols that pay out or trigger bonuses regardless of their position on a specific payline.
*   **Mini-Games:** Contains the logic for secondary interactions, such as a "Pick-a-Box" feature or a bonus prize wheel.


4. window.cs (The Interface)
----------------------------
_This handles the User Interface (UI) and visual representation, serving as the bridge between the code logic and the player._

*   **Reel Rendering:** Manages the visual "blur" or scrolling effect to simulate physical motion before displaying the final symbols.
*   **Input Handling:** Listens for player actions like clicking the "Spin" button, adjusting the bet, or toggling "Auto-play."
*   **Display Updates:** Constantly refreshes the text fields for the player’s total balance, the current bet amount, and the most recent win.
*   **Animations:** Triggers visual feedback for wins, such as symbols flashing, particle effects for "Big Wins," or screen transitions into bonus rounds.


5. sound.cs (The Audio Manager)
-------------------------------
_This manages the auditory feedback loop, which is critical for creating an engaging "casino" atmosphere._

*   **Trigger Methods:** Provides specific functions to play clips for reel stops, winning jingles, and ambient background music.
*   **Audio Priority Logic:** Ensures that important sounds (like a massive win) take priority over standard sounds (like a button click) so the audio doesn't become cluttered.
*   **Volume Control:** Provides global settings for muting the game or adjusting volume levels via the UI.


6. play.cs (The Main Class)
---------------------------
_This class serves as the entry point and primary orchestrator for the entire application._

*   **Game Starter:** Initializes all other classes (Engine, UI, Sound) and ensures they are ready to communicate with each other.
*   **Game Loop Orchestration:** Manages the sequence of events: checking the balance → starting the spin →generating results → playing animations → updating the final balance.