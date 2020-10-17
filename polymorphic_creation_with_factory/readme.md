# Introduce polymorphic creation with factory

https://industriallogic.com/xp/refactoring/polymorphicCreationFactory.html

# Pros
+ reduces duplicated object creation
+ communicates intent of creation

# Cons
- may require unnecessary parameters to cater for some implementations

# Notes on this project

This project has two refactorings. One uses inheritance, the other composition.
Neither is necessarily better - it probably depends on what you're used to. I
find the inheritance solution hard to navigate. There aren't any tests in the
files named *test - you have to navigate to their superclass to find their
tests. On the other hand, the composition refactoring has to do runtime
activation of the class under test, which is a bit clunky. It also relies on
being able to pass the type of the class under test as a parameter to the
testing suite. This may not always be an option, depending on what language
and/or testing tools you're using.

Also note - I don't know if the composition solution actually works - I can't
get the nunit tests to run.
