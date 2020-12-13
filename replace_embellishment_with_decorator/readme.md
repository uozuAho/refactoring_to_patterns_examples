# Move embellishment with decorator

https://industriallogic.com/xp/refactoring/embellishmentToDecorator.html


# Pros
+ simplifies a class by removing embellishments
+ distinguishes a class's core responsibility from its embellishments

# Cons
- changes the object identity of the decorated object
- increases complexity, harder to debug
- multiple decorators can intefere with each other
    - eg. string finder decorator -> encryption decorator -> object
        - string finder won't work on encrypted strings
