class PlanetSystem:
    def __init__(self, *planets):
        self.planetList = [Planet(planet) for planet in planets]

    def __getitem__(self, key):
        return self.planetList[key]

    def __setitem__(self, key, value):
        self.planetList[key] = value


class Planet:
    def __init__(self, name=""):
        self.__name = name

    def __repr__(self):
        return f"Planet: {self.__name}"


planet_system = PlanetSystem("Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uran", "Neptune")
[print(planet_system[i]) for i in range(7)]