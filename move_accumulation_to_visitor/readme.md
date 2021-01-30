# Move accumulation to visitor

https://www.industriallogic.com/xp/refactoring/accumulationToVisitor.html

# Pros
+ clean and efficient way to implement numerous algorithms across a
  heterogeneous set of objects
+ allows calling type-specific methods on heterogenous classes without
  type-casting

# Cons
- too complex if a common interface can be extracted from the heterogeneous
  classes
