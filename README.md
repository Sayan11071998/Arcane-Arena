# Arcane Arena

**Arcane Arena** is a turn-based strategic combat game inspired by classics like *Street Fighter*, built with Unity. It features unique heroes, impactful combat abilities, and a polished architecture leveraging the **Command Pattern** and **Service Locator Pattern**.

---

## ⚔️ Gameplay Overview

**Engage in tactical duels** with a roster of distinct heroes:

- **Wizard** – Casts powerful spells.
- **Sword Master** – Precision strikes with a katana.
- **Healer** – Supports allies and restores health.
- **Mage** – Manipulates fire for area damage.
- **Berserker** – Unleashes devastating power.

Each character features unique mechanics, allowing deep strategic combinations.

---

## 🎯 Attack Actions & Strategy

Customize your battle tactics with powerful action commands:

- **Attack Stance** – Reduces enemy attack power.
- **Berserk Attack** – Deals high-risk, high-reward damage.
- **Cleanse Attack** – Debuffs the opponent’s abilities.
- **Heal & Meditate** – Restores health and prepares for the next round.
- **Third Eye** – Fully restores health for a comeback opportunity.

These moves are implemented using modular command objects, making them easily extendable and testable.

---

## 🔧 Architecture & Design Patterns

### ✅ Command Pattern

- **Modularity**: All player actions (attack, heal, etc.) are implemented as individual command classes.
- **Undo/Redo Support**: Maintains command history using stacks for replays or reversing actions.
- **Clean Codebase**: Encapsulated commands ensure scalable and maintainable systems.

### ✅ Service Locator Pattern

- Centralized services like **Audio**, **Visual Effects**, and **Game State** are accessed via the Service Locator.
- Promotes decoupled components and clean dependency management.

---

## 🎮 Key Features

- **Turn-Based Combat**: Strategic gameplay with multiple action choices each turn.
- **Undo & Redo Mechanics**: Fix mistakes and replay sequences using command stacks.
- **Scriptable Objects**: Define heroes, abilities, and stats with Unity’s ScriptableObject system.
- **Dynamic Audio/Visual Feedback**: Synchronized effects enhance immersion and response.
- **Modular Systems**: Easily extendable for new characters, attacks, or rules.

---

## 📚 Lessons & Takeaways

- Leveraged **Command Pattern** for elegant action encapsulation and undo systems.
- Adopted **Service Locator Pattern** to manage game-wide services without tight coupling.
- Focused on **iterative development**, refining combat flow and usability through continuous feedback.
- Balanced **complex mechanics** with intuitive gameplay and a clean UI.

---

## 🛠️ Technologies Used

- **Unity 2021+**
- **C#**
- **ScriptableObjects**
- **Command & Service Locator Patterns**
- **Custom Undo System**
- **2D Art and Animation**
- **Editor Scripting for Debugging and Testing**

---

## 📬 Feedback & Collaboration

This project was a great exploration of turn-based design and architecture patterns in Unity. I’d love to hear your thoughts, ideas, or feedback.

Let’s connect if you’re into:
- Unity & Game Architecture
- Turn-Based Mechanics
- Pattern-Driven Game Design

---

## Play Link

[![Watch the video](https://img.youtube.com/vi/GDaTn24Y7bA/maxresdefault.jpg)](https://youtu.be/GDaTn24Y7bA)
### [Gameplay Video](https://youtu.be/GDaTn24Y7bA)

![Image](https://github.com/user-attachments/assets/81c32a86-9454-472a-a686-c2adf44d28b0)

![Image](https://github.com/user-attachments/assets/f251f905-ecad-44e8-a190-8dea4912bc18)

![Image](https://github.com/user-attachments/assets/9791d67b-235f-4551-aae3-de4947b31d94)

![Image](https://github.com/user-attachments/assets/6930af4e-99a4-43e0-ac2d-002efbfc57bb)

![Image](https://github.com/user-attachments/assets/8f5cc210-8318-4724-bb22-4823a21dc1c6)

![Image](https://github.com/user-attachments/assets/0757c3a9-9a2a-46b6-b3fe-459c5d9e9398)

![Image](https://github.com/user-attachments/assets/32f702c1-a468-4814-bded-9cf4bf4bee4a)
