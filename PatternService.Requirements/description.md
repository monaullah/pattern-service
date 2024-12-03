# Pattern Service

Specification for the great Pattern Service

## Feature: Stock

- Type (Cotton, Linen, ...)
- Length
- Width
- Colors
- Pattern
- Weaving
- Tags (Summer, Winter, ...)
- Image?

### User-scenarios

```gherkin
Feature: AddFabricToStock
	In order to keep track of fabric in my stock
	As a sewist
	I want to add fabric to the stock

Scenario: Add fabric to stock
	Given cotton poplin fabric of 240 centimeters
    And a width of 140 centimeters
    And color blue and red in stripes
	When the user adds it to the stock
	Then all provided data is reachable
```

```gherkin
Feature: UpdateExistingFabric
	In order to keep track of fabric in my stock
	As a sewist
	I want to reduce the amount of fabric in my stock

Scenario: Reduce length of fabric
	Given a fabric with a length of 340 centimeters
	When reducing by 40 centimeters in length
	Then the fabric length gets reduced accordingly

Scenario: Reduce width of fabric
	Given a fabric with a width of 120 centimeters
	When reducing by 10 centimeters in width
	Then the existing fabric width gets reduced accordingly

Scenario: Update fabric specifications
	Given an existing fabric
	When specifications are modified
	Then the existing fabric gets updated accordingly
```

```gherkin
Feature: DeleteExistingFabric
	In order to keep track of fabric in my stock
	As a sewist
	I want to remove the fabric from my stock

Scenario: Remove existing fabric
	Given an existing fabric
	When the fabric is removed
	Then the fabric is no longer available in the stock
```

## Feature: Patterns

- PDF Upload
- Fabric Requirements
  - Size (32, ..., 36, 38, ...)
  - Length
  - Width
- Addons?

### User-scenarios

```

```

## Ideas

- Be able to list all fabric options based on patterns and their size tables
- Be able to use tags and types to get recommendations
- Visulize fabrics for patterns, given a transparent PNG
- Add QR-codes to stitch along with the fabric for storage
- Pattern Marketplace $$$$
