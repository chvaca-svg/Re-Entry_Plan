# Week 1–4 Re-entry Plan (Freddy)

## Week 1

- [x] Day 1 — Boot API + GET /health (Done: API runs, returns JSON)
- [x] Day 2 — CRUD todos (Done: GET/GET{id}/POST/DELETE work + sensible status codes)
- [ ] Day 3 — Async + error handling (Done: graceful 404s, validation, async handlers)
- [ ] Day 4 — Persistence with SQLite + EF Core (Done: data persists after restart)
- [ ] Day 5 — One meaningful test (Done: one test passes)
- [ ] Day 6 — Refactor pass (Done: code reads cleanly)
- [ ] Day 7 — Verbal walkthrough notes (Done: can explain trade-offs calmly)


## Week 2 — Realistic Backend Behaviour (Hands-on Credibility)

- [ ] Day 8 — Async everywhere
  - Convert all endpoints to async
  - Use async EF Core calls
  - Remove sync leftovers
  - Done when: no blocking calls, code reads naturally async

- [ ] Day 9 — Validation + errors
  - Input validation (minimal, manual or attributes)
  - Proper HTTP responses (400/404/201)
  - Centralised error handling (simple)
  - Done when: bad input never crashes the API

- [ ] Day 10 — Auth (lightweight)
  - Add basic auth (JWT or fake token check)
  - Protect POST/DELETE
  - No roles, no permissions matrix
  - Done when: unauthenticated calls are rejected cleanly

- [ ] Day 11 — Configuration & envs
  - Use appsettings + environment overrides
  - Connection string via config
  - Done when: app runs cleanly in Dev without code changes

- [ ] Day 12 — Logging & observability (minimal)
  - Structured logging
  - Log one happy path + one failure path
  - Done when: logs tell a story during a request

- [ ] Day 13 — Small refactor
  - Clean naming
  - Extract 1–2 methods
  - Improve readability only
  - Done when: code feels calm to read

- [ ] Day 14 — Explain it
  - Write short notes: architecture, trade-offs, next steps
  - Done when: you can explain it in 5–7 minutes out loud


## Week 3 — Contract-Ready & Interview-Ready

- [ ] Day 15 — Testing (realistic)
  - Add 2–3 meaningful tests
  - Mix of integration/unit
  - Done when: tests give confidence, not coverage

- [ ] Day 16 — Data edge cases
  - Duplicate handling
  - Missing records
  - Idempotent DELETE
  - Done when: API behaves sensibly under abuse

- [ ] Day 17 — Performance basics
  - Async EF checks
  - Simple pagination on GET /todos
  - Done when: API would survive basic load

- [ ] Day 18 — Small feature
  - Add one feature (e.g. complete a todo)
  - Touch DB + API + validation
  - Done when: feature is clean and tested

- [ ] Day 19 — Code review simulation
  - Review your own code like a PR
  - Write review comments in a file
  - Done when: you’d approve it as a senior

- [ ] Day 20 — Interview walkthrough
  - Explain:
    - Why minimal API
    - Why EF Core
    - What you’d change for scale
  - Done when: no defensiveness in explanations

- [ ] Day 21 — Freeze scope
  - No new features
  - Only bug fixes
  - Done when: project feels “finished enough”


## Week 4 — CV Alignment + Market Readiness

- [ ] Day 22 — Contract CV alignment
  - Rewrite CV headline + summary for contracts
  - Reorder skills (IC first)
  - Done when: CV clearly says “hands-on”

- [ ] Day 23 — Perm CV alignment
  - Adjust summary slightly for perm roles
  - Keep same project
  - Done when: CV supports Senior/Lead IC roles

- [ ] Day 24 — Repo polish
  - README:
    - What it is
    - How to run
    - Trade-offs
  - Done when: a stranger could run it in 5 mins

- [ ] Day 25 — Mock contract screening
  - Answer:
    - “Can you start fast?”
    - “How do you handle messy code?”
  - Done when: answers are short and confident

- [ ] Day 26 — Mock perm interview
  - Answer:
    - Design trade-offs
    - Code quality
    - Team collaboration
  - Done when: no over-explaining

- [ ] Day 27 — Gap narrative
  - Write a 3–4 sentence explanation of the last year
  - Honest, calm, factual
  - Done when: it sounds boring (that’s good)

- [ ] Day 28 — Apply in anger
  - Apply to:
    - 3–5 contracts
    - 2–3 perm roles
  - Done when: applications feel low-stress


## End-state (Week 4 success criteria)

- I can open a .NET codebase without anxiety
- I can code live without freezing
- I can explain trade-offs calmly
- I have:
  - 1 solid repo
  - 1 contract CV
  - 1 perm CV
