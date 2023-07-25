class Human:
    def __init__(self, name="", lastname="", age=0):
        self.__name = name
        self.__lastname = lastname
        self.__age = age
    
    def __str__(self):
        print("human str")
        return f"Name: {self.__name}, Lastname: {self.__lastname}, Age: {self.__age}"


class Employee:
    def __init__(self, name="", lastname="", age=0, workplace=""):
        self.__name = name
        self.__lastname = lastname
        self.__age = age
        self.__workplace = workplace
        
    def __str__(self):
        print("empl str")
        return f"Name: {self.__name}, Lastname: {self.__lastname}, Age: {self.__age}, Workplace: {self.__workplace}"


class Teacher(Human, Employee):
    def __init__(self, name="", lastname="", age=0, teaches=""):
        super().__init__(name, lastname, age)
        self.__teaches = teaches
    
    def __str__(self):
        print("teach str")
        return super().__str__() + f", Teaches: {self.__teaches}"
        
        
teacher1 = Teacher("Hu", "Tao", 26, "Math")
print(teacher1)