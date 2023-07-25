from abc import ABC, abstractmethod
from math import sqrt, pow, pi


class Shape3D(ABC):
    @abstractmethod
    def area_of_the_base(self):
        pass

    @abstractmethod
    def volume(self):
        pass


class Cube(Shape3D):
    def __init__(self, width, length, height):
        self.__width = width
        self.__length = length
        self.__height = height

    def area_of_the_base(self):
        return self.__width * self.__length

    def volume(self):
        return self.__width * self.__length * self.__height


class RightTriangularPyramid(Shape3D):
    def __init__(self, base_side, height):
        self.__base_side = base_side
        self.__height = height

    def area_of_the_base(self):
        return 0.5 * self.__base_side * (self.__base_side * sqrt(3) / 2)

    def volume(self):
        return (self.__height * pow(self.__base_side, 2)) / 4 * sqrt(3)


class Sphere(Shape3D):
    def __init__(self, radius):
        self.__radius = radius

    def area_of_the_base(self):
        return None

    def volume(self):
        return 4 * pi * pow(self.__radius, 2)


cube1 = Cube(4, 4, 4)
pyramid1 = RightTriangularPyramid(5, 7)
sphere1 = Sphere(3)

print(f"Cube area {cube1.area_of_the_base()}")
print(f"Cube volume {cube1.volume()}")

print(f"Pyramid area {pyramid1.area_of_the_base()}")
print(f"Pyramid volume {pyramid1.volume()}")

print(f"Sphere volume {sphere1.volume()}")