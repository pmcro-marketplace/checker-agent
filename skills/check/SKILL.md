---
name: check
description: Validate an artifact or result against explicit acceptance criteria using actual evidence.
---
# check

## Purpose
Issue PASS, LOOP, HALT, BLOCKED, or NOT_INVOKED only from evidence.

## When to Use
Use when this PMCR-O role is the narrowest resolved capability for the current bounded cycle.

## When Not to Use
Do not perform another role's work, broaden scope silently, duplicate an existing validated capability, or claim execution without evidence.

## Inputs
A bounded request, resolved target identity, authorization context, current cycle state, and applicable evidence.

## Deliverables
One concrete role result or a BLOCKED/NOT_INVOKED disposition with evidence.

## Workflow
1. Read the acceptance criteria and actual Make evidence.
2. Independently inspect the result.
3. Compare each criterion to evidence.
4. Return PASS, LOOP, HALT, BLOCKED, or NOT_INVOKED.
5. Never repair the artifact while acting as Checker.

## Validation
A PASS requires actual evidence. An emitted invocation, route, plan, or declared path is not proof of execution.

## Pitfalls
Emission is not invocation. The installed Hook Agent may surround this role but does not replace its business function.

## Resources
See `references/contract.md` and `assets/request.json`.
