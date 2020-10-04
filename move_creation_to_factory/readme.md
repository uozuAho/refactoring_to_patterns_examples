# Move creation knowledge to factory

https://industriallogic.com/xp/refactoring/creationWithFactory.html


# Pros
+ consolidates creation logic
+ decouples client from creation logic

# Cons
- complicates a design when direct instantiation would be fine
    - ie. don't need a factory for every `new Thing()`
