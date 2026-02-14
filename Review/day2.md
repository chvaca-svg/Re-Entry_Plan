### Phase 2 — Evaluation Mode (Day 2)

**Strengths**
- You made explicit status-code choices for core CRUD paths.
- You recognized a missing failure path on `POST` instead of pretending it was covered.
- You intentionally constrained scope (in-memory, non-async) to keep Day 2 focused.

**Weaknesses**
- `POST` returning `204` for create is not a good REST default. Use `201 Created` (typically with created resource or `Location`).
- No input validation yet means malformed/empty values can enter the system.
- Your delete reasoning mixes uniqueness with concurrency safety. Unique ID does not remove race conditions by itself.
- Failure-mode handling is currently absent (`DB down`, save failure, exceptions).
- Complexity/scaling analysis is a current blind spot you need to close.

**Contract risk level**
- **Medium** for Day 2 stage.
- Reason: basic behavior exists, but status semantics, validation, and failure handling gaps would be flagged quickly in contract delivery.

**Perm interview risk level**
- **Medium-High** right now.
- Reason: seniors will probe HTTP semantics, failure modes, and performance reasoning; your current answers are incomplete in those areas.

**How to improve hireability (next focused moves)**
1. Fix `POST` semantics to `201 Created` and return a stable response shape.
2. Add minimal validation (`required`, length, basic null/empty checks) with clear `400` responses.
3. Define and document delete behavior for missing IDs (`404` or idempotent `204`) and stay consistent.
4. Add basic exception handling path so store failures return intentional `5xx`.
5. Practice one-line complexity answers: `GET all` is O(n), `GET by id` depends on lookup/index strategy.

**What a skeptical senior would question**
- “Why did you return `204` on create instead of `201`?”
- “What exact bad payloads are rejected, and with what response body?”
- “How do you prove delete behavior is intentional and consistent for missing IDs?”
- “What happens when persistence fails mid-request?”
- “What changes at 100k records and why?”

You’re close for Week 1 expectations. Next pass should tighten HTTP correctness and predictable error behavior.