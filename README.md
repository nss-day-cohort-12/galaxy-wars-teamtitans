# Galaxy Wars

Your job is to build some space-faring species that evolved on planets around one of five star types. Your species will compete against each other for resources in their solar system, and end up in a conflict that will be winner-take-all.

## Star Types

1. Supergiant
2. Red Giant
3. Red Dwarf
4. Black Hole
5. Twin Stars

## Requirements

1. Define 3 species that evolved on planets around your assigned star type. Each species starts with 1 million individuals.
1. Each has 10 different properties that you think would they would have evolved around that start type.
1. Each species has one of three overriding goal for their existence - space faring expansion, warfare, religion. You have 10 total points to allocate to each goal type.
1. Define a parent spacegoing vehicle class, and then four derivative types, each one can only be inhabited by one of the species.
1. Define properties for each vehicle that are appropriate to the species that can inhabit it.
1. You must use method overriding and overloading in your inheritance chain for vehicles and species.
1. You muts implement the following interfaces, but define more if you like.
    1. ISpaceFaring (interface for a space faring species)
    1. IWarrior (interface for a warmongering species)
    1. IReligious (interface for a species who reproduces quickly)
1. Species should battle each other based on the weights shown below.
1. Each year in the way, each species that battles lose population at the base rate of 20,000.
    1. ISpaceFaring species will recover a bonus of 5,000 population after each year.
    1. IWarrior species will kill an additional 10,000 of the opponent's population each year, but also lose an additional 2,500 population each year.
    1. IReligious species convert 1% of the opponent's current population to their side each year.
1. First to 0 popuation loses.

## Weighted Battles

Science beats Religion 

Religion beats Warfare

Warfare beats Science

1. Each year, determine the type (space faring, warmonger, religious) of each species.
1. Each species fights both of the other species.
1. Based on the rules above, the type that is stronger kills an additional 2% of the enemy population.
1. However, every 25 years, an anomoly causes a randomly chosen rule to completely reverse (religion beats science, etc.).

## Bonus Criteria

1. For each of the starships that you defined for the species, define small bonuses that they could provide in battle.
    1. Increased kills
    1. Increased reproducing via cloning
    1. Protection from religious telepathy
    1. etc...
