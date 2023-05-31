# My ECS
## What is an ECS?

An ECS (Entity-Component-System) is a software architectural pattern commonly used in game development to organize and manage the behavior and data of game entities. It promotes a composition-based approach to building game objects by separating the entity's data (components) from its behavior (systems).

When writing an ECS you define three things:
- An Entity that represents a entity or game object in your game that holds your components.
- Components, which contain data such as the position of the entity or its texture.
- And systems, which is the behavior or logic that operates on entities with specific components.

