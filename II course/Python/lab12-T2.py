from abc import ABC, abstractmethod


class Transport(ABC):
    def __init__(self, max_speed=0, weight=0):
        self.__max_speed = max_speed
        self.__weight = weight

    def __str__(self):
        return f"Max speed: {self.__max_speed} km/h, Weight: {self.__weight} kg"

    @abstractmethod
    def get_brand(self):
        pass


class Car(Transport):
    def __init__(self, brand="", model="", max_speed=0, weight=0, tank_capacity=0):
        Transport.__init__(self, max_speed, weight)
        self.__brand = brand
        self.__model = model
        self.__tank_capacity = tank_capacity

    def get_brand(self):
        return self.__brand

    def __str__(self):
        return f"Brand: {self.__brand}, Model: {self.__model}, " + super().__str__() + \
               f", Tank capacity: {self.__tank_capacity} l."


class ElectricCar(Transport):
    def __init__(self, brand="", model="", max_speed=0, weight=0, battery_capacity=0, discharge_time=""):
        Transport.__init__(self, max_speed, weight)
        self.__brand = brand
        self.__model = model
        self.__battery_capacity = battery_capacity
        self.__discharge_time = discharge_time

    def get_brand(self):
        return self.__brand

    def __str__(self):
        return f"Brand: {self.__brand}, Model: {self.__model}, " + super().__str__() + \
               f", Battery capacity: {self.__battery_capacity}."


class SportCar(Car, ElectricCar):
    def __init__(self, brand="", model="", max_speed=0, weight=0, batt_tank_capacity=0):
        super().__init__(brand, model, max_speed, weight, batt_tank_capacity)

    def __str__(self):
        return super().__str__()


sport_car1 = SportCar("Mazda", "RX 7", 250, 1280, 150)