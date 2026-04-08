# Memento Pattern (Behavioral)

---

## 📌 Overview

The Memento pattern captures and restores an object's internal state without exposing its internal structure.

It is commonly used for implementing undo/redo functionality.

---

## 🧠 Intent

Save an object’s state so it can be restored later without breaking encapsulation.

---

## 🧩 Structure

* **Originator** → Creates and restores state (Editor)
* **Memento** → Stores the snapshot (nested class)
* **Caretaker** → Stores and manages snapshots (History)

---

## 🔗 Relationships

* Originator → Memento: Composition + Dependency
* Caretaker → Memento: Aggregation
* Caretaker ↔ Originator: Loosely coupled (no direct dependency)

---

## 💡 Use Cases

* Text editors (undo/redo)
* Game save systems
* Transaction rollback
* Version history tracking

---


## ⚙️ How It Works

1. The Editor creates a snapshot using `Save()`
2. The History stores the snapshot
3. The Editor restores a previous state using `Restore()`

---

## 🔐 Why Use a Nested Memento?

* Preserves encapsulation
* Prevents external access to internal state
* Ensures only the Originator can modify the snapshot

---

## 👍 Advantages

* Keeps object state encapsulated
* Simplifies undo/redo implementation
* Clean separation of responsibilities

---

## 👎 Disadvantages

* Can increase memory usage if many snapshots are stored
* Caretaker can grow large over time

---


## 📚 Summary

Use the Memento pattern when you need to:

* Save object state
* Restore it later
* Maintain encapsulation
