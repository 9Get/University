def my_decorator(foo):
    def wrapper():
        print("Function started...")
        foo()
        print("Function finished.")
    return wrapper


def example_function():
    print("Example func!")


def __init__(self, x=0, y=0):
    self.__x = x
    self.__y = y


def __str__(self):
    return f"(X:Y)  {self.__x} : {self.__y}"

func = my_decorator(example_function)
func()
Point = type("Point", (), {"__init__" : __init__, "__str__" : __str__})
point1 = Point(2, 5)
print(point1)