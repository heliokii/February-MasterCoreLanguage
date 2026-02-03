# Clean Code Notes – Practical Takeaways

These are the most important lessons I've extracted from *Clean Code* by Robert C. Martin (and other related materials) that I want to actually apply in this 28-day challenge — especially in **C++ DAA**, **HTML/CSS projects**, and any Unity C# scripting.

## 1. Meaningful Names

- Use intention-revealing names → `daysRemaining` > `d`
- Pronounceable & searchable names → `calculateTaxAmount()` > `calcTx()`
- Avoid encodings: no Hungarian notation (`strName`, `iCount`), no member prefixes (`m_` unless team standard)
- Class names → Noun or Noun Phrase: `User`, `AccountService`, `PathFinder`
- Function names → Verb or Verb Phrase: `calculate`, `findShortestPath`, `renderNavigation`

## 2. Functions – Small & Do One Thing

- Rule of thumb: **< 20–30 lines** (ideally < 10–15)
- One level of abstraction per function
- Prefer **extract till you drop** refactoring style
- Ideal function: does **one thing**, well, and nothing else
- Fewer parameters better (0–2 ideal, 3+ usually smell)

## 3. Comments – Use Sparingly

Good comments explain **WHY**, not **WHAT**.

```cpp
// Bad
// increment i by 1
i++;

// Good
// We skip deleted records because they are marked with tombstone pattern

if (record.isDeleted()) continue;
