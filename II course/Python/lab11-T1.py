class Human:
    def __init__(self, surname="", sex=""):
        self.__surname = surname
        self.__sex = sex

    def get_surname(self):
        return self.__surname

    def set_surname(self, surname):
        self.__surname = surname

    @property
    def sex(self):
        return self.__sex

    @sex.setter
    def sex(self, sex):
        self.__sex = sex

    def __str__(self):
        return f"Surname: {self.__surname}  Sex: {self.__sex}"


class Participant_of_competitions(Human):
    def __init__(self, surname="", sex="", number_of_medals=0):
        Human.__init__(self, surname, sex)
        self.__number_of_medals = number_of_medals

    def get_number_of_medals(self):
        return self.__number_of_medals

    def set_number_of_medals(self, number_of_medals):
        self.__number_of_medals = number_of_medals
    number_of_medals = property(get_number_of_medals, set_number_of_medals)

    def __str__(self):
        return super().__str__() + f"  Number of medals: {self.__number_of_medals}"


class Employee(Human):
    def __init__(self, surname="", sex="", work_place=""):
        Human.__init__(self, surname, sex)
        self.__work_place = work_place

    def get_work_place(self):
        return self.__work_place

    def set_work_place(self, work_place):
        self.__work_place = work_place

    def __str__(self):
        return super().__str__() + f"  Work place: {self.__work_place}"


poc1 = Participant_of_competitions("Jo", "Male", 7)
human1 = Human("Maria", "Female")
poc2 = Participant_of_competitions("Mark")
employee1 = Employee("Den", "Male", "Microsoft")

print(poc1.get_surname())
print(human1)
print(poc1)
print(employee1)

poc_list = [Participant_of_competitions("Max", "Male", 14), Participant_of_competitions("Ellie", "Female", 15),
            Participant_of_competitions("Jon", "Male", 11)]
print("The amount of medals: " + str(sum([num.get_number_of_medals() for num in poc_list])))