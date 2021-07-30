# Replace conditional with strategy

https://industriallogic.com/xp/refactoring/conditionalWithStrategy.html

# Pros
+ clarifies algorithms by decreasing or removing conditional logic
+ simplifies a class by moving logic variations to specific classes

# Cons
- complicates design (especially with composition)
- complicates how algorithms receive data from context

# Notes on this project
This project has two refactorings. One uses inheritance, the other composition.
The composition solution looks messy and has more files than the inheritance
solution. A confused `LoanCalcs` class was created to fill the gap of the
`CapitalStrategy` base class of the inheritance solution. `CapitalStrategy`
isn't any better - it's a mix of capital, duration and risk calculations. This
is just an example of how a complex conditional can be extracted to a strategy
pattern - not an example of the best solution design.

The tests are probably incorrect - I have no idea what loan capital or duration
is. They're just there to enforce the habit of running tests after each small
change. There's also probably enough test coverage for all loan scenarios.
